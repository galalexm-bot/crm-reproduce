using System;
using System.Collections.Specialized;
using System.Globalization;
using EleWise.ELMA.CAB.Configuration;
using EleWise.ELMA.CAB.Configuration.Xsd;
using EleWise.ELMA.CAB.Properties;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.Services;

public class FileCatalogModuleEnumerator : IModuleEnumerator, IConfigurable
{
	private string catalogFilePath = "ProfileCatalog.xml";

	public string CatalogFilePath
	{
		get
		{
			return catalogFilePath;
		}
		set
		{
			catalogFilePath = value;
		}
	}

	public FileCatalogModuleEnumerator()
	{
	}

	public FileCatalogModuleEnumerator(string catalogFilePath)
	{
		Guard.ArgumentNotNullOrEmptyString(catalogFilePath, "catalogFilePath");
		this.catalogFilePath = catalogFilePath;
	}

	public void Configure(NameValueCollection settings)
	{
		Guard.ArgumentNotNull(settings, "settings");
		if (!string.IsNullOrEmpty(settings["filePath"]))
		{
			catalogFilePath = settings["filePath"];
		}
	}

	public IModuleInfo[] EnumerateModules()
	{
		try
		{
			SolutionProfileReader solutionProfileReader = new SolutionProfileReader(catalogFilePath);
			SolutionProfileElement solutionProfile = solutionProfileReader.ReadProfile();
			return CreateModuleInfos(solutionProfile);
		}
		catch (Exception innerException)
		{
			throw new ModuleEnumeratorException(string.Format(CultureInfo.CurrentCulture, Resources.ErrorEnumeratingModules, new object[1] { this }), innerException);
		}
	}

	private static IModuleInfo[] CreateModuleInfos(SolutionProfileElement solutionProfile)
	{
		ModuleInfo[] array = new ModuleInfo[solutionProfile.Modules.Length];
		for (int i = 0; i < solutionProfile.Modules.Length; i++)
		{
			ModuleInfoElement moduleInfoElement = solutionProfile.Modules[i];
			ModuleInfo moduleInfo = new ModuleInfo(moduleInfoElement.AssemblyFile);
			moduleInfo.SetUpdateLocation(moduleInfoElement.UpdateLocation);
			if (moduleInfoElement.Roles != null && moduleInfoElement.Roles.Length > 0)
			{
				RoleElement[] roles = moduleInfoElement.Roles;
				foreach (RoleElement roleElement in roles)
				{
					moduleInfo.AddRoles(roleElement.Allow);
				}
			}
			array[i] = moduleInfo;
		}
		return array;
	}
}
