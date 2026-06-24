using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Caching;
using System.Web.Hosting;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;
using EleWise.ELMA.WebCompiler;

namespace EleWise.ELMA.Web.Mvc;

public class DirectoryMapVirtualPathProvider : VirtualPathProvider, IMapVirtualPathProvider
{
	protected readonly Dictionary<string, string> virtualPhisicalPathMap = new Dictionary<string, string>();

	protected readonly DirectoryFileWatcher fileWatcher;

	protected string root;

	private static readonly string[] obsolete = new string[50]
	{
		"~/Modules/EleWise.ELMA.CRM.Web/Views/ContractorLegal/TabView.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/ContractorIndividual/TabView.cshtml", "~/Modules/EleWise.ELMA.CRM.UA.Web/Views/ContractorLegalUa/TabView.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Shared/Contractor/TasksTab.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Shared/ContractorLegal/ContractorLegalEditForm.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Shared/ContractorIndividual/ContractorIndividualEditForm.cshtml", "~/Modules/EleWise.ELMA.CRM.UA.Web/Views/Shared/ContractorLegalUa/ContractorLegalUaEditForm.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Sale/TabView.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Sale/TasksTab.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Shared/Sale/SaleEditForm.cshtml",
		"~/Modules/EleWise.ELMA.Workflow.Web/Views/WorkflowTask/Execute.cshtml", "~/Modules/EleWise.ELMA.Workflow.Web/Views/WorkflowTask/ExecuteTabView.cshtml", "~/Modules/EleWise.ELMA.Workflow.Web/Views/Shared/WorkflowTask/FieldsView.cshtml", "~/Modules/EleWise.ELMA.Workflow.Web/Views/Shared/WorkflowTask/DefaultFieldsView.cshtml", "~/Modules/EleWise.ELMA.Documents.Web/Views/Shared/Document/TabView.cshtml", "~/Modules/EleWise.ELMA.Documents.Web/Views/Document/GeneralInfo.cshtml", "~/Modules/EleWise.ELMA.Documents.Web/Views/Shared/Document/Attributes.cshtml", "~/Modules/EleWise.ELMA.Documents.Web/Views/Document/Links.cshtml", "~/Modules/EleWise.ELMA.Documents.Web/Views/Shared/Document/EditForm.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Product/Details.cshtml",
		"~/Modules/EleWise.ELMA.CRM.Web/Views/Product/DetailsForm.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Product/Edit.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Product/EditForm.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Product/Index.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Relationship/LinkedEntity.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/RelationshipCall/Details.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/RelationshipCall/TabView.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/RelationshipMail/Details.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/RelationshipMail/TabView.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/RelationshipMeeting/Details.cshtml",
		"~/Modules/EleWise.ELMA.CRM.Web/Views/RelationshipMeeting/TabView.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Shared/Relationship/ContactInfo.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Shared/RelationshipCall/RelationshipCallEditForm.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Shared/RelationshipMail/RelationshipMailEditForm.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Shared/RelationshipMeeting/RelationshipMeetingEditForm.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Shared/RelationshipUsersList.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Shared/RelationshipSchedulesList.cshtml", "~/Modules/EleWise.ELMA.BPM.Web.Calendar/Views/Event/Partial/CalendarEventUser.cshtml", "~/Modules/EleWise.ELMA.BPM.Web.Calendar/Views/Event/Partial/GeneralInfo.cshtml", "~/Modules/EleWise.ELMA.BPM.Web.Calendar/Views/Shared/DisplayTemplates/Entities/Schedule.cshtml",
		"~/Modules/EleWise.ELMA.CRM.Web/Views/Contact/TasksTab.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Contact/TasksTab.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Lead/TabView.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Lead/TasksTab.cshtml", "~/Modules/EleWise.ELMA.Projects.Web/Views/MilestoneTask/GeneralInfo.cshtml", "~/Modules/EleWise.ELMA.Projects.Web/Views/MilestoneTask/TabView.cshtml", "~/Modules/EleWise.ELMA.Projects.Web/Views/ProjectTask/GeneralInfo.cshtml", "~/Modules/EleWise.ELMA.Projects.Web/Views/ProjectTask/TabView.cshtml", "~/Modules/EleWise.ELMA.Projects.Web/Views/WorkflowProjectTask/GeneralInfo.cshtml", "~/Modules/EleWise.ELMA.Projects.Web/Views/WorkflowProjectTask/TabView.cshtml"
	};

	private static readonly string obsoleteCallContextDataName = "DirectoryMapVirtualPathProvider.ObsoleteCallContextDataName";

	protected ILogger Logger { get; set; }

	public static List<string> ObsoleteViews => ContextVars.GetOrAdd(obsoleteCallContextDataName, () => new List<string>());

