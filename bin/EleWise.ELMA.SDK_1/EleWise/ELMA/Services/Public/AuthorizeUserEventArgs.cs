// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Public.AuthorizeUserEventArgs
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Services.Public
{
  [Serializable]
  public class AuthorizeUserEventArgs : EventArgs
  {
    private static AuthorizeUserEventArgs zvE4UpB00vLYfo0HhLtb;

    public string UserId
    {
      get => this.\u003CUserId\u003Ek__BackingField;
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
              this.\u003CUserId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
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

    public string SessionToken
    {
      get => this.\u003CSessionToken\u003Ek__BackingField;
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
              this.\u003CSessionToken\u003Ek__BackingField = value;
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

    public AuthorizeUserEventArgs()
    {
      AuthorizeUserEventArgs.wweRDwB0MO8HVCYMs4dm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool K0ry4eB0mXEcdbvW6Yij() => AuthorizeUserEventArgs.zvE4UpB00vLYfo0HhLtb == null;

    internal static AuthorizeUserEventArgs cgViNEB0y5qWRE0suMhm() => AuthorizeUserEventArgs.zvE4UpB00vLYfo0HhLtb;

    internal static void wweRDwB0MO8HVCYMs4dm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
