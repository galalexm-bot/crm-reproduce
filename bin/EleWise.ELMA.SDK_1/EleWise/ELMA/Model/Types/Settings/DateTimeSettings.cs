// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.DateTimeSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки типа "Дата / время"</summary>
  [Serializable]
  public class DateTimeSettings : SimpleTypeSettings, IMvcValidatableTypeSettings
  {
    internal static DateTimeSettings O6WR9rbWf1Ch8L8M2axU;

    /// <summary>Ctor</summary>
    public DateTimeSettings()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected DateTimeSettings(SerializationInfo info, StreamingContext context)
    {
      DateTimeSettings.i0E5UkbWvQjqdpRhcciD();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Показывать дату</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (DateTimeSettings.__Resources), "ShowDate")]
    [XmlElement("ShowDate")]
    [System.ComponentModel.DefaultValue(true)]
    public bool ShowDate
    {
      get => this.\u003CShowDate\u003Ek__BackingField;
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
              this.\u003CShowDate\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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

    /// <summary>Показывать время</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (DateTimeSettings.__Resources), "ShowTime")]
    [System.ComponentModel.DefaultValue(true)]
    [XmlElement("ShowTime")]
    public bool ShowTime
    {
      get => this.\u003CShowTime\u003Ek__BackingField;
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
              this.\u003CShowTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
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

    /// <summary>Не учитывать временные зоны</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (DateTimeSettings.__Resources), "WithoutOffset")]
    [System.ComponentModel.DefaultValue(false)]
    [XmlElement("WithoutOffset")]
    public bool WithoutOffset
    {
      get => this.\u003CWithoutOffset\u003Ek__BackingField;
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
              this.\u003CWithoutOffset\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
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

    /// <summary>Устанавлиывать текущую дату</summary>
    [XmlElement("SetCurrentDate")]
    [JsonSerializationIgnore]
    [System.ComponentModel.DefaultValue(false)]
    [PublicationBehaviour(PublicationType.Delta)]
    public bool SetCurrentDate
    {
      get => this.\u003CSetCurrentDate\u003Ek__BackingField;
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
              this.\u003CSetCurrentDate\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
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

    /// <summary>Минимальное значение</summary>
    [XmlIgnore]
    public DateTime? MinDateValue { get; set; }

    /// <summary>Минимальное значение (для сериализации)</summary>
    [System.ComponentModel.DefaultValue(null)]
    [XmlElement("MinDate")]
    [JsonSerializationIgnore]
    public string MinDate
    {
      get
      {
        int num = 5;
        long ticks;
        DateTime? minDateValue;
        DateTime dateTime;
        while (true)
        {
          switch (num)
          {
            case 1:
              ticks = dateTime.Ticks;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            case 3:
              dateTime = minDateValue.Value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 1;
              continue;
            case 4:
              if (!minDateValue.HasValue)
              {
                num = 2;
                continue;
              }
              minDateValue = this.MinDateValue;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 3 : 2;
              continue;
            case 5:
              minDateValue = this.MinDateValue;
              num = 4;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return ticks.ToString();
label_5:
        return (string) null;
      }
      set
      {
        int num = 3;
        while (true)
        {
          long result;
          switch (num)
          {
            case 1:
              goto label_6;
            case 2:
              if (!long.TryParse(value, out result))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 3:
              if (!DateTimeSettings.iMAMMKbW8bRpv5Hv6XHJ((object) value))
              {
                num = 2;
                continue;
              }
              break;
            case 4:
              this.MinDateValue = new DateTime?(new DateTime(result));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 1;
              continue;
            case 5:
              goto label_5;
          }
          this.MinDateValue = new DateTime?();
          num = 5;
        }
label_6:
        return;
label_5:;
      }
    }

    /// <summary>Минимальное значение времени</summary>
    [XmlIgnore]
    public DateTime? MinTimeValue { get; set; }

    /// <summary>Минимальное значение времени(для сериализации)</summary>
    [JsonSerializationIgnore]
    [System.ComponentModel.DefaultValue(null)]
    [XmlElement("MinTime")]
    public string MinTime
    {
      get
      {
        int num = 4;
        long ticks;
        DateTime? minTimeValue;
        DateTime dateTime;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              ticks = dateTime.Ticks;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 1;
              continue;
            case 3:
              if (minTimeValue.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 4:
              minTimeValue = this.MinTimeValue;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 3;
              continue;
            case 5:
              goto label_7;
            case 6:
              dateTime = minTimeValue.Value;
              num = 2;
              continue;
            default:
              minTimeValue = this.MinTimeValue;
              num = 6;
              continue;
          }
        }
label_2:
        return ticks.ToString();
label_7:
        return (string) null;
      }
      set
      {
        int num1 = 6;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            long result;
            switch (num2)
            {
              case 1:
              case 5:
                this.MinTimeValue = new DateTime?();
                num2 = 4;
                continue;
              case 2:
                goto label_3;
              case 3:
                if (!long.TryParse(value, out result))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 1;
                  continue;
                }
                break;
              case 4:
                goto label_6;
              case 6:
                if (!string.IsNullOrEmpty(value))
                  goto case 3;
                else
                  goto label_5;
            }
            this.MinTimeValue = new DateTime?(new DateTime(result));
            num2 = 2;
          }
label_5:
          num1 = 5;
        }
label_3:
        return;
label_6:;
      }
    }

    /// <summary>Максимальное значение</summary>
    [XmlIgnore]
    public DateTime? MaxDateValue { get; set; }

    /// <summary>Максимальное значение (для сериализации)</summary>
    [JsonSerializationIgnore]
    [XmlElement("MaxDate")]
    [System.ComponentModel.DefaultValue(null)]
    public string MaxDate
    {
      get
      {
        int num1 = 2;
        long ticks;
        while (true)
        {
          int num2 = num1;
          DateTime? maxDateValue;
          DateTime dateTime;
          while (true)
          {
            switch (num2)
            {
              case 1:
                if (maxDateValue.HasValue)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 2 : 3;
                  continue;
                }
                goto label_3;
              case 2:
                maxDateValue = this.MaxDateValue;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 1;
                continue;
              case 3:
                maxDateValue = this.MaxDateValue;
                num2 = 5;
                continue;
              case 4:
                ticks = dateTime.Ticks;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 6 : 6;
                continue;
              case 5:
                goto label_10;
              case 6:
                goto label_5;
              default:
                goto label_3;
            }
          }
label_10:
          dateTime = maxDateValue.Value;
          num1 = 4;
        }
label_3:
        return (string) null;
label_5:
        return ticks.ToString();
      }
      set
      {
        int num = 1;
        while (true)
        {
          long result;
          switch (num)
          {
            case 1:
              if (DateTimeSettings.iMAMMKbW8bRpv5Hv6XHJ((object) value))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 2:
              this.MaxDateValue = new DateTime?(new DateTime(result));
              num = 4;
              continue;
            case 3:
              if (long.TryParse(value, out result))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 2 : 2;
                continue;
              }
              break;
            case 4:
              goto label_3;
            case 5:
              goto label_5;
          }
          this.MaxDateValue = new DateTime?();
          num = 5;
        }
label_3:
        return;
label_5:;
      }
    }

    /// <summary>Максимальное значение времени</summary>
    [XmlIgnore]
    public DateTime? MaxTimeValue { get; set; }

    /// <summary>Максимальное значение времени(для сериализации)</summary>
    [XmlElement("MaxTime")]
    [System.ComponentModel.DefaultValue(null)]
    [JsonSerializationIgnore]
    public string MaxTime
    {
      get
      {
        int num = 3;
        long ticks;
        DateTime? maxTimeValue;
        DateTime dateTime;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              if (maxTimeValue.HasValue)
              {
                num = 5;
                continue;
              }
              goto label_5;
            case 3:
              maxTimeValue = this.MaxTimeValue;
              num = 2;
              continue;
            case 4:
              ticks = dateTime.Ticks;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 0;
              continue;
            case 5:
              maxTimeValue = this.MaxTimeValue;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
              continue;
            case 6:
              goto label_5;
            default:
              dateTime = maxTimeValue.Value;
              num = 4;
              continue;
          }
        }
