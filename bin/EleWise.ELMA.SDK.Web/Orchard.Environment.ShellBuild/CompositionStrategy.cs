using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using Autofac.Core;
using EleWise.ELMA.Logging;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using Orchard.Environment.Configuration;
using Orchard.Environment.Descriptor.Models;
using Orchard.Environment.Extensions;
using Orchard.Environment.Extensions.Models;
using Orchard.Environment.ShellBuilders.Models;
using Orchard.Localization;
using Orchard.Logging;

namespace Orchard.Environment.ShellBuilders;

public class CompositionStrategy : ICompositionStrategy
{
	private readonly IExtensionManager _extensionManager;

	public ILogger Logger { get; set; }

	public Localizer T { get; set; }

	public CompositionStrategy(IExtensionManager extensionManager)
	{
		_extensionManager = extensionManager;
		Logger = NullLogger.Instance;
		T = NullLocalizer.Instance;
	}

	public ShellBlueprint Compose(ShellSettings settings, ShellDescriptor descriptor)
	{
		Logger.Debug("Composing blueprint");
		List<Feature> list = BuiltinFeatures().ToList();
		List<FeatureDescriptor> list2 = list.Select((Feature x) => x.Descriptor).ToList();
		Dictionary<string, FeatureDescriptor> availableFeatures = (from x in _extensionManager.AvailableFeatures().Concat(list2)
			group x by x.Id.ToLowerInvariant() into x
			select x.FirstOrDefault()).ToDictionary((FeatureDescriptor x) => x.Id, StringComparer.OrdinalIgnoreCase);
		List<string> second = (from x in _extensionManager.EnabledFeatures(descriptor)
			select x.Id).ToList();
		List<string> list3 = ExpandDependencies(availableFeatures, descriptor.Features.Select((ShellFeature x) => x.Name)).ToList();
		List<string> list4 = list3.Except(second).Except(list2.Select((FeatureDescriptor x) => x.Id)).ToList();
		List<FeatureDescriptor> featureDescriptors = _extensionManager.EnabledFeatures(list3.Select((string x) => new ShellFeature
		{
			Name = x
		})).ToList();
		IEnumerable<Feature> enumerable = _extensionManager.LoadFeatures(featureDescriptors);
		if (descriptor.Features.Any((ShellFeature feature) => feature.Name == "Orchard.Framework"))
		{
			enumerable = list.Concat(enumerable);
		}
		IEnumerable<string> excludedTypes = GetExcludedTypes(enumerable);
		IEnumerable<DependencyBlueprint> second2 = BuildBlueprint(enumerable, IsModule, BuildModule, excludedTypes);
		IEnumerable<DependencyBlueprint> first = BuildBlueprint(enumerable, IsDependency, (Type t, Feature f) => BuildDependency(t, f, descriptor), excludedTypes);
		IEnumerable<ControllerBlueprint> controllers = BuildBlueprint(enumerable, IsController, BuildController, excludedTypes);
		IEnumerable<ControllerBlueprint> httpControllers = BuildBlueprint(enumerable, IsHttpController, BuildController, excludedTypes);
		IEnumerable<RecordBlueprint> records = BuildBlueprint(enumerable, IsRecord, (Type t, Feature f) => BuildRecord(t, f, settings), excludedTypes);
		ShellBlueprint result = new ShellBlueprint
		{
			Settings = settings,
			Descriptor = descriptor,
			Dependencies = first.Concat(second2).ToArray(),
			Controllers = controllers,
			HttpControllers = httpControllers,
			Records = records
		};
		Logger.Debug("Done composing blueprint.");
		if (list4.Any())
		{
			descriptor.Features = descriptor.Features.Concat(list4.Select((string x) => new ShellFeature
			{
				Name = x
			})).ToList();
			Logger.Information("Automatically enabled the following dependency features: {0}.", string.Join(", ", list4));
		}
		return result;
	}

	private IEnumerable<string> ExpandDependencies(IDictionary<string, FeatureDescriptor> availableFeatures, IEnumerable<string> features)
	{
		return ExpandDependenciesInternal(availableFeatures, features).Distinct();
	}

