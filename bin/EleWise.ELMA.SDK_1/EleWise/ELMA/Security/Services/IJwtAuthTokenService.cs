// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IJwtAuthTokenService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Security.Services
{
  /// <summary>Сервис для авторизации с использованием JWT токенов</summary>
  public interface IJwtAuthTokenService
  {
    /// <summary>Сгенерировать токен авторизации</summary>
    /// <param name="authInfo">Информация об авторизации</param>
    /// <returns>Токен авторизации</returns>
    JwtTokenContainer CreateToken(AuthInfoContainer authInfo);

    /// <summary>Получить пользователя по токену</summary>
    /// <param name="jwtToken">Токен авторизации</param>
    /// <returns>Информация об авторизации</returns>
    AuthInfoContainer GetAuthInfo(string jwtToken);

    /// <summary>Обновить токен авторизации</summary>
    /// <param name="refreshToken">Токен обновления авторизации</param>
    /// <returns>Новый токен</returns>
    JwtTokenContainer RefreshToken(string refreshToken);

    /// <summary>Отозвать токены авторизации для пользователя</summary>
    /// <param name="authInfo">Информация об авторизации</param>
    void Revoke(AuthInfoContainer authInfo);
  }
}
