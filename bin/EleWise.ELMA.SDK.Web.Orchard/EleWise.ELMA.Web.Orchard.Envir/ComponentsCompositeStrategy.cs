using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using Autofac.Core;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Web.Mvc;
using Orchard;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using Orchard.Environment;
using Orchard.Environment.Configuration;
using Orchard.Environment.Descriptor.Models;
using Orchard.Environment.Extensions;
using Orchard.Environment.Extensions.Models;
using Orchard.Environment.ShellBuilders;
using Orchard.Environment.ShellBuilders.Models;

namespace EleWise.ELMA.Web.Orchard.Enviroment.ShellBuilders;

public class ComponentsCompositeStrategy : ICompositionStrategy
{
	private readonly IExtensionManager extensionManager;

	private readonly ComponentManager componentManager;

	public ILogger Logger { get; set; }

	public ComponentsCompositeStrategy(IExtensionManager extensionManager, ComponentManager componentManager)
	{
		this.extensionManager = extensionManager;
		this.componentManager = componentManager;
		Logger = NullLogger.Instance;
	}

	public ShellBlueprint Compose(ShellSettings settings, ShellDescriptor descriptor)
	{
		IEnumerable<FeatureDescriptor> featureDescriptors = extensionManager.EnabledFeatures(descriptor);
		Feature[] array = extensionManager.LoadFeatures(featureDescriptors).ToArray();
		if (array.Any((Feature feature) => feature.Descriptor.Name == "EleWise.ELMA.SDK.Web" && !feature.ExportedTypes.Any()))
		{
			array = array.Concat(BuiltinFeatures()).ToArray();
		}
		string[] array2 = GetExcludedTypes(array).ToArray();
		DependencyBlueprint[] array3 = BuildBlueprint(array, IsModule, BuildModule, array2).ToArray();
		DependencyBlueprint[] array4 = BuildBlueprint(array, IsDependency, (Type t, Feature f) => BuildDependency(t, f, descriptor), array2).ToArray();
		ControllerBlueprint[] array5 = BuildBlueprint(array, IsController, BuildController, array2).ToArray();
		ControllerBlueprint[] array6 = BuildBlueprint(array, IsHttpController, BuildController, array2).ToArray();
		RecordBlueprint[] array7 = BuildBlueprint(array, IsRecord, (Type t, Feature f) => BuildRecord(t, f, settings), array2).ToArray();
		Type[] array8 = BuildBlueprint(array, IsComponent, (Type t, Feature f) => t, array2).ToArray();
		if (Logger.IsDebugEnabled())
		{
			Logger.DebugFormat("Create shell blueprint: features {0}, modules {1}, dependencies {2},  records {3}, componentsTypes {4}", array.Count(), array3.Count(), array4.Count(), array7.Count(), array8.Count());
			Logger.DebugFormat("Blueprint features: {0}", array.Select((Feature x) => x.Descriptor.Name).AsText());
			Logger.DebugFormat("Blueprint excludedTypes: {0}", array2.AsText());
			Logger.DebugFormat("Blueprint dependecies {0}", array4.Select((DependencyBlueprint x) => x.Type.FullName).AsText());
			Logger.DebugFormat("Blueprint controllers {0}", array5.Select((ControllerBlueprint x) => x.Type.FullName).AsText());
			Logger.DebugFormat("Blueprint httpControllers {0}", array6.Select((ControllerBlueprint x) => x.Type.FullName).AsText());
			Logger.DebugFormat("Blueprint records {0}", array7.Select((RecordBlueprint x) => x.Type.FullName).AsText());
			Logger.DebugFormat("Blueprint componentsTypes {0}", array8.Select((Type x) => x.FullName).AsText());
		}
		return new ShellBlueprintWithComponents
		{
			Settings = settings,
			Descriptor = descriptor,
			Dependencies = array4.Concat(array3).ToArray(),
			Controllers = array5,
			HttpControllers = array6,
			Records = array7,
			ComponentTypes = array8
		};
	}

	private bool IsComponent(Type arg)
	{
		if (!componentManager.IsComponentType(arg))
		{
			return componentManager.IsServiceType(arg);
		}
		return true;
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
				Id = "EleWise.ELMA.SDK.Web",
				Name = "EleWise.ELMA.SDK.Web",
				Extension = new ExtensionDescriptor
				{
					Id = "EleWise.ELMA.SDK.Web",
					Name = "EleWise.ELMA.SDK.Web"
				}
			},
			ExportedTypes = (from t in typeof(ElmaModelBinder).Assembly.GetTypes()
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
		if (!typeof(IDependency).IsAssignableFrom(type))
		{
			if (typeof(IEventHandler).IsAssignableFrom(type))
			{
				return type.GetCustomAttributes(typeof(ComponentAttribute), inherit: true).Length == 0;
			}
			return false;
		}
		return true;
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
		if (((type.Namespace ?? "").EndsWith(".Models") || (type.Namespace ?? "").EndsWith(".Records")) && type.GetProperty("Id") != null)
		{
			IEnumerable<MethodInfo> accessors = type.GetProperty("Id").GetAccessors();
			if ((accessors ?? Enumerable.Empty<MethodInfo>()).All((MethodInfo x) => x.IsVirtual) && !type.IsSealed && !type.IsAbstract)
			{
				if (typeof(IContent).IsAssignableFrom(type))
				{
					return typeof(ContentPartRecord).IsAssignableFrom(type);
				}
				return true;
			}
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
