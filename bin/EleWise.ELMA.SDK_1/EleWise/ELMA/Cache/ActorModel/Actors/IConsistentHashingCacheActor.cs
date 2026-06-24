// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.ActorModel.Actors.IConsistentHashingCacheActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.Cache.ActorModel.Actors
{
  /// <summary>
  /// Актор для представления определенного узла распределенного кэша.
  /// </summary>
  internal interface IConsistentHashingCacheActor : IServerPlacementActor, IActorWithGuidKey, IActor
  {
    /// <summary>Записывает элемент в кэш.</summary>
    /// <param name="key">Ключ.</param>
    /// <param name="region">Регион.</param>
    /// <param name="value">Значение.</param>
    /// <param name="duration">Продолжительность хранения.</param>
    /// <param name="replica">Является ли запись резервной копией.</param>
    /// <returns>Задача.</returns>
    Task Set(string key, string region, byte[] value, TimeSpan duration, bool replica = false);

    Task Accept(
      (string key, string region, byte[] value, TimeSpan duration)[] entries,
      bool replica = false);

    /// <summary>Определяет есть ли запись с указанным ключом.</summary>
    /// <param name="key">Ключ записи.</param>
    /// <param name="region">Регион записи.</param>
    /// <returns>Задача с результатом поиска.</returns>
    Task<bool> Contains(string key, string region);

    /// <summary>Возвращает запись по указанному ключу.</summary>
    /// <param name="key">Ключ записи.</param>
    /// <param name="region">Регион записи.</param>
    /// <returns>Задача с результатом поиска.</returns>
    Task<CacheResult> Get(string key, string region);

    /// <summary>Удаляет запись по указанному ключу.</summary>
    /// <param name="key">&gt;Ключ записи.</param>
    /// <param name="region">Регион записи.</param>
    /// <param name="replica">Определяет удаляется резервная копия или же оригинал записи.</param>
    /// <returns>Задача.</returns>
    Task Remove(string key, string region, bool replica = false);

    /// <summary>Удаляет все записи, принадлежащие указанному региону.</summary>
    /// <param name="region">Регион ключей.</param>
    /// <param name="forward">Определяет следует ли перенаправлять запрос остальным узлам.</param>
    /// <returns>Задача.</returns>
    Task ClearRegion(string region, bool forward = true);

    /// <summary>Обновляет таблицу узлов.</summary>
    /// <param name="node">Узел.</param>
    /// <param name="added">Если <c>true</c>, то узел был добавлен в кластер, иначе удален.</param>
    /// <returns>Задача.</returns>
    Task UpdateMembershipTable(string node, bool added);
  }
}
