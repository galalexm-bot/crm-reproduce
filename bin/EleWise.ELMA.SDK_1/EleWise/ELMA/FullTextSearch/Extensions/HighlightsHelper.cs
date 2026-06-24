// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Extensions.HighlightsHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace EleWise.ELMA.FullTextSearch.Extensions
{
  /// <summary>
  /// Хэлпер для распарса строк с подстветкой найденого в html-строку
  /// </summary>
  public static class HighlightsHelper
  {
    private static Dictionary<Type, Dictionary<string, string>> Mapping;
    private static Dictionary<Type, Dictionary<string, long>> Order;
    internal static HighlightsHelper emxthCGCTp1dcu489TGS;

    public static string CutHtmlTags(BinaryFile file)
    {
      int num = 5;
      IFilePreviewService serviceNotNull;
      string str;
      string text;
      while (true)
      {
        switch (num)
        {
          case 2:
            str = (string) HighlightsHelper.cG15MhGC2mIuJpJVaGnx((object) serviceNotNull, (object) file);
            num = 9;
            continue;
          case 3:
            text = serviceNotNull.GetPreviewText(file);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 7 : 3;
            continue;
          case 4:
            text = "";
            num = 13;
            continue;
          case 5:
            if (!file.Encrypt)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 4 : 4;
              continue;
            }
            goto label_6;
          case 6:
            if (HighlightsHelper.ig4vrYGCOhBrBfTqk9aI((object) serviceNotNull, (object) file) <= 100000000L)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 2 : 2;
              continue;
            }
            goto label_4;
          case 7:
            text = HighlightsHelper.CutHtmlTags(text, true);
            num = 8;
            continue;
          case 8:
          case 11:
            goto label_13;
          case 9:
            if (HighlightsHelper.pbsE4sGCeqXMoxyLxbrP((object) str))
            {
              num = 10;
              continue;
            }
            goto case 12;
          case 12:
            if (!new List<string>()
            {
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411313375),
              (string) HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(-1858887263 ^ -1859098309)
            }.Contains((string) HighlightsHelper.Rc9YAsGC1XMFal4EQmND((object) str)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 13:
            serviceNotNull = Locator.GetServiceNotNull<IFilePreviewService>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 6 : 5;
            continue;
          case 14:
            goto label_4;
          case 15:
            goto label_6;
          default:
            text = serviceNotNull.GetPreviewText(file);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 6 : 11;
            continue;
        }
      }
label_4:
      return "";
label_6:
      return string.Empty;
label_13:
      return text;
    }

    public static string CutHtmlTags(string text, bool isHtml = false)
    {
      int num1 = 18;
      string str;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!isHtml)
              {
                num2 = 12;
                continue;
              }
              goto case 19;
            case 2:
              str = (string) HighlightsHelper.fYgevbGC3tdDjQ9udX8n((object) str, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867397425), HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(1021410165 ^ 1021391447), RegexOptions.IgnoreCase);
              num2 = 6;
              continue;
            case 3:
              str = (string) HighlightsHelper.fYgevbGC3tdDjQ9udX8n((object) str, HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(901793403 ^ 902008691), HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(-97972138 ^ -97953420), RegexOptions.IgnoreCase);
              num2 = 4;
              continue;
            case 4:
              str = Regex.Replace(str, (string) HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(1033719030 - 2012070891 ^ -978567139), (string) HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(-1858887263 ^ -1858869117), RegexOptions.IgnoreCase);
              num2 = 5;
              continue;
            case 5:
              str = (string) HighlightsHelper.fYgevbGC3tdDjQ9udX8n((object) str, HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(~-122002947 ^ 122050342), HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(1199946765 ^ 1199961391), RegexOptions.IgnoreCase);
              num2 = 7;
              continue;
            case 6:
              str = (string) HighlightsHelper.fYgevbGC3tdDjQ9udX8n((object) str, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477321974), HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(1052221104 - 768835541 ^ 283400185), RegexOptions.IgnoreCase);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 13 : 14;
              continue;
            case 7:
              str = (string) HighlightsHelper.fYgevbGC3tdDjQ9udX8n((object) str, HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(979449278 ^ 979565708), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29240255), RegexOptions.IgnoreCase);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            case 8:
              str = (string) HighlightsHelper.hiLCSlGCphi8nXEZSS4F((object) str);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 1;
              continue;
            case 9:
              goto label_12;
            case 10:
              goto label_7;
            case 11:
              str = (string) HighlightsHelper.jhh0nuGCNJyuneab2GwH((object) str.GetClearBodyFromHtml());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 19 : 20;
              continue;
            case 12:
            case 13:
              str = (string) HighlightsHelper.j64V3gGCDGZnufPK21hk((object) str, HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(-680446928 - -370807692 ^ -309817654), HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(1251470110 >> 2 ^ 312849381));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 9;
              continue;
            case 14:
              str = (string) HighlightsHelper.fYgevbGC3tdDjQ9udX8n((object) str, HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(277947046 - -1479185048 ^ 1756921312), HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(979449278 ^ 979467420), RegexOptions.IgnoreCase);
              num2 = 10;
              continue;
            case 15:
              str = Regex.Replace(str, (string) HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(-1867198571 ^ -1867053277), (string) HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(-1380439818 << 3 ^ 1841368722), RegexOptions.IgnoreCase);
              num2 = 2;
              continue;
            case 16:
              str = (string) HighlightsHelper.fYgevbGC3tdDjQ9udX8n((object) str, HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(901793403 ^ 902008449), HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(-35995181 ^ -36009743), RegexOptions.IgnoreCase);
              num2 = 3;
              continue;
            case 17:
              if (isHtml)
              {
                num2 = 11;
                continue;
              }
              goto case 8;
            case 18:
              goto label_10;
            case 19:
              str = (string) HighlightsHelper.DY3AySGCamkihXSPZZeO(HighlightsHelper.DY3AySGCamkihXSPZZeO(HighlightsHelper.DY3AySGCamkihXSPZZeO(HighlightsHelper.DY3AySGCamkihXSPZZeO((object) ((string) HighlightsHelper.DY3AySGCamkihXSPZZeO((object) str, HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(-740338220 ^ -740516724), HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(993438473 ^ 993452587))).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105312630), (string) HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(87862435 ^ 87876993)), HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(~-306453669 ^ 306479002), HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(1251470110 >> 2 ^ 312849381)), HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(979449278 ^ 979446598), HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(712480695 ^ 712498837)), HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(-1380439818 << 3 ^ 1841387540), HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(-2138958856 ^ -2138940710)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289713728), HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(-97972138 ^ -97953420));
              num2 = 13;
              continue;
            case 20:
              str = (string) HighlightsHelper.fYgevbGC3tdDjQ9udX8n((object) str, HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(825385222 ^ 825338272), HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(~-306453669 ^ 306468230), RegexOptions.IgnoreCase);
              num2 = 15;
              continue;
            default:
              str = Regex.Replace(str, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082286174), "");
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 8 : 4;
              continue;
          }
        }
