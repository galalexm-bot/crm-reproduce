// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.BackupParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Runtime.Db
{
  /// <summary>Параметры резервного копирования</summary>
  public struct BackupParameters
  {
    internal static object KynumVWuI3F2yuHAvu1H;

    /// <summary>Выполнять ли резервное копирование БД</summary>
    public bool MainDatabase
    {
      get => this.\u003CMainDatabase\u003Ek__BackingField;
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
              this.\u003CMainDatabase\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
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

    /// <summary>
    /// 
    /// </summary>
    public static BackupParameters OnlyMainDatabase
    {
      get
      {
        int num = 2;
        BackupParameters onlyMainDatabase;
        while (true)
        {
          switch (num)
          {
            case 1:
              onlyMainDatabase.MainDatabase = true;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
              continue;
            case 2:
              onlyMainDatabase = new BackupParameters();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 1;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return onlyMainDatabase;
      }
    }

    internal static bool YCa1UpWuVEitO4tGZcfb() => BackupParameters.KynumVWuI3F2yuHAvu1H == null;

    internal static object HbHgcJWuSniowQpwtr5t() => BackupParameters.KynumVWuI3F2yuHAvu1H;
  }
}
