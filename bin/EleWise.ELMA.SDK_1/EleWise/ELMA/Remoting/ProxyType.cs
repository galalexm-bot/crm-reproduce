// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Remoting.ProxyType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Remoting
{
  /// <summary>Тип использования прокси-сервера</summary>
  public enum ProxyType
  {
    /// <summary>Не использовать</summary>
    [DisplayName(typeof (__Resources_ProxyType), "P_NotUse_DisplayName")] NotUse,
    /// <summary>
    /// Использовать настройки прокси по умолчанию (Internet Explorer)
    /// </summary>
    [DisplayName(typeof (__Resources_ProxyType), "P_UseDefault_DisplayName")] UseDefault,
    /// <summary>Настроить вручную</summary>
    [DisplayName(typeof (__Resources_ProxyType), "P_Custom_DisplayName")] Custom,
  }
}
