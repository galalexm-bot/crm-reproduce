// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.StringExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace EleWise.ELMA.Extensions
{
  /// <summary>
  /// Класс рашриений для типа <see cref="T:System.String" />
  /// </summary>
  public static class StringExtensions
  {
    /// <summary>Возможные разделители строки</summary>
    private static readonly string[] LineSeparators;
    private static readonly Dictionary<string, string> translitChars;
    private static StringExtensions nIdOo9G7Tiv0eZyQJCSV;

    /// <summary>
    /// Заменяет в строке символы перевода строки на "&lt;br /&gt;"
    /// </summary>
    /// <param name="s">Строка</param>
    /// <returns>Строка с измененными символами</returns>
    public static string Nl2Br(this string s)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (s != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return ((string) StringExtensions.OgMe8bG72xJXKcp2X0Rb((object) s.Replace((string) StringExtensions.VJH5sNG7OhRtAcr1FyMa(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539106585)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576145060), (object) "")).Replace((string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-345420348 ^ -345419168), (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(874012245 ^ 874273027));
label_3:
      return (string) null;
    }

    /// <summary>
    /// Заменяет в строке тэг "&lt;br /&gt;" на символ перевода строки
    /// </summary>
    /// <param name="s">Строка</param>
    /// <returns>Строка с измененными символами</returns>
    public static string Br2Nl(this string s)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (s != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) StringExtensions.W5vSGDG7PhO3QaPdlqcG((object) s, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1766114740), StringExtensions.VJH5sNG7OhRtAcr1FyMa(), RegexOptions.IgnoreCase);
label_3:
      return (string) null;
    }

    /// <summary>Преобразует строку в строку формата HTML</summary>
    /// <param name="s">Строка</param>
    /// <returns></returns>
    public static string HtmlEncode(this string s)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (string.IsNullOrEmpty(s))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return string.Empty;
label_5:
      return HttpUtility.HtmlEncode(s);
    }

    /// <summary>Снимает экранирование со строки</summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static string HtmlDecode(this string s)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (StringExtensions.WvgFDkG71kseC6o8colV((object) s))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) StringExtensions.OuKAxfG7Nn1gDqLVlXy4((object) s);
label_5:
      return string.Empty;
    }

    /// <summary>Проверяет строку на пустое значение</summary>
    /// <param name="s">Строка</param>
    /// <returns>Является ли строка пустой</returns>
    public static bool IsNullOrEmpty(this string s) => StringExtensions.WvgFDkG71kseC6o8colV((object) s);

    /// <summary>
    /// Указывает, является ли указанная строка значением null, пустой строкой или строкой, состоящей только из пробельных символов.
    /// </summary>
    /// <param name="s">Строка</param>
    /// <returns>Является ли строка пустой</returns>
    public static bool IsNullOrWhiteSpace(this string s) => StringExtensions.ULHSZCG73UUNdqQK5KPy((object) s);

    /// <summary>Перевод в транслитовый идентификатор</summary>
    /// <param name="s">Исходная строка</param>
    /// <param name="prefix">Префикс</param>
    /// <param name="maxLength">Максимальная длина идентификатора</param>
    /// <returns></returns>
    public static string ToTranslitIdent(this string s, string prefix = null, int maxLength = 0)
    {
      int num1 = 28;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        string str1;
        while (true)
        {
          int index;
          char[] chArray;
          bool flag1;
          bool flag2;
          bool flag3;
          char ch1;
          string lower;
          string str2;
          char ch2;
          object obj;
          int num3;
          int num4;
          switch (num2)
          {
            case 1:
            case 26:
              if (flag3)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 7 : 2;
                continue;
              }
              goto case 46;
            case 2:
            case 11:
              ch1 = chArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 4 : 1;
              continue;
            case 3:
              flag1 = false;
              num2 = 10;
              continue;
            case 4:
              lower = ch1.ToString().ToLower();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 41 : 31;
              continue;
            case 5:
            case 22:
              if (StringExtensions.translitChars.TryGetValue(lower, out str2))
                goto case 45;
              else
                goto label_23;
            case 6:
              obj = (object) "";
              goto label_61;
            case 7:
              if (str1.Length > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 17 : 35;
                continue;
              }
              goto case 46;
            case 8:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 3 : 33;
              continue;
            case 9:
              if (ch1 < 'A')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 37 : 35;
                continue;
              }
              goto case 30;
            case 10:
              flag3 = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 31 : 14;
              continue;
            case 12:
            case 13:
              flag3 = true;
              num2 = 8;
              continue;
            case 14:
              num4 = ch1 <= '9' ? 1 : 0;
              break;
            case 15:
            case 33:
              if (index < chArray.Length)
              {
                num2 = 2;
                continue;
              }
              goto label_49;
            case 16:
              obj = StringExtensions.AVOdFaG7eNJHjjZ89SgL(-87337865 ^ -87336947);
              goto label_61;
            case 17:
              flag3 = lower.ToUpper().Equals(ch1.ToString());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 18 : 15;
              continue;
            case 18:
            case 19:
            case 39:
            case 47:
              if (str1 != null)
              {
                num2 = 42;
                continue;
              }
              goto case 31;
            case 20:
label_5:
              if (flag1 & flag2)
              {
                num2 = 16;
                continue;
              }
              goto case 6;
            case 21:
              if (ch1 > 'z')
              {
                num2 = 9;
                continue;
              }
              goto label_57;
            case 23:
            case 37:
              num3 = ch1 == '_' ? 1 : 0;
              goto label_58;
            case 24:
              if (ch1 >= '0')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 14 : 8;
                continue;
              }
              num4 = 0;
              break;
            case 25:
              str1 = (string) StringExtensions.Kgk8MlG7aPufrVOxNuUV((object) ch2.ToString().ToUpper(), StringExtensions.NUjnTgG7DfQIryEBbioj((object) str1) > 1 ? StringExtensions.Kw41c0G7w9N2gu3k4JRk((object) str1, 1) : (object) string.Empty);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 4 : 46;
              continue;
            case 27:
              chArray = (char[]) StringExtensions.cxvBCQG7pNejTZcNhC21((object) s);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 5 : 40;
              continue;
            case 28:
              stringBuilder = new StringBuilder();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 27 : 10;
              continue;
            case 29:
              stringBuilder.Append(prefix);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            case 30:
              if (ch1 > 'Z')
              {
                num2 = 23;
                continue;
              }
              goto label_57;
            case 31:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 12 : 15;
              continue;
            case 32:
              goto label_49;
            case 34:
              goto label_45;
            case 35:
              ch2 = StringExtensions.HfVCJLG7tivFO2BJ4HrC((object) str1, 0);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 25 : 4;
              continue;
            case 36:
            case 44:
              flag3 = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 47;
              continue;
            case 38:
              if (flag3)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 33 : 39;
                continue;
              }
              goto case 17;
            case 40:
              flag1 = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 3 : 43;
              continue;
            case 41:
              str1 = (string) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 24 : 5;
              continue;
            case 42:
              if (maxLength <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
                continue;
              }
              goto label_45;
            case 43:
              if (string.IsNullOrEmpty(prefix))
              {
                num2 = 13;
                continue;
              }
              goto case 29;
            case 45:
              str1 = str2;
              num2 = 38;
              continue;
            case 46:
              StringExtensions.uUmXYAG74Yqd2K1UUw7X((object) stringBuilder, (object) str1);
              num2 = 3;
              continue;
            case 48:
              if (ch1 >= 'a')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 2 : 21;
                continue;
              }
              goto case 9;
            default:
              flag1 = false;
              num2 = 12;
              continue;
          }
          flag2 = num4 != 0;
          num2 = 48;
          continue;
