// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Exceptions.TransactionRequiredException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Runtime.Exceptions
{
  /// <summary>
  /// Исключение указывает, что для выполнения операции требуется, чтобы она находилась в рамках активной транзакции
  /// </summary>
  [Serializable]
  public class TransactionRequiredException : Exception
  {
    internal static TransactionRequiredException x6EE0nWhBP6P1ofmnaNc;

    /// <summary>Исключение с сообщением по умолчанию</summary>
    public TransactionRequiredException()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector((string) null);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Исключение с описанием производимой операции</summary>
    /// <param name="operationDescription">Описание производимой операции</param>
    public TransactionRequiredException(string operationDescription)
    {
      TransactionRequiredException.B85ZwyWhbRqKyZsDN7cq();
      object message;
      if (TransactionRequiredException.W19BgEWhhNCkZlg68C3n((object) operationDescription))
        message = TransactionRequiredException.Vx94RfWhEqYWGQLpLYlG(TransactionRequiredException.pWNjx7WhGbR1mUKRdqSQ(1597012150 ^ 1597105048));
      else
        message = (object) EleWise.ELMA.SR.T((string) TransactionRequiredException.pWNjx7WhGbR1mUKRdqSQ(-477139494 ^ -477170170), (object) operationDescription);
      // ISSUE: explicit constructor call
      base.\u002Ector((string) message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected TransactionRequiredException(SerializationInfo info, StreamingContext context)
    {
      TransactionRequiredException.B85ZwyWhbRqKyZsDN7cq();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool zwVUCSWhWbXrK9IWA8Y0() => TransactionRequiredException.x6EE0nWhBP6P1ofmnaNc == null;

    internal static TransactionRequiredException OLP05gWhoaFgu9PgHPiZ() => TransactionRequiredException.x6EE0nWhBP6P1ofmnaNc;

    internal static void B85ZwyWhbRqKyZsDN7cq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool W19BgEWhhNCkZlg68C3n([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object pWNjx7WhGbR1mUKRdqSQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Vx94RfWhEqYWGQLpLYlG([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
  }
}