label_2:
        return ticks.ToString();
label_5:
        return (string) null;
      }
      set
      {
        int num = 4;
        while (true)
        {
          long result;
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.MaxTimeValue = new DateTime?(new DateTime(result));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              if (long.TryParse(value, out result))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 0;
                continue;
              }
              break;
            case 4:
              if (!DateTimeSettings.iMAMMKbW8bRpv5Hv6XHJ((object) value))
              {
                num = 3;
                continue;
              }
              break;
            default:
              goto label_10;
          }
          this.MaxTimeValue = new DateTime?();
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 2;
        }
label_2:
        return;
label_6:
        return;
label_10:;
      }
    }

    /// <summary>Настройка преобразования времени</summary>
    [JsonSerializationIgnore]
    [System.ComponentModel.DefaultValue(null)]
    [XmlElement("TZ")]
    public TZSettings TZ
    {
      get => this.\u003CTZ\u003Ek__BackingField;
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
              this.\u003CTZ\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
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
    [XmlIgnore]
    [PublicationBehaviour(PublicationType.Delta)]
    public DateTime? DefaultValue
    {
      get => !string.IsNullOrEmpty(this.DefaultValueStr) ? new DateTime?(new DateTime(Convert.ToInt64(this.DefaultValueStr))) : new DateTime?();
      set
      {
        DateTime? nullable = value;
        if (nullable.HasValue)
          this.DefaultValueStr = nullable.Value.Ticks.ToString();
        else
          this.DefaultValueStr = (string) null;
      }
    }

    /// <summary>Значение по умолчанию (для сериализации)</summary>
    [XmlElement("DefaultValue")]
    [System.ComponentModel.DefaultValue(null)]
    [PublicationBehaviour(PublicationType.Delta)]
    [JsonSerializationIgnore]
    public string DefaultValueStr
    {
      get => this.\u003CDefaultValueStr\u003Ek__BackingField;
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
              this.\u003CDefaultValueStr\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
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

    /// <summary>Генерировать в фильтре диапазон значений</summary>
    [XmlElement("RangeInFilter")]
    [System.ComponentModel.DefaultValue(true)]
    [JsonSerializationIgnore]
    [PublicationBehaviour(PublicationType.Restart)]
    public bool RangeInFilter
    {
      get => this.\u003CRangeInFilter\u003Ek__BackingField;
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
              this.\u003CRangeInFilter\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
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

    /// <summary>Генерировать в фильтре относительную дату</summary>
    [JsonSerializationIgnore]
    [System.ComponentModel.DefaultValue(false)]
    [XmlElement("RelativeInFilter")]
    [PublicationBehaviour(PublicationType.Restart)]
    public bool RelativeInFilter
    {
      get => this.\u003CRelativeInFilter\u003Ek__BackingField;
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
              this.\u003CRelativeInFilter\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
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

    /// <summary>Одинаковы ли настройки</summary>
    /// <param name="obj">Объект настроек</param>
    /// <returns>True, если настройки одинаковы</returns>
    public override bool Equals(object obj)
    {
      int num = 3;
      DateTimeSettings dateTimeSettings;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 7:
            goto label_3;
          case 2:
            goto label_22;
          case 3:
            if (!(obj is DateTimeSettings))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 2;
              continue;
            }
            dateTimeSettings = (DateTimeSettings) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 3 : 11;
            continue;
          case 4:
            if (!DateTimeSettings.wMx8ojbWVhGYI3TMqyXI((object) this.MaxDate, DateTimeSettings.KvPJSQbWSXTaYMcN92EP((object) dateTimeSettings)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
              continue;
            }
            goto case 5;
          case 5:
            if (DateTimeSettings.wMx8ojbWVhGYI3TMqyXI((object) this.MinTime, (object) dateTimeSettings.MinTime))
            {
              num = 10;
              continue;
            }
            goto label_3;
          case 6:
            if (this.WithoutOffset == DateTimeSettings.goSaOibWumYkAPRe8hdR((object) dateTimeSettings))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 5 : 12;
              continue;
            }
            goto label_3;
          case 8:
            if (this.ShowTime == dateTimeSettings.ShowTime)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 6 : 4;
              continue;
            }
            goto label_3;
          case 9:
            if (this.ShowDate == DateTimeSettings.VGckmhbWZD0lUUAyF9sY((object) dateTimeSettings))
            {
              num = 8;
              continue;
            }
            goto label_3;
          case 10:
            goto label_2;
          case 11:
            if (!base.Equals(obj))
            {
              num = 7;
              continue;
            }
            goto case 9;
          case 12:
            if (this.SetCurrentDate == dateTimeSettings.SetCurrentDate)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            if (DateTimeSettings.wMx8ojbWVhGYI3TMqyXI((object) this.MinDate, DateTimeSettings.XiL8dkbWIRKG8LSZrwY4((object) dateTimeSettings)))
            {
              num = 4;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return this.MaxTime == (string) DateTimeSettings.IRNuc3bWif8oRwCqlLBZ((object) dateTimeSettings);
label_3:
      return false;
label_22:
      return false;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
      int num1 = base.GetHashCode() ^ this.ShowDate.GetHashCode() * 397 ^ (this.MaxDate != null ? this.MaxDate.GetHashCode() : 0) * 397 ^ (this.MinDate != null ? this.MinDate.GetHashCode() : 0) * 397 ^ (this.MaxTime == null ? 0 : this.MaxTime.GetHashCode()) * 397 ^ (this.MinTime == null ? 0 : this.MinTime.GetHashCode()) * 397 ^ this.SetCurrentDate.GetHashCode() * 397;
      bool flag = this.ShowTime;
      int num2 = flag.GetHashCode() * 397;
      int num3 = num1 ^ num2;
      flag = this.WithoutOffset;
      int num4 = flag.GetHashCode() * 397;
      return num3 ^ num4;
    }

    protected override void GetSerializationDescriptor(TypeSerializationDescriptor descriptor)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            base.GetSerializationDescriptor(descriptor);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            new TypeSerializationDescriptorBuilder(descriptor).ItemWithDescriptor((string) DateTimeSettings.sZJi7NbWRxgi900y4uli(1917256330 ^ 1917170308), (Action<TypeSerializationDescriptorBuilder>) (i =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ((TypeSerializationDescriptorBuilder) DateTimeSettings.\u003C\u003Ec.rxMvA6CTC1Kdhwp8E3Hu(DateTimeSettings.\u003C\u003Ec.ROpidICTfmjkwLcTeU1J((object) i, DateTimeSettings.\u003C\u003Ec.uw9nBKCTEUJxXfw3o3QJ(DateTimeSettings.\u003C\u003Ec.yoRZqhCTGotoK29ZG4TT(-1146510045 ^ -1146354933))), DateTimeSettings.\u003C\u003Ec.UxZxpZCTQBsEYJ2Pgq3S(__typeref (DateTime)))).Optional();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            })).ItemWithDescriptor((string) DateTimeSettings.sZJi7NbWRxgi900y4uli(572119659 - -337058038 ^ 909263681), (Action<TypeSerializationDescriptorBuilder>) (i =>
            {
              int num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ((TypeSerializationDescriptorBuilder) DateTimeSettings.\u003C\u003Ec.rxMvA6CTC1Kdhwp8E3Hu(DateTimeSettings.\u003C\u003Ec.ROpidICTfmjkwLcTeU1J((object) i, (object) EleWise.ELMA.SR.T((string) DateTimeSettings.\u003C\u003Ec.yoRZqhCTGotoK29ZG4TT(1669212571 ^ 1669041949))), typeof (DateTime))).Optional();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    public override void SerializeToJsonObject(SerializableDictionary<string, object> jsonObject)
    {
      base.SerializeToJsonObject(jsonObject);
      DateTime? nullable;
      if (this.MinDateValue.HasValue)
      {
        SerializableDictionary<string, object> serializableDictionary = jsonObject;
        string key = z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654146391);
        nullable = this.MinDateValue;
        string str = nullable.Value.ToString((IFormatProvider) CultureInfo.InvariantCulture);
        serializableDictionary[key] = (object) str;
      }
      nullable = this.MaxDateValue;
      if (!nullable.HasValue)
        return;
      SerializableDictionary<string, object> serializableDictionary1 = jsonObject;
      string key1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539273839);
      nullable = this.MaxDateValue;
      string str1 = nullable.Value.ToString((IFormatProvider) CultureInfo.InvariantCulture);
      serializableDictionary1[key1] = (object) str1;
    }

    public override void DeserializeFromJsonObject(IDictionary<string, object> jsonObject)
    {
      base.DeserializeFromJsonObject(jsonObject);
      if (jsonObject == null)
        return;
      object obj1;
      DateTime result1;
      if (jsonObject.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875952479), out obj1) && obj1 != null && DateTime.TryParse(obj1.ToString(), (IFormatProvider) CultureInfo.InvariantCulture, DateTimeStyles.None, out result1))
        this.MinDateValue = new DateTime?(result1);
      object obj2;
      DateTime result2;
      if (!jsonObject.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1756955934), out obj2) || obj2 == null || !DateTime.TryParse(obj2.ToString(), (IFormatProvider) CultureInfo.InvariantCulture, DateTimeStyles.None, out result2))
        return;
      this.MaxDateValue = new DateTime?(result2);
    }

    void IMvcValidatableTypeSettings.ApplyValidationRules(
      ICollection<ModelClientValidationRule> rules,
      ModelMetadata metadata,
      ControllerContext context,
      TypeSettings originalPropertySettings)
    {
      Contract.ArgumentNotNull((object) rules, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289807462));
      DateTime? nullable1;
      if (originalPropertySettings is DateTimeSettings dateTimeSettings)
      {
        nullable1 = this.MinDateValue;
        DateTime? nullable2 = dateTimeSettings.MinDateValue;
        if ((nullable1.HasValue == nullable2.HasValue ? (nullable1.HasValue ? (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ? 1 : 0) : 0) : 1) == 0)
        {
          nullable2 = this.MaxDateValue;
          nullable1 = dateTimeSettings.MaxDateValue;
          if ((nullable2.HasValue == nullable1.HasValue ? (nullable2.HasValue ? (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ? 1 : 0) : 0) : 1) == 0)
            return;
        }
      }
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      rules.RemoveAll<ModelClientValidationRule>((Func<ModelClientValidationRule, bool>) (r => DateTimeSettings.\u003C\u003Ec.EdgYJnCT86RDWrQYedtv(DateTimeSettings.\u003C\u003Ec.PApVeHCTvVAbmlQ6phaQ((object) r), DateTimeSettings.\u003C\u003Ec.yoRZqhCTGotoK29ZG4TT(1304605005 ^ 1304433241))));
      nullable1 = this.MinDateValue;
      if (nullable1.HasValue)
      {
        nullable1 = this.MinDateValue;
        if (nullable1.Value > DateTime.MinValue)
          goto label_7;
      }
      nullable1 = this.MaxDateValue;
      if (!nullable1.HasValue)
        return;
      nullable1 = this.MaxDateValue;
      if (!(nullable1.Value > DateTime.MinValue))
        return;