label_57:
          num3 = 1;
label_58:
          int num5 = flag2 ? 1 : 0;
          if ((num3 | num5) == 0)
          {
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 4 : 22;
            continue;
          }
          goto label_5;
label_61:
          string str3 = ch1.ToString();
          str1 = (string) StringExtensions.Kgk8MlG7aPufrVOxNuUV(obj, (object) str3);
          num2 = 19;
        }
label_23:
        num1 = 44;
        continue;
label_45:
        if (stringBuilder.Length + StringExtensions.NUjnTgG7DfQIryEBbioj((object) str1) <= maxLength)
          num1 = 26;
        else
          break;
      }
label_49:
      return stringBuilder.ToString();
    }

    /// <summary>Перевести первый символ строки в нижний регистр</summary>
    /// <returns></returns>
    public static string ToLowerFirstChar(this string s)
    {
      int num = 2;
      char ch;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (!s.IsNullOrEmpty())
            {
              ch = StringExtensions.nqBa36G76svkE31SOuwl(StringExtensions.HfVCJLG7tivFO2BJ4HrC((object) s, 0));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 1;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return string.Empty;
label_6:
      return (string) StringExtensions.Kgk8MlG7aPufrVOxNuUV((object) ch.ToString(), StringExtensions.Kw41c0G7w9N2gu3k4JRk((object) s, 1));
    }

    /// <summary>Перевести первый символ строки в верхний регистр</summary>
    /// <param name="s">Входная строка</param>
    /// <returns>Строка с первым символов в верхнем регистре</returns>
    public static string ToUpperFirstChar(this string s)
    {
      int num = 1;
      char ch;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!s.IsNullOrEmpty())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            goto label_2;
          case 3:
            goto label_3;
          default:
            ch = StringExtensions.gCqGI8G7HP9x8ZnJaC1e(s[0]);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 2;
            continue;
        }
      }
label_2:
      return (string) StringExtensions.Kgk8MlG7aPufrVOxNuUV((object) ch.ToString(), StringExtensions.Kw41c0G7w9N2gu3k4JRk((object) s, 1));
label_3:
      return string.Empty;
    }

    /// <summary>
    /// Перевод в транслитовый идентификатор без изменения регистра
    /// </summary>
    /// <param name="s">Исходная строка</param>
    /// <returns></returns>
    public static string ToTranslit(this string s)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          Dictionary<string, string>.Enumerator enumerator;
          int num3;
          switch (num2)
          {
            case 1:
              goto label_21;
            case 2:
label_16:
              if (StringExtensions.HfVCJLG7tivFO2BJ4HrC((object) s, 0) < '0')
              {
                num3 = 0;
                break;
              }
              goto label_17;
            case 3:
              num3 = StringExtensions.HfVCJLG7tivFO2BJ4HrC((object) s, 0) <= '9' ? 1 : 0;
              break;
            case 4:
              goto label_19;
            case 5:
              if (StringExtensions.ikVDenG7AsccogMHcvpQ((object) s))
              {
                num2 = 4;
                continue;
              }
              enumerator = StringExtensions.translitChars.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 6 : 4;
              continue;
            case 6:
              try
              {
label_6:
                if (enumerator.MoveNext())
                  goto label_5;
                else
                  goto label_7;
label_4:
                KeyValuePair<string, string> current;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_5;
                    case 2:
                      s = s.Replace(current.Key, current.Value);
                      num4 = 3;
                      continue;
                    case 3:
                      goto label_6;
                    default:
                      goto label_16;
                  }
                }
label_5:
                current = enumerator.Current;
                num4 = 2;
                goto label_4;
label_7:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                goto label_4;
              }
              finally
              {
                enumerator.Dispose();
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                }
              }
            default:
              s = (string) StringExtensions.S0wpsBG77n26cHipl4iy((object) s, 0, StringExtensions.AVOdFaG7eNJHjjZ89SgL(222162814 ^ 222159620));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
              continue;
          }
          if (num3 != 0)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
          else
            goto label_21;
        }
label_17:
        num1 = 3;
      }
label_19:
      return s;
