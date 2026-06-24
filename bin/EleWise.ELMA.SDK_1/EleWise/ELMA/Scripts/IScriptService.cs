// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.IScriptService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Scripts.Models;
using System.Collections.Generic;

namespace EleWise.ELMA.Scripts
{
  /// <summary>Сервис скриптов</summary>
  public interface IScriptService
  {
    /// <summary>Сгенерировать код нового метода</summary>
    /// <param name="request">Запрос на генерацию кода нового метода</param>
    /// <returns>Сгенерированный код нового метода и позиция для вставки в исходный код</returns>
    GenerateMethodCodeResponse GenerateMethodCode(GenerateMethodCodeRequest request);

    /// <summary>Распарсить методы модуля сценариев</summary>
    /// <param name="request">Запрос</param>
    /// <returns>Методы модуля сценариев</returns>
    IEnumerable<ScriptMethodDeclaration> ParseMethods(ParseMethodsRequest request);

    /// <summary>Переписать имена в исходном коде</summary>
    /// <param name="sourceCode">Исходный код</param>
    /// <param name="oldName">Старое наименование метаданных</param>
    /// <param name="newName">Новое наименование метаданных</param>
    /// <returns></returns>
    string ChangeSourceClassName(string sourceCode, string oldName, string newName);

    /// <summary>Добавить интерфейс к исходному коду</summary>
    /// <param name="data">Данные</param>
    /// <returns>Сгенерированный новый исходный код</returns>
    AddInterfaceResult AddInterface(AddInterfaceData data);

    /// <summary>Проверить существует ли интерфейс</summary>
    /// <param name="info">Информация об интерфейсе</param>
    /// <returns>True если интерфейс существует</returns>
    bool InterfaceExists(InterfaceExistsInfo info);
  }
}
