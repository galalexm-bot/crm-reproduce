// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryCastExtensions.CastLeftOperandFromBigint2String
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions.QueryCastExtensions
{
  [Component(Type = ComponentType.Server)]
  internal class CastLeftOperandFromBigint2String : IQueryCastExtension
  {
    private ITransformationProvider transformationProvider;
    internal static CastLeftOperandFromBigint2String cIVdxjG05s5gYAD6kPdF;

    public Type LeftOperandType => typeof (long);

    public Type RightOperandType => CastLeftOperandFromBigint2String.Epji1SG0LEoWsVQcKjGx(__typeref (string));

    public CastLeftOperandFromBigint2String(ITransformationProvider transformationProvider)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.transformationProvider = transformationProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public SqlString CastLeftOperand(SqlString sqlString)
    {
      int num = 1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = (string) CastLeftOperandFromBigint2String.GdL2i7G0sWiu1Ole9lU3(CastLeftOperandFromBigint2String.hJ5eixG0URMNsNMtLBSh((object) this.transformationProvider), DbType.AnsiString);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return new SqlString((string) CastLeftOperandFromBigint2String.hu94WMG0zbLYo1gOeX2B(CastLeftOperandFromBigint2String.WdW4O8G0csAcXTrPpohf(712480695 ^ 712219509), (object) sqlString, (object) str));
    }

    public IProjection CastRightOperand(string propertyName) => (IProjection) CastLeftOperandFromBigint2String.By7qC8GmFKZfRBehIqmW((object) propertyName);

    internal static Type Epji1SG0LEoWsVQcKjGx([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool oEvidEG0jZ4vnQI9QslZ() => CastLeftOperandFromBigint2String.cIVdxjG05s5gYAD6kPdF == null;

    internal static CastLeftOperandFromBigint2String AqSxT1G0YsI1OwD9itIf() => CastLeftOperandFromBigint2String.cIVdxjG05s5gYAD6kPdF;

    internal static object hJ5eixG0URMNsNMtLBSh([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object GdL2i7G0sWiu1Ole9lU3([In] object obj0, DbType type) => (object) ((Dialect) obj0).GetTypeName(type);

    internal static object WdW4O8G0csAcXTrPpohf(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object hu94WMG0zbLYo1gOeX2B([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object By7qC8GmFKZfRBehIqmW([In] object obj0) => (object) Projections.Property((string) obj0);
  }
}
