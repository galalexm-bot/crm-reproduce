// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.EncryptionHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Помошник для шифрования</summary>
  public class EncryptionHelper
  {
    private static IBinaryFileHashService binaryFileHashService;
    private static readonly Microsoft.Extensions.ObjectPool.ObjectPool<RNGCryptoServiceProvider> RngCryptoServiceProviderPool;
    private static readonly Microsoft.Extensions.ObjectPool.ObjectPool<SHA256Managed> Sha256ManagedPool;
    /// <summary>
    /// Пул <see cref="T:System.Security.Cryptography.MD5CryptoServiceProvider" />
    /// </summary>
    internal static readonly Microsoft.Extensions.ObjectPool.ObjectPool<MD5CryptoServiceProvider> Md5CryptoServiceProviderPool;
    private static readonly byte[] PubKey;
    private static readonly byte[] Iv;
    private static EncryptionHelper SMBnkvGFH7750VrdSTL5;

    /// <summary>
    /// Сервис хеширования <see cref="T:EleWise.ELMA.Files.BinaryFile" />.
    /// </summary>
    protected static IBinaryFileHashService BinaryFileHashService
    {
      get
      {
        int num = 1;
        IBinaryFileHashService binaryFileHashService;
        while (true)
        {
          switch (num)
          {
            case 1:
              binaryFileHashService = EncryptionHelper.binaryFileHashService;
              if (binaryFileHashService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return binaryFileHashService;
label_5:
        return EncryptionHelper.binaryFileHashService = Locator.GetServiceNotNull<IBinaryFileHashService>();
      }
    }

    /// <summary>Конструктор</summary>
    /// <param name="binaryFileHash">Интерфейс сервиса хеширования <see cref="T:EleWise.ELMA.Files.BinaryFile" /></param>
    internal EncryptionHelper(IBinaryFileHashService binaryFileHash)
    {
      EncryptionHelper.LIYiKoGFxWWPq6Lqf2fQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            EncryptionHelper.binaryFileHashService = binaryFileHash;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Сгенерировать соль</summary>
    /// <param name="size"></param>
    /// <returns></returns>
    public static string GenerateSalt(int size = 16)
    {
      int num1 = 1;
      RNGCryptoServiceProvider cryptoServiceProvider;
      byte[] numArray;
      while (true)
      {
        switch (num1)
        {
          case 1:
            numArray = new byte[size];
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_12;
          case 3:
            goto label_2;
          default:
            cryptoServiceProvider = (RNGCryptoServiceProvider) null;
            num1 = 3;
            continue;
        }
      }
label_2:
      string salt;
      try
      {
        cryptoServiceProvider = EncryptionHelper.RngCryptoServiceProviderPool.Get();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_12;
            case 2:
              salt = (string) EncryptionHelper.C4nUiiGFmXLqgTkiFtAr((object) numArray);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 1;
              continue;
            default:
              EncryptionHelper.paWtVvGF0TnCOmBv8LGD((object) cryptoServiceProvider, (object) numArray);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 2 : 2;
              continue;
          }
        }
      }
      finally
      {
        EncryptionHelper.RngCryptoServiceProviderPool.Return(cryptoServiceProvider);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_12:
      return salt;
    }

    /// <summary>Зашифровать c солью, используя Sha256 шифрование</summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string GetSha256Hash(string input, string salt)
    {
      int num1 = 3;
      SHA256Managed shA256Managed;
      while (true)
      {
        string str1;
        string str2;
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            str2 = "";
            break;
          case 3:
            string str3 = input;
            if (str3 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 2;
              continue;
            }
            str2 = str3;
            break;
          case 4:
            string str4 = salt;
            if (str4 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            }
            str1 = str4;
            goto label_21;
          case 5:
            goto label_13;
          case 6:
            shA256Managed = (SHA256Managed) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 1;
            continue;
          default:
            str1 = "";
            goto label_21;
        }
        input = str2;
        num1 = 4;
        continue;
label_21:
        salt = str1;
        num1 = 6;
      }
label_2:
      string sha256Hash;
      try
      {
        shA256Managed = EncryptionHelper.Sha256ManagedPool.Get();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
          num2 = 0;
        int num3;
        int num4;
        while (true)
        {
          switch (num2)
          {
            case 1:
              sha256Hash = MemoryHelper.ActionWithMemoryBuffer<byte, (SHA256Managed, string, string, int), string>(num4 + num3, (shA256Managed, input, salt, num4), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (SHA256Managed, string, string, int), string>(EncryptionHelper.GetSha256HashAction));
              num2 = 2;
              continue;
            case 2:
              goto label_13;
            case 3:
              num3 = EncryptionHelper.HWbS2lGFMdpPTPyAbpgf(EncryptionHelper.bb5ienGFyXcmrOmWwlZx(), (object) salt);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 1 : 1;
              continue;
            default:
              num4 = EncryptionHelper.HWbS2lGFMdpPTPyAbpgf(EncryptionHelper.bb5ienGFyXcmrOmWwlZx(), (object) input);
              num2 = 3;
              continue;
          }
        }
      }
      finally
      {
        EncryptionHelper.Sha256ManagedPool.Return(shA256Managed);
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
label_13:
      return sha256Hash;
    }

    private static string GetSha256HashAction(
      object buffer,
      int offset,
      int length,
      (SHA256Managed, string, string, int) param)
    {
      (SHA256Managed shA256Managed, string s1, string s2, int num) = param;
      Encoding.UTF8.GetBytes(s1, 0, s1.Length, (byte[]) buffer, offset);
      Encoding.UTF8.GetBytes(s2, 0, s2.Length, (byte[]) buffer, offset + num);
      return Convert.ToBase64String(shA256Managed.ComputeHash((byte[]) buffer, offset, length));
    }

    /// <summary>Зашифровать, используя MD5 шифрование</summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string GetMd5Hash(string input)
    {
      int num1 = 2;
      byte[] buffer;
      MD5CryptoServiceProvider cryptoServiceProvider;
      while (true)
      {
        string str1;
        switch (num1)
        {
          case 1:
            str1 = "";
            break;
          case 2:
            string str2 = input;
            if (str2 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
              continue;
            }
            str1 = str2;
            break;
          case 3:
            goto label_13;
          case 4:
            cryptoServiceProvider = (MD5CryptoServiceProvider) null;
            num1 = 5;
            continue;
          case 5:
            goto label_3;
          default:
            buffer = (byte[]) EncryptionHelper.CfFlSVGFJoADfPwDmvH5(EncryptionHelper.bb5ienGFyXcmrOmWwlZx(), (object) input);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 4 : 4;
            continue;
        }
        input = str1;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
      }
label_3:
      string md5Hash;
      try
      {
        cryptoServiceProvider = EncryptionHelper.Md5CryptoServiceProviderPool.Get();
        int num2 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              md5Hash = (string) EncryptionHelper.u9iJHoGF996oMX45bnul((object) buffer);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
              continue;
            case 2:
              buffer = cryptoServiceProvider.ComputeHash(buffer);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
              continue;
            default:
              goto label_13;
          }
        }
      }
      finally
      {
        EncryptionHelper.Md5CryptoServiceProviderPool.Return(cryptoServiceProvider);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_13:
      return md5Hash;
    }

    /// <summary>Зашифровать, используя MD5 шифрование</summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string GetMd5Hash(Stream input)
    {
      int num1 = 1;
      MD5CryptoServiceProvider cryptoServiceProvider;
      while (true)
      {
        object obj;
        switch (num1)
        {
          case 1:
            Stream stream = input;
            if (stream == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            }
            obj = (object) stream;
            break;
          case 2:
            goto label_2;
          case 3:
            goto label_6;
          case 4:
            cryptoServiceProvider = (MD5CryptoServiceProvider) null;
            num1 = 3;
            continue;
          default:
            obj = EncryptionHelper.aE0u9TGFdKjNMNyKyEyA((object) Array.Empty<byte>(), false);
            break;
        }
        input = (Stream) obj;
        num1 = 4;
      }
label_2:
      string md5Hash;
      return md5Hash;
label_6:
      try
      {
        cryptoServiceProvider = EncryptionHelper.Md5CryptoServiceProviderPool.Get();
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
          num2 = 1;
        Stream stream;
        while (true)
        {
          switch (num2)
          {
            case 1:
              stream = input;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        try
        {
          md5Hash = (string) EncryptionHelper.u9iJHoGF996oMX45bnul((object) cryptoServiceProvider.ComputeHash(input));
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
            num3 = 0;
          switch (num3)
          {
            default:
              goto label_2;
          }
        }
        finally
        {
          if (stream != null)
          {
            int num4 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
              num4 = 0;
            while (true)
            {
              switch (num4)
              {
                case 1:
                  goto label_20;
                default:
                  stream.Dispose();
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 1;
                  continue;
              }
            }
          }
label_20:;
        }
      }
      finally
      {
        EncryptionHelper.Md5CryptoServiceProviderPool.Return(cryptoServiceProvider);
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
    }

    /// <summary>Зашифровать, используя MD5 шифрование</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public static string GetMd5Hash(BinaryFile file) => EncryptionHelper.BinaryFileHashService.GetHash(file, HashAlogrithmEnum.MD5);

    /// <summary>Попытаться получить хэш</summary>
    /// <param name="file"></param>
    /// <param name="hash"></param>
    /// <returns></returns>
    public static bool TryGetMd5Hash(BinaryFile file, out string hash)
    {
      int num = 1;
      string error;
      while (true)
      {
        switch (num)
        {
          case 1:
            error = "";
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return EncryptionHelper.TryGetMd5Hash(file, out hash, out error);
    }

    /// <summary>Попытаться получить хэш</summary>
    /// <param name="file"></param>
    /// <param name="hash"></param>
    /// <returns>Ошибка</returns>
    public static bool TryGetMd5Hash(BinaryFile file, out string hash, out string error)
    {
      bool md5Hash;
      switch (1)
      {
        case 1:
          try
          {
            hash = EncryptionHelper.GetMd5Hash(file);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_1;
                case 2:
                  md5Hash = true;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 0;
                  continue;
                default:
                  error = "";
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 2 : 2;
                  continue;
              }
            }
          }
          catch (Exception ex)
          {
            int num = 3;
            while (true)
            {
              switch (num)
              {
                case 1:
                  md5Hash = false;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
                  continue;
                case 2:
                  error = ex.Message;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 0;
                  continue;
                case 3:
                  hash = "";
                  num = 2;
                  continue;
                default:
                  goto label_1;
              }
            }
          }
      }
label_1:
      return md5Hash;
    }

    /// <summary>Попытаться получить хэш старым методом</summary>
    /// <param name="file">Файл</param>
    /// <param name="hash">Хеш</param>
    /// <param name="error">Ошибка</param>
    /// <returns>Удалось ли получить</returns>
    public static bool TryGetMd5LegacyHash(BinaryFile file, out string hash, out string error)
    {
      bool md5LegacyHash;
      switch (1)
      {
        case 1:
          try
          {
            string str = "";
            int num1 = 3;
            Stream content;
            byte[] numArray;
            while (true)
            {
              switch (num1)
              {
                case 1:
                  try
                  {
                    numArray = content.ReadAllBytes();
                    int num2 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
                      num2 = 0;
                    switch (num2)
                    {
                      default:
                        goto label_8;
                    }
                  }
                  finally
                  {
                    int num3;
                    if (content == null)
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 1;
                    else
                      goto label_16;
label_15:
                    switch (num3)
                    {
                      case 1:
                      case 2:
                    }
label_16:
                    EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) content);
                    num3 = 2;
                    goto label_15;
                  }
                case 2:
                  goto label_1;
                case 3:
                  if (file != null)
                  {
                    num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
                    continue;
                  }
                  goto case 7;
                case 4:
                  error = "";
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 5 : 5;
                  continue;
                case 5:
                  md5LegacyHash = true;
                  num1 = 2;
                  continue;
                case 6:
label_8:
                  str = (string) EncryptionHelper.rt0PQtGFrpsAhBM8PLlD((object) Encoding.UTF8, (object) numArray);
                  num1 = 7;
                  continue;
                case 7:
                  hash = (string) EncryptionHelper.ErL1UMGFgQ2IifOkjB1G((object) str);
                  num1 = 4;
                  continue;
                default:
                  content = file.GetContent();
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 1;
                  continue;
              }
            }
          }
          catch (Exception ex)
          {
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  hash = "";
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 3;
                  continue;
                case 2:
                  md5LegacyHash = false;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                  continue;
                case 3:
                  error = (string) EncryptionHelper.VZYZdiGF5Gj4gw7plbwE((object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 2;
                  continue;
                default:
                  goto label_1;
              }
            }
          }
      }
label_1:
      return md5LegacyHash;
    }

    /// <summary>Проверить хэш md5</summary>
    /// <param name="hash"></param>
    /// <param name="file"></param>
    /// <returns></returns>
    public static EncryptionHelper.VerifyMd5Result VerifyMd5Hash(string hash, BinaryFile file)
    {
      int num = 4;
      string hash1;
      EncryptionHelper.VerifyMd5Result verifyMd5Result;
      string error;
      bool flag;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!EncryptionHelper.TryGetMd5Hash(file, out hash1, out error))
            {
              num = 11;
              continue;
            }
            goto case 10;
          case 2:
            verifyMd5Result.Verified = false;
            num = 8;
            continue;
          case 3:
            error = "";
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 1;
            continue;
          case 4:
            hash1 = "";
            num = 3;
            continue;
          case 5:
            goto label_12;
          case 6:
            verifyMd5Result.Error = !flag ? (string) EncryptionHelper.R8t5iVGFLKCGFrIbnOTv(EncryptionHelper.uTZljvGFYTIvSpkJqlNi(--1867379187 ^ 1867400213)) : "";
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 5;
            continue;
          case 7:
            verifyMd5Result = new EncryptionHelper.VerifyMd5Result();
            num = 9;
            continue;
          case 8:
            verifyMd5Result.Error = error;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
            continue;
          case 9:
            verifyMd5Result.Verified = flag;
            num = 6;
            continue;
          case 10:
            flag = EncryptionHelper.Sy0ftoGFjEwxV6t90JDU((object) hash1, (object) hash);
            num = 7;
            continue;
          case 11:
            verifyMd5Result = new EncryptionHelper.VerifyMd5Result();
            num = 2;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return verifyMd5Result;
label_12:
      return verifyMd5Result;
    }

    /// <summary>Шифрование алгоритмом AES</summary>
    /// <param name="encString">nt</param>
    /// <returns></returns>
    public static string EncryptPwd(string encString) => (string) EncryptionHelper.jFEZ2rGFUewcdbvT9Dpp((object) encString, (object) EncryptionHelper.Iv);

    /// <summary>Шифрование алгоритмом AES</summary>
    /// <param name="encString">Строка для хеширования</param>
    /// <param name="iv">Направляющий вектор byte[16]</param>
    /// <returns></returns>
    public static string EncryptPwd(string encString, byte[] iv)
    {
      int num1 = 2;
      RijndaelManaged rijndaelManaged;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            rijndaelManaged = new RijndaelManaged();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      string str;
      return str;
label_3:
      try
      {
        MemoryStream memoryStream = (MemoryStream) EncryptionHelper.Wjmcs6GFsb6VawSBxrU1();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream.AsNoClose(), (ICryptoTransform) EncryptionHelper.X5TXutGFcbZC4nAnr0qJ((object) rijndaelManaged, (object) EncryptionHelper.PubKey, (object) iv), CryptoStreamMode.Write);
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
                num3 = 2;
              while (true)
              {
                switch (num3)
                {
                  case 1:
label_30:
                    EncryptionHelper.au3PPIGFz87gDT7sgbGP((object) memoryStream, 0L, SeekOrigin.Begin);
                    num3 = 3;
                    continue;
                  case 2:
                    try
                    {
                      StreamWriter streamWriter = new StreamWriter((Stream) cryptoStream);
                      int num4 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
                        num4 = 0;
                      switch (num4)
                      {
                        default:
                          try
                          {
                            streamWriter.WriteLine(encString);
                            int num5 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
                              num5 = 0;
                            switch (num5)
                            {
                              default:
                                goto label_30;
                            }
                          }
                          finally
                          {
                            if (streamWriter != null)
                            {
                              int num6 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
                                num6 = 0;
                              while (true)
                              {
                                switch (num6)
                                {
                                  case 1:
                                    goto label_22;
                                  default:
                                    streamWriter.Dispose();
                                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
                                    continue;
                                }
                              }
                            }
label_22:;
                          }
                      }
                    }
                    finally
                    {
                      if (cryptoStream != null)
                      {
                        int num7 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
                          num7 = 0;
                        while (true)
                        {
                          switch (num7)
                          {
                            case 1:
                              goto label_28;
                            default:
                              EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) cryptoStream);
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 0;
                              continue;
                          }
                        }
                      }
label_28:;
                    }
                  case 3:
                    str = MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int) memoryStream.Length, memoryStream, new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, MemoryStream, string>(EncryptionHelper.EncryptPwdAction));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_2;
                }
              }
            }
            finally
            {
              int num8;
              if (memoryStream == null)
                num8 = 2;
              else
                goto label_34;
label_33:
              switch (num8)
              {
                case 1:
                  break;
                default:
              }
label_34:
              EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) memoryStream);
              num8 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
              {
                num8 = 0;
                goto label_33;
              }
              else
                goto label_33;
            }
        }
      }
      finally
      {
        if (rijndaelManaged != null)
        {
          int num9 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
            num9 = 1;
          while (true)
          {
            switch (num9)
            {
              case 1:
                rijndaelManaged.Dispose();
                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
                continue;
              default:
                goto label_42;
            }
          }
        }
label_42:;
      }
    }

    private static string EncryptPwdAction(
      object buffer,
      int offset,
      int length,
      object memoryStream)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ((Stream) memoryStream).Read((byte[]) buffer, offset, length);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) EncryptionHelper.WOm14QGBFr3CyF63fGn3(buffer, offset, length);
    }

    /// <summary>Дешифрование алгоритмом AES</summary>
    /// <param name="pwd">Пароль</param>
    /// <returns></returns>
    public static string DecryptPwd(string pwd) => (string) EncryptionHelper.gU6OBkGBB94ccnMGBryq((object) pwd, (object) EncryptionHelper.Iv);

    /// <summary>Дешифрование алгоритмом AES</summary>
    /// <param name="pwd">Пароль</param>
    /// <param name="iv">Соль</param>
    /// <returns></returns>
    public static string DecryptPwd(string pwd, byte[] iv)
    {
      int num1 = 1;
      byte[] numArray;
      RijndaelManaged rijndaelManaged;
      while (true)
      {
        switch (num1)
        {
          case 1:
            numArray = (byte[]) EncryptionHelper.h0L7MFGBWcF9MXsvX5vh((object) pwd);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_43;
          case 3:
            goto label_2;
          default:
            rijndaelManaged = new RijndaelManaged();
            num1 = 3;
            continue;
        }
      }
label_2:
      string str;
      try
      {
        MemoryStream memoryStream = (MemoryStream) EncryptionHelper.aE0u9TGFdKjNMNyKyEyA((object) numArray, false);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, (ICryptoTransform) EncryptionHelper.ubABtaGBoRTHZRcqwoBw((object) rijndaelManaged, (object) EncryptionHelper.PubKey, (object) iv), CryptoStreamMode.Read);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  try
                  {
                    StreamReader streamReader = new StreamReader((Stream) cryptoStream);
                    int num4 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
                      num4 = 0;
                    switch (num4)
                    {
                      default:
                        try
                        {
                          str = (string) EncryptionHelper.l6aKfPGBbcy28GoM2IuB((object) streamReader);
                          int num5 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
                            num5 = 0;
                          switch (num5)
                          {
                          }
                        }
                        finally
                        {
                          int num6;
                          if (streamReader == null)
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                          else
                            goto label_20;
label_19:
                          switch (num6)
                          {
                            case 2:
                              break;
                            default:
                          }
label_20:
                          streamReader.Dispose();
                          num6 = 1;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
                          {
                            num6 = 0;
                            goto label_19;
                          }
                          else
                            goto label_19;
                        }
                        break;
                    }
                  }
                  finally
                  {
                    if (cryptoStream != null)
                    {
                      int num7 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
                        num7 = 0;
                      while (true)
                      {
                        switch (num7)
                        {
                          case 1:
                            cryptoStream.Dispose();
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_28;
                        }
                      }
                    }
label_28:;
                  }
              }
            }
            finally
            {
              int num8;
              if (memoryStream == null)
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 0;
              else
                goto label_32;
label_31:
              switch (num8)
              {
                case 1:
                case 2:
              }
label_32:
              EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) memoryStream);
              num8 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
              {
                num8 = 2;
                goto label_31;
              }
              else
                goto label_31;
            }
        }
      }
      finally
      {
        int num9;
        if (rijndaelManaged == null)
          num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
        else
          goto label_38;
label_37:
        switch (num9)
        {
          case 2:
            break;
          default:
        }
label_38:
        EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) rijndaelManaged);
        num9 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        {
          num9 = 1;
          goto label_37;
        }
        else
          goto label_37;
      }
