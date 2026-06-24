// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.AuthInfoContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;

namespace EleWise.ELMA.Security
{
  /// <summary>Контейнер для информации об авторизации</summary>
  public sealed class AuthInfoContainer
  {
    private static readonly IDictionary<string, string> EmptyAdditionalClaims;
    internal static AuthInfoContainer qfLKrdB5RJwvWwpksWKZ;

    /// <summary>Ctor</summary>
    /// <param name="userId">Идентификатор пользователя</param>
    /// <param name="applicationToken">Токен приложения</param>
    public AuthInfoContainer(long userId, string applicationToken)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(userId, applicationToken, AuthInfoContainer.EmptyAdditionalClaims);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="userId">Пользователь</param>
    /// <param name="applicationToken">Токен приложения</param>
    /// <param name="additionalClaims">Дополнительные параметры</param>
    public AuthInfoContainer(
      long userId,
      string applicationToken,
      IDictionary<string, string> additionalClaims)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNullOrEmpty(applicationToken, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812122042));
      Contract.ArgumentNotNull((object) additionalClaims, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87413669));
      this.UserId = userId;
      this.ApplicationToken = applicationToken;
      this.AdditionalClaims = additionalClaims;
    }

    /// <summary>Пользователь</summary>
    public long UserId { get; }

    /// <summary>Токен приложения</summary>
    public string ApplicationToken { get; }

    /// <summary>Дополнительные параметры авторизации</summary>
    public IDictionary<string, string> AdditionalClaims { get; private set; }

    static AuthInfoContainer()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            AuthInfoContainer.EmptyAdditionalClaims = (IDictionary<string, string>) new Dictionary<string, string>(0);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
            continue;
          case 2:
            AuthInfoContainer.FEHAtZB5XJHVO0t08G3e();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool RNGv0bB5qR5SwFvsSlgL() => AuthInfoContainer.qfLKrdB5RJwvWwpksWKZ == null;

    internal static AuthInfoContainer cVR45GB5Ktv2Qolg6Px5() => AuthInfoContainer.qfLKrdB5RJwvWwpksWKZ;

    internal static void FEHAtZB5XJHVO0t08G3e() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