label_7:
        str = Regex.Replace(str, (string) HighlightsHelper.XFLjUQGCPPFKlPTVmUOa(~-122002947 ^ 122050286), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345439002), RegexOptions.IgnoreCase);
        num1 = 16;
        continue;
label_10:
        str = text;
        num1 = 17;
      }
label_12:
      return str;
    }

    public static List<KeyValuePair<bool, string>> HighlightToHtml(
      string highlight,
      string openTag = null,
      string closeTag = null)
    {
      if (string.IsNullOrWhiteSpace(highlight))
        return new List<KeyValuePair<bool, string>>();
      string str1 = string.IsNullOrWhiteSpace(openTag) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1643103538) : openTag;
      string str2 = string.IsNullOrWhiteSpace(closeTag) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822740594) : closeTag;
      List<KeyValuePair<bool, string>> html = new List<KeyValuePair<bool, string>>();
      string str3 = highlight.Trim();
      while (str3.Length > 0 && !string.IsNullOrWhiteSpace(str1) && !string.IsNullOrWhiteSpace(str2))
      {
        int num1 = str3.IndexOf(str1);
        if (num1 < 0)
        {
          html.Add(new KeyValuePair<bool, string>(false, str3));
          str3 = "";
        }
        else
        {
          html.Add(new KeyValuePair<bool, string>(false, str3.Substring(0, num1)));
          string str4 = str3.Remove(0, num1).Remove(0, str1.Length);
          int num2 = str4.IndexOf(str2);
          if (num2 < 0)
          {
            html.Add(new KeyValuePair<bool, string>(false, str4));
            str3 = "";
          }
          else
          {
            html.Add(new KeyValuePair<bool, string>(true, str4.Substring(0, num2)));
            str3 = str4.Remove(0, num2).Remove(0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3215988).Length);
          }
        }
      }
      return html;
    }

    public static long GetOrder(Type type, string key)
    {
      int num1 = 3;
      Dictionary<string, long> dictionary;
      while (true)
      {
        IEnumerator<IModuleFullTextSearchExtension> enumerator1;
        Dictionary<string, long> order;
        switch (num1)
        {
          case 1:
            try
            {
label_11:
              if (HighlightsHelper.uZnKjXGCtqjp1IwgOKgj((object) enumerator1))
                goto label_25;
              else
                goto label_12;
label_10:
              IEnumerator<KeyValuePair<string, long>> enumerator2;
              int num2;
              switch (num2)
              {
                case 1:
                  goto label_25;
                case 2:
                  try
                  {
label_17:
                    if (HighlightsHelper.uZnKjXGCtqjp1IwgOKgj((object) enumerator2))
                      goto label_16;
                    else
                      goto label_18;
label_14:
                    KeyValuePair<string, long> current;
                    int num3;
                    while (true)
                    {
                      switch (num3)
                      {
                        case 1:
                          goto label_11;
                        case 2:
                          order.Add(current.Key, current.Value);
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                          continue;
                        case 3:
                          goto label_16;
                        default:
                          goto label_17;
                      }
                    }
label_16:
                    current = enumerator2.Current;
                    num3 = 2;
                    goto label_14;
label_18:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
                    goto label_14;
                  }
                  finally
                  {
                    if (enumerator2 != null)
                    {
                      int num4 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
                        num4 = 0;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            enumerator2.Dispose();
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_24;
                        }
                      }
                    }
label_24:;
                  }
                case 3:
                  goto label_2;
                default:
                  goto label_11;
              }
label_12:
              num2 = 3;
              goto label_10;
label_25:
              Dictionary<string, long> highlightsOrder = enumerator1.Current.GetHighlightsOrder(type);
              Func<KeyValuePair<string, long>, bool> func;
              Func<KeyValuePair<string, long>, bool> func1 = func;
              Func<KeyValuePair<string, long>, bool> predicate = func1 == null ? (func = (Func<KeyValuePair<string, long>, bool>) (map => !order.ContainsKey(map.Key))) : func1;
              enumerator2 = highlightsOrder.Where<KeyValuePair<string, long>>(predicate).GetEnumerator();
              num2 = 2;
              goto label_10;
            }
            finally
            {
              int num5;
              if (enumerator1 == null)
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
              else
                goto label_29;
label_28:
              switch (num5)
              {
                case 2:
                  break;
                default:
              }
label_29:
              enumerator1.Dispose();
              num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
              {
                num5 = 1;
                goto label_28;
              }
              else
                goto label_28;
            }
          case 2:
          case 7:
            dictionary = HighlightsHelper.Order[type];
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 5 : 4;
            continue;
          case 3:
            if (HighlightsHelper.Order.ContainsKey(type))
            {
              num1 = 2;
              continue;
            }
            break;
          case 4:
            goto label_5;
          case 5:
            if (!dictionary.ContainsKey(key))
            {
              num1 = 6;
              continue;
            }
            goto label_5;
          case 6:
            goto label_6;
          case 8:
label_2:
            HighlightsHelper.Order.Add(type, order);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 2 : 7;
            continue;
          case 9:
            IEnumerable<IModuleFullTextSearchExtension> extensionPoints = ComponentManager.Current.GetExtensionPoints<IModuleFullTextSearchExtension>();
            order = new Dictionary<string, long>();
            enumerator1 = extensionPoints.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
            continue;
        }
        num1 = 9;
      }
