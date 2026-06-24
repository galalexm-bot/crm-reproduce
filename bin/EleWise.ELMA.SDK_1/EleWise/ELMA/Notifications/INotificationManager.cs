// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.INotificationManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Security;

namespace EleWise.ELMA.Notifications
{
  /// <summary>Менеджер оповещений</summary>
  public interface INotificationManager
  {
    /// <summary>Отправить оповещение</summary>
    /// <param name="notification">Оповещение</param>
    void Send(INotification notification);

    /// <summary>
    /// Добавить пользователя в "игнор-лист". Т.е. ему не будут отправляться оповещения.
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <returns>True, если пользователь успешно добавлен. False - если он уже был добавлен до этого.</returns>
    bool AddUserToIgnoreList(IUser user);

    /// <summary>Удалить пользователя из "игнор-листа".</summary>
    /// <param name="user">Пользователь</param>
    /// <returns></returns>
    void RemoveUserFromIgnoreList(IUser user);

    /// <summary>
    /// Добавить пользователя в список для принудительной отправки. Ему будут отправляться оповещения, даже если он является автором.
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <returns>True, если пользователь успешно добавлен. False - если он уже был добавлен до этого.</returns>
    bool AddUserToForceSendList(IUser user);

    /// <summary>
    /// Удалить пользователя из списка для принудительной отправки.
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <returns></returns>
    void RemoveUserFromForceSendList(IUser user);
  }
}
