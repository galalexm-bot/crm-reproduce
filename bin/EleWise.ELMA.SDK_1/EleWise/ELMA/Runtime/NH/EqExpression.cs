// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.EqExpression
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.SqlCommand;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  [Serializable]
  public class EqExpression : AbstractCriterion
  {
    private static readonly TypedValue[] NoTypedValues;
    private readonly string _lhsPropertyName;
    private readonly string _rhsPropertyName;
    private readonly object _rhsValue;
    private readonly IEntityPropertyMetadata _lhsPropertyMetadata;
    private readonly IEntityPropertyMetadata _rhsPropertyMetadata;
    internal static EqExpression N4x2CBWDvnjFW7aBF7HH;

    public EqExpression(
      string alias,
      string lhsPropertyName,
      string rhsPropertyName,
      EntityMetadata metadata)
    {
      EqExpression.M7iynTWDunyZA3WpjNSf();
      // ISSUE: explicit constructor call
      this.\u002Ector(string.IsNullOrWhiteSpace(alias) ? lhsPropertyName : (string) EqExpression.LT7wx7WDIZMJDy8G9H0t((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901776505), (object) alias, (object) lhsPropertyName), metadata, !string.IsNullOrWhiteSpace(alias) ? (string) EqExpression.LT7wx7WDIZMJDy8G9H0t(EqExpression.GxUXZHWDVGWiYeFlK4Fs(1253244298 - 1829393894 ^ -576133722), (object) alias, (object) rhsPropertyName) : rhsPropertyName, metadata);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public EqExpression(
      string lhsPropertyName,
      EntityMetadata lhsMetadata,
      string rhsPropertyName,
      EntityMetadata rhsMetadata)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        num1 = 1;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this._lhsPropertyName = lhsPropertyName;
            num1 = 6;
            continue;
          case 2:
            if (num2 < 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 5;
              continue;
            }
            goto case 12;
          case 4:
            this._rhsPropertyName = rhsPropertyName;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 2 : 11;
            continue;
          case 5:
          case 8:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            this._lhsPropertyMetadata = (IEntityPropertyMetadata) lhsMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => EqExpression.\u003C\u003Ec__DisplayClass7_0.C6NvDLQ95HOZ4PANv3wk(EqExpression.\u003C\u003Ec__DisplayClass7_0.FYDXk1Q9gpsxcx3dNGTo((object) p), (object) lhsPropertyName))) ?? (IEntityPropertyMetadata) lhsMetadata.TableParts.FirstOrDefault<TablePartMetadata>((Func<TablePartMetadata, bool>) (tp => EqExpression.\u003C\u003Ec__DisplayClass7_0.C6NvDLQ95HOZ4PANv3wk(EqExpression.\u003C\u003Ec__DisplayClass7_0.vwUL4wQ9jYBZbfLRop0p((object) tp), (object) lhsPropertyName)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 4;
            continue;
          case 6:
            num2 = EqExpression.mS9lMuWDSpdfvulALSmO((object) lhsPropertyName, '.');
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 2 : 2;
            continue;
          case 7:
            if (num2 < 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 3;
              continue;
            }
            goto case 10;
          case 9:
            goto label_13;
          case 10:
            rhsPropertyName = (string) EqExpression.QySHnhWDib0LExKc7FCo((object) rhsPropertyName, num2 + 1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          case 11:
            num2 = EqExpression.mS9lMuWDSpdfvulALSmO((object) rhsPropertyName, '.');
            num1 = 7;
            continue;
          case 12:
            lhsPropertyName = (string) EqExpression.QySHnhWDib0LExKc7FCo((object) lhsPropertyName, num2 + 1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 8 : 0;
            continue;
          default:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            this._rhsPropertyMetadata = (IEntityPropertyMetadata) rhsMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => EqExpression.\u003C\u003Ec__DisplayClass7_0.C6NvDLQ95HOZ4PANv3wk(EqExpression.\u003C\u003Ec__DisplayClass7_0.FYDXk1Q9gpsxcx3dNGTo((object) p), (object) rhsPropertyName))) ?? (IEntityPropertyMetadata) rhsMetadata.TableParts.FirstOrDefault<TablePartMetadata>((Func<TablePartMetadata, bool>) (tp => EqExpression.\u003C\u003Ec__DisplayClass7_0.C6NvDLQ95HOZ4PANv3wk(EqExpression.\u003C\u003Ec__DisplayClass7_0.vwUL4wQ9jYBZbfLRop0p((object) tp), (object) rhsPropertyName)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 9 : 9;
            continue;
        }
      }
label_13:;
    }

    public EqExpression(
      string alias,
      string lhsPropertyName,
      EntityMetadata metadata,
      object rhsValue)
    {
      EqExpression.M7iynTWDunyZA3WpjNSf();
      // ISSUE: explicit constructor call
      this.\u002Ector(!EqExpression.djPDNaWDRSpQuktgf97s((object) alias) ? (string) EqExpression.LT7wx7WDIZMJDy8G9H0t((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479516598), (object) alias, (object) lhsPropertyName) : lhsPropertyName, metadata, rhsValue);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public EqExpression(string lhsPropertyName, EntityMetadata metadata, object rhsValue)
    {
      EqExpression.M7iynTWDunyZA3WpjNSf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 3;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            lhsPropertyName = lhsPropertyName.Substring(num2 + 1);
            num1 = 5;
            continue;
          case 2:
            num2 = EqExpression.mS9lMuWDSpdfvulALSmO((object) lhsPropertyName, '.');
            num1 = 4;
            continue;
          case 3:
            this._lhsPropertyName = lhsPropertyName;
            num1 = 2;
            continue;
          case 4:
            if (num2 >= 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 1 : 1;
              continue;
            }
            goto case 5;
          case 5:
            // ISSUE: reference to a compiler-generated method
            IEntityPropertyMetadata propertyMetadata = (IEntityPropertyMetadata) metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => EqExpression.\u003C\u003Ec__DisplayClass9_0.W88EnLQ9cMakgyFwWvfS((object) p.Name, (object) lhsPropertyName)));
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            this._lhsPropertyMetadata = propertyMetadata == null ? (IEntityPropertyMetadata) metadata.TableParts.FirstOrDefault<TablePartMetadata>((Func<TablePartMetadata, bool>) (tp => EqExpression.\u003C\u003Ec__DisplayClass9_0.W88EnLQ9cMakgyFwWvfS(EqExpression.\u003C\u003Ec__DisplayClass9_0.sxV3VYQ9zf6rmu75aabo((object) tp), (object) lhsPropertyName))) : propertyMetadata;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
            continue;
          case 6:
            goto label_9;
          default:
            this._rhsValue = rhsValue;
            num1 = 6;
            continue;
        }
      }
