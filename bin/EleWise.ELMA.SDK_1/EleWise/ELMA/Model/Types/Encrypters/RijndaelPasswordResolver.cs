// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.RijndaelPasswordResolver
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Encrypters
{
  /// <summary>Реализация шифрования методом Рейндал (AES)</summary>
  [Component(Order = 10)]
  internal class RijndaelPasswordResolver : IPasswordResolver
  {
    /// <summary>Уникальный идентификатор провайдера</summary>
    internal static Guid UID;
    internal static RijndaelPasswordResolver MPpssRojwEsV2PNFOLjk;

    /// <inheritdoc />
    public Guid Uid => RijndaelPasswordResolver.UID;

    /// <inheritdoc />
    public string DisplayName => (string) RijndaelPasswordResolver.timrmaojAfglWwnKwwFb(RijndaelPasswordResolver.u5fGWkojH9YRgPcp1VZ3(-542721635 ^ -542892753));

    /// <inheritdoc />
    public bool Check(string encryptedPassword, string salt, string password)
    {
      int num = 1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = EncryptionHelper.DecryptPwd(encryptedPassword, (byte[]) RijndaelPasswordResolver.mMo2y8oj7bO6V874BBSE((object) salt));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return password.Equals(str, StringComparison.Ordinal);
    }

    /// <inheritdoc />
    public string Decrypt(string password, string salt) => (string) RijndaelPasswordResolver.NDEvMiojx5IV804O6m5Y((object) password, RijndaelPasswordResolver.mMo2y8oj7bO6V874BBSE((object) salt));

    /// <inheritdoc />
    public string Encrypt(string password, string salt) => (string) RijndaelPasswordResolver.AEsHCeoj0ULclSx1fBU6((object) password, RijndaelPasswordResolver.mMo2y8oj7bO6V874BBSE((object) salt));

    /// <inheritdoc />
    public string GenerateSalt() => EncryptionHelper.GenerateSalt();

    public RijndaelPasswordResolver()
    {
      RijndaelPasswordResolver.kMCS3TojmqF6di18I9ye();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static RijndaelPasswordResolver()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            RijndaelPasswordResolver.UID = new Guid((string) RijndaelPasswordResolver.u5fGWkojH9YRgPcp1VZ3(1142330761 ^ 1541959139 ^ 536632506));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static object u5fGWkojH9YRgPcp1VZ3(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object timrmaojAfglWwnKwwFb([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool FE8Ht9oj4FA6iRAM6b4E() => RijndaelPasswordResolver.MPpssRojwEsV2PNFOLjk == null;

    internal static RijndaelPasswordResolver bGwrjRoj6Mx7PDEHgxdV() => RijndaelPasswordResolver.MPpssRojwEsV2PNFOLjk;

    internal static object mMo2y8oj7bO6V874BBSE([In] object obj0) => (object) Convert.FromBase64String((string) obj0);

    internal static object NDEvMiojx5IV804O6m5Y([In] object obj0, [In] object obj1) => (object) EncryptionHelper.DecryptPwd((string) obj0, (byte[]) obj1);

    internal static object AEsHCeoj0ULclSx1fBU6([In] object obj0, [In] object obj1) => (object) EncryptionHelper.EncryptPwd((string) obj0, (byte[]) obj1);

    internal static void kMCS3TojmqF6di18I9ye() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
