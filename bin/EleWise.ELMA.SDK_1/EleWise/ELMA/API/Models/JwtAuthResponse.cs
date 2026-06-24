// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.Models.JwtAuthResponse
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.API.Models
{
  /// <summary>
  /// Ответ на запрос авторизации с использованием JWT токена
  /// </summary>
  [DataContract(Name = "JwtAuth")]
  [Description("SR.M('Результат авторизации в виде JWT токена')")]
  [Serializable]
  public class JwtAuthResponse
  {
    private static JwtAuthResponse iOiZeXfNfqUFaaQVNwAm;

    /// <summary>JWT токен авторизации</summary>
    [Description("SR.M('JWT токен авторизации, содержит идентификатор пользователя (userId), токен приложения (appToken), а так же сведения о пользовательской локали (lang)')")]
    [DataMember]
    public string AuthToken
    {
      get => this.\u003CAuthToken\u003Ek__BackingField;
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
              this.\u003CAuthToken\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
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

    /// <summary>Токен обновления авторизации</summary>
    [Description("SR.M('Токен обновления авторизации, одноразовый')")]
    [DataMember]
    public string RefreshToken
    {
      get => this.\u003CRefreshToken\u003Ek__BackingField;
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
              this.\u003CRefreshToken\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
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

    public JwtAuthResponse()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool NPF9HnfNQVWHxxeA2V8a() => JwtAuthResponse.iOiZeXfNfqUFaaQVNwAm == null;

    internal static JwtAuthResponse mKwOWUfNCgeTT2AL3DBY() => JwtAuthResponse.iOiZeXfNfqUFaaQVNwAm;
  }
}