label_9:;
    }

    public override SqlString ToSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery)
    {
      int num1 = 44;
      SqlStringBuilder sqlStringBuilder;
      IRuntimeApplication serviceNotNull;
      IType type;
      SqlString[] columnNames;
      SqlString[] rhsColumnNames;
      ICriteriaQuery criteriaQuery1;
      while (true)
      {
        int num2 = num1;
        int index1;
        SqlString[] sqlStringArray;
        NHibernate.SqlCommand.Parameter[] array;
        int index2;
        IProjection projection;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 61:
              EqExpression.BOn8nPWDpE31bJWW0gAX((object) sqlStringBuilder, (object) ((SqlStringBuilder) EqExpression.c7FU7cWDeN0DY7yZFL07(EqExpression.Y5L07QWD36hYr6FNUsCo((object) new SqlStringBuilder(), (object) columnNames[index2]), EqExpression.GxUXZHWDVGWiYeFlK4Fs(1597012150 ^ 1597103146))).Add(rhsColumnNames[index2]).ToSqlString());
              num2 = 13;
              continue;
            case 2:
            case 15:
            case 26:
              if (this._rhsValue is string)
                goto case 35;
              else
                goto label_19;
            case 3:
              array = ((IEnumerable<TypedValue>) EqExpression.sYGaHfWD2wZSrTorDFix((object) this, (object) criteria, (object) criteriaQuery1)).SelectMany<TypedValue, NHibernate.SqlCommand.Parameter>((Func<TypedValue, IEnumerable<NHibernate.SqlCommand.Parameter>>) (t => criteriaQuery1.NewQueryParameter(t))).ToArray<NHibernate.SqlCommand.Parameter>();
              num2 = 36;
              continue;
            case 4:
              goto label_17;
            case 5:
              goto label_41;
            case 6:
            case 58:
              goto label_24;
            case 7:
              goto label_33;
            case 8:
              if (type.ReturnedClass.IsInheritOrSame<IEntity<int>>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 4 : 64;
                continue;
              }
              goto case 46;
            case 9:
              projection = (IProjection) null;
              num2 = 38;
              continue;
            case 10:
              serviceNotNull = Locator.GetServiceNotNull<IRuntimeApplication>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 47 : 14;
              continue;
            case 11:
              if ((object) (this._rhsValue as System.Type) == null)
                goto case 51;
              else
                goto label_80;
            case 12:
              if (!(this._rhsValue is int))
              {
                num2 = 21;
                continue;
              }
              goto case 2;
            case 13:
              ++index2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 42 : 20;
              continue;
            case 14:
            case 16:
              if (index1 < sqlStringArray.Length)
              {
                num2 = 28;
                continue;
              }
              goto label_33;
            case 17:
              if (index2 <= 0)
              {
                num2 = 61;
                continue;
              }
              goto case 33;
            case 18:
            case 56:
              if (EqExpression.DtRaYxWDnvSQNcxYRdIv((object) serviceNotNull) == null)
              {
                num2 = 20;
                continue;
              }
              goto label_41;
            case 19:
              ++index1;
              num2 = 16;
              continue;
            case 20:
              if (columnNames.Length > 1)
                goto case 54;
              else
                goto label_43;
            case 21:
              if (!type.ReturnedClass.IsInheritOrSame<EnumBase>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 6 : 3;
                continue;
              }
              goto case 40;
            case 22:
            case 34:
              goto label_12;
            case 23:
            case 30:
            case 45:
              if (!type.IsCollectionType)
              {
                num2 = 26;
                continue;
              }
              goto label_17;
            case 24:
            case 42:
              if (index2 < columnNames.Length)
                goto case 17;
              else
                goto label_53;
            case 25:
            case 37:
              sqlStringArray = Array.ConvertAll<string, SqlString>((string[]) EqExpression.zBRWjBWDOVLEV9mgxhsJ((object) criteriaQuery1, (object) criteria, (object) this._lhsPropertyName), (Converter<string, SqlString>) (col => new SqlString(col)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 3;
              continue;
            case 27:
              if (this._lhsPropertyMetadata != null)
              {
                num2 = 18;
                continue;
              }
              goto case 29;
            case 28:
            case 41:
              if (index1 > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                continue;
              }
              goto case 50;
            case 29:
              if (this._rhsPropertyMetadata != null)
              {
                num2 = 56;
                continue;
              }
              goto case 20;
            case 31:
              index1 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 8 : 14;
              continue;
            case 32:
            case 63:
              index2 = 0;
              num2 = 24;
              continue;
            case 33:
              EqExpression.c7FU7cWDeN0DY7yZFL07((object) sqlStringBuilder, EqExpression.GxUXZHWDVGWiYeFlK4Fs(-1939377524 ^ -1939417558));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
              continue;
            case 35:
              if (this._lhsPropertyMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 37 : 32;
                continue;
              }
              goto case 57;
            case 36:
              if (((IEnumerable<NHibernate.SqlCommand.Parameter>) array).Any<NHibernate.SqlCommand.Parameter>())
              {
                num2 = 31;
                continue;
              }
              goto label_33;
            case 38:
              if (EqExpression.DVMoKuWDqUKH28oqYqns((object) this._rhsPropertyName))
              {
                num2 = 59;
                continue;
              }
              columnNames = CriterionUtil.GetColumnNames(this._lhsPropertyName, (IProjection) null, criteriaQuery1, criteria);
              num2 = 39;
              continue;
            case 39:
              rhsColumnNames = (SqlString[]) EqExpression.OFUBonWDNwk0oIR4CWcS((object) this._rhsPropertyName, (object) projection, (object) criteriaQuery1, (object) criteria);
              num2 = 27;
              continue;
            case 40:
              if (this._rhsValue is Guid)
              {
                num2 = 2;
                continue;
              }
              goto label_24;
            case 43:
              criteriaQuery1 = criteriaQuery;
              num2 = 10;
              continue;
            case 44:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 27 : 43;
              continue;
            case 46:
              if (!EqExpression.W6bnsUWDXNICG8h8ujMZ((object) type).IsInheritOrSame<Enum>())
                goto case 21;
              else
                goto label_76;
            case 47:
              sqlStringBuilder = new SqlStringBuilder();
              num2 = 9;
              continue;
            case 48:
              EqExpression.c7FU7cWDeN0DY7yZFL07((object) sqlStringBuilder, EqExpression.GxUXZHWDVGWiYeFlK4Fs(825385222 ^ 825392826));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 34 : 18;
              continue;
            case 49:
              if (this._rhsValue is long)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 8 : 15;
                continue;
              }
              goto case 12;
            case 50:
              EqExpression.CqFPr2WDP6nLpQPe9rOD(EqExpression.c7FU7cWDeN0DY7yZFL07((object) sqlStringBuilder.Add(sqlStringArray[index1]), EqExpression.GxUXZHWDVGWiYeFlK4Fs(-1217523399 ^ -1217415771)), (object) array[index1]);
              num2 = 19;
              continue;
            case 51:
              if (EqExpression.W6bnsUWDXNICG8h8ujMZ((object) type).IsInstanceOfType(this._rhsValue))
              {
                num2 = 30;
                continue;
              }
              goto case 60;
            case 52:
              if (columnNames.Length <= 1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 22 : 10;
                continue;
              }
              goto case 48;
            case 53:
              if (this._rhsValue == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 23 : 22;
                continue;
              }
              goto case 11;
            case 54:
              EqExpression.c7FU7cWDeN0DY7yZFL07((object) sqlStringBuilder, EqExpression.GxUXZHWDVGWiYeFlK4Fs(-1350312861 << 3 ^ 2082405550));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 60 : 63;
              continue;
            case 55:
              goto label_81;
            case 57:
              if (serviceNotNull.MainProvider != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 40 : 55;
                continue;
              }
              goto case 25;
            case 59:
              type = (IType) EqExpression.KpN8kjWDKSIqnCsiSBGH((object) criteriaQuery1, (object) criteria, (object) this._lhsPropertyName);
              num2 = 53;
              continue;
            case 60:
              if (!EqExpression.W6bnsUWDXNICG8h8ujMZ((object) type).IsInheritOrSame<IEntity<long>>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 8 : 8;
                continue;
              }
              goto case 64;
            case 62:
              if (!(this._rhsValue is int))
              {
                num2 = 46;
                continue;
              }
              goto case 2;
            case 64:
              if (!(this._rhsValue is long))
              {
                num2 = 62;
                continue;
              }
              goto case 2;
            default:
              sqlStringBuilder.Add((string) EqExpression.GxUXZHWDVGWiYeFlK4Fs(-710283084 ^ -537863435 ^ 173575911));
              num2 = 50;
              continue;
          }
        }
label_19:
        num1 = 25;
        continue;
label_43:
        num1 = 32;
        continue;
label_53:
        num1 = 52;
        continue;
label_76:
        num1 = 49;
        continue;
label_80:
        num1 = 45;
      }
