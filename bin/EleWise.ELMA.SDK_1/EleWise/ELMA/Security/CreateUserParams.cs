// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.CreateUserParams
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security
{
  /// <summary>Параметры для создания пользователя</summary>
  public class CreateUserParams
  {
    internal static CreateUserParams Fc6TCEBjmFYFpZTwqAU3;

    /// <summary>Конструктор</summary>
    /// <param name="username">Имя пользователя</param>
    /// <param name="password">Пароль</param>
    /// <param name="email">Адрес электронной почты</param>
    public CreateUserParams(string username, string password, string email)
    {
      CreateUserParams.BTTR0hBjJOyxCXUHcEsO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Username = username;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          case 2:
            this.Email = email;
            num = 3;
            continue;
          case 3:
            goto label_3;
          default:
            this.Password = password;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Имя пользователя</summary>
    public string Username
    {
      get => this.\u003CUsername\u003Ek__BackingField;
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
              this.\u003CUsername\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
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

    /// <summary>Пароль</summary>
    public string Password
    {
      get => this.\u003CPassword\u003Ek__BackingField;
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
              this.\u003CPassword\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
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

    /// <summary>Адрес электронной почты</summary>
    public string Email
    {
      get => this.\u003CEmail\u003Ek__BackingField;
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
              this.\u003CEmail\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
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

    internal static void BTTR0hBjJOyxCXUHcEsO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool WTLxNNBjyoNfwwF4bGm1() => CreateUserParams.Fc6TCEBjmFYFpZTwqAU3 == null;

    internal static CreateUserParams jKpO3DBjMvwtTgPAV8lt() => CreateUserParams.Fc6TCEBjmFYFpZTwqAU3;
  }
}
