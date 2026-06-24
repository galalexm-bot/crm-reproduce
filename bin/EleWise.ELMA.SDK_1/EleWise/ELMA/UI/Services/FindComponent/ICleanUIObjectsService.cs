// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.FindComponent.ICleanUIObjectsService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.UI.Services.FindComponent.Models;

namespace EleWise.ELMA.UI.Services.FindComponent
{
  /// <summary>Сервис очистки объектов КИ</summary>
  public interface ICleanUIObjectsService
  {
    /// <summary>Очистить</summary>
    /// <param name="model">Модель очистки данных КИ</param>
    /// <returns>Модель очистки данных КИ</returns>
    void Clean(ICleanUIObjectsModel model);
  }
}
