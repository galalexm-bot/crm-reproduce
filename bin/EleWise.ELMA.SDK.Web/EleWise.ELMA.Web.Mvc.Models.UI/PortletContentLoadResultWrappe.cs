using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.UI.Results;

namespace EleWise.ELMA.Web.Mvc.Models.UI;

public class PortletContentLoadResultWrapper : FormResult
{
	public PortletContentLoadResult Result { get; private set; }

	public DynamicFormSettings DynamicFormSettings { get; set; }

	public PortletContentLoadResultWrapper(PortletContentLoadResult result, DynamicFormSettings dynamicFormSettings)
	{
		Contract.ArgumentNotNull(result, "result");
		Result = result;
		DynamicFormSettings = dynamicFormSettings;
	}
}
