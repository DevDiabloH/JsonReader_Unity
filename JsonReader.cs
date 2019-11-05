using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class JsonReader
{
    private static string jsonString;  // json data

    public static T JsonParser<T>(string _filename)
    {
        string path = Application.streamingAssetsPath + "/" + _filename + ".json";
        return JsonUtility.FromJson<T>(File.ReadAllText(path));
    }

    #region Example
    public static void Example()
    {
        YourClass instance = JsonParser<YourClass>("YourJson");
        Debug.log(JsonUtility.ToJson(instance));
    }

    [Serializable]
    public class YourClass
    {
        public string yourString;
        public int yourInt;
    }
    #endregion
}
