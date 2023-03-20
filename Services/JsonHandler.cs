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
        //Load library json file from a filepath and return list of functionblocks
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
        //Save list of functionblocks to library json file
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

        //Load library json file from a filepath and return list of functionblocks
        public static List<Component> DeserializeComponentList(string filepath)
        {
            List<Component> components = new List<Component>();
            try
            {
                string jsonString = File.ReadAllText(filepath);
                components = JsonSerializer.Deserialize<List<Component>>(jsonString);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return components;
        }
        //Save list of functionblocks to library json file
        public static void SerializeComponentList(List<Component> components, string filepath)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(components);
                File.WriteAllText(filepath, jsonString);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        //Load library json file from a filepath and return list of functionblocks
        public static Project DeserializeProject(string filepath)
        {
            Project proj = new Project();
            try
            {
                string jsonString = File.ReadAllText(filepath);
                proj = JsonSerializer.Deserialize<Project>(jsonString);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return proj;
        }
        //Save list of functionblocks to library json file
        public static void SerializeProject(Project proj, string filepath)
        {
            try
            {
                File.Delete(filepath);
                string jsonString = JsonSerializer.Serialize(proj);
                File.WriteAllText(filepath, jsonString);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

    }
}