label_7:
      rules.AddRange<ModelClientValidationRule>(new RangeDateTimeValidator(metadata, context, new RangeDateTimeAttribute(this.MinDate, this.MaxDate)).GetClientValidationRules());
    }

    internal static bool vrOHwpbWQPgXBDNYiTG1() => DateTimeSettings.O6WR9rbWf1Ch8L8M2axU == null;

    internal static DateTimeSettings g2q7aAbWC13aNSwgF0Wr() => DateTimeSettings.O6WR9rbWf1Ch8L8M2axU;

    internal static void i0E5UkbWvQjqdpRhcciD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool iMAMMKbW8bRpv5Hv6XHJ([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool VGckmhbWZD0lUUAyF9sY([In] object obj0) => ((DateTimeSettings) obj0).ShowDate;

    internal static bool goSaOibWumYkAPRe8hdR([In] object obj0) => ((DateTimeSettings) obj0).WithoutOffset;

    internal static object XiL8dkbWIRKG8LSZrwY4([In] object obj0) => (object) ((DateTimeSettings) obj0).MinDate;

    internal static bool wMx8ojbWVhGYI3TMqyXI([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object KvPJSQbWSXTaYMcN92EP([In] object obj0) => (object) ((DateTimeSettings) obj0).MaxDate;

    internal static object IRNuc3bWif8oRwCqlLBZ([In] object obj0) => (object) ((DateTimeSettings) obj0).MaxTime;

    internal static object sZJi7NbWRxgi900y4uli(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    private static class __Resources
    {
      private static object iiVdRNCXsc1AtyXt5EL0;

      public static string ShowDate => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889303064));

      public static string ShowTime => (string) DateTimeSettings.__Resources.uExKGCCTBHx8bG4Dj6Pm(DateTimeSettings.__Resources.Hkuxk7CTFonNbL8E9b5q(-1120607109 - 305487170 ^ -1426447629));

      public static string WithoutOffset => (string) DateTimeSettings.__Resources.uExKGCCTBHx8bG4Dj6Pm(DateTimeSettings.__Resources.Hkuxk7CTFonNbL8E9b5q(-2107978722 ^ -2107676176));

      internal static bool Ex9SU0CXccUDjbuaRbDg() => DateTimeSettings.__Resources.iiVdRNCXsc1AtyXt5EL0 == null;

      internal static DateTimeSettings.__Resources W1S0rFCXzYLpU9L1WDHW() => (DateTimeSettings.__Resources) DateTimeSettings.__Resources.iiVdRNCXsc1AtyXt5EL0;

      internal static object Hkuxk7CTFonNbL8E9b5q(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object uExKGCCTBHx8bG4Dj6Pm([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
    }
  }
}
