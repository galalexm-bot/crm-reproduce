// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.StringParseHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using HtmlAgilityPack;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace EleWise.ELMA.Helpers
{
  public static class StringParseHelper
  {
    public const string BaseUrlPlaceHolder = "{#BaseUrl#}";
    public const string BaseUrlPlaceHolderShortAlias = "@~";
    /// <summary>Что оставлять при очестке HTML</summary>
    private static readonly Dictionary<string, string[]> ValidHtmlTags;
    internal static StringParseHelper s3GcvfhUzRMGLQ09KOy2;

    [Obsolete("Use RelativeDateTimeParser.TryParseFromDate or RelativeDateTimeParser.TryParseToDate instead", true)]
    public static bool GetDateTimeFromString(
      string str,
      bool isFrom,
      out DateTime? result,
      out string errorMessage)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (isFrom)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return RelativeDateTimeParser.TryParseToDate(str, out result, out errorMessage);
label_5:
      return RelativeDateTimeParser.TryParseFromDate(str, out result, out errorMessage);
    }

    /// <summary>Получить маску для JQuery</summary>
    /// <param name="serverMask">Серверный формат даты</param>
    /// <returns>Маска</returns>
    public static string GetJSMaskFromServer(string serverMask) => Regex.Replace(Regex.Replace(serverMask, (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(964881585 - -1459193222 ^ -1870668279), (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(~1767720452 ^ -1767828075)), (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-16752921 ^ -16518503), new MatchEvaluator(StringParseHelper.EvaluateDateTimeMask));

    /// <summary>Плодготовить правильный шаблон</summary>
    /// <param name="mask"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    public static string PrepareDateMask(string mask, string separator, string removeTemplate = null)
    {
      int num = 12;
      string[] source;
      while (true)
      {
        int index;
        Regex regex;
        switch (num)
        {
          case 1:
          case 6:
            if (StringParseHelper.mSSgcyhsbhCf0jKTZ6lW((object) source[index]) == 1)
            {
              num = 10;
              continue;
            }
            break;
          case 2:
            if (StringParseHelper.vouXmXhsG87uqHwuj55D((object) removeTemplate))
            {
              num = 8;
              continue;
            }
            goto case 7;
          case 3:
            regex = new Regex(removeTemplate);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 9;
            continue;
          case 4:
          case 5:
            if (index < source.Length)
            {
              num = 6;
              continue;
            }
            goto case 2;
          case 7:
            num = 3;
            continue;
          case 8:
          case 13:
            goto label_2;
          case 9:
            // ISSUE: reference to a compiler-generated method
            source = ((IEnumerable<string>) source).Where<string>((Func<string, bool>) (m => StringParseHelper.\u003C\u003Ec__DisplayClass4_0.rW56LivyjAYtwkGrfsgr((object) regex, (object) m))).ToArray<string>();
            num = 13;
            continue;
          case 10:
            source[index] = (string) StringParseHelper.tEd0SjhshjGCTHilhJlu((object) source[index], (object) source[index]);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
            continue;
          case 11:
            index = 0;
            num = 4;
            continue;
          case 12:
            source = (string[]) StringParseHelper.iDNdaMhsohWGX1PYICkc((object) mask, (object) new string[1]
            {
              separator
            }, StringSplitOptions.RemoveEmptyEntries);
            num = 11;
            continue;
        }
        ++index;
        num = 5;
      }
label_2:
      return string.Join(separator, source);
    }

    /// <summary>Получить идентификаторы из строки</summary>
    /// <param name="ids">Строка с идентификаторами</param>
    /// <param name="separator">Массив знаков Юникода, разделяющих идентификаторы в данной строке.
    /// Если пустой массив, не содержащий разделителей, или null, то в качестве разделителя используется '_'.</param>
    /// <returns>Массив идентификаторов</returns>
    public static long[] GetIdsFromString(string ids, params char[] separator)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (separator != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_7;
          case 3:
            separator = new char[1]{ '_' };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 2 : 2;
            continue;
          default:
            if (separator.Length == 0)
            {
              num = 3;
              continue;
            }
            goto label_7;
        }
      }
label_7:
      object source = StringParseHelper.LcQ18PhsElJ3lwaMwDx6((object) ids, (object) separator);
      // ISSUE: reference to a compiler-generated field
      Func<string, long> func = StringParseHelper.\u003C\u003Ec.\u003C\u003E9__5_0;
      Func<string, long> selector;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        StringParseHelper.\u003C\u003Ec.\u003C\u003E9__5_0 = selector = (Func<string, long>) (i => StringParseHelper.\u003C\u003Ec.p8UZ94vycxf2Uafl8Rug((object) i));
      }
      else
        goto label_8;
label_10:
      return ((IEnumerable<string>) source).Select<string, long>(selector).ToArray<long>();
label_8:
      selector = func;
      goto label_10;
    }

    /// <summary>Получить только body из html</summary>
    /// <param name="source"></param>
    /// <returns></returns>
    public static string GetClearBodyFromHtml(this string source)
    {
      int num1 = 4;
      string str;
      HtmlDocument html;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            str = (string) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 1;
            continue;
          case 3:
            if (html != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 2 : 2;
              continue;
            }
            goto label_2;
          case 4:
            html = StringParseHelper.GetHtml((object) source);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 3;
            continue;
          case 5:
            goto label_2;
          default:
            goto label_19;
        }
      }
label_2:
      return string.Empty;
