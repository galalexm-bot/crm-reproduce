using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEncryptException
{
	IEnumerable<Type> GetExceptions();

	ActionResult OnException(Exception exception, ControllerBase controller);

	void RenderExceptionPartial(HtmlHelper html, Exception exception);
}
