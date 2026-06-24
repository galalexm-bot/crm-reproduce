using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Web.Mvc.Html.Grids;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IDynamicGridExtension
{
	bool MatchUniqueName(string uniqueName);

	void Apply<T>(DynamicGridBuilder<T> builder) where T : class;
}
