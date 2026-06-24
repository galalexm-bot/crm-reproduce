using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;

namespace EleWise.ELMA.BPM.Web.Content.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterActionLinkReadOnlyExtension
{
	bool MustBeReadOnly(IFilterActionLink filterActionLink);
}
