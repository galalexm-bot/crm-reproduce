// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.Services.IUserDefinedListService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.UI.Metadata;
using System.Collections.Generic;

namespace EleWise.ELMA.UI.Scripts.Services
{
  /// <summary>Сервис для подготовки пользовательских списков</summary>
  public interface IUserDefinedListService
  {
    /// <summary>Получить пользовательский список</summary>
    /// <param name="userDefinedListInfo">Информация о списке, которые нужно подготовить</param>
    IEnumerable<object> GetUserDefinedList(UserDefinedListInfo userDefinedListInfo);
  }
}
