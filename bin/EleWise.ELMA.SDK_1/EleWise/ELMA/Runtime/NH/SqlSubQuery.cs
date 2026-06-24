// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.SqlSubQuery
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Impl;
using NHibernate.Type;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>Подзапрос для использования в критериях NHibernate</summary>
  public class SqlSubQuery
  {
    private string baseSql;
    private string resultSql;
    private TypedValue[] resultParameters;
    private Dictionary<string, TypedValue> parameters;
    private Dictionary<string, TypedValue> parametersLists;
    private bool changed;
    private EntityMode entityMode;
    internal static SqlSubQuery JpOeDjWwBL2bKPmk0C57;

    /// <summary>Ctor</summary>
    /// <param name="query">Именованный SQL запрос, на основе которого строится подзапрос</param>
    /// <param name="session">Сессия</param>
    public SqlSubQuery(SqlQueryImpl query, ISession session)
    {
      SqlSubQuery.YJsG5GWwbxdE1pOv6HT0();
      // ISSUE: explicit constructor call
      this.\u002Ector((string) SqlSubQuery.rRIZnrWwhm3BtSFEdWrC((object) query), session);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="queryString">SQL запрос, на основе которого строится подзапрос</param>
    /// <param name="session">Сессия</param>
    public SqlSubQuery(string queryString, ISession session)
    {
      SqlSubQuery.YJsG5GWwbxdE1pOv6HT0();
      this.parameters = new Dictionary<string, TypedValue>();
      this.parametersLists = new Dictionary<string, TypedValue>();
      this.changed = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.baseSql = queryString;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
            continue;
          default:
            this.entityMode = EntityMode.Poco;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Установить значение параметра по имени</summary>
    /// <param name="name">Имя параметра</param>
    /// <param name="val">Значение параметра (не может быть Null)</param>
    /// <returns></returns>
    public SqlSubQuery SetParameter(string name, object val)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (val != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          case 3:
            goto label_6;
          default:
            this.SetParameter(name, val, this.DetermineType(name, val));
            num = 3;
            continue;
        }
      }
label_4:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345287386));
label_6:
      return this;
    }

    /// <summary>Установить значение параметра по имени</summary>
    /// <param name="name">Имя параметра</param>
    /// <param name="val">Значение параметра</param>
    /// <param name="type">Тип значения</param>
    /// <returns></returns>
    public SqlSubQuery SetParameter(string name, object val, IType type)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            this.parameters[name] = new TypedValue(type, val);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 1;
            continue;
          case 3:
            this.changed = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 2;
            continue;
          case 4:
            if (name != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 3 : 3;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      throw new ArgumentNullException((string) SqlSubQuery.fAlk1hWwGd78S7SHFM9d(~-306453669 ^ 306450610));
label_4:
      return this;
    }

    /// <summary>Установить значение списка параметров по имени</summary>
    /// <param name="name">Имя параметра</param>
    /// <param name="vals">Список значений</param>
    /// <returns></returns>
    public SqlSubQuery SetParameterList(string name, ICollection vals)
    {
      int num = 1;
      IEnumerator enumerator;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (vals == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            }
            if (SqlSubQuery.gxu5RVWwfmPeYKsO15oU((object) vals) == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 2;
              continue;
            }
            goto case 4;
          case 2:
            this.SetParameterList(name, vals, (IType) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 3;
            continue;
          case 3:
          case 6:
            goto label_3;
          case 4:
            enumerator = (IEnumerator) SqlSubQuery.hgJHrZWwQLL0ADJSYJG8((object) vals);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 7 : 2;
            continue;
          case 5:
            this.SetParameterList(name, vals, this.DetermineType(name, SqlSubQuery.XnuBmvWwvLI71QWYaP4p((object) enumerator)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 6 : 3;
            continue;
          case 7:
            SqlSubQuery.zs3X2lWwCfc33t27T8GJ((object) enumerator);
            num = 5;
            continue;
          default:
            goto label_8;
        }
      }
label_3:
      return this;
label_8:
      throw new QueryException((string) SqlSubQuery.F3x0dOWwEA6qHVSxCifF(SqlSubQuery.fAlk1hWwGd78S7SHFM9d(-105199646 ^ -105322738)));
    }

    /// <summary>Установить значение списка параметров по имени</summary>
    /// <param name="name">Имя параметра</param>
    /// <param name="values">Список значений</param>
    /// <param name="type">Тип элемента</param>
    /// <returns></returns>
    public SqlSubQuery SetParameterList(string name, ICollection values, IType type)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.parametersLists[name] = new TypedValue(type, (object) values);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
            continue;
          case 2:
            this.changed = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>Конечный текст запроса</summary>
    public string Sql
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.Prepare();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return this.resultSql;
      }
    }

    /// <summary>Конечный список параметров</summary>
    public TypedValue[] Parameters
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.Prepare();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return this.resultParameters;
      }
    }

    /// <summary>Конечный список значений параметров</summary>
    public object[] ParametersValues
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.Prepare();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return ((IEnumerable<TypedValue>) this.resultParameters).Select<TypedValue, object>((Func<TypedValue, object>) (p => SqlSubQuery.\u003C\u003Ec.JTCURKQdAKoLLjKdxRRM((object) p))).ToArray<object>();
      }
    }

    /// <summary>Конечный список типов параметров</summary>
    public IType[] ParametersTypes
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.Prepare();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        TypedValue[] resultParameters = this.resultParameters;
        Func<TypedValue, IType> func = SqlSubQuery.\u003C\u003Ec.\u003C\u003E9__13_0;
        Func<TypedValue, IType> selector;
        if (func == null)
          SqlSubQuery.\u003C\u003Ec.\u003C\u003E9__13_0 = selector = (Func<TypedValue, IType>) (p => p.Type);
        else
          goto label_4;
