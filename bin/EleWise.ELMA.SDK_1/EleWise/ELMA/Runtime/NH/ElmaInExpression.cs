// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.ElmaInExpression
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.SqlCommand;
using NHibernate.SqlTypes;
using NHibernate.Type;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>
  /// <see cref="T:NHibernate.Criterion.ICriterion" /> ограничивающий свойство фиксированным списком значений
  /// </summary>
  /// <remarks>
  /// ElmaInExpression - может использоваться только для колонки единственного значения - не для свойств с мультиколонкой...
  /// <br />
  /// Для большого списка значений (1000) ElmaInExpression используется хранимую функцию SplitString для передачи значений в запрос.
  /// </remarks>
  [Serializable]
  public class ElmaInExpression : InExpression
  {
    private readonly IProjection _projection;
    private readonly string _propertyName;
    private readonly string _delimiter;
    /// <summary>Название функции в БД</summary>
    public const string ElmaInExpressionTableFunctionName = "SplitString";
    /// <summary>Максимальный размер параметров в выражении in</summary>
    internal const int MaxInCount = 1000;
    private static readonly ConcurrentDictionary<Guid, Pair<string, string>> splitStringFunctions;
    private IType[] types;
    private static ElmaInExpression zITU1mWpwsfdktquuwVA;

    internal static void Init() => ElmaInExpression.iPCNIGWpHnrUQJyoxoHO();

    [Obsolete]
    private static void InitObsolete()
    {
      int num = 1;
      while (true)
      {
        Func<string, object[], AbstractCriterion> inExpressionCtorString;
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            Func<string, object[], AbstractCriterion> func1 = ElmaInExpression.\u003C\u003Ec.\u003C\u003E9__5_0;
            if (func1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
              continue;
            }
            inExpressionCtorString = func1;
            break;
          case 2:
            goto label_6;
          default:
            // ISSUE: reference to a compiler-generated field
            ElmaInExpression.\u003C\u003Ec.\u003C\u003E9__5_0 = inExpressionCtorString = (Func<string, object[], AbstractCriterion>) ((p, v) => (AbstractCriterion) new ElmaInExpression(p, (IEnumerable) v, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824389145)));
            break;
        }
        // ISSUE: reference to a compiler-generated field
        Func<IProjection, object[], AbstractCriterion> func2 = ElmaInExpression.\u003C\u003Ec.\u003C\u003E9__5_1;
        Func<IProjection, object[], AbstractCriterion> inExpressionCtorProjection;
        if (func2 == null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          ElmaInExpression.\u003C\u003Ec.\u003C\u003E9__5_1 = inExpressionCtorProjection = (Func<IProjection, object[], AbstractCriterion>) ((p, v) => (AbstractCriterion) new ElmaInExpression(p, (IEnumerable) v, (string) ElmaInExpression.\u003C\u003Ec.Vj8WTEQJ1VxEfDCdoofu(-2099751081 ^ -2099750099)));
        }
        else
          goto label_9;
label_8:
        Restrictions.InitInExpression(inExpressionCtorString, inExpressionCtorProjection);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 2 : 2;
        continue;
label_9:
        inExpressionCtorProjection = func2;
        goto label_8;
      }
