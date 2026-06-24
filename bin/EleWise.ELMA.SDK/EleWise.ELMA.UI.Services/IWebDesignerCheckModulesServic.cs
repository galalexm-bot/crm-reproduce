using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.UI.Services;

public interface IWebDesignerCheckModulesService
{
	CheckDesignerModuleResult[] CheckWebDesigner();

	void ClearCache();
}