label_5:
      return dictionary[key];
label_6:
      return 1000000;
    }

    /// <summary>
    /// Получение отображаемого имени по ключу названия хайлайта
    /// </summary>
    /// <param name="type"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public static string GetDisplayName(Type type, string key)
    {
      int num1 = 1;
      Dictionary<string, string> dictionary;
      IEnumerator<IModuleFullTextSearchExtension> enumerator1;
      Dictionary<string, string> mapping;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!HighlightsHelper.Mapping.ContainsKey(type))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
label_3:
            HighlightsHelper.Mapping.Add(type, mapping);
            num1 = 3;
            continue;
          case 3:
            dictionary = HighlightsHelper.Mapping[type];
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 4;
            continue;
          case 4:
            if (dictionary.ContainsKey(key))
            {
              num1 = 6;
              continue;
            }
            goto label_34;
          case 5:
            try
            {
label_8:
              if (enumerator1.MoveNext())
                goto label_23;
              else
                goto label_9;
label_7:
              IEnumerator<KeyValuePair<string, string>> enumerator2;
              int num2;
              switch (num2)
              {
                case 1:
                  goto label_8;
                case 2:
                  goto label_3;
                case 3:
                  try
                  {
label_15:
                    if (HighlightsHelper.uZnKjXGCtqjp1IwgOKgj((object) enumerator2))
                      goto label_13;
                    else
                      goto label_16;
label_11:
                    KeyValuePair<string, string> current;
                    int num3;
                    while (true)
                    {
                      switch (num3)
                      {
                        case 1:
                          goto label_8;
                        case 2:
                          mapping.Add(current.Key, current.Value);
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
                          continue;
                        case 3:
                          goto label_13;
                        default:
                          goto label_15;
                      }
                    }
label_13:
                    current = enumerator2.Current;
                    num3 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
                    {
                      num3 = 2;
                      goto label_11;
                    }
                    else
                      goto label_11;
label_16:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
                    goto label_11;
                  }
                  finally
                  {
                    int num4;
                    if (enumerator2 == null)
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 1;
                    else
                      goto label_20;
label_19:
                    switch (num4)
                    {
                      case 1:
                      case 2:
                    }
label_20:
                    HighlightsHelper.VGilhaGCw25R7kclySFA((object) enumerator2);
                    num4 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
                    {
                      num4 = 2;
                      goto label_19;
                    }
                    else
                      goto label_19;
                  }
                default:
                  goto label_23;
              }
label_9:
              num2 = 2;
              goto label_7;
label_23:
              enumerator2 = enumerator1.Current.GetReverseMapping(type).Where<KeyValuePair<string, string>>((Func<KeyValuePair<string, string>, bool>) (map => !mapping.ContainsKey(map.Key))).GetEnumerator();
              num2 = 3;
              goto label_7;
            }
            finally
            {
              int num5;
              if (enumerator1 == null)
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
              else
                goto label_27;
label_26:
              switch (num5)
              {
                case 1:
                case 2:
              }
label_27:
              HighlightsHelper.VGilhaGCw25R7kclySFA((object) enumerator1);
              num5 = 2;
              goto label_26;
            }
          case 6:
            goto label_33;
          case 7:
            IEnumerable<IModuleFullTextSearchExtension> extensionPoints = ComponentManager.Current.GetExtensionPoints<IModuleFullTextSearchExtension>();
            mapping = new Dictionary<string, string>();
            enumerator1 = extensionPoints.GetEnumerator();
            num1 = 5;
            continue;
          default:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 2 : 7;
            continue;
        }
      }
