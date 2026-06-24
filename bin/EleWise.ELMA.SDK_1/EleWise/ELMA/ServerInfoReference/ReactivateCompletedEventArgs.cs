// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ServerInfoReference.ReactivateCompletedEventArgs
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
  [DebuggerStepThrough]
  [GeneratedCode("System.Web.Services", "4.8.3761.0")]
  public class ReactivateCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;
    internal static ReactivateCompletedEventArgs hkALIyv9ZgCiREOFZnf;

    internal ReactivateCompletedEventArgs(
      object[] results,
      Exception exception,
      bool cancelled,
      object userState)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(exception, cancelled, userState);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.results = results;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
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
              ReactivateCompletedEventArgs.MthEe2vrJ1Z0Zv8JSAK((object) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return (StartInformation) this.results[0];
      }
    }

    internal static bool y29f1svdjO05DENus6n() => ReactivateCompletedEventArgs.hkALIyv9ZgCiREOFZnf == null;

    internal static ReactivateCompletedEventArgs EoDCmXvllSeKbH97A8t() => ReactivateCompletedEventArgs.hkALIyv9ZgCiREOFZnf;

    internal static void MthEe2vrJ1Z0Zv8JSAK([In] object obj0) => ((AsyncCompletedEventArgs) obj0).RaiseExceptionIfNecessary();
  }
}
