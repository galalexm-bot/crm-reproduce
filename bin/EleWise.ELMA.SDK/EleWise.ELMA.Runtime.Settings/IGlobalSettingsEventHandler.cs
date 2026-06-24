using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Runtime.Settings.Events;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IGlobalSettingsEventHandler : IEventHandler
{
	void ChangeSetting(EditGlobalSettingsEventArgs args);

	void LoadSettings(IStoreValuesObject settings);
}
