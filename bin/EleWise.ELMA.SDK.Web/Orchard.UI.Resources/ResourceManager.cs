using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac.Features.Metadata;
using Orchard.Environment.Extensions.Models;

namespace Orchard.UI.Resources;

public class ResourceManager : IResourceManager, IDependency, IUnitOfWorkDependency
{
	private readonly Dictionary<Tuple<string, string>, RequireSettings> _required = new Dictionary<Tuple<string, string>, RequireSettings>();

	private readonly List<LinkEntry> _links = new List<LinkEntry>();

	private readonly Dictionary<string, MetaEntry> _metas = new Dictionary<string, MetaEntry> { 
	{
		"generator",
		new MetaEntry
		{
			Content = "Orchard",
			Name = "generator"
		}
	} };

	private readonly Dictionary<string, IList<ResourceRequiredContext>> _builtResources = new Dictionary<string, IList<ResourceRequiredContext>>(StringComparer.OrdinalIgnoreCase);

	private readonly IEnumerable<Meta<IResourceManifestProvider>> _providers;

	private ResourceManifest _dynamicManifest;

	private List<string> _headScripts;

	private List<string> _footScripts;

	private IEnumerable<IResourceManifest> _manifests;

	private const string NotIE = "!IE";

	public IEnumerable<IResourceManifest> ResourceProviders
	{
		get
		{
			if (_manifests == null)
			{
				ResourceManifestBuilder resourceManifestBuilder = new ResourceManifestBuilder();
				foreach (Meta<IResourceManifestProvider> provider in _providers)
				{
					resourceManifestBuilder.Feature = (provider.get_Metadata().ContainsKey("Feature") ? ((Feature)provider.get_Metadata()["Feature"]) : null);
					provider.get_Value().BuildManifests(resourceManifestBuilder);
				}
				_manifests = resourceManifestBuilder.ResourceManifests;
			}
			return _manifests;
		}
	}

	public virtual ResourceManifest DynamicResources => _dynamicManifest ?? (_dynamicManifest = new ResourceManifest());

	private static string ToAppRelativePath(string resourcePath)
	{
		if (!string.IsNullOrEmpty(resourcePath) && !Uri.IsWellFormedUriString(resourcePath, UriKind.Absolute))
		{
			resourcePath = VirtualPathUtility.ToAppRelative(resourcePath);
		}
		return resourcePath;
	}

	private static string FixPath(string resourcePath, string relativeFromPath)
	{
		if (!string.IsNullOrEmpty(resourcePath) && !VirtualPathUtility.IsAbsolute(resourcePath) && !Uri.IsWellFormedUriString(resourcePath, UriKind.Absolute))
		{
			if (string.IsNullOrEmpty(relativeFromPath))
			{
				throw new InvalidOperationException("ResourcePath cannot be relative unless a base relative path is also provided.");
			}
			resourcePath = VirtualPathUtility.ToAbsolute(VirtualPathUtility.Combine(relativeFromPath, resourcePath));
		}
		return resourcePath;
	}

