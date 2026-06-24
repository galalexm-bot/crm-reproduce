// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Providers.Dialect
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db.Migrator.Providers
{
  /// <summary>
  /// Определяет реализацию деталей, специфических для конкретной СУБД.
  /// </summary>
  public abstract class Dialect
  {
    private readonly Dictionary<ColumnProperty, string> propertyMap;
    private readonly TypeNames typeNames;
    private readonly System.Collections.Generic.List<string> reservedWords;
    private readonly string schemaName;
    /// <summary>
    /// Символ запрета заключения в кавычки, даже если служебное слово
    /// </summary>
    public const string UnQuoteSymbol = "^^";
    private static Dialect obAVaoWn0LsHsLfxJahv;

    /// <summary>Получить зарезирвированные слова</summary>
    public System.Collections.Generic.List<string> ReservedWords => this.reservedWords;

    /// <summary>Получить имя схемы</summary>
    public string SchemaName => this.schemaName;

    /// <summary>Создать диалект</summary>
    /// <param name="reservedWords">Список зарезервировнных слов</param>
    protected Dialect(System.Collections.Generic.List<string> reservedWords)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.propertyMap = new Dictionary<ColumnProperty, string>();
      this.typeNames = new TypeNames();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.reservedWords = reservedWords ?? new System.Collections.Generic.List<string>();
      this.RegisterProperty(ColumnProperty.Null, z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521397696));
      this.RegisterProperty(ColumnProperty.NotNull, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333605406));
      this.RegisterProperty(ColumnProperty.Unique, z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408763630));
      this.RegisterProperty(ColumnProperty.PrimaryKey, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675373169));
    }

    /// <summary>Создать диалект</summary>
    /// <param name="reservedWords">Список зарезервировнных слов</param>
    /// <param name="schemaName">Имя текущей схемы</param>
    protected Dialect(System.Collections.Generic.List<string> reservedWords, string schemaName)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(reservedWords);
      this.schemaName = schemaName;
    }

    /// <summary>Проверка, что заданный тип зарегистрирован</summary>
    /// <param name="type">Проверяемый тип</param>
    /// <returns>Возвращает true, если заданный тип зарегистрирован, иначе возвращает false.</returns>
    public virtual bool TypeIsRegistred(DbType type) => Dialect.W0X1TRWnMCqKBqevbUS0((object) this.typeNames, type);

    /// <summary>
    /// Регистрирует название типа БД, которое будет использовано для
    /// конкретного значения DbType, указанного в "миграциях".
    /// <para><c>$l</c> - будет заменено на конкретное значение длины</para>
    /// <para><c>$s</c> - будет заменено на конкретное значение, показывающее
    /// количество знаков после запятой для вещественных чисел</para>м
    /// </summary>
    /// <param name="code">The typecode</param>
    /// <param name="capacity">Maximum length of database type</param>
    /// <param name="name">The database type name</param>
    protected void RegisterColumnType(DbType code, int capacity, string name)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.typeNames.Put(code, new int?(capacity), name);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Регистрирует название типа БД, которое будет использовано для
    /// конкретного значения DbType, указанного в "миграциях".
    /// <para><c>$l</c> - будет заменено на конкретное значение длины</para>
    /// <para><c>$s</c> - будет заменено на конкретное значение, показывающее
    /// количество знаков после запятой для вещественных чисел</para>
    /// </summary>
    /// <param name="code">Тип</param>
    /// <param name="capacity">Максимальная длина</param>
    /// <param name="name">Название типа БД</param>
    /// <param name="defaultScale">Значение по умолчанию: количество знаков после запятой для вещественных чисел</param>
    protected void RegisterColumnType(DbType code, int capacity, string name, int defaultScale)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.typeNames.Put(code, new int?(capacity), name, new int?(defaultScale));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Регистрирует название типа БД, которое будет использовано для
    /// конкретного значения DbType, указанного в "миграциях".
    /// <para><c>$l</c> - будет заменено на конкретное значение длины</para>
    /// <para><c>$s</c> - будет заменено на конкретное значение, показывающее
    /// количество знаков после запятой для вещественных чисел</para>
    /// </summary>
    /// <param name="code">Тип</param>
    /// <param name="name">Название типа БД</param>
    protected void RegisterColumnType(DbType code, string name)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Dialect.fwe2XlWnJHGxhDMnsWnd((object) this.typeNames, code, (object) name);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Get the name of the database type associated with the given
    /// </summary>
    /// <param name="type">The DbType</param>
    /// <returns>The database type name used by ddl.</returns>
    public virtual string GetTypeName(DbType type) => (string) Dialect.cpI1JGWn9MPTMDgUWSwy((object) this.typeNames, type);

    /// <summary>
    /// Get the name of the database type associated with the given
    /// </summary>
    /// <param name="type">The DbType</param>
    /// <returns>The database type name used by ddl.</returns>
    public virtual string GetTypeName(ColumnType type) => this.typeNames.Get(type);

    /// <summary>
    /// Get the name of the database type associated with the given
    /// </summary>
    /// <param name="type">The DbType</param>
    /// <returns>The database type name used by ddl.</returns>
    /// <param name="length"></param>
    /// <param name="scale"></param>
    public virtual string GetTypeName(DbType type, int? length, int? scale) => this.typeNames.Get(type, length, scale);

    public void RegisterProperty(ColumnProperty property, string sql)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
            this.propertyMap[property] = sql;
            num = 3;
            continue;
          case 2:
            if (this.propertyMap.ContainsKey(property))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 0;
              continue;
            }
            break;
          case 3:
            goto label_2;
        }
        this.propertyMap.Add(property, sql);
        num = 4;
      }
