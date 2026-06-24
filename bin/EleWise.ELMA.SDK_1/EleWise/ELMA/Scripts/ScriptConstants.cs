// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.ScriptConstants
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Scripts
{
  /// <summary>Константы генерации кода скриптов</summary>
  public static class ScriptConstants
  {
    /// <summary>Префикс интерфейса</summary>
    public const string InterfacePrefix = "I";
    /// <summary>Суффикс для автогенерируемых файлов</summary>
    public const string AutoGen = "designer";
    /// <summary>Контекст</summary>
    public const string Context = "Context";
    /// <summary>Переменная контекста</summary>
    public const string ContextVariable = "context";
    /// <summary>Контроллер</summary>
    public const string Controller = "Controller";
    /// <summary>Сервер</summary>
    public const string Server = "Server";
    /// <summary>Интерфейс сервера</summary>
    public const string ServerInterface = "IServer";
    /// <summary>Серверный контроллер</summary>
    public const string ServerController = "ServerController";
    /// <summary>Интерфейс серверного контроллера</summary>
    public const string ServerControllerInterface = "IServerController";
    /// <summary>Модель отображения</summary>
    public const string ViewModel = "ViewModel";
    /// <summary>Контроллер модели отображения</summary>
    public const string ViewModelController = "ViewModelController";
    /// <summary>Тест</summary>
    public const string Test = "Test";
    /// <summary>Компонент тестов</summary>
    public const string ComponentTests = "ComponentTests";
    /// <summary>Контроллер компонента</summary>
    public const string ComponentController = "ComponentController";
    /// <summary>Интерфейс контроллера компонента</summary>
    public const string IComponentController = "IComponentController";
    /// <summary>Скрипты</summary>
    public const string Scripts = "Scripts";
    /// <summary>Персонализация (настройки портлета)</summary>
    public const string Personalization = "Personalization";
    /// <summary>Настройки</summary>
    public const string Settings = "Settings";
    /// <summary>Переменная настроек</summary>
    public const string SettingsVariable = "settings";
    /// <summary>Константа для поля formResult</summary>
    /// <remarks>
    /// Используется в механике серверного обновления формы для
    /// новых страниц и портлетов
    /// </remarks>
    internal const string FormResultVariable = "formResult";

    /// <summary>Константы с пространствами имён</summary>
    public static class Usings
    {
      /// <summary>Пространство имён "System"</summary>
      public const string System = "System";
      /// <summary>Пространство имён "System.Collections.Generic"</summary>
      public const string SystemCollectionsGeneric = "System.Collections.Generic";
      /// <summary>Пространство имён "System.Linq"</summary>
      public const string SystemLinq = "System.Linq";
      /// <summary>Пространство имён "System.Text"</summary>
      public const string SystemText = "System.Text";
      /// <summary>Пространство имён "System.Threading.Tasks"</summary>
      public const string SystemThreadingTasks = "System.Threading.Tasks";
      /// <summary>Пространство имён "Bridge"</summary>
      public const string Bridge = "Bridge";
      /// <summary>Пространство имён "EleWise.ELMA.Core.Controllers"</summary>
      public const string EleWiseELMACoreControllers = "EleWise.ELMA.Core.Controllers";
      /// <summary>Пространство имён "EleWise.ELMA.Core.Services"</summary>
      public const string EleWiseELMACoreServices = "EleWise.ELMA.Core.Services";
      /// <summary>Пространство имён "EleWise.ELMA.Model.Validation"</summary>
      public const string EleWiseELMAModelValidation = "EleWise.ELMA.Model.Validation";
      /// <summary>Пространство имён "EleWise.ELMA.Model.ViewModel"</summary>
      public const string EleWiseELMAModelViewModel = "EleWise.ELMA.Model.ViewModel";
      /// <summary>Пространство имён "EleWise.ELMA.TestFramework"</summary>
      public const string EleWiseELMATestFramework = "EleWise.ELMA.TestFramework";
      /// <summary>Пространство имён "EleWise.ELMA.TestFramework.API"</summary>
      public const string EleWiseELMATestFrameworkAPI = "EleWise.ELMA.TestFramework.API";
      /// <summary>Пространство имен "EleWise.ELMA.Core"</summary>
      public const string EleWiseELMACore = "EleWise.ELMA.Core";
      /// <summary>Пространство имен "EleWise.ELMA.Core.ComponentModel"</summary>
      public const string EleWiseELMACoreComponentModel = "EleWise.ELMA.Core.ComponentModel";
      /// <summary>Пространство имен "EleWise.ELMA.Model.Views"</summary>
      public const string EleWiseELMAModelViews = "EleWise.ELMA.Model.Views";
      /// <summary>Пространство имен "EleWise.ELMA.API"</summary>
      public const string EleWiseELMAApi = "EleWise.ELMA.API";
      /// <summary>Пространство имен "EleWise.ELMA.Model.Common"</summary>
      public const string EleWiseELMAModelCommon = "EleWise.ELMA.Model.Common";
      /// <summary>Пространство имен "EleWise.ELMA.Model.Entities"</summary>
      public const string EleWiseELMAModelEntities = "EleWise.ELMA.Model.Entities";
      /// <summary>Пространство имен "EleWise.ELMA.Model.Managers"</summary>
      public const string EleWiseELMAModelManagers = "EleWise.ELMA.Model.Managers";
      /// <summary>Пространство имен "EleWise.ELMA.Model.Types.Settings"</summary>
      public const string EleWiseELMAModelTypesSettings = "EleWise.ELMA.Model.Types.Settings";
      /// <summary>Пространство имен "EleWise.ELMA.DataClasses"</summary>
      public const string EleWiseELMADataClasses = "EleWise.ELMA.DataClasses";
      /// <summary>Пространство имен "EleWise.ELMA.Extensions"</summary>
      public const string EleWiseELMAExtensions = "EleWise.ELMA.Extensions";
      /// <summary>Пространство имен "EleWise.ELMA.Model.Scripts"</summary>
      public const string EleWiseELMAModelScripts = "EleWise.ELMA.Model.Scripts";
      /// <summary>Пространство имен "Bridge.React"</summary>
      public const string BridgeReact = "Bridge.React";
      /// <summary>Пространство имен "EleWise.ELMA.Core.React.Models"</summary>
      public const string EleWiseELMACoreReactModels = "EleWise.ELMA.Core.React.Models";
    }
  }
}
