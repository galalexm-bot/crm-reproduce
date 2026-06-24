// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryCastExtensions.CastRightOperandFromBigint2Int
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Type;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions.QueryCastExtensions
{
  [Component(Type = EleWise.ELMA.ComponentModel.ComponentType.Server)]
  internal class CastRightOperandFromBigint2Int : IQueryCastExtension
  {
    private ITransformationProvider transformationProvider;
    internal static CastRightOperandFromBigint2Int QL1OL7G03Tx7kxmtGQVI;

    public System.Type LeftOperandType => CastRightOperandFromBigint2Int.SmBlUDG0DCn5HtMuuvfD(__typeref (int));

    public System.Type RightOperandType => CastRightOperandFromBigint2Int.SmBlUDG0DCn5HtMuuvfD(__typeref (long));

    public CastRightOperandFromBigint2Int(ITransformationProvider transformationProvider)
    {
      CastRightOperandFromBigint2Int.CTZWcHG0tU42Kv7pWdrQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.transformationProvider = transformationProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public SqlString CastLeftOperand(SqlString sqlString) => sqlString;

    public IProjection CastRightOperand(string propertyName) => Projections.Cast((IType) NHibernateUtil.Int32, (IProjection) CastRightOperandFromBigint2Int.FwLyYMG0wXaGPaUFxnAU((object) propertyName));

    internal static System.Type SmBlUDG0DCn5HtMuuvfD([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static void CTZWcHG0tU42Kv7pWdrQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ryt5JdG0pYQaxDX2r7nc() => CastRightOperandFromBigint2Int.QL1OL7G03Tx7kxmtGQVI == null;

    internal static CastRightOperandFromBigint2Int NPH38wG0aiHMk2ukTTkE() => CastRightOperandFromBigint2Int.QL1OL7G03Tx7kxmtGQVI;

    internal static object FwLyYMG0wXaGPaUFxnAU([In] object obj0) => (object) Projections.Property((string) obj0);
  }
}