label_6:
        return ((IEnumerable<TypedValue>) resultParameters).Select<TypedValue, IType>(selector).ToArray<IType>();
label_4:
        selector = func;
        goto label_6;
      }
    }

    private string ExpandParameterList(
      string query,
      string name,
      TypedValue typedList,
      IDictionary<string, TypedValue> namedParamsCopy)
    {
      ICollection collection = (ICollection) typedList.Value;
      IType type = typedList.Type;
      if (collection.Count == 1)
      {
        IEnumerator enumerator = collection.GetEnumerator();
        enumerator.MoveNext();
        namedParamsCopy[name] = new TypedValue(type, enumerator.Current);
        return query;
      }
      StringBuilder stringBuilder = new StringBuilder(16);
      int num = 0;
      bool flag = false;
      foreach (object obj in (IEnumerable) collection)
      {
        if (num > 0)
          stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712481717));
        string key = (flag ? (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099612057) + name) : (object) (name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633517521))).ToString() + (object) num++ + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767721599);
        namedParamsCopy[key] = new TypedValue(type, obj);
        stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979395836)).Append(key);
      }
      string str = flag ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998540944) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413607773);
      return StringHelper.Replace(query, str + name, stringBuilder.ToString(), true);
    }

    private string ExpandParameterLists(IDictionary<string, TypedValue> namedParamsCopy)
    {
      string query = this.baseSql;
      foreach (KeyValuePair<string, TypedValue> parametersList in this.parametersLists)
        query = this.ExpandParameterList(query, parametersList.Key, parametersList.Value, namedParamsCopy);
      return query;
    }

    private void Prepare()
    {
      int num1 = 15;
      while (true)
      {
        int num2 = num1;
        Dictionary<string, TypedValue> namedParamsCopy;
        List<Tuple<int, string, TypedValue>> source;
        List<TypedValue> typedValueList;
        Dictionary<string, TypedValue>.Enumerator enumerator1;
        List<Tuple<int, string, TypedValue>>.Enumerator enumerator2;
        string str1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_56;
            case 1:
              goto label_18;
            case 2:
              goto label_3;
            case 3:
              this.resultParameters = (TypedValue[]) SqlSubQuery.nr03M7WwimDSo9ZFFx0o((object) typedValueList);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 7 : 7;
              continue;
            case 4:
label_59:
              source = source.OrderBy<Tuple<int, string, TypedValue>, int>((Func<Tuple<int, string, TypedValue>, int>) (t => t.Item1)).ToList<Tuple<int, string, TypedValue>>();
              num2 = 13;
              continue;
            case 5:
              try
              {
label_10:
                if (enumerator1.MoveNext())
                  goto label_12;
                else
                  goto label_11;
label_8:
                KeyValuePair<string, TypedValue> current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_10;
                    case 2:
                      goto label_12;
                    case 3:
                      namedParamsCopy[current.Key] = current.Value;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 1;
                      continue;
                    default:
                      goto label_38;
                  }
                }
label_11:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
                goto label_8;
label_12:
                current = enumerator1.Current;
                num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
                {
                  num3 = 3;
                  goto label_8;
                }
                else
                  goto label_8;
              }
              finally
              {
                enumerator1.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 6:
              enumerator1 = this.parameters.GetEnumerator();
              num2 = 5;
              continue;
            case 7:
              this.changed = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 2 : 2;
              continue;
            case 8:
              try
              {
label_28:
                if (enumerator2.MoveNext())
                  goto label_26;
                else
                  goto label_29;
label_23:
                Tuple<int, string, TypedValue> current;
                string str2;
                int num5;
                int num6;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      typedValueList.Add(current.Item3);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                      continue;
                    case 2:
                      str1 = (string) SqlSubQuery.HaEhXkWwSBAP7J22ZZjq(SqlSubQuery.GrkU7jWwIHvQNwyrPj9a((object) str1, 0, num5), SqlSubQuery.fAlk1hWwGd78S7SHFM9d(-2092274397 << 4 ^ 883346042), SqlSubQuery.B08VfZWwVQlTofUTw4ZR((object) str1, num5 + str2.Length));
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 0;
                      continue;
                    case 3:
                      str2 = (string) SqlSubQuery.tRwGLeWw8tVGn7vmnciE(SqlSubQuery.fAlk1hWwGd78S7SHFM9d(901793403 ^ 901846841), (object) current.Item2);
                      num6 = 5;
                      continue;
                    case 4:
                      goto label_26;
                    case 5:
                      num5 = SqlSubQuery.xjr6ipWwZWlV7BlfJaeA((object) str1, (object) str2, StringComparison.InvariantCultureIgnoreCase);
                      num6 = 2;
                      continue;
                    case 6:
                      goto label_36;
                    default:
                      goto label_28;
                  }
                }
