// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IHttpContextAccessor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using System.Web;

namespace EleWise.ELMA.Services
{
  /// <summary>
  /// Интерфейс компонента для получения текущего контекста <see cref="T:System.Web.HttpContextBase" />
  /// </summary>
  [DeveloperApi(DeveloperApiType.Service)]
  public interface IHttpContextAccessor
  {
    /// <summary>
    /// Получить текущий контекст запроса
    /// Для работы с <see cref="P:System.Web.HttpContextBase.Items" /> используйте <see cref="T:EleWise.ELMA.Services.ContextVars" />
    /// </summary>
    /// <returns>Текущий контекст запроса, или <c>null</c> если запроса нет</returns>
    HttpContextBase Current();
  }
}
