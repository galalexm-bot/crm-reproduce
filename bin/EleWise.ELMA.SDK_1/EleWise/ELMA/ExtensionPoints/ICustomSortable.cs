// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.ICustomSortable
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Кастомная сортировка</summary>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface ICustomSortable
  {
    /// <summary>Проверка метаданных</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="sortExpression">Сортировочное выражение</param>
    /// <returns></returns>
    bool CheckMetadata(ClassMetadata classMetadata, string sortExpression);

    /// <summary>Проверка на возможность сортировки</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="metadata">Метаданные свойства класса</param>
    /// <returns><c>true</c>, если возможно применить сортировку</returns>
    bool IsSortable(ClassMetadata classMetadata, PropertyMetadata metadata);

    /// <summary>Построить сортировку по выражению</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="sortExpression">Сортировочное выражение</param>
    /// <returns>Сортировка</returns>
    string BuildSortExpression(ClassMetadata classMetadata, string sortExpression);
  }
}
