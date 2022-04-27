using System.Collections.Generic;
using System;
using Godot;
using Newtonsoft.Json;
namespace PVZGDFrame
{
    static class Debug
    {
        static public void Out(String text)
        {
            GD.Print("[Info]",text);
        }
        static public void Out<T1,T2>(Dictionary<T1,T2> dic)
        {
            Out(DictionaryToJson<T1,T2>(dic));
        }
        static public string DictionaryToJson<T1,T2>(Dictionary<T1,T2> myDic) 
        {
            string jsonStr = JsonConvert.SerializeObject(myDic);
            return jsonStr;
        }
    }
}