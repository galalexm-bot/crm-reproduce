// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.CheckEmptyProperty
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class CheckEmptyProperty : ICheckEmptyProperty
  {
    public bool? IsEmpty(PropertyInfo propertyInfo, object model)
    {
      object source = propertyInfo.GetValue(model, (object[]) null);
      switch (source)
      {
        case IAddress _:
          return new bool?(string.IsNullOrEmpty(((IAddress) source).Name));
        case IEnumerable _:
          if (source.GetType().IsGenericType)
          {
            Type[] interfaces = source.GetType().GetGenericArguments()[0].GetInterfaces();
            if (((IEnumerable<Type>) interfaces).Any<Type>((Func<Type, bool>) (i => i == typeof (IEmail))))
              return new bool?(((IEnumerable) source).Cast<IEmail>().Any<IEmail>((Func<IEmail, bool>) (e => e != null && string.IsNullOrEmpty(e.EmailString))));
            if (((IEnumerable<Type>) interfaces).Any<Type>((Func<Type, bool>) (i => i == typeof (IPhone))))
              return new bool?(((IEnumerable) source).Cast<IPhone>().Any<IPhone>((Func<IPhone, bool>) (e => e != null && string.IsNullOrEmpty(e.PhoneString))));
            break;
          }
          break;
      }
      return new bool?();
    }
  }
}
