// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator.EntityGetPropertyMethodInfo
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
  internal class EntityGetPropertyMethodInfo : EntityMethodInfo
  {
    private static readonly ParameterInfo[] getParameters;
    private readonly IGetter getter;
    internal static EntityGetPropertyMethodInfo l4QiEwhiGebbhmqL79wm;

    public EntityGetPropertyMethodInfo(
      Type declaringType,
      Type reflectedType,
      string name,
      Type type,
      IGetter getter)
    {
      EntityGetPropertyMethodInfo.ylWbFKhiQmvgq6JxX27i();
      // ISSUE: explicit constructor call
      base.\u002Ector(declaringType, reflectedType, (string) EntityGetPropertyMethodInfo.I0vZE8hiCeRnUvqxY5Vj((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921201341), (object) name));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.getter = getter;
            num = 3;
            continue;
          case 2:
            this.ReturnParameter = (ParameterInfo) new EntityMethodInfo.EntityMethodParameterInfo((MemberInfo) this, type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            this.ReturnType = type;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    public override Type ReturnType { get; }

    public override ParameterInfo ReturnParameter { get; }

    public override ParameterInfo[] GetParameters() => EntityGetPropertyMethodInfo.getParameters;

    public override object Invoke(
      object obj,
      BindingFlags invokeAttr,
      Binder binder,
      object[] parameters,
      CultureInfo culture)
    {
      return EntityGetPropertyMethodInfo.t1t5GShivy8LDQ2e5VB4((object) this.getter, obj);
    }

    static EntityGetPropertyMethodInfo()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            EntityGetPropertyMethodInfo.ylWbFKhiQmvgq6JxX27i();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            EntityGetPropertyMethodInfo.getParameters = new ParameterInfo[0];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void ylWbFKhiQmvgq6JxX27i() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object I0vZE8hiCeRnUvqxY5Vj([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool pL5jwlhiEtlR8wnUafnU() => EntityGetPropertyMethodInfo.l4QiEwhiGebbhmqL79wm == null;

    internal static EntityGetPropertyMethodInfo SnMMldhifbR0e0A2e2aW() => EntityGetPropertyMethodInfo.l4QiEwhiGebbhmqL79wm;

    internal static object t1t5GShivy8LDQ2e5VB4([In] object obj0, [In] object obj1) => ((IGetter) obj0).Get(obj1);
  }
}
