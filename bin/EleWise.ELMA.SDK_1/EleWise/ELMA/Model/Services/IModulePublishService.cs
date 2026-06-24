// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.IModulePublishService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>Сервис для публикации модуля единой сущностью</summary>
  public interface IModulePublishService
  {
    /// <summary>Публикация модуля</summary>
    /// <param name="headerUid">Заголовок модуля</param>
    /// <param name="comment">Комментарий</param>
    void Publish(Guid headerUid, string comment);
  }
}