label_12:
      return sqlStringBuilder.ToSqlString();
label_17:
      throw new QueryException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487249722), EqExpression.TlOboxWDkcEW79248k6t((object) criteriaQuery1, (object) criteria), (object) this._lhsPropertyName));
label_24:
      throw new QueryException(string.Format((string) EqExpression.GxUXZHWDVGWiYeFlK4Fs(-1978478350 ^ -1978609962), (object) EqExpression.nGX6oBWDTvHqGv3y5OoK((object) this), (object) this._lhsPropertyName, (object) EqExpression.W6bnsUWDXNICG8h8ujMZ((object) type), (object) this._rhsValue.GetType()));
label_33:
      return (SqlString) EqExpression.vfpq8aWD1O8FfPZHLRK1((object) sqlStringBuilder);
label_41:
      return ((IMainDatabaseProvider) EqExpression.DtRaYxWDnvSQNcxYRdIv((object) serviceNotNull)).EqualToSqlString(criteria, criteriaQuery1, columnNames, this._lhsPropertyMetadata, rhsColumnNames, this._rhsPropertyMetadata);
label_81:
      return ((IMainDatabaseProvider) EqExpression.DtRaYxWDnvSQNcxYRdIv((object) serviceNotNull)).EqualToSqlString(criteria, criteriaQuery1, this._lhsPropertyName, this._lhsPropertyMetadata, this._rhsValue);
    }

    public override TypedValue[] GetTypedValues(ICriteria criteria, ICriteriaQuery criteriaQuery)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (EqExpression.DVMoKuWDqUKH28oqYqns((object) this._rhsPropertyName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (TypedValue[]) EqExpression.ONrxlKWDaRrNfdbovQFb((object) criteriaQuery, (object) criteria, (object) null, (object) this._lhsPropertyName, (object) new object[1]
      {
        this._rhsValue
      });
label_5:
      return EqExpression.NoTypedValues;
    }

    public override string ToString() => (string) EqExpression.i05vDVWDD4BBQ4p6oQkd((object) this._lhsPropertyName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993464213), string.IsNullOrEmpty(this._rhsPropertyName) ? this._rhsValue : (object) this._rhsPropertyName);

    public override IProjection[] GetProjections() => (IProjection[]) null;

    static EqExpression()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            EqExpression.M7iynTWDunyZA3WpjNSf();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            EqExpression.NoTypedValues = new TypedValue[0];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static void M7iynTWDunyZA3WpjNSf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object LT7wx7WDIZMJDy8G9H0t([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object GxUXZHWDVGWiYeFlK4Fs(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool wbGkDuWD8KLLrlZrlUvv() => EqExpression.N4x2CBWDvnjFW7aBF7HH == null;

    internal static EqExpression T4EtUQWDZO2LTJvt4mxk() => EqExpression.N4x2CBWDvnjFW7aBF7HH;

    internal static int mS9lMuWDSpdfvulALSmO([In] object obj0, [In] char obj1) => ((string) obj0).LastIndexOf(obj1);

    internal static object QySHnhWDib0LExKc7FCo([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static bool djPDNaWDRSpQuktgf97s([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static bool DVMoKuWDqUKH28oqYqns([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object KpN8kjWDKSIqnCsiSBGH([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ICriteriaQuery) obj0).GetTypeUsingProjection((ICriteria) obj1, (string) obj2);

    internal static System.Type W6bnsUWDXNICG8h8ujMZ([In] object obj0) => ((IType) obj0).ReturnedClass;

    internal static System.Type nGX6oBWDTvHqGv3y5OoK([In] object obj0) => obj0.GetType();

    internal static object TlOboxWDkcEW79248k6t([In] object obj0, [In] object obj1) => (object) ((ICriteriaQuery) obj0).GetEntityName((ICriteria) obj1);

    internal static object DtRaYxWDnvSQNcxYRdIv([In] object obj0) => (object) ((IRuntimeApplication) obj0).MainProvider;

    internal static object zBRWjBWDOVLEV9mgxhsJ([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ICriteriaQuery) obj0).GetColumnsUsingProjection((ICriteria) obj1, (string) obj2);

    internal static object sYGaHfWD2wZSrTorDFix([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((AbstractCriterion) obj0).GetTypedValues((ICriteria) obj1, (ICriteriaQuery) obj2);

    internal static object c7FU7cWDeN0DY7yZFL07([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((string) obj1);

    internal static object CqFPr2WDP6nLpQPe9rOD([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((NHibernate.SqlCommand.Parameter) obj1);

    internal static object vfpq8aWD1O8FfPZHLRK1([In] object obj0) => (object) ((SqlStringBuilder) obj0).ToSqlString();

    internal static object OFUBonWDNwk0oIR4CWcS(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) CriterionUtil.GetColumnNames((string) obj0, (IProjection) obj1, (ICriteriaQuery) obj2, (ICriteria) obj3);
    }

    internal static object Y5L07QWD36hYr6FNUsCo([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((SqlString) obj1);

    internal static object BOn8nPWDpE31bJWW0gAX([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((SqlString) obj1);

    internal static object ONrxlKWDaRrNfdbovQFb(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      return (object) CriterionUtil.GetTypedValues((ICriteriaQuery) obj0, (ICriteria) obj1, (IProjection) obj2, (string) obj3, (object[]) obj4);
    }

    internal static object i05vDVWDD4BBQ4p6oQkd([In] object obj0, [In] object obj1, [In] object obj2) => (object) (obj0.ToString() + obj1 + obj2);
  }
}
