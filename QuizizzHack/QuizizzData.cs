//    using QuizizzHack;
//
//    var quizizzData = QuizizzData.FromJson(jsonString);

#region

using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

#endregion

namespace QuizizzHack
{
    public partial class QuizizzData
    {
        [JsonProperty("success")] public bool Success { get; set; }

        [JsonProperty("message")] public string Message { get; set; }

        [JsonProperty("data")] public Data Data { get; set; }

        [JsonProperty("meta")] public QuizizzDataMeta Meta { get; set; }
    }

    public class Data
    {
        [JsonProperty("quiz")] public Quiz Quiz { get; set; }

        [JsonProperty("draft")] public object Draft { get; set; }
    }

    public class Quiz
    {
        [JsonProperty("isTagged")] public bool IsTagged { get; set; }

        [JsonProperty("isLoved")] public bool IsLoved { get; set; }

        [JsonProperty("stats")] public Stats Stats { get; set; }

        [JsonProperty("love")] public long Love { get; set; }

        [JsonProperty("cloned")] public bool Cloned { get; set; }

        [JsonProperty("parentDetail")] public object ParentDetail { get; set; }

        [JsonProperty("deleted")] public bool Deleted { get; set; }

        [JsonProperty("draftVersion")] public object DraftVersion { get; set; }

        [JsonProperty("publishedVersion")] public string PublishedVersion { get; set; }

        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("_id")] public string Id { get; set; }

        [JsonProperty("info")] public Info Info { get; set; }

        [JsonProperty("createdBy")] public CreatedBy CreatedBy { get; set; }

        [JsonProperty("createdAt")] public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated")] public DateTimeOffset Updated { get; set; }

        [JsonProperty("hasPublishedVersion")] public bool HasPublishedVersion { get; set; }

