// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ServerInfoReference.GetRemotingPortCompletedEventArgs
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
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "4.8.3761.0")]
  [DebuggerStepThrough]
  public class GetRemotingPortCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;
    private static GetRemotingPortCompletedEventArgs h7bVEEvHYKx1pSd2oru;

    internal GetRemotingPortCompletedEventArgs(
      object[] results,
      Exception exception,
      bool cancelled,
      object userState)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(exception, cancelled, userState);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.results = results;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <remarks />
    public int Result
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              GetRemotingPortCompletedEventArgs.LikLESvxBmSda2hvLp5((object) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return (int) this.results[0];
      }
    }

    internal static bool WFR2m2vA0WwDqSrB0Cc() => GetRemotingPortCompletedEventArgs.h7bVEEvHYKx1pSd2oru == null;

    internal static GetRemotingPortCompletedEventArgs khqZ1jv7t7B9YjUaLLY() => GetRemotingPortCompletedEventArgs.h7bVEEvHYKx1pSd2oru;

    internal static void LikLESvxBmSda2hvLp5([In] object obj0) => ((AsyncCompletedEventArgs) obj0).RaiseExceptionIfNecessary();
  }
}
