// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Hubs.IGroupManagerWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Threading.Tasks;

namespace EleWise.ELMA.Hubs
{
  /// <summary>Интерфейс менеджера управления группами хаба</summary>
  public interface IGroupManagerWrapper
  {
    /// <summary>Добавить соединение в указанную группу</summary>
    /// <param name="connectionId">Идентификатор соединения для добавления в группу</param>
    /// <param name="groupName">Имя группы</param>
    /// <returns>Задача, которая представляет идентификатор соединения, добавляемого в группу</returns>
    Task Add(string connectionId, string groupName);

    /// <summary>Удалить соединение из указанной группы</summary>
    /// <param name="connectionId">Идентификатор соединения для удаления из группы</param>
    /// <param name="groupName">Имя группы</param>
    /// <returns>Задача, которая представляет идентификатор соединения, удаляемого из группы</returns>
    Task Remove(string connectionId, string groupName);
  }
}