label_2:;
    }

    public virtual string SqlForProperty(ColumnProperty property)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.propertyMap.ContainsKey(property))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
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
      return this.propertyMap[property];
label_3:
      return string.Empty;
    }

    /// <summary>
    /// Максимальная длина названия TableName для БД
    /// Использовать только для проверки перед импортом! Для остальных мест есть EleWise.ELMA.Model.Metadata.EntityMetadata.MAX_TABLE_NAME_LENGTH
    /// </summary>
    public virtual int MaxTableNameLength => 28;

    public virtual DateTime MinDateTime => DateTime.MinValue;

    public virtual DateTime MaxDateTime => DateTime.MaxValue;

    public virtual bool TableNameNeedsQuote => false;

    public virtual bool ConstraintNameNeedsQuote => false;

    public virtual bool IdentityNeedsType => true;

    public virtual bool NeedsNotNullForIdentity => true;

    public virtual bool SupportsIndex => true;

    public virtual string Quote(string value) => string.Format((string) Dialect.C9gcf1Wnd3YUeTBlIdtP((object) this), (object) value);

    /// <summary>Убрать кавычки из имени, если они имеются</summary>
    /// <param name="name">Имя</param>
    /// <returns>Обработанное имя</returns>
    public virtual string UnquoteIfNeeded(string name)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            goto label_6;
          case 2:
            if (!Dialect.vBCisLWnlkg5C2In2Qcm((object) name, (object) this.QuoteReservedWordsSymbolStart))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 1;
              continue;
            }
            break;
        }
        if (!Dialect.pNHvUkWngiQYGMnXgSDi((object) name, Dialect.loLuCDWnrGGLVZuaZP5G((object) this)))
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 3 : 1;
        else
          goto label_7;
      }
label_6:
      return name;
