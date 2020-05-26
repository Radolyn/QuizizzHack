#region

using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using RadLibrary.Logging;
using RadLibrary.Logging.InputExtension;

#endregion

namespace QuizizzHack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var logger = LoggerUtils.GetLogger("QuizizzHack");

            LoggerUtils.PrintSystemInformation();
            LoggerUtils.RegisterExceptionHandler();

            if (File.Exists("answers.txt"))
                File.Delete("answers.txt");

            var id = logger.GetInput("Quizizz id:");

            var wc = new WebClient();

            var jsonData = wc.DownloadString("https://quizizz.com/quiz/" + id);

            var data = QuizizzData.FromJson(jsonData);

            if (!data.Success)
            {
                logger.Error("Failed to fetch data from quizizz!");
                Environment.Exit(-1);
            }

            logger.Success("Data fetched successfully!");

            var quizData = $"Quiz name: {data.Data.Quiz.Info.Name}\nLast update date: {data.Data.Quiz.Info.Updated}";
            var creatorInfo =
                $"Creator username: {data.Data.Quiz.CreatedBy.Local.CasedUsername}\nName: {data.Data.Quiz.CreatedBy.FirstName + " " + data.Data.Quiz.CreatedBy.LastName}";
            var playedTimes = $"Times played: {data.Data.Quiz.Stats.Played} ({data.Data.Quiz.Stats.TotalPlayers})";
            var totalQuestions = "\n\nTotal questions: {0}";

            logger.Info(quizData);
            logger.Info(creatorInfo);
            logger.Info(playedTimes);

            File.AppendAllText("answers.txt", quizData + "\n" + creatorInfo + "\n\n\nAnswers:\n\n\n");

            logger.Warn("\n\nPrinting answers...\n\n");

            var re = new Regex(@"<[/\w]+>");

            var i = 0;

            foreach (var question in data.Data.Quiz.Info.Questions)
            {
                var q = re.Replace(question.Structure.Query.Text, "");
                var b = new StringBuilder();
                if (question.Structure.Answer.IntegerArray?.Any() == true)
                {
                    var end = question.Structure.Answer.IntegerArray.LastOrDefault();
                    foreach (var l in question.Structure.Answer.IntegerArray)
                    {
                        b.Append(question.Structure.Options[(int) l].Text);
                        if (l != end)
                            b.Append(", ");
                    }
                }
                else
                {
                    b.Append(question.Structure.Settings.HasCorrectAnswer
                        ? question.Structure.Options[(int) (question.Structure.Answer.Integer ?? 0)].Text
                        : "no correct answer");
                }

                var ans = re.Replace(b.ToString(),
                    "");
                var str = ">>> " + q + " <<< === >>> " + ans + " <<<";
                logger.Info(str);
                File.AppendAllText("answers.txt", str + "\n");
                ++i;
            }

            totalQuestions = string.Format(totalQuestions, i);

            File.AppendAllText("answers.txt", totalQuestions);

            logger.Warn("\n{0}\n\n\nEverything is done!", totalQuestions);
        }
    }
}