label_21:
      return (string) StringExtensions.OgMe8bG72xJXKcp2X0Rb((object) s, StringExtensions.AVOdFaG7eNJHjjZ89SgL(~541731958 ^ -541746517), (object) "");
    }

    /// <summary>Является ли строка корректным идентификатором</summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static bool IsValidIdentifier(this string s) => StringExtensions.GqrS8mG7xwLD7A58oV56((object) s, StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1822890472 ^ -1822629478));

    public static string ToHexString(this byte[] bytes) => (string) StringExtensions.OgMe8bG72xJXKcp2X0Rb(StringExtensions.xwnAlkG70DeUBaeTlMvJ((object) bytes), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099750597), (object) "");

    /// <summary>Hex строку в массив байт</summary>
    /// <param name="inputHex">Входная строка</param>
    /// <returns>Байты</returns>
    public static byte[] HexStringToByteArray(this string inputHex)
    {
      int num = 2;
      int index;
      byte[] byteArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 6 : 2;
            continue;
          case 2:
            byteArray = new byte[StringExtensions.NUjnTgG7DfQIryEBbioj((object) inputHex) / 2];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
            continue;
          case 3:
            ++index;
            num = 5;
            continue;
          case 4:
            byteArray[index] = StringExtensions.vkNvtUG7yFMZw6QcH87W(StringExtensions.z9YxotG7mFkVExOMcRtH((object) inputHex, index * 2, 2), 16);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 3;
            continue;
          case 5:
          case 6:
            if (index >= byteArray.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          default:
            goto label_6;
        }
      }
label_6:
      return byteArray;
    }

    /// <summary>
    /// Получить значение строки, или значение по умолчанию, если строка пустая
    /// </summary>
    /// <param name="value">Строка</param>
    /// <param name="defaultValue">Значение по умолчанию</param>
    /// <param name="format">Формат для преобразования значения текущей строки в результате</param>
    /// <returns>Значение строки</returns>
    public static string ValueOrDefault(this string value, string defaultValue, string format = "{0}")
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!value.IsNullOrEmpty())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return format.FormatWith((object) value);
label_5:
      return defaultValue;
    }

    /// <summary>
    /// Получить значение строки, или значение по умолчанию, если строка пустая
    /// </summary>
    /// <param name="value">Строка</param>
    /// <param name="defaultValue">Значение по умолчанию</param>
    /// <param name="format">Формат для преобразования значения текущей строки в результате</param>
    /// <returns>Значение строки</returns>
    public static string ValueOrDefaultWhiteSpace(
      this string value,
      string defaultValue,
      string format = "{0}")
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (StringExtensions.o0oH4qG7MaZVEQnmsRTl((object) value))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
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
      return format.FormatWith((object) value);
label_3:
      return defaultValue;
    }

    /// <summary>
    ///  Обрезает строку <c>s</c> до указанной длинны <c>length</c>
    ///  <remarks>
    /// 	Если длинна строки <c>s</c> больше <c>length</c>, к ней добавляется <c>suffix</c>.
    ///  Если строка <c>s</c> является <strong>null</strong> возвращается <strong>string.Empty</strong>
    ///  </remarks>
    /// </summary>
    /// <param name="s"></param>
    /// <param name="length"></param>
    /// <param name="suffix"></param>
    /// <returns></returns>
    public static string Trunk(this string s, int length, string suffix)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (s != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_6;
          case 3:
            goto label_5;
          case 4:
            goto label_4;
          default:
            if (StringExtensions.NUjnTgG7DfQIryEBbioj((object) s) <= length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 3 : 3;
              continue;
            }
            goto label_4;
        }
      }
label_4:
      return s.Substring(0, length) + suffix;
label_5:
      return s;
label_6:
      return string.Empty;
    }

    /// <summary>
    /// Обрезает строку input, взяв startLength символов с начала строки и endLength с конца строки
    /// </summary>
    /// <param name="input">Входная строка</param>
    /// <param name="startLength">Количество символов с начала</param>
    /// <param name="endLength">Количество символов с конца</param>
    /// <returns></returns>
    public static string Truncate(this string input, int startLength, int endLength)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            StringExtensions.iCgIH6G7JesJySkXNReA(endLength >= 0, StringExtensions.AVOdFaG7eNJHjjZ89SgL(1142330761 ^ 1541959139 ^ 536543106));
            num = 5;
            continue;
          case 2:
            StringExtensions.iCgIH6G7JesJySkXNReA(startLength >= 0, StringExtensions.AVOdFaG7eNJHjjZ89SgL(381945751 ^ 1158627804 ^ 1406091663));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
            continue;
          case 3:
            Contract.ArgumentNotNull((object) input, (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1290212282 ^ -644262414 ^ 1787149826));
            num = 2;
            continue;
          case 4:
            if (startLength + endLength + 3 >= input.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          case 5:
            Contract.CheckArgument(startLength + endLength > 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319192628));
            num = 4;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return input;
label_9:
      return (string) StringExtensions.aP6iCgG79wqx5qVDw8wn((object) input.Remove(startLength), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132652413), StringExtensions.Kw41c0G7w9N2gu3k4JRk((object) input, StringExtensions.NUjnTgG7DfQIryEBbioj((object) input) - endLength));
    }

    /// <summary>
    /// Обрезать строку input длиной больше maxLength, взяв startLength символов с начала строки и endLength c конца
    /// </summary>
    /// <param name="input">Входная строка</param>
    /// <param name="startLength">Количество символов с начала строки</param>
    /// <param name="endLength">Количество символов с конца строки</param>
    /// <param name="maxLength">Длина строки, с которой начинается обрезание</param>
    /// <returns></returns>
    public static string Truncate(
      this string input,
      int startLength,
      int endLength,
      int maxLength)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              StringExtensions.iCgIH6G7JesJySkXNReA(endLength >= 0, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939638940));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_7;
            case 4:
              StringExtensions.XN9jNfG7djrF1996O6pI((object) input, StringExtensions.AVOdFaG7eNJHjjZ89SgL(1051276242 - 990076387 ^ 60936793));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 3 : 3;
              continue;
            case 5:
              StringExtensions.iCgIH6G7JesJySkXNReA(maxLength >= 0, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633254375));
              num2 = 6;
              continue;
            case 6:
              if (StringExtensions.NUjnTgG7DfQIryEBbioj((object) input) <= maxLength)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 7 : 2;
                continue;
              }
              goto label_10;
            case 7:
              goto label_11;
            default:
              Contract.CheckArgument(startLength + endLength > 0, (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1819636893 << 3 ^ 1672457440));
              num2 = 5;
              continue;
          }
        }
label_7:
        Contract.CheckArgument(startLength >= 0, (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-2092274397 << 4 ^ 883086836));
        num1 = 2;
      }
label_10:
      return (string) StringExtensions.xgwJmpG7ldtcXTG5oDlP((object) input, startLength, endLength);
