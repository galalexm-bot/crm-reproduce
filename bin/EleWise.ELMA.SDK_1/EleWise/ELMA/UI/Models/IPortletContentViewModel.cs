// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.IPortletContentViewModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.UI.Descriptors;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Интерфейс модели страницы</summary>
  public interface IPortletContentViewModel : IFormViewModel
  {
    /// <summary>Значения настроек</summary>
    IPortletPersonalization Settings { get; }

    /// <summary>Дескриптор содержимого портлета</summary>
    PortletContentDescriptor PortletContentDescriptor { get; }
  }
}
