// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.UserDefinedList.IUserDefinedListExecutionHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.UserDefinedList
{
  /// <summary>
  /// Точка расширения для получения пользовательского спика
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IUserDefinedListExecutionHandler
  {
    /// <summary>Получить пользовательский список</summary>
    /// <param name="modelSubTypeUid">Подтип модуля</param>
    /// <param name="userDefinedListUid">уид списка</param>
    /// <returns>Пользовательский список</returns>
    IEnumerable<object> ExecuteGetUserDefinedList(Guid modelSubTypeUid, Guid userDefinedListUid);
  }
}
