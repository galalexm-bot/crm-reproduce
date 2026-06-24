// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.DropDownItemQueryResult
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

namespace EleWise.ELMA.Extensions.QueryFunctionResults
{
  [Component]
  public class DropDownItemQueryResult : IQueryFunctionResult, IEQLFunction
  {
    private static DropDownItemQueryResult aFfl3LGmM2qA7xr7Zw2P;

    public string FunctionName => (string) DropDownItemQueryResult.PcH5IwGmdpf9XZBf0O6L(-2092274397 << 4 ^ 883228222);

    public object GetValue(EntityMetadata metadata, string propName, object[] parameters)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parameters.Length == 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            goto label_4;
          default:
            if (parameters[0] is string)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 2 : 2;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      return (object) new DropDownItem((string) parameters[0]);
label_5:
      throw new ArgumentException();
    }

    public IEnumerable<EQLFunction> GetEqlFunctions() => (IEnumerable<EQLFunction>) new EQLFunction[1]
    {
      new EQLFunction()
      {
        DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875968559), (object) this.FunctionName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461366447))),
        Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70172145)),
        Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418699446), (object) this.FunctionName),
        Types = new Guid[1]{ DropDownListDescriptor.UID }
      }
    };

    public DropDownItemQueryResult()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object PcH5IwGmdpf9XZBf0O6L(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool sQ7YR2GmJnTZM8FcgMNm() => DropDownItemQueryResult.aFfl3LGmM2qA7xr7Zw2P == null;

    internal static DropDownItemQueryResult zPNMAgGm9QNr3mrMbUWf() => DropDownItemQueryResult.aFfl3LGmM2qA7xr7Zw2P;
  }
}
