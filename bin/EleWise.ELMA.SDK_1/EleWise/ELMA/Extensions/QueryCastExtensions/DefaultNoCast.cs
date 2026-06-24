// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryCastExtensions.DefaultNoCast
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions.QueryCastExtensions
{
  [Component(Type = ComponentType.Server)]
  internal class DefaultNoCast : IQueryCastExtension
  {
    private static DefaultNoCast O5Vq4UG09YpguDcpeeWi;

    public Type LeftOperandType => (Type) null;

    public Type RightOperandType => (Type) null;

    public SqlString CastLeftOperand(SqlString sqlString) => sqlString;

    public IProjection CastRightOperand(string propertyName) => (IProjection) DefaultNoCast.drCnd6G0rKZGrC1XQl1S((object) propertyName);

    public DefaultNoCast()
    {
      DefaultNoCast.hZavLNG0gOMT7649pOum();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object drCnd6G0rKZGrC1XQl1S([In] object obj0) => (object) Projections.Property((string) obj0);

    internal static void hZavLNG0gOMT7649pOum() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool L3KsUgG0dY1IhwDf0mBb() => DefaultNoCast.O5Vq4UG09YpguDcpeeWi == null;

    internal static DefaultNoCast RKiIVRG0lAAknQuKgtw3() => DefaultNoCast.O5Vq4UG09YpguDcpeeWi;
  }
}
