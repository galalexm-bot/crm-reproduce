using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.ContentManagement;
using Orchard.Environment.Extensions.Models;
using Orchard.Exceptions;
using Orchard.FileSystems.WebSite;
using Orchard.Localization;
using Orchard.Logging;
using Orchard.Utility.Extensions;

namespace Orchard.Environment.Extensions.Folders;

public class ExtensionHarvester : IExtensionHarvester
{
	private const string NameSection = "name";

	private const string PathSection = "path";

	private const string DescriptionSection = "description";

	private const string DisplayNameSection = "displayname";

	private const string VersionSection = "version";

	private const string OrchardVersionSection = "orchardversion";

	private const string AuthorSection = "author";

	private const string WebsiteSection = "website";

	private const string TagsSection = "tags";

	private const string AntiForgerySection = "antiforgery";

	private const string ZonesSection = "zones";

	private const string BaseThemeSection = "basetheme";

	private const string DependenciesSection = "dependencies";

	private const string CategorySection = "category";

	private const string FeatureDescriptionSection = "featuredescription";

	private const string FeatureNameSection = "featurename";

	private const string PrioritySection = "priority";

	private const string FeaturesSection = "features";

	private const string SessionStateSection = "sessionstate";

	private const string LifecycleStatusSection = "lifecyclestatus";

	private const string ModuleSection = "module";

	private readonly ICacheManager _cacheManager;

	private readonly IWebSiteFolder _webSiteFolder;

	private readonly ICriticalErrorProvider _criticalErrorProvider;

	public Localizer T { get; set; }

	public ILogger Logger { get; set; }

	public bool DisableMonitoring { get; set; }

	public ExtensionHarvester(ICacheManager cacheManager, IWebSiteFolder webSiteFolder, ICriticalErrorProvider criticalErrorProvider)
	{
		_cacheManager = cacheManager;
		_webSiteFolder = webSiteFolder;
		_criticalErrorProvider = criticalErrorProvider;
		Logger = NullLogger.Instance;
		T = NullLocalizer.Instance;
	}

	public IEnumerable<ExtensionDescriptor> HarvestExtensions(IEnumerable<string> paths, string extensionType, string manifestName, bool manifestIsOptional)
	{
		return paths.SelectMany((string path) => HarvestExtensions(path, extensionType, manifestName, manifestIsOptional)).ToList();
	}

	private IEnumerable<ExtensionDescriptor> HarvestExtensions(string path, string extensionType, string manifestName, bool manifestIsOptional)
	{
		string key = $"{path}-{manifestName}-{extensionType}";
		return _cacheManager.Get(key, preventConcurrentCalls: true, delegate(AcquireContext<string> ctx)
		{
			if (!DisableMonitoring)
			{
				Logger.Debug("Monitoring virtual path \"{0}\"", path);
				ctx.Monitor(_webSiteFolder.WhenPathChanges(path));
			}
			return AvailableExtensionsInFolder(path, extensionType, manifestName, manifestIsOptional).ToReadOnlyCollection();
		});
	}

	private List<ExtensionDescriptor> AvailableExtensionsInFolder(string path, string extensionType, string manifestName, bool manifestIsOptional)
	{
		Logger.Information("Start looking for extensions in '{0}'...", path);
		IEnumerable<string> enumerable = _webSiteFolder.ListDirectories(path);
		List<ExtensionDescriptor> list = new List<ExtensionDescriptor>();
		foreach (string item in enumerable)
		{
			string fileName = Path.GetFileName(item.TrimEnd('/', '\\'));
			string manifestPath = Path.Combine(item, manifestName);
			try
			{
				ExtensionDescriptor extensionDescriptor = GetExtensionDescriptor(path, fileName, extensionType, manifestPath, manifestIsOptional);
				if (extensionDescriptor == null)
				{
					continue;
				}
				if (extensionDescriptor.Path != null && !extensionDescriptor.Path.IsValidUrlSegment())
				{
					Logger.Error("The module '{0}' could not be loaded because it has an invalid Path ({1}). It was ignored. The Path if specified must be a valid URL segment. The best bet is to stick with letters and numbers with no spaces.", fileName, extensionDescriptor.Path);
					_criticalErrorProvider.RegisterErrorMessage(T("The extension '{0}' could not be loaded because it has an invalid Path ({1}). It was ignored. The Path if specified must be a valid URL segment. The best bet is to stick with letters and numbers with no spaces.", fileName, extensionDescriptor.Path));
				}
				else
				{
					if (extensionDescriptor.Path == null)
					{
						extensionDescriptor.Path = (extensionDescriptor.Name.IsValidUrlSegment() ? extensionDescriptor.Name : extensionDescriptor.Id);
					}
					list.Add(extensionDescriptor);
				}
			}
			catch (Exception ex)
			{
				if (ex.IsFatal())
				{
					throw;
				}
				Logger.Error(ex, "The module '{0}' could not be loaded. It was ignored.", fileName);
				_criticalErrorProvider.RegisterErrorMessage(T("The extension '{0}' manifest could not be loaded. It was ignored.", fileName));
			}
		}
		Logger.Information("Done looking for extensions in '{0}': {1}", path, string.Join(", ", list.Select((ExtensionDescriptor d) => d.Id)));
		return list;
	}

