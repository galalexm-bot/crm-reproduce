// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.IModule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Modules
{
  /// <summary>Модуль приложения</summary>
  public interface IModule : ICompositeApplicationUnit, IApplicationUnit
  {
    /// <summary>Тип модуля</summary>
    ModuleType ModuleType { get; }

    /// <summary>Веб-сайт</summary>
    string WebSite { get; }

    /// <summary>Описание в виде HTML-разметки</summary>
    string HtmlDescription { get; }

    /// <summary>
    /// Требуется ли, чтобы данный модуль был доступен на сервере
    /// </summary>
    bool ServerModuleRequired { get; }

    /// <summary>
    /// Получить список сборок, которые составляют данный модуль
    /// </summary>
    IEnumerable<IModuleAssembly> Assemblies { get; }

    /// <summary>Получить список модулей, расширяющих данный модуль</summary>
    IEnumerable<IModule> ExtensionModules { get; }

    /// <summary>Статус модуля</summary>
    ModuleStatus Status { get; }

    /// <summary>Причина отключения модуля</summary>
    ModuleDisabledReason DisabledReason { get; }
  }
}
