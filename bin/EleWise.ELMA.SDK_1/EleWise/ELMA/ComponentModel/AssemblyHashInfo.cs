// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.AssemblyHashInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>Содержит информацию с хэш-кодом сборки</summary>
  [Serializable]
  public class AssemblyHashInfo
  {
    internal static AssemblyHashInfo JyJXcwfE2gHOJTd8mPOp;

    /// <summary>Имя сборки</summary>
    public string AssemblyName
    {
      get => this.\u003CAssemblyName\u003Ek__BackingField;
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
              this.\u003CAssemblyName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
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

    /// <summary>Хэш-код</summary>
    public string HashCode
    {
      get => this.\u003CHashCode\u003Ek__BackingField;
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
              this.\u003CHashCode\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
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

    /// <summary>Вычислить хэш-код файла</summary>
    /// <param name="fileName">Полное имя файла</param>
    public void EvaluteHashCode(string fileName)
    {
      int num1 = 2;
      FileStream fileStream;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_11;
          case 1:
            goto label_2;
          case 2:
            fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 1;
            continue;
          default:
            goto label_10;
        }
      }
label_11:
      return;
label_10:
      return;
label_2:
      try
      {
        this.EvaluteHashCode((Stream) fileStream);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (fileStream == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
        else
          goto label_12;
label_9:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_12:
        AssemblyHashInfo.TWKhxLfE18qUBsfoPLdD((object) fileStream);
        num3 = 2;
        goto label_9;
      }
    }

    /// <summary>Вычислить хэш-код потока</summary>
    /// <param name="fileName">Полное имя файла</param>
    public void EvaluteMD5(string fileName)
    {
      int num1 = 1;
      FileStream fileStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_12;
          default:
            goto label_2;
        }
      }
label_12:
      return;
label_2:
      try
      {
        this.EvaluteMD5((Stream) fileStream);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (fileStream != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                AssemblyHashInfo.TWKhxLfE18qUBsfoPLdD((object) fileStream);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                continue;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
    }

    /// <summary>Вычислить хэш-код потока</summary>
    /// <param name="stream">Поток</param>
    public void EvaluteHashCode(Stream stream)
    {
      int num1 = 1;
      SHA512 shA512;
      while (true)
      {
        switch (num1)
        {
          case 1:
            shA512 = SHA512.Create();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_3;
        }
      }
label_13:
      return;
label_3:
      try
      {
        byte[] inArray = (byte[]) AssemblyHashInfo.RXxHeEfENgVLCUEZ15MZ((object) shA512, (object) stream);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            default:
              this.HashCode = Convert.ToBase64String(inArray);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
              continue;
          }
        }
label_8:;
      }
      finally
      {
        if (shA512 != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                AssemblyHashInfo.TWKhxLfE18qUBsfoPLdD((object) shA512);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
    }

    /// <summary>Вычислить хэш-код потока</summary>
    /// <param name="stream">Поток</param>
    public void EvaluteMD5(Stream stream)
    {
      int num1 = 1;
      MD5CryptoServiceProvider cryptoServiceProvider;
      while (true)
      {
        switch (num1)
        {
          case 1:
            cryptoServiceProvider = new MD5CryptoServiceProvider();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_3;
        }
      }
label_13:
      return;
label_3:
      try
      {
        this.HashCode = (string) AssemblyHashInfo.h4PJJQfE3KV8kB6h2IZP(AssemblyHashInfo.RXxHeEfENgVLCUEZ15MZ((object) cryptoServiceProvider, (object) stream));
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (cryptoServiceProvider != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_15;
              default:
                cryptoServiceProvider.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_15:;
      }
    }

    /// <summary>Вычислить хэш-код бинарных данных</summary>
    /// <param name="assemblyRaw">Бинарные данные</param>
    public void EvaluteHashCode(byte[] assemblyRaw)
    {
      int num1 = 2;
      SHA512 shA512;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_12;
          case 1:
            goto label_3;
          case 2:
            shA512 = (SHA512) AssemblyHashInfo.hDp3elfEpZkrIlCfT8qT();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
            continue;
          default:
            goto label_11;
        }
      }
label_12:
      return;
label_11:
      return;
label_3:
      try
      {
        byte[] inArray = (byte[]) AssemblyHashInfo.PB7leofEa3TbY1wMtBwb((object) shA512, (object) assemblyRaw);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            default:
              this.HashCode = Convert.ToBase64String(inArray);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
              continue;
          }
        }
label_7:;
      }
      finally
      {
        int num3;
        if (shA512 == null)
          num3 = 2;
        else
          goto label_13;
label_10:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_13:
        AssemblyHashInfo.TWKhxLfE18qUBsfoPLdD((object) shA512);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
        {
          num3 = 0;
          goto label_10;
        }
        else
          goto label_10;
      }
    }

    /// <summary>Вычислить хэш-код сборки</summary>
    /// <param name="asm">Сборка</param>
    public void EvaluteHashCode(Assembly asm)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        byte[] assemblyRaw;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
            case 6:
              this.EvaluteHashCode(assemblyRaw);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 8;
              continue;
            case 3:
              if (AssemblyHashInfo.uF5iS7fE4emvPJwX8HP4(AssemblyHashInfo.IYATExfEtuGjRP23M088((object) asm)))
              {
                num2 = 7;
                continue;
              }
              goto label_12;
            case 4:
              goto label_5;
            case 5:
              assemblyRaw = (byte[]) AssemblyHashInfo.RTTssKfEDEkWSuXr7FPV((object) asm);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 4 : 2;
              continue;
            case 7:
              this.EvaluteHashCode((string) AssemblyHashInfo.IYATExfEtuGjRP23M088((object) asm));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 2 : 1;
              continue;
            case 8:
              goto label_9;
            default:
              goto label_12;
          }
        }
label_5:
        if (assemblyRaw != null)
        {
          num1 = 6;
          continue;
        }
label_10:
        if (!AssemblyHashInfo.HIBEVBfEwnC7kKWLnho6(AssemblyHashInfo.IYATExfEtuGjRP23M088((object) asm)))
          num1 = 3;
        else
          goto label_12;
      }
label_9:
      return;
label_12:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) AssemblyHashInfo.XC7ncEfE6pUeThDMbmZ4(901793403 ^ 901926025), (object) asm.FullName));
    }

    public AssemblyHashInfo()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool N9TE1wfEeCYeEunG5mto() => AssemblyHashInfo.JyJXcwfE2gHOJTd8mPOp == null;

    internal static AssemblyHashInfo zb5uZFfEPoEChM73x3eU() => AssemblyHashInfo.JyJXcwfE2gHOJTd8mPOp;

    internal static void TWKhxLfE18qUBsfoPLdD([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object RXxHeEfENgVLCUEZ15MZ([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((Stream) obj1);

    internal static object h4PJJQfE3KV8kB6h2IZP([In] object obj0) => (object) Convert.ToBase64String((byte[]) obj0);

    internal static object hDp3elfEpZkrIlCfT8qT() => (object) SHA512.Create();

    internal static object PB7leofEa3TbY1wMtBwb([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((byte[]) obj1);

    internal static object RTTssKfEDEkWSuXr7FPV([In] object obj0) => (object) ComponentManager.GetLoadedAssemblyRaw((Assembly) obj0);

    internal static object IYATExfEtuGjRP23M088([In] object obj0) => (object) ((Assembly) obj0).Location;

    internal static bool HIBEVBfEwnC7kKWLnho6([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool uF5iS7fE4emvPJwX8HP4([In] object obj0) => File.Exists((string) obj0);

    internal static object XC7ncEfE6pUeThDMbmZ4(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
