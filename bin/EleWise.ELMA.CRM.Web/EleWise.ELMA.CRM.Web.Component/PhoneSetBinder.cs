using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Web.Components;

public class PhoneSetBinder : DefaultModelBinder
{
	private RunWithSoftDeletableService runWithSoftDeletableService;

	private RunWithSoftDeletableService RunWithSoftDeletableService => runWithSoftDeletableService ?? (runWithSoftDeletableService = Locator.GetService<RunWithSoftDeletableService>());

	public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		bool turned = RunWithSoftDeletableService.Turned;
		RunWithSoftDeletableService.Turned = true;
		try
		{
			object obj;
			try
			{
				obj = ((DefaultModelBinder)this).BindModel(controllerContext, bindingContext);
			}
			catch
			{
				return null;
			}
			if (!(obj is IEnumerable))
			{
				return obj;
			}
			List<IPhone> list = (from IPhone q in (IEnumerable)obj
				where q == null || string.IsNullOrWhiteSpace(q.PhoneString)
				select q).ToList();
			if (!list.Any())
			{
				return obj;
			}
			MethodInfo method = obj.GetType().GetMethod("Remove", new Type[1] { InterfaceActivator.TypeOf<IPhone>() });
			foreach (IPhone item in list)
			{
				method.Invoke(obj, new object[1] { item });
			}
			return obj;
		}
		finally
		{
			RunWithSoftDeletableService.Turned = turned;
		}
	}
}
