// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.IFormViewModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Results;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Интерфейс модели формы</summary>
  public interface IFormViewModel
  {
    /// <summary>Заголовок страницы</summary>
    string Header { get; }

    /// <summary>Контекст</summary>
    IEntity Context { get; set; }

    /// <summary>Представление</summary>
    FormViewItem View { get; set; }

    /// <summary>Дескриптор содержимого страницы</summary>
    IFormPartDescriptor Descriptor { get; }

    /// <summary>Результат выполнения</summary>
    FormResult Result { get; }
  }
}