label_11:
      return input;
    }

    /// <summary>Сгенерировать гуид по строке</summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static Guid GetDeterministicGuid(this string input) => StringExtensions.v4IEJfG7rZALoX34LnlR((object) input, (object) Encoding.UTF8);

    /// <summary>Сгенерировать гуид по строке</summary>
    /// <param name="input"></param>
    /// <param name="encoding">Кодировка</param>
    /// <returns></returns>
    public static Guid GetDeterministicGuid(this string input, Encoding encoding)
    {
      int num1 = 2;
      MD5CryptoServiceProvider cryptoServiceProvider;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_14;
          case 2:
            if (input == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
              continue;
            }
            if (encoding != null)
            {
              cryptoServiceProvider = (MD5CryptoServiceProvider) null;
              num1 = 3;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
            continue;
          case 3:
            goto label_2;
          case 4:
            goto label_17;
          default:
            goto label_10;
        }
      }
label_2:
      Guid deterministicGuid;
      try
      {
        cryptoServiceProvider = EncryptionHelper.Md5CryptoServiceProviderPool.Get();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_17;
            default:
              deterministicGuid = MemoryHelper.ActionWithMemoryBuffer<byte, (MD5CryptoServiceProvider, Encoding, string), Guid>(encoding.GetByteCount(input), (cryptoServiceProvider, encoding, input), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (MD5CryptoServiceProvider, Encoding, string), Guid>(StringExtensions.GetDeterministicGuidAction));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 0;
              continue;
          }
        }
      }
      finally
      {
        EncryptionHelper.Md5CryptoServiceProviderPool.Return(cryptoServiceProvider);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_10:
      throw new ArgumentNullException((string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(236071375 ^ 236132165));
label_14:
      throw new ArgumentNullException((string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-244066886 - -48452443 ^ -195875165));
label_17:
      return deterministicGuid;
    }

    private static Guid GetDeterministicGuidAction(
      object buffer,
      int offset,
      int length,
      (MD5CryptoServiceProvider, Encoding, string) param)
    {
      (MD5CryptoServiceProvider cryptoServiceProvider, Encoding encoding, string s) = param;
      encoding.GetBytes(s, 0, s.Length, (byte[]) buffer, offset);
      return new Guid(cryptoServiceProvider.ComputeHash((byte[]) buffer, offset, length));
    }

    /// <summary>
    /// Получить хэш-код строки с помощью алгоритма SHA1 в виде строки Base64
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static string GetSHA1Base64Hash(this string s)
    {
      int num1 = 2;
      SHA1 shA1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            if (s != null)
            {
              shA1 = (SHA1) StringExtensions.WVPODCG7gukwIWCFAvXV();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_14;
          default:
            goto label_4;
        }
      }
label_2:
      throw new ArgumentNullException((string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1317790512 ^ -1317689674));
label_4:
      string shA1Base64Hash;
      try
      {
        shA1Base64Hash = MemoryHelper.ActionWithMemoryBuffer<byte, (SHA1, string), string>(((Encoding) StringExtensions.ebm4RJG75Oj9diIko3Y5()).GetByteCount(s), (shA1, s), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (SHA1, string), string>(StringExtensions.GetSHA1Base64HashAction));
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (shA1 == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 0;
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
        StringExtensions.lxWbpjG7j7tV0bQtdRMw((object) shA1);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
        {
          num3 = 0;
          goto label_10;
        }
        else
          goto label_10;
      }
label_14:
      return shA1Base64Hash;
    }

    private static string GetSHA1Base64HashAction(
      object buffer,
      int offset,
      int length,
      (SHA1, string) param)
    {
      (SHA1 shA1, string s) = param;
      Encoding.UTF8.GetBytes(s, 0, s.Length, (byte[]) buffer, offset);
      return Convert.ToBase64String(shA1.ComputeHash((byte[]) buffer, offset, length));
    }

    /// <summary>
    /// Преобразовать строку Base64 в строку, которая является валидным именем файла
    /// </summary>
    /// <remarks>Символ "/" заменяется на "#"</remarks>
    /// <param name="s"></param>
    /// <returns></returns>
    public static string Base64StringToValidFileName(this string s)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (s != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      throw new ArgumentNullException((string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(92412609 - 1050237057 ^ -957777882));
label_5:
      return (string) StringExtensions.R6B71VG7YSTOyqRMnZMQ((object) s, '/', '#');
    }

    /// <summary>Функция, обратная функции Base64StringToValidFileName</summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static string Base64StringFromValidFileName(this string s)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (s != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      throw new ArgumentNullException((string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-643786247 ^ -643751009));
label_5:
      return (string) StringExtensions.R6B71VG7YSTOyqRMnZMQ((object) s, '#', '/');
    }

    public static string FormatWith(this string format, params object[] args) => (string) StringExtensions.qgKAwfG7LhFaieKnmOnc((object) format, (object) args);

    public static string FormatWith(
      this string format,
      IFormatProvider provider,
      params object[] args)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            StringExtensions.XN9jNfG7djrF1996O6pI((object) format, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309375024));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) StringExtensions.y4IgPtG7U2EFSe7lu0bn((object) provider, (object) format, (object) args);
    }

    public static bool IsNullOrEmpty(this string str, bool ignoreWhiteSpace)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ignoreWhiteSpace)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      object obj = (object) str;
      goto label_6;
label_5:
      obj = StringExtensions.SDg8t2G7stb8D9VW2xMh((object) str);
