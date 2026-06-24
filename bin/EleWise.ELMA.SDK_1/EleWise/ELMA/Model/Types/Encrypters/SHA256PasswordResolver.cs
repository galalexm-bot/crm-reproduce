// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.SHA256PasswordResolver
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
  /// <summary>Реализация хеширования методом SHA256</summary>
  [Component(Order = 10)]
  internal class SHA256PasswordResolver : IPasswordResolver
  {
    /// <summary>Уникальный идентификатор провайдера</summary>
    internal static Guid UID;
    private static SHA256PasswordResolver K2c5w0ojynOV1cVRwPPn;

    /// <inheritdoc />
    public Guid Uid => SHA256PasswordResolver.UID;

    /// <inheritdoc />
    public string DisplayName => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411351411));

    /// <inheritdoc />
    public bool Check(string encryptedPassword, string salt, string password)
    {
      int num = 1;
      string sha256Hash;
      while (true)
      {
        switch (num)
        {
          case 1:
            sha256Hash = EncryptionHelper.GetSha256Hash(password, salt);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return SHA256PasswordResolver.OOODnkoj9qS03y3Wsc2p((object) encryptedPassword, (object) sha256Hash, StringComparison.Ordinal);
    }

    /// <inheritdoc />
    public string Decrypt(string password, string salt) => password;

    /// <inheritdoc />
    public string Encrypt(string password, string salt) => (string) SHA256PasswordResolver.ibHyVFojdku6oLrKuCuj((object) password, (object) salt);

    /// <inheritdoc />
    public string GenerateSalt() => EncryptionHelper.GenerateSalt();

    public SHA256PasswordResolver()
    {
      SHA256PasswordResolver.vpwhYMojlIvkoU2G5HZX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static SHA256PasswordResolver()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            SHA256PasswordResolver.UID = new Guid((string) SHA256PasswordResolver.sc6m8kojrJeSkbxwtf0W(516838154 ^ 516748854));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
            continue;
          case 2:
            SHA256PasswordResolver.vpwhYMojlIvkoU2G5HZX();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool UtYJY3ojMEgqIObW80xZ() => SHA256PasswordResolver.K2c5w0ojynOV1cVRwPPn == null;

    internal static SHA256PasswordResolver G1iJeeojJhxSk0TesqC0() => SHA256PasswordResolver.K2c5w0ojynOV1cVRwPPn;

    internal static bool OOODnkoj9qS03y3Wsc2p([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static object ibHyVFojdku6oLrKuCuj([In] object obj0, [In] object obj1) => (object) EncryptionHelper.GetSha256Hash((string) obj0, (string) obj1);

    internal static void vpwhYMojlIvkoU2G5HZX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object sc6m8kojrJeSkbxwtf0W(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
