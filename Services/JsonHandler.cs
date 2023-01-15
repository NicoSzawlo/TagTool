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
        public static List<FunctionBlock> DeserializeLibrary(string filepath)
        {
            List<FunctionBlock> fbs = new List<FunctionBlock>();
            try
            {
                string jsonString = File.ReadAllText(filepath);
                fbs = JsonSerializer.Deserialize<List<FunctionBlock>>(jsonString);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            
            return fbs;
        }

        public static void SerializeLibrary(List<FunctionBlock> fbs,string filepath)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(fbs);
                File.WriteAllText(filepath, jsonString);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            
        }

    }
}
