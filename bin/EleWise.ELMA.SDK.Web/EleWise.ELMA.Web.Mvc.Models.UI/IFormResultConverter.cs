using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.UI.Results;
using EleWise.ELMA.Web.Mvc.Controllers;

namespace EleWise.ELMA.Web.Mvc.Models.UI.ResultConverters;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface IFormResultConverter
{
	Type ResultType { get; }

	ActionResult Convert(FormResult result, BaseController controller);

	Dictionary<string, object> GetClientData(FormResult result, BaseController controller);
}