        [JsonProperty("hasDraftVersion")] public bool HasDraftVersion { get; set; }
    }

    public class CreatedBy
    {
        [JsonProperty("local")] public Local Local { get; set; }

        [JsonProperty("google")] public Google Google { get; set; }

        [JsonProperty("student")] public object Student { get; set; }

        [JsonProperty("deactivated")] public bool Deactivated { get; set; }

        [JsonProperty("deleted")] public bool Deleted { get; set; }

        [JsonProperty("_id")] public string Id { get; set; }

        [JsonProperty("country")] public string Country { get; set; }

        [JsonProperty("media")] public Uri Media { get; set; }

        [JsonProperty("firstName")] public string FirstName { get; set; }

        [JsonProperty("lastName")] public string LastName { get; set; }

        [JsonProperty("occupation")] public string Occupation { get; set; }

        [JsonProperty("id")] public string CreatedById { get; set; }
    }

    public class Google
    {
        [JsonProperty("createdAt")] public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("profileId")] public string ProfileId { get; set; }

        [JsonProperty("email")] public string Email { get; set; }

        [JsonProperty("displayName")] public string DisplayName { get; set; }

        [JsonProperty("firstName")] public string FirstName { get; set; }

        [JsonProperty("lastName")] public string LastName { get; set; }

        [JsonProperty("image")] public Uri Image { get; set; }
    }

    public class Local
    {
        [JsonProperty("username")] public string Username { get; set; }

        [JsonProperty("casedUsername")] public string CasedUsername { get; set; }
    }

    public class Info
    {
        [JsonProperty("_id")] public string Id { get; set; }

        [JsonProperty("traits")] public Traits Traits { get; set; }

        [JsonProperty("pref")] public Pref Pref { get; set; }

        [JsonProperty("lang")] public string Lang { get; set; }

        [JsonProperty("visibility")] public bool Visibility { get; set; }

        [JsonProperty("questions")] public Question[] Questions { get; set; }

        [JsonProperty("subjects")] public string[] Subjects { get; set; }

        [JsonProperty("topics")] public object[] Topics { get; set; }

        [JsonProperty("subtopics")] public object[] Subtopics { get; set; }

        [JsonProperty("grade")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public long[] Grade { get; set; }

        [JsonProperty("gradeLevel")] public object GradeLevel { get; set; }

        [JsonProperty("deleted")] public bool Deleted { get; set; }

        [JsonProperty("standards")] public object[] Standards { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("createdAt")] public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated")] public DateTimeOffset Updated { get; set; }

        [JsonProperty("qm")] public Dictionary<string, Pref> Qm { get; set; }

        [JsonProperty("image")] public Uri Image { get; set; }

        [JsonProperty("profane")] public bool Profane { get; set; }

        [JsonProperty("isProfane")] public bool IsProfane { get; set; }

        [JsonProperty("whitelisted")] public bool Whitelisted { get; set; }

        [JsonProperty("cached")] public bool Cached { get; set; }

        [JsonProperty("courses")] public object[] Courses { get; set; }
    }

    public class Pref
    {
        [JsonProperty("time")] public long? Time { get; set; }
    }

    public class Question
    {
        [JsonProperty("_id")] public string Id { get; set; }

        [JsonProperty("type")] public KindEnum Type { get; set; }

        [JsonProperty("published")] public bool Published { get; set; }

        [JsonProperty("structure")] public Structure Structure { get; set; }

        [JsonProperty("standards")] public object[] Standards { get; set; }

        [JsonProperty("topics")] public object[] Topics { get; set; }

        [JsonProperty("createdAt")] public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated")] public DateTimeOffset Updated { get; set; }

        [JsonProperty("cached")] public bool Cached { get; set; }

        [JsonProperty("time")] public long Time { get; set; }
    }

    public class Structure
    {
        [JsonProperty("settings")] public Settings Settings { get; set; }

        [JsonProperty("explain", NullValueHandling = NullValueHandling.Ignore)]
        public Explain Explain { get; set; }

        [JsonProperty("kind")] public KindEnum Kind { get; set; }

        [JsonProperty("query")] public Explain Query { get; set; }

        [JsonProperty("options")] public Explain[] Options { get; set; }

        [JsonProperty("answer")] public Answer Answer { get; set; }

        [JsonProperty("hasMath", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMath { get; set; }
    }

    public class Explain
    {
        [JsonProperty("math", NullValueHandling = NullValueHandling.Ignore)]
        public Math Math { get; set; }

        [JsonProperty("type")] public MediaType? Type { get; set; }

        [JsonProperty("hasMath")] public bool? HasMath { get; set; }

        [JsonProperty("text")] public string Text { get; set; }

        [JsonProperty("media")] public Media[] Media { get; set; }
    }

    public class Math
    {
        [JsonProperty("latex")] public object[] Latex { get; set; }

        [JsonProperty("template")] public object Template { get; set; }
    }

    public class Media
    {
        [JsonProperty("type")] public MediaType Type { get; set; }

        [JsonProperty("url")] public Uri Url { get; set; }

        [JsonProperty("meta")] public MediaMeta Meta { get; set; }
    }

    public class MediaMeta
    {
        [JsonProperty("width")] public long Width { get; set; }

        [JsonProperty("height")] public long Height { get; set; }

        [JsonProperty("text")] public object Text { get; set; }

        [JsonProperty("bgColor")] public object BgColor { get; set; }

        [JsonProperty("layout")] public object Layout { get; set; }

        [JsonProperty("videoId")] public object VideoId { get; set; }

        [JsonProperty("start")] public object Start { get; set; }

        [JsonProperty("end")] public object End { get; set; }

        [JsonProperty("duration")] public object Duration { get; set; }
    }

    public class Settings
    {
        [JsonProperty("hasCorrectAnswer")] public bool HasCorrectAnswer { get; set; }
    }

    public class Traits
    {
        [JsonProperty("isQuizWithoutCorrectAnswer")]
        public bool IsQuizWithoutCorrectAnswer { get; set; }

        [JsonProperty("totalSlides")] public long TotalSlides { get; set; }
    }

    public class Stats
    {
        [JsonProperty("played")] public long Played { get; set; }

        [JsonProperty("totalPlayers")] public long TotalPlayers { get; set; }

        [JsonProperty("totalCorrect")] public long TotalCorrect { get; set; }

        [JsonProperty("totalQuestions")] public long TotalQuestions { get; set; }
    }

    public class QuizizzDataMeta
    {
        [JsonProperty("service")] public string Service { get; set; }

        [JsonProperty("version")] public string Version { get; set; }
    }

    public enum MediaType
    {
        Image,
        Text
    }

    public enum KindEnum
    {
        Mcq,
        Msq
    }

    public struct Answer
    {
        public long? Integer;
        public long[] IntegerArray;

        public static implicit operator Answer(long Integer)
        {
            return new Answer {Integer = Integer};
        }

        public static implicit operator Answer(long[] IntegerArray)
        {
            return new Answer {IntegerArray = IntegerArray};
        }
    }

    public partial class QuizizzData
    {
        public static QuizizzData FromJson(string json)
        {
            return JsonConvert.DeserializeObject<QuizizzData>(json, Converter.Settings);
        }
    }

    public static class Serialize
    {
        public static string ToJson(this QuizizzData self)
        {
            return JsonConvert.SerializeObject(self, Converter.Settings);
        }
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                AnswerConverter.Singleton,
                MediaTypeConverter.Singleton,
                KindEnumConverter.Singleton,
                new IsoDateTimeConverter {DateTimeStyles = DateTimeStyles.AssumeUniversal}
            },
        };
    }

    internal class DecodeArrayConverter : JsonConverter
    {
        public static readonly DecodeArrayConverter Singleton = new DecodeArrayConverter();

        public override bool CanConvert(Type t)
        {
            return t == typeof(long[]);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            reader.Read();
            var value = new List<long>();
            while (reader.TokenType != JsonToken.EndArray)
            {
                var converter = ParseStringConverter.Singleton;
                var arrayItem = (long) converter.ReadJson(reader, typeof(long), null, serializer);
                value.Add(arrayItem);
                reader.Read();
            }

            return value.ToArray();
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (long[]) untypedValue;
            writer.WriteStartArray();
            foreach (var arrayItem in value)
            {
                var converter = ParseStringConverter.Singleton;
                converter.WriteJson(writer, arrayItem, serializer);
            }

            writer.WriteEndArray();
        }
    }

    internal class ParseStringConverter : JsonConverter
    {
        public static readonly ParseStringConverter Singleton = new ParseStringConverter();

        public override bool CanConvert(Type t)
        {
            return t == typeof(long) || t == typeof(long?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (long.TryParse(value, out l)) return l;
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (long) untypedValue;
            serializer.Serialize(writer, value.ToString());
        }
    }

    internal class AnswerConverter : JsonConverter
    {
        public static readonly AnswerConverter Singleton = new AnswerConverter();

        public override bool CanConvert(Type t)
        {
            return t == typeof(Answer) || t == typeof(Answer?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new Answer {Integer = integerValue};
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<long[]>(reader);
                    return new Answer {IntegerArray = arrayValue};
            }

            throw new Exception("Cannot unmarshal type Answer");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Answer) untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }

            if (value.IntegerArray != null)
            {
                serializer.Serialize(writer, value.IntegerArray);
                return;
            }

            throw new Exception("Cannot marshal type Answer");
        }
    }

    internal class MediaTypeConverter : JsonConverter
    {
        public static readonly MediaTypeConverter Singleton = new MediaTypeConverter();

        public override bool CanConvert(Type t)
        {
            return t == typeof(MediaType) || t == typeof(MediaType?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "image":
                    return MediaType.Image;
                case "text":
                    return MediaType.Text;
            }

            throw new Exception("Cannot unmarshal type MediaType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (MediaType) untypedValue;
            switch (value)
            {
                case MediaType.Image:
                    serializer.Serialize(writer, "image");
                    return;
                case MediaType.Text:
                    serializer.Serialize(writer, "text");
                    return;
            }

            throw new Exception("Cannot marshal type MediaType");
        }
    }

    internal class KindEnumConverter : JsonConverter
    {
        public static readonly KindEnumConverter Singleton = new KindEnumConverter();

        public override bool CanConvert(Type t)
        {
            return t == typeof(KindEnum) || t == typeof(KindEnum?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "MCQ":
                    return KindEnum.Mcq;
                case "MSQ":
                    return KindEnum.Msq;
            }

            throw new Exception("Cannot unmarshal type KindEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (KindEnum) untypedValue;
            switch (value)
            {
                case KindEnum.Mcq:
                    serializer.Serialize(writer, "MCQ");
                    return;
                case KindEnum.Msq:
                    serializer.Serialize(writer, "MSQ");
                    return;
            }

            throw new Exception("Cannot marshal type KindEnum");
        }
    }
}