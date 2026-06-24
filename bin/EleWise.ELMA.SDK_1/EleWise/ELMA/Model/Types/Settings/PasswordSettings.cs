// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.PasswordSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки пароля</summary>
  [Serializable]
  public class PasswordSettings : SimpleTypeSettings
  {
    private static PasswordSettings BdyLKOosBNar1EaMmPSL;

    /// <summary>Ctor</summary>
    public PasswordSettings()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected PasswordSettings(SerializationInfo info, StreamingContext context)
    {
      PasswordSettings.nZuXlhosbyjFZMKEPXMm();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Тип хранения пароля</summary>
    [XmlIgnore]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Тип хранения пароля')")]
    public Guid PasswordType
    {
      get => this.\u003CPasswordType\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CPasswordType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Тип хранения пароля (для сериализации)</summary>
    [JsonSerializationIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DefaultValue("")]
    [Browsable(false)]
    [XmlElement("PasswordType")]
    public string PasswordTypeStr
    {
      get
      {
        int num = 1;
        Guid passwordType;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.PasswordType != Guid.Empty)
              {
                passwordType = this.PasswordType;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 2 : 0;
                continue;
              }
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            default:
              goto label_2;
          }
        }
label_2:
        return "";
label_6:
        return passwordType.ToString();
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              this.PasswordType = string.IsNullOrEmpty(value) ? Guid.Empty : new Guid(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }
    }

    internal static bool rDPBhUosWACXSR4SSJmp() => PasswordSettings.BdyLKOosBNar1EaMmPSL == null;

    internal static PasswordSettings VXlcqMosoSBsmZqV7yF6() => PasswordSettings.BdyLKOosBNar1EaMmPSL;

    internal static void nZuXlhosbyjFZMKEPXMm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
