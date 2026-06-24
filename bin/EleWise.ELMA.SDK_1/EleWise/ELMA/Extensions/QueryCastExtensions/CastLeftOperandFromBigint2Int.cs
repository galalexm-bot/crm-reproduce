// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryCastExtensions.CastLeftOperandFromBigint2Int
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
  internal class CastLeftOperandFromBigint2Int : IQueryCastExtension
  {
    private ITransformationProvider transformationProvider;
    internal static CastLeftOperandFromBigint2Int l5p9DVG0SKgvSUFOAgKP;

    public Type LeftOperandType => CastLeftOperandFromBigint2Int.x81ui1G0qWjrr0RpwJt2(__typeref (long));

    public Type RightOperandType => CastLeftOperandFromBigint2Int.x81ui1G0qWjrr0RpwJt2(__typeref (int));

    public CastLeftOperandFromBigint2Int(ITransformationProvider transformationProvider)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.transformationProvider = transformationProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
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
            str = (string) CastLeftOperandFromBigint2Int.KUx9ALG0X4ir4QyQiUHu(CastLeftOperandFromBigint2Int.LPZWICG0KIR0XQXD7MAx((object) this.transformationProvider), DbType.Int32);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return new SqlString((string) CastLeftOperandFromBigint2Int.z5TvcVG0khcei3KAlAvP(CastLeftOperandFromBigint2Int.IlCpXDG0Ty267uItyuiS(-1146510045 ^ -1146246687), (object) sqlString, (object) str));
    }

    public IProjection CastRightOperand(string propertyName) => (IProjection) Projections.Property(propertyName);

    internal static Type x81ui1G0qWjrr0RpwJt2([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool pCvPTpG0ihCEehlDbrDu() => CastLeftOperandFromBigint2Int.l5p9DVG0SKgvSUFOAgKP == null;

    internal static CastLeftOperandFromBigint2Int dJFS0pG0Rw05Rd02qE7i() => CastLeftOperandFromBigint2Int.l5p9DVG0SKgvSUFOAgKP;

    internal static object LPZWICG0KIR0XQXD7MAx([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object KUx9ALG0X4ir4QyQiUHu([In] object obj0, DbType type) => (object) ((Dialect) obj0).GetTypeName(type);

    internal static object IlCpXDG0Ty267uItyuiS(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object z5TvcVG0khcei3KAlAvP([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);
  }
}
