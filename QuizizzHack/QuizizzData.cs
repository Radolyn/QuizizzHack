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

        [JsonProperty("country")] public object Country { get; set; }

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
        [JsonProperty("traits")] public Traits Traits { get; set; }

        [JsonProperty("pref")] public Pref Pref { get; set; }

        [JsonProperty("lang")] public string Lang { get; set; }

        [JsonProperty("visibility")] public bool Visibility { get; set; }

        [JsonProperty("questions")] public List<Question> Questions { get; set; }

        [JsonProperty("subjects")] public List<string> Subjects { get; set; }

        [JsonProperty("topics")] public List<string> Topics { get; set; }

        [JsonProperty("subtopics")] public List<object> Subtopics { get; set; }

        [JsonProperty("grade")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> Grade { get; set; }

        [JsonProperty("gradeLevel")] public object GradeLevel { get; set; }

        [JsonProperty("deleted")] public bool Deleted { get; set; }

        [JsonProperty("standards")] public List<object> Standards { get; set; }

        [JsonProperty("courses")] public List<Course> Courses { get; set; }

        [JsonProperty("_id")] public string Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("createdAt")] public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated")] public DateTimeOffset Updated { get; set; }

        [JsonProperty("qm")] public Dictionary<string, Pref> Qm { get; set; }

        [JsonProperty("image")] public Uri Image { get; set; }

        [JsonProperty("isProfane")] public bool IsProfane { get; set; }

        [JsonProperty("whitelisted")] public bool Whitelisted { get; set; }
    }

    public class Course
    {
        [JsonProperty("displayName")] public string DisplayName { get; set; }

        [JsonProperty("internalName")] public string InternalName { get; set; }

        [JsonProperty("description")] public object Description { get; set; }

        [JsonProperty("defaultGrade")] public object DefaultGrade { get; set; }

        [JsonProperty("lowerGrade")] public long LowerGrade { get; set; }

        [JsonProperty("upperGrade")] public long UpperGrade { get; set; }

        [JsonProperty("_id")] public string Id { get; set; }

        [JsonProperty("uniqueName")] public string UniqueName { get; set; }

        [JsonProperty("internal")] public bool Internal { get; set; }

        [JsonProperty("subject")] public long Subject { get; set; }

        [JsonProperty("createdAt")] public DateTimeOffset CreatedAt { get; set; }
    }

    public class Pref
    {
        [JsonProperty("time")] public long? Time { get; set; }
    }

    public class Question
    {
        [JsonProperty("type")] public KindEnum Type { get; set; }

        [JsonProperty("published")] public bool Published { get; set; }

        [JsonProperty("structure")] public Structure Structure { get; set; }

        [JsonProperty("standards")] public List<object> Standards { get; set; }

        [JsonProperty("_id")] public string Id { get; set; }

        [JsonProperty("createdAt")] public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated")] public DateTimeOffset Updated { get; set; }

        [JsonProperty("time")] public long Time { get; set; }

        [JsonProperty("cached", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cached { get; set; }
    }

    public class Structure
    {
        [JsonProperty("kind")] public KindEnum Kind { get; set; }

        [JsonProperty("query")] public Query Query { get; set; }

        [JsonProperty("options")] public List<Query> Options { get; set; }

        [JsonProperty("answer")] public Answer Answer { get; set; }

        [JsonProperty("settings")] public Settings Settings { get; set; }

        [JsonProperty("hasMath")] public bool? HasMath { get; set; }
    }

    public class Query
    {
        [JsonProperty("math", NullValueHandling = NullValueHandling.Ignore)]
        public Math Math { get; set; }

        [JsonProperty("type")] public QueryType? Type { get; set; }

        [JsonProperty("hasMath")] public bool HasMath { get; set; }

        [JsonProperty("media")] public List<Media> Media { get; set; }

        [JsonProperty("text")] public string Text { get; set; }
    }

    public class Math
    {
        [JsonProperty("latex")] public List<object> Latex { get; set; }

        [JsonProperty("template")] public object Template { get; set; }
    }

    public class Media
    {
        [JsonProperty("type")] public MediaType Type { get; set; }

        [JsonProperty("url")] public Uri Url { get; set; }

        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public MediaMeta Meta { get; set; }
    }

    public class MediaMeta
    {
        [JsonProperty("width")] public long Width { get; set; }

        [JsonProperty("height")] public long Height { get; set; }

        [JsonProperty("text")] public object Text { get; set; }

        [JsonProperty("bgColor")] public object BgColor { get; set; }
    }

    public class Settings
    {
        [JsonProperty("hasCorrectAnswer")] public bool HasCorrectAnswer { get; set; }
    }

    public class Traits
    {
        [JsonProperty("isQuizWithoutCorrectAnswer")]
        public bool IsQuizWithoutCorrectAnswer { get; set; }
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

    public enum KindEnum
    {
        Blank,
        Mcq,
        Msq
    }

    public enum MediaType
    {
        Image
    }

    public enum QueryType
    {
        Text,
        TextImage
    }

    public struct Answer
    {
        public long? Integer;
        public List<long> IntegerArray;

        public static implicit operator Answer(long Integer)
        {
            return new Answer {Integer = Integer};
        }

        public static implicit operator Answer(List<long> IntegerArray)
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
                KindEnumConverter.Singleton,
                MediaTypeConverter.Singleton,
                QueryTypeConverter.Singleton,
                new IsoDateTimeConverter {DateTimeStyles = DateTimeStyles.AssumeUniversal}
            },
        };
    }

    internal class DecodeArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(List<long>);
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

            return value;
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (List<long>) untypedValue;
            writer.WriteStartArray();
            foreach (var arrayItem in value)
            {
                var converter = ParseStringConverter.Singleton;
                converter.WriteJson(writer, arrayItem, serializer);
            }

            writer.WriteEndArray();
        }

        public static readonly DecodeArrayConverter Singleton = new DecodeArrayConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
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

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class AnswerConverter : JsonConverter
    {
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
                    var arrayValue = serializer.Deserialize<List<long>>(reader);
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

        public static readonly AnswerConverter Singleton = new AnswerConverter();
    }

    internal class KindEnumConverter : JsonConverter
    {
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
                case "BLANK":
                    return KindEnum.Blank;
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
                case KindEnum.Blank:
                    serializer.Serialize(writer, "BLANK");
                    return;
                case KindEnum.Mcq:
                    serializer.Serialize(writer, "MCQ");
                    return;
                case KindEnum.Msq:
                    serializer.Serialize(writer, "MSQ");
                    return;
            }

            throw new Exception("Cannot marshal type KindEnum");
        }

        public static readonly KindEnumConverter Singleton = new KindEnumConverter();
    }

    internal class MediaTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(MediaType) || t == typeof(MediaType?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "image") return MediaType.Image;
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
            if (value == MediaType.Image)
            {
                serializer.Serialize(writer, "image");
                return;
            }

            throw new Exception("Cannot marshal type MediaType");
        }

        public static readonly MediaTypeConverter Singleton = new MediaTypeConverter();
    }

    internal class QueryTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(QueryType) || t == typeof(QueryType?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "text":
                    return QueryType.Text;
                case "text-image":
                    return QueryType.TextImage;
            }

            throw new Exception("Cannot unmarshal type QueryType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (QueryType) untypedValue;
            switch (value)
            {
                case QueryType.Text:
                    serializer.Serialize(writer, "text");
                    return;
                case QueryType.TextImage:
                    serializer.Serialize(writer, "text-image");
                    return;
            }

            throw new Exception("Cannot marshal type QueryType");
        }

        public static readonly QueryTypeConverter Singleton = new QueryTypeConverter();
    }
}