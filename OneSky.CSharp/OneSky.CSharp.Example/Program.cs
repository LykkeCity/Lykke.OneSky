using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Lykke.OneSky.Json;
using Newtonsoft.Json;

namespace OneSky.CSharp.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var oneskyClient = Lykke.OneSky.Json.OneSkyClient.CreateClient(
                "0HVWy7Z8imDqm4hTKmGdqCqqrLvhzJPq", "Rctn51ldJlxEi9B1GPeWDe6m9Zvf0YoI");


            // grt groups
            var groupList = oneskyClient.Platform.ProjectGroup.List();
            //Console.WriteLine($"Group list code={groupList.StatusCode}, discr={groupList.StatusDescription}, meta_count_page={groupList.Meta.PageCount}");
            Console.WriteLine("Group list");
            foreach (var group in groupList.Data)
            {
                Console.WriteLine($"  {group.Id}: {group.Name}");
                var projects = oneskyClient.Platform.Project.List(group.Id);

                Console.WriteLine("  projects:");
                //Console.WriteLine($"    Group list code={projects.StatusCode}, discr={projects.StatusDescription}, meta_count={projects.Meta.RecordCount}");
                foreach (var project in projects.Data)
                {
                    Console.WriteLine($"    {project.Id}: {project.Name}");

                    Console.WriteLine("      languages:");
                    var langs = oneskyClient.Platform.Project.Languages(project.Id);
                    foreach (var lang in langs.Data)
                    {
                        Console.WriteLine($"        {lang.EnglishName}; {lang.Code}; {lang.TranslationProgress}%");
                    }

                    Console.WriteLine("      files:");
                    var files = oneskyClient.Platform.File.List(project.Id);
                    foreach (var file in files.Data)
                    {
                        Console.WriteLine($"        {file.Name}; {file.StringCount}");

                        foreach (var lang in langs.Data.Select(e => e.Code))
                        {
                            var datajson = oneskyClient.Platform.Translation.Export(project.Id, lang, file.Name);
                            if (string.IsNullOrEmpty(datajson.Data)) continue;
                            var data = JsonConvert.DeserializeObject<Dictionary<string, string>>(datajson.Data);
                            Console.WriteLine($"{file.Name}.{lang}");
                            Console.WriteLine("--------------------------------");
                            foreach (var kv in data)
                            {
                                Console.WriteLine($"{kv.Key}\t: {kv.Value}");
                            }
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine();

                        }

                    }

                }
            }

            //135910

            UploadFile(oneskyClient);

            //get projects

        }

        private static void UploadFile(IOneSkyClient oneskyClient)
        {
            var projectId = 135910;
            var file = "test.en.json";
            var locale = "en-US";
            var fileJson = oneskyClient.Platform.Translation.Export(projectId, locale, file).Data;
            if (!string.IsNullOrEmpty(fileJson))
            {
                var data = JsonConvert.DeserializeObject<Dictionary<string, string>>(fileJson);
                while (data.Count > 10)
                {
                    data.Remove(data.Keys.Last());
                }

                var lastkey = data.Keys.Last();
                data[$"{lastkey}_{data.Count}"] = $"Hello world at {data.Count}";

                fileJson = JsonConvert.SerializeObject(data);
                if (File.Exists(file)) File.Delete(file);
                var writer = new StreamWriter(file);
                writer.WriteLineAsync(fileJson);
                writer.Dispose();

                var res = oneskyClient.Platform.File.Upload(projectId, file, "HIERARCHICAL_JSON", locale);
                if (File.Exists(file)) File.Delete(file);
                Console.WriteLine($"inport: {res.StatusCode} {res.StatusDescription} {res.Meta.Message}");
            }
        }
    }
}
