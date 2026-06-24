// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.Models.AuthResponse
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
  /// <summary>Результат авторизации</summary>
  [DataContract(Name = "Auth")]
  [Description("SR.M('Результат авторизации')")]
  [Serializable]
  public class AuthResponse
  {
    private static AuthResponse kQGCmsf184DWviDQvVRh;

    /// <summary>AuthToken</summary>
    [Description("SR.M('Токен авторизации')")]
    [DataMember]
    public Guid AuthToken
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
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

    /// <summary>
    /// Токен сессии. Храните его в приложении как можно дольше
    /// </summary>
    [DataMember]
    [Description("SR.M('Токен сессии. Храните его в приложении как можно дольше')")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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

    /// <summary>Идентификатор текущего пользователя</summary>
    [DataMember]
    [Description("SR.M('Идентификатор текущего пользователя')")]
    public string CurrentUserId
    {
      get => this.\u003CCurrentUserId\u003Ek__BackingField;
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
              this.\u003CCurrentUserId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
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

    /// <summary>Имя текущего пользователя</summary>
    [DataMember]
    [Description("SR.M('Имя текущего пользователя')")]
    public string CurrentUserName
    {
      get => this.\u003CCurrentUserName\u003Ek__BackingField;
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
              this.\u003CCurrentUserName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
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

    /// <summary>Язык текущего пользователя</summary>
    [DataMember]
    [Description("SR.M('Язык текущего пользователя')")]
    public string Lang
    {
      get => this.\u003CLang\u003Ek__BackingField;
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
              this.\u003CLang\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
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

    public AuthResponse()
    {
      AuthResponse.iNmE7Tf1IsC4EdacdLo5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool IIKuXPf1Zud9SOWngFtp() => AuthResponse.kQGCmsf184DWviDQvVRh == null;

    internal static AuthResponse jC4xauf1u5Ihsi3ma0nP() => AuthResponse.kQGCmsf184DWviDQvVRh;

    internal static void iNmE7Tf1IsC4EdacdLo5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