label_4:
      try
      {
        HtmlNode htmlNode = ((HtmlNode) StringParseHelper.akJLOrhsfnAfcF3XxGe1((object) html)).SelectSingleNode((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-138018305 ^ -138039965));
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
          num2 = 0;
        while (true)
        {
          object obj;
          switch (num2)
          {
            case 1:
              if (htmlNode == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
                continue;
              }
              obj = StringParseHelper.LjeEd9hsQkpHbIsoMTKt((object) htmlNode);
              break;
            case 2:
              goto label_19;
            default:
              obj = (object) source;
              break;
          }
          str = (string) obj;
          num2 = 2;
        }
      }
      catch (Exception ex)
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              ((ILogger) StringParseHelper.jy74wYhsCbommOGrOIIq()).Error(StringParseHelper.CeOM9YhsvRhD2xjEQx2A((object) ex), ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
              continue;
            default:
              goto label_19;
          }
        }
      }
label_19:
      return (string) StringParseHelper.bYWaIrhs8ybmaEnDBMcG((object) str);
    }

    /// <summary>
    /// Добавляет домен для ссылок (чтобы правильно импортировалось)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="prefix"></param>
    /// <returns></returns>
    public static string SetFullPathForImg(this string source, string prefix)
    {
      int num = 3;
      HtmlDocument htmlDocument;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (htmlDocument != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
              continue;
            }
            goto label_3;
          case 3:
            htmlDocument = (HtmlDocument) StringParseHelper.f6PCNHhsZ2UeFBQPKne4((object) source);
            num = 2;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return string.Empty;
label_4:
      object obj = StringParseHelper.akJLOrhsfnAfcF3XxGe1((object) htmlDocument);
      StringParseHelper.feJs8whsuh9t0xPY4Nxm(obj, (object) prefix);
      return (string) StringParseHelper.LjeEd9hsQkpHbIsoMTKt(obj);
    }

    /// <summary>Очистка HTML от тегов по белому листу</summary>
    /// <param name="source"></param>
    /// <returns></returns>
    public static string SanitizeHtml(this string source)
    {
      int num1 = 4;
      HtmlNode node;
      string[] array1;
      Dictionary<string, string[]>.Enumerator enumerator1;
      HtmlDocument htmlDocument;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_39;
          case 2:
            goto label_40;
          case 3:
            if (htmlDocument != null)
            {
              node = (HtmlNode) StringParseHelper.akJLOrhsfnAfcF3XxGe1((object) htmlDocument);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 7 : 2;
              continue;
            }
            num1 = 2;
            continue;
          case 4:
            htmlDocument = (HtmlDocument) StringParseHelper.f6PCNHhsZ2UeFBQPKne4((object) source);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 3;
            continue;
          case 5:
            enumerator1 = StringParseHelper.ValidHtmlTags.GetEnumerator();
            num1 = 6;
            continue;
          case 6:
            goto label_3;
          case 7:
            array1 = StringParseHelper.ValidHtmlTags.Select<KeyValuePair<string, string[]>, string>((Func<KeyValuePair<string, string[]>, string>) (kv => kv.Key)).ToArray<string>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          default:
            StringParseHelper.CleanNodes((object) node, (object) array1);
            num1 = 5;
            continue;
        }
      }
label_3:
      try
      {
label_28:
        if (enumerator1.MoveNext())
          goto label_32;
        else
          goto label_29;
label_4:
        KeyValuePair<string, string[]> current1;
        IEnumerator<HtmlNode> enumerator2;
        int num2;
        KeyValuePair<string, string[]> tag1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 2 : 5;
              continue;
            case 2:
              goto label_6;
            case 3:
              goto label_28;
            case 4:
              goto label_39;
            case 5:
              tag1 = current1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
              continue;
            case 6:
              goto label_32;
            default:
              // ISSUE: reference to a compiler-generated method
              enumerator2 = node.DescendantsAndSelf().Where<HtmlNode>((Func<HtmlNode, bool>) (n => StringParseHelper.\u003C\u003Ec__DisplayClass9_0.uqQ6rpvMGr8n7goxF9w6((object) n.Name, (object) tag1.Key))).GetEnumerator();
              num2 = 2;
              continue;
          }
        }
label_6:
        try
        {
label_12:
          if (enumerator2.MoveNext())
            goto label_10;
          else
            goto label_13;
label_7:
          HtmlAttribute htmlAttribute;
          HtmlNode current2;
          HtmlAttribute[] array2;
          int index;
          int num3;
          while (true)
          {
            switch (num3)
            {
              case 1:
              case 11:
                htmlAttribute = array2[index];
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 5 : 0;
                continue;
              case 2:
              case 9:
                ++index;
                num3 = 4;
                continue;
              case 3:
                goto label_10;
              case 5:
                if (((IEnumerable<string>) current1.Value).Contains<string>((string) StringParseHelper.LHYuMThsS3j15OlfqXOL((object) htmlAttribute)))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 2 : 0;
                  continue;
                }
                goto case 6;
              case 6:
                StringParseHelper.gK9khehsiQG8rvIUDVO1((object) htmlAttribute);
                num3 = 9;
                continue;
              case 7:
              case 14:
                goto label_12;
              case 8:
                if (!StringParseHelper.Fp85EphsI6mfnUbLgegG((object) current2))
                {
                  num3 = 7;
                  continue;
                }
                goto case 13;
              case 10:
                goto label_28;
              case 12:
                index = 0;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
                continue;
              case 13:
                array2 = ((IEnumerable<HtmlAttribute>) StringParseHelper.Q4xKHfhsVt8tWWVVpK06((object) current2)).ToArray<HtmlAttribute>();
                num3 = 12;
                continue;
              default:
                if (index < array2.Length)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
                  continue;
                }
                goto label_12;
            }
          }
label_10:
          current2 = enumerator2.Current;
          num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
          {
            num3 = 8;
            goto label_7;
          }
          else
            goto label_7;
