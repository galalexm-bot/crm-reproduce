// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.LanguagesMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Globalization
{
  public class LanguagesMap
  {
    private static LanguagesMap xhvgbFGhaGy28T1blWyD;

    /// <summary>Ctor</summary>
    public LanguagesMap()
    {
      LanguagesMap.shdmmKGhwl3YZ96rCw2H();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Languages = new List<LanguageMapItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Маппинг языков</summary>
    public List<LanguageMapItem> Languages { get; set; }

    /// <summary>Получить все базовые локали</summary>
    /// <returns></returns>
    public List<CultureInfo> AllBaseCultureInfo() => this.Languages.GroupBy<LanguageMapItem, string>((Func<LanguageMapItem, string>) (l => (string) LanguagesMap.\u003C\u003Ec.mbNR18vllwEYt0nhMu6B((object) l))).Select<IGrouping<string, LanguageMapItem>, CultureInfo>((Func<IGrouping<string, LanguageMapItem>, CultureInfo>) (g =>
    {
      try
      {
        return new CultureInfo(g.Key);
      }
      catch (Exception ex)
      {
        Logger.Log.Error((object) ex.Message, ex);
      }
      return (CultureInfo) null;
    })).Where<CultureInfo>((Func<CultureInfo, bool>) (c => c != null)).ToList<CultureInfo>();

    /// <summary>Получить нулевую локаль</summary>
    /// <param name="code"></param>
    /// <returns></returns>
    public CultureInfo GetBaseCultureInfo(string code)
    {
      int num1 = 5;
      string name;
      while (true)
      {
        LanguageMapItem languageMapItem;
        object obj;
        string code1;
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            goto label_13;
          case 3:
            obj = LanguagesMap.Nb0X1yGhHXgi3w4gFZ1G((object) languageMapItem);
            break;
          case 4:
            code1 = code;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
            continue;
          case 5:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 4 : 4;
            continue;
          case 6:
            if (languageMapItem == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 1 : 1;
              continue;
            }
            if (LanguagesMap.xntObZGh6UZthv83N0dr((object) languageMapItem.BaseLanguage))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 3;
              continue;
            }
            obj = LanguagesMap.QUUsyeGhAh5stQ0XD7AQ((object) languageMapItem);
            break;
          case 7:
            goto label_10;
          default:
            // ISSUE: reference to a compiler-generated method
            languageMapItem = this.Languages.FirstOrDefault<LanguageMapItem>((Func<LanguageMapItem, bool>) (l => LanguagesMap.\u003C\u003Ec__DisplayClass6_0.HVwUdyvlYajDxsfv86Kc((object) l.Code, (object) code1, StringComparison.OrdinalIgnoreCase)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 5 : 6;
            continue;
        }
        name = (string) obj;
        num1 = 2;
      }
label_4:
      return (CultureInfo) LanguagesMap.tg07NDGh4IxG1D8BwPiV();
label_10:
      return (CultureInfo) LanguagesMap.tg07NDGh4IxG1D8BwPiV();
label_13:
      CultureInfo baseCultureInfo;
      try
      {
        baseCultureInfo = new CultureInfo(name);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_10;
        }
      }
      return baseCultureInfo;
    }

    /// <summary>Сформировать имя ресурса по локали</summary>
    /// <param name="resource"></param>
    /// <param name="local"></param>
    /// <returns></returns>
    public string GetResourceName(string resource, string local) => (string) LanguagesMap.L02p86GhxRQWIVxCBEWd(LanguagesMap.N9Y47QGh7G1btT9b39Ob(~538519529 ^ -538470158), (object) resource, (object) local.Replace((string) LanguagesMap.N9Y47QGh7G1btT9b39Ob(272623989 ^ 272623385), (string) LanguagesMap.N9Y47QGh7G1btT9b39Ob(1597012150 ^ 1597011148)));

    /// <summary>Загрузить из xml</summary>
    /// <param name="xml"></param>
    /// <returns></returns>
    public static LanguagesMap Load(string xml)
    {
      int num1 = 1;
      XmlReader xmlReader;
      LanguagesMap languagesMap;
      while (true)
      {
        switch (num1)
        {
          case 1:
            languagesMap = new LanguagesMap();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            goto label_5;
          default:
            xmlReader = (XmlReader) LanguagesMap.eVcTMWGh0tB0pOsenJPk((object) new StringReader(xml));
            num1 = 3;
            continue;
        }
      }
label_4:
      return languagesMap;
label_5:
      try
      {
        if (LanguagesMap.TIE1dMGhmLoNuEJqhy0H((object) xmlReader, LanguagesMap.N9Y47QGh7G1btT9b39Ob(1597012150 ^ 1597227590)))
        {
          int num2 = 14;
          LanguageMapItem languageMapItem;
          while (true)
          {
            switch (num2)
            {
              case 1:
                LanguagesMap.e99ayuGhlXofsJB3V2rv((object) languageMapItem, LanguagesMap.YNLxu0Gh9YeynGrNgomO((object) xmlReader, LanguagesMap.N9Y47QGh7G1btT9b39Ob(-1146510045 ^ -1146479099)));
                num2 = 3;
                continue;
              case 2:
                if (!LanguagesMap.xntObZGh6UZthv83N0dr((object) languageMapItem.Code))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 6 : 4;
                  continue;
                }
                goto case 9;
              case 3:
                languageMapItem.NativeName = xmlReader.GetAttribute((string) LanguagesMap.N9Y47QGh7G1btT9b39Ob(654297945 ^ 654077977));
                num2 = 4;
                continue;
              case 4:
                LanguagesMap.pdOVvCGhrpIMu6IUMnAZ((object) languageMapItem, (object) xmlReader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272388653)));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 2;
                continue;
              case 5:
                LanguagesMap.kn7yyJGhdfOT7gxlARIL((object) languageMapItem, LanguagesMap.YNLxu0Gh9YeynGrNgomO((object) xmlReader, LanguagesMap.N9Y47QGh7G1btT9b39Ob(95909607 + 343705423 ^ 439371052)));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 0;
                continue;
              case 6:
                languagesMap.Languages.Add(languageMapItem);
                num2 = 9;
                continue;
              case 7:
                languageMapItem = new LanguageMapItem();
                num2 = 5;
                continue;
              case 8:
              case 12:
                if (xmlReader.NodeType == XmlNodeType.EndElement)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 7 : 10;
                  continue;
                }
                goto default;
              case 9:
                LanguagesMap.lOyUYxGhgByLxHJa8Fl6((object) xmlReader);
                num2 = 11;
                continue;
              case 10:
                goto label_4;
              case 11:
                int num3 = (int) LanguagesMap.a2KED1GhMakOC3nLUXmq((object) xmlReader);
                num2 = 8;
                continue;
              case 13:
                int num4 = (int) LanguagesMap.a2KED1GhMakOC3nLUXmq((object) xmlReader);
                num2 = 12;
                continue;
              case 14:
                LanguagesMap.BDqciKGhyC5WmFxOpnqH((object) xmlReader);
                num2 = 13;
                continue;
              default:
                if (LanguagesMap.gC7nitGhJJgEy4DyOp7W((object) xmlReader.Name, LanguagesMap.N9Y47QGh7G1btT9b39Ob(-688192331 - 435440695 ^ -1123744904)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 5 : 7;
                  continue;
                }
                goto case 9;
            }
          }
        }
        else
          goto label_4;
      }
      finally
      {
        if (xmlReader != null)
        {
          int num5 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                LanguagesMap.hn0c0eGh5LjXVmiJX0lC((object) xmlReader);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
                continue;
              default:
                goto label_29;
            }
          }
        }
