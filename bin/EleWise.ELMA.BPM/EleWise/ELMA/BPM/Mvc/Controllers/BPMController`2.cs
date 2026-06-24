// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPM.Mvc.Controllers.BPMController`2
// Assembly: EleWise.ELMA.BPM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EE1B80B5-F464-4FFF-85CF-6A69B66F676D
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Controllers;
using j3AmrhgkCleVTGdEwA;
using Orchard.Themes;

namespace EleWise.ELMA.BPM.Mvc.Controllers
{
  /// <summary>
  /// Базовый контроллер для модулей Платформы, основанный на модели. Содержит несколько вспомогательных сервисов.
  /// </summary>
  /// <typeparam name="TModel">Тип модели</typeparam>
  /// <typeparam name="TModelId">Тип ИД модели</typeparam>
  [Themed]
  public class BPMController<TModel, TModelId> : BaseController<TModel, TModelId> where TModel : IEntity<TModelId>
  {
    internal static object c2gvDtiu6ZyGM26JRTp;

    /// <summary>
    /// Получить текущего пользователя как модель Платформы <see cref="T:EleWise.ELMA.Security.Models.IUser" />
    /// </summary>
    /// <returns>Текущий пользователь контекста или <c>null</c></returns>
    protected IUser GetCurrentUser() => this.AuthenticationService.GetCurrentUser<IUser>();

    public BPMController()
    {
      TKW1L3mlUyvXmg29jA.RWk58XigPN();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_a4a0d03145aa4a86bff873b4ae1fb8c0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool JejRw5iVlSXJWgUSMlt() => BPMController<TModel, TModelId>.c2gvDtiu6ZyGM26JRTp == null;

    internal static object vT2MCPiyJFlb4UBfO8Q() => BPMController<TModel, TModelId>.c2gvDtiu6ZyGM26JRTp;
  }
}
