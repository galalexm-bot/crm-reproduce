// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.PropertyAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут свойства класса</summary>
  [AttributeUsage(AttributeTargets.Property)]
  public class PropertyAttribute : Attribute
  {
    private Guid typeUid;
    private Guid subTypeUid;
    private static PropertyAttribute zZWrmroVv8buulErSYmC;

    /// <summary>Новый атрибут свойства класса</summary>
    /// <param name="typeUid">UID типа атрибута</param>
    public PropertyAttribute(string typeUid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            Contract.ArgumentNotNull((object) typeUid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272478325));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
            continue;
          default:
            this.typeUid = new Guid(typeUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Новый атрибут свойства класса</summary>
    /// <param name="typeUid">UID типа атрибута</param>
    /// <param name="subTypeUid">UID подтипа атрибута</param>
    public PropertyAttribute(string typeUid, string subTypeUid)
    {
      PropertyAttribute.WiNlpZoVuuFEexCSs5Fy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.typeUid = new Guid(typeUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 2:
            Contract.ArgumentNotNull((object) typeUid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217640391));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 3 : 3;
            continue;
          case 3:
            Contract.ArgumentNotNull((object) subTypeUid, (string) PropertyAttribute.oFUrAboVIWPLosTqmgbs(44884861 ^ 45005481));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 1;
            continue;
          case 4:
            goto label_3;
          default:
            this.subTypeUid = new Guid(subTypeUid);
            num = 4;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Новый атрибут свойства класса</summary>
    /// <param name="typeUid">UID типа атрибута</param>
    public PropertyAttribute(Guid typeUid)
    {
      PropertyAttribute.WiNlpZoVuuFEexCSs5Fy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.typeUid = typeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Новый атрибут свойства класса</summary>
    /// <param name="typeUid">UID типа атрибута</param>
    /// <param name="subTypeUid">UID подтипа атрибута</param>
    public PropertyAttribute(Guid typeUid, Guid subTypeUid)
    {
      PropertyAttribute.WiNlpZoVuuFEexCSs5Fy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.typeUid = typeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
            continue;
          default:
            this.subTypeUid = subTypeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>UID типа данных</summary>
    public Guid TypeUid => this.typeUid;

    /// <summary>UID подтипа данных</summary>
    public Guid SubTypeUid => this.subTypeUid;

    internal static bool BWUVpvoV8tCeejnTpqGH() => PropertyAttribute.zZWrmroVv8buulErSYmC == null;

    internal static PropertyAttribute gHbOH8oVZKaVaLLIHyMO() => PropertyAttribute.zZWrmroVv8buulErSYmC;

    internal static void WiNlpZoVuuFEexCSs5Fy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object oFUrAboVIWPLosTqmgbs(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
