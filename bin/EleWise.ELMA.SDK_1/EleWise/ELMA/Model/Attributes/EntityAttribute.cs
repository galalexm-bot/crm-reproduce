// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.EntityAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут сущности</summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
  public class EntityAttribute : Attribute
  {
    private string tableName;
    private static EntityAttribute rQgxqJoVEasDQDnPHtJF;

    /// <summary>Новый атрибут сущности</summary>
    /// <param name="tableName">Имя таблицы в БД</param>
    public EntityAttribute(string tableName)
    {
      EntityAttribute.nH2tFhoVCsRgIuZQ1NIE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.tableName = tableName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Имя таблицы в БД</summary>
    public string TableName => this.tableName;

    internal static void nH2tFhoVCsRgIuZQ1NIE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool pce8LCoVfljNhdM6ZLne() => EntityAttribute.rQgxqJoVEasDQDnPHtJF == null;

    internal static EntityAttribute eLAHSxoVQxAoqj5Fj3re() => EntityAttribute.rQgxqJoVEasDQDnPHtJF;
  }
}