label_6:
      return StringExtensions.WvgFDkG71kseC6o8colV(obj);
    }

    public static string Repeat(this string stringToRepeat, int repetitionsCount)
    {
      int num1 = 1;
      int num2;
      StringBuilder stringBuilder;
      while (true)
      {
        switch (num1)
        {
          case 1:
            stringBuilder = new StringBuilder();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          case 2:
          case 5:
            StringExtensions.uUmXYAG74Yqd2K1UUw7X((object) stringBuilder, (object) stringToRepeat);
            num1 = 4;
            continue;
          case 3:
          case 7:
            if (num2 < repetitionsCount)
            {
              num1 = 5;
              continue;
            }
            goto label_4;
          case 4:
            ++num2;
            num1 = 7;
            continue;
          case 6:
            goto label_4;
          default:
            num2 = 0;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 3 : 1;
            continue;
        }
      }
label_4:
      return stringBuilder.ToString();
    }

    /// <summary>
    /// Возвращает подстроку между строками from и to.
    /// Если from не найдена, то возвращает подстроку от начала строки до to.
    /// Если не найдена to, то возвращает подстроку от from и до конца строки.
    /// Если ни from, ни to не найдены, то возвращает string.Empty
    /// </summary>
    /// <param name="str"></param>
    /// <param name="from">От</param>
    /// <param name="to">До</param>
    /// <returns></returns>
    public static string Between(this string str, string from, string to = null)
    {
      int num1 = 2;
      int num2;
      int num3;
      while (true)
      {
        int num4 = num1;
        while (true)
        {
          int num5;
          switch (num4)
          {
            case 1:
              if (to != null)
              {
                if (num2 == -1)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 3;
                  continue;
                }
                num5 = StringExtensions.R51ebQG7ztcEBO4H6Yv4((object) str, (object) to, num2 + StringExtensions.NUjnTgG7DfQIryEBbioj((object) from), StringComparison.InvariantCultureIgnoreCase);
                break;
              }
              goto label_16;
            case 2:
              num2 = StringExtensions.R9VQH9G7cYTVT8KvFJMa((object) str, (object) from, StringComparison.InvariantCultureIgnoreCase);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 0;
              continue;
            case 3:
              num5 = StringExtensions.R9VQH9G7cYTVT8KvFJMa((object) str, (object) to, StringComparison.InvariantCultureIgnoreCase);
              break;
            case 4:
              if (num2 == -1)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
                continue;
              }
              goto label_10;
            case 5:
              num5 = StringExtensions.NUjnTgG7DfQIryEBbioj((object) str);
              break;
            case 6:
              goto label_8;
            default:
              if (num3 == -1)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 4 : 6;
                continue;
              }
              goto label_9;
          }
          num3 = num5;
          num4 = 4;
        }
label_16:
        num1 = 5;
      }
label_8:
      return (string) null;
label_9:
      return (string) StringExtensions.z9YxotG7mFkVExOMcRtH((object) str, 0, num3);
label_10:
      return (string) StringExtensions.z9YxotG7mFkVExOMcRtH((object) str, num2 + StringExtensions.NUjnTgG7DfQIryEBbioj((object) from), num3 - num2 - StringExtensions.NUjnTgG7DfQIryEBbioj((object) from));
    }

    /// <summary>
    /// Определяет равны ли два строки за время, не зависящее от содержимого этих строк.
    /// Данный метод неэффективен. Для обычного сравнения используйте оператор ==
    /// </summary>
    /// <param name="str1"></param>
    /// <param name="str2"></param>
    /// <returns></returns>
    public static bool SlowEquals(this string str1, string str2) => StringExtensions.KgL8JTGxWXjx8AY1i4EZ(StringExtensions.lW9eduGxBa2P74YkV7jR(StringExtensions.hm6FtnGxFZNtuAL5nmfP(), (object) str1), StringExtensions.lW9eduGxBa2P74YkV7jR(StringExtensions.hm6FtnGxFZNtuAL5nmfP(), (object) str2));

    /// <summary>Обернуть строковое значение в ограничители значения.</summary>
    /// <param name="str">Строка</param>
    /// <param name="quote">Символ ограничителя</param>
    /// <returns>Обёрнутое в ограничители строковое значение</returns>
    public static string Quote(this string str, char quote = '"') => (string) StringExtensions.lrHmLmGxo0WnsUSDG6Vt((object) quote, (object) str, (object) quote);

    /// <summary>Экранировать символ в строке путём его удваивания.</summary>
    /// <param name="str">Исходная строка</param>
    /// <param name="escapeChar">Экранируемый символ</param>
    /// <returns>Экранированная строка</returns>
    public static string Escape(this string str, char escapeChar = '"')
    {
      int num = 1;
      string str1;
      while (true)
      {
        switch (num)
        {
          case 1:
            str1 = new string(escapeChar, 2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) StringExtensions.OgMe8bG72xJXKcp2X0Rb((object) str, (object) escapeChar.ToString(), (object) str1);
    }

    /// <summary>Удалить разрывы строки</summary>
    /// <param name="str">Строка</param>
    /// <returns>Строка без разрывов</returns>
    public static string RemoveLineBreaks(this string str)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (str != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) null;
label_3:
      return ((string) StringExtensions.OgMe8bG72xJXKcp2X0Rb((object) str, StringExtensions.AVOdFaG7eNJHjjZ89SgL(1669212571 ^ 1669216099), (object) "")).Replace((string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-420743386 ^ -420747134), "");
    }

    /// <summary>Заменить с позиции</summary>
    /// <param name="str">Строка</param>
    /// <param name="index">Индекс, с которого выполнить замену</param>
    /// <param name="length">Количество заменяемых символов</param>
    /// <param name="replace">Строка-замена</param>
    /// <returns>Итоговая строка</returns>
    public static string ReplaceAt(this string str, int index, int length, string replace) => ((string) StringExtensions.pT7BPaGxhokncVkFUSfY((object) str, index, StringExtensions.C44dEPGxbNUQEWAZFNZh(length, StringExtensions.NUjnTgG7DfQIryEBbioj((object) str) - index))).Insert(index, replace);

    /// <summary>Заменить недопустимые символы в имени файла на '_'</summary>
    /// <param name="fileName">Имя файла</param>
    /// <returns>Имя файла с замененными символами</returns>
    public static string ReplaceInvalidFileNameChars(this string fileName)
    {
      int num = 2;
      char[] first;
      while (true)
      {
        switch (num)
        {
          case 1:
            first = (char[]) StringExtensions.MO1rs4GxGNBJHe2unXhV();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 2:
            StringExtensions.XN9jNfG7djrF1996O6pI((object) fileName, StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1088304168 ^ -1088309822));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_3;
          default:
            ((IEnumerable<char>) first).Union<char>((IEnumerable<char>) StringExtensions.HsnTJWGxEZVunWD3q0e1());
            num = 3;
            continue;
        }
      }
label_3:
      return string.Join((string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-2138160520 ^ -2138157566), fileName.Split(first));
    }

    /// <summary>Заменить управляющие символы в строке на '_'</summary>
    /// <param name="input">Входная строка</param>
    /// <returns>Строка с заменёнными управляющими символами</returns>
    public static string ReplaceControlCharacters(this string input)
    {
      int num1 = 11;
      StringBuilder stringBuilder;
      string str;
      int num2;
      char c;
      while (true)
      {
        switch (num1)
        {
          case 1:
          case 9:
            c = StringExtensions.HfVCJLG7tivFO2BJ4HrC((object) str, num2);
            num1 = 5;
            continue;
          case 2:
          case 12:
            if (num2 < StringExtensions.NUjnTgG7DfQIryEBbioj((object) str))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          case 4:
            num2 = 0;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 2 : 1;
            continue;
          case 5:
            if (char.IsControl(c))
            {
              num1 = 13;
              continue;
            }
            goto case 6;
          case 6:
            StringExtensions.nGm2fFGxfIWDDUHueDQa((object) stringBuilder, c);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          case 7:
            goto label_2;
          case 8:
            str = input;
            num1 = 4;
            continue;
          case 10:
            stringBuilder = new StringBuilder(StringExtensions.NUjnTgG7DfQIryEBbioj((object) input));
            num1 = 8;
            continue;
          case 11:
            StringExtensions.XN9jNfG7djrF1996O6pI((object) input, StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1852837372 ^ -1853098574));
            num1 = 10;
            continue;
          case 13:
            stringBuilder.Append('_');
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 3 : 0;
            continue;
          default:
            ++num2;
            num1 = 12;
            continue;
        }
      }
