using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.Tasks.Components;

[Component(Order = 400, Type = ComponentType.Server)]
internal class UpdateWorkLogExtensionSettings : IModuleContainerEvents
{
	public void UpdateSettings()
	{
		foreach (IWorkLogExtension item in WorkLogExtensionHelper.ExtensionList())
		{
			WorkLogExtensionSettings workLogExtensionSettings = item.LoadSettings();
			if (workLogExtensionSettings.Enabled)
			{
				workLogExtensionSettings.EnabledObjectsUids = item.ObjectUidList;
				workLogExtensionSettings.Enabled = false;
				item.SaveSettings(workLogExtensionSettings);
			}
		}
	}

	public void Activated()
	{
		UpdateSettings();
	}

	public void Terminating()
	{
	}
}