	public DirectoryMapVirtualPathProvider(IDictionary<string, string> map)
		: this(map, Locator.GetServiceNotNull<ApplicationDirectoryFileWatcher>())
	{
	}

	protected DirectoryMapVirtualPathProvider(IDictionary<string, string> map, DirectoryFileWatcher fileWatcher)
	{
		this.fileWatcher = fileWatcher;
		if (map != null)
		{
			foreach (KeyValuePair<string, string> item in map)
			{
				AddMap(item.Key, item.Value);
			}
		}
		Logger = Locator.GetService<ILogger>() ?? NullLogger.Instance;
	}

	protected void AddMap(string virtualPath, string phisicalPath)
	{
		if (virtualPath == null)
		{
			throw new ArgumentNullException("virtualPath");
		}
		if (phisicalPath == null)
		{
			throw new ArgumentNullException("phisicalPath");
		}
		root = root ?? HostingEnvironment.MapPath("~/");
		if (root == null)
		{
			throw new InvalidOperationException("web hostring enviroment is not available ~/ == null");
		}
		string fullPath = Path.GetFullPath(Path.Combine(root, phisicalPath));
		virtualPhisicalPathMap.Add(virtualPath, fullPath);
		if (virtualPath.StartsWith("~"))
		{
			virtualPhisicalPathMap.Add(virtualPath.Substring(1), fullPath);
		}
		fileWatcher.AddWatchPaths(fullPath);
	}

	protected internal string MapPath(string virtualPath, out string phisicalPathPrefix)
	{
		if (virtualPath == null)
		{
			throw new ArgumentNullException("virtualPath");
		}
		string text = MappedPrefix(virtualPath);
		if (text == null)
		{
			phisicalPathPrefix = null;
			return null;
		}
		phisicalPathPrefix = virtualPhisicalPathMap[text];
		string text2 = virtualPath.Substring(text.Length);
		text2 = text2.Replace("/", "\\");
		if (text2.StartsWith("\\"))
		{
			text2 = text2.Substring(1);
		}
		return Path.Combine(phisicalPathPrefix, text2);
	}

	public string GetExistsFilePath(string virtualPath)
	{
		string phisicalPathPrefix;
		return GetExistsFilePath(virtualPath, out phisicalPathPrefix);
	}

	protected string GetExistsFilePath(string virtualPath, out string phisicalPathPrefix)
	{
		string text = MapPath(virtualPath, out phisicalPathPrefix);
		if (text == null)
		{
			return null;
		}
		if (!fileWatcher.FileExists(phisicalPathPrefix, text))
		{
			return null;
		}
		return text;
	}

	private string MappedPrefix(string virtualPath)
	{
		return virtualPhisicalPathMap.Keys.FirstOrDefault(virtualPath.StartsWith);
	}

	public override CacheDependency GetCacheDependency(string virtualPath, IEnumerable virtualPathDependencies, DateTime utcStart)
	{
		CacheDependency cacheDependency = (base.FileExists(virtualPath) ? base.GetCacheDependency(virtualPath, virtualPathDependencies, utcStart) : null);
		string phisicalPathPrefix;
		string text = MapPath(virtualPath, out phisicalPathPrefix);
		if (text != null)
		{
			string text2 = SearchNearestExistingPath(text);
			if (text2 != null)
			{
				return new CacheDependency(new string[1] { text2 }, null, cacheDependency, utcStart);
			}
		}
		return cacheDependency;
	}

	private static string SearchNearestExistingPath(string path)
	{
		if (string.IsNullOrEmpty(path) || !Path.IsPathRooted(path))
		{
			return null;
		}
		if (File.Exists(path) || Directory.Exists(path))
		{
			return path;
		}
		if (path.IndexOf("\\") <= 1)
		{
			return null;
		}
		string directoryName = Path.GetDirectoryName(path);
		if (directoryName.Length < path.Length)
		{
			return SearchNearestExistingPath(directoryName);
		}
		return null;
	}

	public override bool FileExists(string virtualPath)
	{
		if (GetExistsFilePath(virtualPath, out var _) != null)
		{
			return true;
		}
		return base.FileExists(virtualPath);
	}

	public override VirtualFile GetFile(string virtualPath)
	{
		string phisicalPathPrefix;
		string existsFilePath = GetExistsFilePath(virtualPath, out phisicalPathPrefix);
		if (existsFilePath != null)
		{
			return CreateVirtualFile(virtualPath, existsFilePath);
		}
		return base.GetFile(virtualPath);
	}

	protected virtual VirtualFile CreateVirtualFile(string virtualPath, string physicalPath)
	{
		return new MapPathVirtualFile(virtualPath, physicalPath);
	}

	public static bool AnyConfigFile(params string[] virtualPaths)
	{
		return virtualPaths.Any(ConfigDirectoryMapVirtualPathProvider.IsConfigFile);
	}
}