	private static TagBuilder GetTagBuilder(ResourceDefinition resource, string url)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		TagBuilder val = new TagBuilder(resource.TagName);
		val.MergeAttributes<string, string>(resource.TagBuilder.get_Attributes());
		if (!string.IsNullOrEmpty(resource.FilePathAttributeName) && !string.IsNullOrEmpty(url))
		{
			if (VirtualPathUtility.IsAppRelative(url))
			{
				url = VirtualPathUtility.ToAbsolute(url);
			}
			val.MergeAttribute(resource.FilePathAttributeName, url, true);
		}
		return val;
	}

	public static void WriteResource(TextWriter writer, ResourceDefinition resource, string url, string condition, Dictionary<string, string> attributes)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(condition))
		{
			if (condition == "!IE")
			{
				writer.WriteLine("<!--[if " + condition + "]>-->");
			}
			else
			{
				writer.WriteLine("<!--[if " + condition + "]>");
			}
		}
		TagBuilder tagBuilder = GetTagBuilder(resource, url);
		if (attributes != null)
		{
			tagBuilder.MergeAttributes<string, string>((IDictionary<string, string>)attributes, true);
		}
		writer.WriteLine(tagBuilder.ToString(resource.TagRenderMode));
		if (!string.IsNullOrEmpty(condition))
		{
			if (condition == "!IE")
			{
				writer.WriteLine("<!--<![endif]-->");
			}
			else
			{
				writer.WriteLine("<![endif]-->");
			}
		}
	}

	public ResourceManager(IEnumerable<Meta<IResourceManifestProvider>> resourceProviders)
	{
		_providers = resourceProviders;
	}

	public virtual RequireSettings Require(string resourceType, string resourceName)
	{
		if (resourceType == null)
		{
			throw new ArgumentNullException("resourceType");
		}
		if (resourceName == null)
		{
			throw new ArgumentNullException("resourceName");
		}
		Tuple<string, string> key = new Tuple<string, string>(resourceType, resourceName);
		if (!_required.TryGetValue(key, out var value))
		{
			value = new RequireSettings
			{
				Type = resourceType,
				Name = resourceName
			};
			_required[key] = value;
		}
		_builtResources[resourceType] = null;
		return value;
	}

	public virtual RequireSettings Include(string resourceType, string resourcePath, string resourceDebugPath)
	{
		return Include(resourceType, resourcePath, resourceDebugPath, null);
	}

	public virtual RequireSettings Include(string resourceType, string resourcePath, string resourceDebugPath, string relativeFromPath)
	{
		if (resourceType == null)
		{
			throw new ArgumentNullException("resourceType");
		}
		if (resourcePath == null)
		{
			throw new ArgumentNullException("resourcePath");
		}
		if (VirtualPathUtility.IsAppRelative(resourcePath))
		{
			resourcePath = VirtualPathUtility.ToAbsolute(resourcePath);
		}
		if (resourceDebugPath != null && VirtualPathUtility.IsAppRelative(resourceDebugPath))
		{
			resourceDebugPath = VirtualPathUtility.ToAbsolute(resourceDebugPath);
		}
		resourcePath = FixPath(resourcePath, relativeFromPath);
		resourceDebugPath = FixPath(resourceDebugPath, relativeFromPath);
		return Require(resourceType, ToAppRelativePath(resourcePath)).Define(delegate(ResourceDefinition d)
		{
			d.SetUrl(resourcePath, resourceDebugPath);
		});
	}

	public virtual void RegisterHeadScript(string script)
	{
		if (_headScripts == null)
		{
			_headScripts = new List<string>();
		}
		_headScripts.Add(script);
	}

	public virtual void RegisterFootScript(string script)
	{
		if (_footScripts == null)
		{
			_footScripts = new List<string>();
		}
		_footScripts.Add(script);
	}

	public virtual void NotRequired(string resourceType, string resourceName)
	{
		if (resourceType == null)
		{
			throw new ArgumentNullException("resourceType");
		}
		if (resourceName == null)
		{
			throw new ArgumentNullException("resourceName");
		}
		Tuple<string, string> key = new Tuple<string, string>(resourceType, resourceName);
		_builtResources[resourceType] = null;
		_required.Remove(key);
	}

	public virtual ResourceDefinition FindResource(RequireSettings settings)
	{
		return FindResource(settings, resolveInlineDefinitions: true);
	}

	private ResourceDefinition FindResource(RequireSettings settings, bool resolveInlineDefinitions)
	{
		string name = settings.Name ?? "";
		string type = settings.Type;
		ResourceDefinition resourceDefinition = (from p in ResourceProviders
			from r in p.GetResources(type)
			where name.Equals(r.Key, StringComparison.OrdinalIgnoreCase)
			let version = (r.Value.Version != null) ? new Version(r.Value.Version) : null
			orderby version descending
			select r.Value).FirstOrDefault();
		if (resourceDefinition == null && _dynamicManifest != null)
		{
			resourceDefinition = (from _003C_003Eh__TransparentIdentifier0 in _dynamicManifest.GetResources(type).Where(delegate(KeyValuePair<string, ResourceDefinition> r)
				{
					string text = name;
					KeyValuePair<string, ResourceDefinition> keyValuePair2 = r;
					return text.Equals(keyValuePair2.Key, StringComparison.OrdinalIgnoreCase);
				}).Select(delegate(KeyValuePair<string, ResourceDefinition> r)
				{
					KeyValuePair<string, ResourceDefinition> keyValuePair = r;
					object version;
					if (keyValuePair.Value.Version == null)
					{
						version = null;
					}
					else
					{
						keyValuePair = r;
						version = new Version(keyValuePair.Value.Version);
					}
					return new
					{
						r = r,
						version = (Version)version
					};
				})
				orderby _003C_003Eh__TransparentIdentifier0.version descending
				select _003C_003Eh__TransparentIdentifier0.r.Value).FirstOrDefault();
		}
		if (resolveInlineDefinitions && resourceDefinition == null && ResolveInlineDefinitions(settings.Type))
		{
			resourceDefinition = FindResource(settings, resolveInlineDefinitions: false);
		}
		return resourceDefinition;
	}

	private bool ResolveInlineDefinitions(string resourceType)
	{
		bool result = false;
		foreach (RequireSettings item in from settings in GetRequiredResources(resourceType)
			where settings.InlineDefinition != null
			select settings)
		{
			ResourceDefinition resourceDefinition = FindResource(item, resolveInlineDefinitions: false);
			if (resourceDefinition == null)
			{
				resourceDefinition = DynamicResources.DefineResource(resourceType, item.Name).SetBasePath(item.BasePath);
				result = true;
			}
			item.InlineDefinition(resourceDefinition);
			item.InlineDefinition = null;
		}
		return result;
	}

	public virtual IEnumerable<RequireSettings> GetRequiredResources(string type)
	{
		return from r in _required
			where r.Key.Item1 == type
			select r.Value;
	}

	public virtual IList<LinkEntry> GetRegisteredLinks()
	{
		return _links.AsReadOnly();
	}

	public virtual IList<MetaEntry> GetRegisteredMetas()
	{
		return _metas.Values.ToList().AsReadOnly();
	}

	public virtual IList<string> GetRegisteredHeadScripts()
	{
		if (_headScripts != null)
		{
			return _headScripts.AsReadOnly();
		}
		return null;
	}

	public virtual IList<string> GetRegisteredFootScripts()
	{
		if (_footScripts != null)
		{
			return _footScripts.AsReadOnly();
		}
		return null;
	}

	public virtual IList<ResourceRequiredContext> BuildRequiredResources(string resourceType)
	{
		if (_builtResources.TryGetValue(resourceType, out var value) && value != null)
		{
			return value;
		}
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		foreach (RequireSettings requiredResource in GetRequiredResources(resourceType))
		{
			ResourceDefinition resourceDefinition = FindResource(requiredResource);
			if (resourceDefinition == null)
			{
				throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, "A '{1}' named '{0}' could not be found.", requiredResource.Name, requiredResource.Type));
			}
			ExpandDependencies(resourceDefinition, requiredResource, orderedDictionary);
		}
		value = orderedDictionary.Cast<DictionaryEntry>().Select(delegate(DictionaryEntry entry)
		{
			ResourceRequiredContext resourceRequiredContext = new ResourceRequiredContext();
			DictionaryEntry dictionaryEntry = entry;
			resourceRequiredContext.Resource = (ResourceDefinition)dictionaryEntry.Key;
			dictionaryEntry = entry;
			resourceRequiredContext.Settings = (RequireSettings)dictionaryEntry.Value;
			return resourceRequiredContext;
		}).ToList();
		_builtResources[resourceType] = value;
		return value;
	}

	protected virtual void ExpandDependencies(ResourceDefinition resource, RequireSettings settings, OrderedDictionary allResources)
	{
		if (resource == null)
		{
			return;
		}
		settings = (allResources.Contains(resource) ? ((RequireSettings)allResources[resource]).Combine(settings) : new RequireSettings
		{
			Type = resource.Type,
			Name = resource.Name
		}.Combine(settings));
		if (resource.Dependencies != null)
		{
			foreach (ResourceDefinition item in resource.Dependencies.Select((string d) => FindResource(new RequireSettings
			{
				Type = resource.Type,
				Name = d
			})))
			{
				if (item != null)
				{
					ExpandDependencies(item, settings, allResources);
				}
			}
		}
		allResources[resource] = settings;
	}

	public void RegisterLink(LinkEntry link)
	{
		_links.Add(link);
	}

	public void SetMeta(MetaEntry meta)
	{
		if (meta != null)
		{
			string key = meta.Name ?? meta.HttpEquiv ?? "charset";
			_metas[key] = meta;
		}
	}

	public void AppendMeta(MetaEntry meta, string contentSeparator)
	{
		if (meta == null)
		{
			return;
		}
		string text = meta.Name ?? meta.HttpEquiv;
		if (!string.IsNullOrEmpty(text))
		{
			if (_metas.TryGetValue(text, out var value))
			{
				meta = MetaEntry.Combine(value, meta, contentSeparator);
			}
			_metas[text] = meta;
		}
	}
}
