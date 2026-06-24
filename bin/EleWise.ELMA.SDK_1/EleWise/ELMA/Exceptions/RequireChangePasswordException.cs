// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.RequireChangePasswordException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Exceptions
{
  /// <summary>
  /// Вызывается при установленном флаге принудительной смены пароля
  /// </summary>
  [Serializable]
  public class RequireChangePasswordException : Exception
  {
    private IUser _user;
    internal static RequireChangePasswordException rZL3udGgl1G16rqjNQAG;

    /// <summary>Ctor</summary>
    /// <param name="user">Пользователь, который пытается войти в систему</param>
    public RequireChangePasswordException(IUser user)
    {
      RequireChangePasswordException.KHwPBNGg5eNXd5OZur7u();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) RequireChangePasswordException.btNlWwGgjwAE4uKnxPfB((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154090831)));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this._user = user;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public RequireChangePasswordException()
    {
      RequireChangePasswordException.KHwPBNGg5eNXd5OZur7u();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) RequireChangePasswordException.btNlWwGgjwAE4uKnxPfB(RequireChangePasswordException.b8bx5jGgY4T36ammhL4d(44884861 ^ 44879079)));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this._user = (IUser) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public IUser User => this._user;

    protected RequireChangePasswordException(SerializationInfo info, StreamingContext context)
    {
      RequireChangePasswordException.KHwPBNGg5eNXd5OZur7u();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void KHwPBNGg5eNXd5OZur7u() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object btNlWwGgjwAE4uKnxPfB([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool mwUgtOGgrAZjAfStWd1Q() => RequireChangePasswordException.rZL3udGgl1G16rqjNQAG == null;

    internal static RequireChangePasswordException g5oSPnGggPJxvkpu9NXa() => RequireChangePasswordException.rZL3udGgl1G16rqjNQAG;

    internal static object b8bx5jGgY4T36ammhL4d(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
