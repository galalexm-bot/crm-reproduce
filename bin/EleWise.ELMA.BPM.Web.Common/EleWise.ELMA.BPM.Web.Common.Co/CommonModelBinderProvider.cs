using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Binders;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component]
public class CommonModelBinderProvider : IModelBinderProvider
{
	public IEnumerable<KeyValuePair<Type, IModelBinder>> GetModelBinders()
	{
		AttachmentSetBinder binder = new AttachmentSetBinder();
		Type key = typeof(IList<>).MakeGenericType(InterfaceActivator.TypeOf<IAttachment>());
		yield return new KeyValuePair<Type, IModelBinder>(key, (IModelBinder)(object)binder);
		Type key2 = typeof(ISet<>).MakeGenericType(InterfaceActivator.TypeOf<IAttachment>());
		yield return new KeyValuePair<Type, IModelBinder>(key2, (IModelBinder)(object)binder);
		AttachmentBinder singleBinder = new AttachmentBinder();
		yield return new KeyValuePair<Type, IModelBinder>(typeof(IAttachment), (IModelBinder)(object)singleBinder);
		yield return new KeyValuePair<Type, IModelBinder>(InterfaceActivator.TypeOf<IAttachment>(), (IModelBinder)(object)singleBinder);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(FilterModel), (IModelBinder)(object)new FilterModelBinder());
		yield return new KeyValuePair<Type, IModelBinder>(typeof(QueryParameters), (IModelBinder)(object)new QueryParametersBinder());
	}
}
