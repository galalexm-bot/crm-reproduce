// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.ConcurrentLicenseExceededException
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

namespace EleWise.ELMA.Licensing
{
  /// <summary>
  /// Вызывается, когда превышено число конкурентных лицензий
  /// </summary>
  [Serializable]
  public class ConcurrentLicenseExceededException : LicenseException
  {
    private IUser _user;
    private static ConcurrentLicenseExceededException AlGQQhAflqs2FJXdr5U;

    /// <summary>Ctor</summary>
    /// <param name="user">Пользователь, который пытается войти в систему</param>
    public ConcurrentLicenseExceededException(IUser user)
    {
      ConcurrentLicenseExceededException.FCZIuJAvFQG368mbKuf();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) ConcurrentLicenseExceededException.xeKSq4AZHpSjSv4EMiV(ConcurrentLicenseExceededException.r662OcA8Uu9W9yu8Vc7(-1998538950 ^ -1998577178)));
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._user = user;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public IUser User => this._user;

    protected ConcurrentLicenseExceededException(SerializationInfo info, StreamingContext context)
    {
      ConcurrentLicenseExceededException.FCZIuJAvFQG368mbKuf();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void FCZIuJAvFQG368mbKuf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object r662OcA8Uu9W9yu8Vc7(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object xeKSq4AZHpSjSv4EMiV([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool xfdVcKAQOjCc93751t0() => ConcurrentLicenseExceededException.AlGQQhAflqs2FJXdr5U == null;

    internal static ConcurrentLicenseExceededException HNHicAACI9eEj2jNQkC() => ConcurrentLicenseExceededException.AlGQQhAflqs2FJXdr5U;
  }
}
