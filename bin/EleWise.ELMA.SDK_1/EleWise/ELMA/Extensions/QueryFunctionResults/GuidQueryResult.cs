// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.GuidQueryResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions.QueryFunctionResults
{
  [Component]
  public class GuidQueryResult : IQueryFunctionResult, IEQLFunction
  {
    internal static GuidQueryResult EAoucqGJvdh3WxNa2O0Q;

    public string FunctionName => (string) GuidQueryResult.TRc3ntGJuoaSh4rJTQjs(-105199646 ^ -104937446);

    public object GetValue(EntityMetadata metadata, string propName, object[] parameters)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parameters[0] is string)
            {
              num = 3;
              continue;
            }
            break;
          case 2:
            if (!GuidQueryResult.jCHaVkGJIx5yfl8yuW6a((object) (string) parameters[0], GuidQueryResult.TRc3ntGJuoaSh4rJTQjs(1051276242 - 990076387 ^ 60933625), StringComparison.OrdinalIgnoreCase))
            {
              num = 9;
              continue;
            }
            goto label_7;
          case 3:
            if (GuidQueryResult.jCHaVkGJIx5yfl8yuW6a((object) (string) parameters[0], GuidQueryResult.TRc3ntGJuoaSh4rJTQjs(236071375 ^ 236337611), StringComparison.OrdinalIgnoreCase))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 12 : 11;
              continue;
            }
            break;
          case 4:
            if (parameters.Length == 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 1;
              continue;
            }
            break;
          case 5:
            if (parameters.Length != 0)
            {
              num = 4;
              continue;
            }
            goto label_4;
          case 6:
            goto label_10;
          case 7:
            if (!(parameters[0] is string))
            {
              num = 10;
              continue;
            }
            goto label_10;
          case 8:
          case 9:
label_8:
            if (parameters.Length == 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 7 : 3;
              continue;
            }
            goto label_11;
          case 10:
            goto label_11;
          case 11:
            if (!(parameters[0] is string))
            {
              num = 8;
              continue;
            }
            goto case 2;
          case 12:
            goto label_4;
          default:
            goto label_7;
        }
        if (parameters.Length == 1)
          num = 11;
        else
          goto label_8;
      }
label_4:
      return (object) GuidQueryResult.Yk3VBlGJVu3N6wgoRJ8V();
label_7:
      return (object) Guid.Empty;
label_10:
      return (object) new Guid((string) parameters[0]);
label_11:
      throw new ArgumentException();
    }

    public IEnumerable<EQLFunction> GetEqlFunctions() => (IEnumerable<EQLFunction>) new EQLFunction[1]
    {
      new EQLFunction()
      {
        DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099567063), (object) this.FunctionName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787186367))),
        Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87313709)),
        Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813338505), (object) this.FunctionName),
        Types = new Guid[1]{ GuidDescriptor.UID }
      }
    };

    public GuidQueryResult()
    {
      GuidQueryResult.OR1iCaGJSU6agJOpU6FD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object TRc3ntGJuoaSh4rJTQjs(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool vynMLEGJ8LURp0wXmhDd() => GuidQueryResult.EAoucqGJvdh3WxNa2O0Q == null;

    internal static GuidQueryResult xZD3xqGJZQGHBZKJ8R2g() => GuidQueryResult.EAoucqGJvdh3WxNa2O0Q;

    internal static bool jCHaVkGJIx5yfl8yuW6a([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static Guid Yk3VBlGJVu3N6wgoRJ8V() => Guid.NewGuid();

    internal static void OR1iCaGJSU6agJOpU6FD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