label_7:
      return (string) Dialect.hqWuh7WnYMHAEHFHmpbt((object) name, Dialect.UsIwOuWnjASJ2PyISe3d(Dialect.o9AqFbWn5Ecx2iktAay3((object) this)), Dialect.UsIwOuWnjASJ2PyISe3d((object) name) - ((string) Dialect.loLuCDWnrGGLVZuaZP5G((object) this)).Length - Dialect.UsIwOuWnjASJ2PyISe3d(Dialect.o9AqFbWn5Ecx2iktAay3((object) this)));
    }

    /// <summary>
    /// Заключить имя в кавычки, если это резервное слово или содержит недопустимые символы
    /// </summary>
    /// <param name="name">Имя</param>
    /// <returns>Обработанное имя</returns>
    public virtual string QuoteIfNeeded(string name)
    {
      int num = 1;
      while (true)
      {
        string str;
        switch (num)
        {
          case 1:
            if (!Dialect.vBCisLWnlkg5C2In2Qcm((object) name, Dialect.rrwkl1WnLliKhsOMwb73(1917256330 ^ 1917125824)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
              continue;
            }
            goto case 9;
          case 2:
            goto label_10;
          case 3:
            if (str.EndsWith((string) Dialect.loLuCDWnrGGLVZuaZP5G((object) this)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 2;
              continue;
            }
            break;
          case 4:
            if (Dialect.vBCisLWnlkg5C2In2Qcm((object) str, Dialect.o9AqFbWn5Ecx2iktAay3((object) this)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 3;
              continue;
            }
            break;
          case 5:
            goto label_6;
          case 6:
            if (!Dialect.zpe2bcWncb5JDBEwoU0r((object) name))
            {
              num = 7;
              continue;
            }
            goto label_6;
          case 7:
            goto label_7;
          case 8:
            goto label_4;
          case 9:
            if (name.EndsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998409360)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 8;
              continue;
            }
            goto default;
          default:
            str = (string) Dialect.iTo6FBWnU00y7OdYLgjj((object) name);
            num = 4;
            continue;
        }
        if (!Dialect.XJAg8CWnsXkIrxM1DAMv((object) this, (object) name))
          num = 6;
        else
          goto label_7;
      }
label_4:
      return this.RemoveUnQuote(name);
label_6:
      return name;
label_7:
      return (string) Dialect.NiM3pPWnzECleTAOuxJE(Dialect.C9gcf1Wnd3YUeTBlIdtP((object) this), (object) name);
label_10:
      return name;
    }

    /// <summary>Проверить, является ли имя резервным словом</summary>
    /// <param name="name">Проверяемое имя</param>
    /// <returns>True, если резервное слово</returns>
    public virtual bool IsReservedWord(string name)
    {
      int num = 2;
      string trimedName;
      while (true)
      {
        switch (num)
        {
          case 1:
            trimedName = (string) Dialect.iTo6FBWnU00y7OdYLgjj((object) name);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      return this.reservedWords.Any<string>((System.Func<string, bool>) (w => ((StringComparer) Dialect.\u003C\u003Ec__DisplayClass39_0.KkhZx0QAEtoQpkHLqRip()).Equals(w, trimedName)));
    }

    public virtual string QuoteTemplate => (string) Dialect.y5v6JQWOFR8F9EhCXC1q(Dialect.rrwkl1WnLliKhsOMwb73(1251470110 >> 2 ^ 312999469), Dialect.o9AqFbWn5Ecx2iktAay3((object) this), Dialect.loLuCDWnrGGLVZuaZP5G((object) this));

    public virtual string QuoteReservedWordsSymbolStart => (string) Dialect.rrwkl1WnLliKhsOMwb73(-477139494 ^ -477138814);

    public virtual string QuoteReservedWordsSymbolEnd => (string) Dialect.rrwkl1WnLliKhsOMwb73(-1445902765 ^ -1980277732 ^ 539363095);

    public virtual string Default(object defaultValue) => (string) Dialect.NiM3pPWnzECleTAOuxJE((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87993073), defaultValue);

    public virtual string GetColumnSql(Column column, bool compoundPrimaryKey)
    {
      int num = 3;
      System.Collections.Generic.List<string> vals;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            vals = new System.Collections.Generic.List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
            continue;
          case 3:
            Dialect.S09BKTWOBWu5uFGXVa8x((object) column, Dialect.rrwkl1WnLliKhsOMwb73(~210725948 ^ -210670391));
            num = 2;
            continue;
          default:
            this.BuildColumnSql(vals, column, compoundPrimaryKey);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:
      return (string) Dialect.ooWyrsWOo2jx6Inrbllg(Dialect.rrwkl1WnLliKhsOMwb73(-1822890472 ^ -1822904518), Dialect.h3pZdAWOWAy37X2xXjjD((object) vals));
    }

    /// <summary>
    /// Преобразует дату в строку пригодную для вставки в SQL запрос
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public abstract string DateToSql(DateTime date);

    /// <summary>
    /// Оборачивает в функцию преобразования в тип, аналогичный Int64
    /// </summary>
    /// <param name="param"></param>
    /// <returns></returns>
    public abstract string ConvertToInt64(string parameter);

    /// <summary>
    /// Преобразует дату в строку пригодную для вставки в SQL запрос
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public abstract string DateTimeToSql(DateTime date);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="parametrName"></param>
    /// <returns></returns>
    public abstract string StrToIntFromSql(string parametrName);

    /// <summary>
    /// Преобразует UID в строку в строку пригодную для вставки в SQL запрос
    /// Возвращает сроку  пригодную для вставки в SQL запрос
    /// </summary>
    /// <param name="parametrName">Возвращает сроку  пригодную для вставки в SQL запрос</param>
    /// <returns></returns>
    public abstract string GuidToCharFromSql(string parametrName);

    /// <summary>
    /// Преобразует UID в строку пригодную для вставки в SQL запрос не заключая parametrName в кавычки
    /// Возвращает сроку пригодную для вставки в SQL запрос
    /// </summary>
    /// <param name="alias"></param>
    /// <param name="parametrName">Возвращает сроку  пригодную для вставки в SQL запрос</param>
    /// <returns></returns>
    public abstract string GuidToCharFromSqlWithoutQuote(string parametrName);

    /// <summary>
    /// Преобразует стркоу в UID пригодную для вставки в SQL запрос не заключая parametrName в кавычки
    /// Возвращает сроку  пригодную для вставки в SQL запрос
    /// </summary>
    /// <param name="alias"></param>
    /// <param name="parametrName">Возвращает сроку  пригодную для вставки в SQL запрос</param>
    /// <returns></returns>
    public abstract string CharToGuidFromSqlWithoutQuote(string parametrName);

    public abstract string CharToGuidFromSql(string parametrName);

    /// <summary>
    /// Функция SQL, возвращающая текущее локальное время на сервере БД
    /// </summary>
    public abstract string CurrentTimestamp { get; }

    /// <summary>
    /// Функция SQL, возвращающая текущее UTC время на сервере БД
    /// </summary>
    public abstract string CurrentUtcTimestamp { get; }

    public abstract string AddSecond(string arg, string second);

    /// <summary>Символ кавычки для текста.</summary>
    /// <returns></returns>
    public abstract string QuoteSymbol();

    /// <summary>Символ объединения двух строк.</summary>
    /// <returns></returns>
    public abstract string ConcatenateSymbol();

    /// <summary>Функция IsNull.</summary>
    /// <returns></returns>
    public abstract string IsNull(string checkExpression, string replacementValue);

    /// <summary>Заключить текст в кавычки.</summary>
    /// <returns></returns>
    public abstract string QuoteString(string text);

    /// <summary>
    /// Преобразовать текст в текст защищенный от проверки на резервное слово.
    /// </summary>
    /// <param name="text">Текст, который необходимо преобразовать</param>
    public string UnQuoteString(string text) => (string) Dialect.Ie2JMNWOG2psmcToryBg((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426226829), Dialect.fF6aLKWOh6ghgyPYVHyI((object) text, Dialect.rrwkl1WnLliKhsOMwb73(1461825605 - 1531863589 ^ -70170518), Dialect.p3dGbPWObHXq3JQtqVf4(Dialect.rrwkl1WnLliKhsOMwb73(1574260816 ^ 1574393370), Dialect.rrwkl1WnLliKhsOMwb73(825385222 ^ 825255756))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979383173));

    /// <summary>Убрать защиту от проверки на резервное слово.</summary>
    /// <param name="text">Текст, который необходимо преобразовать</param>
    public string RemoveUnQuote(string text) => (string) Dialect.hqWuh7WnYMHAEHFHmpbt((object) text, Dialect.eIkqWdWOEuVAopwZ8Wmy((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112834852)), Dialect.UsIwOuWnjASJ2PyISe3d((object) text) - Dialect.eIkqWdWOEuVAopwZ8Wmy(Dialect.rrwkl1WnLliKhsOMwb73(-138018305 ^ -138147915)) * 2);

    public virtual Guid GetGuid(object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return Guid.Empty;
label_5:
      return (Guid) value;
    }

    public abstract string GetIsNullFunctionName();

    public virtual bool IsIsolationLevelSupported(IsolationLevel isolationLevel) => true;

    /// <summary>Генерирование Uid</summary>
    /// <returns></returns>
    public abstract string GenUid();

    /// <summary>Объединение строк</summary>
    /// <param name="items">Значения</param>
    /// <returns></returns>
    public abstract string Concat(params string[] items);

    /// <summary>Получение подстроки из строкового значения</summary>
    /// <param name="val">Колонка или конкретное тектовое значение</param>
    /// <param name="start">Начальнй индекс (нумерация с 1)</param>
    /// <param name="length">Количество эле ментов</param>
    /// <returns></returns>
    public abstract string Substring(string val, int start, int? length = null);

    /// <summary>Возвращает длину строки</summary>
    /// <param name="columnName">Название столбца, или выражение</param>
    public virtual string Length(string columnName) => string.Format((string) Dialect.rrwkl1WnLliKhsOMwb73(1917998801 >> 2 ^ 479630296), (object) columnName);

    /// <summary>Возвращает наибольшее значение в определенном столбце</summary>
    /// <param name="columnName">Название столбца</param>
    /// <returns></returns>
    public virtual string Max(string columnName) => (string) Dialect.NiM3pPWnzECleTAOuxJE(Dialect.rrwkl1WnLliKhsOMwb73(-1867198571 ^ -1867069163), (object) columnName);

    /// <summary>Преобразовать в строку</summary>
    /// <param name="columnName">Колонка</param>
    /// <returns></returns>
    public abstract string CastToString(string columnName);

    /// <summary>Аналог функции LIST для FB</summary>
    /// <param name="columNameForConnect">Колонка для объединения - fb - ora - pg</param>
    /// <param name="inColumNameForConnect">Внутренняя колонка для объединения - ms</param>
    /// <param name="outAlias">Внешний псевдоним - fb - ora - pg</param>
    /// <param name="inAlias">Внутренний псевдоним - ms</param>
    /// <param name="tableName">Внутренняя таблица для выборки - ms</param>
    /// <param name="where">Условие для выборки - ms</param>
    /// <returns></returns>
    public abstract string List(
      string columNameForConnect,
      string inColumNameForConnect,
      string outAlias,
      string inAlias,
      string tableName,
      string where);

    /// <summary>Получение наименования параметра</summary>
    /// <param name="queryPart">Часть запроса с параметром</param>
    /// <returns></returns>
    public virtual string GetParamName(string queryPart) => (string) Dialect.p4B5rZWOfwyrwI0FFwhV((object) queryPart, 1);

    /// <summary>Функция "Побитовое ИЛИ"</summary>
    /// <param name="value1">Операнд 1</param>
    /// <param name="value2">Операнд 2</param>
    /// <returns></returns>
    public abstract string BinOr(string value1, string value2);

    /// <summary>
    /// Возвращает необходимое значение в соответствии с условием
    /// </summary>
    /// <param name="expression">Логическое выражение</param>
    /// <param name="trueValue">Возвращаемое значение, если <paramref name="expression" /> = <c>true</c></param>
    /// <param name="falseValue">Возвращаемое значение, если <paramref name="expression" /> = <c>false</c></param>
    /// <returns>Возвращает сроку пригодную для вставки в SQL запрос с выражением, возвращающим значение в соответствии с условием <paramref name="expression" /></returns>
    public virtual string InsertIf(string expression, string trueValue, string falseValue) => (string) Dialect.KU8m1yWOQ5g06pWy8koD(Dialect.rrwkl1WnLliKhsOMwb73(1654249598 >> 2 ^ 413429899), (object) expression, (object) trueValue, (object) falseValue);

    /// <summary>Преобразорвать строку для like-выражения</summary>
    /// <remarks>
    /// В разных диалектах возможны разные управляющие символы в like-выражении.
    /// Метод приводит входную строку к универсальному виду, в котором можно использовать символы '%' - любое количество любых символов и '_' - любой 1 символ
    /// </remarks>
    /// <param name="value">Строка</param>
    public virtual string LikeValue(string value) => value;

    protected virtual void BuildColumnSql(
      System.Collections.Generic.List<string> vals,
      Column column,
      bool compoundPrimaryKey)
    {
      this.AddColumnName(vals, column);
      this.AddColumnType(vals, column);
      this.AddSqlForIdentityWhichNotNeedsType(vals, column);
      this.AddUnsignedSql(vals, column);
      this.AddNotNullSql(vals, column);
      this.AddPrimaryKeySql(vals, column, compoundPrimaryKey);
      this.AddSqlForIdentityWhichNeedsType(vals, column);
      this.AddUniqueSql(vals, column);
      this.AddForeignKeySql(vals, column);
      this.AddDefaultValueSql(vals, column);
    }

    protected void AddColumnName(System.Collections.Generic.List<string> vals, Column column) => vals.Add(this.QuoteIfNeeded(column.Name));

    protected void AddColumnType(System.Collections.Generic.List<string> vals, Column column)
    {
      string s = this.IdentityNeedsType || !column.IsIdentity ? this.GetTypeName(column.ColumnType) : string.Empty;
      if (s.IsNullOrEmpty())
        return;
      vals.Add(s);
    }

    protected void AddSqlForIdentityWhichNotNeedsType(System.Collections.Generic.List<string> vals, Column column)
    {
      if (this.IdentityNeedsType)
        return;
      this.AddValueIfSelected(column, ColumnProperty.Identity, (ICollection<string>) vals);
    }

    protected void AddUnsignedSql(System.Collections.Generic.List<string> vals, Column column) => this.AddValueIfSelected(column, ColumnProperty.Unsigned, (ICollection<string>) vals);

    protected void AddNotNullSql(System.Collections.Generic.List<string> vals, Column column)
    {
      if (column.ColumnProperty.HasProperty(ColumnProperty.PrimaryKey) && !this.NeedsNotNullForIdentity)
        return;
      this.AddValueIfSelected(column, ColumnProperty.NotNull, (ICollection<string>) vals);
    }

    protected void AddPrimaryKeySql(System.Collections.Generic.List<string> vals, Column column, bool compoundPrimaryKey)
    {
      if (compoundPrimaryKey)
        return;
      this.AddValueIfSelected(column, ColumnProperty.PrimaryKey, (ICollection<string>) vals);
    }

    protected void AddSqlForIdentityWhichNeedsType(System.Collections.Generic.List<string> vals, Column column)
    {
      if (!this.IdentityNeedsType)
        return;
      this.AddValueIfSelected(column, ColumnProperty.Identity, (ICollection<string>) vals);
    }

    protected void AddForeignKeySql(System.Collections.Generic.List<string> vals, Column column) => this.AddValueIfSelected(column, ColumnProperty.ForeignKey, (ICollection<string>) vals);

    protected void AddUniqueSql(System.Collections.Generic.List<string> vals, Column column) => this.AddValueIfSelected(column, ColumnProperty.Unique, (ICollection<string>) vals);

    protected void AddDefaultValueSql(System.Collections.Generic.List<string> vals, Column column)
    {
      if (column.DefaultValue == null)
        return;
      vals.Add(this.Default(column.DefaultValue));
    }

    protected void AddReservedWord(string word)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!Dialect.XJAg8CWnsXkIrxM1DAMv((object) this, (object) word))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_2;
          default:
            this.reservedWords.Add(word);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return;
label_6:;
    }

    protected void AddValueIfSelected(
      Column column,
      ColumnProperty property,
      ICollection<string> vals)
    {
      if (!column.ColumnProperty.HasProperty(property))
        return;
      vals.Add(this.SqlForProperty(property));
    }

    internal static bool W0X1TRWnMCqKBqevbUS0([In] object obj0, DbType type) => ((TypeNames) obj0).HasType(type);

    internal static bool MIe5R1Wnm9Wi7VkGtBxV() => Dialect.obAVaoWn0LsHsLfxJahv == null;

    internal static Dialect dfobXkWnyvcNAZka5nHB() => Dialect.obAVaoWn0LsHsLfxJahv;

    internal static void fwe2XlWnJHGxhDMnsWnd([In] object obj0, DbType typecode, [In] object obj2) => ((TypeNames) obj0).Put(typecode, (string) obj2);

    internal static object cpI1JGWn9MPTMDgUWSwy([In] object obj0, DbType typecode) => (object) ((TypeNames) obj0).Get(typecode);

    internal static object C9gcf1Wnd3YUeTBlIdtP([In] object obj0) => (object) ((Dialect) obj0).QuoteTemplate;

    internal static bool vBCisLWnlkg5C2In2Qcm([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static object loLuCDWnrGGLVZuaZP5G([In] object obj0) => (object) ((Dialect) obj0).QuoteReservedWordsSymbolEnd;

    internal static bool pNHvUkWngiQYGMnXgSDi([In] object obj0, [In] object obj1) => ((string) obj0).EndsWith((string) obj1);

    internal static object o9AqFbWn5Ecx2iktAay3([In] object obj0) => (object) ((Dialect) obj0).QuoteReservedWordsSymbolStart;

    internal static int UsIwOuWnjASJ2PyISe3d([In] object obj0) => ((string) obj0).Length;

    internal static object hqWuh7WnYMHAEHFHmpbt([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object rrwkl1WnLliKhsOMwb73(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object iTo6FBWnU00y7OdYLgjj([In] object obj0) => (object) ((string) obj0).Trim();

    internal static bool XJAg8CWnsXkIrxM1DAMv([In] object obj0, [In] object obj1) => ((Dialect) obj0).IsReservedWord((string) obj1);

    internal static bool zpe2bcWncb5JDBEwoU0r([In] object obj0) => ((string) obj0).IsValidIdentifier();

    internal static object NiM3pPWnzECleTAOuxJE([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object y5v6JQWOFR8F9EhCXC1q([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void S09BKTWOBWu5uFGXVa8x([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object h3pZdAWOWAy37X2xXjjD([In] object obj0) => (object) ((System.Collections.Generic.List<string>) obj0).ToArray();

    internal static object ooWyrsWOo2jx6Inrbllg([In] object obj0, [In] object obj1) => (object) string.Join((string) obj0, (string[]) obj1);

    internal static object p3dGbPWObHXq3JQtqVf4([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object fF6aLKWOh6ghgyPYVHyI([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object Ie2JMNWOG2psmcToryBg([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static int eIkqWdWOEuVAopwZ8Wmy([In] object obj0) => ((string) obj0).Length;

    internal static object p4B5rZWOfwyrwI0FFwhV([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static object KU8m1yWOQ5g06pWy8koD(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }
  }
}
