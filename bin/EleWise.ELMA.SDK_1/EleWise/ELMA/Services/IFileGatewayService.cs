// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IFileGatewayService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Security;

namespace EleWise.ELMA.Services
{
  /// <summary>Интерфейс службы файловых шлюзов.</summary>
  public interface IFileGatewayService
  {
    /// <summary>Ближайший к серверу ELMA файловый шлюз.</summary>
    string SystemGateway { get; }

    /// <summary>Все имена файловых шлюзов.</summary>
    string[] AllGateways { get; }

    /// <summary>Получить ближайший к пользователю файловый шлюз.</summary>
    /// <returns>Уникальное идентификатор файлового шлюза.</returns>
    string GetClosestGateway();

    /// <summary>
    /// Получить точку хранения, к которой прикреплён данный пользователь.
    /// </summary>
    /// <param name="user">Пользователь.</param>
    /// <returns>
    /// Идентификатор закреплённой за пользователем точки хранения (индивидуальное сопоставление), либо null, если сопоставление отсутствует.
    /// </returns>
    string GetUserGateway(IUser user);

    /// <summary>
    /// Указать точку хранения, к которому будет прикреплён пользователь.
    /// </summary>
    /// <param name="user">Пользователь.</param>
    /// <param name="gateway">Уникальное имя шлюза.</param>
    void SetUserGateway(IUser user, string gateway);
  }
}
