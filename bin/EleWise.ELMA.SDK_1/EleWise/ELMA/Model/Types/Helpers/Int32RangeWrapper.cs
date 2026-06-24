// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.Int32RangeWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component]
  [XmlRoot("Int32RangeValue")]
  public class Int32RangeWrapper : IXsiType
  {
    internal static Int32RangeWrapper aX1DJ6bED5wpF6F1Tal9;

    public Int32RangeWrapper()
    {
      Int32RangeWrapper.lPe9nwbE40OyEiY6JmWw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public Int32RangeWrapper(Int32Range source)
    {
      Int32RangeWrapper.lPe9nwbE40OyEiY6JmWw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 4;
      int? nullable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_9;
          case 2:
            nullable = source.From;
            this.HasFromValue = nullable.HasValue;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 3 : 2;
            continue;
          case 3:
            nullable = source.To;
            this.HasToValue = nullable.HasValue;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
            continue;
          case 4:
            nullable = source.From;
            int num2;
            if (!nullable.HasValue)
            {
              num2 = 0;
            }
            else
            {
              nullable = source.From;
              num2 = nullable.Value;
            }
            this.From = num2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
            continue;
          default:
            nullable = source.To;
            int num3;
            if (!nullable.HasValue)
            {
              num3 = 0;
            }
            else
            {
              nullable = source.To;
              num3 = nullable.Value;
            }
            this.To = num3;
            num1 = 2;
            continue;
        }
      }
label_9:;
    }

    [XmlElement("From")]
    public int From
    {
      get => this.\u003CFrom\u003Ek__BackingField;
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
              this.\u003CFrom\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
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

    [XmlElement("To")]
    public int To
    {
      get => this.\u003CTo\u003Ek__BackingField;
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
              this.\u003CTo\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
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

    [XmlElement("HasFromValue")]
    public bool HasFromValue
    {
      get => this.\u003CHasFromValue\u003Ek__BackingField;
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
              this.\u003CHasFromValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
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

    [XmlElement("HasToValue")]
    public bool HasToValue
    {
      get => this.\u003CHasToValue\u003Ek__BackingField;
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
              this.\u003CHasToValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
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

    internal static void lPe9nwbE40OyEiY6JmWw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool crgirDbEtljB2FLtkPNH() => Int32RangeWrapper.aX1DJ6bED5wpF6F1Tal9 == null;

    internal static Int32RangeWrapper o09gqlbEwTLaERLlXKxY() => Int32RangeWrapper.aX1DJ6bED5wpF6F1Tal9;
  }
}