label_13:
          num3 = 10;
          goto label_7;
        }
        finally
        {
          int num4;
          if (enumerator2 == null)
            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
          else
            goto label_26;
label_25:
          switch (num4)
          {
            case 1:
              break;
            default:
          }
label_26:
          StringParseHelper.X3HOKjhsRJMn5ynnRi4j((object) enumerator2);
          num4 = 2;
          goto label_25;
        }
label_29:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 4 : 4;
        goto label_4;
label_32:
        current1 = enumerator1.Current;
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
        {
          num2 = 1;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        enumerator1.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
label_39:
      return (string) StringParseHelper.LjeEd9hsQkpHbIsoMTKt((object) node);
label_40:
      return string.Empty;
    }

    /// <summary>
    /// Подготовить текст к выводу - обернуть все ссылки в тэг "a",
    /// так же распарсить системные ссылки {#BaseUrl#}/ и ~/
    /// </summary>
    /// <param name="source">Текст для разбора</param>
    /// <param name="applicationBaseUrl">Базовый URL системы, если не задан попытаемся взять из настроек</param>
    /// <returns></returns>
    public static string PrepareHtmlHref(this string source, string applicationBaseUrl = null)
    {
      int num1 = 1;
      HtmlDocument htmlDocument;
      while (true)
      {
        int num2 = num1;
        CommonSettingsModule service;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!StringParseHelper.VgpdprhsqvulPRn6e8C6((object) source))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
                continue;
              }
              goto label_8;
            case 2:
              service = Locator.GetService<CommonSettingsModule>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 10 : 2;
              continue;
            case 3:
            case 4:
            case 9:
              goto label_15;
            case 5:
              goto label_8;
            case 6:
              goto label_3;
            case 7:
              if (!StringParseHelper.xIybkZhsK92sDpReVW7P())
              {
                num2 = 9;
                continue;
              }
              goto case 2;
            case 8:
              applicationBaseUrl = (string) StringParseHelper.vKugshhsXFeYleIpgm9H((object) service.Settings);
              num2 = 3;
              continue;
            case 10:
              if (service == null)
              {
                num2 = 4;
                continue;
              }
              goto case 8;
            case 11:
              if (htmlDocument.ParseErrors.Any<HtmlParseError>())
              {
                num2 = 6;
                continue;
              }
              goto label_4;
            case 12:
              if (htmlDocument != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 11 : 11;
                continue;
              }
              goto label_3;
            default:
              goto label_9;
          }
        }
label_4:
        if (string.IsNullOrWhiteSpace(applicationBaseUrl))
        {
          num1 = 7;
          continue;
        }
        goto label_15;
label_9:
        htmlDocument = (HtmlDocument) StringParseHelper.f6PCNHhsZ2UeFBQPKne4((object) source.Trim());
        num1 = 12;
      }
label_3:
      return source;
label_8:
      return (string) null;
label_15:
      HtmlNode documentNode = htmlDocument.DocumentNode;
      StringParseHelper.OxR86JhsTXowaotRQ0bO((object) documentNode, (object) applicationBaseUrl);
      return documentNode.OuterHtml;
    }

    /// <summary>
    /// Заменить <see cref="F:EleWise.ELMA.Helpers.StringParseHelper.BaseUrlPlaceHolder" /> на базовый URL системы, переданный в параметре или полученный из настроек
    /// </summary>
    /// <param name="source">Исходная строка</param>
    /// <param name="applicationBaseUrl">Базовый URL</param>
    /// <returns></returns>
    public static string FormatWithBaseUrl(this string source, string applicationBaseUrl = null)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        CommonSettingsModule service;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (StringParseHelper.VgpdprhsqvulPRn6e8C6((object) applicationBaseUrl))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 4 : 5;
                continue;
              }
              goto label_15;
            case 2:
              if (!StringParseHelper.VgpdprhsqvulPRn6e8C6((object) source))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
                continue;
              }
              goto label_3;
            case 3:
              applicationBaseUrl = (string) StringParseHelper.vKugshhsXFeYleIpgm9H((object) service.Settings);
              num2 = 4;
              continue;
            case 4:
              goto label_15;
            case 5:
              if (StringParseHelper.xIybkZhsK92sDpReVW7P())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 5 : 7;
                continue;
              }
              goto label_15;
            case 6:
              goto label_3;
            case 7:
              service = Locator.GetService<CommonSettingsModule>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            case 8:
              goto label_9;
            default:
              if (service != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 2 : 3;
                continue;
              }
              goto label_15;
          }
        }
label_15:
        source = (string) StringParseHelper.SI77ZthskLeBds0sHEHE((object) source, StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-542721635 ^ -542752999), (object) applicationBaseUrl);
        num1 = 8;
      }
label_3:
      return (string) null;
