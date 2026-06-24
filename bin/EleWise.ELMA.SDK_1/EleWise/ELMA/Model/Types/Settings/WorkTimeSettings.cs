// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.WorkTimeSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки типа "Интервал рабочего времени"</summary>
  [Serializable]
  public class WorkTimeSettings : SimpleTypeSettings, IHasDefaultValue<long?>
  {
    private long _minValue;
    private long _maxValue;
    private static WorkTimeSettings NYhpxPocwuQ5ShBML005;

    /// <summary>Ctor</summary>
    public WorkTimeSettings()
    {
      WorkTimeSettings.WY80syocHHQuCLGm6sKj();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected WorkTimeSettings(SerializationInfo info, StreamingContext context)
    {
      WorkTimeSettings.WY80syocHHQuCLGm6sKj();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Минимальное значение</summary>
    [System.ComponentModel.DefaultValue(-9223372036854775808)]
    [PublicationBehaviour(PublicationType.Restart)]
    [XmlElement("MinValue")]
    public long MinValue
    {
      get => this._minValue;
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
              this._minValue = value < this._minValue ? long.MinValue : value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
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

    /// <summary>Максимальное значение</summary>
    [XmlElement("MaxValue")]
    [PublicationBehaviour(PublicationType.Restart)]
    [System.ComponentModel.DefaultValue(9223372036854775807)]
    public long MaxValue
    {
      get => this._maxValue;
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
              this._maxValue = value > this._maxValue ? long.MaxValue : value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
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

    /// <summary>Значение по умолчанию</summary>
    [PublicationBehaviour(PublicationType.Delta)]
    [XmlIgnore]
    public long? DefaultValue { get; set; }

    /// <summary>Значение по умолчанию (для сериализации)</summary>
    [XmlElement("DefaultValue")]
    [PublicationBehaviour(PublicationType.Delta)]
    [System.ComponentModel.DefaultValue(null)]
    public string DefaultValueStr
    {
      get
      {
        int num1 = 4;
        long num2;
        long? defaultValue;
        while (true)
        {
          switch (num1)
          {
            case 1:
              num2 = defaultValue.Value;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              if (!defaultValue.HasValue)
              {
                num1 = 2;
                continue;
              }
              defaultValue = this.DefaultValue;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
              continue;
            case 4:
              defaultValue = this.DefaultValue;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 3;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return num2.ToString();
label_6:
        return (string) null;
      }
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_5;
            case 1:
              this.DefaultValue = new long?(WorkTimeSettings.wsEaSXocxuMs2duuZ2Ux((object) value, WorkTimeSettings.AQDVbyoc7BneGVT7dkDg((object) Thread.CurrentThread.CurrentCulture)));
              num = 3;
              continue;
            case 2:
              if (!WorkTimeSettings.lUsHVaocATYfjNX5drPf((object) value))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
                continue;
              }
              this.DefaultValue = new long?();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_2;
            default:
              goto label_8;
          }
        }
label_5:
        return;
label_2:
        return;
label_8:;
      }
    }

    internal static void WY80syocHHQuCLGm6sKj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool vqI8fpoc4VNZBqIZwM29() => WorkTimeSettings.NYhpxPocwuQ5ShBML005 == null;

    internal static WorkTimeSettings F4tvpkoc6AOi148sqZty() => WorkTimeSettings.NYhpxPocwuQ5ShBML005;

    internal static bool lUsHVaocATYfjNX5drPf([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object AQDVbyoc7BneGVT7dkDg([In] object obj0) => (object) ((CultureInfo) obj0).NumberFormat;

    internal static long wsEaSXocxuMs2duuZ2Ux([In] object obj0, [In] object obj1) => long.Parse((string) obj0, (IFormatProvider) obj1);
  }
}
