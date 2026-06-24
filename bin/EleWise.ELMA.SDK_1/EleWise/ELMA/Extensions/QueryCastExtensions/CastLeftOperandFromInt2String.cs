// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryCastExtensions.CastLeftOperandFromInt2String
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
  internal class CastLeftOperandFromInt2String : IQueryCastExtension
  {
    private ITransformationProvider transformationProvider;
    private static CastLeftOperandFromInt2String b71JY3G0nEJNBIGuYyDg;

    public Type LeftOperandType => CastLeftOperandFromInt2String.c8LEAIG0eFCOmdRRF2LL(__typeref (int));

    public Type RightOperandType => CastLeftOperandFromInt2String.c8LEAIG0eFCOmdRRF2LL(__typeref (string));

    public CastLeftOperandFromInt2String(ITransformationProvider transformationProvider)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.transformationProvider = transformationProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public SqlString CastLeftOperand(SqlString sqlString)
    {
      int num = 1;
      string typeName;
      while (true)
      {
        switch (num)
        {
          case 1:
            typeName = ((Dialect) CastLeftOperandFromInt2String.wgEV8aG0PjAtMNb7tKWq((object) this.transformationProvider)).GetTypeName(DbType.AnsiString);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return new SqlString((string) CastLeftOperandFromInt2String.II6DdmG01cGQEHLygBjJ((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16494043), (object) sqlString, (object) typeName));
    }

    public IProjection CastRightOperand(string propertyName) => (IProjection) CastLeftOperandFromInt2String.BlX0ViG0N5QYrhepk7lZ((object) propertyName);

    internal static Type c8LEAIG0eFCOmdRRF2LL([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool VshMlhG0OdpeW5EdvRnb() => CastLeftOperandFromInt2String.b71JY3G0nEJNBIGuYyDg == null;

    internal static CastLeftOperandFromInt2String S7TIoOG027LfdyRJTafR() => CastLeftOperandFromInt2String.b71JY3G0nEJNBIGuYyDg;

    internal static object wgEV8aG0PjAtMNb7tKWq([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object II6DdmG01cGQEHLygBjJ([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object BlX0ViG0N5QYrhepk7lZ([In] object obj0) => (object) Projections.Property((string) obj0);
  }
}
