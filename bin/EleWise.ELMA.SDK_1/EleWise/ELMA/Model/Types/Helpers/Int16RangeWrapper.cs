// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.Int16RangeWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [XmlRoot("Int16RangeValue")]
  [Component]
  public class Int16RangeWrapper : IXsiType
  {
    internal static Int16RangeWrapper HenpcwbEWGWZLp83FaxK;

    public Int16RangeWrapper()
    {
      Int16RangeWrapper.Fiu5ZcbEhCc5ODEa5Fws();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public Int16RangeWrapper(Int16Range source)
    {
      Int16RangeWrapper.Fiu5ZcbEhCc5ODEa5Fws();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
        num1 = 0;
      short? nullable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            nullable = source.From;
            this.HasFromValue = nullable.HasValue;
            num1 = 2;
            continue;
          case 2:
            nullable = source.To;
            this.HasToValue = nullable.HasValue;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 4 : 4;
            continue;
          case 3:
            nullable = source.To;
            int num2;
            if (!nullable.HasValue)
            {
              num2 = (int) Int16RangeWrapper.suUJn3bEGShKhSIil4lE(0);
            }
            else
            {
              nullable = source.To;
              num2 = (int) nullable.Value;
            }
            this.To = (short) num2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
            continue;
          case 4:
            goto label_10;
          default:
            nullable = source.From;
            int num3;
            if (!nullable.HasValue)
            {
              num3 = (int) Int16RangeWrapper.suUJn3bEGShKhSIil4lE(0);
            }
            else
            {
              nullable = source.From;
              num3 = (int) nullable.Value;
            }
            this.From = (short) num3;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 2 : 3;
            continue;
        }
      }
label_10:;
    }

    [XmlElement("From")]
    public short From
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
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
    public short To
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
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

    internal static void Fiu5ZcbEhCc5ODEa5Fws() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool EXc9uhbEoPrAIL11Ygrc() => Int16RangeWrapper.HenpcwbEWGWZLp83FaxK == null;

    internal static Int16RangeWrapper r7VosWbEbCdex7pJqPcQ() => Int16RangeWrapper.HenpcwbEWGWZLp83FaxK;

    internal static short suUJn3bEGShKhSIil4lE([In] int obj0) => Convert.ToInt16(obj0);
  }
}
