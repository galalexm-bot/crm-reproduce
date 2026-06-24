// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IConfigurationScriptsErrorService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.ComponentModel;

namespace EleWise.ELMA.Services
{
  /// <summary>Сервис информации об ошибках скриптов конфигурации</summary>
  [EditorBrowsable(EditorBrowsableState.Never)]
  public interface IConfigurationScriptsErrorService
  {
    /// <summary>Проверить код для продолжения запуска</summary>
    /// <param name="code">Код для продолжения запуска</param>
    /// <returns><see langword="true" />, если <paramref name="code" /> верный</returns>
    /// <remarks>При вызове метода с правильным кодом текущая сессия запоминается для проверки в методе <see cref="M:EleWise.ELMA.Services.IConfigurationScriptsErrorService.IsValidCurrent" /></remarks>
    bool Validate(string code);

    /// <summary>
    /// Получить абсолютный путь до файла на сервере с кодом для продолжения
    /// </summary>
    string GetFileAbsolutePath();

    /// <summary>Получить строковое представление ошибок</summary>
    /// <returns></returns>
    string GetErrors();

    /// <summary>
    /// Проверить возможность продолжения работы в текущей сессии
    /// </summary>
    bool IsValidCurrent();
  }
}
