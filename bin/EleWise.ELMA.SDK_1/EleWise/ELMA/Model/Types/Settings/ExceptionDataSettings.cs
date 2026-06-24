// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.ExceptionDataSettings
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
  /// <summary>Настройки типа "Описание ошибки выполнения сценария"</summary>
  [Serializable]
  public class ExceptionDataSettings : SimpleTypeSettings
  {
    private static ExceptionDataSettings nrV48mosdUl3g7nEgN3Y;

    /// <summary>Ctor</summary>
    public ExceptionDataSettings()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected ExceptionDataSettings(SerializationInfo info, StreamingContext context)
    {
      ExceptionDataSettings.SqBthUosg96JKxStHkKG();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Значение по умолчанию</summary>
    [XmlIgnore]
    [PublicationBehaviour(PublicationType.Delta)]
    public long? DefaultValue { get; set; }

    /// <summary>Тип отображения (Упрощенный, полный)</summary>
    [System.ComponentModel.DefaultValue(ExceptionDataDisplayType.simple)]
    [XmlElement("DisplayType")]
    public ExceptionDataDisplayType DisplayType
    {
      get => this.\u003CDisplayType\u003Ek__BackingField;
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
              this.\u003CDisplayType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
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

    internal static bool dTA5mJoslNbJF7Vm7ROt() => ExceptionDataSettings.nrV48mosdUl3g7nEgN3Y == null;

    internal static ExceptionDataSettings hEwfxJosrmvhHn77n3BP() => ExceptionDataSettings.nrV48mosdUl3g7nEgN3Y;

    internal static void SqBthUosg96JKxStHkKG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
