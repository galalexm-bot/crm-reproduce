// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.IFormNotifier
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Web.Mvc;

namespace EleWise.ELMA.Model.Views
{
  public interface IFormNotifier
  {
    /// <summary>Отобразить информативное сообщение</summary>
    /// <param name="text"></param>
    void Information(string text);

    /// <summary>Отобразить информативное сообщение</summary>
    /// <param name="text"></param>
    void Information(MvcHtmlString text);

    /// <summary>Отобразить предупреждающее сообщение</summary>
    /// <param name="text"></param>
    void Warning(string text);

    /// <summary>Отобразить предупреждающее сообщение</summary>
    /// <param name="text"></param>
    void Warning(MvcHtmlString text);

    /// <summary>Отобразить сообщение об ошибке</summary>
    /// <param name="text"></param>
    void Error(string text);

    /// <summary>Отобразить сообщение об ошибке</summary>
    /// <param name="text"></param>
    void Error(MvcHtmlString text);
  }
}
