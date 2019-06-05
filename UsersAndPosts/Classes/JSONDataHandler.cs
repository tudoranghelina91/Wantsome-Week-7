using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.IO;
using System.Reflection;

namespace UsersAndPosts.Classes
{
    public class JSONDataHandler
    {
        public static List<T> ReadFrom<T>(string fileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            return ReadFrom<List<T>>(assembly.GetManifestResourceStream($"UsersAndPosts.JSONData.{fileName}"));
        }

        private static T ReadFrom<T>(Stream stream)
        {
            using (stream)
            using (var reader = new StreamReader(stream ?? throw new InvalidOperationException()))
            {
                var text = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(
                    text,
                    new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            }
        }
    }
}
