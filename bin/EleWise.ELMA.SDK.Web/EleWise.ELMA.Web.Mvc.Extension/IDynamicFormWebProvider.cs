using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IDynamicFormWebProvider
{
	Dictionary<string, object> GetExtendedData(Controller controller, DynamicFormResultData resultData);
}
