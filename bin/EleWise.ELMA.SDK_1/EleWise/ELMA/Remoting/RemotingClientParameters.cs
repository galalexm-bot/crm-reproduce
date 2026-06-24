// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Remoting.RemotingClientParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Remoting
{
  public static class RemotingClientParameters
  {
    public static Func<bool> TryStopDebuggingHandler;
    public static Func<bool> IsDebuggingHandler;
    internal static RemotingClientParameters eFjY1yXlQpN7eD8g3DZ;

    public static bool IsDebugging
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (RemotingClientParameters.IsDebuggingHandler == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return false;
label_5:
        return RemotingClientParameters.IsDebuggingHandler();
      }
    }

    public static bool TryStopDebugging()
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (RemotingClientParameters.TryStopDebuggingHandler == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 2:
              goto label_6;
            default:
              goto label_5;
          }
        }
label_6:
        int num3 = RemotingClientParameters.TryStopDebuggingHandler() ? 1 : 0;
        num1 = 3;
      }
label_5:
      return !RemotingClientParameters.IsDebugging;
    }

    internal static bool R8Q5GOXrSqGrG738mBw() => RemotingClientParameters.eFjY1yXlQpN7eD8g3DZ == null;

    internal static RemotingClientParameters IFNamFXgHyalPmqEjU9() => RemotingClientParameters.eFjY1yXlQpN7eD8g3DZ;
  }
}
