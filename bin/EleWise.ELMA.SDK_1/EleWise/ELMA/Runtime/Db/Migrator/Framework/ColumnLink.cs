// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Framework.ColumnLink
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework
{
  /// <summary>Колонка таблицы базы данных со связью</summary>
  public class ColumnLink
  {
    private readonly string column;
    private readonly string link;
    internal static ColumnLink vuYbqTWOPYgfvl9XaSL2;

    /// <summary>Ctor</summary>
    /// <param name="name">Название колонки</param>
    public ColumnLink(string name)
    {
      ColumnLink.mIdH1yWO3UsB2D0OcKHw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.link = name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
            continue;
          default:
            this.column = name;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="name">Название колонки</param>
    /// <param name="link">Название колонки связи</param>
    public ColumnLink(string name, string link)
    {
      ColumnLink.mIdH1yWO3UsB2D0OcKHw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.link = link;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          case 2:
            this.column = name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Колонка</summary>
    public string Column => this.column;

    /// <summary>Ссылка, название колонки связи</summary>
    public string Link => this.link;

    internal static void mIdH1yWO3UsB2D0OcKHw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool y3OjwkWO1HTVnYPm5aW0() => ColumnLink.vuYbqTWOPYgfvl9XaSL2 == null;

    internal static ColumnLink A8kJfdWONjMmY0R8oOES() => ColumnLink.vuYbqTWOPYgfvl9XaSL2;
  }
}
