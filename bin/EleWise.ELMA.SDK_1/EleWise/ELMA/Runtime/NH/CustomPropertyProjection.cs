// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomPropertyProjection
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.Persister.Entity;
using NHibernate.SqlCommand;
using NHibernate.Tuple;
using NHibernate.Tuple.Entity;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  [Serializable]
  public class CustomPropertyProjection : SimpleProjection, IPropertyProjection
  {
    private string propertyName;
    private bool grouped;
    private string entityName;
    private string tableName;
    private PropertyMetadata propertyMetadata;
    private bool forOrder;
    private readonly ITransformationProvider transformationProvider;
    internal static CustomPropertyProjection Xw8eTiWtToqY11D8aECt;

    public static string GetExpressionFromString(string exp, out string entityName)
    {
      int num1 = 3;
      List<string> stringList;
      while (true)
      {
        int num2 = num1;
        int index;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 14:
              if (index < CustomPropertyProjection.yNefbQWtPyaVT7tWSU4x((object) exp))
              {
                num2 = 5;
                continue;
              }
              goto case 4;
            case 2:
              if (!CustomPropertyProjection.spvdSIWtODqAqUPDUPUc((object) exp))
              {
                num2 = 13;
                continue;
              }
              goto label_14;
            case 3:
              goto label_17;
            case 4:
              stringList = new List<string>()
              {
                (string) CustomPropertyProjection.poNTDOWt1fUTkV2sld1i((object) exp, 0, index - 3),
                (string) CustomPropertyProjection.kWZkO4WtN2tLrPJvxBWu((object) exp, index)
              };
              num2 = 15;
              continue;
            case 5:
            case 11:
              if (exp[index] == '_')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 10 : 10;
                continue;
              }
              goto case 4;
            case 6:
              goto label_6;
            case 7:
              if (CustomPropertyProjection.yNefbQWtPyaVT7tWSU4x((object) exp) <= index)
              {
                num2 = 6;
                continue;
              }
              goto case 1;
            case 8:
              if (index > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 9:
              goto label_14;
            case 10:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 14 : 4;
              continue;
            case 12:
              goto label_5;
            case 13:
              index = CustomPropertyProjection.by24Z2Wte5T1pv6D0pNq((object) exp, CustomPropertyProjection.ak9gAeWt2rR0wf6Z8mWU(864270449 << 6 ^ -521388932), StringComparison.OrdinalIgnoreCase);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 8 : 0;
              continue;
            case 15:
              entityName = (string) CustomPropertyProjection.dY5JLQWt3D0XVL2Kmy1H((object) stringList[1], CustomPropertyProjection.ak9gAeWt2rR0wf6Z8mWU(-1978478350 ^ -1978424670), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978480074));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 8 : 12;
              continue;
            default:
              goto label_16;
          }
        }
label_16:
        index += 3;
        num1 = 7;
        continue;
label_17:
        entityName = "";
        num1 = 2;
      }
label_5:
      return (string) CustomPropertyProjection.dY5JLQWt3D0XVL2Kmy1H((object) stringList[0], CustomPropertyProjection.ak9gAeWt2rR0wf6Z8mWU(1994213607 >> 4 ^ 124561118), CustomPropertyProjection.ak9gAeWt2rR0wf6Z8mWU(1218962250 ^ 1218967950));
label_6:
      return exp;
label_14:
      return string.Empty;
    }

    public static string GetStringFromExpression(string colName, string entityName) => (string) CustomPropertyProjection.Y64xdPWtp76xwlOeLlJQ(CustomPropertyProjection.ak9gAeWt2rR0wf6Z8mWU(-398663332 ^ -398540518), CustomPropertyProjection.dY5JLQWt3D0XVL2Kmy1H((object) colName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539361419), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87940851)), (object) entityName.Replace((string) CustomPropertyProjection.ak9gAeWt2rR0wf6Z8mWU(-1837662597 ^ -1837669185), (string) CustomPropertyProjection.ak9gAeWt2rR0wf6Z8mWU(-1255365154 ^ 596875508 ^ -1765912710)));

    protected internal CustomPropertyProjection(
      string propertyName,
      bool grouped,
      string entityName,
      string tableName,
      PropertyMetadata propertyMetadata,
      bool forOrder)
    {
      CustomPropertyProjection.mdBexYWtaoXQRV2icJUG();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.entityName = entityName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 2:
            this.propertyMetadata = propertyMetadata;
            num = 6;
            continue;
          case 3:
            goto label_2;
          case 4:
            this.grouped = grouped;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 1;
            continue;
          case 5:
            this.transformationProvider = Locator.GetService<ITransformationProvider>();
            num = 7;
            continue;
          case 6:
            this.forOrder = forOrder;
            num = 3;
            continue;
          case 7:
            this.propertyName = propertyName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 4 : 4;
            continue;
          default:
            this.tableName = (string) CustomPropertyProjection.FBLae2WttotT1iBbImXn(CustomPropertyProjection.pp36MdWtDRmGbt2fa4fs((object) this.transformationProvider), (object) tableName);
            num = 2;
            continue;
        }
      }
