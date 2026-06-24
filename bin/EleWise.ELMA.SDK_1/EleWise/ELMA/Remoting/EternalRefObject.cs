// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Remoting.EternalRefObject
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Remoting
{
  /// <summary>
  /// Объект, обеспечивающий взаимодействие через Remoting с вечной ссылкой
  /// </summary>
  public abstract class EternalRefObject : MarshalByRefObject
  {
    private static EternalRefObject EN9oKITg39CMDhH5bRh;

    /// <exclude />
    public override object InitializeLifetimeService() => (object) null;

    protected EternalRefObject()
    {
      EternalRefObject.UhwvZJTYnSovmEBfwMe();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void UhwvZJTYnSovmEBfwMe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool F9WZBHT5Qov4l0kNLlq() => EternalRefObject.EN9oKITg39CMDhH5bRh == null;

    internal static EternalRefObject jYTETcTjwhQH19tkIBE() => EternalRefObject.EN9oKITg39CMDhH5bRh;
  }
}