label_6:;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="projection">Проекция</param>
    /// <param name="values">Список значений</param>
    /// <param name="delimiter">Разделитель при использовании хранимой функции SplitString</param>
    [Obsolete("Use Restrictions.In instead", true)]
    public ElmaInExpression(IProjection projection, IEnumerable values, string delimiter = "_")
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(projection, values.CastToArrayOrNull<object>());
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._projection = projection;
            num = 2;
            continue;
          case 2:
            this._delimiter = delimiter;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="propertyName">Наименование свойства</param>
    /// <param name="values">Список значений</param>
    /// <param name="delimiter">Разделитель при использовании хранимой функции SplitString</param>
    [Obsolete("Use Restrictions.In instead", true)]
    public ElmaInExpression(string propertyName, IEnumerable values, string delimiter = "_")
    {
      ElmaInExpression.Tf0KCRWpAbD81c0rLTcK();
      // ISSUE: explicit constructor call
      base.\u002Ector(propertyName, values.CastToArrayOrNull<object>());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._delimiter = delimiter;
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            this._propertyName = propertyName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    private IType[] GetTypes(ICriteria criteria, ICriteriaQuery criteriaQuery)
    {
      int num = 1;
      IType[] types1;
      IType[] types2;
      while (true)
      {
        switch (num)
        {
          case 1:
            types2 = this.types;
            if (types2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            goto label_9;
          default:
            object obj;
            if (this._projection != null)
              obj = ElmaInExpression.hFxV9qWp7ZCYcHNfaWq3((object) this._projection, (object) criteria, (object) criteriaQuery);
            else
              obj = (object) new IType[1]
              {
                (IType) ElmaInExpression.Gnky5RWpxBOENG3Wgkrk((object) criteriaQuery, (object) criteria, (object) this._propertyName)
              };
            types1 = (IType[]) obj;
            this.types = (IType[]) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 2 : 0;
            continue;
        }
      }
label_3:
      return types2;
label_9:
      return types1;
    }

    private bool CallBase(ICriteria criteria, ICriteriaQuery criteriaQuery)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.Values.Length <= 1000)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 2:
            if (ElmaInExpression.m5BeC8Wp0p2Ttku5lp2y((object) this) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 1;
              continue;
            }
            goto label_5;
          case 3:
            goto label_4;
          case 4:
            if (!ElmaInExpression.G1qPo3WpmcRHtT8tu86t((object) this.types[0]))
            {
              num = 3;
              continue;
            }
            goto label_5;
          case 5:
            if (this.GetTypes(criteria, criteriaQuery).Length == 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 4 : 2;
              continue;
            }
            goto label_5;
          default:
            goto label_5;
        }
      }
label_4:
      return ElmaInExpression.YiTYVyWpJPo7iBjF3EBi(ElmaInExpression.i7yvgSWpyGlNAZ0t51wp((object) this.types[0]), ElmaInExpression.X1VYkMWpMD3rI1qMd8A6((object) NHibernateUtil.String));
label_5:
      return true;
    }

    /// <inheritdoc />
    public override SqlString ToSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery)
    {
      int num1 = 2;
      string str1;
      Pair<string, string> orAdd;
      SqlString[] columnNames;
      Parameter[] array;
      while (true)
      {
        int num2 = num1;
        ITransformationProvider transform;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (this.CallBase(criteria, criteriaQuery))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 2 : 4;
                continue;
              }
              goto label_5;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 1;
              continue;
            case 3:
              orAdd = ElmaInExpression.splitStringFunctions.GetOrAdd(ElmaInExpression.h2gjXuWpdQVXueuEEAXW((object) transform), (System.Func<Guid, Pair<string, string>>) (guid =>
              {
                string str2 = transform.TableFunction(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479628470), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672068596));
                int startIndex = str2.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909306493), StringComparison.InvariantCulture);
                return new Pair<string, string>(str2.Remove(startIndex), str2.Substring(startIndex + 4));
              }));
              num2 = 6;
              continue;
            case 4:
              goto label_4;
            case 5:
              goto label_7;
            case 6:
              columnNames = CriterionUtil.GetColumnNames(this._propertyName, this._projection, criteriaQuery, criteria);
              num2 = 7;
              continue;
            case 7:
              array = this.GetParameterTypedValues(criteria, criteriaQuery, this._projection == null ? 0 : this._projection.GetTypedValues(criteria, criteriaQuery).Length).SelectMany<TypedValue, Parameter>(new System.Func<TypedValue, IEnumerable<Parameter>>(criteriaQuery.NewQueryParameter)).ToArray<Parameter>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
              continue;
            default:
              str1 = (string) ElmaInExpression.kKW0JwWpgjrG96rr5Jmc(ElmaInExpression.ag7iUrWplin5UiN2PXS3((object) criteriaQuery.Factory), ElmaInExpression.P0RbjtWprk2TAoIhlOwO((object) this.GetTypes(criteria, criteriaQuery)[0], (object) criteriaQuery.Factory)[0]);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 5;
              continue;
          }
        }
label_5:
        transform = Locator.GetServiceNotNull<ITransformationProvider>();
        num1 = 3;
      }
label_4:
      return (SqlString) ElmaInExpression.nA90IqWp96AS3AWKr2It((object) this, (object) criteria, (object) criteriaQuery);
