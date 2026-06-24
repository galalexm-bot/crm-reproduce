using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

public class RemoteDomain : MarshalByRefObject
{
	public override object InitializeLifetimeService()
	{
		return null;
	}

	public List<Assembly> GetPackageAssemblies(List<string> fileNames)
	{
		List<Assembly> list = new List<Assembly>();
		List<string> list2 = new List<string>();
		foreach (string fileName2 in fileNames)
		{
			string extension = Path.GetExtension(fileName2);
			string fileName = Path.GetFileName(fileName2);
			if (extension != null && (extension.Equals(".dll") || extension.Equals(".exe")) && !fileName2.Contains("App_Data"))
			{
				string tmpFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
				if (!list2.Any((string a) => a.Equals(tmpFilePath, StringComparison.OrdinalIgnoreCase)))
				{
					Assembly item = Assembly.ReflectionOnlyLoadFrom(tmpFilePath);
					list.Add(item);
					list2.Add(tmpFilePath);
				}
			}
		}
		return list;
	}
}
