// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.MoneyWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component]
  [XmlRoot("MoneyValue")]
  public class MoneyWrapper : IXsiType
  {
    internal static MoneyWrapper sELTMObfahF1FNR660E0;

    public MoneyWrapper()
    {
      MoneyWrapper.zrOXCKbfwNKaUyNv1l0k();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public MoneyWrapper(Money money)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.HasValue = money.HasValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
            continue;
          case 2:
            this.Value = MoneyWrapper.dgA3jkbf4JU2spFQ1JN8(money.Value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    [XmlElement("Value")]
    public double ValueDoub
    {
      get => this.\u003CValueDoub\u003Ek__BackingField;
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
              this.\u003CValueDoub\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
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

    [XmlElement("HasValue")]
    public bool HasValue
    {
      get => this.\u003CHasValue\u003Ek__BackingField;
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
              this.\u003CHasValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
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

    [XmlIgnore]
    public Money Value
    {
      get
      {
        int num = 3;
        Money money;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              money.Value = this.ValueDoub;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            case 3:
              money = new Money();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 2;
              continue;
            default:
              money.HasValue = this.HasValue;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 0;
              continue;
          }
        }
label_2:
        return money;
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.ValueDoub = value.Value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              this.HasValue = value.HasValue;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 2 : 2;
              continue;
          }
        }
label_2:;
      }
    }

    internal static void zrOXCKbfwNKaUyNv1l0k() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool JoVLHLbfDa0uI9m6NdT3() => MoneyWrapper.sELTMObfahF1FNR660E0 == null;

    internal static MoneyWrapper v3J0T5bft4Wq7U3Yaaf8() => MoneyWrapper.sELTMObfahF1FNR660E0;

    internal static Money dgA3jkbf4JU2spFQ1JN8(double d) => (Money) d;
  }
}
