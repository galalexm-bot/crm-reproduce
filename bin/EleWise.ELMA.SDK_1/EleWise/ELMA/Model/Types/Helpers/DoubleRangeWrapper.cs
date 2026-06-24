// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.DoubleRangeWrapper
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
  [XmlRoot("DoubleRangeValue")]
  public class DoubleRangeWrapper : IXsiType
  {
    internal static DoubleRangeWrapper JH2RlTbhzHAQ8nQUEJ9M;

    public DoubleRangeWrapper()
    {
      DoubleRangeWrapper.LPD1OnbGWQD4vfSLpjbJ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public DoubleRangeWrapper(DoubleRange source)
    {
      DoubleRangeWrapper.LPD1OnbGWQD4vfSLpjbJ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
        num1 = 0;
      double? nullable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            nullable = source.From;
            this.HasFromValue = nullable.HasValue;
            num1 = 3;
            continue;
          case 2:
            nullable = source.To;
            double num2;
            if (!nullable.HasValue)
            {
              num2 = 0.0;
            }
            else
            {
              nullable = source.To;
              num2 = nullable.Value;
            }
            this.To = num2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 0;
            continue;
          case 3:
            nullable = source.To;
            this.HasToValue = nullable.HasValue;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 2 : 4;
            continue;
          case 4:
            goto label_6;
          default:
            nullable = source.From;
            double num3;
            if (!nullable.HasValue)
            {
              num3 = 0.0;
            }
            else
            {
              nullable = source.From;
              num3 = nullable.Value;
            }
            this.From = num3;
            num1 = 2;
            continue;
        }
      }
label_6:;
    }

    [XmlElement("From")]
    public double From
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
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
    public double To
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
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

    internal static void LPD1OnbGWQD4vfSLpjbJ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool fgNWCebGFQB9GsnWcn3Y() => DoubleRangeWrapper.JH2RlTbhzHAQ8nQUEJ9M == null;

    internal static DoubleRangeWrapper eMC80CbGB5bjFjspjmqO() => DoubleRangeWrapper.JH2RlTbhzHAQ8nQUEJ9M;
  }
}
