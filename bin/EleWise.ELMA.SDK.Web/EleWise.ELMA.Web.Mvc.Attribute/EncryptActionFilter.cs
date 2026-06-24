using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Attributes;

public class EncryptActionFilter : FilterAttribute, IExceptionFilter
{
	public void OnException(ExceptionContext filterContext)
	{
		Exception ex = filterContext.get_Exception();
		while (ex is TargetInvocationException && ex.InnerException != null)
		{
			ex = ex.InnerException;
		}
		IEncryptException ex2 = ComponentManager.Current.GetExtensionPoints<IEncryptException>().FirstOrDefault((IEncryptException p) => p.GetExceptions().Contains(filterContext.get_Exception().GetType()));
		if (ex2 != null)
		{
			filterContext.set_Result(ex2.OnException(filterContext.get_Exception(), ((ControllerContext)filterContext).get_Controller()));
			filterContext.set_ExceptionHandled(true);
		}
	}
}
