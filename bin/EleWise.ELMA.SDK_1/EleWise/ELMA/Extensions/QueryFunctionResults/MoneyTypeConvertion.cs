// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.MoneyTypeConvertion
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
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
  public class MoneyTypeConvertion : IQueryTypeConvertion
  {
    internal static MoneyTypeConvertion lvW7auGyPrErxtR8AJRK;

    public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
    {
      int num = 5;
      Type c;
      while (true)
      {
        PropertyInfo propertyInfo;
        Type type;
        switch (num)
        {
          case 1:
            type = MoneyTypeConvertion.x1e2PwGytntcNuiOJn33((object) propertyInfo);
            break;
          case 2:
            propertyInfo = (PropertyInfo) MoneyTypeConvertion.YXkuGuGyaEJPokiEGFmx(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(MoneyTypeConvertion.pvbVwbGypSB9iuPtUiWf((object) metadata)), (object) propName);
            num = 3;
            continue;
          case 3:
            if (!MoneyTypeConvertion.Y5tN28GyDZgaBbfeQd5S((object) propertyInfo, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
              continue;
            }
            type = (Type) null;
            break;
          case 4:
            // ISSUE: type reference
            if (MoneyTypeConvertion.EhwAqxGy3TAjcksAvIMs(__typeref (double)).IsAssignableFrom(valueType))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 2 : 1;
              continue;
            }
            goto label_11;
          case 5:
            // ISSUE: type reference
            if (!MoneyTypeConvertion.EhwAqxGy3TAjcksAvIMs(__typeref (long)).IsAssignableFrom(valueType))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 4 : 4;
              continue;
            }
            goto case 2;
          case 6:
            goto label_5;
          case 7:
            if (!(c != (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 6 : 2;
              continue;
            }
            goto label_4;
          case 8:
            goto label_4;
          case 9:
            goto label_11;
          default:
            if (!MoneyTypeConvertion.BnnOG4GywS2iy6cOdvi0(MoneyTypeConvertion.x1e2PwGytntcNuiOJn33((object) propertyInfo)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 1;
              continue;
            }
            type = MoneyTypeConvertion.x1e2PwGytntcNuiOJn33((object) propertyInfo).GetNonNullableType();
            break;
        }
        c = type;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 7;
      }
label_4:
      // ISSUE: type reference
      return MoneyTypeConvertion.EhwAqxGy3TAjcksAvIMs(__typeref (Money)).IsAssignableFrom(c);
label_5:
      return false;
label_11:
      return false;
    }

    public object ConvertValue(EntityMetadata metadata, string propName, object value) => (object) MoneyTypeConvertion.ONucF8Gy6fsAhpg0s5lh(MoneyTypeConvertion.VLKofeGy4br23RZoNxj8(value));

    public MoneyTypeConvertion()
    {
      MoneyTypeConvertion.e7GumaGyHFWdutdm7qZS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type EhwAqxGy3TAjcksAvIMs([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Guid pvbVwbGypSB9iuPtUiWf([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object YXkuGuGyaEJPokiEGFmx(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static bool Y5tN28GyDZgaBbfeQd5S([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static Type x1e2PwGytntcNuiOJn33([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static bool BnnOG4GywS2iy6cOdvi0(Type type) => type.IsNullableType();

    internal static bool L0Bn1rGy1NVwF0sniAho() => MoneyTypeConvertion.lvW7auGyPrErxtR8AJRK == null;

    internal static MoneyTypeConvertion JVHnsWGyNcMBoOTHIoij() => MoneyTypeConvertion.lvW7auGyPrErxtR8AJRK;

    internal static double VLKofeGy4br23RZoNxj8([In] object obj0) => Convert.ToDouble(obj0);

    internal static Money ONucF8Gy6fsAhpg0s5lh(double d) => (Money) d;

    internal static void e7GumaGyHFWdutdm7qZS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
