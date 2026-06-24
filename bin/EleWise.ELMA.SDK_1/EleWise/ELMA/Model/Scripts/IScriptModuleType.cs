// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.IScriptModuleType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Тип модуля сценариев</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IScriptModuleType
  {
    /// <summary>Уникальный идентификатор типа</summary>
    Guid Uid { get; }

    /// <summary>Имя типа модуля</summary>
    string Name { get; }

    /// <summary>
    /// Сгенерировать начальный исходный код для модуля сценариев
    /// </summary>
    /// <param name="parameters">Параметры</param>
    /// <returns>Исходный код</returns>
    string GenerateSourceCode(object parameters);

    /// <summary>Скомпилировать модуль</summary>
    /// <param name="module">Модуль сценариев</param>
    /// <returns>Результаты компиляции</returns>
    ScriptCompileResult Compile(ScriptModule module);
  }
}
