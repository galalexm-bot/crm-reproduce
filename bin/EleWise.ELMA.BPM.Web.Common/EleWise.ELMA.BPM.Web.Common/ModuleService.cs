using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.UI;
using Orchard.Environment.Descriptor;
using Orchard.Environment.Descriptor.Models;
using Orchard.Environment.Extensions;
using Orchard.Environment.Extensions.Models;

namespace EleWise.ELMA.BPM.Web.Common;

[Service(Scope = ServiceScope.UnitOfWork)]
public class ModuleService : IModuleService
{
	private readonly IExtensionManager _extensionManager;

	private readonly IShellDescriptorManager _shellDescriptorManager;

	private readonly INotifier _notifier;

	public ModuleService(IExtensionManager extensionManager, IShellDescriptorManager shellDescriptorManager, INotifier notifier)
	{
		_extensionManager = extensionManager;
		_shellDescriptorManager = shellDescriptorManager;
		_notifier = notifier;
	}

	public IEnumerable<ModuleFeature> GetAvailableFeatures()
	{
		IEnumerable<ShellFeature> enabledFeatures = _shellDescriptorManager.GetShellDescriptor().Features;
		return from f in _extensionManager.AvailableExtensions().SelectMany((ExtensionDescriptor m) => _extensionManager.LoadFeatures(m.Features))
			select AssembleModuleFromDescriptor(f, enabledFeatures.FirstOrDefault((ShellFeature sf) => string.Equals(sf.Name, f.Descriptor.Id, StringComparison.OrdinalIgnoreCase)) != null);
	}

	public void EnableFeatures(IEnumerable<string> featureNames)
	{
		EnableFeatures(featureNames, force: false);
	}

	public void EnableFeatures(IEnumerable<string> features, bool force)
	{
		ShellDescriptor shellDescriptor = _shellDescriptorManager.GetShellDescriptor();
		List<ShellFeature> list = shellDescriptor.Features.ToList();
		List<ModuleFeature> availableFeatures = GetAvailableFeatures().ToList();
		IEnumerable<string> enumerable = features.Select((string s) => EnableFeature(s, availableFeatures, force)).ToList().SelectMany((IEnumerable<string> ies) => ies.Select((string s) => s));
		if (enumerable.Count() == 0)
		{
			return;
		}
		foreach (string item in enumerable)
		{
			string name = item;
			list.Add(new ShellFeature
			{
				Name = name
			});
			_notifier.Information(SR.T("{0} was enabled", item));
		}
		_shellDescriptorManager.UpdateShellDescriptor(shellDescriptor.SerialNumber, list);
	}

	public void DisableFeatures(IEnumerable<string> featureNames)
	{
		DisableFeatures(featureNames, force: false);
	}

	public void DisableFeatures(IEnumerable<string> features, bool force)
	{
		ShellDescriptor shellDescriptor = _shellDescriptorManager.GetShellDescriptor();
		List<ShellFeature> list = shellDescriptor.Features.ToList();
		List<ModuleFeature> availableFeatures = GetAvailableFeatures().ToList();
		IEnumerable<string> enumerable = features.Select((string s) => DisableFeature(s, availableFeatures, force)).ToList().SelectMany((IEnumerable<string> ies) => ies.Select((string s) => s));
		if (enumerable.Count() == 0)
		{
			return;
		}
		foreach (string item in enumerable)
		{
			string feature = item;
			list.RemoveAll((ShellFeature f) => f.Name == feature);
			_notifier.Information(SR.T("{0} was disabled", feature));
		}
		_shellDescriptorManager.UpdateShellDescriptor(shellDescriptor.SerialNumber, list);
	}

	private IEnumerable<string> EnableFeature(string featureName, IEnumerable<ModuleFeature> features, bool force)
	{
		List<ModuleFeature> features2 = features.ToList();
		Func<string, IEnumerable<ModuleFeature>, IEnumerable<ModuleFeature>> getAffectedDependencies = delegate(string n, IEnumerable<ModuleFeature> fs)
		{
			ModuleFeature moduleFeature = fs.Single((ModuleFeature f) => f.Descriptor.Id == n);
			return (moduleFeature.Descriptor.Dependencies == null) ? Enumerable.Empty<ModuleFeature>() : (from fn in moduleFeature.Descriptor.Dependencies
				select fs.Single((ModuleFeature f) => f.Descriptor.Id == fn) into f
				where !f.IsEnabled
				select f);
		};
		IEnumerable<string> affectedFeatures = GetAffectedFeatures(featureName, features2, getAffectedDependencies);
		if (affectedFeatures.Count() > 1 && !force)
		{
			GenerateWarning("If you want {0} enabled, then you'll also need to enable {1}.", featureName, affectedFeatures.Where((string fn) => fn != featureName));
			return Enumerable.Empty<string>();
		}
		return affectedFeatures;
	}

	private IEnumerable<string> DisableFeature(string featureName, IEnumerable<ModuleFeature> features, bool force)
	{
		List<ModuleFeature> features2 = features.ToList();
		Func<string, IEnumerable<ModuleFeature>, IEnumerable<ModuleFeature>> getAffectedDependencies = (string n, IEnumerable<ModuleFeature> fs) => fs.Where((ModuleFeature f) => f.IsEnabled && f.Descriptor.Dependencies != null && f.Descriptor.Dependencies.Contains(n));
		IEnumerable<string> affectedFeatures = GetAffectedFeatures(featureName, features2, getAffectedDependencies);
		if (affectedFeatures.Count() > 1 && !force)
		{
			GenerateWarning("If {0} is disabled, then you'll also lose {1}.", featureName, affectedFeatures.Where((string fn) => fn != featureName));
			return Enumerable.Empty<string>();
		}
		return affectedFeatures;
	}

	private static IEnumerable<string> GetAffectedFeatures(string featureName, IEnumerable<ModuleFeature> features, Func<string, IEnumerable<ModuleFeature>, IEnumerable<ModuleFeature>> getAffectedDependencies)
	{
		List<string> list = new List<string> { featureName };
		foreach (ModuleFeature item in getAffectedDependencies(featureName, features))
		{
			list.AddRange(GetAffectedFeatures(item.Descriptor.Id, features, getAffectedDependencies));
		}
		return list;
	}

	private void GenerateWarning(string messageFormat, string featureName, IEnumerable<string> featuresInQuestion)
	{
		if (featuresInQuestion.Count() >= 1)
		{
			_notifier.Warning(SR.T(messageFormat, featureName, (featuresInQuestion.Count() > 1) ? string.Join("", featuresInQuestion.Select((string fn, int i) => SR.T((i == featuresInQuestion.Count() - 1) ? "{0}" : ((i == featuresInQuestion.Count() - 2) ? "{0} and " : "{0}, "), fn).ToString()).ToArray()) : featuresInQuestion.First()));
		}
	}

	private static ModuleFeature AssembleModuleFromDescriptor(Feature feature, bool isEnabled)
	{
		return new ModuleFeature
		{
			Descriptor = feature.Descriptor,
			IsEnabled = isEnabled
		};
	}
}
