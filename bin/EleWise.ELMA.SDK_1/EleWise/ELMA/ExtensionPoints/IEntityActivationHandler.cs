// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IEntityActivationHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Точка расширения для перехвата активации сущностей</summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IEntityActivationHandler
  {
    /// <summary>Вызывается после конструктора сущности</summary>
    /// <param name="entity">Сущность</param>
    void OnActivating(IEntity entity);

    /// <summary>Вызывается, когда сущность полностью подготовлена</summary>
    /// <param name="entity">Сущность</param>
    void OnActivated(IEntity entity);
  }
}
