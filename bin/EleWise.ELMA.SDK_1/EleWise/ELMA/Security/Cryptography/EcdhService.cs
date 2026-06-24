// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Cryptography.EcdhService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace EleWise.ELMA.Security.Cryptography
{
  /// <summary>Сервис согласования секрета сессии по алгоритму ECDH</summary>
  [Service]
  public class EcdhService : IEcdhService
  {
    private static readonly byte[] keyTypePublicP256;
    private static readonly byte[] keyLength256;
    private static readonly byte[] dotNetFormatSignature;
    internal static EcdhService KQVTddBLfA95PgOTBpAP;

    /// <summary>
    /// Получение ключевой пары по присланному другой стороной публичному ключу
    /// </summary>
    /// <param name="publicKey">Публичный ключ</param>
    /// <returns>Ключевую пару: наш_публичный_ключ, shared_secret</returns>
    public IEcdhKey DeriveKeyMaterial(byte[] publicKey)
    {
      int num1 = 1;
      ECDiffieHellmanCng diffieHellmanCng;
      byte[] normalizedPublicKey;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (this.CheckFixPublicKey(publicKey, out normalizedPublicKey))
            {
              diffieHellmanCng = new ECDiffieHellmanCng(256);
              num1 = 3;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_7;
          default:
            goto label_3;
        }
      }
label_2:
      IEcdhKey ecdhKey;
      return ecdhKey;
label_3:
      throw new CryptographicException(EleWise.ELMA.SR.T((string) EcdhService.RncpBlBLvb3VmSYs94Qp(-542721635 ^ -542653527)));
label_7:
      try
      {
        object publicKey1 = EcdhService.AAthZJBLZ1S0PfEyaMFp(EcdhService.qdGm4KBL8hPSrLiPB8y7((object) diffieHellmanCng));
        diffieHellmanCng.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
        diffieHellmanCng.HashAlgorithm = (CngAlgorithm) EcdhService.eSPRMHBLuXSbgMNevTBU();
        ECDiffieHellmanPublicKey hellmanPublicKey = (ECDiffieHellmanPublicKey) EcdhService.w059oPBLVfG33aVIoHAx((object) normalizedPublicKey, EcdhService.BU6L32BLIFSZ28M4dilo());
        byte[] sharedSecret = (byte[]) EcdhService.HsD2RDBLSQ7pZSrqaAqS((object) diffieHellmanCng, (object) hellmanPublicKey);
        ecdhKey = (IEcdhKey) new EcdhKey((byte[]) publicKey1, sharedSecret);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      finally
      {
        int num3;
        if (diffieHellmanCng == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 1;
        else
          goto label_13;
label_12:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_13:
        EcdhService.seEAKOBLi3e152xWKqwH((object) diffieHellmanCng);
        num3 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        {
          num3 = 0;
          goto label_12;
        }
        else
          goto label_12;
      }
    }

    /// <summary>
    /// Конвертация из формата ключа DotNet CNG в uncompressed format
    /// </summary>
    /// <param name="publicKey">Публичный ключ</param>
    /// <returns>Ключ в формате uncompressed</returns>
    public byte[] DotNetToUncompressed(byte[] publicKey) => ((IEnumerable<byte>) new byte[1]
    {
      (byte) 4
    }).Concat<byte>(((IEnumerable<byte>) publicKey).Skip<byte>(EcdhService.dotNetFormatSignature.Length)).ToArray<byte>();

    /// <summary>
    /// Проверка и, при возможности, восстановление ключа в формате DotNet CNG
    /// </summary>
    /// <param name="publicKey">публичный ключ</param>
    /// <param name="normalizedPublicKey">Ключ в формате DotNet CNG</param>
    /// <returns>Результат проверки/конветации</returns>
    public bool CheckFixPublicKey(byte[] publicKey, out byte[] normalizedPublicKey)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (publicKey[0] == (byte) 4)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 3 : 3;
              continue;
            }
            break;
          case 2:
            if (publicKey.Length == 65)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 1;
              continue;
            }
            break;
          case 3:
            normalizedPublicKey = ((IEnumerable<byte>) EcdhService.dotNetFormatSignature).Concat<byte>(((IEnumerable<byte>) publicKey).Skip<byte>(1)).ToArray<byte>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 4 : 4;
            continue;
          case 4:
            goto label_8;
          case 5:
label_7:
            normalizedPublicKey = publicKey;
            num = 7;
            continue;
          case 6:
            normalizedPublicKey = Array.Empty<byte>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
            continue;
          case 7:
            goto label_5;
          default:
            goto label_13;
        }
        if (!this.CheckDotNetPublicKeyFormat(publicKey))
          num = 6;
        else
          goto label_7;
      }
