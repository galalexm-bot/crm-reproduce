// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IPasswordResolver
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Как считать пароль</summary>
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  public interface IPasswordResolver
  {
    /// <summary>Уникальный идентификатор</summary>
    Guid Uid { get; }

    /// <summary>Название типа пароля</summary>
    string DisplayName { get; }

    /// <summary>Сгенерировать соль для шифрования (хеширования)</summary>
    /// <returns></returns>
    string GenerateSalt();

    /// <summary>Зашифровать</summary>
    /// <param name="password">Пароль</param>
    /// <param name="salt">Соль</param>
    /// <returns></returns>
    string Encrypt(string password, string salt);

    /// <summary>Рашифровать пароль</summary>
    /// <param name="password">Пароль</param>
    /// <param name="salt">Соль</param>
    /// <returns></returns>
    string Decrypt(string password, string salt);

    /// <summary>Проверка зашифрованного пароля</summary>
    /// <param name="encryptedPassword">Зашифрованный пароль</param>
    /// <param name="salt">Соль</param>
    /// <param name="password">Пароль для сравнения</param>
    /// <returns></returns>
    bool Check(string encryptedPassword, string salt, string password);
  }
}
