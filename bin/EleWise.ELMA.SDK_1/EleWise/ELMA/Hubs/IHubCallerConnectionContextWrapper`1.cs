// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Hubs.IHubCallerConnectionContextWrapper`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Hubs
{
  /// <summary>
  /// Инкапсулирует всю информацию об отдельном соединении для <see cref="T:EleWise.ELMA.Hubs.IHub" />.
  /// </summary>
  public interface IHubCallerConnectionContextWrapper<T> : IHubConnectionContextWrapper<T>
  {
    /// <summary>Получить клиента, который вызвал метод хаба</summary>
    T Caller { get; }

    /// <summary>Получить состояние клиента, который вызвал метод хаба</summary>
    object CallerState { get; }

    /// <summary>
    /// Получить всех пользователей, исключая клиента, который вызвал метод хаба
    /// </summary>
    T Others { get; }

    /// <summary>
    /// Получить всех пользователей из группы, исключая клиента, который вызвал метод хаба
    /// </summary>
    /// <param name="groupName"></param>
    /// <returns></returns>
    T OthersInGroup(string groupName);

    /// <summary>
    /// Получить всех пользователей из групп, исключая клиента, который вызвал метод хаба
    /// </summary>
    /// <param name="groupNames"></param>
    /// <returns></returns>
    T OthersInGroups(IList<string> groupNames);
  }
}
