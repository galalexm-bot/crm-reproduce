// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.SimultaneousSessionExceededException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Licensing
{
  /// <summary>
  /// Вызывается, когда превышено количество одновременных подключений
  /// </summary>
  [Serializable]
  public class SimultaneousSessionExceededException : LicenseException
  {
    private IUser _user;
    internal static SimultaneousSessionExceededException Nfu4yQ7XNM7NHjXbobT;

    /// <summary>Ctor</summary>
    /// <param name="user">Пользователь, который пытается войти в систему</param>
    public SimultaneousSessionExceededException(IUser user)
    {
      SimultaneousSessionExceededException.SRCaAa7nLkAC3NH0x6P();
      // ISSUE: explicit constructor call
      base.\u002Ector(EleWise.ELMA.SR.T((string) SimultaneousSessionExceededException.cKk2Am7OBe5J6nuYVt8(-138018305 ^ -137979067)));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this._user = user;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public IUser User => this._user;

    protected SimultaneousSessionExceededException(SerializationInfo info, StreamingContext context)
    {
      SimultaneousSessionExceededException.SRCaAa7nLkAC3NH0x6P();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void SRCaAa7nLkAC3NH0x6P() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object cKk2Am7OBe5J6nuYVt8(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool VUfFPS7TnDkLQHhrcfQ() => SimultaneousSessionExceededException.Nfu4yQ7XNM7NHjXbobT == null;

    internal static SimultaneousSessionExceededException wSqfCS7k8HJYRlYLgGr() => SimultaneousSessionExceededException.Nfu4yQ7XNM7NHjXbobT;
  }
}
