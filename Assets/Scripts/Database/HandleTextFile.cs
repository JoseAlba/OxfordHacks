using UnityEngine;
using UnityEditor;
using System.IO;

namespace Database{
    public class HandleTextFile
    {
        // private static string path = "Assets/Scripts/Database/bills.json";
        // [MenuItem("Tools/Write file")]
        // public static void WriteString(){
        //     //Write some text to the test.txt file
        //     StreamWriter writer = new StreamWriter(path, true);
        //     writer.WriteLine("Test");
        //     writer.Close();

        //     //Re-import the file to update the reference in the editor
        //     AssetDatabase.ImportAsset(path); 
        //     TextAsset asset = Resources.Load("test");

        //     //Print the text from the file
        //     Debug.Log(asset.text);
        // }

        [MenuItem("Tools/Read file")]
        public static void ReadString(){
            string path = "Assets/Scripts/Database/bills.json";

            //Read the text from directly from the test.txt file
            StreamReader reader = new StreamReader(path); 
            Debug.Log(reader.ReadToEnd());
            reader.Close();
        }

    }
}