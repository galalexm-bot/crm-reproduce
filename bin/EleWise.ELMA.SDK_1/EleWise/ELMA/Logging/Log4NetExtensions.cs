// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.Log4NetExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using log4net;
using log4net.Core;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Logging
{
  public static class Log4NetExtensions
  {
    internal static Log4NetExtensions kAXlmXhlEs7N8q1hXtCU;

    public static bool IsVerboseEnabled(ILog log) => Log4NetExtensions.mlcTqxhlviBitJNUMphP(Log4NetExtensions.rZLFCjhlCrkrFO1yPRl1((object) log), (object) Level.Verbose);

    public static bool IsTraceEnabled(ILog log) => ((log4net.Core.ILogger) Log4NetExtensions.rZLFCjhlCrkrFO1yPRl1((object) log)).IsEnabledFor(Level.Trace);

    internal static object rZLFCjhlCrkrFO1yPRl1([In] object obj0) => (object) ((ILoggerWrapper) obj0).Logger;

    internal static bool mlcTqxhlviBitJNUMphP([In] object obj0, [In] object obj1) => ((log4net.Core.ILogger) obj0).IsEnabledFor((Level) obj1);

    internal static bool SGh9MuhlfUanq3RD70UJ() => Log4NetExtensions.kAXlmXhlEs7N8q1hXtCU == null;

    internal static Log4NetExtensions fG4f5nhlQN7K3DpZ2fjy() => Log4NetExtensions.kAXlmXhlEs7N8q1hXtCU;
  }
}
