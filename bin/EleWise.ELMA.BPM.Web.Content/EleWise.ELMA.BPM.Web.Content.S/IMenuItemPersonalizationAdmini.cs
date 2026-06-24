using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;

namespace EleWise.ELMA.BPM.Web.Content.Services;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IMenuItemPersonalizationAdministration
{
	void SaveState(IMenuItem newItem, IMenuItem oldItem);

	IMenuItem GetTransformedItem(IMenuItem item);

	void ResetState();
}