label_7:
      SqlStringBuilder sqlStringBuilder = new SqlStringBuilder();
      ElmaInExpression.ey37fIWpYdeJbREHYYen(ElmaInExpression.ey37fIWpYdeJbREHYYen(ElmaInExpression.XSZdobWpLeZuBOwD9xEl(ElmaInExpression.ey37fIWpYdeJbREHYYen((object) ((SqlStringBuilder) ElmaInExpression.ey37fIWpYdeJbREHYYen(ElmaInExpression.ey37fIWpYdeJbREHYYen((object) ((SqlStringBuilder) ElmaInExpression.ey37fIWpYdeJbREHYYen(ElmaInExpression.ey37fIWpYdeJbREHYYen(ElmaInExpression.ey37fIWpYdeJbREHYYen(ElmaInExpression.ey37fIWpYdeJbREHYYen(ElmaInExpression.ey37fIWpYdeJbREHYYen((object) ((SqlStringBuilder) ElmaInExpression.CF5isnWp5quOvtI7rBJx((object) sqlStringBuilder, (object) columnNames[0])).Add((string) ElmaInExpression.Ni4BxCWpjculWhcW4C2K(-1872275253 >> 6 ^ -29129307)).Add((string) ElmaInExpression.Ni4BxCWpjculWhcW4C2K(322893104 - -1992822529 ^ -1979237327)).Add((string) ElmaInExpression.Ni4BxCWpjculWhcW4C2K(-1255365154 ^ 596875508 ^ -1765988866)), ElmaInExpression.Ni4BxCWpjculWhcW4C2K(874012245 ^ 874137271)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583608296)), (object) str1), ElmaInExpression.Ni4BxCWpjculWhcW4C2K(712480695 ^ 712476683)), ElmaInExpression.Ni4BxCWpjculWhcW4C2K(333888594 ^ 1075625116 ^ 1408768034))).Add((string) ElmaInExpression.Ni4BxCWpjculWhcW4C2K(-643786247 ^ -643819353)), ElmaInExpression.Ni4BxCWpjculWhcW4C2K(1917256330 ^ 1917270680)), (object) orAdd.First)).Add(array[0]), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654296923)), (object) array[1]), (object) orAdd.Second), ElmaInExpression.Ni4BxCWpjculWhcW4C2K(1242972401 >> 4 ^ 77691827));
      return (SqlString) ElmaInExpression.IRsjJFWpU5NZtFcqtlTq((object) sqlStringBuilder);
    }

    public override TypedValue[] GetTypedValues(ICriteria criteria, ICriteriaQuery criteriaQuery)
    {
      int num1 = 4;
      TypedValue[] first;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          object obj;
          switch (num2)
          {
            case 1:
              obj = (object) new TypedValue[0];
              break;
            case 2:
              obj = ElmaInExpression.rWhlZeWpcuFWd7ph2ccL((object) this._projection, (object) criteria, (object) criteriaQuery);
              break;
            case 3:
              goto label_6;
            case 4:
              if (this.CallBase(criteria, criteriaQuery))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 3 : 3;
                continue;
              }
              if (this._projection == null)
                goto case 1;
              else
                goto label_8;
            default:
              goto label_9;
          }
          first = (TypedValue[]) obj;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
        }
label_8:
        num1 = 2;
      }
label_6:
      return (TypedValue[]) ElmaInExpression.hG4Nd1Wps2rKupaZLnbS((object) this, (object) criteria, (object) criteriaQuery);