label_43:
      return str;
    }

    /// <summary>Зашифровать по паролю</summary>
    /// <param name="plainText"></param>
    /// <param name="passPhrase"></param>
    /// <returns></returns>
    public static string Encrypt(string plainText, string passPhrase)
    {
      int num1 = 4;
      StringBuilder stringBuilder;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
          case 6:
            if (num2 >= 8)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            EncryptionHelper.mq4ZAsGBEAbvTc92aOw8((object) stringBuilder, EncryptionHelper.nRPHqdGBG7AttuFIoO1t(EncryptionHelper.uTZljvGFYTIvSpkJqlNi(1574260816 ^ 1574240928), (object) EncryptionHelper.eyd55BGBhL5upVNyicGL((object) passPhrase)));
            num1 = 5;
            continue;
          case 3:
            num2 = 0;
            num1 = 6;
            continue;
          case 4:
            stringBuilder = new StringBuilder();
            num1 = 3;
            continue;
          case 5:
            ++num2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return (string) EncryptionHelper.zoXtALGBfPY14yVgveBM((object) plainText, (object) stringBuilder.ToString(), (object) passPhrase);
    }

    /// <summary>Зашифровать по паролю + соль</summary>
    /// <param name="plainText"></param>
    /// <param name="saltStr"></param>
    /// <param name="passPhrase"></param>
    public static string Encrypt(string plainText, string saltStr, string passPhrase)
    {
      int num1 = 1;
      Rfc2898DeriveBytes rfc2898DeriveBytes;
      byte[] bytes;
      while (true)
      {
        switch (num1)
        {
          case 1:
            bytes = ((Encoding) EncryptionHelper.b8VnC3GBQhUDRbTRNykw()).GetBytes(saltStr);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_12;
          case 3:
            goto label_2;
          default:
            rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, bytes, 10000);
            num1 = 3;
            continue;
        }
      }
