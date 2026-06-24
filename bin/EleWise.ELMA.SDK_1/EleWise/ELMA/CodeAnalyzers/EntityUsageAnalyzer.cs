// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CodeAnalyzers.EntityUsageAnalyzer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.CodeAnalyzers.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.CodeAnalyzers
{
  /// <summary>Обработчик использования свойств сущности в коде</summary>
  public abstract class EntityUsageAnalyzer : IAnalyzerWithResult
  {
    private readonly UsageAnalyzer usageAnalyzer;
    private IDictionary<string, EntityMetadata> entityMetadataList;
    internal static EntityUsageAnalyzer UbEIrIfRD7NEFnjYJN8U;

    /// <summary>Список метаданных</summary>
    protected virtual IDictionary<string, EntityMetadata> EntityMetadataList => this.entityMetadataList ?? (this.entityMetadataList = (IDictionary<string, EntityMetadata>) MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>().GroupBy<EntityMetadata, string>((Func<EntityMetadata, string>) (m => (string) EntityUsageAnalyzer.\u003C\u003Ec.uHQMG68Yfxmj1QAD29Nd((object) m))).ToDictionary<IGrouping<string, EntityMetadata>, string, EntityMetadata>((Func<IGrouping<string, EntityMetadata>, string>) (g => g.Key), (Func<IGrouping<string, EntityMetadata>, EntityMetadata>) (g => g.First<EntityMetadata>())));

    /// <summary>Ctor</summary>
    public EntityUsageAnalyzer()
    {
      EntityUsageAnalyzer.muIuGMfR4i5bq4eaYATw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num1 = 0;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            this.CodeAnalyzerResult = (ICodeAnalyzerResult) new EleWise.ELMA.CodeAnalyzers.Model.CodeAnalyzerResult();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 0;
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
                    this.CheckIfEntity(s, n);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
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
    /// <param name="analyzer">EntityUsageAnalyzer</param>
    public static implicit operator DiagnosticAnalyzer(EntityUsageAnalyzer analyzer) => (DiagnosticAnalyzer) analyzer.usageAnalyzer;

    /// <summary>Результат анализа</summary>
    public ICodeAnalyzerResult CodeAnalyzerResult { get; }

    /// <summary>Проверить модуль типа</summary>
    /// <param name="module">Модуль типа</param>
    /// <returns><c>true</c>, если модуль типа подходит</returns>
    protected abstract bool CheckModule(IModuleSymbol module);

    private (ISymbol, EntityMetadata) CheckIfEntity(SemanticModel semanticModel, SyntaxNode node)
    {
      if (node == null)
        return ((ISymbol) null, (EntityMetadata) null);
      ISymbol symbol = semanticModel.GetSymbolInfo(node).Symbol;
      if (symbol == null)
        return ((ISymbol) null, (EntityMetadata) null);
      switch (symbol)
      {
        case IPropertySymbol propertySymbol:
          (ISymbol, EntityMetadata) valueTuple = InternalCheck(propertySymbol.Type);
          (ISymbol, EntityMetadata) tuple = InternalCheck((ITypeSymbol) symbol.ContainingType);
          return tuple.Item2 == null ? valueTuple : tuple;
        case ITypeSymbol typeSymbol:
          return InternalCheck(typeSymbol.OriginalDefinition);
        default:
          return InternalCheck((ITypeSymbol) symbol.ContainingType);
      }

      (ISymbol, EntityMetadata) InternalCheck(ITypeSymbol type)
      {
        if (type == null)
          return (symbol, (EntityMetadata) null);
        if (!this.CheckModule(type.ContainingModule))
          return (symbol, (EntityMetadata) null);
        EntityMetadata key;
        if (!this.EntityMetadataList.TryGetValue(type.ToString(), out key))
          return (symbol, (EntityMetadata) null);
        if (!this.CodeAnalyzerResult.ReferenceMetadata.ContainsKey((IMetadata) key))
          this.CodeAnalyzerResult.ReferenceMetadata[(IMetadata) key] = (ICollection<IPropertyMetadata>) new List<IPropertyMetadata>();
        return (symbol, key);
      }
    }

    private void ProcessSymbol(SemanticModel semanticModel, SyntaxNode syntax, string propertyName)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        IMetadata key1;
        EntityMetadata key2;
        ISymbol symbol;
        string propertyName1;
        IPropertyMetadata property;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_27;
            case 1:
              (symbol, key2) = this.CheckIfEntity(semanticModel, syntax);
              num2 = 14;
              continue;
            case 2:
              goto label_19;
            case 3:
              goto label_12;
            case 4:
              propertyName1 = propertyName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
              continue;
            case 5:
              num2 = 4;
              continue;
            case 6:
              if (!this.CodeAnalyzerResult.ReferenceMetadata.ContainsKey((IMetadata) key2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 10 : 13;
                continue;
              }
              goto case 15;
            case 7:
              goto label_17;
            case 8:
              goto label_34;
            case 9:
              if (this.CodeAnalyzerResult.ReferenceMetadata.ContainsKey(key1))
              {
                num2 = 12;
                continue;
              }
              goto case 18;
            case 10:
              key1 = MetadataLoader.LoadMetadataOrNull(EntityUsageAnalyzer.Nqa87dfRA2Wg8THg9ZDe((object) property));
              num2 = 17;
              continue;
            case 11:
              goto label_41;
            case 12:
              goto label_3;
            case 13:
              this.CodeAnalyzerResult.ReferenceMetadata[(IMetadata) key2] = (ICollection<IPropertyMetadata>) new List<IPropertyMetadata>();
              num2 = 15;
              continue;
            case 14:
              if (symbol == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 8 : 4;
                continue;
              }
              goto case 22;
            case 15:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (this.CodeAnalyzerResult.ReferenceMetadata[(IMetadata) key2].FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (a => EntityUsageAnalyzer.\u003C\u003Ec__DisplayClass11_0.vQ7pdr8YiRJ3B8PLtR8v(EntityUsageAnalyzer.\u003C\u003Ec__DisplayClass11_0.NWD40i8YSNaPiJw5kPSD((object) a), EntityUsageAnalyzer.\u003C\u003Ec__DisplayClass11_0.NWD40i8YSNaPiJw5kPSD((object) property)))) == null)
              {
                this.CodeAnalyzerResult.ReferenceMetadata[(IMetadata) key2].Add(property);
                num2 = 23;
                continue;
              }
              goto label_40;
            case 16:
              if (EntityUsageAnalyzer.qfUiUIfR6bCx4YZQe0r5((object) propertySymbol) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 21 : 3;
                continue;
              }
              // ISSUE: reference to a compiler-generated method
              property = key2.GetAllPropertiesAndTableParts().FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (p => EntityUsageAnalyzer.\u003C\u003Ec__DisplayClass11_0.kNM5Lj8YVQyUP0BXH92v((object) p.Name, (object) propertyName1)));
              num2 = 2;
              continue;
            case 17:
              if (key1 == null)
              {
                num2 = 3;
                continue;
              }
              goto case 9;
            case 18:
              this.CodeAnalyzerResult.ReferenceMetadata[key1] = (ICollection<IPropertyMetadata>) new List<IPropertyMetadata>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            case 19:
              goto label_43;
            case 20:
              goto label_35;
            case 21:
              goto label_6;
            case 22:
              if (key2 == null)
              {
                num2 = 19;
                continue;
              }
              if (symbol is IPropertySymbol propertySymbol)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 16 : 15;
                continue;
              }
              goto label_32;
            case 23:
              if (EntityUsageAnalyzer.ohqjOWfRHK420aMqDwjo((object) property) is EntitySettings)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 4 : 10;
                continue;
              }
              goto label_13;
            default:
              goto label_42;
          }
        }
