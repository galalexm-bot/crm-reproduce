// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Constants.FullTextSearchConst
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Constants
{
  public static class FullTextSearchConst
  {
    public const string DefaultIndexFolder = "FullTextIndex";
    public const int MaxIndexPart = 100;
    public const int IndexPageSize = 10;
    public const string DbLockKey = "FullTextIndexJobDoLock";
    /// <summary>
    /// Ключ настройки размера пачки данных для первичной индексации
    /// </summary>
    public const string PageSizeSettingsKey = "FullTextSearch.PageSize";
    /// <summary>
    /// Максимальный размер обрабатываемого файла в формате html (байт)
    /// </summary>
    public const int MaxHtmlFileSize = 100000000;
    /// <summary>
    /// Максимальный размер обрабатываемого файла в формате text (байт)
    /// </summary>
    public const int MaxTextFileSize = 50000000;
    /// <summary>
    /// Текст предупреждение о недоступности сервера полнотекстового поиска
    /// </summary>
    public static readonly string FullTextServerErrorText;
    /// <summary>
    /// Минимальная длина поисковой строки для поиска в индексе
    /// </summary>
    public const int MinSearchStringLength = 3;
    public const int DefaultMaxSize = 1000;
    public const int DefaultFrom = 0;
    public const int DefaultSize = 10;
    internal static FullTextSearchConst TbV6UHGC4dHWJBe8xcQw;

    /// <summary>
    /// Текст предупреждение об прерывании индексации из-за отключения индексирования
    /// </summary>
    public static string StopIndexTextLog => (string) FullTextSearchConst.EAjh38GC7oYYTrp7rUEw(FullTextSearchConst.g9cE9oGCASxB6ciMF9i5(--1333735954 ^ 1333590966));

    public static Guid DeafultProviderUid => FullTextSearchConst.zbuLBZGCxiK05dZoXv9R((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323266102));

    static FullTextSearchConst()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FullTextSearchConst.FullTextServerErrorText = (string) FullTextSearchConst.EAjh38GC7oYYTrp7rUEw(FullTextSearchConst.g9cE9oGCASxB6ciMF9i5(-2099751081 ^ -2099536633));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
            continue;
          case 2:
            FullTextSearchConst.QOweLXGC0CBolAVZAEh8();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object g9cE9oGCASxB6ciMF9i5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object EAjh38GC7oYYTrp7rUEw([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool EVKYUCGC679eOSTqd9RT() => FullTextSearchConst.TbV6UHGC4dHWJBe8xcQw == null;

    internal static FullTextSearchConst Ia4uxNGCHjTtR0tNvbPL() => FullTextSearchConst.TbV6UHGC4dHWJBe8xcQw;

    internal static Guid zbuLBZGCxiK05dZoXv9R([In] object obj0) => Guid.Parse((string) obj0);

    internal static void QOweLXGC0CBolAVZAEh8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
