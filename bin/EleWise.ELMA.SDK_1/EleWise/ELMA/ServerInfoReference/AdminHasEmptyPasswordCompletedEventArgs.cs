// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ServerInfoReference.AdminHasEmptyPasswordCompletedEventArgs
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ServerInfoReference
{
  /// <remarks />
  [GeneratedCode("System.Web.Services", "4.8.3761.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class AdminHasEmptyPasswordCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;
    internal static AdminHasEmptyPasswordCompletedEventArgs I850yIv08h2HZP5wHEw;

    internal AdminHasEmptyPasswordCompletedEventArgs(
      object[] results,
      Exception exception,
      bool cancelled,
      object userState)
    {
      AdminHasEmptyPasswordCompletedEventArgs.FpVV2YvMI5Qyo9LdD5t();
      // ISSUE: explicit constructor call
      base.\u002Ector(exception, cancelled, userState);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.results = results;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <remarks />
    public bool Result
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              AdminHasEmptyPasswordCompletedEventArgs.pFSwp9vJvQ6GqKcyqwn((object) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return (bool) this.results[0];
      }
    }

    internal static void FpVV2YvMI5Qyo9LdD5t() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool u9kSqTvmvREohiVla35() => AdminHasEmptyPasswordCompletedEventArgs.I850yIv08h2HZP5wHEw == null;

    internal static AdminHasEmptyPasswordCompletedEventArgs o0s4hVvyPITI94SUom0() => AdminHasEmptyPasswordCompletedEventArgs.I850yIv08h2HZP5wHEw;

    internal static void pFSwp9vJvQ6GqKcyqwn([In] object obj0) => ((AsyncCompletedEventArgs) obj0).RaiseExceptionIfNecessary();
  }
}
