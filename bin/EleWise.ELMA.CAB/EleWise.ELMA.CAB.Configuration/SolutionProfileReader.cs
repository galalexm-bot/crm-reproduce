using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using EleWise.ELMA.CAB.Configuration.Xsd;
using EleWise.ELMA.CAB.Properties;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.Configuration;

public class SolutionProfileReader
{
	public const string DefaultCatalogFile = "ProfileCatalog.xml";

	private readonly string catalogFilePath = "ProfileCatalog.xml";

	public string CatalogFilePath => catalogFilePath;

	public SolutionProfileReader()
	{
	}

	public SolutionProfileReader(string catalogFilePath)
	{
		this.catalogFilePath = GetFullPathOrThrowIfInvalid(catalogFilePath);
	}

	public SolutionProfileElement ReadProfile()
	{
		SolutionProfileElement result = new SolutionProfileElement();
		if (File.Exists(catalogFilePath))
		{
			try
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(SolutionProfileElement));
				using XmlReader xmlReader = GetValidatingReader();
				result = (SolutionProfileElement)xmlSerializer.Deserialize(xmlReader);
				ProcessProfileRoles(result);
				return result;
			}
			catch (Exception innerException)
			{
				throw new SolutionProfileReaderException(string.Format(CultureInfo.CurrentCulture, Resources.ErrorReadingProfile, new object[1] { catalogFilePath }), innerException);
			}
		}
		ThrowIfCatalogPathNotDefault();
		return result;
	}

	private XmlReader GetValidatingReader()
	{
		Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EleWise.ELMA.CAB.SolutionProfile.xsd");
		XmlTextReader schemaDocument = new XmlTextReader(manifestResourceStream);
		manifestResourceStream.Dispose();
		XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
		xmlReaderSettings.Schemas.Add("http://schemas.microsoft.com/pag/cab-profile", schemaDocument);
		return XmlReader.Create(catalogFilePath, xmlReaderSettings);
	}

	private static void ProcessProfileRoles(SolutionProfileElement profile)
	{
		IPrincipal currentPrincipal = Thread.CurrentPrincipal;
		List<ModuleInfoElement> list = new List<ModuleInfoElement>();
		if (profile.Modules == null)
		{
			return;
		}
		ModuleInfoElement[] modules = profile.Modules;
		foreach (ModuleInfoElement moduleInfoElement in modules)
		{
			if (moduleInfoElement.Roles != null)
			{
				if (!currentPrincipal.Identity.IsAuthenticated)
				{
					continue;
				}
				RoleElement[] roles = moduleInfoElement.Roles;
				foreach (RoleElement roleElement in roles)
				{
					if (currentPrincipal.IsInRole(roleElement.Allow))
					{
						list.Add(moduleInfoElement);
						break;
					}
				}
			}
			else
			{
				list.Add(moduleInfoElement);
			}
		}
		profile.Modules = list.ToArray();
	}

	private void ThrowIfCatalogPathNotDefault()
	{
		string strB = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ProfileCatalog.xml");
		if (string.Compare(catalogFilePath, "ProfileCatalog.xml", ignoreCase: true, CultureInfo.CurrentCulture) == 0 || string.Compare(catalogFilePath, strB, ignoreCase: true, CultureInfo.CurrentCulture) == 0)
		{
			return;
		}
		throw new SolutionProfileReaderException(string.Format(CultureInfo.CurrentCulture, Resources.SolutionProfileNotFound, new object[1] { catalogFilePath }));
	}

	private string GetFullPathOrThrowIfInvalid(string catalogFilePath)
	{
		Guard.ArgumentNotNullOrEmptyString(catalogFilePath, "catalogFilePath");
		string text = catalogFilePath;
		if (!Path.IsPathRooted(text))
		{
			text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, text);
		}
		text = new FileInfo(text).FullName;
		if (!text.StartsWith(AppDomain.CurrentDomain.BaseDirectory, ignoreCase: true, CultureInfo.CurrentCulture))
		{
			throw new SolutionProfileReaderException(string.Format(CultureInfo.CurrentCulture, Resources.InvalidSolutionProfilePath, new object[2]
			{
				catalogFilePath,
				AppDomain.CurrentDomain.BaseDirectory
			}));
		}
		return text;
	}
}
