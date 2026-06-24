// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.DbNameAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут, определяющий имя БД по умолчанию, с которой работает сущность
  /// </summary>
  [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class)]
  public class DbNameAttribute : Attribute
  {
    private string dbName;
    internal static DbNameAttribute PZOQXxoIGdT9p6sjy7jw;

    /// <summary>Конструктор</summary>
    /// <param name="dbName">Имя БД</param>
    public DbNameAttribute(string dbName)
    {
      DbNameAttribute.yyipsooIQUefJH5QLtTu();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.dbName = dbName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Имя БД</summary>
    public string DbName => this.dbName;

    internal static void yyipsooIQUefJH5QLtTu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool y4igYfoIEtIribruIpeO() => DbNameAttribute.PZOQXxoIGdT9p6sjy7jw == null;

    internal static DbNameAttribute C1WQZIoIfIbBAYbJnbcr() => DbNameAttribute.PZOQXxoIGdT9p6sjy7jw;
  }
}