label_2:
      string str;
      try
      {
        str = (string) EncryptionHelper.GRxyWCGBCClKsdgN0PSB((object) plainText, (object) rfc2898DeriveBytes);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (rfc2898DeriveBytes == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 1;
        else
          goto label_8;
label_7:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_8:
        EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) rfc2898DeriveBytes);
        num3 = 2;
        goto label_7;
      }
label_12:
      return str;
    }

    /// <summary>Зашифровать по паролю + соль</summary>
    /// <param name="plainText">Шифруемый</param>
    /// <param name="saltStr">Соль</param>
    /// <param name="passPhrase">Пароль</param>
    public static string Encrypt(string plainText, string saltStr, byte[] passPhrase)
    {
      int num1 = 3;
      Rfc2898DeriveBytes rfc2898DeriveBytes;
      byte[] salt;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, salt, 10000);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 1;
            continue;
          case 3:
            salt = (byte[]) EncryptionHelper.CfFlSVGFJoADfPwDmvH5(EncryptionHelper.b8VnC3GBQhUDRbTRNykw(), (object) saltStr);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 2 : 2;
            continue;
          default:
            goto label_12;
        }
      }
label_2:
      string str;
      try
      {
        str = (string) EncryptionHelper.GRxyWCGBCClKsdgN0PSB((object) plainText, (object) rfc2898DeriveBytes);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (rfc2898DeriveBytes != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_10;
              default:
                rfc2898DeriveBytes.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_10:;
      }
label_12:
      return str;
    }

    private static string EncryptInnerLogic(object plainText, object pwdGen)
    {
      int num1 = 3;
      RijndaelManaged rijndaelManaged1;
      byte[] numArray1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            RijndaelManaged rijndaelManaged2 = new RijndaelManaged();
            EncryptionHelper.GPkAHJGB8eWfpbWNYGNh((object) rijndaelManaged2, 256);
            rijndaelManaged1 = rijndaelManaged2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 1;
            continue;
          case 3:
            numArray1 = (byte[]) EncryptionHelper.CfFlSVGFJoADfPwDmvH5(EncryptionHelper.r61mqmGBvPwMserDDdYA(), plainText);
            num1 = 2;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      string str;
      return str;
label_4:
      try
      {
        byte[] numArray2 = (byte[]) EncryptionHelper.B09IVKGBuF3n9rksPXgX(pwdGen, EncryptionHelper.ItUKJcGBZZYj063xTm5n((object) rijndaelManaged1) / 8);
        int num2 = 3;
        byte[] numArray3;
        MemoryStream memoryStream;
        while (true)
        {
          switch (num2)
          {
            case 1:
              memoryStream = (MemoryStream) EncryptionHelper.Wjmcs6GFsb6VawSBxrU1();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 2 : 2;
              continue;
            case 2:
              goto label_10;
            case 3:
              numArray3 = (byte[]) EncryptionHelper.B09IVKGBuF3n9rksPXgX(pwdGen, rijndaelManaged1.BlockSize / 8);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
              continue;
            case 4:
              rijndaelManaged1.IV = numArray3;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
              continue;
            default:
              rijndaelManaged1.Key = numArray2;
              num2 = 4;
              continue;
          }
        }
label_10:
        try
        {
          CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream.AsNoClose(), (ICryptoTransform) EncryptionHelper.LdL3yRGBI3H3r0iqS0ty((object) rijndaelManaged1), CryptoStreamMode.Write);
          int num3 = 2;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_3;
              case 2:
                try
                {
                  EncryptionHelper.SwI0RtGBV9V7B4iBEY4n((object) cryptoStream, (object) numArray1, 0, numArray1.Length);
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
                    num4 = 0;
                  switch (num4)
                  {
                    default:
                      goto label_22;
                  }
                }
                finally
                {
                  if (cryptoStream != null)
                  {
                    int num5 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
                      num5 = 0;
                    while (true)
                    {
                      switch (num5)
                      {
                        case 1:
                          goto label_21;
                        default:
                          EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) cryptoStream);
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
                          continue;
                      }
                    }
                  }
label_21:;
                }
              case 3:
