// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.IModuleContainerEvents
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Modules
{
  /// <summary>События контейнера модулей</summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-793.html">Пример реализации в базе знаний</see>
  /// <see href="http://www.elma-bpm.ru/kb/article-787.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IModuleContainerEvents
  {
    /// <summary>
    /// Контейнер активирован (все модули, точки расширения загружены).
    /// Вызывается после выполнения активации контейнера.
    /// Контейнер активируется:
    /// 1) при запуске приложения
    /// 2) при пересоздании контейнера (это происходит при включении/отключении модуля)
    /// </summary>
    void Activated();

    /// <summary>
    /// Контейнер уничтожается (вызывается при перезагрузке модулей)
    /// </summary>
    void Terminating();
  }
}
