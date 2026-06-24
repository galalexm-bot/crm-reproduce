// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ServerInfoReference.GetStartInformationCompletedEventArgs
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
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  public class GetStartInformationCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;
    internal static GetStartInformationCompletedEventArgs BjcQTAv3wmRWbl5hLdo;

    internal GetStartInformationCompletedEventArgs(
      object[] results,
      Exception exception,
      bool cancelled,
      object userState)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(exception, cancelled, userState);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.results = results;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <remarks />
    public StartInformation Result
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              GetStartInformationCompletedEventArgs.arXQPwvDfU867FQ33Om((object) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return (StartInformation) this.results[0];
      }
    }

    internal static bool v0mFXXvpXuBeDwL5naI() => GetStartInformationCompletedEventArgs.BjcQTAv3wmRWbl5hLdo == null;

    internal static GetStartInformationCompletedEventArgs RlhkG2vaXiiAjuypr5E() => GetStartInformationCompletedEventArgs.BjcQTAv3wmRWbl5hLdo;

    internal static void arXQPwvDfU867FQ33Om([In] object obj0) => ((AsyncCompletedEventArgs) obj0).RaiseExceptionIfNecessary();
  }
}
