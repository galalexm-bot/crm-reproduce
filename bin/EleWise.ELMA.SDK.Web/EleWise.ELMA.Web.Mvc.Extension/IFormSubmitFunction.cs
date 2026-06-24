using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Transient, ComponentType.All)]
public interface IFormSubmitFunction
{
	bool SupportFormViewModel(FormViewModel formViewModel);

	string FunctionName(FormViewModel formViewModel);
}
