// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.ILicensedUnit
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Licensing;
using System;

namespace EleWise.ELMA.Modules
{
  /// <summary>Лицензируемая часть приложения</summary>
  public interface ILicensedUnit
  {
    /// <summary>
    /// Уникальный идентификатор метода получения регистрационного ключа (чтобы объединять регистрационные ключи частей приложения)
    /// </summary>
    Guid RegistrationKeyMethodUid { get; }

    /// <summary>Получить регистрационный ключ</summary>
    /// <returns>Регистрационный ключ</returns>
    string GetRegistrationKey();

    /// <summary>Применить ключ активации</summary>
    /// <param name="key">Ключ активации</param>
    void ApplyActivationKey(string key);

    /// <summary>Завершить инициализацию лицензирования</summary>
    void CompleteLicensingInitialize();

    /// <summary>Получить информацию о лицензиях</summary>
    /// <returns>Информация о лицензиях</returns>
    ILicenseInfo GetLicenseInfo();

    /// <summary>Обновить информацию о лицензиях</summary>
    void UpdateLicenseInfo();

    /// <summary>Получить токен активации модуля</summary>
    /// <returns></returns>
    byte[] GetActivationToken();
  }
}
