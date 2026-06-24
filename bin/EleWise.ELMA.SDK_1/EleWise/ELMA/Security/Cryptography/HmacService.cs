// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Cryptography.HmacService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace EleWise.ELMA.Security.Cryptography
{
  /// <summary>Реализация сервиса для подписи HMAC</summary>
  [Service]
  public class HmacService : IHmacService
  {
    private static HmacService CRRgbxBLK4Ujc9UJRNvZ;

    /// <summary>Нормализация запроса для подписания</summary>
    /// <param name="verb">Метод (GET, POST ...)</param>
    /// <param name="headers">Словарь заголовков</param>
    /// <param name="contentType">Content-Type</param>
    /// <param name="resourceUri">Адрес ресурса</param>
    /// <param name="queryUri">Параметры запроса</param>
    /// <param name="requestBody">Тело запроса (для вычисления хеша)</param>
    /// <returns>Нормализованное сообщение для подписания/проверки подписи</returns>
    public string GetNormalizedMessage(
      string verb,
      string resourceUri,
      string queryUri,
      Dictionary<string, string> headers,
      string contentType,
      byte[] requestBody)
    {
      StringBuilder stringBuilder = new StringBuilder();
      string str1 = verb != null ? verb.Trim().ToUpper() : string.Empty;
      string str2 = resourceUri != null ? resourceUri : string.Empty;
      string str3 = queryUri != null ? queryUri : string.Empty;
      string normalizedHeaders = this.GetNormalizedHeaders(headers);
      string contentHash = this.GetContentHash(requestBody);
      string str4 = !string.IsNullOrEmpty(contentType) ? contentType.Trim().ToLower() : string.Empty;
      stringBuilder.Append(str1).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672126305)).Append(str2).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501465645)).Append(str3).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333734838)).Append(normalizedHeaders).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123637286)).Append(contentHash).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360338361)).Append(str4).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837669921));
      return stringBuilder.ToString();
    }

    /// <summary>Подписание сообщения HMAC</summary>
    /// <param name="message">Сообщение</param>
    /// <param name="secret">Секрет</param>
    /// <returns>Подпись</returns>
    public string Sign(string message, byte[] secret) => MemoryHelper.ActionWithMemoryBuffer<byte, (string, byte[]), string>(((Encoding) HmacService.mhOwGFBLkfmTyraKA1R3()).GetByteCount(message), (message, secret), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (string, byte[]), string>(this.SignAction));

    private string SignAction(byte[] buffer, int offset, int length, (string, byte[]) param)
    {
      (string s, byte[] key) = param;
      Encoding.UTF8.GetBytes(s, 0, s.Length, buffer, offset);
      using (HMACSHA256 hmacshA256 = new HMACSHA256(key))
        return Convert.ToBase64String(hmacshA256.ComputeHash(buffer, offset, length));
    }

    /// <summary>Подписание сообщения HMAC</summary>
    /// <param name="message">Сообщение</param>
    /// <param name="secret">Секрет</param>
    /// <returns>Подпись</returns>
    public byte[] Sign(byte[] message, byte[] secret)
    {
      int num1 = 1;
      HMACSHA256 hmacshA256;
      while (true)
      {
        switch (num1)
        {
          case 1:
            hmacshA256 = new HMACSHA256(secret);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      byte[] numArray;
      return numArray;
label_4:
      try
      {
        numArray = (byte[]) HmacService.W4HEc6BLnQOVZ5ghei8i((object) hmacshA256, (object) message);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
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
        if (hmacshA256 == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
        else
          goto label_11;
label_10:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_11:
        hmacshA256.Dispose();
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        {
          num3 = 0;
          goto label_10;
        }
        else
          goto label_10;
      }
    }

    /// <summary>Проверка подписи</summary>
    /// <param name="message">Сообщение</param>
    /// <param name="secret">Секрет</param>
    /// <param name="base64Signature">Подпись на проверку</param>
    /// <returns>Результат проверки валидности подписи</returns>
    public bool CheckSignature(string message, byte[] secret, string base64Signature)
    {
      int num = 2;
      byte[] numArray1;
      byte[] numArray2;
      while (true)
      {
        switch (num)
        {
          case 1:
            numArray1 = this.Sign((byte[]) HmacService.NVqxZmBLOeDILKftXCTe(HmacService.mhOwGFBLkfmTyraKA1R3(), (object) message), secret);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
            continue;
          case 2:
            numArray2 = Convert.FromBase64String(base64Signature);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return HmacService.OUOgDcBL25o2Lr4dLXLB((object) StructuralComparisons.StructuralEqualityComparer, (object) numArray2, (object) numArray1);
    }

    private string GetNormalizedHeaders(Dictionary<string, string> headers)
    {
      IOrderedEnumerable<KeyValuePair<string, string>> orderedEnumerable = headers.Select<KeyValuePair<string, string>, KeyValuePair<string, string>>((Func<KeyValuePair<string, string>, KeyValuePair<string, string>>) (h => new KeyValuePair<string, string>(h.Key.ToLower(), h.Value.Trim().Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867198415), "").Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418239644), "")))).OrderBy<KeyValuePair<string, string>, string>((Func<KeyValuePair<string, string>, string>) (e => e.Key));
      StringBuilder stringBuilder = new StringBuilder();
      foreach (KeyValuePair<string, string> keyValuePair in (IEnumerable<KeyValuePair<string, string>>) orderedEnumerable)
      {
        if (stringBuilder.Length > 0)
          stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654300413));
        stringBuilder.AppendFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309722794), (object) keyValuePair.Key, (object) keyValuePair.Value);
      }
      return stringBuilder.ToString();
    }

    private string GetContentHash(byte[] body)
    {
      int num1 = 3;
      SHA256 shA256;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            shA256 = SHA256.Create();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          case 3:
            if (body != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 2 : 1;
              continue;
            }
            goto label_2;
          case 4:
            goto label_4;
          default:
            goto label_7;
        }
      }
