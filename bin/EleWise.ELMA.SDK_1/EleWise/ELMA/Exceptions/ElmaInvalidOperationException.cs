// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.ElmaInvalidOperationException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Exceptions
{
  [Serializable]
  public class ElmaInvalidOperationException : Exception
  {
    private readonly string actionType;
    private readonly string actionObject;
    private readonly string argsString;
    private static ElmaInvalidOperationException rw94iPG5L6ls5ifAMR6g;

    public ElmaInvalidOperationException()
    {
      ElmaInvalidOperationException.Ra9trbG5cWCi0uXI5n1M();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ElmaInvalidOperationException(string message)
    {
      ElmaInvalidOperationException.Ra9trbG5cWCi0uXI5n1M();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ElmaInvalidOperationException(string message, Exception innerException)
    {
      ElmaInvalidOperationException.Ra9trbG5cWCi0uXI5n1M();
      // ISSUE: explicit constructor call
      base.\u002Ector(message, innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ElmaInvalidOperationException(string actionType, string actionObject, string argsString)
    {
      ElmaInvalidOperationException.Ra9trbG5cWCi0uXI5n1M();
      // ISSUE: explicit constructor call
      this.\u002Ector(actionType, actionObject, argsString, (Exception) null);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ElmaInvalidOperationException(
      string actionType,
      string actionObject,
      string argsString,
      Exception innerException)
    {
      ElmaInvalidOperationException.Ra9trbG5cWCi0uXI5n1M();
      // ISSUE: explicit constructor call
      base.\u002Ector(EleWise.ELMA.SR.T((string) ElmaInvalidOperationException.tcGv1sG5zIOo0efdnKoR(-53329496 >> 4 ^ -3588684), (object) actionType, (object) actionObject, (object) argsString), innerException);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.actionObject = actionObject;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          case 2:
            this.actionType = actionType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_3;
          default:
            this.argsString = argsString;
            num = 3;
            continue;
        }
      }
label_3:;
    }

    public string ActionType => this.actionType;

    public string ActionObject => this.actionObject;

    public string ArgsString => this.argsString;

    internal static void Ra9trbG5cWCi0uXI5n1M() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool rnlPHBG5UFUHs8R6k7pk() => ElmaInvalidOperationException.rw94iPG5L6ls5ifAMR6g == null;

    internal static ElmaInvalidOperationException euZJtIG5sxj56f3jkeQi() => ElmaInvalidOperationException.rw94iPG5L6ls5ifAMR6g;

    internal static object tcGv1sG5zIOo0efdnKoR(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