label_22:
                EncryptionHelper.au3PPIGFz87gDT7sgbGP((object) memoryStream, 0L, SeekOrigin.Begin);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                continue;
              default:
                str = MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int) EncryptionHelper.rI9ayTGBSgMZemxQqrRw((object) memoryStream), memoryStream, new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, MemoryStream, string>(EncryptionHelper.EncryptAction));
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 1 : 1;
                continue;
            }
          }
        }
        finally
        {
          int num6;
          if (memoryStream == null)
            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
          else
            goto label_26;
label_25:
          switch (num6)
          {
            case 2:
              break;
            default:
          }
label_26:
          memoryStream.Dispose();
          num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
          {
            num6 = 1;
            goto label_25;
          }
          else
            goto label_25;
        }
      }
      finally
      {
        int num7;
        if (rijndaelManaged1 == null)
          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 1;
        else
          goto label_32;
label_31:
        switch (num7)
        {
          case 2:
            break;
          default:
        }
label_32:
        rijndaelManaged1.Dispose();
        num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
        {
          num7 = 0;
          goto label_31;
        }
        else
          goto label_31;
      }
    }

    private static string EncryptAction(
      object buffer,
      int offset,
      int length,
      object memoryStream)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ((Stream) memoryStream).Read((byte[]) buffer, offset, length);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return Convert.ToBase64String((byte[]) buffer, offset, length);
    }

    /// <summary>Зашифровать файл с паролем + соль</summary>
    /// <param name="fileInput"></param>
    /// <param name="fileEncrypted"></param>
    /// <param name="saltStr"></param>
    /// <param name="passPhrase"></param>
    public static void EncryptFile(
      string fileInput,
      string fileEncrypted,
      string saltStr,
      string passPhrase)
    {
      int num1 = 1;
      byte[] salt;
      Rfc2898DeriveBytes rfc2898DeriveBytes;
      while (true)
      {
        switch (num1)
        {
          case 1:
            salt = (byte[]) EncryptionHelper.CfFlSVGFJoADfPwDmvH5(EncryptionHelper.b8VnC3GBQhUDRbTRNykw(), (object) saltStr);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            goto label_57;
          default:
            rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, salt, 10000);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 2 : 0;
            continue;
        }
      }
label_57:
      return;
label_4:
      try
      {
        RijndaelManaged rijndaelManaged1 = new RijndaelManaged();
        EncryptionHelper.GPkAHJGB8eWfpbWNYGNh((object) rijndaelManaged1, 256);
        RijndaelManaged rijndaelManaged2 = rijndaelManaged1;
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              byte[] numArray1 = (byte[]) EncryptionHelper.B09IVKGBuF3n9rksPXgX((object) rfc2898DeriveBytes, rijndaelManaged2.KeySize / 8);
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
                num3 = 0;
              byte[] numArray2;
              FileStream fileStream1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    numArray2 = (byte[]) EncryptionHelper.B09IVKGBuF3n9rksPXgX((object) rfc2898DeriveBytes, EncryptionHelper.Rs1J4hGBixUexD1sJmTb((object) rijndaelManaged2) / 8);
                    num3 = 3;
                    continue;
                  case 2:
                    EncryptionHelper.LtaDamGBqpebrs4FmyYJ((object) rijndaelManaged2, (object) numArray2);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
                    continue;
                  case 3:
                    EncryptionHelper.lpVuJJGBRE5Zq76Yr8jU((object) rijndaelManaged2, (object) numArray1);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 2 : 0;
                    continue;
                  case 4:
                    goto label_15;
                  default:
                    fileStream1 = new FileStream(fileInput, FileMode.Open, FileAccess.Read);
                    num3 = 4;
                    continue;
                }
              }
label_15:
              try
              {
                FileStream fileStream2 = new FileStream(fileEncrypted, FileMode.Create, FileAccess.Write);
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                    try
                    {
                      CryptoStream cryptoStream = new CryptoStream((Stream) fileStream2, (ICryptoTransform) EncryptionHelper.LdL3yRGBI3H3r0iqS0ty((object) rijndaelManaged2), CryptoStreamMode.Write);
                      int num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
                        num5 = 0;
                      switch (num5)
                      {
                        default:
                          try
                          {
                            EncryptionHelper.FTnpW4GBKX777V9QA9hA((object) fileStream1, (object) cryptoStream);
                            int num6 = 1;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
                              num6 = 1;
                            while (true)
                            {
                              switch (num6)
                              {
                                case 0:
                                  goto label_49;
                                case 1:
                                  EncryptionHelper.PfZPklGBX52mroZwtuFR((object) cryptoStream);
                                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                                  continue;
                                default:
                                  goto label_48;
                              }
                            }
label_49:
                            return;
label_48:
                            return;
                          }
                          finally
                          {
                            if (cryptoStream != null)
                            {
                              int num7 = 1;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
                                num7 = 0;
                              while (true)
                              {
                                switch (num7)
                                {
                                  case 1:
                                    EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) cryptoStream);
                                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
                                    continue;
                                  default:
                                    goto label_32;
                                }
                              }
                            }
label_32:;
                          }
                      }
                    }
                    finally
                    {
                      if (fileStream2 != null)
                      {
                        int num8 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
                          num8 = 0;
                        while (true)
                        {
                          switch (num8)
                          {
                            case 1:
                              goto label_38;
                            default:
                              EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) fileStream2);
                              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 0;
                              continue;
                          }
                        }
                      }
label_38:;
                    }
                }
              }
              finally
              {
                if (fileStream1 != null)
                {
                  int num9 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
                    num9 = 1;
                  while (true)
                  {
                    switch (num9)
                    {
                      case 1:
                        fileStream1.Dispose();
                        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_44;
                    }
                  }
                }
label_44:;
              }
            }
            finally
            {
              int num10;
              if (rijndaelManaged2 == null)
                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 2 : 1;
              else
                goto label_50;
label_47:
              switch (num10)
              {
                case 1:
                  break;
                default:
              }
label_50:
              rijndaelManaged2.Dispose();
              num10 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
              {
                num10 = 0;
                goto label_47;
              }
              else
                goto label_47;
            }
        }
      }
      finally
      {
        if (rfc2898DeriveBytes != null)
        {
          int num11 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
            num11 = 0;
          while (true)
          {
            switch (num11)
            {
              case 1:
                goto label_59;
              default:
                EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) rfc2898DeriveBytes);
                num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_59:;
      }
    }

    /// <summary>Расшифровать по паролю</summary>
    /// <param name="cipherText"></param>
    /// <param name="passPhrase"></param>
    /// <returns></returns>
    public static string Decrypt(string cipherText, string passPhrase)
    {
      int num1 = 3;
      StringBuilder stringBuilder;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            num2 = 0;
            num1 = 5;
            continue;
          case 3:
            stringBuilder = new StringBuilder();
            num1 = 2;
            continue;
          case 4:
          case 7:
            EncryptionHelper.mq4ZAsGBEAbvTc92aOw8((object) stringBuilder, EncryptionHelper.nRPHqdGBG7AttuFIoO1t(EncryptionHelper.uTZljvGFYTIvSpkJqlNi(1461625753 ^ 1461645673), (object) EncryptionHelper.eyd55BGBhL5upVNyicGL((object) passPhrase)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 3 : 6;
            continue;
          case 6:
            ++num2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
            continue;
          default:
            if (num2 < 8)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 4 : 4;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return (string) EncryptionHelper.yNyTkUGBTAr1p7I0wavv((object) cipherText, (object) stringBuilder.ToString(), (object) passPhrase);
    }

    /// <summary>Расшифровать по паролю + соль</summary>
    /// <param name="cipherText"></param>
    /// <param name="saltStr"></param>
    /// <param name="passPhrase"></param>
    public static string Decrypt(string cipherText, string saltStr, string passPhrase)
    {
      int num1 = 2;
      byte[] bytes;
      Rfc2898DeriveBytes pwdGen;
      while (true)
      {
        switch (num1)
        {
          case 1:
            pwdGen = new Rfc2898DeriveBytes(passPhrase, bytes, 10000);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 3;
            continue;
          case 2:
            bytes = ((Encoding) EncryptionHelper.b8VnC3GBQhUDRbTRNykw()).GetBytes(saltStr);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_4;
          default:
            goto label_13;
        }
      }
label_4:
      string str;
      try
      {
        str = EncryptionHelper.DecryptInnerLogic((object) cipherText, (object) pwdGen);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (pwdGen != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) pwdGen);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
                continue;
              default:
                goto label_12;
            }
          }
        }
label_12:;
      }
label_13:
      return str;
    }

    /// <summary>Расшифровать по паролю + соль</summary>
    /// <param name="cipherText">Расшифровываемый текст</param>
    /// <param name="saltStr">Соль</param>
    /// <param name="passPhrase">Пароль</param>
    public static string Decrypt(string cipherText, string saltStr, byte[] passPhrase)
    {
      int num1 = 3;
      Rfc2898DeriveBytes rfc2898DeriveBytes;
      byte[] bytes;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, bytes, 10000);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 0;
            continue;
          case 3:
            bytes = Encoding.ASCII.GetBytes(saltStr);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 2;
            continue;
          default:
            goto label_10;
        }
      }
label_2:
      string str;
      try
      {
        str = (string) EncryptionHelper.SZjKdeGBkykVTvOkvmF1((object) cipherText, (object) rfc2898DeriveBytes);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (rfc2898DeriveBytes == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 1;
        else
          goto label_8;
label_7:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_8:
        EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) rfc2898DeriveBytes);
        num3 = 2;
        goto label_7;
      }
