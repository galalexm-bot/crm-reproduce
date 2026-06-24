// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.ILicenseManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Licensing
{
  /// <summary>Менеджер лицензирования</summary>
  public interface ILicenseManager
  {
    /// <summary>Получить регистрационный ключ основного модуля</summary>
    string GetRegistrationKey();

    /// <summary>Получить регистрационный ключ указанного модуля</summary>
    /// <param name="unit"></param>
    /// <returns></returns>
    string GetRegistrationKey(ILicensedUnit unit);

    /// <summary>
    /// Применить все зарегистрированные ключи активации ко всем модулям системы
    /// </summary>
    void ApplyAllActivationKeys();

    /// <summary>
    /// Зарегистрировать ключ активации и применить его ко всем модулям системы
    /// </summary>
    /// <param name="key">Ключ активации</param>
    /// <returns>Уникальный идентификатор ключа</returns>
    Guid AddActivationKey(string key);

    /// <summary>
    /// Зарегистрировать ключ активации и применить его ко всем модулям системы
    /// </summary>
    /// <param name="key">Ключ активации</param>
    /// <param name="newActivatedComponents">Возвращаемый список компонентов, которые дополнительно были активированы данным ключом</param>
    /// <returns>Уникальный идентификатор ключа</returns>
    Guid AddActivationKey(
      string key,
      out IEnumerable<IStoreComponentInfo> newActivatedComponents);

    /// <summary>Удалить ключ активации</summary>
    /// <param name="keyUid">Уникальный идентификатор ключа</param>
    void RemoveActivationKey(Guid keyUid);

    /// <summary>Получить зарегистрированные текущие ключи актиации</summary>
    /// <returns>Словарь "Уникальный идентификатор ключа-Ключ"</returns>
    Dictionary<Guid, string> GetActivationKeys();

    /// <summary>Можно ли добавлять ключ активации</summary>
    /// <returns></returns>
    bool CanAddActivationKey();

    /// <summary>Получить общий токен активации</summary>
    /// <returns></returns>
    string GetActivationToken();
  }
}
