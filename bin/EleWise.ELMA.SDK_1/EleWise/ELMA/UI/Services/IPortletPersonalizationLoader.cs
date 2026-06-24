// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.IPortletPersonalizationLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.UI.Models;
using System;

namespace EleWise.ELMA.UI.Services
{
  /// <summary>Интерфейс сервиса загрузки настроек портлета</summary>
  public interface IPortletPersonalizationLoader
  {
    /// <summary>Загрузить настройки портлета</summary>
    IPortletPersonalization Load(
      int portletManagerScope,
      string portletManagerPath,
      Guid portletId,
      Guid instanceId,
      string path);
  }
}
