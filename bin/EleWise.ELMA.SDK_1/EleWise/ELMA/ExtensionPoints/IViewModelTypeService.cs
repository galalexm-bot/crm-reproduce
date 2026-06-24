// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IViewModelTypeService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для получения типа модели представления по типу метаданных
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IViewModelTypeService
  {
    /// <summary>
    /// Проверить то, может ли данный компонент использоваться для типа метаданных
    /// </summary>
    /// <param name="metadataTypeCode">Код типа метаданных</param>
    bool Check(string metadataTypeCode);

    /// <summary>Получить тип модели представления для свойства</summary>
    /// <param name="property">Метаданные свойства</param>
    /// <param name="metadataNamespace">Пространство имен объекта метаданных, в которых находится свойство</param>
    /// <returns>Имя типа модели представления</returns>
    ViewModelTypeName GetViewPropertyModelType(IPropertyMetadata property, string metadataNamespace);

    /// <summary>Получить тип модели представления</summary>
    /// <param name="metadataName">Имя объекта метаданных, в которых находится свойство</param>
    /// <param name="metadataNamespace">Пространство имен объекта метаданных, в которых находится свойство</param>
    /// <param name="useOriginalModel">Использовать оригинальную модель</param>
    /// <returns>Имя типа модели представления</returns>
    ViewModelTypeName GetViewModelType(
      string metadataName,
      string metadataNamespace,
      bool useOriginalModel);
  }
}