label_9:
      return ((IEnumerable<TypedValue>) first).Concat<TypedValue>(this.GetParameterTypedValues(criteria, criteriaQuery, first.Length)).ToArray<TypedValue>();
    }

    private IEnumerable<TypedValue> GetParameterTypedValues(
      ICriteria criteria,
      ICriteriaQuery criteriaQuery,
      int projectionParametersCount)
    {
      return (IEnumerable<TypedValue>) new TypedValue[2]
      {
        ElmaInExpression.JoinedValuesType.GetTypedValue((object) this.GetTypes(criteria, criteriaQuery)[0], (object) this.Values, (object) this._delimiter),
        new TypedValue((IType) NHibernateUtil.String, (object) this._delimiter)
      };
    }

    /// <summary>
    /// Формирование строки для ограничения колонки базы данных указанного типа фиксированным набором значений
    /// </summary>
    /// <param name="columnName">Имя колонки базы данных</param>
    /// <param name="values">Значения для ограничения</param>
    /// <param name="typecode">Тип колонки</param>
    /// <param name="length">Ограничение типа по длине</param>
    /// <param name="scale"></param>
    /// <param name="delimiter">Разделитель для значений при использовании хранимой функции SplitString</param>
    /// <returns></returns>
    public static string ToString(
      string columnName,
      IEnumerable values,
      DbType typecode = DbType.Int64,
      int? length = null,
      int? scale = null,
      string delimiter = "_")
    {
      object[] arrayOrNull = values.CastToArrayOrNull<object>();
      if (arrayOrNull == null || arrayOrNull.Length == 0)
        return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97843026);
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(columnName).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979376393));
      if (arrayOrNull.Length <= 1000)
      {
        stringBuilder.Append(string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195615465), arrayOrNull));
      }
      else
      {
        ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
        stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289704342)).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561203792)).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372628683)).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021535129)).Append(serviceNotNull.Dialect.GetTypeName(typecode, length, scale)).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398655776)).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1200071905)).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765819276)).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70027726)).Append(serviceNotNull.TableFunction(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727496116), serviceNotNull.Dialect.QuoteString(string.Join(delimiter, arrayOrNull)) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957821374) + serviceNotNull.Dialect.QuoteString(delimiter)));
      }
      stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939378896));
      return stringBuilder.ToString();
    }

    /// <summary>
    /// Формирование строки для ограничения колонки базы данных указанного типа фиксированным набором значений
    /// </summary>
    /// <param name="columnName">Имя колонки базы данных</param>
    /// <param name="values">Значения для ограничения</param>
    /// <param name="sqlValues">Дополняемые значения параметров для sql запроса</param>
    /// <param name="sqlTypes">Дополняемые типы параметров для sql запроса</param>
    /// <param name="typecode">Тип колонки</param>
    /// <param name="length">Ограничение типа по длине</param>
    /// <param name="scale"></param>
    /// <param name="delimiter">Разделитель для значений при использовании хранимой функции SplitString</param>
    /// <returns></returns>
    public static string ToString(
      string columnName,
      IEnumerable values,
      List<object> sqlValues,
      List<IType> sqlTypes,
      DbType typecode = DbType.Int64,
      int? length = null,
      int? scale = null,
      string delimiter = "_")
    {
      object[] sqlValues1;
      IType[] sqlTypes1;
      string str = ElmaInExpression.ToString(columnName, values, out sqlValues1, out sqlTypes1, typecode, length, scale, delimiter);
      sqlValues.AddRange((IEnumerable<object>) sqlValues1);
      sqlTypes.AddRange((IEnumerable<IType>) sqlTypes1);
      return str;
    }

    /// <summary>
    /// Формирование строки для ограничения колонки базы данных указанного типа фиксированным набором значений
    /// </summary>
    /// <param name="columnName">Имя колонки базы данных</param>
    /// <param name="values">Значения для ограничения</param>
    /// <param name="sqlValues">Значения параметров для sql запроса</param>
    /// <param name="sqlTypes">Типы параметров для sql запроса</param>
    /// <param name="typecode">Тип колонки</param>
    /// <param name="length">Ограничение типа по длине</param>
    /// <param name="scale"></param>
    /// <param name="delimiter">Разделитель для значений при использовании хранимой функции SplitString</param>
    /// <returns></returns>
    public static string ToString(
      string columnName,
      IEnumerable values,
      out object[] sqlValues,
      out IType[] sqlTypes,
      DbType typecode = DbType.Int64,
      int? length = null,
      int? scale = null,
      string delimiter = "_")
    {
      object[] arrayOrNull = values.CastToArrayOrNull<object>();
      if (arrayOrNull == null || arrayOrNull.Length == 0)
      {
        sqlValues = new object[0];
        sqlTypes = new IType[0];
        return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217656383);
      }
      ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(columnName).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979376393));
      if (arrayOrNull.Length <= 1000)
      {
        // ISSUE: reference to a compiler-generated method
        stringBuilder.Append(string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132913469), ((IEnumerable<object>) arrayOrNull).Select<object, string>((System.Func<object, string>) (v => (string) ElmaInExpression.\u003C\u003Ec.Vj8WTEQJ1VxEfDCdoofu(1642859704 ^ 1642861810)))));
        sqlValues = arrayOrNull;
        sqlTypes = ((IEnumerable<object>) arrayOrNull).Select<object, IType>(new System.Func<object, IType>(NHibernateUtil.GuessType)).ToArray<IType>();
      }
      else
      {
        stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137448498)).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283510287)).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439477972)).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397399092)).Append(serviceNotNull.Dialect.GetTypeName(typecode, length, scale)).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234307412)).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488744153)).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132944993)).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099744955)).Append(serviceNotNull.TableFunction(z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 235942093), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642993060)));
        sqlValues = new object[2]
        {
          (object) string.Join(delimiter, arrayOrNull),
          (object) delimiter
        };
        sqlTypes = new IType[2]
        {
          (IType) NHibernateUtil.StringClob,
          (IType) NHibernateUtil.String
        };
      }
      stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654300389));
      return stringBuilder.ToString();
    }

    static ElmaInExpression()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ElmaInExpression.splitStringFunctions = new ConcurrentDictionary<Guid, Pair<string, string>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
            continue;
          case 2:
            ElmaInExpression.Tf0KCRWpAbD81c0rLTcK();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void iPCNIGWpHnrUQJyoxoHO() => ElmaInExpression.InitObsolete();

    internal static bool EEGx6cWp4CgnLZ7lm1cA() => ElmaInExpression.zITU1mWpwsfdktquuwVA == null;

    internal static ElmaInExpression AxENA4Wp6vYOPLprujA8() => ElmaInExpression.zITU1mWpwsfdktquuwVA;

    internal static void Tf0KCRWpAbD81c0rLTcK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object hFxV9qWp7ZCYcHNfaWq3([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IProjection) obj0).GetTypes((ICriteria) obj1, (ICriteriaQuery) obj2);

    internal static object Gnky5RWpxBOENG3Wgkrk([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ICriteriaQuery) obj0).GetTypeUsingProjection((ICriteria) obj1, (string) obj2);

    internal static object m5BeC8Wp0p2Ttku5lp2y([In] object obj0) => (object) ((InExpression) obj0).Values;

    internal static bool G1qPo3WpmcRHtT8tu86t([In] object obj0) => ((IType) obj0).IsComponentType;

    internal static System.Type i7yvgSWpyGlNAZ0t51wp([In] object obj0) => ((IType) obj0).ReturnedClass;

    internal static System.Type X1VYkMWpMD3rI1qMd8A6([In] object obj0) => ((AbstractType) obj0).ReturnedClass;

    internal static bool YiTYVyWpJPo7iBjF3EBi([In] System.Type obj0, [In] System.Type obj1) => obj0 == obj1;

    internal static object nA90IqWp96AS3AWKr2It([In] object obj0, [In] object obj1, [In] object obj2) => (object) __nonvirtual (((InExpression) obj0).ToSqlString((ICriteria) obj1, (ICriteriaQuery) obj2));

    internal static Guid h2gjXuWpdQVXueuEEAXW([In] object obj0) => ((ITransformationProvider) obj0).Uid;

    internal static object ag7iUrWplin5UiN2PXS3([In] object obj0) => (object) ((IMapping) obj0).Dialect;

    internal static object P0RbjtWprk2TAoIhlOwO([In] object obj0, [In] object obj1) => (object) ((IType) obj0).SqlTypes((IMapping) obj1);

    internal static object kKW0JwWpgjrG96rr5Jmc([In] object obj0, [In] object obj1) => (object) ((NHibernate.Dialect.Dialect) obj0).GetCastTypeName((SqlType) obj1);

    internal static object CF5isnWp5quOvtI7rBJx([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((SqlString) obj1);

    internal static object Ni4BxCWpjculWhcW4C2K(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object ey37fIWpYdeJbREHYYen([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((string) obj1);

    internal static object XSZdobWpLeZuBOwD9xEl([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((Parameter) obj1);

    internal static object IRsjJFWpU5NZtFcqtlTq([In] object obj0) => (object) ((SqlStringBuilder) obj0).ToSqlString();

    internal static object hG4Nd1Wps2rKupaZLnbS([In] object obj0, [In] object obj1, [In] object obj2) => (object) __nonvirtual (((InExpression) obj0).GetTypedValues((ICriteria) obj1, (ICriteriaQuery) obj2));

    internal static object rWhlZeWpcuFWd7ph2ccL([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IProjection) obj0).GetTypedValues((ICriteria) obj1, (ICriteriaQuery) obj2);

    private class JoinedValuesType : AbstractType
    {
      private readonly object sqlTypes;
      private static object HTid18QJ8j6BbECas9tZ;

      /// <inheritdoc />
      public override string ToLoggableString(object value, ISessionFactoryImplementor factory) => throw new NotImplementedException();

      /// <inheritdoc />
      public override bool IsDirty(
        object old,
        object current,
        bool[] checkable,
        ISessionImplementor session)
      {
        throw new NotImplementedException();
      }

      /// <inheritdoc />
      public override object DeepCopy(object val, ISessionFactoryImplementor factory) => throw new NotImplementedException();

      /// <inheritdoc />
      public override object Replace(
        object original,
        object current,
        ISessionImplementor session,
        object owner,
        IDictionary copiedAlready)
      {
        throw new NotImplementedException();
      }

      /// <inheritdoc />
      public override object NullSafeGet(
        DbDataReader rs,
        string[] names,
        ISessionImplementor session,
        object owner)
      {
        throw new NotImplementedException();
      }

      /// <inheritdoc />
      public override object NullSafeGet(
        DbDataReader rs,
        string name,
        ISessionImplementor session,
        object owner)
      {
        throw new NotImplementedException();
      }

      /// <inheritdoc />
      public override Task<object> ReplaceAsync(
        object original,
        object current,
        ISessionImplementor session,
        object owner,
        IDictionary copiedAlready,
        CancellationToken cancellationToken)
      {
        throw new NotImplementedException();
      }

      /// <inheritdoc />
      public override Task<object> NullSafeGetAsync(
        DbDataReader rs,
        string[] names,
        ISessionImplementor session,
        object owner,
        CancellationToken cancellationToken)
      {
        throw new NotImplementedException();
      }

      /// <inheritdoc />
      public override Task<object> NullSafeGetAsync(
        DbDataReader rs,
        string name,
        ISessionImplementor session,
        object owner,
        CancellationToken cancellationToken)
      {
        throw new NotImplementedException();
      }

      /// <inheritdoc />
      public override Task<bool> IsDirtyAsync(
        object old,
        object current,
        bool[] checkable,
        ISessionImplementor session,
        CancellationToken cancellationToken)
      {
        throw new NotImplementedException();
      }

      private static IType Singleton { get; }

      public static TypedValue GetTypedValue(object type, object values, object delimiter) => new TypedValue(ElmaInExpression.JoinedValuesType.Singleton, (object) new ElmaInExpression.JoinedValuesType.Value((IType) type, (object[]) values, (string) delimiter));

      /// <inheritdoc />
      public override bool[] ToColumnNullness(object value, IMapping mapping) => ArrayHelper.True;

      /// <inheritdoc />
      public override string Name => (string) ElmaInExpression.JoinedValuesType.GPTd5sQJIfUwNyFt4vfZ((object) NHibernateUtil.StringClob);

      /// <inheritdoc />
      public override System.Type ReturnedClass => ElmaInExpression.JoinedValuesType.k36bYnQJVIIlWKNOFcxK((object) NHibernateUtil.StringClob);

      /// <inheritdoc />
      public override bool IsMutable => ElmaInExpression.JoinedValuesType.pQS39cQJSMvk5SgeufZP((object) NHibernateUtil.StringClob);

      /// <inheritdoc />
      public override SqlType[] SqlTypes(IMapping mapping) => (SqlType[]) this.sqlTypes;

      /// <inheritdoc />
      public override int GetColumnSpan(IMapping mapping) => 1;

      /// <inheritdoc />
      public override void NullSafeSet(
        DbCommand st,
        object value,
        int index,
        bool[] settable,
        ISessionImplementor session)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.NullSafeSet(st, value, index, session);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
              continue;
            case 2:
              if (settable[0])
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 1;
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

      /// <inheritdoc />
      public override void NullSafeSet(
        DbCommand st,
        object value_obj,
        int index,
        ISessionImplementor session)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ElmaInExpression.JoinedValuesType.YVCbNtQJXbExuebjlB4w((object) ((DbParameterCollection) ElmaInExpression.JoinedValuesType.wGfSxuQJiqYANsPQih51((object) st))[index], (object) string.Join<object>((string) ElmaInExpression.JoinedValuesType.oUncVKQJRwKMdoVhBpYh((object) obj), session.NullSafeSet(Enumerable.Repeat<IType>((IType) ElmaInExpression.JoinedValuesType.WSVGw8QJqe8xZZBix0nu((object) obj), ElmaInExpression.JoinedValuesType.A193clQJKgb6qrTyd4Hl((object) obj).Length), (IEnumerable<object>) obj.Values)));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            case 2:
              if (value_obj is ElmaInExpression.JoinedValuesType.Value obj)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 0;
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

      /// <inheritdoc />
      public override Task NullSafeSetAsync(
        DbCommand st,
        object value,
        int index,
        bool[] settable,
        ISessionImplementor session,
        CancellationToken cancellationToken)
      {
        int num1 = 4;
        // ISSUE: variable of a compiler-generated type
        ElmaInExpression.JoinedValuesType.\u003CNullSafeSetAsync\u003Ed__26 stateMachine;
        while (true)
        {
          int num2 = num1;
          AsyncTaskMethodBuilder tBuilder;
          while (true)
          {
            switch (num2)
            {
              case 1:
                // ISSUE: reference to a compiler-generated field
                stateMachine.cancellationToken = cancellationToken;
                num2 = 5;
                continue;
              case 2:
                // ISSUE: reference to a compiler-generated field
                tBuilder = stateMachine.\u003C\u003Et__builder;
                num2 = 8;
                continue;
              case 3:
                // ISSUE: reference to a compiler-generated field
                stateMachine.st = st;
                num2 = 9;
                continue;
              case 4:
                // ISSUE: reference to a compiler-generated field
                stateMachine.\u003C\u003E4__this = this;
                num2 = 3;
                continue;
              case 5:
                // ISSUE: reference to a compiler-generated field
                stateMachine.\u003C\u003Et__builder = ElmaInExpression.JoinedValuesType.pipLifQJTycAt5sErxZs();
                num2 = 7;
                continue;
              case 6:
                // ISSUE: reference to a compiler-generated field
                stateMachine.session = session;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
                continue;
              case 7:
                // ISSUE: reference to a compiler-generated field
                stateMachine.\u003C\u003E1__state = -1;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 2 : 0;
                continue;
              case 8:
                tBuilder.Start<ElmaInExpression.JoinedValuesType.\u003CNullSafeSetAsync\u003Ed__26>(ref stateMachine);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
                continue;
              case 9:
                goto label_9;
              case 10:
                goto label_7;
              case 11:
                // ISSUE: reference to a compiler-generated field
                stateMachine.index = index;
                num2 = 10;
                continue;
              default:
                goto label_12;
            }
          }
label_7:
          // ISSUE: reference to a compiler-generated field
          stateMachine.settable = settable;
          num1 = 6;
          continue;
label_9:
          // ISSUE: reference to a compiler-generated field
          stateMachine.value = value;
          num1 = 11;
        }
label_12:
        // ISSUE: reference to a compiler-generated field
        return stateMachine.\u003C\u003Et__builder.Task;
      }

      /// <inheritdoc />
      public override Task NullSafeSetAsync(
        DbCommand st,
        object value_obj,
        int index,
        ISessionImplementor session,
        CancellationToken cancellationToken)
      {
        int num1 = 9;
        // ISSUE: variable of a compiler-generated type
        ElmaInExpression.JoinedValuesType.\u003CNullSafeSetAsync\u003Ed__27 stateMachine;
        while (true)
        {
          int num2 = num1;
          AsyncTaskMethodBuilder tBuilder;
          while (true)
          {
            switch (num2)
            {
              case 1:
                // ISSUE: reference to a compiler-generated field
                stateMachine.session = session;
                num2 = 6;
                continue;
              case 2:
                // ISSUE: reference to a compiler-generated field
                stateMachine.\u003C\u003E1__state = -1;
                num2 = 3;
                continue;
              case 3:
                // ISSUE: reference to a compiler-generated field
                tBuilder = stateMachine.\u003C\u003Et__builder;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 2 : 4;
                continue;
              case 4:
                tBuilder.Start<ElmaInExpression.JoinedValuesType.\u003CNullSafeSetAsync\u003Ed__27>(ref stateMachine);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
                continue;
              case 5:
                // ISSUE: reference to a compiler-generated field
                stateMachine.\u003C\u003Et__builder = ElmaInExpression.JoinedValuesType.pipLifQJTycAt5sErxZs();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 2;
                continue;
              case 6:
                // ISSUE: reference to a compiler-generated field
                stateMachine.cancellationToken = cancellationToken;
                num2 = 5;
                continue;
              case 7:
                // ISSUE: reference to a compiler-generated field
                stateMachine.index = index;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
                continue;
              case 8:
                goto label_5;
              case 9:
                // ISSUE: reference to a compiler-generated field
                stateMachine.st = st;
                num2 = 8;
                continue;
              default:
                goto label_10;
            }
          }
label_5:
          // ISSUE: reference to a compiler-generated field
          stateMachine.value_obj = value_obj;
          num1 = 7;
        }
label_10:
        // ISSUE: reference to a compiler-generated field
        return stateMachine.\u003C\u003Et__builder.Task;
      }

      public JoinedValuesType()
      {
        ElmaInExpression.JoinedValuesType.zENr4oQJkpeE56Djr4oO();
        this.sqlTypes = (object) new SqlType[1]
        {
          (SqlType) ElmaInExpression.JoinedValuesType.s1lAwqQJngeOOZVuiUZ2((object) NHibernateUtil.StringClob)
        };
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      static JoinedValuesType()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              ElmaInExpression.JoinedValuesType.zENr4oQJkpeE56Djr4oO();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              ElmaInExpression.JoinedValuesType.Singleton = (IType) new ElmaInExpression.JoinedValuesType();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 2;
              continue;
          }
        }
label_2:;
      }

      internal static bool GO7F00QJZv7R63npKwJr() => ElmaInExpression.JoinedValuesType.HTid18QJ8j6BbECas9tZ == null;

      internal static ElmaInExpression.JoinedValuesType y84mvtQJuqIcT90930q2() => (ElmaInExpression.JoinedValuesType) ElmaInExpression.JoinedValuesType.HTid18QJ8j6BbECas9tZ;

      internal static object GPTd5sQJIfUwNyFt4vfZ([In] object obj0) => (object) ((AbstractType) obj0).Name;

      internal static System.Type k36bYnQJVIIlWKNOFcxK([In] object obj0) => ((AbstractType) obj0).ReturnedClass;

      internal static bool pQS39cQJSMvk5SgeufZP([In] object obj0) => ((AbstractType) obj0).IsMutable;

      internal static object wGfSxuQJiqYANsPQih51([In] object obj0) => (object) ((DbCommand) obj0).Parameters;

      internal static object oUncVKQJRwKMdoVhBpYh([In] object obj0) => (object) ((ElmaInExpression.JoinedValuesType.Value) obj0).Delimiter;

      internal static object WSVGw8QJqe8xZZBix0nu([In] object obj0) => (object) ((ElmaInExpression.JoinedValuesType.Value) obj0).Type;

      internal static object A193clQJKgb6qrTyd4Hl([In] object obj0) => (object) ((ElmaInExpression.JoinedValuesType.Value) obj0).Values;

      internal static void YVCbNtQJXbExuebjlB4w([In] object obj0, [In] object obj1) => ((IDataParameter) obj0).Value = obj1;

      internal static AsyncTaskMethodBuilder pipLifQJTycAt5sErxZs() => AsyncTaskMethodBuilder.Create();

      internal static void zENr4oQJkpeE56Djr4oO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object s1lAwqQJngeOOZVuiUZ2([In] object obj0) => (object) ((NullableType) obj0).SqlType;

      private class Value
      {
        private static object wUJEDvZuKEi2O1v8C8Jm;

        public Value(IType type, object[] values, string delimiter)
        {
          ElmaInExpression.JoinedValuesType.Value.Ww76cAZuk6BjNvcR749s();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 3;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
            num = 2;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.Delimiter = delimiter;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 2 : 2;
                continue;
              case 2:
                goto label_3;
              case 3:
                this.Type = type;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
                continue;
              default:
                this.Values = values;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 1;
                continue;
            }
          }
label_3:;
        }

        public IType Type { get; }

        public object[] Values { get; }

        public string Delimiter { get; }

        public override string ToString() => string.Join(this.Delimiter, this.Values);

        internal static void Ww76cAZuk6BjNvcR749s() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static bool T3tiDaZuXM1FwUIjGDv8() => ElmaInExpression.JoinedValuesType.Value.wUJEDvZuKEi2O1v8C8Jm == null;

        internal static ElmaInExpression.JoinedValuesType.Value b1lfcoZuTr3HeoBL5x6R() => (ElmaInExpression.JoinedValuesType.Value) ElmaInExpression.JoinedValuesType.Value.wUJEDvZuKEi2O1v8C8Jm;
      }
    }
  }
}
