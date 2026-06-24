// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.ReferenceOnEntityQueryResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions.QueryFunctionResults
{
  [Component]
  public class ReferenceOnEntityQueryResult : IQueryFunctionResult, IEQLFunction
  {
    internal static ReferenceOnEntityQueryResult s2jIZVGMej3rvvvXeG2S;

    public string FunctionName => (string) ReferenceOnEntityQueryResult.eVsXJAGMNMinu3dQqncX(~541731958 ^ -541829391);

    public object GetValue(EntityMetadata metadata, string propName, object[] parameters)
    {
      int num1 = 8;
      EntityMetadata entityMetadata1;
      Guid result;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          IMetadataRuntimeService serviceNotNull;
          PropertyInfo propertyInfo;
          IEnumerable<EntityMetadata> source;
          EntityMetadata entityMetadata2;
          string name;
          switch (num2)
          {
            case 1:
              if (ReferenceOnEntityQueryResult.XLOr2iGMaHdTxiIH1BeG((object) propertyInfo, (object) null))
                goto case 11;
              else
                goto label_15;
            case 2:
              if (entityMetadata1 != null)
              {
                num2 = 6;
                continue;
              }
              goto label_21;
            case 3:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 9 : 9;
              continue;
            case 4:
              goto label_21;
            case 5:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              EntityMetadata entityMetadata3 = source.FirstOrDefault<EntityMetadata>((Func<EntityMetadata, bool>) (m => ReferenceOnEntityQueryResult.\u003C\u003Ec__DisplayClass2_0.Pp1Cdf8CrYf2k3eHnALK(ReferenceOnEntityQueryResult.\u003C\u003Ec__DisplayClass2_0.sXrVsV8ClfL5RQKTOu2G((object) m), (object) name)));
              if (entityMetadata3 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
                continue;
              }
              entityMetadata2 = entityMetadata3;
              break;
            case 6:
              goto label_20;
            case 7:
              goto label_5;
            case 8:
              if (parameters.Length == 2)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 7;
                continue;
              }
              goto label_21;
            case 9:
              if (!Guid.TryParse((string) parameters[0], out result))
              {
                num2 = 10;
                continue;
              }
              goto label_23;
            case 10:
              // ISSUE: reference to a compiler-generated method
              source = serviceNotNull.GetMetadataList().OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (m => !ReferenceOnEntityQueryResult.\u003C\u003Ec.X8kJ0r8CLxfXXjjKohSQ((object) m)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 14 : 14;
              continue;
            case 11:
              if (typeof (ReferenceOnEntity).IsAssignableFrom(ReferenceOnEntityQueryResult.uimf9rGMDQ3ymqMedNqq((object) propertyInfo)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 3 : 0;
                continue;
              }
              goto label_21;
            case 12:
              goto label_23;
            case 13:
              serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
              num2 = 15;
              continue;
            case 14:
              name = (string) parameters[0];
              num2 = 5;
              continue;
            case 15:
              propertyInfo = (PropertyInfo) ReferenceOnEntityQueryResult.LYbGLQGMpFmf4TvLiUDt(serviceNotNull.GetTypeByUid(ReferenceOnEntityQueryResult.eJc9m1GM3RfX0ILTYTeM((object) metadata)), (object) propName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
              continue;
            case 16:
              if (parameters[1] is long)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 13 : 12;
                continue;
              }
              goto label_21;
            default:
              // ISSUE: reference to a compiler-generated method
              entityMetadata2 = source.FirstOrDefault<EntityMetadata>((Func<EntityMetadata, bool>) (m => ReferenceOnEntityQueryResult.\u003C\u003Ec__DisplayClass2_0.Pp1Cdf8CrYf2k3eHnALK((object) m.DisplayName, (object) name)));
              break;
          }
          entityMetadata1 = entityMetadata2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 2 : 0;
        }
label_5:
        if (parameters[0] is string)
        {
          num1 = 16;
          continue;
        }
        goto label_21;
label_15:
        num1 = 4;
      }
label_20:
      return ReferenceOnEntityQueryResult.aQ9udYGMw6DgVsxJkpYE(ReferenceOnEntityQueryResult.eJc9m1GM3RfX0ILTYTeM((object) entityMetadata1), ReferenceOnEntityQueryResult.Ru1OfwGMtJhrtKJV6Ill(parameters[1]));
label_21:
      throw new ArgumentException();
label_23:
      return (object) ReferenceOnEntity.Create(result, ReferenceOnEntityQueryResult.Ru1OfwGMtJhrtKJV6Ill(parameters[1]));
    }

    public IEnumerable<EQLFunction> GetEqlFunctions() => (IEnumerable<EQLFunction>) new EQLFunction[1]
    {
      new EQLFunction()
      {
        DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837927513), (object) this.FunctionName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420479770)), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082139878))),
        Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217621333)),
        Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418698918), (object) this.FunctionName),
        Types = new Guid[1]
        {
          ReferenceOnEntityDecription.UID
        }
      }
    };

    public ReferenceOnEntityQueryResult()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object eVsXJAGMNMinu3dQqncX(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool TgUUN0GMPfidLjCLxTj5() => ReferenceOnEntityQueryResult.s2jIZVGMej3rvvvXeG2S == null;

    internal static ReferenceOnEntityQueryResult I321LJGM1HCpFdlE8ZfH() => ReferenceOnEntityQueryResult.s2jIZVGMej3rvvvXeG2S;

    internal static Guid eJc9m1GM3RfX0ILTYTeM([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object LYbGLQGMpFmf4TvLiUDt(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static bool XLOr2iGMaHdTxiIH1BeG([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static Type uimf9rGMDQ3ymqMedNqq([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static long Ru1OfwGMtJhrtKJV6Ill([In] object obj0) => Convert.ToInt64(obj0);

    internal static object aQ9udYGMw6DgVsxJkpYE(Guid typeUid, long id) => (object) ReferenceOnEntity.Create(typeUid, id);
  }
}
