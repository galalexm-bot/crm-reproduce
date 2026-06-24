// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CodeAnalyzers.DataClassUsageAnalyzer
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
using System.Runtime.InteropServices;

namespace EleWise.ELMA.CodeAnalyzers
{
  /// <summary>Обработчик использования свойств DataClass в коде</summary>
  public sealed class DataClassUsageAnalyzer : IAnalyzerWithResult
  {
    private readonly UsageAnalyzer usageAnalyzer;
    private IDictionary<string, DataClassMetadata> dataClassMetadataList;
    private static DataClassUsageAnalyzer PlrfXIfRPR2EpOtYcqwn;

    private IDictionary<string, DataClassMetadata> DataClassMetadataList => this.dataClassMetadataList ?? (this.dataClassMetadataList = (IDictionary<string, DataClassMetadata>) MetadataServiceContext.Service.GetMetadataList().OfType<DataClassMetadata>().GroupBy<DataClassMetadata, string>((Func<DataClassMetadata, string>) (m => (string) DataClassUsageAnalyzer.\u003C\u003Ec.ilTcHW8jjxLUOmqyZMcf((object) m))).ToDictionary<IGrouping<string, DataClassMetadata>, string, DataClassMetadata>((Func<IGrouping<string, DataClassMetadata>, string>) (g => g.Key), (Func<IGrouping<string, DataClassMetadata>, DataClassMetadata>) (g => g.First<DataClassMetadata>())));

