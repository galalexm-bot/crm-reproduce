using System;
using System.Collections.Generic;
using Autofac;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Serialization;
using Orchard.Environment.Configuration;
using Orchard.Environment.Descriptor;
using Orchard.Environment.Descriptor.Models;
using Orchard.Environment.Extensions;
using Orchard.Environment.Extensions.Models;
using Orchard.Environment.ShellBuilders.Models;

namespace Orchard.Environment.ShellBuilders;

public class ShellContextFactory : IShellContextFactory
{
	private readonly IShellDescriptorCache _shellDescriptorCache;

	private readonly ICompositionStrategy _compositionStrategy;

	private readonly IShellContainerFactory _shellContainerFactory;

	private readonly IExtensionManager _extensionManager;

	private readonly IShellDescriptorManager _shellDescriptorManager;

	public ILogger Logger { get; set; }

	public ShellContextFactory(IShellDescriptorCache shellDescriptorCache, ICompositionStrategy compositionStrategy, IShellContainerFactory shellContainerFactory, IExtensionManager extensionManager, IShellDescriptorManager shellDescriptorManager)
	{
		_shellDescriptorCache = shellDescriptorCache;
		_compositionStrategy = compositionStrategy;
		_shellContainerFactory = shellContainerFactory;
		_extensionManager = extensionManager;
		_shellDescriptorManager = shellDescriptorManager;
		Logger = NullLogger.Instance;
	}

	public ShellContext CreateShellContext(ShellSettings settings)
	{
		Logger.DebugFormat("Creating shell context for tenant {0}", settings.Name);
		ShellDescriptor shellDescriptor = _shellDescriptorManager.GetShellDescriptor();
		if (shellDescriptor == null || shellDescriptor.SerialNumber != 0)
		{
			throw new InvalidOperationException("ShellDescriptor.SerialNumber != 0");
		}
		List<ShellFeature> list = new List<ShellFeature>();
		foreach (FeatureDescriptor item in _extensionManager.AvailableFeatures())
		{
			bool flag = true;
			if (item != null && item.Extension != null && !string.IsNullOrEmpty(item.Extension.Module))
			{
				if (ComponentManager.Current.ModuleManager.FindUnitById(item.Extension.Module) == null)
				{
					flag = false;
				}
				else
				{
					IModule module = ComponentManager.Current.ModuleManager.FindModuleById(item.Extension.Module);
					if (module != null)
					{
						flag = module.Status == ModuleStatus.Enabled;
					}
					else if (ComponentManager.Current.ModuleManager.FindUnitById(item.Extension.Module) is ILicensedUnit licensedUnit)
					{
						ILicenseInfo licenseInfo = licensedUnit.GetLicenseInfo();
						if (licenseInfo != null && licenseInfo.Status != 0)
						{
							flag = false;
						}
					}
				}
			}
			if (flag)
			{
				list.Add(new ShellFeature
				{
					Name = item.Id
				});
			}
		}
		_shellDescriptorManager.UpdateShellDescriptor(0, list);
		ShellDescriptor shellDescriptor2 = _shellDescriptorManager.GetShellDescriptor();
		ShellBlueprint blueprint = _compositionStrategy.Compose(settings, shellDescriptor2);
		ILifetimeScope val = _shellContainerFactory.CreateContainer(settings, blueprint);
		return new ShellContext
		{
			Settings = settings,
			Descriptor = shellDescriptor2,
			Blueprint = blueprint,
			LifetimeScope = val,
			Shell = ResolutionExtensions.Resolve<IOrchardShell>((IComponentContext)(object)val)
		};
	}

	private static ShellDescriptor MinimumShellDescriptor()
	{
		ShellDescriptor shellDescriptor = new ShellDescriptor();
		shellDescriptor.SerialNumber = -1;
		shellDescriptor.Features = new ShellFeature[2]
		{
			new ShellFeature
			{
				Name = "Orchard.Framework"
			},
			new ShellFeature
			{
				Name = "Settings"
			}
		};
		return shellDescriptor;
	}

	public ShellContext CreateSetupContext(ShellSettings settings)
	{
		Logger.Debug("No shell settings available. Creating shell context for setup");
		throw new InvalidOperationException("CreateSetupContext called with settings: " + ClassSerializationHelper.SerializeObjectByJson(settings));
	}

	public ShellContext CreateDescribedContext(ShellSettings settings, ShellDescriptor shellDescriptor)
	{
		Logger.DebugFormat("Creating described context for tenant {0}", settings.Name);
		ShellBlueprint blueprint = _compositionStrategy.Compose(settings, shellDescriptor);
		ILifetimeScope val = _shellContainerFactory.CreateContainer(settings, blueprint);
		return new ShellContext
		{
			Settings = settings,
			Descriptor = shellDescriptor,
			Blueprint = blueprint,
			LifetimeScope = val,
			Shell = ResolutionExtensions.Resolve<IOrchardShell>((IComponentContext)(object)val)
		};
	}
}
