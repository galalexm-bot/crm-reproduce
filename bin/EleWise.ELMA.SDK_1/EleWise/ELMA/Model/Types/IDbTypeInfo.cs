// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.IDbTypeInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Дополнительный интерфейс типа, предоставляющий информацию о структуре в БД
  /// </summary>
  public interface IDbTypeInfo
  {
    /// <summary>Поддерживается ли автоинкремент</summary>
    bool AutoIncrementSupported { get; }

    /// <summary>Получить информацию о требуемых структурах БД</summary>
    /// <param name="entityMetadata">Метаданные сущности (не может быть NULL)</param>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Структуры БД</returns>
    TypeDbStructures GetDbStructures(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata);

    /// <summary>Применить изменения в структуре БД в updater</summary>
    /// <param name="updater">Обработчик изменения структуры БД моделей</param>
    /// <param name="entityMetadata">Метаданные сущности (не может быть NULL)</param>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <param name="oldPropertyMetadata">Предыдущие метаданные свойства (не может быть NULL)</param>
    /// <returns>True, если есть изменения</returns>
    bool ApplyDbChanges(
      IDbModelUpdater updater,
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata,
      EntityPropertyMetadata oldPropertyMetadata);
  }
}