label_29:;
      }
    }

    internal static void shdmmKGhwl3YZ96rCw2H() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool GrTlr7GhDrEDvWPe18sn() => LanguagesMap.xhvgbFGhaGy28T1blWyD == null;

    internal static LanguagesMap XJNYSQGhtWpOm0MU2unc() => LanguagesMap.xhvgbFGhaGy28T1blWyD;

    internal static object tg07NDGh4IxG1D8BwPiV() => (object) EleWise.ELMA.SR.KeyCultureInfo;

    internal static bool xntObZGh6UZthv83N0dr([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object Nb0X1yGhHXgi3w4gFZ1G([In] object obj0) => (object) ((LanguageMapItem) obj0).Code;

    internal static object QUUsyeGhAh5stQ0XD7AQ([In] object obj0) => (object) ((LanguageMapItem) obj0).BaseLanguage;

    internal static object N9Y47QGh7G1btT9b39Ob(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object L02p86GhxRQWIVxCBEWd([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object eVcTMWGh0tB0pOsenJPk([In] object obj0) => (object) XmlReader.Create((TextReader) obj0);

    internal static bool TIE1dMGhmLoNuEJqhy0H([In] object obj0, [In] object obj1) => ((XmlReader) obj0).ReadToNextSibling((string) obj1);

    internal static bool BDqciKGhyC5WmFxOpnqH([In] object obj0) => ((XmlReader) obj0).Read();

    internal static XmlNodeType a2KED1GhMakOC3nLUXmq([In] object obj0) => ((XmlReader) obj0).MoveToContent();

    internal static bool gC7nitGhJJgEy4DyOp7W([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object YNLxu0Gh9YeynGrNgomO([In] object obj0, [In] object obj1) => (object) ((XmlReader) obj0).GetAttribute((string) obj1);

    internal static void kn7yyJGhdfOT7gxlARIL([In] object obj0, [In] object obj1) => ((LanguageMapItem) obj0).Code = (string) obj1;

    internal static void e99ayuGhlXofsJB3V2rv([In] object obj0, [In] object obj1) => ((LanguageMapItem) obj0).EnglishName = (string) obj1;

    internal static void pdOVvCGhrpIMu6IUMnAZ([In] object obj0, [In] object obj1) => ((LanguageMapItem) obj0).BaseLanguage = (string) obj1;

    internal static void lOyUYxGhgByLxHJa8Fl6([In] object obj0) => ((XmlReader) obj0).Skip();

    internal static void hn0c0eGh5LjXVmiJX0lC([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
