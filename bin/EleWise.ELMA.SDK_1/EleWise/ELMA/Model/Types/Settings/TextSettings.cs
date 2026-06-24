// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.TextSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки типа "Текст"</summary>
  [Serializable]
  public class TextSettings : StringSettings
  {
    private static TextSettings W5l6qwozxZo9doTl7uCg;

    /// <summary>Ctor</summary>
    public TextSettings()
    {
      TextSettings.t7q3wfozyxI004XXUlhx();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected TextSettings(SerializationInfo info, StreamingContext context)
    {
      TextSettings.t7q3wfozyxI004XXUlhx();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Многострочное поле</summary>
    [System.ComponentModel.DefaultValue(true)]
    [JsonSerializationIgnore]
    public override bool MultiLine
    {
      get => this.\u003CMultiLine\u003Ek__BackingField;
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
              this.\u003CMultiLine\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
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

    internal static void t7q3wfozyxI004XXUlhx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool FEhHnfoz0DYf3pX5Wbw6() => TextSettings.W5l6qwozxZo9doTl7uCg == null;

    internal static TextSettings DJF1SgozmBXEKBNIYV3D() => TextSettings.W5l6qwozxZo9doTl7uCg;
  }
}