label_5:
      return true;
label_8:
      return true;
label_13:
      return false;
    }

    private bool CheckDotNetPublicKeyFormat(byte[] publicKey)
    {
      int num = 3;
      int index;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
            if (index < EcdhService.dotNetFormatSignature.Length)
            {
              num = 5;
              continue;
            }
            goto label_2;
          case 2:
            goto label_11;
          case 3:
            if (publicKey.Length != 72)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 2 : 1;
              continue;
            }
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 4 : 2;
            continue;
          case 5:
          case 7:
            if ((int) publicKey[index] == (int) EcdhService.dotNetFormatSignature[index])
            {
              ++index;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
            continue;
          case 6:
            goto label_2;
          default:
            goto label_7;
        }
      }
label_2:
      return true;
label_7:
      return false;
label_11:
      return false;
    }

    public EcdhService()
    {
      EcdhService.unCSU6BLRmiopuIRcuA7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EcdhService()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
            continue;
          case 2:
            EcdhService.dotNetFormatSignature = ((IEnumerable<byte>) EcdhService.keyTypePublicP256).Concat<byte>((IEnumerable<byte>) EcdhService.keyLength256).ToArray<byte>();
            num = 4;
            continue;
          case 3:
            EcdhService.keyLength256 = new byte[4]
            {
              (byte) 32,
              (byte) 0,
              (byte) 0,
              (byte) 0
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 2 : 2;
            continue;
          case 4:
            goto label_2;
          default:
            byte[] numArray = new byte[4];
            // ISSUE: field reference
            EcdhService.InC968BLqtoPIripWEEy((object) numArray, __fieldref (\u003CPrivateImplementationDetails\u003E.\u0039C7E099C650E7D6A6903F693ECE572615F88BB6A));
            EcdhService.keyTypePublicP256 = numArray;
            num = 3;
            continue;
        }
      }
label_2:;
    }

    internal static object RncpBlBLvb3VmSYs94Qp(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object qdGm4KBL8hPSrLiPB8y7([In] object obj0) => (object) ((ECDiffieHellman) obj0).PublicKey;

    internal static object AAthZJBLZ1S0PfEyaMFp([In] object obj0) => (object) ((ECDiffieHellmanPublicKey) obj0).ToByteArray();

    internal static object eSPRMHBLuXSbgMNevTBU() => (object) CngAlgorithm.Sha256;

    internal static object BU6L32BLIFSZ28M4dilo() => (object) CngKeyBlobFormat.EccPublicBlob;

    internal static object w059oPBLVfG33aVIoHAx([In] object obj0, [In] object obj1) => (object) ECDiffieHellmanCngPublicKey.FromByteArray((byte[]) obj0, (CngKeyBlobFormat) obj1);

    internal static object HsD2RDBLSQ7pZSrqaAqS([In] object obj0, [In] object obj1) => (object) ((ECDiffieHellman) obj0).DeriveKeyMaterial((ECDiffieHellmanPublicKey) obj1);

    internal static void seEAKOBLi3e152xWKqwH([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool C64tt7BLQtaxXvHWjhkv() => EcdhService.KQVTddBLfA95PgOTBpAP == null;

    internal static EcdhService U7CM1nBLCjDhk1WJ3Nx6() => EcdhService.KQVTddBLfA95PgOTBpAP;

    internal static void unCSU6BLRmiopuIRcuA7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void InC968BLqtoPIripWEEy([In] object obj0, [In] RuntimeFieldHandle obj1) => RuntimeHelpers.InitializeArray((Array) obj0, obj1);
  }
}