	private IEnumerable<string> ExpandDependenciesInternal(IDictionary<string, FeatureDescriptor> availableFeatures, IEnumerable<string> features, FeatureDescriptor dependentFeatureDescriptor = null)
	{
		foreach (string shellFeature in features)
		{
			if (!availableFeatures.ContainsKey(shellFeature))
			{
				if (dependentFeatureDescriptor != null)
				{
					throw new OrchardException(T("The feature '{0}' was listed as a dependency of '{1}' of extension '{2}', but this feature could not be found. Please update your manifest file or install the module providing the missing feature.", shellFeature, dependentFeatureDescriptor.Name, dependentFeatureDescriptor.Extension.Name));
				}
				Logger.Warning("Identified '{0}' as an orphaned feature state record in Settings_ShellFeatureRecord.", shellFeature);
				continue;
			}
			FeatureDescriptor feature = availableFeatures[shellFeature];
			foreach (string item in ExpandDependenciesInternal(availableFeatures, feature.Dependencies, feature))
			{
				yield return item;
			}
			foreach (string dependency in feature.Dependencies)
			{
				yield return dependency;
			}
			yield return shellFeature;
		}
	}

	private static IEnumerable<string> GetExcludedTypes(IEnumerable<Feature> features)
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (Feature feature in features)
		{
			foreach (Type exportedType in feature.ExportedTypes)
			{
				object[] customAttributes = exportedType.GetCustomAttributes(typeof(OrchardSuppressDependencyAttribute), inherit: false);
				for (int i = 0; i < customAttributes.Length; i++)
				{
					OrchardSuppressDependencyAttribute orchardSuppressDependencyAttribute = (OrchardSuppressDependencyAttribute)customAttributes[i];
					hashSet.Add(orchardSuppressDependencyAttribute.FullName);
				}
			}
		}
		return hashSet;
	}

	private static IEnumerable<Feature> BuiltinFeatures()
	{
		yield return new Feature
		{
			Descriptor = new FeatureDescriptor
			{
				Id = "Orchard.Framework",
				Extension = new ExtensionDescriptor
				{
					Id = "Orchard.Framework"
				}
			},
			ExportedTypes = (from t in typeof(OrchardStarter).Assembly.GetTypes()
				where t.IsClass && !t.IsAbstract
				select t).Except(new Type[1] { typeof(DefaultOrchardHost) }).ToArray()
		};
	}

	private static IEnumerable<T> BuildBlueprint<T>(IEnumerable<Feature> features, Func<Type, bool> predicate, Func<Type, Feature, T> selector, IEnumerable<string> excludedTypes)
	{
		return features.SelectMany((Feature feature) => from type in feature.ExportedTypes.Where(predicate)
			where !excludedTypes.Contains(type.FullName)
			select selector(type, feature)).ToArray();
	}

	private static bool IsModule(Type type)
	{
		return typeof(IModule).IsAssignableFrom(type);
	}

	private static DependencyBlueprint BuildModule(Type type, Feature feature)
	{
		return new DependencyBlueprint
		{
			Type = type,
			Feature = feature
		};
	}

	private static bool IsDependency(Type type)
	{
		return typeof(IDependency).IsAssignableFrom(type);
	}

	private static DependencyBlueprint BuildDependency(Type type, Feature feature, ShellDescriptor descriptor)
	{
		return new DependencyBlueprint
		{
			Type = type,
			Feature = feature
		};
	}

	private static bool IsController(Type type)
	{
		return typeof(IController).IsAssignableFrom(type);
	}

	private static bool IsHttpController(Type type)
	{
		return typeof(IHttpController).IsAssignableFrom(type);
	}

	private static ControllerBlueprint BuildController(Type type, Feature feature)
	{
		string id = feature.Descriptor.Extension.Id;
		string text = type.Name;
		if (text.EndsWith("Controller"))
		{
			text = text.Substring(0, text.Length - "Controller".Length);
		}
		return new ControllerBlueprint
		{
			Type = type,
			Feature = feature,
			AreaName = id,
			ControllerName = text
		};
	}

	private static bool IsRecord(Type type)
	{
		if (((type.Namespace ?? "").EndsWith(".Models") || (type.Namespace ?? "").EndsWith(".Records")) && type.GetProperty("Id") != null && type.GetProperty("Id").GetAccessors().All((MethodInfo x) => x.IsVirtual) && !type.IsSealed && !type.IsAbstract)
		{
			if (typeof(IContent).IsAssignableFrom(type))
			{
				return typeof(ContentPartRecord).IsAssignableFrom(type);
			}
			return true;
		}
		return false;
	}

	private static RecordBlueprint BuildRecord(Type type, Feature feature, ShellSettings settings)
	{
		string text = feature.Descriptor.Extension.Id.Replace('.', '_');
		string text2 = "";
		if (!string.IsNullOrEmpty(settings.DataTablePrefix))
		{
			text2 = settings.DataTablePrefix + "_";
		}
		return new RecordBlueprint
		{
			Type = type,
			Feature = feature,
			TableName = text2 + text + "_" + type.Name
		};
	}
}
