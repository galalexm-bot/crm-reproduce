// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.Models.TimeSpanHolder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using System;
using System.Xml.Serialization;

namespace EleWise.ELMA.Common.Models
{
  /// <summary>Сериализуемое хранилище значения типа TimeSpan</summary>
  [Component]
  [Serializable]
  public struct TimeSpanHolder : IXsiType
  {
    private long ticks;
    internal static object RxZyINfStnO6OUsjMfu1;

    public override string ToString()
    {
      int num = 1;
      TimeSpan timeSpan;
      while (true)
      {
        switch (num)
        {
          case 1:
            timeSpan = this.Value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return timeSpan.ToString();
    }

    /// <summary>Значение в виде TimeSpan</summary>
    [XmlIgnore]
    public TimeSpan Value
    {
      get => new TimeSpan(this.ticks);
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
              this.ticks = value.Ticks;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
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

    /// <summary>Значение в виде тиков</summary>
    public long Ticks
    {
      get => this.ticks;
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
              this.ticks = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
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

    internal static bool eYrHCJfSwQPiCbBkgBb2() => TimeSpanHolder.RxZyINfStnO6OUsjMfu1 == null;

    internal static object z9WbR3fS4Q6P78oK1wPY() => TimeSpanHolder.RxZyINfStnO6OUsjMfu1;
  }
}
