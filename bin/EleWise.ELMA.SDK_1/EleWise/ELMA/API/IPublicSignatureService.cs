// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.IPublicSignatureService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API.Models;
using EleWise.ELMA.Security.Cryptography;

namespace EleWise.ELMA.API
{
  /// <summary>Сервис для работы с подписью запросов Public API</summary>
  public interface IPublicSignatureService
  {
    /// <summary>Проверка подписи запроса</summary>
    /// <param name="session">Сессия</param>
    /// <returns>Результат проверки</returns>
    bool CheckRequestSignature(IPublicClientSession session);

    /// <summary>
    /// Первичное согласование информации для подписи при создание сессии
    /// </summary>
    /// <returns>Ключевая пара</returns>
    IEcdhKey ProcessAuthInfo();
  }
}
