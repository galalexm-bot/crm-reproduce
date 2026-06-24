// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Attributes.AssemblyLicenseUnitAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Modules.Attributes
{
  /// <summary>Указывает тип, осуществляющий лицензирование сборки</summary>
  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public class AssemblyLicenseUnitAttribute : Attribute
  {
    private ComponentType componentType;
    private Type licenseUnitType;
    internal static AssemblyLicenseUnitAttribute jZxMFfaFgPmZuEtNGGU;

    /// <summary>Ctor</summary>
    /// <param name="componentType">Тип компонента, для которого применяется лицензирование</param>
    /// <param name="licenseUnitType">Тип модуля</param>
    public AssemblyLicenseUnitAttribute(ComponentType componentType, Type licenseUnitType)
    {
      AssemblyLicenseUnitAttribute.X84CXyaouqgQHxpT8IV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.componentType = componentType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 2;
            continue;
          case 2:
            this.licenseUnitType = licenseUnitType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>
    /// Тип компонента, для которого применяется лицензирование
    /// </summary>
    public ComponentType ComponentType => this.componentType;

    /// <summary>Тип модуля</summary>
    public Type LicenseUnitType => this.licenseUnitType;

    internal static void X84CXyaouqgQHxpT8IV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool j8hdN4aBpAIbb5XZtjO() => AssemblyLicenseUnitAttribute.jZxMFfaFgPmZuEtNGGU == null;

    internal static AssemblyLicenseUnitAttribute iKyCOBaWUSfmyBKU8nZ() => AssemblyLicenseUnitAttribute.jZxMFfaFgPmZuEtNGGU;
  }
}