label_10:
      return str;
    }

    private static string DecryptInnerLogic(object cipherText, object pwdGen)
    {
      int num1 = 1;
      RijndaelManaged rijndaelManaged1;
      byte[] buffer;
      while (true)
      {
        switch (num1)
        {
          case 1:
            buffer = (byte[]) EncryptionHelper.h0L7MFGBWcF9MXsvX5vh(cipherText);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            goto label_4;
          default:
            RijndaelManaged rijndaelManaged2 = new RijndaelManaged();
            EncryptionHelper.GPkAHJGB8eWfpbWNYGNh((object) rijndaelManaged2, 256);
            rijndaelManaged1 = rijndaelManaged2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 2 : 0;
            continue;
        }
      }
label_4:
      string str;
      return str;
label_5:
      try
      {
        byte[] numArray1 = (byte[]) EncryptionHelper.B09IVKGBuF3n9rksPXgX(pwdGen, rijndaelManaged1.KeySize / 8);
        int num2 = 4;
        byte[] numArray2;
        MemoryStream memoryStream;
        while (true)
        {
          switch (num2)
          {
            case 1:
              EncryptionHelper.lpVuJJGBRE5Zq76Yr8jU((object) rijndaelManaged1, (object) numArray1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
              continue;
            case 2:
              memoryStream = (MemoryStream) EncryptionHelper.Wjmcs6GFsb6VawSBxrU1();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 3 : 3;
              continue;
            case 3:
              goto label_11;
            case 4:
              numArray2 = (byte[]) EncryptionHelper.B09IVKGBuF3n9rksPXgX(pwdGen, rijndaelManaged1.BlockSize / 8);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
              continue;
            default:
              EncryptionHelper.LtaDamGBqpebrs4FmyYJ((object) rijndaelManaged1, (object) numArray2);
              num2 = 2;
              continue;
          }
        }
label_11:
        try
        {
          CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream.AsNoClose(), (ICryptoTransform) EncryptionHelper.AvkYBIGBnMy1SVwelBn6((object) rijndaelManaged1), CryptoStreamMode.Write);
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                try
                {
                  cryptoStream.Write(buffer, 0, buffer.Length);
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
                    num4 = 0;
                  switch (num4)
                  {
                  }
                }
                finally
                {
                  if (cryptoStream != null)
                  {
                    int num5 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
                      num5 = 0;
                    while (true)
                    {
                      switch (num5)
                      {
                        case 1:
                          goto label_22;
                        default:
                          EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) cryptoStream);
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 1;
                          continue;
                      }
                    }
                  }
label_22:;
                }
                break;
              case 2:
                goto label_4;
            }
            str = (string) EncryptionHelper.QGjo1pGBO4wKBF6Hw9sA((object) memoryStream, EncryptionHelper.r61mqmGBvPwMserDDdYA());
            num3 = 2;
          }
        }
        finally
        {
          int num6;
          if (memoryStream == null)
            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 0;
          else
            goto label_27;
label_26:
          switch (num6)
          {
            case 2:
              break;
            default:
          }
label_27:
          EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) memoryStream);
          num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
          {
            num6 = 0;
            goto label_26;
          }
          else
            goto label_26;
        }
      }
      finally
      {
        if (rijndaelManaged1 != null)
        {
          int num7 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
            num7 = 1;
          while (true)
          {
            switch (num7)
            {
              case 1:
                EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) rijndaelManaged1);
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
                continue;
              default:
                goto label_35;
            }
          }
        }
label_35:;
      }
    }

    /// <summary>Расшифровать файл по паролю + соль</summary>
    /// <param name="fileEncrypted"></param>
    /// <param name="outputFile"></param>
    /// <param name="saltStr"></param>
    /// <param name="passPhrase"></param>
    public static void DecryptFile(
      string fileEncrypted,
      string outputFile,
      string saltStr,
      string passPhrase)
    {
      int num1 = 3;
      Rfc2898DeriveBytes rfc2898DeriveBytes;
      byte[] salt;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_55;
          case 1:
            goto label_2;
          case 2:
            rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, salt, 10000);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 1;
            continue;
          case 3:
            salt = (byte[]) EncryptionHelper.CfFlSVGFJoADfPwDmvH5(EncryptionHelper.b8VnC3GBQhUDRbTRNykw(), (object) saltStr);
            num1 = 2;
            continue;
          default:
            goto label_48;
        }
      }
label_55:
      return;
label_48:
      return;
label_2:
      try
      {
        RijndaelManaged rijndaelManaged1 = new RijndaelManaged();
        EncryptionHelper.GPkAHJGB8eWfpbWNYGNh((object) rijndaelManaged1, 256);
        RijndaelManaged rijndaelManaged2 = rijndaelManaged1;
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              byte[] numArray1 = (byte[]) EncryptionHelper.B09IVKGBuF3n9rksPXgX((object) rfc2898DeriveBytes, rijndaelManaged2.KeySize / 8);
              int num3 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
                num3 = 0;
              FileStream fileStream1;
              byte[] numArray2;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_13;
                  case 2:
                    numArray2 = (byte[]) EncryptionHelper.B09IVKGBuF3n9rksPXgX((object) rfc2898DeriveBytes, EncryptionHelper.Rs1J4hGBixUexD1sJmTb((object) rijndaelManaged2) / 8);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 4 : 0;
                    continue;
                  case 3:
                    fileStream1 = new FileStream(fileEncrypted, FileMode.Open, FileAccess.Read);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 1;
                    continue;
                  case 4:
                    rijndaelManaged2.Key = numArray1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
                    continue;
                  default:
                    EncryptionHelper.LtaDamGBqpebrs4FmyYJ((object) rijndaelManaged2, (object) numArray2);
                    num3 = 3;
                    continue;
                }
              }
label_13:
              try
              {
                FileStream fileStream2 = (FileStream) EncryptionHelper.DF818gGB29DRQOZPWclO((object) outputFile);
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                    try
                    {
                      CryptoStream destination = new CryptoStream((Stream) fileStream2, rijndaelManaged2.CreateDecryptor(), CryptoStreamMode.Write);
                      int num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
                        num5 = 0;
                      switch (num5)
                      {
                        default:
                          try
                          {
                            fileStream1.CopyTo((Stream) destination);
                            int num6 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
                              num6 = 0;
                            switch (num6)
                            {
                              case 0:
                                return;
                              default:
                                return;
                            }
                          }
                          finally
                          {
                            int num7;
                            if (destination == null)
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
                            else
                              goto label_27;
label_26:
                            switch (num7)
                            {
                              case 1:
                                break;
                              default:
                            }
label_27:
                            EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) destination);
                            num7 = 2;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
                            {
                              num7 = 2;
                              goto label_26;
                            }
                            else
                              goto label_26;
                          }
                      }
                    }
                    finally
                    {
                      int num8;
                      if (fileStream2 == null)
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 2;
                      else
                        goto label_33;
label_32:
                      switch (num8)
                      {
                        case 1:
                        case 2:
                      }
label_33:
                      EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) fileStream2);
                      num8 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
                      {
                        num8 = 1;
                        goto label_32;
                      }
                      else
                        goto label_32;
                    }
                }
              }
              finally
              {
                int num9;
                if (fileStream1 == null)
                  num9 = 2;
                else
                  goto label_40;
label_38:
                switch (num9)
                {
                  case 1:
                    break;
                  default:
                }
label_40:
                fileStream1.Dispose();
                num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
                {
                  num9 = 0;
                  goto label_38;
                }
                else
                  goto label_38;
              }
            }
            finally
            {
              if (rijndaelManaged2 != null)
              {
                int num10 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
                  num10 = 1;
                while (true)
                {
                  switch (num10)
                  {
                    case 1:
                      rijndaelManaged2.Dispose();
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_50;
                  }
                }
              }
label_50:;
            }
        }
      }
      finally
      {
        if (rfc2898DeriveBytes != null)
        {
          int num11 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
            num11 = 0;
          while (true)
          {
            switch (num11)
            {
              case 1:
                goto label_57;
              default:
                EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) rfc2898DeriveBytes);
                num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_57:;
      }
    }

    /// <summary>Расшифровать поток.</summary>
    /// <param name="inStream">Входной поток с зашифрованным контентом.</param>
    /// <param name="saltStr">Соль шифрования.</param>
    /// <param name="passPhrase">Пароль шифрования.</param>
    /// <returns>Поток с расшифрованным контентом.</returns>
    public static Stream DecryptStream(Stream inStream, string saltStr, string passPhrase)
    {
      int num1 = 2;
      byte[] salt;
      Rfc2898DeriveBytes rfc2898DeriveBytes;
      while (true)
      {
        switch (num1)
        {
          case 1:
            rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, salt, 10000);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
            continue;
          case 2:
            salt = (byte[]) EncryptionHelper.CfFlSVGFJoADfPwDmvH5(EncryptionHelper.b8VnC3GBQhUDRbTRNykw(), (object) saltStr);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_28;
          default:
            goto label_3;
        }
      }
label_3:
      Stream stream;
      try
      {
        RijndaelManaged rijndaelManaged1 = new RijndaelManaged();
        EncryptionHelper.GPkAHJGB8eWfpbWNYGNh((object) rijndaelManaged1, 256);
        RijndaelManaged rijndaelManaged2 = rijndaelManaged1;
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              byte[] numArray1 = (byte[]) EncryptionHelper.B09IVKGBuF3n9rksPXgX((object) rfc2898DeriveBytes, rijndaelManaged2.KeySize / 8);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
                num3 = 1;
              byte[] numArray2;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    numArray2 = (byte[]) EncryptionHelper.B09IVKGBuF3n9rksPXgX((object) rfc2898DeriveBytes, EncryptionHelper.Rs1J4hGBixUexD1sJmTb((object) rijndaelManaged2) / 8);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 1;
                    continue;
                  case 2:
                    EncryptionHelper.lpVuJJGBRE5Zq76Yr8jU((object) rijndaelManaged2, (object) numArray1);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                    continue;
                  case 3:
                    stream = (Stream) new CryptoStream(inStream, (ICryptoTransform) EncryptionHelper.AvkYBIGBnMy1SVwelBn6((object) rijndaelManaged2), CryptoStreamMode.Read);
                    num3 = 4;
                    continue;
                  case 4:
                    goto label_28;
                  default:
                    rijndaelManaged2.IV = numArray2;
                    num3 = 3;
                    continue;
                }
              }
            }
            finally
            {
              int num4;
              if (rijndaelManaged2 == null)
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
              else
                goto label_18;
label_17:
              switch (num4)
              {
                case 2:
                  break;
                default:
              }
label_18:
              rijndaelManaged2.Dispose();
              num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
              {
                num4 = 0;
                goto label_17;
              }
              else
                goto label_17;
            }
        }
      }
      finally
      {
        int num5;
        if (rfc2898DeriveBytes == null)
          num5 = 2;
        else
          goto label_24;
label_23:
        switch (num5)
        {
          case 1:
          case 2:
        }
label_24:
        EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) rfc2898DeriveBytes);
        num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
        {
          num5 = 0;
          goto label_23;
        }
        else
          goto label_23;
      }
