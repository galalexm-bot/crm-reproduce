using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.BPM.Web.Common.Components;

public class AttachmentSetBinder : DefaultModelBinder
{
	public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
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
		List<IAttachment> list = (from IAttachment q in (IEnumerable)obj
			where q == null
			select q).ToList();
		if (!list.Any())
		{
			return obj;
		}
		MethodInfo method = obj.GetType().GetMethod("Remove", new Type[1] { InterfaceActivator.TypeOf<IAttachment>() });
		foreach (IAttachment item in list)
		{
			method.Invoke(obj, new object[1] { item });
		}
		return obj;
	}
}
