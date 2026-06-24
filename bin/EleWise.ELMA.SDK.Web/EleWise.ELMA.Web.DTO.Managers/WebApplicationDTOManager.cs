using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Hosting;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files.DTO.Managers;
using EleWise.ELMA.Files.DTO.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Inputs;
using EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.WebForms;

namespace EleWise.ELMA.Web.DTO.Managers;

public class WebApplicationDTOManager : DTOManager, IWebApplicationDTOManager, IConfigurationService
{
	private class FakeController : Controller
	{
		[HttpGet]
		public ActionResult Action()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			return (ActionResult)new EmptyResult();
		}
	}

	public virtual IEnumerable<string> GetViewsTree(string prefix, bool isProperty)
	{
		if (!isProperty)
		{
			return GetViewsTree("", prefix).ToArray();
		}
		return GetViewsTree("DisplayTemplates/", prefix).Union(GetViewsTree("EditorTemplates/", prefix)).ToArray();
	}

	public virtual IEnumerable<WebFileDTO> GetFilePlaces(string partialViewName, IPropertyMetadata propertyMetadata)
	{
		return GetFilePlaces(partialViewName, propertyMetadata != null).Select(delegate(WebFileDTO webFile)
		{
			LoadFile(webFile);
			if (propertyMetadata != null && webFile.WebText == null && webFile.DefaultVirtualPath == null)
			{
				IEnumerable<IInput> extensionPoints = ComponentManager.Current.GetExtensionPoints<IInput>();
				if ((extensionPoints.FirstOrDefault((IInput inp) => inp.TypeUid == propertyMetadata.TypeUid) ?? extensionPoints.FirstOrDefault((IInput inp) => inp.TypeUid == Guid.Empty)) is BaseInput baseInput)
				{
					Type type = null;
					if (propertyMetadata.Settings is EntitySettings entitySettings)
					{
						type = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(propertyMetadata.SubTypeUid) ?? typeof(IEntity);
						if (entitySettings.RelationType != 0)
						{
							type = typeof(IEnumerable<>).MakeGenericType(type);
						}
					}
					else if (Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeDescriptor(propertyMetadata.TypeUid, propertyMetadata.SubTypeUid) is IRuntimeTypeDescriptor runtimeTypeDescriptor)
					{
						type = runtimeTypeDescriptor.RuntimeType;
					}
					if (type != null)
					{
						using (SafeHttpContext.Create())
						{
							IWorkPlaceTypeService service = Locator.GetService<IWorkPlaceTypeService>();
							ControllerContext controllerContext = ControllerContextCreator.Create((Controller)(object)new FakeController());
							ViewAttributes viewAttributes = new ViewAttributes
							{
								ReadOnly = !webFile.IsEditor,
								TypeSettings = propertyMetadata.Settings
							};
							string text = (webFile.IsEditor ? ("EditorTemplates/" + baseInput.EditorTemplateName(controllerContext, propertyMetadata, type, viewAttributes)) : ("DisplayTemplates/" + baseInput.DisplayTemplateName(controllerContext, propertyMetadata, type, viewAttributes)));
							string text2 = ((service == null || webFile.Uid == Guid.Empty) ? text : (service.GetVirtualPath(webFile.Uid, text) ?? text));
							WebFileDTO webFileDTO = new WebFileDTO
							{
								VirtualPath = text2
							};
							LoadFile(webFileDTO);
							webFile.WebText = webFileDTO.Text ?? webFileDTO.WebText;
							if (webFile.WebText != null)
							{
								return webFile;
							}
							if (service == null)
							{
								return webFile;
							}
							if (!(webFile.Uid != Guid.Empty))
							{
								return webFile;
							}
							string virtualPath = service.GetVirtualPath(Guid.Empty, text);
							if (!(virtualPath != text2))
							{
								return webFile;
							}
							webFileDTO.VirtualPath = virtualPath;
							LoadFile(webFileDTO);
							webFile.WebText = webFileDTO.Text ?? webFileDTO.WebText;
							return webFile;
						}
					}
				}
			}
			return webFile;
		}).ToArray();
	}

	public virtual void SaveFiles(IEnumerable<ConfigurationFileDTO> filePlace)
	{
		filePlace.Each(SaveFile);
	}

	public virtual void CopyFiles(string oldPartialViewName, string newPartialViewName, bool isProperty)
	{
		IWorkPlaceTypeService service = Locator.GetService<IWorkPlaceTypeService>();
		Func<Guid, string, string, string> getVirtualPath = delegate(Guid workPlaceTypeUid, string partialViewNamePrefix, string partialViewName)
		{
			string text2;
			if (service != null && !(workPlaceTypeUid == Guid.Empty))
			{
				text2 = service.GetVirtualPath(workPlaceTypeUid, partialViewNamePrefix + partialViewName);
				if (text2 == null)
				{
					return partialViewNamePrefix + partialViewName;
				}
			}
			else
			{
				text2 = partialViewNamePrefix + partialViewName;
			}
			return text2;
		};
		IDictionary<Guid, string> source;
		if (service == null)
		{
			IDictionary<Guid, string> dictionary = new Dictionary<Guid, string> { 
			{
				Guid.Empty,
				""
			} };
			source = dictionary;
		}
		else
		{
			source = service.WorkPlaceTypes();
		}
		source.SelectMany((KeyValuePair<Guid, string> p) => isProperty ? new[]
		{
			new
			{
				WorkPlaceTypeUid = p.Key,
				PartialViewNamePrefix = "DisplayTemplates/"
			},
			new
			{
				WorkPlaceTypeUid = p.Key,
				PartialViewNamePrefix = "EditorTemplates/"
			}
		} : new[]
		{
			new
			{
				WorkPlaceTypeUid = p.Key,
				PartialViewNamePrefix = ""
			}
		}).Each(p =>
		{
			string virtualPath = getVirtualPath(p.WorkPlaceTypeUid, p.PartialViewNamePrefix, oldPartialViewName);
			string text = GetConfigurationPath(virtualPath);
			if (text == null || !File.Exists(text))
			{
				text = GetServerPath(virtualPath);
				if (text != null && !File.Exists(text))
				{
					text = null;
				}
			}
			if (text != null)
			{
				string configurationPath = GetConfigurationPath(getVirtualPath(p.WorkPlaceTypeUid, p.PartialViewNamePrefix, newPartialViewName));
				Directory.CreateDirectory(Path.GetDirectoryName(configurationPath));
				File.Copy(text, configurationPath);
			}
		});
	}

	public virtual IEnumerable<string> GetExportViewsTree()
	{
		string configurationPath = GetConfigurationPath(null);
		DirectoryInfo directoryInfo = new DirectoryInfo(configurationPath);
		if (!directoryInfo.Exists)
		{
			return new string[0];
		}
		int directoryNameLength = configurationPath.Length;
		return (from f in directoryInfo.EnumerateFiles("*.cshtml", SearchOption.AllDirectories)
			select "~" + f.FullName.Substring(directoryNameLength).Replace('\\', '/') into vp
			where File.Exists(HostingEnvironment.MapPath(vp))
			select vp).ToArray();
	}

	public virtual bool CheckViewExists(string partialViewName, bool isProperty)
	{
		return (from p in GetFilePlaces(partialViewName, isProperty)
			select p.VirtualPath).SelectMany((string p) => new string[2]
		{
			GetServerPath(p),
			GetConfigurationPath(p)
		}).Any(File.Exists);
	}

	internal static IEnumerable<WebFileDTO> GetFilePlaces(string partialViewName, bool isProperty)
	{
		IWorkPlaceTypeService service = Locator.GetService<IWorkPlaceTypeService>();
		IDictionary<Guid, string> source;
		if (service == null)
		{
			IDictionary<Guid, string> dictionary = new Dictionary<Guid, string> { 
			{
				Guid.Empty,
				""
			} };
			source = dictionary;
		}
		else
		{
			source = service.WorkPlaceTypes();
		}
		Func<string, Guid, string, bool, WebFileDTO> getVirtualPath = delegate(string placeName, Guid workPlaceTypeUid, string viewName, bool isEditor)
		{
			string text = ((service == null || workPlaceTypeUid == Guid.Empty) ? partialViewName : (service.GetVirtualPath(workPlaceTypeUid, viewName) ?? partialViewName));
			string text2 = ((service == null || workPlaceTypeUid == Guid.Empty) ? null : service.GetVirtualPath(Guid.Empty, viewName));
			if (text2 == text)
			{
				text2 = null;
			}
			return new WebFileDTO
			{
				PlaceName = placeName,
				Uid = workPlaceTypeUid,
				VirtualPath = text,
				DefaultVirtualPath = text2,
				IsEditor = isEditor
			};
		};
		return source.SelectMany((KeyValuePair<Guid, string> p) => isProperty ? new WebFileDTO[2]
		{
			getVirtualPath(string.IsNullOrEmpty(p.Value) ? SR.T("Просмотр") : SR.T("{0}: Просмотр", p.Value), p.Key, "DisplayTemplates/" + partialViewName, arg4: false),
			getVirtualPath(string.IsNullOrEmpty(p.Value) ? SR.T("Редактирование") : SR.T("{0}: Редактирование", p.Value), p.Key, "EditorTemplates/" + partialViewName, arg4: true)
		} : new WebFileDTO[1] { getVirtualPath(p.Value, p.Key, partialViewName, arg4: true) }).ToArray();
	}

	internal static string GetConfigurationPath(string virtualPath)
	{
		EleWise.ELMA.Services.ConfigurationDirectoryFileWatcher service = Locator.GetService<EleWise.ELMA.Services.ConfigurationDirectoryFileWatcher>();
		if (service == null)
		{
			return null;
		}
		if (virtualPath != null)
		{
			if (virtualPath.StartsWith("~"))
			{
				virtualPath = virtualPath.Substring(1);
			}
			virtualPath = virtualPath.Replace('/', '\\');
			if (virtualPath.StartsWith("\\"))
			{
				virtualPath = virtualPath.Substring(1);
			}
		}
		string text = service.WatchRoot;
		if (string.IsNullOrWhiteSpace(text))
		{
			IRuntimeApplication service2 = Locator.GetService<IRuntimeApplication>();
			if (service2 == null)
			{
				return null;
			}
			text = Path.GetDirectoryName(service2.Configuration.Config.FilePath);
		}
		if (text == null)
		{
			return null;
		}
		return Path.GetFullPath((virtualPath != null) ? Path.Combine(text, "WebApplication", virtualPath) : Path.Combine(text, "WebApplication"));
	}

	internal static string GetServerPath(string virtualPath)
	{
		HostingEnvironment.VirtualPathProvider.GetFile("");
		return (from p in DefaultViewLocationCache.MapVirtualPathProviders
			where !(p is ConfigDirectoryMapVirtualPathProvider)
			select p.GetExistsFilePath(virtualPath)).FirstOrDefault((string fp) => fp != null) ?? HostingEnvironment.MapPath(virtualPath);
	}

	private IEnumerable<string> GetViewsTree(string virtualPathPrefix, string prefix)
	{
		IWorkPlaceTypeService service = Locator.GetService<IWorkPlaceTypeService>();
		IDictionary<Guid, string> source;
		if (service == null)
		{
			IDictionary<Guid, string> dictionary = new Dictionary<Guid, string> { 
			{
				Guid.Empty,
				""
			} };
			source = dictionary;
		}
		else
		{
			source = service.WorkPlaceTypes();
		}
		return source.SelectMany(delegate(KeyValuePair<Guid, string> p)
		{
			string text = virtualPathPrefix + prefix;
			text = ((service == null || p.Key == Guid.Empty) ? text : (service.GetVirtualPath(p.Key, text) ?? text));
			text = Path.ChangeExtension(text, null);
			string configurationPath = GetConfigurationPath(text);
			DirectoryInfo directoryInfo = new DirectoryInfo(configurationPath);
			if (!directoryInfo.Exists)
			{
				return new string[0];
			}
			if (prefix.EndsWith("/") || prefix.EndsWith("\\"))
			{
				prefix.Remove(prefix.Length - 1);
			}
			int directoryNameLength = configurationPath.Length;
			return from f in directoryInfo.EnumerateFiles("*.*", SearchOption.AllDirectories)
				select (prefix + Path.ChangeExtension(f.FullName, null).Substring(directoryNameLength)).Replace('\\', '/');
		}).Distinct();
	}

	private void LoadFile(WebFileDTO webFile)
	{
		string configurationPath = GetConfigurationPath(webFile.VirtualPath);
		if (configurationPath != null)
		{
			FileInfo fileInfo = new FileInfo(configurationPath);
			if (fileInfo.Exists)
			{
				using StreamReader streamReader = fileInfo.OpenText();
				webFile.Text = streamReader.ReadToEnd();
			}
		}
		string serverPath = GetServerPath(webFile.VirtualPath);
		if (serverPath == null)
		{
			return;
		}
		FileInfo fileInfo2 = new FileInfo(serverPath);
		if (fileInfo2.Exists)
		{
			using (StreamReader streamReader2 = fileInfo2.OpenText())
			{
				webFile.WebText = streamReader2.ReadToEnd();
			}
		}
	}

	private void DeleteDirectory(string directory)
	{
		string configurationPath = GetConfigurationPath("");
		DirectoryInfo directoryInfo = new DirectoryInfo(directory);
		try
		{
			while (directoryInfo != null && directoryInfo.FullName != configurationPath && !directoryInfo.EnumerateFiles().Any() && !directoryInfo.EnumerateDirectories().Any())
			{
				directoryInfo.Delete();
				directoryInfo = directoryInfo.Parent;
			}
		}
		catch
		{
		}
	}

	private void SaveFile(ConfigurationFileDTO configurationFile)
	{
		string configurationPath = GetConfigurationPath(configurationFile.VirtualPath);
		if (configurationPath == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(configurationFile.Text))
		{
			FileInfo fileInfo = new FileInfo(configurationPath);
			if (fileInfo.Exists)
			{
				fileInfo.Delete();
				DeleteDirectory(Path.GetDirectoryName(configurationPath));
			}
			return;
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetDirectoryName(configurationPath));
		if (!directoryInfo.Exists)
		{
			directoryInfo.Create();
		}
		using StreamWriter streamWriter = new StreamWriter(configurationPath, append: false, Encoding.UTF8);
		streamWriter.Write(configurationFile.Text);
	}
}
