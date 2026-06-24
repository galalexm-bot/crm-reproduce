// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryCastExtensions.CastRightOperandFromBigint2String
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
  internal class CastRightOperandFromBigint2String : IQueryCastExtension
  {
    private ITransformationProvider transformationProvider;
    internal static CastRightOperandFromBigint2String BAXvb3G04QaGx3uvf4wp;

    public System.Type LeftOperandType => CastRightOperandFromBigint2String.zflRhkG0AJ5MgQfYvRwH(__typeref (string));

    public System.Type RightOperandType => typeof (long);

    public CastRightOperandFromBigint2String(ITransformationProvider transformationProvider)
    {
      CastRightOperandFromBigint2String.sg2IDNG07GPjZfB3WZ7T();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.transformationProvider = transformationProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public SqlString CastLeftOperand(SqlString sqlString) => sqlString;

    public IProjection CastRightOperand(string propertyName) => Projections.Cast((IType) NHibernateUtil.String, (IProjection) Projections.Property(propertyName));

    internal static System.Type zflRhkG0AJ5MgQfYvRwH([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static void sg2IDNG07GPjZfB3WZ7T() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool P82amlG06JRXBvIkdkDS() => CastRightOperandFromBigint2String.BAXvb3G04QaGx3uvf4wp == null;

    internal static CastRightOperandFromBigint2String uEuevnG0HY8joxiBfj7i() => CastRightOperandFromBigint2String.BAXvb3G04QaGx3uvf4wp;
  }
}
