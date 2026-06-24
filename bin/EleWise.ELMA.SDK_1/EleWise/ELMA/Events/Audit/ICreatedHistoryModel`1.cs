// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.ICreatedHistoryModel`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>
  /// Модель отображения истории работы с объектом для действия "Создание"
  /// </summary>
  /// <typeparam name="TEntity">Тип сущности</typeparam>
  public interface ICreatedHistoryModel<TEntity> : IHistoryBaseModel where TEntity : class, IEntity
  {
    /// <summary>Созданная сущность</summary>
    TEntity Entity { get; set; }
  }
}
