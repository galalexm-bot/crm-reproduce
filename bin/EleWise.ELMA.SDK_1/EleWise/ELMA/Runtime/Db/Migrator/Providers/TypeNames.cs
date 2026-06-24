// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Providers.TypeNames
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
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
  /// <summary>This class maps a DbType to names.</summary>
  /// <remarks>
  /// Associations may be marked with a capacity. Calling the <c>Get()</c>
  /// method with a type and actual size n will return the associated
  /// name with smallest capacity &gt;= n, if available and an unmarked
  /// default type otherwise.
  /// Eg, setting
  /// <code>
  /// 	Names.Put(DbType,			"TEXT" );
  /// 	Names.Put(DbType,	255,	"VARCHAR($l)" );
  /// 	Names.Put(DbType,	65534,	"LONGVARCHAR($l)" );
  /// </code>
  /// will give you back the following:
  /// <code>
  /// 	Names.Get(DbType)			// --&gt; "TEXT" (default)
  /// 	Names.Get(DbType,100)		// --&gt; "VARCHAR(100)" (100 is in [0:255])
  /// 	Names.Get(DbType,1000)		// --&gt; "LONGVARCHAR(1000)" (100 is in [256:65534])
  /// 	Names.Get(DbType,100000)	// --&gt; "TEXT" (default)
  /// </code>
  /// On the other hand, simply putting
  /// <code>
  /// 	Names.Put(DbType, "VARCHAR($l)" );
  /// </code>
  /// would result in
  /// <code>
  /// 	Names.Get(DbType)		// --&gt; "VARCHAR($l)" (will cause trouble)
  /// 	Names.Get(DbType,100)	// --&gt; "VARCHAR(100)"
  /// 	Names.Get(DbType,1000)	// --&gt; "VARCHAR(1000)"
  /// 	Names.Get(DbType,10000)	// --&gt; "VARCHAR(10000)"
  /// </code>
  /// </remarks>
  public class TypeNames
  {
    private readonly Dictionary<DbType, SortedList<int, Pair<string, int?>>> typeMapping;
    private readonly Dictionary<DbType, string> defaults;
    public const string LENGTH_PLACE_HOLDER = "$l";
    public const string SCALE_PLACE_HOLDER = "$s";
    internal static TypeNames TKmUJpWOuexbZLXmh9o5;

    /// <summary>Добавить значение по умолчанию для типа</summary>
    /// <param name="typecode">Тип</param>
    /// <param name="value">Значение</param>
    private void PutDefaultValue(DbType typecode, string value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.defaults[typecode] = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Получить значение по умолчанию</summary>
    /// <param name="typecode">Тип</param>
    /// <returns>
    /// Значение по умолчанию для данного типа.
    /// Если значение определить не удалось, генерируется исключение.
    /// </returns>
    private string GetDefaultValue(DbType typecode)
    {
      int num = 2;
      string defaultValue;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (this.defaults.TryGetValue(typecode, out defaultValue))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      throw new ArgumentException((string) TypeNames.wwDaptWOSmCWCyWB7u0B((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727488510), (object) typecode), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824519151));
label_3:
      return defaultValue;
    }

    private void PutValue(DbType typecode, int length, Pair<string, int?> value)
    {
      SortedList<int, Pair<string, int?>> sortedList;
      if (!this.typeMapping.TryGetValue(typecode, out sortedList))
        this.typeMapping[typecode] = sortedList = new SortedList<int, Pair<string, int?>>();
      sortedList[length] = value;
    }

    /// <summary>Получение строки SQL для типа с учетом размеров</summary>
    /// <param name="typecode">Тип</param>
    /// <param name="size">Размер</param>
    /// <returns>
    /// Возвращает строку SQL для типа, определенную с учетом его размеров.
    /// Если строку SQL определить не удалось, возвращается null.
    /// </returns>
    private Pair<string, int?> GetValue(DbType typecode, int size)
    {
      SortedList<int, Pair<string, int?>> source;
      this.typeMapping.TryGetValue(typecode, out source);
      if (source == null)
        return (Pair<string, int?>) null;
      return source.Count<KeyValuePair<int, Pair<string, int?>>>((System.Func<KeyValuePair<int, Pair<string, int?>>, bool>) (pair => pair.Key >= size)) == 0 ? (Pair<string, int?>) null : source.OrderBy<KeyValuePair<int, Pair<string, int?>>, int>((System.Func<KeyValuePair<int, Pair<string, int?>>, int>) (pair => pair.Key)).First<KeyValuePair<int, Pair<string, int?>>>((System.Func<KeyValuePair<int, Pair<string, int?>>, bool>) (pair => pair.Key >= size)).Value;
    }

    public void Put(DbType typecode, int? length, string value) => this.Put(typecode, length, value, new int?());

    public void Put(DbType typecode, int? length, string value, int? defaultScale)
    {
      if (length.HasValue)
        this.PutValue(typecode, length.Value, new Pair<string, int?>(value, defaultScale));
      else
        this.PutDefaultValue(typecode, value);
    }

    public void Put(DbType typecode, string value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.PutDefaultValue(typecode, value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public string Get(ColumnType columnType) => this.Get(TypeNames.r8uhNWWOiDLa1fmkbfbY((object) columnType), columnType.Length, columnType.Scale);

    public string Get(DbType typecode) => this.Get(typecode, new int?());

    public string Get(DbType typecode, int? length) => this.Get(typecode, length, new int?());

    public string Get(DbType typecode, int? length, int? scale)
    {
      Pair<string, int?> pair = (Pair<string, int?>) null;
      if (length.HasValue)
        pair = this.GetValue(typecode, length.Value);
      if (pair == null)
        pair = new Pair<string, int?>(this.GetDefaultValue(typecode), new int?());
      return TypeNames.Replace((object) pair.First, length, scale ?? pair.Second);
    }

    /// <summary>
    /// Проверка, содержит ли провайдер мэппинг для заданного типа
    /// </summary>
    /// <param name="type">Проверяемый тип</param>
    /// <returns>Если мэппинг для проверяемого типа установлен, возвращается true, иначе возвращается false.</returns>
    public bool HasType(DbType type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.typeMapping.ContainsKey(type))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return this.defaults.ContainsKey(type);
label_3:
      return true;
    }

    private static string Replace(object type, int? size, int? scale)
    {
      if (size.HasValue)
        type = (object) StringUtils.ReplaceOnce((string) type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539237871), size.ToString());
      if (scale.HasValue)
        type = (object) StringUtils.ReplaceOnce((string) type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574393848), scale.ToString());
      return (string) type;
    }

    public TypeNames()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.typeMapping = new Dictionary<DbType, SortedList<int, Pair<string, int?>>>();
      this.defaults = new Dictionary<DbType, string>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool gWZr3KWOIVrQD5dbwZEn() => TypeNames.TKmUJpWOuexbZLXmh9o5 == null;

    internal static TypeNames m6fSAeWOVwGZBwpJcMqk() => TypeNames.TKmUJpWOuexbZLXmh9o5;

    internal static object wwDaptWOSmCWCyWB7u0B([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static DbType r8uhNWWOiDLa1fmkbfbY([In] object obj0) => ((ColumnType) obj0).DataType;
  }
}