	public static ExtensionDescriptor GetDescriptorForExtension(string locationPath, string extensionId, string extensionType, string manifestText)
	{
		Dictionary<string, string> dictionary = ParseManifest(manifestText);
		ExtensionDescriptor extensionDescriptor = new ExtensionDescriptor
		{
			Location = locationPath,
			Id = extensionId,
			ExtensionType = extensionType,
			Name = (GetValue(dictionary, "name") ?? extensionId),
			Module = GetValue(dictionary, "module"),
			Path = GetValue(dictionary, "path"),
			Description = GetValue(dictionary, "description"),
			DisplayName = GetValue(dictionary, "displayname"),
			Version = GetValue(dictionary, "version"),
			OrchardVersion = GetValue(dictionary, "orchardversion"),
			Author = GetValue(dictionary, "author"),
			WebSite = GetValue(dictionary, "website"),
			Tags = GetValue(dictionary, "tags"),
			AntiForgery = GetValue(dictionary, "antiforgery"),
			Zones = GetValue(dictionary, "zones"),
			BaseTheme = GetValue(dictionary, "basetheme"),
			SessionState = GetValue(dictionary, "sessionstate"),
			LifecycleStatus = GetValue(dictionary, "lifecyclestatus", LifecycleStatus.Production)
		};
		extensionDescriptor.Features = GetFeaturesForExtension(dictionary, extensionDescriptor);
		return extensionDescriptor;
	}

	private ExtensionDescriptor GetExtensionDescriptor(string locationPath, string extensionId, string extensionType, string manifestPath, bool manifestIsOptional)
	{
		return _cacheManager.Get(manifestPath, preventConcurrentCalls: true, delegate(AcquireContext<string> context)
		{
			if (!DisableMonitoring)
			{
				Logger.Debug("Monitoring virtual path \"{0}\"", manifestPath);
				context.Monitor(_webSiteFolder.WhenPathChanges(manifestPath));
			}
			string text = _webSiteFolder.ReadFile(manifestPath);
			if (text == null)
			{
				if (!manifestIsOptional)
				{
					return null;
				}
				text = $"Id: {extensionId}";
			}
			return GetDescriptorForExtension(locationPath, extensionId, extensionType, text);
		});
	}

