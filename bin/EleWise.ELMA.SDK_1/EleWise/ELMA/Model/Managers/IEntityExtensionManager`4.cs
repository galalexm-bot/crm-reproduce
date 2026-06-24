// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.IEntityExtensionManager`4
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>Менеджер сущности-расширения</summary>
  /// <typeparam name="TBase">Тип основной сущности</typeparam>
  /// <typeparam name="T">Тип сущности-расширения</typeparam>
  /// <typeparam name="IdT">Тип идентификатора</typeparam>
  /// <typeparam name="TBaseManager">Тип менеджера основной сущности</typeparam>
  public interface IEntityExtensionManager<TBase, T, IdT, TBaseManager> : 
    IEntityExtensionManager<TBase, T, IdT>,
    IEntityManager<T, IdT>,
    IEntityManager<T>,
    IEntityManager,
    IEntityExtensionManager
    where TBase : class, IEntity<IdT>
    where T : class, TBase
    where TBaseManager : class, IEntityManager<TBase, IdT>
  {
    /// <summary>Базовый менеджер</summary>
    TBaseManager Manager { get; }
  }
}
