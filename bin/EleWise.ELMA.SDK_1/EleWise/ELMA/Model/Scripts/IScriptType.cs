// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.IScriptType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Интерфейс типа сценария</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IScriptType
  {
    /// <summary>Уникальный идентификатор типа сценария</summary>
    Guid Uid { get; }

    /// <summary>Отображаемое имя</summary>
    string Name { get; }

    /// <summary>
    /// Перечисляются полные имена сборок ELMA которые нужно добавить в референсы при подключении скрипта
    /// </summary>
    string ListReferenceAdd { get; }

    /// <summary>Сгенерировать определение метода</summary>
    /// <param name="name">Имя метода</param>
    /// <param name="generationParams">Дополнительные параметры генерации</param>
    /// <returns>Определение метода</returns>
    ScriptMethodDeclaration GenerateMethod(
      string name,
      IDictionary<string, object> generationParams = null);
  }
}
