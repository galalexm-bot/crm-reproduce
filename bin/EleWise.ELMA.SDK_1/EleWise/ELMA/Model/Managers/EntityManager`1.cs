// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.EntityManager`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>
  /// Класс для получения типизированного менеджера сущности
  /// </summary>
  /// <typeparam name="T">Тип сущности</typeparam>
  public static class EntityManager<T> where T : IEntity
  {
    /// <summary>Получить экземпляр менеджера</summary>
    public static IEntityManager<T> Instance => Locator.GetServiceNotNull<IEntityManager<T>>();

    /// <summary>Создать сущность указанного типа</summary>
    /// <returns>Тип класса или интерфейса сущности</returns>
    public static T Create() => EntityManager<T>.Instance.Create();
  }
}