label_2:;
    }

    public CustomPropertyProjection(
      string propertyName,
      string entityName,
      string tableName,
      PropertyMetadata propertyMetadata,
      bool forOrder = false)
    {
      CustomPropertyProjection.mdBexYWtaoXQRV2icJUG();
      // ISSUE: explicit constructor call
      this.\u002Ector(propertyName, false, entityName, tableName, propertyMetadata, forOrder);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public string PropertyName => this.propertyName;

    public override string ToString() => this.propertyName;

    public override bool IsGrouped => this.grouped;

    public override bool IsAggregate => false;

    public override IType[] GetTypes(ICriteria criteria, ICriteriaQuery criteriaQuery)
    {
      int num1 = 2;
      StandardProperty standardProperty;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              if (CustomPropertyProjection.spvdSIWtODqAqUPDUPUc((object) this.entityName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
                continue;
              }
              break;
            case 3:
              goto label_6;
            case 4:
              goto label_3;
          }
          standardProperty = ((IEnumerable<StandardProperty>) ((EntityMetamodel) CustomPropertyProjection.SiWlD5Wt6QTWKBpdB9dF(CustomPropertyProjection.HdRVM5Wt4oGvYXSdrVJo(CustomPropertyProjection.IFG59PWtwTP5Tq8OV0AI((object) criteriaQuery), (object) this.entityName))).Properties).FirstOrDefault<StandardProperty>((Func<StandardProperty, bool>) (p => CustomPropertyProjection.SB1ZFZWtMfm3EdfEWGLF((object) p.Name, (object) this.propertyName)));
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 4 : 4;
        }
label_3:
        if (standardProperty != null)
          num1 = 3;
        else
          goto label_7;
      }
label_6:
      return new IType[1]{ standardProperty.Type };
label_7:
      return new IType[1]
      {
        (IType) CustomPropertyProjection.sSJqtNWtHDwxveQbFlFu((object) criteriaQuery, (object) criteria, (object) this.propertyName)
      };
    }

    protected override int GetColumnCount(ICriteria criteria, ICriteriaQuery criteriaQuery)
    {
      int num1 = 1;
      ICriteriaQuery criteriaQuery1;
      CustomPropertyProjection propertyProjection;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            propertyProjection = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 2;
            continue;
          default:
            criteriaQuery1 = criteriaQuery;
            num1 = 3;
            continue;
        }
      }
label_3:
      return ((IEnumerable<IType>) CustomPropertyProjection.NG03yvWtAoo1yl9ntoL1((object) this, (object) criteria, (object) criteriaQuery1)).Sum<IType>((Func<IType, int>) (t =>
      {
        int num2 = 2;
        int columnCount;
        while (true)
        {
          int num3 = num2;
          while (true)
          {
            switch (num3)
            {
              case 1:
                if (columnCount > 0)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                  continue;
                }
                goto label_6;
              case 2:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                columnCount = CustomPropertyProjection.\u003C\u003Ec__DisplayClass19_0.sZh6clQdtQLIT6dhkp6A((object) t, CustomPropertyProjection.\u003C\u003Ec__DisplayClass19_0.bFjajEQdDKZ4buBY1cXL((object) criteriaQuery1));
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
                continue;
              case 3:
                goto label_7;
              case 4:
                goto label_6;
              default:
                goto label_3;
            }
          }
label_3:
          if (!propertyProjection.forOrder)
            num2 = 3;
          else
            break;
        }
label_6:
        return 1;
label_7:
        return columnCount;
      }));
    }

    public override SqlString ToSqlString(
      ICriteria criteria,
      int loc,
      ICriteriaQuery criteriaQuery)
    {
      int num = 9;
      string[] strArray;
      SqlStringBuilder sqlStringBuilder;
      int index;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            CustomPropertyProjection.H9PqHQWtmE8AiEj7y8L9((object) sqlStringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3332072));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 15 : 12;
            continue;
          case 2:
            str = strArray[index];
            num = 4;
            continue;
          case 3:
          case 14:
            goto label_21;
          case 4:
            CustomPropertyProjection.H9PqHQWtmE8AiEj7y8L9((object) sqlStringBuilder, !this.forOrder ? (object) str : CustomPropertyProjection.vmpEStWt0IH5QTmhDBMA((object) this.transformationProvider, (object) this.propertyMetadata, (object) str));
            num = 6;
            continue;
          case 5:
            if (index < strArray.Length - 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
              continue;
            }
            goto case 15;
          case 6:
            sqlStringBuilder.Add((string) CustomPropertyProjection.ak9gAeWt2rR0wf6Z8mWU(-2106517564 ^ -2106378414));
            num = 10;
            continue;
          case 7:
          case 18:
            goto label_9;
          case 8:
            if (strArray == null)
            {
              num = 3;
              continue;
            }
            goto case 13;
          case 9:
            strArray = (string[]) CustomPropertyProjection.U73JhfWt7pJYnQbXUjTP((object) criteriaQuery, (object) criteria, (object) this.propertyName, (object) this.entityName, (object) this.tableName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 8;
            continue;
          case 10:
            CustomPropertyProjection.H9PqHQWtmE8AiEj7y8L9((object) sqlStringBuilder, (object) (loc + index).ToString());
            num = 12;
            continue;
          case 12:
            CustomPropertyProjection.H9PqHQWtmE8AiEj7y8L9((object) sqlStringBuilder, CustomPropertyProjection.ak9gAeWt2rR0wf6Z8mWU(92412609 - 1050237057 ^ -957821382));
            num = 16;
            continue;
          case 13:
            if (strArray.Length == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 14 : 3;
              continue;
            }
            sqlStringBuilder = new SqlStringBuilder();
            num = 17;
            continue;
          case 15:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          case 16:
            if (this.forOrder)
            {
              num = 7;
              continue;
            }
            goto case 5;
          case 17:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 11;
            continue;
          default:
            if (index >= strArray.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 18 : 6;
              continue;
            }
            goto case 2;
        }
      }
