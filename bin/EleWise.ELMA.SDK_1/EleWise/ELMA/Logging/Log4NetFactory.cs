// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.Log4NetFactory
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using log4net;
using log4net.Config;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Logging
{
  internal class Log4NetFactory : ILoggerFactory
  {
    private static string configFile;
    internal static Log4NetFactory bPFNvKhdYbxRxsVP8Tjy;

    public Log4NetFactory()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      string configFile = Log4NetFactory.configFile;
      // ISSUE: explicit constructor call
      this.\u002Ector(configFile == null ? EleWise.ELMA.SR.GetSetting((string) Log4NetFactory.yV7X5UhdsAxjtaN8ZEw4(-345420348 ^ -345318764)) : configFile);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public Log4NetFactory(string configFile)
    {
      Log4NetFactory.Oy67OJhdchTaynEenbZP();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 5;
      string fileName;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            if (!Log4NetFactory.UX8j9XhlFigVMNOhudhu((object) fileName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 3 : 0;
              continue;
            }
            goto case 4;
          case 2:
            fileName = (string) Log4NetFactory.RlsTF7hdzJ3ofifEcivy((object) configFile);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            Log4NetFactory.QIdBx3hlBGyKWtq2sI21((object) new FileInfo(fileName));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          case 5:
            Log4NetFactory.configFile = configFile;
            num = 2;
            continue;
          default:
            goto label_9;
        }
      }
label_6:
      return;
label_2:
      return;
label_9:;
    }

    public ILogger Create(string name) => (ILogger) new Log4NetLogger((ILog) Log4NetFactory.eDAoPlhlWPf2lOJ3TAlt((object) name));

    public ILogger CreateLogger(string name) => this.Create(name);

    public ILogger CreateLogger(Type type) => this.Create(type.FullName);

    internal static object yV7X5UhdsAxjtaN8ZEw4(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool u9V3BThdLSFodBsqyXDJ() => Log4NetFactory.bPFNvKhdYbxRxsVP8Tjy == null;

    internal static Log4NetFactory E03CaUhdUYECBZbkWc7C() => Log4NetFactory.bPFNvKhdYbxRxsVP8Tjy;

    internal static void Oy67OJhdchTaynEenbZP() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object RlsTF7hdzJ3ofifEcivy([In] object obj0) => (object) Logger.GetConfigFile((string) obj0);

    internal static bool UX8j9XhlFigVMNOhudhu([In] object obj0) => File.Exists((string) obj0);

    internal static object QIdBx3hlBGyKWtq2sI21([In] object obj0) => (object) XmlConfigurator.ConfigureAndWatch((FileInfo) obj0);

    internal static object eDAoPlhlWPf2lOJ3TAlt([In] object obj0) => (object) LogManager.GetLogger((string) obj0);
  }
}
