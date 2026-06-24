// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Cryptography.EcdhKey
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Cryptography
{
  /// <summary>Ключевая пара</summary>
  public class EcdhKey : IEcdhKey
  {
    private static EcdhKey M5u99lBLbcJ38ERquDAN;

    /// <summary>Ctor</summary>
    /// <param name="publicKey"></param>
    /// <param name="sharedSecret"></param>
    public EcdhKey(byte[] publicKey, byte[] sharedSecret)
    {
      EcdhKey.suBojEBLEl5p7qpfMo9H();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.SharedSecret = sharedSecret;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
            continue;
          case 2:
            this.PublicKey = publicKey;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Публичный ключ</summary>
    public byte[] PublicKey
    {
      get => this.\u003CPublicKey\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CPublicKey\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
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

    /// <summary>Разделяемый секрет</summary>
    public byte[] SharedSecret
    {
      get => this.\u003CSharedSecret\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CSharedSecret\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
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

    internal static void suBojEBLEl5p7qpfMo9H() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool GE65DWBLh90N9lyVmGYj() => EcdhKey.M5u99lBLbcJ38ERquDAN == null;

    internal static EcdhKey cuKYPNBLGX8dqDkqukRj() => EcdhKey.M5u99lBLbcJ38ERquDAN;
  }
}
