using System.Collections;
using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
//注册器
//注册全局的格子类型,敌方类型等...
//注意,未来会对注册器启用类似矿物词典类的东西

namespace PVZGDFrame
{
    using StringDictionary = Dictionary<String, String>;
    public partial class Register
    {
        /// <summary>
        /// 注册总列表
        /// </summary>
        public Dictionary<String, ArrayList> RegistedDictionary = new Dictionary<string, ArrayList>();
        /// <summary>
        ///构造函数
        /// </summary>
        public Register()
        {
            Debug.Out("Regist all information now.");

            Debug.Out("Regist Vanilla GridType now...");
            DoRegistVanilla();
            PrintAllRegisted();
            Debug.Out("Registe finished.");
        }
        /// <summary>
        /// 注册一个类型,返回此类型id,失败为-1,一般原因为重名
        /// </summary>
        public int Regist(String type, String name, StringDictionary content)
        {
            StringDictionary dic = new StringDictionary();
            dic.Add("Name", name);
            dic.Union(content).ToDictionary(k => k.Key, v => v.Value);
            Debug.Out<String, String>(dic);
            RegistedDictionary[type].Add(dic);
            return RegistedDictionary[type].Count - 1;
        }
        /// <summary>
        /// 注册一个可以被注册的类型...(返回是否成功,一般为否的原因是已被注册)
        /// <summary>
        public bool RegistRegistType(String name)
        {
            if (!RegistedDictionary.ContainsKey(name))
            {
                RegistedDictionary.Add(name, new ArrayList());
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintAllRegisted()
        {
            Debug.Out<String, ArrayList>(RegistedDictionary);
        }
    }
}