// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.GuidSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки типа "Уникальный идентификатор (GUID)"</summary>
  [Serializable]
  public class GuidSettings : SimpleTypeSettings, IHasDefaultValue<Guid?>
  {
    internal static GuidSettings lcmyJAbBaerW407xeD8Q;

    /// <summary>Ctor</summary>
    public GuidSettings()
    {
      GuidSettings.RKPjOfbBwjQnd8pOIapL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected GuidSettings(SerializationInfo info, StreamingContext context)
    {
      GuidSettings.RKPjOfbBwjQnd8pOIapL();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Значение по умолчанию</summary>
    [XmlIgnore]
    [PublicationBehaviour(PublicationType.Delta)]
    public Guid? DefaultValue { get; set; }

    /// <summary>Значение по умолчанию (для сериализации)</summary>
    [JsonSerializationIgnore]
    [System.ComponentModel.DefaultValue("")]
    [XmlElement("DefaultValue")]
    [PublicationBehaviour(PublicationType.Delta)]
    public string DefaultValueStr
    {
      get
      {
        int num = 5;
        Guid? defaultValue;
        Guid guid;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (defaultValue.Value != Guid.Empty)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 6 : 3;
                continue;
              }
              goto label_8;
            case 2:
              guid = defaultValue.Value;
              num = 3;
              continue;
            case 3:
              goto label_5;
            case 4:
              if (!defaultValue.HasValue)
              {
                num = 8;
                continue;
              }
              goto case 7;
            case 5:
              defaultValue = this.DefaultValue;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 4 : 4;
              continue;
            case 6:
              defaultValue = this.DefaultValue;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 2 : 1;
              continue;
            case 7:
              defaultValue = this.DefaultValue;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
              continue;
            default:
              goto label_8;
          }
        }
label_5:
        return guid.ToString();
label_8:
        return "";
      }
      set
      {
        int num1 = 1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (!GuidSettings.VCkPCQbB43r27OECQTms((object) value))
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              this.DefaultValue = new Guid?();
              num1 = 3;
              continue;
            case 3:
              goto label_15;
            default:
              goto label_4;
          }
        }
label_15:
        return;
label_4:
        try
        {
          this.DefaultValue = new Guid?(new Guid(value));
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
            num2 = 0;
          switch (num2)
          {
          }
        }
        catch (Exception ex)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 0:
                goto label_8;
              case 1:
                GuidSettings.LXiPehbBAqmDNIJEx1Gk(GuidSettings.mIpYQRbB6Ok34hojaIqK(), (object) EleWise.ELMA.SR.T((string) GuidSettings.aS2wrjbBHfhX4QQ933aQ(1242972401 >> 4 ^ 77843223), (object) value), (object) ex);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
label_8:
          return;
label_2:;
        }
      }
    }

    internal static void RKPjOfbBwjQnd8pOIapL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool yjDLaVbBDh7LhDxyOohn() => GuidSettings.lcmyJAbBaerW407xeD8Q == null;

    internal static GuidSettings J3jqMibBtJZpaHVrtfkR() => GuidSettings.lcmyJAbBaerW407xeD8Q;

    internal static bool VCkPCQbB43r27OECQTms([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object mIpYQRbB6Ok34hojaIqK() => (object) Logger.Log;

    internal static object aS2wrjbBHfhX4QQ933aQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void LXiPehbBAqmDNIJEx1Gk([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);
  }
}
