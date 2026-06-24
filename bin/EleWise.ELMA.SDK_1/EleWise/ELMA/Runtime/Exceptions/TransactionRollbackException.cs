// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Exceptions.TransactionRollbackException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;
using System.Security;

namespace EleWise.ELMA.Runtime.Exceptions
{
  /// <summary>
  /// Исключение, которое заставит откатиться транзакцию.
  /// Если выбросить исключение <see cref="T:System.Exception" />, то из методов <see cref="M:EleWise.ELMA.Runtime.NH.IUnitOfWorkEventListener.OnPreFlushUnitofWork(EleWise.ELMA.Runtime.NH.IUnitOfWork,System.Collections.Generic.IEnumerable{System.Object})" />, <see cref="M:EleWise.ELMA.Runtime.NH.IUnitOfWorkEventListener.OnPreCommitUnitofWork(EleWise.ELMA.Runtime.NH.IUnitOfWork)" />, <see cref="M:EleWise.ELMA.Runtime.NH.IUnitOfWorkEventListener.OnPostFlushUnitofWork(EleWise.ELMA.Runtime.NH.IUnitOfWork)" /> оно будет проглочено, и транзакция продолжится.
  /// </summary>
  [Serializable]
  public class TransactionRollbackException : Exception
  {
    private static TransactionRollbackException ptnT26WhfJD7wr7Ykkhl;

    public TransactionRollbackException()
    {
      TransactionRollbackException.MjkmjpWhvhuY2RacClid();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public TransactionRollbackException(string message)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public TransactionRollbackException(string message, Exception innerException)
    {
      TransactionRollbackException.MjkmjpWhvhuY2RacClid();
      // ISSUE: explicit constructor call
      base.\u002Ector(message, innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    [SecuritySafeCritical]
    protected TransactionRollbackException(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void MjkmjpWhvhuY2RacClid() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool xpat5kWhQkHEeUoEqQyL() => TransactionRollbackException.ptnT26WhfJD7wr7Ykkhl == null;

    internal static TransactionRollbackException jfpLSTWhC0ELbUuT7StC() => TransactionRollbackException.ptnT26WhfJD7wr7Ykkhl;
  }
}
