using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.UI.Results;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.UI.ResultConverters;

namespace EleWise.ELMA.Web.Mvc.Models.UI;

[Component]
public class UIDynamicFormWebProvider : IDynamicFormWebProvider
{
	public Dictionary<string, object> GetExtendedData(Controller controller, DynamicFormResultData resultData)
	{
		Contract.ArgumentNotNull(controller, "controller");
		Contract.ArgumentNotNull(resultData, "resultData");
		if (resultData.Data.TryGetValue("UIFormResult", out var value))
		{
			BaseController baseController = controller as BaseController;
			FormResult formResult = value as FormResult;
			if (baseController != null && formResult != null)
			{
				IFormResultConverter converter = UIController.GetConverter(formResult.GetType());
				if (converter != null)
				{
					return converter.GetClientData(formResult, baseController);
				}
			}
		}
		return null;
	}
}
