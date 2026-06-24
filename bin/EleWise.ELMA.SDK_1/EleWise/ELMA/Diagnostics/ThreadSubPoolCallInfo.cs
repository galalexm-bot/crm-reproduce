// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.ThreadSubPoolCallInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Reflection;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Информация о вызове метода из пула потоков</summary>
  [Serializable]
  internal sealed class ThreadSubPoolCallInfo : MethodCallInfo
  {
    private static ThreadSubPoolCallInfo tPTXfFGzz9urSZ8uavVq;

    /// <summary>Ctor</summary>
    public ThreadSubPoolCallInfo()
    {
      ThreadSubPoolCallInfo.bTYWUDEFWpmuss2q5oKk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="ownerType">Тип владельца метода</param>
    /// <param name="method">Информация о методе</param>
    public ThreadSubPoolCallInfo(Type ownerType, MethodInfo method)
    {
      ThreadSubPoolCallInfo.bTYWUDEFWpmuss2q5oKk();
      // ISSUE: explicit constructor call
      base.\u002Ector(ownerType, method, (object[]) null);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <inheritdoc />
    public override string CallType => (string) ThreadSubPoolCallInfo.H67OYOEFowOYn0yAnk6P(-138018305 ^ -138270829);

    internal static void bTYWUDEFWpmuss2q5oKk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool RvoA3HEFFZTGrgdXxODu() => ThreadSubPoolCallInfo.tPTXfFGzz9urSZ8uavVq == null;

    internal static ThreadSubPoolCallInfo SedEENEFBIpAW53aq8ry() => ThreadSubPoolCallInfo.tPTXfFGzz9urSZ8uavVq;

    internal static object H67OYOEFowOYn0yAnk6P(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
