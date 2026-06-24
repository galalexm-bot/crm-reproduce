using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using EleWise.ELMA.CAB.Configuration;

namespace EleWise.ELMA.CAB.Services;

public class ReflectionModuleEnumerator : IModuleEnumerator
{
	public string BasePath { get; set; }

	public ReflectionModuleEnumerator()
	{
		BasePath = AppDomain.CurrentDomain.BaseDirectory;
	}

	public IModuleInfo[] EnumerateModules()
	{
		List<ModuleInfo> list = new List<ModuleInfo>();
		List<string> list2 = new List<string>();
		list2.Add(BasePath);
		while (list2.Count > 0)
		{
			string text = list2[0];
			list2.Remove(text);
			string[] files = Directory.GetFiles(text, "*.dll");
			foreach (string text2 in files)
			{
				Assembly assm = Assembly.LoadFile(text2);
				if (AssemblyHasModuleAttribute(assm))
				{
					ModuleInfo moduleInfo = new ModuleInfo();
					moduleInfo.SetAssemblyFile(text2);
					list.Add(moduleInfo);
				}
			}
			list2.AddRange(Directory.GetDirectories(text));
		}
		return list.ToArray();
	}

	private static bool AssemblyHasModuleAttribute(Assembly assm)
	{
		return assm.GetCustomAttributes(typeof(ModuleAttribute), inherit: false).Length > 0;
	}
}