label_2:
      return stringBuilder.ToString();
    }

    /// <summary>
    /// Преобразовать строку в указанной кодировке в эквивалентное представление, состоящее из цифр в кодировке Base64
    /// </summary>
    /// <param name="value">Строка</param>
    /// <param name="encoding">Кодировка символов. По умолчанию используется <see cref="P:System.Text.Encoding.UTF8" /></param>
    /// <returns>Base64 строка</returns>
    public static string ToBase64String(this string value, Encoding encoding = null)
    {
      int num = 5;
      int minimumBufferLength;
      while (true)
      {
        Encoding encoding1;
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            encoding1 = Encoding.UTF8;
            break;
          case 3:
            if (minimumBufferLength != 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
              continue;
            }
            goto label_5;
          case 4:
            Encoding encoding2 = encoding;
            if (encoding2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 2;
              continue;
            }
            encoding1 = encoding2;
            break;
          case 5:
            StringExtensions.XN9jNfG7djrF1996O6pI((object) value, StringExtensions.AVOdFaG7eNJHjjZ89SgL(-35995181 ^ -36009819));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 3 : 4;
            continue;
          default:
            minimumBufferLength = StringExtensions.YuK2xeGxQuxtAXhWMQN1((object) encoding, (object) value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 3 : 1;
            continue;
        }
        encoding = encoding1;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
      }
label_4:
      return MemoryHelper.ActionWithMemoryBuffer<byte, (string, Encoding), string>(minimumBufferLength, (value, encoding), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (string, Encoding), string>(StringExtensions.ToBase64StringAction));
label_5:
      return string.Empty;
    }

    private static string ToBase64StringAction(
      object buffer,
      int offset,
      int length,
      (string, Encoding) param)
    {
      (string, Encoding) tuple = param;
      string s = tuple.Item1;
      tuple.Item2.GetBytes(s, 0, s.Length, (byte[]) buffer, offset);
      return Convert.ToBase64String((byte[]) buffer, offset, length);
    }

    /// <summary>Разбить текст на строки и вернуть не пустые строки</summary>
    /// <param name="value">Текст</param>
    /// <returns>Строки текста</returns>
    public static string[] SplitToLines(this string value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            StringExtensions.XN9jNfG7djrF1996O6pI((object) value, StringExtensions.AVOdFaG7eNJHjjZ89SgL(1514961705 ^ 1514943071));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return value.Split(StringExtensions.LineSeparators, StringSplitOptions.RemoveEmptyEntries);
    }

    static StringExtensions()
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1876063057 ^ -1876326911)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1445902765 ^ -1980277732 ^ 539103469);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 23 : 33;
              continue;
            case 2:
              StringExtensions.translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671859277)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1304605005 ^ 1304869315);
              num2 = 28;
              continue;
            case 3:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1113862659 ^ 1113603015)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(--1333735954 ^ 1333701380);
              num2 = 44;
              continue;
            case 4:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(44884861 ^ 44624613)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1642859704 ^ 1642595622);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 67 : 43;
              continue;
            case 5:
              StringExtensions.LineSeparators = new string[3]
              {
                (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(236071375 ^ 236079857),
                (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(813604817 ^ 813596969),
                (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(874012245 ^ 874004977)
              };
              num2 = 68;
              continue;
            case 6:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num2 = 5;
              continue;
            case 7:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1514961705 ^ 1514697235)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1033719030 - 2012070891 ^ -978616245);
              num2 = 37;
              continue;
            case 8:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1304605005 ^ 1304869765)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124378688);
              num2 = 26;
              continue;
            case 9:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-420743386 ^ -420479678)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1426456882 ^ 2009939514 ^ -583603534);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 16 : 23;
              continue;
            case 10:
              StringExtensions.translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1514697291)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(874012245 ^ 874272573);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 40 : 18;
              continue;
            case 11:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(825385222 ^ 825650074)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1146510045 ^ -1146245247);
              num2 = 64;
              continue;
            case 12:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1120607109 - 305487170 ^ -1426354917)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-542721635 ^ -542717549);
              num2 = 45;
              continue;
            case 13:
              StringExtensions.translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1853097898)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(272623989 ^ 272360237);
              num2 = 21;
              continue;
            case 14:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(~210725948 ^ -210462097)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1978478350 ^ -1978214080);
              num2 = 47;
              continue;
            case 15:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1598106783 - -968262081 ^ -630104922)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1251470110 >> 2 ^ 312832751);
              num2 = 30;
              continue;
            case 16:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1251470110 >> 2 ^ 312603635)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(236071375 ^ 236094843);
              num2 = 7;
              continue;
            case 17:
              StringExtensions.translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876326689)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-2099751081 ^ -2099487455);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 56 : 6;
              continue;
            case 18:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-138018305 ^ -138278911)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(647913418 ^ 647648718);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 9 : 31;
              continue;
            case 19:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1253244298 - 1829393894 ^ -575885640)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-281842504 ^ -281932198);
              num2 = 25;
              continue;
            case 20:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1669371371 ^ 1669388981)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(~-397266137 ^ 397357598);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 63 : 8;
              continue;
            case 21:
              goto label_63;
            case 22:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-2106517564 ^ -2106253638)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(--1333735954 ^ 1333664932);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 15 : 0;
              continue;
            case 23:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-281842504 ^ -281581870)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(222162814 ^ 222145586);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 17;
              continue;
            case 24:
              goto label_14;
            case 25:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1824388195 ^ -1824128321)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1319452732 ^ 1319562976);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            case 26:
              goto label_3;
            case 27:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-688192331 - 435440695 ^ -1123897342)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1251470110 >> 2 ^ 312947021);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 15 : 41;
              continue;
            case 28:
              goto label_55;
            case 29:
              StringExtensions.translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740598412)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1669212571 ^ 1669243315);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 53 : 34;
              continue;
            case 30:
              StringExtensions.translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309375434)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(2008901894 << 3 ^ -1108393568);
              num2 = 4;
              continue;
            case 31:
              StringExtensions.translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345159730)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633253819);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 66 : 63;
              continue;
            case 32:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-787452571 ^ -787192367)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470180324);
              num2 = 48;
              continue;
            case 33:
              StringExtensions.translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757396874)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(813604817 ^ 813341747);
              num2 = 62;
              continue;
            case 34:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1978478350 ^ -1978214400)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1669212571 ^ 1669092149);
              num2 = 61;
              continue;
            case 35:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-2138958856 ^ -2138695234)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-882126494 ^ -882246866);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 56 : 58;
              continue;
            case 36:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-35995181 ^ -35731171)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1052221104 - 768835541 ^ 283437899);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 46 : 9;
              continue;
            case 37:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(~538519529 ^ -538783408)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(712480695 ^ 712220411);
              num2 = 51;
              continue;
            case 38:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-2092274397 << 4 ^ 883087370)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-2112703338 ^ -2112438570);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 35 : 3;
              continue;
            case 39:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1867198571 ^ -1867463009)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-2138958856 ^ -2138908384);
              num2 = 52;
              continue;
            case 40:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1113862659 ^ 1113602929)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1819636893 << 3 ^ 1672120926);
              num2 = 65;
              continue;
            case 41:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-606654180 ^ -606914146)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1581325282 << 3 ^ -234130978);
              num2 = 2;
              continue;
            case 42:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-951514650 ^ -951254784)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-477139494 ^ -477403850);
              num2 = 34;
              continue;
            case 43:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-97972138 ^ -97707640)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1886646897 ^ -1886911381);
              num2 = 50;
              continue;
            case 44:
              goto label_50;
            case 45:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-138018305 ^ -138277929)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712220057);
              num2 = 49;
              continue;
            case 46:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-87337865 ^ -87073629)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(~1767720452 ^ -1767829179);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 22 : 24;
              continue;
            case 47:
              goto label_37;
            case 48:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(277947046 - -1479185048 ^ 1757396476)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(277947046 - -1479185048 ^ 1757396470);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 36 : 14;
              continue;
            case 49:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1487388570 ^ -1487123886)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1917256330 ^ 1917105344);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 38 : 6;
              continue;
            case 50:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-2092274397 << 4 ^ 883088348)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-281842504 ^ -281582262);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 20 : 2;
              continue;
            case 51:
              StringExtensions.translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108393628)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335257771);
              num2 = 10;
              continue;
            case 52:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(--1360331293 ^ 1360071437)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1218962250 ^ 1218843204);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 60;
              continue;
            case 53:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(901793403 ^ 902057693)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606914128);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 32 : 6;
              continue;
            case 54:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-2138160520 ^ -2138420510)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(272623989 ^ 272427415);
              num2 = 29;
              continue;
            case 55:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(222162814 ^ 221898624)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1998538950 ^ -1998275010);
              num2 = 39;
              continue;
            case 56:
              StringExtensions.translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978213748)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(825385222 ^ 825650050);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 57 : 20;
              continue;
            case 57:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-710283084 ^ -537863435 ^ 173875405)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(864270449 << 6 ^ -521529646);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 11 : 5;
              continue;
            case 58:
              goto label_20;
            case 59:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1253244298 - 1829393894 ^ -575885708)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-951514650 ^ -951254992);
              num2 = 43;
              continue;
            case 60:
              StringExtensions.translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44624491)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-688192331 - 435440695 ^ -1123614184);
              num2 = 19;
              continue;
            case 61:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-2092274397 << 4 ^ 883088072)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-441065788 ^ -2092910478 ^ 1727372542);
              num2 = 55;
              continue;
            case 62:
              StringExtensions.translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638662997)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921463037);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 8 : 5;
              continue;
            case 63:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(92412609 - 1050237057 ^ -957559880)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501249357);
              num2 = 18;
              continue;
            case 64:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-87337865 ^ -87073057)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(381945751 ^ 1158627804 ^ 1405677199);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 1;
              continue;
            case 65:
              goto label_19;
            case 66:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(712480695 ^ 712220065)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(~541731958 ^ -541992555);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 12 : 12;
              continue;
            case 67:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1917256330 ^ 1917294024)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-1334993905 ^ -1335030963);
              num2 = 69;
              continue;
            case 68:
              StringExtensions.translitChars = new Dictionary<string, string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 27 : 27;
              continue;
            case 69:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-951514650 ^ -951254976)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(2045296739 + 1688595713 ^ -561104296);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 14 : 11;
              continue;
            default:
              StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(993438473 ^ 993174049)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-87337865 ^ -87073447);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 16 : 13;
              continue;
          }
        }
