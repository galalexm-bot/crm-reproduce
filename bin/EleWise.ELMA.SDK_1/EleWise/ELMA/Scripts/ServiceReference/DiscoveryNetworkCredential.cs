// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.ServiceReference.DiscoveryNetworkCredential
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Net;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Scripts.ServiceReference
{
  /// <summary>
  /// Adds an authentication type to the standard NetworkCredential class.
  /// </summary>
  public class DiscoveryNetworkCredential : NetworkCredential
  {
    /// <summary>Тип авторизации по умолчанию</summary>
    public const string DefaultAuthenticationType = "Default";
    private string authenticationType;
    internal static DiscoveryNetworkCredential S5DJS5Bc3cHHWcl1KQu3;

    /// <summary>Ctor</summary>
    /// <param name="userName">Имя пользователя</param>
    /// <param name="password">Пароль</param>
    /// <param name="domain">Домен</param>
    /// <param name="authenticationType">Тип авторизации</param>
    public DiscoveryNetworkCredential(
      string userName,
      string password,
      string domain,
      string authenticationType)
    {
      DiscoveryNetworkCredential.G3x5beBcDgMjdDLDwKik();
      this.authenticationType = string.Empty;
      // ISSUE: explicit constructor call
      base.\u002Ector(userName, password, domain);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.authenticationType = authenticationType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="credential">Учетные данные</param>
    /// <param name="authenticationType">Тип авторизации</param>
    public DiscoveryNetworkCredential(NetworkCredential credential, string authenticationType)
    {
      DiscoveryNetworkCredential.G3x5beBcDgMjdDLDwKik();
      // ISSUE: explicit constructor call
      this.\u002Ector((string) DiscoveryNetworkCredential.ow8dAPBctMMIArhG6p8a((object) credential), (string) DiscoveryNetworkCredential.djOTbsBcwKAJFP5hdcZB((object) credential), (string) DiscoveryNetworkCredential.aYM6xTBc4clg9sZGFpDg((object) credential), authenticationType);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Тип авторизации</summary>
    public string AuthenticationType => this.authenticationType;

    /// <summary>Тип авторизации по умолчанию</summary>
    public bool IsDefaultAuthenticationType => DiscoveryNetworkCredential.fa1NhgBcHZ61rl04Iqes((object) this.authenticationType, DiscoveryNetworkCredential.dVYYBEBc6UFZKhOOdcmf(1819636893 << 3 ^ 1672161406), true) == 0;

    internal static void G3x5beBcDgMjdDLDwKik() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool V1XZO3Bcp0nrGvbfO5Cm() => DiscoveryNetworkCredential.S5DJS5Bc3cHHWcl1KQu3 == null;

    internal static DiscoveryNetworkCredential YIGKKSBcaVbmwZY10MDC() => DiscoveryNetworkCredential.S5DJS5Bc3cHHWcl1KQu3;

    internal static object ow8dAPBctMMIArhG6p8a([In] object obj0) => (object) ((NetworkCredential) obj0).UserName;

    internal static object djOTbsBcwKAJFP5hdcZB([In] object obj0) => (object) ((NetworkCredential) obj0).Password;

    internal static object aYM6xTBc4clg9sZGFpDg([In] object obj0) => (object) ((NetworkCredential) obj0).Domain;

    internal static object dVYYBEBc6UFZKhOOdcmf(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static int fa1NhgBcHZ61rl04Iqes([In] object obj0, [In] object obj1, [In] bool obj2) => string.Compare((string) obj0, (string) obj1, obj2);
  }
}
