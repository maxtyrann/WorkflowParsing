using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;
using WorkflowParsing.Configuration;

namespace WorkflowParsing
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var jsonFile = Path.Combine(Environment.CurrentDirectory, @"Samples/FinalSampleWithoutComments.json");
            var jsonFileText = await File.ReadAllTextAsync(jsonFile);

            Workflow workflow = JsonConvert.DeserializeObject<Workflow>(jsonFileText);
            string jsonContent = JsonConvert.SerializeObject(workflow, Formatting.Indented);

            var outputFilePath = Path.Combine(Environment.CurrentDirectory, @"Output/FinalSampleWithoutCommentsOutput.json");
            await File.WriteAllTextAsync(outputFilePath, jsonContent, encoding: System.Text.Encoding.UTF8);

            Workflow workflowRecreated = JsonConvert.DeserializeObject<Workflow>(jsonContent);

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