label_9:
      return source;
    }

    private static void PrepareHtmlNodeHref(object node, object applicationBaseUrl)
    {
      int num1 = 1;
      IEnumerator<HtmlNode> enumerator;
      string applicationBaseUrl1;
      while (true)
      {
        string str;
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          case 2:
            if (StringParseHelper.DeYoU5hsPc7CtthEI6oy(StringParseHelper.NdIaMvhse3V7gaAxwgaq(node)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 6 : 9;
              continue;
            }
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            str = (string) StringParseHelper.zqLX4ths1V4Pq5snKrsC(StringParseHelper.NdIaMvhse3V7gaAxwgaq(node), StringParseHelper.OmYS1BhsWb0wBI0xxv7p(874012245 ^ 874246887), (object) (MatchEvaluator) (match => (string) StringParseHelper.\u003C\u003Ec.wfiCPrvMBXbk1lHxVIZH(StringParseHelper.\u003C\u003Ec.LFNOnjvyzc5T1jn7XFRu(132912447 ^ 132735187), StringParseHelper.\u003C\u003Ec.aPhVDOvMFpf2nw9T0S7R((object) match))), RegexOptions.IgnoreCase);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 11 : 8;
            continue;
          case 3:
            ((HtmlNode) node).InnerHtml = str;
            num1 = 13;
            continue;
          case 4:
            goto label_20;
          case 5:
            goto label_27;
          case 6:
            goto label_10;
          case 7:
            goto label_4;
          case 8:
            if (StringParseHelper.CLAjxIhsnRXfsr5H4njl(node) == HtmlNodeType.Comment)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 2 : 5;
              continue;
            }
            if (StringParseHelper.CLAjxIhsnRXfsr5H4njl(node) == HtmlNodeType.Element)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 4 : 10;
              continue;
            }
            break;
          case 9:
            goto label_32;
          case 10:
            if (StringParseHelper.DXLKNEhs205cERRMeQsN(StringParseHelper.mVdNFphsO4Ky0Gjj8ceE(node), StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1217523399 ^ -1217602893), StringComparison.InvariantCultureIgnoreCase))
            {
              num1 = 7;
              continue;
            }
            break;
          case 11:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            str = (string) StringParseHelper.zqLX4ths1V4Pq5snKrsC((object) str, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272385115), (object) (MatchEvaluator) (match => string.Format((string) StringParseHelper.\u003C\u003Ec__DisplayClass12_0.TSuoB2vMCr6FYywMagTo(572119659 - -337058038 ^ 909140339), StringParseHelper.\u003C\u003Ec__DisplayClass12_0.EW3VSIvMvelv2PgYthoX((object) match), (object) ((string) StringParseHelper.\u003C\u003Ec__DisplayClass12_0.ckUS7svM8wucSDNOCMVR(StringParseHelper.\u003C\u003Ec__DisplayClass12_0.EW3VSIvMvelv2PgYthoX((object) match), StringParseHelper.\u003C\u003Ec__DisplayClass12_0.TSuoB2vMCr6FYywMagTo(~-397266137 ^ 396892760), (object) "")).ValueOrDefaultWhiteSpace(applicationBaseUrl1, z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654280915)))), RegexOptions.IgnoreCase);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 11 : 12;
            continue;
          case 12:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            str = (string) StringParseHelper.zqLX4ths1V4Pq5snKrsC((object) str, StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1867198571 ^ -1867030007), (object) (MatchEvaluator) (match => (string) StringParseHelper.\u003C\u003Ec__DisplayClass12_0.oTAUIpvMIbvmcGPVwEVJ(StringParseHelper.\u003C\u003Ec__DisplayClass12_0.TSuoB2vMCr6FYywMagTo(1012087039 ^ 1012116205), StringParseHelper.\u003C\u003Ec__DisplayClass12_0.UAD6ERvMuw48Oem6TW8d(StringParseHelper.\u003C\u003Ec__DisplayClass12_0.TSuoB2vMCr6FYywMagTo(-1858887263 ^ -1858918619), StringParseHelper.\u003C\u003Ec__DisplayClass12_0.QVh0o0vMZaO282Hk24Ys(StringParseHelper.\u003C\u003Ec__DisplayClass12_0.EW3VSIvMvelv2PgYthoX((object) match), 0, 2)), (object) ((string) StringParseHelper.\u003C\u003Ec__DisplayClass12_0.QVh0o0vMZaO282Hk24Ys(StringParseHelper.\u003C\u003Ec__DisplayClass12_0.EW3VSIvMvelv2PgYthoX((object) match), 0, 3)).ValueOrDefaultWhiteSpace(applicationBaseUrl1, (string) StringParseHelper.\u003C\u003Ec__DisplayClass12_0.TSuoB2vMCr6FYywMagTo(-281842504 ^ -281858254)))), RegexOptions.IgnoreCase);
            num1 = 3;
            continue;
          case 13:
            goto label_3;
          default:
            applicationBaseUrl1 = (string) applicationBaseUrl;
            num1 = 8;
            continue;
        }
        if (((HtmlNode) node).NodeType != HtmlNodeType.Text)
        {
          enumerator = ((IEnumerable<HtmlNode>) StringParseHelper.v0L2quhsNl2NfUAIHrhN(node)).GetEnumerator();
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 4 : 6;
        }
        else
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 2;
      }
label_20:
      return;
label_27:
      return;
label_4:
      return;
label_32:
      return;
label_3:
      return;
label_10:
      try
      {
label_13:
        if (StringParseHelper.Urtrirhs3FU8G9CSnrBp((object) enumerator))
          goto label_12;
        else
          goto label_14;
label_11:
        int num2;
        switch (num2)
        {
          case 1:
            return;
          case 2:
            goto label_13;
        }
label_12:
        StringParseHelper.PrepareHtmlNodeHref((object) enumerator.Current, (object) applicationBaseUrl1);
        num2 = 2;
        goto label_11;
label_14:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
        goto label_11;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                StringParseHelper.X3HOKjhsRJMn5ynnRi4j((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
                continue;
              default:
                goto label_22;
            }
          }
        }
