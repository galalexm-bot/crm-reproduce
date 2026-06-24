using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Binders;

namespace EleWise.ELMA.BPM.Web.Common.Components;

public class QueryParametersBinder : ElmaModelBinder
{
	public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		if (!(bindingContext.get_Model() is QueryParameters queryParameters))
		{
			return base.BindModel(controllerContext, bindingContext);
		}
		foreach (string item in (from i in GetZeroBasedIndexes()
			select bindingContext.get_ModelName() + "[" + i + "]").TakeWhile((string prefix) => bindingContext.get_ValueProvider().ContainsPrefix(prefix + "__ParameterName")))
		{
			Type type = ReflectionType.GetType(bindingContext.GetValue<string>(item + "__ParameterType"));
			object model = ((type.IsGenericType && type.GetGenericTypeDefinition() == TypeOf.Iesi_ISet.Raw) ? Activator.CreateInstance(TypeOf.Iesi_HashedSet.Raw.MakeGenericType(type.GetGenericArguments()[0])) : null);
			ModelMetadata modelMetadata = new ModelMetadata(ModelMetadataProviders.get_Current(), (Type)null, (model != null) ? ((Func<object>)(() => model)) : null, type, (string)null);
			ModelBindingContext val = new ModelBindingContext();
			val.set_ModelMetadata(modelMetadata);
			val.set_ModelName(item);
			val.set_ModelState(bindingContext.get_ModelState());
			val.set_PropertyFilter(bindingContext.get_PropertyFilter());
			val.set_ValueProvider(bindingContext.get_ValueProvider());
			ModelBindingContext bindingContext2 = val;
			queryParameters.Set(bindingContext.GetValue<string>(item + "__ParameterName"), base.BindModel(controllerContext, bindingContext2));
		}
		return queryParameters;
	}

	private static IEnumerable<int> GetZeroBasedIndexes()
	{
		int i = 0;
		while (true)
		{
			yield return i;
			i++;
		}
	}
}