label_19:
        if (property != null)
        {
          num1 = 6;
          continue;
        }
        goto label_16;
label_40:
        num1 = 20;
      }
label_27:
      return;
label_12:
      return;
label_17:
      return;
label_34:
      return;
label_41:
      return;
label_3:
      return;
label_43:
      return;
label_35:
      return;
label_6:
      return;
label_42:
      return;
label_13:
      return;
label_16:
      return;
label_32:;
    }

    internal static void muIuGMfR4i5bq4eaYATw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool y8YEX2fRtWqv9PoOsqmU() => EntityUsageAnalyzer.UbEIrIfRD7NEFnjYJN8U == null;

    internal static EntityUsageAnalyzer tXlVIbfRwQKBp338Ur0v() => EntityUsageAnalyzer.UbEIrIfRD7NEFnjYJN8U;

    internal static object qfUiUIfR6bCx4YZQe0r5([In] object obj0) => (object) ((IPropertySymbol) obj0).GetMethod;

    internal static object ohqjOWfRHK420aMqDwjo([In] object obj0) => (object) ((IPropertyMetadata) obj0).Settings;

    internal static Guid Nqa87dfRA2Wg8THg9ZDe([In] object obj0) => ((IPropertyMetadata) obj0).SubTypeUid;
  }
}
