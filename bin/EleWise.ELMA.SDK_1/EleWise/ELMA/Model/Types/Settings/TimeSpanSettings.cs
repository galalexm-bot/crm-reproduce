// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.TimeSpanSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки типа "Временной интервал"</summary>
  [Serializable]
  public class TimeSpanSettings : SimpleTypeSettings
  {
    [OptionalField]
    private bool showDays;
    [OptionalField]
    private bool showHours;
    [OptionalField]
    private bool showMinutes;
    private static TimeSpanSettings m4KwnHbB7OjvCC0CusWf;

    /// <summary>Ctor</summary>
    public TimeSpanSettings()
    {
      TimeSpanSettings.LWs5ZqbBmsLjFIEbIcaG();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected TimeSpanSettings(SerializationInfo info, StreamingContext context)
    {
      TimeSpanSettings.LWs5ZqbBmsLjFIEbIcaG();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Показывать дни</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (TimeSpanSettings.__Resources), "ShowDays")]
    [DefaultValue(true)]
    [XmlElement("ShowDays")]
    public bool ShowDays
    {
      get => this.showDays;
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
              this.showDays = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
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

    /// <summary>Показывать часы</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (TimeSpanSettings.__Resources), "ShowHours")]
    [DefaultValue(true)]
    [XmlElement("ShowHours")]
    public bool ShowHours
    {
      get => this.showHours;
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
              this.showHours = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
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

    /// <summary>Показывать минуты</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (TimeSpanSettings.__Resources), "ShowMinutes")]
    [XmlElement("ShowMinutes")]
    [DefaultValue(true)]
    public bool ShowMinutes
    {
      get => this.showMinutes;
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
              this.showMinutes = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
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

    /// <summary>Показывать секунды</summary>
    [XmlElement("ShowSeconds")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (TimeSpanSettings.__Resources), "ShowSeconds")]
    [DefaultValue(false)]
    public bool ShowSeconds
    {
      get => this.\u003CShowSeconds\u003Ek__BackingField;
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
              this.\u003CShowSeconds\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
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

    internal static void LWs5ZqbBmsLjFIEbIcaG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool vQeGb8bBx5v2WU1kquQM() => TimeSpanSettings.m4KwnHbB7OjvCC0CusWf == null;

    internal static TimeSpanSettings dNe4ILbB0eb58uBl10KC() => TimeSpanSettings.m4KwnHbB7OjvCC0CusWf;

    private static class __Resources
    {
      private static object YQoPHQCXehgKxNfC5kTT;

      public static string ShowDays => (string) TimeSpanSettings.__Resources.q1E9kiCX3A5AldAgh1pR(TimeSpanSettings.__Resources.vXeTPgCXNroRf6eaW9uc(-1598106783 - -968262081 ^ -630132678));

      public static string ShowHours => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199577397));

      public static string ShowMinutes => (string) TimeSpanSettings.__Resources.q1E9kiCX3A5AldAgh1pR(TimeSpanSettings.__Resources.vXeTPgCXNroRf6eaW9uc(-1872275253 >> 6 ^ -29083591));

      public static string ShowSeconds => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77906319));

      internal static object vXeTPgCXNroRf6eaW9uc(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object q1E9kiCX3A5AldAgh1pR([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool KkHw9mCXPQlMdaA6FIJ9() => TimeSpanSettings.__Resources.YQoPHQCXehgKxNfC5kTT == null;

      internal static TimeSpanSettings.__Resources wTHMBPCX1PEBWPfXENTn() => (TimeSpanSettings.__Resources) TimeSpanSettings.__Resources.YQoPHQCXehgKxNfC5kTT;
    }
  }
}
