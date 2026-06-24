// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Cryptography.IHmacService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Security.Cryptography
{
  /// <summary>Сервис для подписи сообщений по стандарту HMAC</summary>
  public interface IHmacService
  {
    /// <summary>Нормализация запроса для подписания</summary>
    /// <param name="verb">Метод (GET, POST ...)</param>
    /// <param name="headers">Словарь заголовков</param>
    /// <param name="contentType">Content-Type</param>
    /// <param name="resourceUri">Адрес ресурса</param>
    /// <param name="queryUri">Параметры запроса</param>
    /// <param name="requestBody">Тело запроса (для вычисления хеша)</param>
    /// <returns>Нормализованное сообщение для подписания/проверки подписи</returns>
    string GetNormalizedMessage(
      string verb,
      string resourceUri,
      string queryUri,
      Dictionary<string, string> headers,
      string contentType,
      byte[] requestBody);

    /// <summary>Подписание сообщения HMAC</summary>
    /// <param name="message">Сообщение</param>
    /// <param name="secret">Секрет</param>
    /// <returns>Подпись</returns>
    string Sign(string message, byte[] secret);

    /// <summary>Подписание сообщения HMAC</summary>
    /// <param name="message">Сообщение</param>
    /// <param name="secret">Секрет</param>
    /// <returns>Подпись</returns>
    byte[] Sign(byte[] message, byte[] secret);

    /// <summary>Проверка подписи</summary>
    /// <param name="message">Сообщение</param>
    /// <param name="secret">Секрет</param>
    /// <param name="signature">Подпись на проверку</param>
    /// <returns>Результат проверки валидности подписи</returns>
    bool CheckSignature(string message, byte[] secret, string signature);
  }
}
