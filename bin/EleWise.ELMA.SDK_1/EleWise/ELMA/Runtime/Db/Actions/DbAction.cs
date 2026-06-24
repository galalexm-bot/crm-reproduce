// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Actions.DbAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db.Actions
{
  /// <summary>Абстрактное действие по преобразованию БД</summary>
  public abstract class DbAction : IDbAction
  {
    private ITransformationProvider transform;
    private List<DbAction> subActions;
    private static readonly ILogger DbUpdateLog;
    private static DbAction KXkLEDWKZPfsMxJnbUQD;

    /// <summary>Создать действие</summary>
    /// <param name="transform">Провайдер преобразования БД</param>
    public DbAction(ITransformationProvider transform)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.subActions = new List<DbAction>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.transform = transform;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Подчиненные действия</summary>
    public List<DbAction> SubActions => this.subActions;

    /// <summary>
    /// Выполнить предварительную проверку действия (если есть какие-либо ошибки)
    /// </summary>
    public virtual void Check()
    {
      int num1 = 2;
      List<DbAction>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_14;
          case 1:
            goto label_3;
          case 2:
            enumerator = this.subActions.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
            continue;
          default:
            goto label_10;
        }
      }
label_14:
      return;
label_10:
      return;
label_3:
      try
      {
label_6:
        if (enumerator.MoveNext())
          goto label_8;
        else
          goto label_7;
label_4:
        int num2;
        switch (num2)
        {
          case 1:
            goto label_6;
          case 2:
            return;
          default:
            goto label_8;
        }
label_7:
        num2 = 2;
        goto label_4;
label_8:
        DbAction.WnfVyNWKVX76Lv0mjeHf((object) enumerator.Current);
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
        {
          num2 = 1;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Выполнить действие</summary>
    public virtual void Execute()
    {
      int num1 = 1;
      List<DbAction>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = this.subActions.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_2;
        }
      }
label_13:
      return;
label_2:
      try
      {
label_7:
        if (enumerator.MoveNext())
          goto label_5;
        else
          goto label_8;
label_4:
        int num2;
        switch (num2)
        {
          case 1:
            break;
          case 2:
            return;
          default:
            goto label_7;
        }
label_5:
        enumerator.Current.Execute();
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
label_8:
        num2 = 2;
        goto label_4;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Сообщение для записи в лог обновления структуры БД</summary>
    public string LogMessage
    {
      get => this.\u003CLogMessage\u003Ek__BackingField;
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
              this.\u003CLogMessage\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
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

    /// <summary>Провайдер трансформации БД</summary>
    protected ITransformationProvider Transform => this.transform;

    protected void WriteLogMessage()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.WriteLogMessage(this.LogMessage);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected void WriteLogMessage(string message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            if (DbAction.o7C0t7WKSlCmkdfNtpgw((object) message))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_2;
          case 3:
            DbAction.wJy5l1WKibLXoEGuWkWe((object) DbAction.DbUpdateLog, (object) message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 2;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_2:
      return;
label_7:;
    }

    static DbAction()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DbAction.DbUpdateLog = (ILogger) DbAction.L7t495WKqoRqF2I5ogtu(DbAction.Ond3RfWKRAisaeffIsbN(1021410165 ^ 1021348633));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool sI1RRtWKuFtXhXTW0P7r() => DbAction.KXkLEDWKZPfsMxJnbUQD == null;

    internal static DbAction uUF1a0WKI8y5JMhLpocp() => DbAction.KXkLEDWKZPfsMxJnbUQD;

    internal static void WnfVyNWKVX76Lv0mjeHf([In] object obj0) => ((DbAction) obj0).Check();

    internal static bool o7C0t7WKSlCmkdfNtpgw([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void wJy5l1WKibLXoEGuWkWe([In] object obj0, [In] object obj1) => ((ILogger) obj0).Info(obj1);

    internal static object Ond3RfWKRAisaeffIsbN(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object L7t495WKqoRqF2I5ogtu([In] object obj0) => (object) Logger.GetLogger((string) obj0);
  }
}