label_22:;
      }
    }

    private static void SetFullPathForImgNode(object node, object prefix)
    {
      int num1 = 14;
      IEnumerator<HtmlNode> enumerator;
      while (true)
      {
        int num2 = num1;
        HtmlAttribute htmlAttribute1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              StringParseHelper.VThQDfhstJR02eJJLpF4((object) htmlAttribute1, (object) string.Format((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1218962250 ^ 1218916768), prefix, StringParseHelper.ymDkAshsagLZD2JneXiR((object) htmlAttribute1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 2 : 5;
              continue;
            case 2:
            case 3:
            case 5:
              if (!StringParseHelper.SflNjbhswwv0aFiiwSxW(node))
              {
                num2 = 11;
                continue;
              }
              goto case 4;
            case 4:
              enumerator = ((IEnumerable<HtmlNode>) StringParseHelper.v0L2quhsNl2NfUAIHrhN(node)).GetEnumerator();
              num2 = 8;
              continue;
            case 6:
              if (htmlAttribute1 != null)
              {
                num2 = 7;
                continue;
              }
              goto case 2;
            case 7:
              if (((string) StringParseHelper.ymDkAshsagLZD2JneXiR((object) htmlAttribute1)).IndexOf((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(901793403 ^ 902031481), StringComparison.OrdinalIgnoreCase) >= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 2 : 1;
                continue;
              }
              goto case 10;
            case 8:
              goto label_3;
            case 9:
              if (!StringParseHelper.cfVbGZhspHpspjrsEoUR(StringParseHelper.Q4xKHfhsVt8tWWVVpK06(node), StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1839087379 - 334718690 ^ 2121136115)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
                continue;
              }
              goto label_35;
            case 10:
              if (StringParseHelper.MGFNjBhsDD0Bh0vKJIod(StringParseHelper.ymDkAshsagLZD2JneXiR((object) htmlAttribute1), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998382806), StringComparison.OrdinalIgnoreCase) < 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 0;
                continue;
              }
              goto case 2;
            case 11:
              goto label_33;
            case 12:
              goto label_18;
            case 13:
              if (!StringParseHelper.DXLKNEhs205cERRMeQsN(StringParseHelper.mVdNFphsO4Ky0Gjj8ceE(node), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35999331), StringComparison.OrdinalIgnoreCase))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 3 : 1;
                continue;
              }
              goto case 9;
            case 14:
              if (((HtmlNode) node).NodeType != HtmlNodeType.Element)
                goto case 2;
              else
                goto label_17;
            default:
              goto label_34;
          }
        }
label_17:
        num1 = 13;
        continue;
label_34:
        HtmlAttribute htmlAttribute2 = (HtmlAttribute) null;
        goto label_36;
label_35:
        htmlAttribute2 = ((HtmlAttributeCollection) StringParseHelper.Q4xKHfhsVt8tWWVVpK06(node))[(string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1149433385 + 173655049 ^ 1323243466)];
label_36:
        htmlAttribute1 = htmlAttribute2;
        num1 = 6;
      }
label_33:
      return;
label_18:
      return;
label_3:
      try
      {
label_5:
        if (enumerator.MoveNext())
          goto label_7;
        else
          goto label_6;
label_4:
        int num3;
        switch (num3)
        {
          case 1:
            goto label_5;
          case 2:
            return;
          default:
            goto label_7;
        }
label_6:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 2 : 1;
        goto label_4;
label_7:
        StringParseHelper.feJs8whsuh9t0xPY4Nxm((object) enumerator.Current, prefix);
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
        {
          num3 = 1;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                StringParseHelper.X3HOKjhsRJMn5ynnRi4j((object) enumerator);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                continue;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
    }

    private static void CleanNodes(object node, object whitelist)
    {
      int num = 8;
      while (true)
      {
        HtmlNodeCollection newChildren;
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            StringParseHelper.XFmeMnhs6F1ALE6tGdW6(node, whitelist, (object) newChildren);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          case 3:
            newChildren = new HtmlNodeCollection((HtmlNode) StringParseHelper.yNAr3Dhs4EyCHohstmGq(node));
            num = 2;
            continue;
          case 4:
            StringParseHelper.CleanChildren(node, whitelist);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
            continue;
          case 5:
            goto label_3;
          case 6:
            StringParseHelper.PZP6PPhsHLVhVkq8YiLR((object) ((HtmlNode) node).ParentNode, node);
            num = 5;
            continue;
          case 7:
            if (!((IEnumerable<string>) whitelist).Contains<string>(((HtmlNode) node).Name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 3 : 0;
              continue;
            }
            break;
          case 8:
            if (StringParseHelper.CLAjxIhsnRXfsr5H4njl(node) == HtmlNodeType.Element)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 7 : 7;
              continue;
            }
            break;
          default:
            ((HtmlNode) StringParseHelper.yNAr3Dhs4EyCHohstmGq(node)).AppendChildren(newChildren);
            num = 6;
            continue;
        }
        if (((HtmlNode) node).HasChildNodes)
          num = 4;
        else
          goto label_15;
      }
label_2:
      return;
label_3:
      return;
label_15:;
    }

    private static void CleanChildren(object parent, object whitelist)
    {
      int num = 1;
      int index;
      while (true)
      {
        switch (num)
        {
          case 1:
            index = StringParseHelper.vswwpehsAl7ktWvyFHwQ(StringParseHelper.v0L2quhsNl2NfUAIHrhN(parent)) - 1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
            continue;
          case 2:
            StringParseHelper.xdq3ephs7BsRMrFe3LNK((object) ((HtmlNodeCollection) StringParseHelper.v0L2quhsNl2NfUAIHrhN(parent))[index], whitelist);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 4 : 0;
            continue;
          case 4:
            --index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 2 : 3;
            continue;
          case 5:
            goto label_6;
          default:
            if (index < 0)
            {
              num = 5;
              continue;
            }
            goto case 2;
        }
      }
label_6:;
    }

    private static void GetNodes(object node, object whitelist, object htmlNodes)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (StringParseHelper.CLAjxIhsnRXfsr5H4njl(node) == HtmlNodeType.Element)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 2:
            StringParseHelper.XFmeMnhs6F1ALE6tGdW6(node, whitelist, htmlNodes);
            num = 3;
            continue;
          case 3:
            goto label_9;
          case 4:
          case 6:
            if (StringParseHelper.SflNjbhswwv0aFiiwSxW(node))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 2;
              continue;
            }
            goto label_2;
          case 5:
            StringParseHelper.gSN5oDhsxjUieTL6grJa(htmlNodes, node);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 4 : 4;
            continue;
          default:
            if (!((IEnumerable<string>) whitelist).Contains<string>(((HtmlNode) node).Name))
            {
              num = 6;
              continue;
            }
            goto case 5;
        }
      }
