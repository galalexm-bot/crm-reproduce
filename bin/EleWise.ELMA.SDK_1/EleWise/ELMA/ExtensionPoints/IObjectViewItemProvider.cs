// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IObjectViewItemProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using System;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>
  /// Провайдер для получения информации о представлении, используемом в Object.cshtml
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
  public interface IObjectViewItemProvider
  {
    /// <summary>Уникальный идентификатор провайдера</summary>
    Guid ProviderUid { get; }

    /// <summary>Получить представление</summary>
    /// <param name="viewItemId">Идентификатор представления</param>
    /// <returns>Представление или null</returns>
    ViewItem GetViewItem(string viewItemId);
  }
}
