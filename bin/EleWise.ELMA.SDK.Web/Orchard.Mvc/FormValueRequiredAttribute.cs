using System.Reflection;
using System.Web.Mvc;

namespace Orchard.Mvc;

public class FormValueRequiredAttribute : ActionMethodSelectorAttribute
{
	private readonly string _submitButtonName;

	public FormValueRequiredAttribute(string submitButtonName)
	{
		_submitButtonName = submitButtonName;
	}

	public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
	{
		return !string.IsNullOrEmpty(controllerContext.get_HttpContext().Request.Form[_submitButtonName]);
	}
}
