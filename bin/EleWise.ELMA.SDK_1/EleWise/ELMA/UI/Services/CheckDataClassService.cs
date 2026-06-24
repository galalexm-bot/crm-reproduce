// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.CheckDataClassService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.UI.Services
{
  /// <inheritdoc />
  [Service]
  internal sealed class CheckDataClassService : ICheckDataClassService
  {
    internal static CheckDataClassService Fj32HKs88t7RZBtlgcB;

    /// <inheritdoc />
    public ValidationResult Validate(DataClassMetadata dataClassMetadata) => new ValidationResult(true, Array.Empty<ValidationError>());

    public CheckDataClassService()
    {
      CheckDataClassService.xMCUXVsITph4Eylh3hM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool fexJ6XsZk6Msyiq1DdQ() => CheckDataClassService.Fj32HKs88t7RZBtlgcB == null;

    internal static CheckDataClassService olZw24suHgn5UGPkRyF() => CheckDataClassService.Fj32HKs88t7RZBtlgcB;

    internal static void xMCUXVsITph4Eylh3hM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