    /// <summary>Ctor</summary>
    public DataClassUsageAnalyzer()
    {
      DataClassUsageAnalyzer.FhPw8XfR3rGCuAdVx7FV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
        num1 = 0;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            this.CodeAnalyzerResult = (ICodeAnalyzerResult) new EleWise.ELMA.CodeAnalyzers.Model.CodeAnalyzerResult();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
            continue;
          default:
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
                    this.CheckIfDataClass(s, n);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }), new Action<SemanticModel, SyntaxNode, string>(this.ProcessSymbol));
            num1 = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Оператор приведения к DiagnosticAnalyzer</summary>
    /// <param name="analyzer">DataClassUsageAnalyzer</param>
    public static implicit operator DiagnosticAnalyzer(DataClassUsageAnalyzer analyzer) => (DiagnosticAnalyzer) analyzer.usageAnalyzer;

    /// <summary>Результат анализа</summary>
    public ICodeAnalyzerResult CodeAnalyzerResult { get; }

    private (ISymbol, DataClassMetadata) CheckIfDataClass(
      SemanticModel semanticModel,
      SyntaxNode node)
    {
      if (node == null)
        return ((ISymbol) null, (DataClassMetadata) null);
      ISymbol symbol = semanticModel.GetSymbolInfo(node).Symbol;
      if (symbol == null)
        return ((ISymbol) null, (DataClassMetadata) null);
      switch (symbol)
      {
        case IPropertySymbol propertySymbol:
          (ISymbol, DataClassMetadata) valueTuple = InternalCheck((ISymbol) propertySymbol.Type);
          (ISymbol, DataClassMetadata) tuple = InternalCheck((ISymbol) symbol.ContainingType);
          return tuple.Item2 == null ? valueTuple : tuple;
        case ITypeSymbol typeSymbol:
          return InternalCheck((ISymbol) typeSymbol.OriginalDefinition);
        default:
          return InternalCheck((ISymbol) symbol.ContainingType);
      }

      (ISymbol, DataClassMetadata) InternalCheck(ISymbol type)
      {
        if (type == null)
          return (symbol, (DataClassMetadata) null);
        DataClassMetadata key;
        if (!this.DataClassMetadataList.TryGetValue(type.ToString(), out key))
          return (symbol, (DataClassMetadata) null);
        if (!this.CodeAnalyzerResult.ReferenceMetadata.ContainsKey((IMetadata) key))
          this.CodeAnalyzerResult.ReferenceMetadata[(IMetadata) key] = (ICollection<IPropertyMetadata>) new List<IPropertyMetadata>();
        return (symbol, key);
      }
    }

    private void ProcessSymbol(SemanticModel semanticModel, SyntaxNode syntax, string propertyName)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        DataClassMetadata key;
        ISymbol symbol;
        string propertyName1;
        PropertyMetadata property;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_7;
            case 1:
              goto label_6;
            case 2:
              propertyName1 = propertyName;
              num2 = 9;
              continue;
            case 3:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 2;
              continue;
            case 4:
              if (property != null)
              {
                num2 = 16;
                continue;
              }
              goto label_3;
            case 5:
            case 13:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (this.CodeAnalyzerResult.ReferenceMetadata[(IMetadata) key].FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (a => DataClassUsageAnalyzer.\u003C\u003Ec__DisplayClass10_0.TKZMHC8Yoab7YcGXcyDx(DataClassUsageAnalyzer.\u003C\u003Ec__DisplayClass10_0.NtGWSA8YWfD7XnHZNmVW((object) a), property.Uid))) != null)
              {
                num2 = 6;
                continue;
              }
              goto label_20;
            case 6:
              goto label_10;
            case 7:
              goto label_9;
            case 8:
              goto label_19;
            case 9:
              (symbol, key) = this.CheckIfDataClass(semanticModel, syntax);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 14 : 13;
              continue;
            case 10:
              if (key != null)
              {
                if (!(symbol is IPropertySymbol propertySymbol))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 4 : 15;
                  continue;
                }
                if (DataClassUsageAnalyzer.kWTT9mfRpOEwehPbkF7K((object) propertySymbol) == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
                  continue;
                }
                goto case 11;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 7;
                continue;
              }
            case 11:
              if (DataClassUsageAnalyzer.jUcUbgfRaFSLXGsIuWrQ((object) propertySymbol) != null)
              {
                // ISSUE: reference to a compiler-generated method
                property = key.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => DataClassUsageAnalyzer.\u003C\u003Ec__DisplayClass10_0.wCri3F8YBRJEE4eCjLKY((object) p.Name, (object) propertyName1)));
                num2 = 4;
                continue;
              }
              num2 = 12;
              continue;
            case 12:
              goto label_13;
            case 14:
              if (symbol == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
                continue;
              }
              goto case 10;
            case 15:
              goto label_25;
            case 16:
              if (this.CodeAnalyzerResult.ReferenceMetadata.ContainsKey((IMetadata) key))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 3 : 5;
                continue;
              }
              goto case 17;
            case 17:
              this.CodeAnalyzerResult.ReferenceMetadata[(IMetadata) key] = (ICollection<IPropertyMetadata>) new List<IPropertyMetadata>();
              num2 = 13;
              continue;
            case 18:
              goto label_14;
            default:
              goto label_5;
          }
        }
label_20:
        this.CodeAnalyzerResult.ReferenceMetadata[(IMetadata) key].Add((IPropertyMetadata) property);
        num1 = 18;
      }
label_7:
      return;
label_6:
      return;
label_10:
      return;
label_9:
      return;
label_19:
      return;
label_13:
      return;
label_25:
      return;
label_14:
      return;
label_5:
      return;
label_3:;
    }

    internal static void FhPw8XfR3rGCuAdVx7FV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool zGgR9xfR111Kppfrjlrc() => DataClassUsageAnalyzer.PlrfXIfRPR2EpOtYcqwn == null;

    internal static DataClassUsageAnalyzer Wg349DfRNhixaElDwMvS() => DataClassUsageAnalyzer.PlrfXIfRPR2EpOtYcqwn;

    internal static object kWTT9mfRpOEwehPbkF7K([In] object obj0) => (object) ((IPropertySymbol) obj0).GetMethod;

    internal static object jUcUbgfRaFSLXGsIuWrQ([In] object obj0) => (object) ((IPropertySymbol) obj0).SetMethod;
  }
}
