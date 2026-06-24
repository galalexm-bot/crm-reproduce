using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Content.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IContentFilterMenuItemIdExtension
{
	bool SetParameters(IFilterActionLink action, ActionRoute route, ref bool canMakeDefault);
}
