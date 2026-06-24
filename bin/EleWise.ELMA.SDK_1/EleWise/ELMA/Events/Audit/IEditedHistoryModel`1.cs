// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.IEditedHistoryModel`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using System.Collections.Generic;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>
  /// Модель отображения истории работы с объектом для действия "Изменение"
  /// </summary>
  /// <remarks>
  /// В данном случае не применяется к базовому действию <see cref="F:EleWise.ELMA.Model.Actions.DefaultEntityActions.Update" />,
  /// для использования нужно добавлять в сущность собственное действие "Изменение" (Edit)
  /// </remarks>
  /// <typeparam name="TEntity">Тип сущности</typeparam>
  public interface IEditedHistoryModel<TEntity> : IHistoryBaseModel where TEntity : class, IEntity
  {
    /// <summary>Сущность до изменения</summary>
    TEntity OldEntity { get; set; }

    /// <summary>Сущность после изменения</summary>
    TEntity NewEntity { get; set; }

    /// <summary>Список метаданных измененных свойств</summary>
    IList<PropertyMetadata> ChangedProperties { get; set; }
  }
}
