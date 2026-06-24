// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.CrmModelBinderProvider
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class CrmModelBinderProvider : EleWise.ELMA.Web.Mvc.Binders.IModelBinderProvider
  {
    public IEnumerable<KeyValuePair<Type, IModelBinder>> GetModelBinders()
    {
      PhoneSetBinder phoneBinder = new PhoneSetBinder();
      yield return new KeyValuePair<Type, IModelBinder>(typeof (IList<>).MakeGenericType(InterfaceActivator.TypeOf<IPhone>()), (IModelBinder) phoneBinder);
      yield return new KeyValuePair<Type, IModelBinder>(typeof (Iesi.Collections.Generic.ISet<>).MakeGenericType(InterfaceActivator.TypeOf<IPhone>()), (IModelBinder) phoneBinder);
      PhoneBinder phoneSingleBinder = new PhoneBinder();
      yield return new KeyValuePair<Type, IModelBinder>(typeof (IPhone), (IModelBinder) phoneSingleBinder);
      yield return new KeyValuePair<Type, IModelBinder>(InterfaceActivator.TypeOf<IPhone>(), (IModelBinder) phoneSingleBinder);
      EmailSetBinder emailBinder = new EmailSetBinder();
      yield return new KeyValuePair<Type, IModelBinder>(typeof (IList<>).MakeGenericType(InterfaceActivator.TypeOf<IEmail>()), (IModelBinder) emailBinder);
      yield return new KeyValuePair<Type, IModelBinder>(typeof (Iesi.Collections.Generic.ISet<>).MakeGenericType(InterfaceActivator.TypeOf<IEmail>()), (IModelBinder) emailBinder);
      EmailBinder emailSingleBinder = new EmailBinder();
      yield return new KeyValuePair<Type, IModelBinder>(typeof (IEmail), (IModelBinder) emailSingleBinder);
      yield return new KeyValuePair<Type, IModelBinder>(InterfaceActivator.TypeOf<IEmail>(), (IModelBinder) emailSingleBinder);
    }
  }
}