label_28:
      return stream;
    }

    /// <summary>Загрузить ключ RSA из xml файла.</summary>
    /// <param name="keyFilePath">Путь к файлу ключа.</param>
    /// <returns>Параметры RSA ключа.</returns>
    /// <exception cref="T:System.Exception">Неверный XML файл ключа RSA.</exception>
    /// <exception cref="T:System.IO.FileNotFoundException">Файл ключа не существует.</exception>
    public static RSAParameters LoadRsaKeyFromFile(string keyFilePath)
    {
      int num1 = 2;
      XmlDocument xmlDocument;
      IEnumerator enumerator;
      RSAParameters rsaParameters;
      while (true)
      {
        switch (num1)
        {
          case 1:
            xmlDocument = new XmlDocument();
            num1 = 5;
            continue;
          case 2:
            rsaParameters = new RSAParameters();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
            continue;
          case 3:
            enumerator = (IEnumerator) EncryptionHelper.VZLssxGB3JrQXdZkII3P(EncryptionHelper.SEylk4GBNKtUnH3958bN(EncryptionHelper.OEheFCGBPZI76lNFjQ9n((object) xmlDocument)));
            num1 = 4;
            continue;
          case 4:
            goto label_3;
          case 5:
            EncryptionHelper.uwbpCPGBeOAwAHkRU3na((object) xmlDocument, (object) keyFilePath);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 3 : 6;
            continue;
          case 6:
            if (!EncryptionHelper.qlV3wuGB1tTuFyhs9EOd((object) ((XmlNode) EncryptionHelper.OEheFCGBPZI76lNFjQ9n((object) xmlDocument)).Name, EncryptionHelper.uTZljvGFYTIvSpkJqlNi(516838154 ^ 516809984)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 7;
              continue;
            }
            goto case 3;
          default:
            goto label_68;
        }
      }
label_3:
      try
      {
label_37:
        if (EncryptionHelper.c2kFWhGBtu4obyinnEph((object) enumerator))
          goto label_25;
        else
          goto label_38;
label_4:
        int num2;
        int num3 = num2;
label_5:
        uint stringHash;
        string name;
        XmlNode xmlNode;
        while (true)
        {
          switch (num3)
          {
            case 1:
              if (stringHash != 2183145318U)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 44 : 7;
                continue;
              }
              goto case 3;
            case 2:
            case 4:
            case 7:
            case 15:
            case 17:
            case 18:
            case 20:
            case 28:
            case 29:
            case 34:
            case 36:
            case 37:
            case 42:
            case 43:
            case 44:
            case 46:
            case 48:
            case 49:
            case 51:
              goto label_37;
            case 3:
              if (!EncryptionHelper.Sy0ftoGFjEwxV6t90JDU((object) name, EncryptionHelper.uTZljvGFYTIvSpkJqlNi(272623989 ^ 272392003)))
              {
                num3 = 49;
                continue;
              }
              goto case 12;
            case 5:
              if (stringHash != 3574337935U)
              {
                num3 = 6;
                continue;
              }
              goto case 24;
            case 6:
              if (stringHash == 3883103162U)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 13 : 8;
                continue;
              }
              goto label_37;
            case 8:
              if (stringHash != 3557560316U)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 42 : 31;
                continue;
              }
              goto case 50;
            case 9:
              if (stringHash <= 684613497U)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 6 : 10;
                continue;
              }
              goto case 26;
            case 10:
              if (stringHash != 667835878U)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                continue;
              }
              goto case 14;
            case 11:
              rsaParameters.InverseQ = !string.IsNullOrEmpty((string) EncryptionHelper.w3b2mwGBD76p2gTO8evX((object) xmlNode)) ? (byte[]) EncryptionHelper.h0L7MFGBWcF9MXsvX5vh((object) xmlNode.InnerText) : (byte[]) (object) null;
              num3 = 28;
              continue;
            case 12:
              rsaParameters.Exponent = !EncryptionHelper.U673h8GBayccYNpu4st6(EncryptionHelper.w3b2mwGBD76p2gTO8evX((object) xmlNode)) ? (byte[]) EncryptionHelper.h0L7MFGBWcF9MXsvX5vh(EncryptionHelper.w3b2mwGBD76p2gTO8evX((object) xmlNode)) : (byte[]) (object) null;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 48 : 23;
              continue;
            case 13:
              if (!EncryptionHelper.Sy0ftoGFjEwxV6t90JDU((object) name, EncryptionHelper.uTZljvGFYTIvSpkJqlNi(1304605005 ^ 1304495977)))
              {
                num3 = 46;
                continue;
              }
              goto case 19;
            case 14:
              if (EncryptionHelper.Sy0ftoGFjEwxV6t90JDU((object) name, EncryptionHelper.uTZljvGFYTIvSpkJqlNi(92412609 - 1050237057 ^ -957647842)))
              {
                num3 = 39;
                continue;
              }
              goto label_37;
            case 16:
              rsaParameters.P = !EncryptionHelper.U673h8GBayccYNpu4st6(EncryptionHelper.w3b2mwGBD76p2gTO8evX((object) xmlNode)) ? Convert.FromBase64String((string) EncryptionHelper.w3b2mwGBD76p2gTO8evX((object) xmlNode)) : (byte[]) null;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 4 : 29;
              continue;
            case 19:
              rsaParameters.Modulus = EncryptionHelper.U673h8GBayccYNpu4st6((object) xmlNode.InnerText) ? (byte[]) (object) null : (byte[]) EncryptionHelper.h0L7MFGBWcF9MXsvX5vh(EncryptionHelper.w3b2mwGBD76p2gTO8evX((object) xmlNode));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 3 : 4;
              continue;
            case 21:
              rsaParameters.DP = !EncryptionHelper.U673h8GBayccYNpu4st6(EncryptionHelper.w3b2mwGBD76p2gTO8evX((object) xmlNode)) ? (byte[]) EncryptionHelper.h0L7MFGBWcF9MXsvX5vh(EncryptionHelper.w3b2mwGBD76p2gTO8evX((object) xmlNode)) : (byte[]) (object) null;
              num3 = 51;
              continue;
            case 22:
              goto label_24;
            case 23:
            case 30:
              rsaParameters.D = string.IsNullOrEmpty((string) EncryptionHelper.w3b2mwGBD76p2gTO8evX((object) xmlNode)) ? (byte[]) (object) null : (byte[]) EncryptionHelper.h0L7MFGBWcF9MXsvX5vh(EncryptionHelper.w3b2mwGBD76p2gTO8evX((object) xmlNode));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 7 : 0;
              continue;
            case 24:
              if (!EncryptionHelper.Sy0ftoGFjEwxV6t90JDU((object) name, EncryptionHelper.uTZljvGFYTIvSpkJqlNi(1052221104 - 768835541 ^ 283617425)))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 24 : 34;
                continue;
              }
              goto case 16;
            case 25:
              if (stringHash <= 2183145318U)
              {
                num3 = 9;
                continue;
              }
              goto case 32;
            case 26:
              if (stringHash != 1898057334U)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
                continue;
              }
              goto case 38;
            case 27:
              if (stringHash != 3238785555U)
              {
                num3 = 8;
                continue;
              }
              goto case 33;
            case 31:
              goto label_69;
            case 32:
              if (stringHash <= 3557560316U)
              {
                num3 = 27;
                continue;
              }
              goto case 5;
            case 33:
              if (name == (string) EncryptionHelper.uTZljvGFYTIvSpkJqlNi(1033719030 - 2012070891 ^ -978448355))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 30 : 30;
                continue;
              }
              goto label_37;
            case 35:
            case 39:
              rsaParameters.DQ = string.IsNullOrEmpty((string) EncryptionHelper.w3b2mwGBD76p2gTO8evX((object) xmlNode)) ? (byte[]) (object) null : (byte[]) EncryptionHelper.h0L7MFGBWcF9MXsvX5vh((object) xmlNode.InnerText);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 20 : 1;
              continue;
            case 38:
              if (!(name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106416734)))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 15 : 5;
                continue;
              }
              goto case 11;
            case 40:
              rsaParameters.Q = !EncryptionHelper.U673h8GBayccYNpu4st6(EncryptionHelper.w3b2mwGBD76p2gTO8evX((object) xmlNode)) ? Convert.FromBase64String(xmlNode.InnerText) : (byte[]) null;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 19 : 36;
              continue;
            case 41:
              goto label_25;
            case 45:
              name = xmlNode.Name;
              num3 = 22;
              continue;
            case 47:
              if (!EncryptionHelper.Sy0ftoGFjEwxV6t90JDU((object) name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633601021)))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 2 : 0;
                continue;
              }
              goto case 21;
            case 50:
              if (!EncryptionHelper.Sy0ftoGFjEwxV6t90JDU((object) name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516810074)))
              {
                num3 = 17;
                continue;
              }
              goto case 40;
            default:
              if (stringHash != 684613497U)
              {
                num3 = 18;
                continue;
              }
              goto case 47;
          }
        }
