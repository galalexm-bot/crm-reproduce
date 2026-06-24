// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.HtmlStringSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки для типа HTML</summary>
  [Serializable]
  public class HtmlStringSettings : SimpleTypeSettings, IHasDefaultValue<string>
  {
    internal static HtmlStringSettings GfBogQozYp5a6wZWm5ir;

    /// <summary>Ctor</summary>
    public HtmlStringSettings()
    {
      HtmlStringSettings.Xw9nK0ozsGCt9dtncsEe();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected HtmlStringSettings(SerializationInfo info, StreamingContext context)
    {
      HtmlStringSettings.Xw9nK0ozsGCt9dtncsEe();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Значение по умолчанию</summary>
    [XmlElement("DefaultValue")]
    [JsonSerializationIgnore]
    [System.ComponentModel.DefaultValue("")]
    [PublicationBehaviour(PublicationType.Delta)]
    public string DefaultValue
    {
      get => this.\u003CDefaultValue\u003Ek__BackingField;
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
              this.\u003CDefaultValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
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

    /// <summary>Отображать кнопку "ELMA"</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Отображать кнопку \"ELMA\"')")]
    [System.ComponentModel.DefaultValue(true)]
    public bool NeedButtonELMA
    {
      get => this.\u003CNeedButtonELMA\u003Ek__BackingField;
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
              this.\u003CNeedButtonELMA\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
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

    /// <summary>Отображать кнопку "Исходный код"</summary>
    [System.ComponentModel.DefaultValue(true)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Отображать кнопку \"Исходный код\"')")]
    public bool NeedButtonSource
    {
      get => this.\u003CNeedButtonSource\u003Ek__BackingField;
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
              this.\u003CNeedButtonSource\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
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

    internal static void Xw9nK0ozsGCt9dtncsEe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool y8RCedozLoWTuZSAye0R() => HtmlStringSettings.GfBogQozYp5a6wZWm5ir == null;

    internal static HtmlStringSettings Hhscd2ozUruvD3uUOj0A() => HtmlStringSettings.GfBogQozYp5a6wZWm5ir;
  }
}
