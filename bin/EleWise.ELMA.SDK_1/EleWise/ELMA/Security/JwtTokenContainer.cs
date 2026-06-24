// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.JwtTokenContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security
{
  /// <summary>Контейнер JWT токена</summary>
  public sealed class JwtTokenContainer
  {
    internal static JwtTokenContainer EvGIT5B5TFag35gbaVvG;

    /// <summary>Ctor</summary>
    /// <param name="jwtToken">Токен авторизации</param>
    /// <param name="refreshToken">Токен для обновления токена авторизации</param>
    public JwtTokenContainer(string jwtToken, string refreshToken)
    {
      JwtTokenContainer.goRUb6B5OaiKExtytWyK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.RefreshToken = refreshToken;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
            continue;
          case 2:
            this.JwtToken = jwtToken;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Токен авторизации</summary>
    public string JwtToken { get; }

    /// <summary>Токен для обновления токена авторизации</summary>
    public string RefreshToken { get; }

    internal static void goRUb6B5OaiKExtytWyK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ddSwYTB5kZZBvslpnwMD() => JwtTokenContainer.EvGIT5B5TFag35gbaVvG == null;

    internal static JwtTokenContainer wKuLxLB5ng1GepUitx9T() => JwtTokenContainer.EvGIT5B5TFag35gbaVvG;
  }
}
