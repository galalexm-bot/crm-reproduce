using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.Configuration;

public class ModuleInfo : IModuleInfo
{
	private readonly List<string> allowedRoles = new List<string>();

	private string assemblyFile;

	private string updateLocation;

	public string AssemblyFile => assemblyFile;

	public string UpdateLocation => updateLocation;

	public IList<string> AllowedRoles => allowedRoles.AsReadOnly();

	public ModuleInfo()
	{
	}

	public ModuleInfo(string assemblyFile)
	{
		Guard.ArgumentNotNullOrEmptyString(assemblyFile, "assemblyFile");
		this.assemblyFile = assemblyFile;
	}

	public ModuleInfo(Assembly assembly)
	{
		Guard.ArgumentNotNull(assembly, "assembly");
		assemblyFile = assembly.CodeBase.Replace("file:///", "").Replace('/', '\\');
	}

	public void SetAssemblyFile(string assemblyFile)
	{
		this.assemblyFile = assemblyFile;
	}

	public void SetUpdateLocation(string updateLocation)
	{
		this.updateLocation = updateLocation;
	}

	public void AddRoles(params string[] roles)
	{
		Guard.ArgumentNotNull(roles, "roles");
		foreach (string text in roles)
		{
			if (text != null && text.Length > 0)
			{
				allowedRoles.Add(text);
			}
		}
	}

	public void ClearRoles()
	{
		allowedRoles.Clear();
	}
}