label_24:
        // ISSUE: reference to a compiler-generated method
        stringHash = \u003CPrivateImplementationDetails\u003E.ComputeStringHash(name);
        num2 = 25;
        goto label_4;
label_25:
        xmlNode = (XmlNode) EncryptionHelper.d2akmgGBpYAPBUggHkv6((object) enumerator);
        num3 = 45;
        goto label_5;
label_38:
        num2 = 31;
        goto label_4;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
          num4 = 1;
        while (true)
        {
          switch (num4)
          {
            case 1:
              if (disposable != null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
                continue;
              }
              goto label_63;
            case 2:
              goto label_63;
            default:
              EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) disposable);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 2 : 1;
              continue;
          }
        }
label_63:;
      }
label_69:
      return rsaParameters;
label_68:
      throw new Exception(EleWise.ELMA.SR.T((string) EncryptionHelper.uTZljvGFYTIvSpkJqlNi(-2107978722 ^ -2108065180)));
    }

    /// <summary>Расшифровать сообщение.</summary>
    /// <param name="encryptedMessage">Зашифрованное сообщение в кодировке base64.</param>
    /// <param name="privateKey">Закрытый ключ RSA.</param>
    /// <returns>Расшифрованное сообщение в кодировке utf-8.</returns>
    public static string RsaDecrypt(string encryptedMessage, RSAParameters privateKey)
    {
      int num1 = 1;
      RSACryptoServiceProvider cryptoServiceProvider;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (EncryptionHelper.U673h8GBayccYNpu4st6((object) encryptedMessage))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            }
            cryptoServiceProvider = new RSACryptoServiceProvider();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 2 : 0;
            continue;
          case 2:
            goto label_7;
          case 3:
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      string str;
      return str;
label_5:
      return (string) null;
label_7:
      try
      {
        cryptoServiceProvider.ImportParameters(privateKey);
        int num2 = 3;
        byte[] rgb;
        byte[] numArray;
        while (true)
        {
          switch (num2)
          {
            case 1:
              numArray = cryptoServiceProvider.Decrypt(rgb, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            case 3:
              rgb = (byte[]) EncryptionHelper.h0L7MFGBWcF9MXsvX5vh((object) encryptedMessage);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 1;
              continue;
            default:
              str = (string) EncryptionHelper.rt0PQtGFrpsAhBM8PLlD((object) Encoding.UTF8, (object) numArray);
              num2 = 2;
              continue;
          }
        }
      }
      finally
      {
        int num3;
        if (cryptoServiceProvider == null)
          num3 = 2;
        else
          goto label_15;
label_14:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_15:
        EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) cryptoServiceProvider);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        {
          num3 = 0;
          goto label_14;
        }
        else
          goto label_14;
      }
    }

    /// <summary>Зашифровать сообщение.</summary>
    /// <param name="message">Сообщение в кодировке utf-8.</param>
    /// <param name="publicKey">Публичный ключ RSA.</param>
    /// <returns>Зашифрованное сообщение в кодировке base64.</returns>
    public static string RsaEncrypt(string message, RSAParameters publicKey)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!string.IsNullOrEmpty(message))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return (string) null;
label_3:
      return (string) EncryptionHelper.Ult5HeGBwsULAAISYqiA((object) ((Encoding) EncryptionHelper.bb5ienGFyXcmrOmWwlZx()).GetBytes(message), publicKey);
    }

    /// <summary>Зашифровать сообщение.</summary>
    /// <param name="messageBytes">Сообщение в виде массива байт.</param>
    /// <param name="publicKey">Публичный ключ RSA.</param>
    /// <returns>Зашифрованное сообщение в кодировке base64.</returns>
    public static string RsaEncrypt(byte[] messageBytes, RSAParameters publicKey)
    {
      int num1 = 3;
      RSACryptoServiceProvider cryptoServiceProvider;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_3;
            case 3:
              if (messageBytes != null)
              {
                cryptoServiceProvider = new RSACryptoServiceProvider();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
                continue;
              }
              goto label_6;
            default:
              goto label_7;
          }
        }
label_6:
        num1 = 2;
      }
label_3:
      return (string) null;
label_7:
      string str;
      return str;
label_8:
      try
      {
        EncryptionHelper.dMB72dGB4UuBhWnDftDq((object) cryptoServiceProvider, publicKey);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_7;
            default:
              str = (string) EncryptionHelper.C4nUiiGFmXLqgTkiFtAr(EncryptionHelper.kbcqB3GB63BNTdferCcl((object) cryptoServiceProvider, (object) messageBytes, false));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 1;
              continue;
          }
        }
      }
      finally
      {
        int num4;
        if (cryptoServiceProvider == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
        else
          goto label_15;
label_14:
        switch (num4)
        {
          case 2:
            break;
          default:
        }
label_15:
        EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) cryptoServiceProvider);
        num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
        {
          num4 = 0;
          goto label_14;
        }
        else
          goto label_14;
      }
    }

    /// <summary>Создать подпись для текстового сообщения.</summary>
    /// <param name="message">Текст сообщения.</param>
    /// <param name="serverPrivateKey">Закрытый ключ сервера.</param>
    /// <returns>Подпись в кодировке base64.</returns>
    public static string RsaSign(string message, RSAParameters serverPrivateKey)
    {
      int num1 = 4;
      RSACryptoServiceProvider cryptoServiceProvider;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_14;
          case 2:
            goto label_4;
          case 3:
            cryptoServiceProvider = new RSACryptoServiceProvider();
            num1 = 2;
            continue;
          case 4:
            if (!EncryptionHelper.U673h8GBayccYNpu4st6((object) message))
            {
              num1 = 3;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) null;
label_4:
      string str;
      try
      {
        EncryptionHelper.dMB72dGB4UuBhWnDftDq((object) cryptoServiceProvider, serverPrivateKey);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              str = MemoryHelper.ActionWithMemoryBuffer<byte, (RSACryptoServiceProvider, string), string>(EncryptionHelper.HWbS2lGFMdpPTPyAbpgf(EncryptionHelper.bb5ienGFyXcmrOmWwlZx(), (object) message), (cryptoServiceProvider, message), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (RSACryptoServiceProvider, string), string>(EncryptionHelper.RsaSignAction));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
            default:
              goto label_14;
          }
        }
      }
      finally
      {
        if (cryptoServiceProvider != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_13;
              default:
                EncryptionHelper.Pe0o4hGFl5F4MOqr0X4h((object) cryptoServiceProvider);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_13:;
      }
label_14:
      return str;
    }

    private static string RsaSignAction(
      object buffer,
      int offset,
      int length,
      (RSACryptoServiceProvider, string) param)
    {
      (RSACryptoServiceProvider cryptoServiceProvider, string s) = param;
      Encoding.UTF8.GetBytes(s, 0, s.Length, (byte[]) buffer, offset);
      return Convert.ToBase64String(cryptoServiceProvider.SignData((byte[]) buffer, offset, length, (object) new SHA256CryptoServiceProvider()));
    }

    private static string BytesToHexString(object bytes) => (string) EncryptionHelper.aRVd9WGBAQktB6D7oxMM((object) ((string) EncryptionHelper.sCQrNyGBH4yy5jkswjAG(bytes)).Replace((string) EncryptionHelper.uTZljvGFYTIvSpkJqlNi(-1872275253 >> 6 ^ -29256945), ""));

    static EncryptionHelper()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            EncryptionHelper.Sha256ManagedPool = Microsoft.Extensions.ObjectPool.ObjectPool.Create<SHA256Managed>();
            num = 2;
            continue;
          case 2:
            EncryptionHelper.Md5CryptoServiceProviderPool = Microsoft.Extensions.ObjectPool.ObjectPool.Create<MD5CryptoServiceProvider>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          case 3:
            EncryptionHelper.RngCryptoServiceProviderPool = Microsoft.Extensions.ObjectPool.ObjectPool.Create<RNGCryptoServiceProvider>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 1;
            continue;
          case 4:
            EncryptionHelper.LIYiKoGFxWWPq6Lqf2fQ();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 3 : 2;
            continue;
          case 5:
            byte[] numArray1 = new byte[16];
            // ISSUE: field reference
            EncryptionHelper.iynDXOGB72hynar6O7ee((object) numArray1, __fieldref (\u003CPrivateImplementationDetails\u003E.\u00357514714EBF5072C179DF17C7016AF16F2D16520));
            EncryptionHelper.Iv = numArray1;
            num = 6;
            continue;
          case 6:
            goto label_2;
          default:
            byte[] numArray2 = new byte[16];
            // ISSUE: field reference
            EncryptionHelper.iynDXOGB72hynar6O7ee((object) numArray2, __fieldref (\u003CPrivateImplementationDetails\u003E.\u003694FA395BBB60E36DFBEF2137683E684F595E83C));
            EncryptionHelper.PubKey = numArray2;
            num = 5;
            continue;
        }
      }
