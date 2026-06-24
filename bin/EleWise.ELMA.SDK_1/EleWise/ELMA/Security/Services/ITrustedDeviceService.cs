// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.ITrustedDeviceService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Security.Services
{
  /// <summary>Сервис доверенных устройств</summary>
  /// <remarks>
  /// Сам управляющий сервис должен реализовывать управление доверенными устройствами.
  /// </remarks>
  public interface ITrustedDeviceService
  {
    /// <summary>
    /// Добавить доверенное устройство для текущего авторизованного пользователя
    /// </summary>
    /// <param name="deviceInfo">Информация идентифицирующая устройство, она не должна меняться со временем</param>
    /// <param name="deviceName">Имя, которым назвать это устройство</param>
    /// <returns>Токен добавленного доверенного устройства, который нужен в дальнейшем для проверки</returns>
    string AddDevice(string deviceInfo, string deviceName);

    /// <summary>Проверить доверенное устройство</summary>
    /// <param name="deviceToken">Токен устройства</param>
    /// <param name="deviceInfo">Информация идентифицирующая устройство</param>
    /// <param name="user">Пользователь, для которого осуществляется проверка</param>
    /// <returns><c>true</c>, если устройство прошло проверку</returns>
    bool CheckDevice(string deviceToken, string deviceInfo, IUser user);
  }
}
