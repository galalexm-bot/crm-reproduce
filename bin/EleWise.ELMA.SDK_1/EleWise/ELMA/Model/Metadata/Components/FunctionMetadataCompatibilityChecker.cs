// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Components.FunctionMetadataCompatibilityChecker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Dependencies;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata.Components
{
  /// <inheritdoc />
  [Component]
  internal sealed class FunctionMetadataCompatibilityChecker : 
    CompatibilityChecker<FunctionDependency>
  {
    private static FunctionMetadataCompatibilityChecker dRdASFhWESA61D2FiMUy;

    /// <inheritdoc />
    public override ICollection<string> CheckCompatibility(
      FunctionDependency old,
      FunctionDependency @new)
    {
      Contract.NotNull((object) old, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61133219));
      Contract.NotNull((object) @new, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426088701));
      List<string> stringList = new List<string>();
      CompatibilityResult compatibilityResult1 = old.ParameterType.Compatible(@new.ParameterType);
      if (!compatibilityResult1.IsValid)
      {
        stringList.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234094682), (object) @new.DisplayName));
        stringList.AddRange((IEnumerable<string>) compatibilityResult1.Errors);
      }
      CompatibilityResult compatibilityResult2 = old.ReturnType.Compatible(@new.ReturnType);
      if (!compatibilityResult2.IsValid)
      {
        stringList.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675301145), (object) @new.DisplayName));
        stringList.AddRange((IEnumerable<string>) compatibilityResult2.Errors);
      }
      return (ICollection<string>) stringList;
    }

    public FunctionMetadataCompatibilityChecker()
    {
      FunctionMetadataCompatibilityChecker.z69HJnhWCNYhQiNhDvLU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void z69HJnhWCNYhQiNhDvLU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool SWErQshWfVReNkUB3a8P() => FunctionMetadataCompatibilityChecker.dRdASFhWESA61D2FiMUy == null;

    internal static FunctionMetadataCompatibilityChecker yWS2xnhWQPBtyftQ3qFh() => FunctionMetadataCompatibilityChecker.dRdASFhWESA61D2FiMUy;
  }
}
