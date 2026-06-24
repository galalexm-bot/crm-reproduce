// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.Int16TypeConvertion
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions.QueryFunctionResults
{
  [Component]
  public class Int16TypeConvertion : IQueryTypeConvertion
  {
    internal static Int16TypeConvertion J4BYb6GyQuT9KSdJEdck;

    public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
    {
      int num = 1;
      Type c;
      while (true)
      {
        PropertyInfo propertyInfo;
        Type type;
        switch (num)
        {
          case 1:
            if (!typeof (long).IsAssignableFrom(valueType))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            }
            propertyInfo = (PropertyInfo) Int16TypeConvertion.p32s3PGy8wI4ryMXr9Ek(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(metadata.Uid), (object) propName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 4 : 2;
            continue;
          case 2:
            if (Int16TypeConvertion.cBRRJXGyI4OoV9wh32qe(Int16TypeConvertion.xwIv2UGyutLufUcFJZFK((object) propertyInfo)))
            {
              type = Int16TypeConvertion.mgkhJCGyVyfv6EVkiCFp(Int16TypeConvertion.xwIv2UGyutLufUcFJZFK((object) propertyInfo));
              break;
            }
            num = 3;
            continue;
          case 3:
            type = Int16TypeConvertion.xwIv2UGyutLufUcFJZFK((object) propertyInfo);
            break;
          case 4:
            if (!Int16TypeConvertion.Gfa6oWGyZM03vTJjXRxX((object) propertyInfo, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 2;
              continue;
            }
            type = (Type) null;
            break;
          case 5:
            goto label_4;
          case 6:
            if (c != (Type) null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 5 : 1;
              continue;
            }
            goto label_5;
          default:
            goto label_11;
        }
        c = type;
        num = 6;
      }
label_4:
      return typeof (short).IsAssignableFrom(c);
label_5:
      return false;
label_11:
      return false;
    }

    public object ConvertValue(EntityMetadata metadata, string propName, object value) => (object) Int16TypeConvertion.auc5ruGySGoeZwSgrIOy(value);

    public Int16TypeConvertion()
    {
      Int16TypeConvertion.dr765VGyiOdhDLydVSTd();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object p32s3PGy8wI4ryMXr9Ek(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static bool Gfa6oWGyZM03vTJjXRxX([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static Type xwIv2UGyutLufUcFJZFK([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static bool cBRRJXGyI4OoV9wh32qe(Type type) => type.IsNullableType();

    internal static Type mgkhJCGyVyfv6EVkiCFp(Type type) => type.GetNonNullableType();

    internal static bool kXfdaYGyCkSQWuPqAeS1() => Int16TypeConvertion.J4BYb6GyQuT9KSdJEdck == null;

    internal static Int16TypeConvertion ylvT3hGyvmKYRJK8sJkG() => Int16TypeConvertion.J4BYb6GyQuT9KSdJEdck;

    internal static short auc5ruGySGoeZwSgrIOy([In] object obj0) => Convert.ToInt16(obj0);

    internal static void dr765VGyiOdhDLydVSTd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
