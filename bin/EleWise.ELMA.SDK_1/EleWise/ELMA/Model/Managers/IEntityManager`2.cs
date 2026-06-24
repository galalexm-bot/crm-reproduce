// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.IEntityManager`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>
  /// Типизированный интерфейс менеджера сущности с идентификатором
  /// </summary>
  /// <typeparam name="T">Тип класса сущности</typeparam>
  /// <typeparam name="IdT">Тип идентификатора сущности</typeparam>
  public interface IEntityManager<T, in IdT> : IEntityManager<T>, IEntityManager where T : IEntity<IdT>
  {
    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - вызывается исключение
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns></returns>
    [NotNull]
    T Load(IdT id);

    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - возвращается null
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns></returns>
    [CanBeNull]
    T LoadOrNull(IdT id);

    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - возвращается новая сущность
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns>Сущность</returns>
    [NotNull]
    T LoadOrCreate(IdT id);

    /// <summary>Найти все сущности по идентификаторам из массива</summary>
    /// <param name="idArray">Массив идентификаторов</param>
    /// <returns>Список сущностей</returns>
    ICollection<T> FindByIdArray(IdT[] idArray);
  }
}
