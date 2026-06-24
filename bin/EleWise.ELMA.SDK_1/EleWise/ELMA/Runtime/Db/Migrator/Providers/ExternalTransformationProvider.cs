// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Providers.ExternalTransformationProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db.Migrator.Providers
{
  /// <summary>Внешний провайдер работы с БД</summary>
  public abstract class ExternalTransformationProvider : TransformationProviderBase
  {
    private List<string> reservedWords;
    private static ExternalTransformationProvider rZNnouWkMlX2A3MWQIWr;

    /// <summary>Ctor</summary>
    [Obsolete("Не использовать", true)]
    public ExternalTransformationProvider()
    {
      ExternalTransformationProvider.WMq4ogWkdKvyjbGZ6sEQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="connectionCreateFunc">Функция создания соединения с БД</param>
    public ExternalTransformationProvider(Func<IDbConnection> connectionCreateFunc)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(connectionCreateFunc);
    }

    /// <summary>Получение наименования параметра</summary>
    /// <param name="queryPart">Часть запроса с параметром</param>
    /// <returns>Наименование параметра</returns>
    public virtual string GetParamName(string queryPart) => (string) ExternalTransformationProvider.htUbh7WklTXotK6bDEyf((object) queryPart, 1);

    /// <inheritdoc />
    protected override string QuoteIfNeeded(string name)
    {
      int num = 5;
      while (true)
      {
        string str;
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (ExternalTransformationProvider.mmJP4oWkYH4LBeYWiwka((object) name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
              continue;
            }
            goto label_3;
          case 3:
            goto label_9;
          case 4:
            if (ExternalTransformationProvider.t8YtmpWk5VtyM0VmY3FT((object) str, ExternalTransformationProvider.QpAXp8Wkgn4fXTFvsUEw((object) this)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
              continue;
            }
            break;
          case 5:
            str = (string) ExternalTransformationProvider.iDY8OhWkrapQ8wD8Tmxa((object) name);
            num = 4;
            continue;
          default:
            if (str.EndsWith(this.QuoteReservedWordsSymbolEnd))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 3 : 3;
              continue;
            }
            break;
        }
        if (!ExternalTransformationProvider.OygyGsWkjxlUYqjtD6CZ((object) this, (object) name))
          num = 2;
        else
          goto label_3;
      }
label_2:
      return name;
label_3:
      return string.Format(this.QuoteTemplate, (object) name);
label_9:
      return name;
    }

    /// <summary>Проверить, является ли имя резервным словом</summary>
    /// <param name="name">Проверяемое имя</param>
    /// <returns>True, если резервное слово</returns>
    protected virtual bool IsReservedWord(string name)
    {
      int num = 4;
      string trimedName;
      while (true)
      {
        switch (num)
        {
          case 1:
            List<string> reservedWords = this.GetReservedWords();
            this.reservedWords = reservedWords == null ? new List<string>() : reservedWords;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 2 : 1;
            continue;
          case 2:
            this.AddReservedWord(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312769923));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          case 3:
            if (this.reservedWords == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
              continue;
            }
            break;
          case 4:
            num = 3;
            continue;
          case 5:
            goto label_7;
        }
        trimedName = (string) ExternalTransformationProvider.iDY8OhWkrapQ8wD8Tmxa((object) name);
        num = 5;
      }
label_7:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.reservedWords.Any<string>((System.Func<string, bool>) (w => ExternalTransformationProvider.\u003C\u003Ec__DisplayClass5_0.X3FviGQAWnqi0AU4cTw2(ExternalTransformationProvider.\u003C\u003Ec__DisplayClass5_0.gWPpwQQAB2GWYTOd0IAU(), (object) w, (object) trimedName)));
    }

    /// <summary>Добавить зарезервированное слово</summary>
    /// <param name="word">Слово</param>
    protected void AddReservedWord(string word)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.reservedWords.Add(word);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
            continue;
          case 2:
            if (!this.IsReservedWord(word))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:
      return;
label_6:;
    }

    /// <summary>Первый символ экранирования</summary>
    protected virtual string QuoteReservedWordsSymbolStart => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939378220);

    /// <summary>Последний символ экранирования</summary>
    protected virtual string QuoteReservedWordsSymbolEnd => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70002091);

    /// <summary>Шаблон экранирования</summary>
    protected virtual string QuoteTemplate => (string) ExternalTransformationProvider.xhuT9YWksiPO6GsQO0vM(ExternalTransformationProvider.cMlagSWkLa9ShOGaGaOV(1581325282 << 3 ^ -234169350), ExternalTransformationProvider.QpAXp8Wkgn4fXTFvsUEw((object) this), ExternalTransformationProvider.UUZ8SjWkUlS9m2tSDIix((object) this));

    internal static void WMq4ogWkdKvyjbGZ6sEQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool TpcDCZWkJ0fF0RsUlKoP() => ExternalTransformationProvider.rZNnouWkMlX2A3MWQIWr == null;

    internal static ExternalTransformationProvider oqhLoMWk9UXLYNfLEhow() => ExternalTransformationProvider.rZNnouWkMlX2A3MWQIWr;

    internal static object htUbh7WklTXotK6bDEyf([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static object iDY8OhWkrapQ8wD8Tmxa([In] object obj0) => (object) ((string) obj0).Trim();

    internal static object QpAXp8Wkgn4fXTFvsUEw([In] object obj0) => (object) ((ExternalTransformationProvider) obj0).QuoteReservedWordsSymbolStart;

    internal static bool t8YtmpWk5VtyM0VmY3FT([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static bool OygyGsWkjxlUYqjtD6CZ([In] object obj0, [In] object obj1) => ((ExternalTransformationProvider) obj0).IsReservedWord((string) obj1);

    internal static bool mmJP4oWkYH4LBeYWiwka([In] object obj0) => ((string) obj0).IsValidIdentifier();

    internal static object cMlagSWkLa9ShOGaGaOV(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object UUZ8SjWkUlS9m2tSDIix([In] object obj0) => (object) ((ExternalTransformationProvider) obj0).QuoteReservedWordsSymbolEnd;

    internal static object xhuT9YWksiPO6GsQO0vM([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);
  }
}