label_9:
      return;
label_2:;
    }

    private static void GetChildren(object node, object whitelist, object htmlNodes)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              ++num3;
              num2 = 6;
              continue;
            case 3:
            case 6:
              goto label_6;
            case 4:
              num3 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 3 : 3;
              continue;
            default:
              StringParseHelper.P9LjIEhsmIdxAmnVNNhK(StringParseHelper.PLTpKnhs0PcpYCaEAIDb(StringParseHelper.v0L2quhsNl2NfUAIHrhN(node), num3), whitelist, htmlNodes);
              num2 = 2;
              continue;
          }
        }
label_6:
        if (num3 < ((HtmlNodeCollection) StringParseHelper.v0L2quhsNl2NfUAIHrhN(node)).Count)
          num1 = 5;
        else
          goto label_3;
      }
label_5:
      return;
label_3:;
    }

    private static HtmlDocument GetHtml(object source)
    {
      HtmlDocument html = new HtmlDocument();
      html.OptionFixNestedTags = true;
      html.OptionAutoCloseOnEnd = true;
      html.OptionDefaultStreamEncoding = (Encoding) StringParseHelper.MVWAK2hsyrlKGlkKqoQq();
      StringParseHelper.cYQSdchsM1KN6WadIebv((object) html, source);
      return html;
    }

    private static string EvaluateDateTimeMask(object match)
    {
      int num = 1;
      int repetitionsCount;
      while (true)
      {
        switch (num)
        {
          case 1:
            repetitionsCount = StringParseHelper.mSSgcyhsbhCf0jKTZ6lW(StringParseHelper.VamJLVhsJmuN9i7f2EmG(match)) - 2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            if (repetitionsCount != 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 2;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return (string) StringParseHelper.LxD5Rmhs9TFVuuc93unF((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021554943), repetitionsCount);
label_6:
      return z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917103274);
    }

    static StringParseHelper()
    {
      int num1 = 29;
      while (true)
      {
        int num2 = num1;
        Dictionary<string, string[]> dictionary;
        while (true)
        {
          switch (num2)
          {
            case 1:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-35995181 ^ -36031421), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-2107978722 ^ -2108124670),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1867198571 ^ -1867030093)
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 27 : 21;
              continue;
            case 2:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-630932142 - 1120244082 ^ -1751349898), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1334993905 ^ -1334853101),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1822890472 ^ -1822734274)
              });
              num2 = 20;
              continue;
            case 3:
              StringParseHelper.ValidHtmlTags = dictionary;
              num2 = 14;
              continue;
            case 4:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-2092274397 << 4 ^ 883300584), new string[3]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1514961705 ^ 1515070773),
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397304574),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1317790512 ^ -1317555484)
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 17 : 7;
              continue;
            case 5:
              dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70042002), new string[10]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(2008901894 << 3 ^ -1108797908),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-882126494 ^ -882344124),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-630932142 - 1120244082 ^ -1751349736),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-675505729 ^ -675334409),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1218962250 ^ 1218726930),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1350312861 << 3 ^ 2082294910),
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239536816),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-867826612 ^ -867849412),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(589593376 ^ -1977315327 ^ -1459403615),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(222162814 ^ 222278324)
              });
              num2 = 19;
              continue;
            case 6:
              dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112808202), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1253244298 - 1829393894 ^ -575997512),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-882126494 ^ -882344124)
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 8 : 4;
              continue;
            case 7:
              dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459445139), new string[3]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-649342099 - -1150814748 ^ 501318549),
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082295102),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1598106783 - -968262081 ^ -629736752)
              });
              num2 = 9;
              continue;
            case 8:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1925118608 << 2 ^ -889699288), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1470998129 - 231418599 ^ 1239426454),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1142330761 ^ 1541959139 ^ 536696396)
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 4 : 22;
              continue;
            case 9:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1290212282 ^ -644262414 ^ 1786910278), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1470998129 - 231418599 ^ 1239426454),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1120607109 - 305487170 ^ -1426314977)
              });
              num2 = 12;
              continue;
            case 10:
              goto label_26;
            case 11:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(323422137 << 2 ^ 1293922798), new string[2]
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 235960275),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1669371371 ^ 1669544909)
              });
              num2 = 38;
              continue;
            case 12:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(44884861 ^ 45042819), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1470998129 - 231418599 ^ 1239426454),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1178210108 ^ 1178181914)
              });
              num2 = 13;
              continue;
            case 13:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-812025778 ^ -811939772), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(132912447 ^ 133057315),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1858887263 ^ -1859121273)
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 35;
              continue;
            case 14:
              goto label_3;
            case 15:
              goto label_45;
            case 16:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-867826612 ^ -867849554), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-87337865 ^ -87487893),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-542721635 ^ -542828613)
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 39 : 19;
              continue;
            case 17:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-218496594 ^ -218517524), new string[3]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-2138958856 ^ -2139075100),
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811936152),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-867826612 ^ -867849608)
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
              continue;
            case 18:
              dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195786931), new string[2]
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917148310),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-477139494 ^ -477314052)
              });
              num2 = 6;
              continue;
            case 19:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1178210108 ^ 1178333662), new string[2]
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538671606),
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77777449)
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 33 : 23;
              continue;
            case 20:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1872275253 >> 6 ^ -29215747), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1654249598 >> 2 ^ 413411331),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-606654180 ^ -606822598)
              });
              num2 = 32;
              continue;
            case 21:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1824388195 ^ -1824414361), new string[2]
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487266182),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1837662597 ^ -1837838243)
              });
              num2 = 23;
              continue;
            case 22:
              dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333566564), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1470440286 ^ 1470594370),
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998382820)
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 11 : 30;
              continue;
            case 23:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1334993905 ^ -1334955251), new string[2]
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901912679),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(~210725948 ^ -210551323)
              });
              num2 = 11;
              continue;
            case 24:
              dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 902031605), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1217523399 ^ -1217638619),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(813604817 ^ 813511159)
              });
              num2 = 2;
              continue;
            case 25:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1574260816 ^ 1574371278), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1839087379 - 334718690 ^ 2121008151),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(--1867379187 ^ 1867407317)
              });
              num2 = 10;
              continue;
            case 26:
              dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323242636), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1319452732 ^ 1319575072),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1852837372 ^ -1853072350)
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 15 : 0;
              continue;
            case 27:
              dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889699172), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-16752921 ^ -16645893),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-542721635 ^ -542828613)
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 16 : 16;
              continue;
            case 28:
              dictionary = new Dictionary<string, string[]>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 4 : 2;
              continue;
            case 29:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 28 : 21;
              continue;
            case 30:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1149433385 + 173655049 ^ 1323242572), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1088304168 ^ -1088186940),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(381945751 ^ 1158627804 ^ 1405675629)
              });
              num2 = 40;
              continue;
            case 31:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1149433385 + 173655049 ^ 1323200952), new string[4]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1426456882 ^ 2009939514 ^ -583622936),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(132912447 ^ 133151513),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-105199646 ^ -105289524),
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108071132)
              });
              num2 = 5;
              continue;
            case 32:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(864270449 << 6 ^ -521387588), new string[5]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1255365154 ^ 596875508 ^ -1765973194),
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306688642),
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672143134),
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561183806),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(979449278 ^ 979540748)
              });
              num2 = 26;
              continue;
            case 33:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-688192331 - 435440695 ^ -1123739666), new string[2]
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536651382),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-710283084 ^ -537863435 ^ 173704295)
              });
              num2 = 25;
              continue;
            case 34:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-16752921 ^ -16518849), new string[3]
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70149871),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-951514650 ^ -951408704),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1654249598 >> 2 ^ 413522431)
              });
              num2 = 7;
              continue;
            case 35:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(874012245 ^ 874245705), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(964881585 - -1459193222 ^ -1870779349),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1051276242 - 990076387 ^ 61242313)
              });
              num2 = 36;
              continue;
            case 36:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(874012245 ^ 874245747), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(--1418440330 ^ 1418326166),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1921202237 ^ -1921029659)
              });
              num2 = 42;
              continue;
            case 37:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1872275253 >> 6 ^ -29216077), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(964881585 - -1459193222 ^ -1870779349),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1994213607 >> 4 ^ 124680872)
              });
              num2 = 34;
              continue;
            case 38:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-2112703338 ^ -2112808012), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-951514650 ^ -951363590),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-35995181 ^ -36081675)
              });
              num2 = 31;
              continue;
            case 39:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1581325282 << 3 ^ -234130974), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(381945751 ^ 1158627804 ^ 1405687895),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(694673736 ^ -23604109 ^ -671900899)
              });
              num2 = 21;
              continue;
            case 40:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1669371371 ^ 1669544813), new string[2]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(44884861 ^ 45006177),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-1876063057 ^ -1876024695)
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 24 : 24;
              continue;
            case 41:
              dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515181565), new string[2]
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 45006177),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(~-306453669 ^ 306688642)
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
              continue;
            case 42:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(647913418 ^ 647884794), new string[2]
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542840959),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(322893104 - -1992822529 ^ -1979405801)
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 3 : 1;
              continue;
            case 43:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-35995181 ^ -36082071), new string[3]
              {
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1819636893 << 3 ^ 1672084212),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1925118608 << 2 ^ -889699226),
                (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(381945751 ^ 1158627804 ^ 1405675913)
              });
              num2 = 37;
              continue;
            default:
              dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(-812025778 ^ -811936254), new string[2]
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575997512),
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978564908)
              });
              num2 = 18;
              continue;
          }
        }
