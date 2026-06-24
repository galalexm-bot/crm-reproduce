using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using Orchard.Environment.Configuration;
using Orchard.Environment.Descriptor;
using Orchard.Environment.Descriptor.Models;

namespace Orchard.Core.Settings.Descriptor;

public class ShellDescriptorManager : Component, IShellDescriptorManager, IDependency
{
	private static int serialNumber = 0;

	private static IEnumerable<string> features = Enumerable.Empty<string>();

	private readonly IShellDescriptorManagerEventHandler _events;

	private readonly IShellSettingsManager _shellSettingsManager;

	public ShellDescriptorManager(IShellDescriptorManagerEventHandler events, IShellSettingsManager shellSettingsManager)
	{
		_events = events;
		_shellSettingsManager = shellSettingsManager;
	}

	public ShellDescriptor GetShellDescriptor()
	{
		return new ShellDescriptor
		{
			SerialNumber = serialNumber,
			Features = features.Select((string name) => new ShellFeature
			{
				Name = name
			})
		};
	}

	public void UpdateShellDescriptor(int priorSerialNumber, IEnumerable<ShellFeature> enabledFeatures)
	{
		if (base.Logger.IsDebugEnabled())
		{
			base.Logger.DebugFormat("UpdateShellDescriptor priorSerialNumber: {0}, enabledFeatures: {1}", priorSerialNumber, enabledFeatures.Select((ShellFeature f) => f.Name).AsText());
		}
		if (priorSerialNumber != serialNumber)
		{
			throw new InvalidOperationException(SR.T("Invalid serial number for shell descriptor").ToString());
		}
		serialNumber++;
		features = enabledFeatures.Select((ShellFeature f) => f.Name).ToArray();
		if (priorSerialNumber > 0 && _events != null)
		{
			_events.Changed(GetShellDescriptor(), _shellSettingsManager.LoadSettings().First().Name);
		}
	}
}