label_9:
      return sqlStringBuilder.ToSqlString();
label_21:
      throw new Exception((string) CustomPropertyProjection.NgPqKyWtxwNZsR2VHoau(CustomPropertyProjection.ak9gAeWt2rR0wf6Z8mWU(647913418 ^ 647790486)));
    }

    public override SqlString ToGroupSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.grouped)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      throw new InvalidOperationException((string) CustomPropertyProjection.ak9gAeWt2rR0wf6Z8mWU(-882126494 ^ -882249274));
label_3:
      return new SqlString((string) CustomPropertyProjection.oAuD4mWtyDLGLfRbNQ54((object) criteriaQuery, (object) criteria, (object) this.propertyName));
    }

    internal static bool spvdSIWtODqAqUPDUPUc([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object ak9gAeWt2rR0wf6Z8mWU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static int by24Z2Wte5T1pv6D0pNq([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).IndexOf((string) obj1, obj2);

    internal static int yNefbQWtPyaVT7tWSU4x([In] object obj0) => ((string) obj0).Length;

    internal static object poNTDOWt1fUTkV2sld1i([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object kWZkO4WtN2tLrPJvxBWu([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static object dY5JLQWt3D0XVL2Kmy1H([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static bool ySQ2nBWtk1o0SK3TAyV2() => CustomPropertyProjection.Xw8eTiWtToqY11D8aECt == null;

    internal static CustomPropertyProjection BPOZ2IWtnN4ordONijY1() => CustomPropertyProjection.Xw8eTiWtToqY11D8aECt;

    internal static object Y64xdPWtp76xwlOeLlJQ([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void mdBexYWtaoXQRV2icJUG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object pp36MdWtDRmGbt2fa4fs([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object FBLae2WttotT1iBbImXn([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object IFG59PWtwTP5Tq8OV0AI([In] object obj0) => (object) ((ICriteriaQuery) obj0).Factory;

    internal static object HdRVM5Wt4oGvYXSdrVJo([In] object obj0, [In] object obj1) => (object) ((ISessionFactoryImplementor) obj0).GetEntityPersister((string) obj1);

    internal static object SiWlD5Wt6QTWKBpdB9dF([In] object obj0) => (object) ((IEntityPersister) obj0).EntityMetamodel;

    internal static object sSJqtNWtHDwxveQbFlFu([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ICriteriaQuery) obj0).GetType((ICriteria) obj1, (string) obj2);

    internal static object NG03yvWtAoo1yl9ntoL1([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SimpleProjection) obj0).GetTypes((ICriteria) obj1, (ICriteriaQuery) obj2);

    internal static object U73JhfWt7pJYnQbXUjTP(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      return (object) ((ICriteriaQuery) obj0).GetColumnsForSubclassProperty((ICriteria) obj1, (string) obj2, (string) obj3, (string) obj4);
    }

    internal static object NgPqKyWtxwNZsR2VHoau([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object vmpEStWt0IH5QTmhDBMA([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ITransformationProvider) obj0).GetSqlOrderBy((PropertyMetadata) obj1, (string) obj2);

    internal static object H9PqHQWtmE8AiEj7y8L9([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((string) obj1);

    internal static object oAuD4mWtyDLGLfRbNQ54([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ICriteriaQuery) obj0).GetColumn((ICriteria) obj1, (string) obj2);

    internal static bool SB1ZFZWtMfm3EdfEWGLF([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;
  }
}
