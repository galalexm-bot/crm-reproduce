// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.IModuleEvents
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Modules
{
  /// <summary>События модулей</summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-787.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IModuleEvents
  {
    /// <summary>Установка модуля</summary>
    /// <param name="module">Веб-часть модуля приложения</param>
    void Installing(IWebModuleUnit module);

    /// <summary>Модуль установлен</summary>
    /// <param name="module">Веб-часть модуля приложения</param>
    void Installed(IWebModuleUnit module);

    /// <summary>Включение модуля</summary>
    /// <param name="module">Веб-часть модуля приложения</param>
    void Enabling(IWebModuleUnit module);

    /// <summary>Модуль включен</summary>
    /// <param name="module">Веб-часть модуля приложения</param>
    void Enabled(IWebModuleUnit module);

    /// <summary>Отключение модуля</summary>
    /// <param name="module">Веб-часть модуля приложения</param>
    void Disabling(IWebModuleUnit module);

    /// <summary>Модуль отключен</summary>
    /// <param name="module">Веб-часть модуля приложения</param>
    void Disabled(IWebModuleUnit module);

    /// <summary>Деинсталляция модуля</summary>
    /// <param name="module">Веб-часть модуля приложения</param>
    void Uninstalling(IWebModuleUnit module);

    /// <summary>Модуль деинсталлирован</summary>
    /// <param name="module">Веб-часть модуля приложения</param>
    void Uninstalled(IWebModuleUnit module);
  }
}