label_2:;
    }

    internal static bool JZP7LxGFArCqfTiWLLQT() => EncryptionHelper.SMBnkvGFH7750VrdSTL5 == null;

    internal static EncryptionHelper zp0LMwGF7hLe3Qmjp76r() => EncryptionHelper.SMBnkvGFH7750VrdSTL5;

    internal static void LIYiKoGFxWWPq6Lqf2fQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void paWtVvGF0TnCOmBv8LGD([In] object obj0, [In] object obj1) => ((RandomNumberGenerator) obj0).GetBytes((byte[]) obj1);

    internal static object C4nUiiGFmXLqgTkiFtAr([In] object obj0) => (object) Convert.ToBase64String((byte[]) obj0);

    internal static object bb5ienGFyXcmrOmWwlZx() => (object) Encoding.UTF8;

    internal static int HWbS2lGFMdpPTPyAbpgf([In] object obj0, [In] object obj1) => ((Encoding) obj0).GetByteCount((string) obj1);

    internal static object CfFlSVGFJoADfPwDmvH5([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetBytes((string) obj1);

    internal static object u9iJHoGF996oMX45bnul([In] object obj0) => (object) EncryptionHelper.BytesToHexString(obj0);

    internal static object aE0u9TGFdKjNMNyKyEyA([In] object obj0, bool writable) => (object) MemoryHelper.GetMemoryStream((byte[]) obj0, writable);

    internal static void Pe0o4hGFl5F4MOqr0X4h([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object rt0PQtGFrpsAhBM8PLlD([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetString((byte[]) obj1);

    internal static object ErL1UMGFgQ2IifOkjB1G([In] object obj0) => (object) EncryptionHelper.GetMd5Hash((string) obj0);

    internal static object VZYZdiGF5Gj4gw7plbwE([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static bool Sy0ftoGFjEwxV6t90JDU([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object uTZljvGFYTIvSpkJqlNi(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object R8t5iVGFLKCGFrIbnOTv([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object jFEZ2rGFUewcdbvT9Dpp([In] object obj0, [In] object obj1) => (object) EncryptionHelper.EncryptPwd((string) obj0, (byte[]) obj1);

    internal static object Wjmcs6GFsb6VawSBxrU1() => (object) MemoryHelper.GetMemoryStream();

    internal static object X5TXutGFcbZC4nAnr0qJ([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SymmetricAlgorithm) obj0).CreateEncryptor((byte[]) obj1, (byte[]) obj2);

    internal static long au3PPIGFz87gDT7sgbGP([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static object WOm14QGBFr3CyF63fGn3([In] object obj0, [In] int obj1, [In] int obj2) => (object) Convert.ToBase64String((byte[]) obj0, obj1, obj2);

    internal static object gU6OBkGBB94ccnMGBryq([In] object obj0, [In] object obj1) => (object) EncryptionHelper.DecryptPwd((string) obj0, (byte[]) obj1);

    internal static object h0L7MFGBWcF9MXsvX5vh([In] object obj0) => (object) Convert.FromBase64String((string) obj0);

    internal static object ubABtaGBoRTHZRcqwoBw([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SymmetricAlgorithm) obj0).CreateDecryptor((byte[]) obj1, (byte[]) obj2);

    internal static object l6aKfPGBbcy28GoM2IuB([In] object obj0) => (object) ((TextReader) obj0).ReadLine();

    internal static int eyd55BGBhL5upVNyicGL([In] object obj0) => ((string) obj0).Length;

    internal static object nRPHqdGBG7AttuFIoO1t([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object mq4ZAsGBEAbvTc92aOw8([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static object zoXtALGBfPY14yVgveBM([In] object obj0, [In] object obj1, [In] object obj2) => (object) EncryptionHelper.Encrypt((string) obj0, (string) obj1, (string) obj2);

    internal static object b8VnC3GBQhUDRbTRNykw() => (object) Encoding.ASCII;

    internal static object GRxyWCGBCClKsdgN0PSB([In] object obj0, [In] object obj1) => (object) EncryptionHelper.EncryptInnerLogic(obj0, obj1);

    internal static object r61mqmGBvPwMserDDdYA() => (object) Encoding.Unicode;

    internal static void GPkAHJGB8eWfpbWNYGNh([In] object obj0, [In] int obj1) => ((SymmetricAlgorithm) obj0).BlockSize = obj1;

    internal static int ItUKJcGBZZYj063xTm5n([In] object obj0) => ((SymmetricAlgorithm) obj0).KeySize;

    internal static object B09IVKGBuF3n9rksPXgX([In] object obj0, [In] int obj1) => (object) ((DeriveBytes) obj0).GetBytes(obj1);

    internal static object LdL3yRGBI3H3r0iqS0ty([In] object obj0) => (object) ((SymmetricAlgorithm) obj0).CreateEncryptor();

    internal static void SwI0RtGBV9V7B4iBEY4n([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Write((byte[]) obj1, obj2, obj3);

    internal static long rI9ayTGBSgMZemxQqrRw([In] object obj0) => ((Stream) obj0).Length;

    internal static int Rs1J4hGBixUexD1sJmTb([In] object obj0) => ((SymmetricAlgorithm) obj0).BlockSize;

    internal static void lpVuJJGBRE5Zq76Yr8jU([In] object obj0, [In] object obj1) => ((SymmetricAlgorithm) obj0).Key = (byte[]) obj1;

    internal static void LtaDamGBqpebrs4FmyYJ([In] object obj0, [In] object obj1) => ((SymmetricAlgorithm) obj0).IV = (byte[]) obj1;

    internal static void FTnpW4GBKX777V9QA9hA([In] object obj0, [In] object obj1) => ((Stream) obj0).CopyTo((Stream) obj1);

    internal static void PfZPklGBX52mroZwtuFR([In] object obj0) => ((CryptoStream) obj0).FlushFinalBlock();

    internal static object yNyTkUGBTAr1p7I0wavv([In] object obj0, [In] object obj1, [In] object obj2) => (object) EncryptionHelper.Decrypt((string) obj0, (string) obj1, (string) obj2);

    internal static object SZjKdeGBkykVTvOkvmF1([In] object obj0, [In] object obj1) => (object) EncryptionHelper.DecryptInnerLogic(obj0, obj1);

    internal static object AvkYBIGBnMy1SVwelBn6([In] object obj0) => (object) ((SymmetricAlgorithm) obj0).CreateDecryptor();

    internal static object QGjo1pGBO4wKBF6Hw9sA([In] object obj0, [In] object obj1) => (object) ((MemoryStream) obj0).AsString((Encoding) obj1);

    internal static object DF818gGB29DRQOZPWclO([In] object obj0) => (object) File.OpenWrite((string) obj0);

    internal static void uwbpCPGBeOAwAHkRU3na([In] object obj0, [In] object obj1) => ((XmlDocument) obj0).Load((string) obj1);

    internal static object OEheFCGBPZI76lNFjQ9n([In] object obj0) => (object) ((XmlDocument) obj0).DocumentElement;

    internal static bool qlV3wuGB1tTuFyhs9EOd([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);

    internal static object SEylk4GBNKtUnH3958bN([In] object obj0) => (object) ((XmlNode) obj0).ChildNodes;

    internal static object VZLssxGB3JrQXdZkII3P([In] object obj0) => (object) ((XmlNodeList) obj0).GetEnumerator();

    internal static object d2akmgGBpYAPBUggHkv6([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static bool U673h8GBayccYNpu4st6([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object w3b2mwGBD76p2gTO8evX([In] object obj0) => (object) ((XmlNode) obj0).InnerText;

    internal static bool c2kFWhGBtu4obyinnEph([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object Ult5HeGBwsULAAISYqiA([In] object obj0, RSAParameters publicKey) => (object) EncryptionHelper.RsaEncrypt((byte[]) obj0, publicKey);

    internal static void dMB72dGB4UuBhWnDftDq([In] object obj0, [In] RSAParameters obj1) => ((RSA) obj0).ImportParameters(obj1);

    internal static object kbcqB3GB63BNTdferCcl([In] object obj0, [In] object obj1, [In] bool obj2) => (object) ((RSACryptoServiceProvider) obj0).Encrypt((byte[]) obj1, obj2);

    internal static object sCQrNyGBH4yy5jkswjAG([In] object obj0) => (object) BitConverter.ToString((byte[]) obj0);

    internal static object aRVd9WGBAQktB6D7oxMM([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static void iynDXOGB72hynar6O7ee([In] object obj0, [In] RuntimeFieldHandle obj1) => RuntimeHelpers.InitializeArray((Array) obj0, obj1);

    /// <summary>Результат проверки md5</summary>
    public struct VerifyMd5Result
    {
      internal static object UbXkhuv9eIac7eRRHydW;

      public bool Verified
      {
        get => this.\u003CVerified\u003Ek__BackingField;
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
                this.\u003CVerified\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
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

      public string Error
      {
        get => this.\u003CError\u003Ek__BackingField;
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
                this.\u003CError\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
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

      internal static bool lLbwFrv9P3dXvmhtuKH2() => EncryptionHelper.VerifyMd5Result.UbXkhuv9eIac7eRRHydW == null;

      internal static object pSH5Eav91wQqWig1La71() => EncryptionHelper.VerifyMd5Result.UbXkhuv9eIac7eRRHydW;
    }
  }
}
