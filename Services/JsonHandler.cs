using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using TagTool.Models;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace TagTool.Services
{
    public class JsonHandler
    {
        public static void JsonTest()
        {
            var device = new FunctionBlock
            {
                Name = "Device",
                Description = "On/Off Device 2 Directions",
                Size = 30
            };
            var servo = new FunctionBlock
            {
                Name = "Servo",
                Description = "Servo Control Base Fb",
                Size = 150
            };

            var fbs = new List<FunctionBlock>();
            fbs.Add(device);
            fbs.Add(servo);

            string jsonString = JsonSerializer.Serialize(fbs);
            Debug.WriteLine(jsonString);

            List<FunctionBlock> fbsRead = JsonSerializer.Deserialize<List<FunctionBlock>>(jsonString);


        }

        public static List<FunctionBlock> DeserializeLibrary(string filepath)
        {

            string jsonString = File.ReadAllText(filepath);
            List<FunctionBlock> fbs = JsonSerializer.Deserialize<List<FunctionBlock>>(jsonString);
            return fbs;
        }

        public static void SerializeLibrary(List<FunctionBlock> fbs,string filepath)
        {
            string jsonString = JsonSerializer.Serialize(fbs);
            File.WriteAllText(filepath, jsonString);
        }

    }
}
