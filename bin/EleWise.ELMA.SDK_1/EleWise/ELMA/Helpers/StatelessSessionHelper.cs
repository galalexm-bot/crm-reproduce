// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.StatelessSessionHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Helper для работы с сессиями</summary>
  public class StatelessSessionHelper
  {
    private readonly SessionFactoryHolder SessionFactoryHolder;
    internal static StatelessSessionHelper QLxQbVhYxj5RfvgHHyJL;

    /// <summary>Ctor</summary>
    /// <param name="sessionFactoryHolder"></param>
    public StatelessSessionHelper(SessionFactoryHolder sessionFactoryHolder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.SessionFactoryHolder = sessionFactoryHolder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Выполнить в отдельной сессии</summary>
    /// <param name="action"></param>
    public void ExecuteOnSeparateTransaction(Action<IStatelessSession> action)
    {
      IStatelessSession statelessSession = (IStatelessSession) null;
      try
      {
        statelessSession = this.SessionFactoryHolder.SessionFactory.OpenStatelessSession();
        statelessSession.BeginTransaction(IsolationLevel.ReadCommitted);
        action(statelessSession);
      }
      catch (Exception ex)
      {
        if (statelessSession != null && statelessSession.Transaction != null && statelessSession.Transaction.IsActive)
        {
          Logger.Log.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479661898));
          statelessSession.Transaction.Rollback();
        }
        Logger.Log.Debug(ex, z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 133140081));
      }
      finally
      {
        if (statelessSession != null)
        {
          try
          {
            if (statelessSession.Transaction != null)
            {
              if (statelessSession.Transaction.IsActive)
                statelessSession.Transaction.Commit();
            }
          }
          finally
          {
            statelessSession.Close();
            statelessSession.Dispose();
          }
        }
      }
    }

    internal static bool qUC4j2hY0rfj8YcyKS9G() => StatelessSessionHelper.QLxQbVhYxj5RfvgHHyJL == null;

    internal static StatelessSessionHelper oECngYhYmLimD4bCcmiA() => StatelessSessionHelper.QLxQbVhYxj5RfvgHHyJL;
  }
}