label_14:
        StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1199946765 ^ 1199682775)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-740338220 ^ -740598476);
        num1 = 42;
        continue;
label_19:
        StringExtensions.translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099487185)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1514961705 ^ 1515180951);
        num1 = 22;
        continue;
label_20:
        StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(1242972401 >> 4 ^ 77950531)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675289047);
        num1 = 13;
        continue;
label_37:
        StringExtensions.translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304869109)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561339174);
        num1 = 3;
        continue;
label_50:
        StringExtensions.translitChars[(string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-542721635 ^ -542986153)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099489611);
        num1 = 59;
        continue;
label_55:
        StringExtensions.translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672457340)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(-882126494 ^ -882170142);
        num1 = 54;
        continue;
label_63:
        StringExtensions.translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87073239)] = (string) StringExtensions.AVOdFaG7eNJHjjZ89SgL(~538519529 ^ -538525626);
        num1 = 9;
      }
label_3:;
    }

    internal static object VJH5sNG7OhRtAcr1FyMa() => (object) Environment.NewLine;

    internal static object OgMe8bG72xJXKcp2X0Rb([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object AVOdFaG7eNJHjjZ89SgL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool oqQu61G7kYUkVv53KfBC() => StringExtensions.nIdOo9G7Tiv0eZyQJCSV == null;

    internal static StringExtensions xZEjoIG7nmaawCtiM7VB() => StringExtensions.nIdOo9G7Tiv0eZyQJCSV;

    internal static object W5vSGDG7PhO3QaPdlqcG(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] RegexOptions obj3)
    {
      return (object) Regex.Replace((string) obj0, (string) obj1, (string) obj2, obj3);
    }

    internal static bool WvgFDkG71kseC6o8colV([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object OuKAxfG7Nn1gDqLVlXy4([In] object obj0) => (object) HttpUtility.HtmlDecode((string) obj0);

    internal static bool ULHSZCG73UUNdqQK5KPy([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object cxvBCQG7pNejTZcNhC21([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object Kgk8MlG7aPufrVOxNuUV([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static int NUjnTgG7DfQIryEBbioj([In] object obj0) => ((string) obj0).Length;

    internal static char HfVCJLG7tivFO2BJ4HrC([In] object obj0, [In] int obj1) => ((string) obj0)[obj1];

    internal static object Kw41c0G7w9N2gu3k4JRk([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static object uUmXYAG74Yqd2K1UUw7X([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static char nqBa36G76svkE31SOuwl([In] char obj0) => char.ToLowerInvariant(obj0);

    internal static char gCqGI8G7HP9x8ZnJaC1e([In] char obj0) => char.ToUpperInvariant(obj0);

    internal static bool ikVDenG7AsccogMHcvpQ([In] object obj0) => ((string) obj0).IsNullOrEmpty();

    internal static object S0wpsBG77n26cHipl4iy([In] object obj0, [In] int obj1, [In] object obj2) => (object) ((string) obj0).Insert(obj1, (string) obj2);

    internal static bool GqrS8mG7xwLD7A58oV56([In] object obj0, [In] object obj1) => Regex.IsMatch((string) obj0, (string) obj1);

    internal static object xwnAlkG70DeUBaeTlMvJ([In] object obj0) => (object) BitConverter.ToString((byte[]) obj0);

    internal static object z9YxotG7mFkVExOMcRtH([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static byte vkNvtUG7yFMZw6QcH87W([In] object obj0, [In] int obj1) => Convert.ToByte((string) obj0, obj1);

    internal static bool o0oH4qG7MaZVEQnmsRTl([In] object obj0) => ((string) obj0).IsNullOrWhiteSpace();

    internal static void iCgIH6G7JesJySkXNReA(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static object aP6iCgG79wqx5qVDw8wn([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static void XN9jNfG7djrF1996O6pI([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object xgwJmpG7ldtcXTG5oDlP([In] object obj0, int startLength, int endLength) => (object) ((string) obj0).Truncate(startLength, endLength);

    internal static Guid v4IEJfG7rZALoX34LnlR([In] object obj0, [In] object obj1) => ((string) obj0).GetDeterministicGuid((Encoding) obj1);

    internal static object WVPODCG7gukwIWCFAvXV() => (object) SHA1.Create();

    internal static object ebm4RJG75Oj9diIko3Y5() => (object) Encoding.UTF8;

    internal static void lxWbpjG7j7tV0bQtdRMw([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object R6B71VG7YSTOyqRMnZMQ([In] object obj0, [In] char obj1, [In] char obj2) => (object) ((string) obj0).Replace(obj1, obj2);

    internal static object qgKAwfG7LhFaieKnmOnc([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static object y4IgPtG7U2EFSe7lu0bn([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((IFormatProvider) obj0, (string) obj1, (object[]) obj2);

    internal static object SDg8t2G7stb8D9VW2xMh([In] object obj0) => (object) ((string) obj0).Trim();

    internal static int R9VQH9G7cYTVT8KvFJMa([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).IndexOf((string) obj1, obj2);

    internal static int R51ebQG7ztcEBO4H6Yv4(
      [In] object obj0,
      [In] object obj1,
      [In] int obj2,
      [In] StringComparison obj3)
    {
      return ((string) obj0).IndexOf((string) obj1, obj2, obj3);
    }

    internal static object hm6FtnGxFZNtuAL5nmfP() => (object) Encoding.Unicode;

    internal static object lW9eduGxBa2P74YkV7jR([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetBytes((string) obj1);

    internal static bool KgL8JTGxWXjx8AY1i4EZ([In] object obj0, [In] object obj1) => ByteArrayConstTimeEqualityExtension.Equals((byte[]) obj0, (byte[]) obj1);

    internal static object lrHmLmGxo0WnsUSDG6Vt([In] object obj0, [In] object obj1, [In] object obj2) => (object) (obj0.ToString() + obj1 + obj2);

    internal static int C44dEPGxbNUQEWAZFNZh([In] int obj0, [In] int obj1) => Math.Min(obj0, obj1);

    internal static object pT7BPaGxhokncVkFUSfY([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Remove(obj1, obj2);

    internal static object MO1rs4GxGNBJHe2unXhV() => (object) Path.GetInvalidFileNameChars();

    internal static object HsnTJWGxEZVunWD3q0e1() => (object) Path.GetInvalidPathChars();

    internal static object nGm2fFGxfIWDDUHueDQa([In] object obj0, [In] char obj1) => (object) ((StringBuilder) obj0).Append(obj1);

    internal static int YuK2xeGxQuxtAXhWMQN1([In] object obj0, [In] object obj1) => ((Encoding) obj0).GetByteCount((string) obj1);
  }
}
