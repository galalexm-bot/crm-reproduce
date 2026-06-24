// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryCastExtensions.CastRightOperandFromInt2String
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
  internal class CastRightOperandFromInt2String : IQueryCastExtension
  {
    private ITransformationProvider transformationProvider;
    internal static CastRightOperandFromInt2String J8UjnAG0x723T3R4Fwlj;

    public System.Type LeftOperandType => CastRightOperandFromInt2String.uq2wnCG0yyFGfide6uxJ(__typeref (string));

    public System.Type RightOperandType => CastRightOperandFromInt2String.uq2wnCG0yyFGfide6uxJ(__typeref (int));

    public CastRightOperandFromInt2String(ITransformationProvider transformationProvider)
    {
      CastRightOperandFromInt2String.qQaPrHG0MJnr2FhjoYmK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.transformationProvider = transformationProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public SqlString CastLeftOperand(SqlString sqlString) => sqlString;

    public IProjection CastRightOperand(string propertyName) => Projections.Cast((IType) NHibernateUtil.String, (IProjection) CastRightOperandFromInt2String.odqMLpG0JFOmFJlW3nLH((object) propertyName));

    internal static System.Type uq2wnCG0yyFGfide6uxJ([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static void qQaPrHG0MJnr2FhjoYmK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ICvFkjG00rBAKXreC7W3() => CastRightOperandFromInt2String.J8UjnAG0x723T3R4Fwlj == null;

    internal static CastRightOperandFromInt2String jbl1ImG0mUGmIUKEEepv() => CastRightOperandFromInt2String.J8UjnAG0x723T3R4Fwlj;

    internal static object odqMLpG0JFOmFJlW3nLH([In] object obj0) => (object) Projections.Property((string) obj0);
  }
}
