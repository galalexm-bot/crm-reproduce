using System.Collections.Generic;
using EleWise.ELMA.Logging;
using Orchard.Environment.Descriptor;
using Orchard.Environment.Descriptor.Models;
using Orchard.Environment.Extensions;
using Orchard.Environment.Extensions.Models;
using Orchard.Localization;

namespace Orchard.Environment.Features;

public class FeatureManager : IFeatureManager, IDependency
{
	private readonly IExtensionManager _extensionManager;

	private readonly IShellDescriptorManager _shellDescriptorManager;

	public Localizer T { get; set; }

	public ILogger Logger { get; set; }

	public FeatureManager(IExtensionManager extensionManager, IShellDescriptorManager shellDescriptorManager)
	{
		_extensionManager = extensionManager;
		_shellDescriptorManager = shellDescriptorManager;
		T = NullLocalizer.Instance;
		Logger = NullLogger.Instance;
	}

	public IEnumerable<FeatureDescriptor> GetAvailableFeatures()
	{
		return _extensionManager.AvailableFeatures();
	}

	public IEnumerable<FeatureDescriptor> GetEnabledFeatures()
	{
		ShellDescriptor shellDescriptor = _shellDescriptorManager.GetShellDescriptor();
		return _extensionManager.EnabledFeatures(shellDescriptor);
	}
}
