// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.ApplicationEnvironmentService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  /// <summary>
  /// Сервис получения уникального идентифкатора окружения приложения
  /// </summary>
  [Service]
  internal class ApplicationEnvironmentService : IApplicationEnvironmentService
  {
    internal static ApplicationEnvironmentService QNnFWeBwPTSqTcARMBmQ;

    /// <inheritdoc />
    public string GetEnvironmentId() => string.Format((string) ApplicationEnvironmentService.mT9TF4Bw3aer8PA9APwA(-867826612 ^ -867745114), (object) Environment.MachineName, (object) ApplicationEnvironmentService.SEFGGVBwaA7TaRRcp7hg(ApplicationEnvironmentService.WD1N8gBwp731aB0g5guk()));

    public ApplicationEnvironmentService()
    {
      ApplicationEnvironmentService.a0cN1sBwDlCl4vVpW5G0();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object mT9TF4Bw3aer8PA9APwA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object WD1N8gBwp731aB0g5guk() => (object) Process.GetCurrentProcess();

    internal static int SEFGGVBwaA7TaRRcp7hg([In] object obj0) => ((Process) obj0).Id;

    internal static bool gIaaKGBw14rK8ArIayti() => ApplicationEnvironmentService.QNnFWeBwPTSqTcARMBmQ == null;

    internal static ApplicationEnvironmentService NwIHYjBwNN09Jvfas7KF() => ApplicationEnvironmentService.QNnFWeBwPTSqTcARMBmQ;

    internal static void a0cN1sBwDlCl4vVpW5G0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
