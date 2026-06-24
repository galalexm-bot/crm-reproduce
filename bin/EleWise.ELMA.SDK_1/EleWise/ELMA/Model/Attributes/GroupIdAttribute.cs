// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.GroupIdAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Указывает идентификатор группы элемента метаданных</summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface)]
  public class GroupIdAttribute : Attribute
  {
    private long id;
    internal static GroupIdAttribute Bw10dbov4bpeATxUYy2D;

    /// <summary>Ctor</summary>
    /// <param name="id">Идентификатор группы элемента метаданных</param>
    public GroupIdAttribute(long id)
    {
      GroupIdAttribute.f636AwovADtvLjZbbbfy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.id = id;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Идентификатор группы элемента метаданных</summary>
    public long Id => this.id;

    internal static void f636AwovADtvLjZbbbfy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool aQXSVjov6tHZQdXUbIBy() => GroupIdAttribute.Bw10dbov4bpeATxUYy2D == null;

    internal static GroupIdAttribute NSralQovHFM06Njej7Sk() => GroupIdAttribute.Bw10dbov4bpeATxUYy2D;
  }
}
