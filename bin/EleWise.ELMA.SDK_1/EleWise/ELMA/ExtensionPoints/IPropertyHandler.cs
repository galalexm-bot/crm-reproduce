// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IPropertyHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Интерфейс обработчика свойства</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IPropertyHandler
  {
    /// <summary>Уникальный идентификатор обработчика</summary>
    Guid Uid { get; }

    /// <summary>Имя обработчика (для текущей культуры)</summary>
    string Name { get; }

    /// <summary>Доступен ли обработчик (можно ли добавить)</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства, для которого нужно проверить доступность обработчика</param>
    /// <param name="typeUid">Uid типа данных</param>
    /// <param name="subTypeUid">Uid подтипа данных</param>
    /// <param name="currentHandlers">Список текущих обработчиков</param>
    /// <returns>True, если доступен</returns>
    bool IsAvailableFor(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      Guid typeUid,
      Guid subTypeUid,
      IEnumerable<PropertyHandlerInfo> currentHandlers);
  }
}
