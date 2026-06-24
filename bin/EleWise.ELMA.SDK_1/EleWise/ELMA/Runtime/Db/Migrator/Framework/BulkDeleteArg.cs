// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Framework.BulkDeleteArg
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework
{
  /// <summary>Аргументы массового удаления</summary>
  public class BulkDeleteArg
  {
    internal static BulkDeleteArg nS986yWOn2I2XgxSlIVc;

    /// <summary>Ctor</summary>
    public BulkDeleteArg()
    {
      BulkDeleteArg.ggFniAWOeBEMpUITNBol();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Clauses = new List<BulkDeleteArg.Clause>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Название таблицы</summary>
    public string TableName
    {
      get => this.\u003CTableName\u003Ek__BackingField;
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
              this.\u003CTableName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
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

    /// <summary>Условия</summary>
    public List<BulkDeleteArg.Clause> Clauses { get; set; }

    internal static void ggFniAWOeBEMpUITNBol() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool UULtptWOOqoV9QJa5VZD() => BulkDeleteArg.nS986yWOn2I2XgxSlIVc == null;

    internal static BulkDeleteArg H8x0HxWO2gcFjDBNZDqK() => BulkDeleteArg.nS986yWOn2I2XgxSlIVc;

    /// <summary>Условия</summary>
    public class Clause
    {
      private static BulkDeleteArg.Clause WbhT9dQAIKJvSk5paEEe;

      /// <summary>Ctor</summary>
      public Clause()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.Values = new Dictionary<string, object>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      /// <summary>Название таблицы</summary>
      public string TableName
      {
        get => this.\u003CTableName\u003Ek__BackingField;
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
                this.\u003CTableName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
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

      /// <summary>Пара колонка/значение</summary>
      public Dictionary<string, object> Values { get; set; }

      internal static bool uuGjGkQAVXNtPR8vWq6X() => BulkDeleteArg.Clause.WbhT9dQAIKJvSk5paEEe == null;

      internal static BulkDeleteArg.Clause RIWZOKQAS0QXN0qZqxFh() => BulkDeleteArg.Clause.WbhT9dQAIKJvSk5paEEe;
    }
  }
}