label_26:
        dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146484081), new string[2]
        {
          (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(92412609 - 1050237057 ^ -957703076),
          (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1669212571 ^ 1669171133)
        });
        num1 = 43;
        continue;
label_45:
        dictionary.Add((string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(694673736 ^ -23604109 ^ -671900683), new string[2]
        {
          (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1149433385 + 173655049 ^ 1323230254),
          (string) StringParseHelper.OmYS1BhsWb0wBI0xxv7p(1461625753 ^ 1461521855)
        });
        num1 = 41;
      }
label_3:;
    }

    internal static bool fbuJa4hsFJTQxHqQ1X2I() => StringParseHelper.s3GcvfhUzRMGLQ09KOy2 == null;

    internal static StringParseHelper TcJROIhsBi1jNPDa85Pj() => StringParseHelper.s3GcvfhUzRMGLQ09KOy2;

    internal static object OmYS1BhsWb0wBI0xxv7p(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object iDNdaMhsohWGX1PYICkc([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((string[]) obj1, obj2);

    internal static int mSSgcyhsbhCf0jKTZ6lW([In] object obj0) => ((string) obj0).Length;

    internal static object tEd0SjhshjGCTHilhJlu([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool vouXmXhsG87uqHwuj55D([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object LcQ18PhsElJ3lwaMwDx6([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static object akJLOrhsfnAfcF3XxGe1([In] object obj0) => (object) ((HtmlDocument) obj0).DocumentNode;

    internal static object LjeEd9hsQkpHbIsoMTKt([In] object obj0) => (object) ((HtmlNode) obj0).InnerHtml;

    internal static object jy74wYhsCbommOGrOIIq() => (object) Logger.Log;

    internal static object CeOM9YhsvRhD2xjEQx2A([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static object bYWaIrhs8ybmaEnDBMcG([In] object obj0) => (object) ((string) obj0).SanitizeHtml();

    internal static object f6PCNHhsZ2UeFBQPKne4([In] object obj0) => (object) StringParseHelper.GetHtml(obj0);

    internal static void feJs8whsuh9t0xPY4Nxm([In] object obj0, [In] object obj1) => StringParseHelper.SetFullPathForImgNode(obj0, obj1);

    internal static bool Fp85EphsI6mfnUbLgegG([In] object obj0) => ((HtmlNode) obj0).HasAttributes;

    internal static object Q4xKHfhsVt8tWWVVpK06([In] object obj0) => (object) ((HtmlNode) obj0).Attributes;

    internal static object LHYuMThsS3j15OlfqXOL([In] object obj0) => (object) ((HtmlAttribute) obj0).Name;

    internal static void gK9khehsiQG8rvIUDVO1([In] object obj0) => ((HtmlAttribute) obj0).Remove();

    internal static void X3HOKjhsRJMn5ynnRi4j([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool VgpdprhsqvulPRn6e8C6([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static bool xIybkZhsK92sDpReVW7P() => Locator.Initialized;

    internal static object vKugshhsXFeYleIpgm9H([In] object obj0) => (object) ((CommonSettings) obj0).ApplicationBaseUrl;

    internal static void OxR86JhsTXowaotRQ0bO([In] object obj0, [In] object obj1) => StringParseHelper.PrepareHtmlNodeHref(obj0, obj1);

    internal static object SI77ZthskLeBds0sHEHE([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static HtmlNodeType CLAjxIhsnRXfsr5H4njl([In] object obj0) => ((HtmlNode) obj0).NodeType;

    internal static object mVdNFphsO4Ky0Gjj8ceE([In] object obj0) => (object) ((HtmlNode) obj0).Name;

    internal static bool DXLKNEhs205cERRMeQsN([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static object NdIaMvhse3V7gaAxwgaq([In] object obj0) => (object) ((HtmlNode) obj0).InnerText;

    internal static bool DeYoU5hsPc7CtthEI6oy([In] object obj0) => ((string) obj0).IsNullOrWhiteSpace();

    internal static object zqLX4ths1V4Pq5snKrsC(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] RegexOptions obj3)
    {
      return (object) Regex.Replace((string) obj0, (string) obj1, (MatchEvaluator) obj2, obj3);
    }

    internal static object v0L2quhsNl2NfUAIHrhN([In] object obj0) => (object) ((HtmlNode) obj0).ChildNodes;

    internal static bool Urtrirhs3FU8G9CSnrBp([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool cfVbGZhspHpspjrsEoUR([In] object obj0, [In] object obj1) => ((HtmlAttributeCollection) obj0).Contains((string) obj1);

    internal static object ymDkAshsagLZD2JneXiR([In] object obj0) => (object) ((HtmlAttribute) obj0).Value;

    internal static int MGFNjBhsDD0Bh0vKJIod([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).IndexOf((string) obj1, obj2);

    internal static void VThQDfhstJR02eJJLpF4([In] object obj0, [In] object obj1) => ((HtmlAttribute) obj0).Value = (string) obj1;

    internal static bool SflNjbhswwv0aFiiwSxW([In] object obj0) => ((HtmlNode) obj0).HasChildNodes;

    internal static object yNAr3Dhs4EyCHohstmGq([In] object obj0) => (object) ((HtmlNode) obj0).ParentNode;

    internal static void XFmeMnhs6F1ALE6tGdW6([In] object obj0, [In] object obj1, [In] object obj2) => StringParseHelper.GetChildren(obj0, obj1, obj2);

    internal static object PZP6PPhsHLVhVkq8YiLR([In] object obj0, [In] object obj1) => (object) ((HtmlNode) obj0).RemoveChild((HtmlNode) obj1);

    internal static int vswwpehsAl7ktWvyFHwQ([In] object obj0) => ((HtmlNodeCollection) obj0).Count;

    internal static void xdq3ephs7BsRMrFe3LNK([In] object obj0, [In] object obj1) => StringParseHelper.CleanNodes(obj0, obj1);

    internal static void gSN5oDhsxjUieTL6grJa([In] object obj0, [In] object obj1) => ((HtmlNodeCollection) obj0).Append((HtmlNode) obj1);

    internal static object PLTpKnhs0PcpYCaEAIDb([In] object obj0, [In] int obj1) => (object) ((HtmlNodeCollection) obj0)[obj1];

    internal static void P9LjIEhsmIdxAmnVNNhK([In] object obj0, [In] object obj1, [In] object obj2) => StringParseHelper.GetNodes(obj0, obj1, obj2);

    internal static object MVWAK2hsyrlKGlkKqoQq() => (object) Encoding.UTF8;

    internal static void cYQSdchsM1KN6WadIebv([In] object obj0, [In] object obj1) => ((HtmlDocument) obj0).LoadHtml((string) obj1);

    internal static object VamJLVhsJmuN9i7f2EmG([In] object obj0) => (object) ((Capture) obj0).Value;

    internal static object LxD5Rmhs9TFVuuc93unF([In] object obj0, int repetitionsCount) => (object) ((string) obj0).Repeat(repetitionsCount);
  }
}
