// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator.EntitySetPropertyMethodInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate.Properties;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator
{
  internal class EntitySetPropertyMethodInfo : EntityMethodInfo
  {
    private readonly ParameterInfo[] getParameters;
    private readonly ISetter setter;
    private readonly object defaultValue;
    private static EntitySetPropertyMethodInfo qJ0hqrhi88cJ22OIt6MZ;

    public EntitySetPropertyMethodInfo(
      Type declaringType,
      Type reflectedType,
      string name,
      Type type,
      ISetter setter)
    {
      EntitySetPropertyMethodInfo.ntsf9ghiImywPuD7XPed();
      // ISSUE: explicit constructor call
      base.\u002Ector(declaringType, reflectedType, (string) EntitySetPropertyMethodInfo.Wl79K4hiV2Cs0cJD6gGn(-1978478350 ^ -1978475394) + name);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.getParameters = (ParameterInfo[]) new EntityMethodInfo.EntityMethodParameterInfo[1]
            {
              new EntityMethodInfo.EntityMethodParameterInfo((MemberInfo) this, type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323103044), 0)
            };
            num = 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.ReturnParameter = (ParameterInfo) new EntityMethodInfo.EntityMethodParameterInfo((MemberInfo) this, typeof (void));
            num = 4;
            continue;
          case 4:
            this.setter = setter;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
            continue;
          default:
            this.defaultValue = EntitySetPropertyMethodInfo.lafJG4hiSl4L8xJy6Dq4(type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 2;
            continue;
        }
      }
label_3:;
    }

    public override Type ReturnType => EntitySetPropertyMethodInfo.AIv1dBhiiLhCcKk7oBac(__typeref (void));

    public override ParameterInfo ReturnParameter { get; }

    public override ParameterInfo[] GetParameters() => this.getParameters;

    public override object Invoke(
      object obj,
      BindingFlags invokeAttr,
      Binder binder,
      object[] parameters,
      CultureInfo culture)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ISetter setter = this.setter;
            object obj1 = obj;
            object parameter = parameters[0];
            object obj2 = parameter == null ? this.defaultValue : parameter;
            EntitySetPropertyMethodInfo.DJSBZQhiRA6IhN9nDUYo((object) setter, obj1, obj2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) null;
    }

    internal static void ntsf9ghiImywPuD7XPed() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object Wl79K4hiV2Cs0cJD6gGn(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object lafJG4hiSl4L8xJy6Dq4(Type type) => type.DefaultValue();

    internal static bool Akjn0shiZZPSJ7NpLMZU() => EntitySetPropertyMethodInfo.qJ0hqrhi88cJ22OIt6MZ == null;

    internal static EntitySetPropertyMethodInfo nGf0OMhiusXciUUJAw5V() => EntitySetPropertyMethodInfo.qJ0hqrhi88cJ22OIt6MZ;

    internal static Type AIv1dBhiiLhCcKk7oBac([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void DJSBZQhiRA6IhN9nDUYo([In] object obj0, [In] object obj1, [In] object obj2) => ((ISetter) obj0).Set(obj1, obj2);
  }
}