label_2:
      return string.Empty;
label_4:
      string contentHash;
      return contentHash;
label_7:
      try
      {
        contentHash = (string) HmacService.uE09gHBLPwUIsRvgedsL(HmacService.VqASKxBL1lXUpNWgx26N(HmacService.uE09gHBLPwUIsRvgedsL(HmacService.aIktNYBLenOpmOo7JETU(HmacService.W4HEc6BLnQOVZ5ghei8i((object) shA256, (object) body))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088305740), (object) ""));
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_4;
        }
      }
      finally
      {
        int num3;
        if (shA256 == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
        else
          goto label_14;
label_13:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_14:
        HmacService.uHEwIoBLNhYF1yQ1d5n0((object) shA256);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
        {
          num3 = 2;
          goto label_13;
        }
        else
          goto label_13;
      }
    }

    public HmacService()
    {
      HmacService.HqrkVrBL30CbKROS8TeB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object mhOwGFBLkfmTyraKA1R3() => (object) Encoding.UTF8;

    internal static bool B8DdVEBLX4NW8q8nNoOd() => HmacService.CRRgbxBLK4Ujc9UJRNvZ == null;

    internal static HmacService PEr1HmBLT1x9fo8gKdge() => HmacService.CRRgbxBLK4Ujc9UJRNvZ;

    internal static object W4HEc6BLnQOVZ5ghei8i([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((byte[]) obj1);

    internal static object NVqxZmBLOeDILKftXCTe([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetBytes((string) obj1);

    internal static bool OUOgDcBL25o2Lr4dLXLB([In] object obj0, [In] object obj1, [In] object obj2) => ((IEqualityComparer) obj0).Equals(obj1, obj2);

    internal static object aIktNYBLenOpmOo7JETU([In] object obj0) => (object) BitConverter.ToString((byte[]) obj0);

    internal static object uE09gHBLPwUIsRvgedsL([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object VqASKxBL1lXUpNWgx26N([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static void uHEwIoBLNhYF1yQ1d5n0([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void HqrkVrBL30CbKROS8TeB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
