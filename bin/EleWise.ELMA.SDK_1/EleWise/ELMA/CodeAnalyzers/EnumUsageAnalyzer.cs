// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CodeAnalyzers.EnumUsageAnalyzer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.CodeAnalyzers.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CodeAnalyzers
{
  /// <summary>Обработчик использования перечислений в коде</summary>
  public sealed class EnumUsageAnalyzer : IAnalyzerWithResult
  {
    private readonly UsageAnalyzer usageAnalyzer;
    private IDictionary<string, EnumMetadata> enumMetadataList;
    internal static EnumUsageAnalyzer l0nU36fR7KF79C8GOHux;

    private IDictionary<string, EnumMetadata> EnumMetadataList => this.enumMetadataList ?? (this.enumMetadataList = (IDictionary<string, EnumMetadata>) MetadataServiceContext.Service.GetMetadataList().OfType<EnumMetadata>().GroupBy<EnumMetadata, string>((Func<EnumMetadata, string>) (m => (string) EnumUsageAnalyzer.\u003C\u003Ec.GeQhAi8YTTSMa0m3UmWI((object) m))).ToDictionary<IGrouping<string, EnumMetadata>, string, EnumMetadata>((Func<IGrouping<string, EnumMetadata>, string>) (g => g.Key), (Func<IGrouping<string, EnumMetadata>, EnumMetadata>) (g => g.First<EnumMetadata>())));

    /// <summary>Ctor</summary>
    public EnumUsageAnalyzer()
    {
      EnumUsageAnalyzer.TyNEqyfRmBAJRh5BL58I();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this.usageAnalyzer = new UsageAnalyzer((Action<SemanticModel, SyntaxNode>) ((s, n) =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    this.CheckIfEnum(s, n);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }), new Action<SemanticModel, SyntaxNode, string>(this.ProcessSymbol));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.CodeAnalyzerResult = (ICodeAnalyzerResult) new EleWise.ELMA.CodeAnalyzers.Model.CodeAnalyzerResult();
            num1 = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Оператор приведения к DiagnosticAnalyzer</summary>
    /// <param name="analyzer">EntityUsageAnalyzer</param>
    public static implicit operator DiagnosticAnalyzer(EnumUsageAnalyzer analyzer) => (DiagnosticAnalyzer) analyzer.usageAnalyzer;

    /// <summary>Результат анализа</summary>
    public ICodeAnalyzerResult CodeAnalyzerResult { get; }

    private (ISymbol, EnumMetadata) CheckIfEnum(SemanticModel semanticModel, SyntaxNode node)
    {
      if (node == null)
        return ((ISymbol) null, (EnumMetadata) null);
      ISymbol symbol = semanticModel.GetSymbolInfo(node).Symbol;
      if (symbol == null)
        return ((ISymbol) null, (EnumMetadata) null);
      switch (symbol)
      {
        case IPropertySymbol propertySymbol:
          (ISymbol, EnumMetadata) valueTuple = InternalCheck(propertySymbol.Type);
          (ISymbol, EnumMetadata) tuple = InternalCheck((ITypeSymbol) symbol.ContainingType);
          return tuple.Item2 == null ? valueTuple : tuple;
        case ITypeSymbol typeSymbol:
          return InternalCheck(typeSymbol.OriginalDefinition);
        default:
          return InternalCheck((ITypeSymbol) symbol.ContainingType);
      }

      (ISymbol, EnumMetadata) InternalCheck(ITypeSymbol type)
      {
        if (type == null)
          return (symbol, (EnumMetadata) null);
        string key1 = type.ToString();
        if (string.IsNullOrWhiteSpace(key1))
          return (symbol, (EnumMetadata) null);
        EnumMetadata key2;
        if (!this.EnumMetadataList.TryGetValue(key1, out key2))
          return (symbol, (EnumMetadata) null);
        if (!this.CodeAnalyzerResult.ReferenceMetadata.ContainsKey((IMetadata) key2))
          this.CodeAnalyzerResult.ReferenceMetadata[(IMetadata) key2] = (ICollection<IPropertyMetadata>) new List<IPropertyMetadata>();
        return (symbol, key2);
      }
    }

    private void ProcessSymbol(SemanticModel semanticModel, SyntaxNode syntax, string propertyName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.CheckIfEnum(semanticModel, syntax);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void TyNEqyfRmBAJRh5BL58I() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool IgPh12fRxZmjK1BjHjhB() => EnumUsageAnalyzer.l0nU36fR7KF79C8GOHux == null;

    internal static EnumUsageAnalyzer svVsCXfR0HEa3rLwtn2D() => EnumUsageAnalyzer.l0nU36fR7KF79C8GOHux;
  }
}
