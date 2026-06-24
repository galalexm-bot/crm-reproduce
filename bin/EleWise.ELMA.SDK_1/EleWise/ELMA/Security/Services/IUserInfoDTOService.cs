// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IUserInfoDTOService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Сервис для получения информации о пользователях при работе через Remoting
  /// </summary>
  public interface IUserInfoDTOService : IConfigurationService
  {
    /// <summary>Получить полное имя пользователя</summary>
    /// <param name="id">Идентификатор пользователя</param>
    /// <returns></returns>
    string GetFullName(long id);
  }
}
