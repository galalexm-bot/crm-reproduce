// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Projects.BuildLogger
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using Microsoft.Build.Framework;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Projects
{
  public class BuildLogger : ILogger
  {
    private IEventSource eventSource;
    private string parameters;
    private LoggerVerbosity verbosity;
    private List<string> errors;
    private static BuildLogger YFO9QaW5nefeJQlKnYxH;

    public void Initialize(IEventSource eventSource)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            BuildLogger.rUUo0yW5ecLfbZQTl7NU((object) eventSource, (object) new BuildErrorEventHandler(this.eventSource_ErrorRaised));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          case 2:
            this.eventSource = eventSource;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    private void eventSource_ErrorRaised(object sender, BuildErrorEventArgs e)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.errors.Add((string) BuildLogger.ouHBaMW5Pv4UVhBZvWYH((object) e));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public string Parameters
    {
      get => this.parameters;
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
              this.parameters = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
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

    public void Shutdown()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            BuildLogger.FLAuaJW51F9YYNcwcn0N((object) this.eventSource, (object) new BuildErrorEventHandler(this.eventSource_ErrorRaised));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public LoggerVerbosity Verbosity
    {
      get => this.verbosity;
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
              this.verbosity = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
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

    public string Errors => string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306479002), (IEnumerable<string>) this.errors);

    public BuildLogger()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.errors = new List<string>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void rUUo0yW5ecLfbZQTl7NU([In] object obj0, [In] object obj1) => ((IEventSource) obj0).ErrorRaised += (BuildErrorEventHandler) obj1;

    internal static bool vNSREYW5OLnnGMnkeKd7() => BuildLogger.YFO9QaW5nefeJQlKnYxH == null;

    internal static BuildLogger BshBMJW52OH4gGADrM0u() => BuildLogger.YFO9QaW5nefeJQlKnYxH;

    internal static object ouHBaMW5Pv4UVhBZvWYH([In] object obj0) => (object) ((BuildEventArgs) obj0).Message;

    internal static void FLAuaJW51F9YYNcwcn0N([In] object obj0, [In] object obj1) => ((IEventSource) obj0).ErrorRaised -= (BuildErrorEventHandler) obj1;
  }
}
