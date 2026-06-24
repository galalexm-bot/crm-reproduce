// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ServerInfoReference.GetStartInformationLocalizedCompletedEventArgs
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
  public class GetStartInformationLocalizedCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;
    internal static GetStartInformationLocalizedCompletedEventArgs toJv1rvtEJqaPQjjNrr;

    internal GetStartInformationLocalizedCompletedEventArgs(
      object[] results,
      Exception exception,
      bool cancelled,
      object userState)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(exception, cancelled, userState);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.results = results;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
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
              GetStartInformationLocalizedCompletedEventArgs.vmONbQv6XftA6Ewjobb((object) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return (StartInformation) this.results[0];
      }
    }

    internal static bool SyGO3Avw3fQYlUuyTkm() => GetStartInformationLocalizedCompletedEventArgs.toJv1rvtEJqaPQjjNrr == null;

    internal static GetStartInformationLocalizedCompletedEventArgs Ni8aRkv4mL7tk7hXBlS() => GetStartInformationLocalizedCompletedEventArgs.toJv1rvtEJqaPQjjNrr;

    internal static void vmONbQv6XftA6Ewjobb([In] object obj0) => ((AsyncCompletedEventArgs) obj0).RaiseExceptionIfNecessary();
  }
}
