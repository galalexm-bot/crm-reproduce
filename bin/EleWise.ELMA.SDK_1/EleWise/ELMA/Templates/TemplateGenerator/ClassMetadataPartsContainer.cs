// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.TemplateGenerator.ClassMetadataPartsContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Templates.TemplateGenerator
{
  /// <summary>Класс содержащий несколько метаданных классов</summary>
  public sealed class ClassMetadataPartsContainer
  {
    private readonly ICollection<ClassMetadata> classMetadataParts;

    /// <summary>Ctor</summary>
    /// <param name="classMetadataParts">Массив метаданных класса</param>
    public ClassMetadataPartsContainer(IEnumerable<ClassMetadata> classMetadataParts)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.classMetadataParts = (ICollection<ClassMetadata>) new List<ClassMetadata>();
      this.classMetadataParts.AddRange<ClassMetadata>(classMetadataParts.Where<ClassMetadata>((Func<ClassMetadata, bool>) (m => m != null)));
    }

    /// <summary>Получить метаданные классов из контейнера</summary>
    /// <returns></returns>
    public IEnumerable<ClassMetadata> GetClassMetadataParts() => (IEnumerable<ClassMetadata>) this.classMetadataParts;
  }
}
