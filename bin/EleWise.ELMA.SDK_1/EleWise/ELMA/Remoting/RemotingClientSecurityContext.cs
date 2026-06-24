// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Remoting.RemotingClientSecurityContext
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Remoting
{
  /// <summary>
  /// Контекст авторизации через Remoting на стороне клиента
  /// </summary>
  public class RemotingClientSecurityContext
  {
    /// <summary>Текущий контекст</summary>
    public static RemotingClientSecurityContext Current;
    private static RemotingClientSecurityContext JSpJidkOYVMYYMqGvyV;

    /// <summary>Создать контекст</summary>
    /// <param name="userName"></param>
    /// <param name="password"></param>
    public RemotingClientSecurityContext(string userName, string password)
    {
      RemotingClientSecurityContext.qG0KFDkPbQ2xE5ktB8U();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.UserName = userName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.Password = password;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 2 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Токен авторизации (заполняется после успешной авторизации)
    /// </summary>
    public Guid Token
    {
      get => this.\u003CToken\u003Ek__BackingField;
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
              this.\u003CToken\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
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
    /// Идентификатор авторизованного пользователя (заполняется после успешной авторизации)
    /// </summary>
    public long UserId
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
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

    /// <summary>Имя пользователя</summary>
    public string UserName
    {
      get => this.\u003CUserName\u003Ek__BackingField;
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
              this.\u003CUserName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
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

    internal static void qG0KFDkPbQ2xE5ktB8U() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool j3WXwQk2fnpkQQHjYDV() => RemotingClientSecurityContext.JSpJidkOYVMYYMqGvyV == null;

    internal static RemotingClientSecurityContext Ask9Chkew5D0Jtrkj60() => RemotingClientSecurityContext.JSpJidkOYVMYYMqGvyV;
  }
}
