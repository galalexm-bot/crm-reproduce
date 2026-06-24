using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.UI.Results;

namespace EleWise.ELMA.Web.Mvc.Models.UI;

public class PageLoadResultWrapper : FormResult
{
	public PageLoadResult Result { get; private set; }

	public DynamicFormSettings DynamicFormSettings { get; set; }

	public PageLoadResultWrapper(PageLoadResult result, DynamicFormSettings dynamicFormSettings)
	{
		Contract.ArgumentNotNull(result, "result");
		Result = result;
		DynamicFormSettings = dynamicFormSettings;
	}
}
