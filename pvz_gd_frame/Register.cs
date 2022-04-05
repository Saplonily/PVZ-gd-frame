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
    class Register
    {
        //注册总列表
        public Dictionary<String, ArrayList> RegistedDictionary = new Dictionary<string, ArrayList>();
        public Register()
        {
            Debug.Out("Regist all information now.");
            DoRegistGridTypeVanilla();
            //这里会放置一个函数API用于注册mod物品
            //注册成功返回一个id,为全局id,用于填充于RegistedDictionary中
			StringDictionary content = new StringDictionary();
			content.Add("HP", "100");
			content.Add("Infos", "很牛逼的发射器");
			RegistRegistType("PartyWeapon");
            Regist("PartyWeapon", "Dispener",content);
            PrintAllRegisted();
            Debug.Out("Registed.");
        }
        public int Regist(String type, String name, StringDictionary content)
        {
            StringDictionary dic = new StringDictionary();
            dic.Add("Name", name);
			dic.Union(content).ToDictionary(k => k.Key, v => v.Value);
            Debug.Out<String,String>(dic);
			RegistedDictionary[type].Add(dic);
			return RegistedDictionary[type].Count - 1;
        }
        #region 格子相关
        //注册格子类型
        public void DoRegistGridTypeVanilla()
		{
			RegistRegistType("GridType");
			GridType.Normal = RegistGridType("Normal");
			GridType.Water = RegistGridType("Water");
			GridType.Lava = RegistGridType("Lava");
		}

        public int RegistGridType(String name)
		{
			int length = RegistedDictionary["GridType"].Count;
			RegistedDictionary["GridType"].Add(name);
			return length;
		}
		public void RegistRegistType(String name)
		{
			RegistedDictionary.Add(name, new ArrayList());
		}
		#endregion

		public void PrintAllRegisted()
		{
			Debug.Out<String,ArrayList>(RegistedDictionary);
		}
		public static class GridType
		{
			static public int Normal;
			static public int Water;
			static public int Lava;
		}
    }
}