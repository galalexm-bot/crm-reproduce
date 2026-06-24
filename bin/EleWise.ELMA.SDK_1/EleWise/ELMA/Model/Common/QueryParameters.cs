// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.QueryParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Common
{
  /// <summary>Коллекция параметров EQL-запроса</summary>
  [Serializable]
  public class QueryParameters : 
    IDictionary<string, object>,
    ICollection<KeyValuePair<string, object>>,
    IEnumerable<KeyValuePair<string, object>>,
    IEnumerable
  {
    private readonly IDictionary<string, object> dictionary;
    internal static QueryParameters PaJpNChqDibWZk1LYm6f;

    /// <summary>ctor</summary>
    public QueryParameters()
    {
      QueryParameters.MOyjGIhq420tgJPUkJtu();
      // ISSUE: explicit constructor call
      this.\u002Ector((IDictionary<string, object>) new SerializableDictionary<string, object>());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>ctor</summary>
    /// <param name="dictionary">Контейнер для хранения значений параметров</param>
    protected QueryParameters(IDictionary<string, object> dictionary)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.dictionary = dictionary;
    }

    /// <inheritdoc />
    public int Count => QueryParameters.P9vII1hq65E3QT6JQabO((object) this.dictionary);

    /// <inheritdoc />
    public object this[string key]
    {
      get => this.dictionary[this.TrimKey(key)];
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
              this.dictionary[this.TrimKey(key)] = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
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

    /// <summary>Имена параметров</summary>
    public ICollection<string> ParameterNames => this.dictionary.Keys;

    /// <summary>Проверяет содержит ли коллекция заданный параметр</summary>
    /// <param name="name">Имя параметра</param>
    /// <returns></returns>
    public bool Contains(string name) => this.dictionary.ContainsKey(this.TrimKey(name));

    /// <summary>Возвращает значение параметра по переданному имени</summary>
    /// <param name="name">Имя параметра</param>
    /// <exception cref="T:EleWise.ELMA.Exceptions.VariableNotFoundException">Параметр не найден в коллекции</exception>
    /// <returns></returns>
    public object Get(string name)
    {
      int num = 1;
      object obj;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.TryGetValue(name, out obj))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      throw new VariableNotFoundException(name);
label_3:
      return obj;
    }

    [Obsolete("Not used", true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void FillPropertyParams(string key, string propertyName, Guid parentTypeUid)
    {
    }

    /// <summary>Возвращает значение параметра по переданному имени</summary>
    /// <param name="name">Имя параметра</param>
    /// <param name="value">Значение параметра</param>
    /// <returns>true, если параметр найден в коллекции, иначе false</returns>
    public bool TryGetValue(string name, out object value) => this.dictionary.TryGetValue(this.TrimKey(name), out value);

    /// <summary>
    /// Добавляет новое значение в коллекцию параметров EQL-запроса, или обновляет значение уже существующего параметра
    /// </summary>
    /// <param name="name">Имя параметра</param>
    /// <param name="value">Значение для параметра</param>
    /// <returns></returns>
    public QueryParameters Set(string name, object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this[name] = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use Set(string name, object value) instead", true)]
    public QueryParameters Set(string name, QueryParameter value) => this.Set(name, QueryParameters.QjVRkLhqHPBkgYscUtXL((object) value));

    /// <summary>Удаляет параметр из коллекции</summary>
    /// <param name="key">Имя параметра</param>
    public void Remove(string key)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.dictionary.Remove(this.TrimKey(key));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Очищает коллекцию параметров EQL-запроса</summary>
    public void Clear()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.dictionary.Clear();
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

    /// <inheritdoc />
    public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => this.dictionary.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

    void IDictionary<string, object>.Add(string key, object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.dictionary.Add(this.TrimKey(key), value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    bool IDictionary<string, object>.Remove(string key) => this.dictionary.Remove(this.TrimKey(key));

    ICollection<string> IDictionary<string, object>.Keys => this.ParameterNames;

    ICollection<object> IDictionary<string, object>.Values => this.dictionary.Values;

    bool ICollection<KeyValuePair<string, object>>.IsReadOnly => false;

    void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> item) => this.dictionary.Add(this.TrimKey(item.Key), item.Value);

    bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> item)
    {
      object obj;
      return this.dictionary.TryGetValue(this.TrimKey(item.Key), out obj) && obj == item.Value;
    }

    bool IDictionary<string, object>.ContainsKey(string key) => this.Contains(key);

    void ICollection<KeyValuePair<string, object>>.CopyTo(
      KeyValuePair<string, object>[] array,
      int arrayIndex)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.dictionary.CopyTo(array, arrayIndex);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> item)
    {
      string key = this.TrimKey(item.Key);
      object obj;
      return this.dictionary.TryGetValue(key, out obj) && obj == item.Value && this.dictionary.Remove(key);
    }

    protected IDictionary<string, object> Dictionary => this.dictionary;

    protected string TrimKey(string key)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (QueryParameters.MmmZgJhqAKb2xXp6faSE((object) key) <= 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 3:
            if (QueryParameters.wQM5IZhq7JosTBeUsR6g((object) key, QueryParameters.MmmZgJhqAKb2xXp6faSE((object) key) - 1) == ']')
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 7 : 7;
              continue;
            }
            goto label_14;
          case 4:
          case 6:
            goto label_14;
          case 5:
            if (QueryParameters.wQM5IZhq7JosTBeUsR6g((object) key, 0) == '@')
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 8 : 5;
              continue;
            }
            goto default;
          case 7:
            key = ((string) QueryParameters.EanyvThq0FFlXBFE1EBK((object) key, 1, QueryParameters.MmmZgJhqAKb2xXp6faSE((object) key) - 2)).Replace((string) QueryParameters.cCUvQphqmrMj7UGSbFA6(~-306453669 ^ 306665968), z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979190573)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398715392), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876067769));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 6 : 5;
            continue;
          case 8:
            key = (string) QueryParameters.kfOGLrhqxaefG9Y1HbJq((object) key, 1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 2;
            continue;
          case 9:
            if (QueryParameters.wQM5IZhq7JosTBeUsR6g((object) key, 0) == '[')
            {
              num = 3;
              continue;
            }
            goto label_14;
          default:
            if (QueryParameters.MmmZgJhqAKb2xXp6faSE((object) key) <= 2)
            {
              num = 4;
              continue;
            }
            goto case 9;
        }
      }
label_14:
      return key;
    }

    internal static void MOyjGIhq420tgJPUkJtu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool OIcTJDhqtcDUESuNUdB0() => QueryParameters.PaJpNChqDibWZk1LYm6f == null;

    internal static QueryParameters G9eTdPhqwAlOM6C9pFx8() => QueryParameters.PaJpNChqDibWZk1LYm6f;

    internal static int P9vII1hq65E3QT6JQabO([In] object obj0) => ((ICollection<KeyValuePair<string, object>>) obj0).Count;

    internal static object QjVRkLhqHPBkgYscUtXL([In] object obj0) => ((QueryParameter) obj0).Value;

    internal static int MmmZgJhqAKb2xXp6faSE([In] object obj0) => ((string) obj0).Length;

    internal static char wQM5IZhq7JosTBeUsR6g([In] object obj0, [In] int obj1) => ((string) obj0)[obj1];

    internal static object kfOGLrhqxaefG9Y1HbJq([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static object EanyvThq0FFlXBFE1EBK([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object cCUvQphqmrMj7UGSbFA6(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
