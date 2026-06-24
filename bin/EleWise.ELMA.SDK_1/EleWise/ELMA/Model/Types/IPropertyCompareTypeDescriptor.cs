// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.IPropertyCompareTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Дополнительный интерфейс описателя типов, который поддерживает сравнение значений данного типа
  /// </summary>
  public interface IPropertyCompareTypeDescriptor
  {
    /// <summary>
    /// Получить сериализуемые значения для сравниваемого свойства данного типа
    /// </summary>
    /// <param name="oldObject">Объект до изменения, содержащий свойство данного типа</param>
    /// <param name="newObject">Измененный объект,  содержащий свойство данного типа</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Данные сравнения в сериализуемом представлении</returns>
    PropertyCompareData GetCompareData(
      object oldObject,
      object newObject,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata);

    /// <summary>
    /// Восстановить значение свойства из сериализуемых значений
    /// </summary>
    /// <param name="oldObject">Объект до изменения, содержащий свойство данного типа</param>
    /// <param name="newObject">Измененный объект,  содержащий свойство данного типа</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="compareData">Данные сравнения в сериализуемом представлении</param>
    void SetCompareData(
      object oldObject,
      object newObject,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      PropertyCompareData compareData);
  }
}
