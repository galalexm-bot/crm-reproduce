// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CodeAnalyzers.Model.CodeAnalyzerResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.CodeAnalyzers.Model
{
  /// <inheritdoc />
  public sealed class CodeAnalyzerResult : ICodeAnalyzerResult
  {
    private static CodeAnalyzerResult fDCoPHfRYlwunyQQm5yK;

    /// <summary>Ctor</summary>
    public CodeAnalyzerResult()
    {
      CodeAnalyzerResult.XL3ypUfRsgedNlNhujMO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.ReferenceMetadata = (IDictionary<IMetadata, ICollection<IPropertyMetadata>>) new Dictionary<IMetadata, ICollection<IPropertyMetadata>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public IDictionary<IMetadata, ICollection<IPropertyMetadata>> ReferenceMetadata { get; }

    internal static void XL3ypUfRsgedNlNhujMO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool LGxd1jfRL95QvES04sIO() => CodeAnalyzerResult.fDCoPHfRYlwunyQQm5yK == null;

    internal static CodeAnalyzerResult xw8qrAfRU1FWZvnbiODn() => CodeAnalyzerResult.fDCoPHfRYlwunyQQm5yK;
  }
}