label_26:
                current = enumerator2.Current;
                num6 = 3;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
                {
                  num6 = 3;
                  goto label_23;
                }
                else
                  goto label_23;
label_29:
                num6 = 6;
                goto label_23;
              }
              finally
              {
                enumerator2.Dispose();
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
                  num7 = 0;
                switch (num7)
                {
                  default:
                }
              }
            case 9:
label_38:
              str1 = this.ExpandParameterLists((IDictionary<string, TypedValue>) namedParamsCopy);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 3 : 10;
              continue;
            case 10:
              source = new List<Tuple<int, string, TypedValue>>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
              continue;
            case 11:
              try
              {
label_50:
                if (enumerator1.MoveNext())
                  goto label_43;
                else
                  goto label_51;
label_41:
                string str3;
                int num8;
                KeyValuePair<string, TypedValue> current;
                int num9;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      num8 = SqlSubQuery.xjr6ipWwZWlV7BlfJaeA((object) str1, (object) str3, StringComparison.InvariantCultureIgnoreCase);
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 3;
                      continue;
                    case 2:
                      num8 = SqlSubQuery.YPKmONWwu5Cwe83oDgei((object) str1, (object) str3, num8 + 1, StringComparison.InvariantCultureIgnoreCase);
                      num9 = 5;
                      continue;
                    case 3:
                    case 5:
                      if (num8 <= 0)
                      {
                        num9 = 8;
                        continue;
                      }
                      goto case 7;
                    case 4:
                      str3 = (string) SqlSubQuery.tRwGLeWw8tVGn7vmnciE((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901846841), (object) current.Key);
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 1;
                      continue;
                    case 6:
                      goto label_43;
                    case 7:
                      source.Add(new Tuple<int, string, TypedValue>(num8, current.Key, current.Value));
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 2 : 2;
                      continue;
                    case 8:
                      goto label_50;
                    default:
                      goto label_59;
                  }
                }
label_43:
                current = enumerator1.Current;
                num9 = 4;
                goto label_41;
label_51:
                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
                goto label_41;
              }
              finally
              {
                enumerator1.Dispose();
                int num10 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
                  num10 = 0;
                switch (num10)
                {
                  default:
                }
              }
            case 12:
label_36:
              this.resultSql = str1;
              num2 = 3;
              continue;
            case 13:
              typedValueList = new List<TypedValue>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 16 : 6;
              continue;
            case 14:
              namedParamsCopy = new Dictionary<string, TypedValue>();
              num2 = 6;
              continue;
            case 15:
              if (this.changed)
              {
                num2 = 14;
                continue;
              }
              goto label_52;
            case 16:
              enumerator2 = source.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 2 : 8;
              continue;
            default:
              goto label_47;
          }
        }
label_18:
        enumerator1 = namedParamsCopy.GetEnumerator();
        num1 = 11;
      }
label_56:
      return;
label_3:
      return;
label_47:
      return;
label_52:;
    }

    private IType DetermineType(string paramName, object paramValue) => NHibernateUtil.GuessType(paramValue);

    internal static void YJsG5GWwbxdE1pOv6HT0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object rRIZnrWwhm3BtSFEdWrC([In] object obj0) => (object) ((AbstractQueryImpl) obj0).QueryString;

    internal static bool sfaWg2WwWBml1EsRyrCh() => SqlSubQuery.JpOeDjWwBL2bKPmk0C57 == null;

    internal static SqlSubQuery AgvZgcWwoFFfw1ppk0Wf() => SqlSubQuery.JpOeDjWwBL2bKPmk0C57;

    internal static object fAlk1hWwGd78S7SHFM9d(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object F3x0dOWwEA6qHVSxCifF([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static int gxu5RVWwfmPeYKsO15oU([In] object obj0) => ((ICollection) obj0).Count;

    internal static object hgJHrZWwQLL0ADJSYJG8([In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

    internal static bool zs3X2lWwCfc33t27T8GJ([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object XnuBmvWwvLI71QWYaP4p([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static object tRwGLeWw8tVGn7vmnciE([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static int xjr6ipWwZWlV7BlfJaeA([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).IndexOf((string) obj1, obj2);

    internal static int YPKmONWwu5Cwe83oDgei(
      [In] object obj0,
      [In] object obj1,
      [In] int obj2,
      [In] StringComparison obj3)
    {
      return ((string) obj0).IndexOf((string) obj1, obj2, obj3);
    }

    internal static object GrkU7jWwIHvQNwyrPj9a([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object B08VfZWwVQlTofUTw4ZR([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static object HaEhXkWwSBAP7J22ZZjq([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object nr03M7WwimDSo9ZFFx0o([In] object obj0) => (object) ((List<TypedValue>) obj0).ToArray();
  }
}
