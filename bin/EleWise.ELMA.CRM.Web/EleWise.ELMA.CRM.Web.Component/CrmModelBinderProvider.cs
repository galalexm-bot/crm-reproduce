using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Binders;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class CrmModelBinderProvider : IModelBinderProvider
{
	public IEnumerable<KeyValuePair<Type, IModelBinder>> GetModelBinders()
	{
		PhoneSetBinder phoneBinder = new PhoneSetBinder();
		Type key = typeof(IList<>).MakeGenericType(InterfaceActivator.TypeOf<IPhone>());
		yield return new KeyValuePair<Type, IModelBinder>(key, (IModelBinder)(object)phoneBinder);
		Type key2 = typeof(ISet<>).MakeGenericType(InterfaceActivator.TypeOf<IPhone>());
		yield return new KeyValuePair<Type, IModelBinder>(key2, (IModelBinder)(object)phoneBinder);
		PhoneBinder phoneSingleBinder = new PhoneBinder();
		yield return new KeyValuePair<Type, IModelBinder>(typeof(IPhone), (IModelBinder)(object)phoneSingleBinder);
		yield return new KeyValuePair<Type, IModelBinder>(InterfaceActivator.TypeOf<IPhone>(), (IModelBinder)(object)phoneSingleBinder);
		EmailSetBinder emailBinder = new EmailSetBinder();
		Type key3 = typeof(IList<>).MakeGenericType(InterfaceActivator.TypeOf<IEmail>());
		yield return new KeyValuePair<Type, IModelBinder>(key3, (IModelBinder)(object)emailBinder);
		Type key4 = typeof(ISet<>).MakeGenericType(InterfaceActivator.TypeOf<IEmail>());
		yield return new KeyValuePair<Type, IModelBinder>(key4, (IModelBinder)(object)emailBinder);
		EmailBinder emailSingleBinder = new EmailBinder();
		yield return new KeyValuePair<Type, IModelBinder>(typeof(IEmail), (IModelBinder)(object)emailSingleBinder);
		yield return new KeyValuePair<Type, IModelBinder>(InterfaceActivator.TypeOf<IEmail>(), (IModelBinder)(object)emailSingleBinder);
	}
}