	private static Dictionary<string, string> ParseManifest(string manifestText)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		using StringReader stringReader = new StringReader(manifestText);
		string text;
		while ((text = stringReader.ReadLine()) != null)
		{
			string[] array = text.Split(new string[1] { ":" }, 2, StringSplitOptions.None);
			int num = array.Length;
			if (num == 2)
			{
				for (int i = 0; i < num; i++)
				{
					array[i] = array[i].Trim();
				}
				switch (array[0].ToLowerInvariant())
				{
				case "name":
					dictionary.Add("name", array[1]);
					break;
				case "path":
					dictionary.Add("path", array[1]);
					break;
				case "description":
					dictionary.Add("description", array[1]);
					break;
				case "displayname":
					dictionary.Add("displayname", array[1]);
					break;
				case "version":
					dictionary.Add("version", array[1]);
					break;
				case "orchardversion":
					dictionary.Add("orchardversion", array[1]);
					break;
				case "author":
					dictionary.Add("author", array[1]);
					break;
				case "website":
					dictionary.Add("website", array[1]);
					break;
				case "tags":
					dictionary.Add("tags", array[1]);
					break;
				case "antiforgery":
					dictionary.Add("antiforgery", array[1]);
					break;
				case "zones":
					dictionary.Add("zones", array[1]);
					break;
				case "basetheme":
					dictionary.Add("basetheme", array[1]);
					break;
				case "dependencies":
					dictionary.Add("dependencies", array[1]);
					break;
				case "category":
					dictionary.Add("category", array[1]);
					break;
				case "featuredescription":
					dictionary.Add("featuredescription", array[1]);
					break;
				case "featurename":
					dictionary.Add("featurename", array[1]);
					break;
				case "priority":
					dictionary.Add("priority", array[1]);
					break;
				case "sessionstate":
					dictionary.Add("sessionstate", array[1]);
					break;
				case "lifecyclestatus":
					dictionary.Add("lifecyclestatus", array[1]);
					break;
				case "module":
					dictionary.Add("module", array[1]);
					break;
				case "features":
					dictionary.Add("features", stringReader.ReadToEnd());
					break;
				}
			}
		}
		return dictionary;
	}

	private static IEnumerable<FeatureDescriptor> GetFeaturesForExtension(IDictionary<string, string> manifest, ExtensionDescriptor extensionDescriptor)
	{
		List<FeatureDescriptor> list = new List<FeatureDescriptor>();
		FeatureDescriptor featureDescriptor = new FeatureDescriptor
		{
			Id = extensionDescriptor.Id,
			Name = (GetValue(manifest, "featurename") ?? extensionDescriptor.Name),
			Priority = ((GetValue(manifest, "priority") != null) ? int.Parse(GetValue(manifest, "priority")) : 0),
			Description = (GetValue(manifest, "featuredescription") ?? GetValue(manifest, "description") ?? string.Empty),
			Dependencies = ParseFeatureDependenciesEntry(GetValue(manifest, "dependencies")),
			Extension = extensionDescriptor,
			Category = GetValue(manifest, "category")
		};
		list.Add(featureDescriptor);
		string value = GetValue(manifest, "features");
		if (value != null)
		{
			FeatureDescriptor featureDescriptor2 = null;
			using StringReader stringReader = new StringReader(value);
			string text;
			while ((text = stringReader.ReadLine()) != null)
			{
				if (IsFeatureDeclaration(text))
				{
					if (featureDescriptor2 != null)
					{
						if (!featureDescriptor2.Equals(featureDescriptor))
						{
							list.Add(featureDescriptor2);
						}
						featureDescriptor2 = null;
					}
					string text2 = text.Split(new string[1] { ":" }, StringSplitOptions.RemoveEmptyEntries)[0].Trim();
					if (string.Equals(text2, extensionDescriptor.Id, StringComparison.OrdinalIgnoreCase))
					{
						featureDescriptor2 = featureDescriptor;
						featureDescriptor2.Name = extensionDescriptor.Name;
					}
					else
					{
						featureDescriptor2 = new FeatureDescriptor
						{
							Id = text2,
							Extension = extensionDescriptor
						};
					}
					continue;
				}
				if (IsFeatureFieldDeclaration(text))
				{
					if (featureDescriptor2 != null)
					{
						string[] array = text.Split(new string[1] { ":" }, 2, StringSplitOptions.None);
						int num = array.Length;
						if (num == 2)
						{
							for (int i = 0; i < num; i++)
							{
								array[i] = array[i].Trim();
							}
							switch (array[0].ToLowerInvariant())
							{
							case "name":
								featureDescriptor2.Name = array[1];
								break;
							case "description":
								featureDescriptor2.Description = array[1];
								break;
							case "category":
								featureDescriptor2.Category = array[1];
								break;
							case "priority":
								featureDescriptor2.Priority = int.Parse(array[1]);
								break;
							case "dependencies":
								featureDescriptor2.Dependencies = ParseFeatureDependenciesEntry(array[1]);
								break;
							case "module":
								featureDescriptor2.Module = array[1];
								break;
							}
						}
						continue;
					}
					throw new ArgumentException($"The line {text} in manifest for extension {extensionDescriptor.Id} was ignored");
				}
				throw new ArgumentException($"The line {text} in manifest for extension {extensionDescriptor.Id} was ignored");
			}
			if (featureDescriptor2 != null)
			{
				if (!featureDescriptor2.Equals(featureDescriptor))
				{
					list.Add(featureDescriptor2);
					return list;
				}
				return list;
			}
			return list;
		}
		return list;
	}

	private static bool IsFeatureFieldDeclaration(string line)
	{
		if (line.StartsWith("\t\t") || line.StartsWith("\t    ") || line.StartsWith("    ") || line.StartsWith("    \t"))
		{
			return true;
		}
		return false;
	}

	private static bool IsFeatureDeclaration(string line)
	{
		int length = line.Length;
		if (line.StartsWith("\t") && length >= 2)
		{
			return !char.IsWhiteSpace(line[1]);
		}
		if (line.StartsWith("    ") && length >= 5)
		{
			return !char.IsWhiteSpace(line[4]);
		}
		return false;
	}

	private static IEnumerable<string> ParseFeatureDependenciesEntry(string dependenciesEntry)
	{
		if (string.IsNullOrEmpty(dependenciesEntry))
		{
			return Enumerable.Empty<string>();
		}
		List<string> list = new List<string>();
		string[] array = dependenciesEntry.Split(',');
		foreach (string text in array)
		{
			list.Add(text.Trim());
		}
		return list;
	}

	private static string GetValue(IDictionary<string, string> fields, string key)
	{
		if (!fields.TryGetValue(key, out var value))
		{
			return null;
		}
		return value;
	}

	private static T GetValue<T>(IDictionary<string, string> fields, string key, T defaultValue = default(T))
	{
		string value = GetValue(fields, key);
		if (!string.IsNullOrWhiteSpace(value))
		{
			return XmlHelper.Parse<T>(value);
		}
		return defaultValue;
	}
}
