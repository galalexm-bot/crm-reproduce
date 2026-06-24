// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.DefaultValueUidAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут, указывающий уникальный идентификатор значения перечисления по умолчанию
  /// </summary>
  public class DefaultValueUidAttribute : Attribute
  {
    private Guid uid;
    private static DefaultValueUidAttribute MfBTfNovkAKNi450A2Nm;

    /// <summary>Конструктор</summary>
    /// <param name="uid">Уникальный идентификатор значения перечисления по умолчанию</param>
    public DefaultValueUidAttribute(string uid)
    {
      DefaultValueUidAttribute.bH6Mf7ov2bgaR1F8tLBN();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.uid = new Guid(uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>
    /// Уникальный идентификатор значения перечисления по умолчанию
    /// </summary>
    public Guid Uid
    {
      get => this.uid;
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
              this.uid = value;
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

    internal static void bH6Mf7ov2bgaR1F8tLBN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool FReuoqovn3osk9GkBJAA() => DefaultValueUidAttribute.MfBTfNovkAKNi450A2Nm == null;

    internal static DefaultValueUidAttribute g4Sb3govOrM4bwKdLkcO() => DefaultValueUidAttribute.MfBTfNovkAKNi450A2Nm;
  }
}