label_33:
      return dictionary[key];
label_34:
      return key;
    }

    static HighlightsHelper()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            HighlightsHelper.Order = new Dictionary<Type, Dictionary<string, long>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
            continue;
          case 2:
            HighlightsHelper.Mapping = new Dictionary<Type, Dictionary<string, string>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
            continue;
          case 3:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 2 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static long ig4vrYGCOhBrBfTqk9aI([In] object obj0, [In] object obj1) => ((IFilePreviewService) obj0).GetTextPreviewSize((BinaryFile) obj1);

    internal static object cG15MhGC2mIuJpJVaGnx([In] object obj0, [In] object obj1) => (object) ((IFilePreviewService) obj0).GetTextPreviewPath((BinaryFile) obj1);

    internal static bool pbsE4sGCeqXMoxyLxbrP([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object XFLjUQGCPPFKlPTVmUOa(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Rc9YAsGC1XMFal4EQmND([In] object obj0) => (object) Path.GetExtension((string) obj0);

    internal static bool TSY2xTGCkcOM7Pr7AOjv() => HighlightsHelper.emxthCGCTp1dcu489TGS == null;

    internal static HighlightsHelper TsQFQWGCnpSfDL7AKUeT() => HighlightsHelper.emxthCGCTp1dcu489TGS;

    internal static object jhh0nuGCNJyuneab2GwH([In] object obj0) => (object) ((string) obj0).SanitizeHtml();

    internal static object fYgevbGC3tdDjQ9udX8n(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] RegexOptions obj3)
    {
      return (object) Regex.Replace((string) obj0, (string) obj1, (string) obj2, obj3);
    }

    internal static object hiLCSlGCphi8nXEZSS4F([In] object obj0) => (object) WebUtility.HtmlDecode((string) obj0);

    internal static object DY3AySGCamkihXSPZZeO([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object j64V3gGCDGZnufPK21hk([In] object obj0, [In] object obj1, [In] object obj2) => (object) Regex.Replace((string) obj0, (string) obj1, (string) obj2);

    internal static bool uZnKjXGCtqjp1IwgOKgj([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void VGilhaGCw25R7kclySFA([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
