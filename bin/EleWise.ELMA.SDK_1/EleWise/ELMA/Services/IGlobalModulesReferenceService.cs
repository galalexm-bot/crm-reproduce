// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IGlobalModulesReferenceService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Services
{
  /// <summary>Сервис для добавления ссылки на глобальный модуль</summary>
  internal interface IGlobalModulesReferenceService
  {
    /// <summary>
    /// Создать файл сборки для глобального модуля.
    /// Если файл существует - он не будет перезаписан.
    /// </summary>
    /// <param name="globalModuleHeaderUid">Идентификатор заголовка глобального модуля</param>
    /// <returns>Путь до файла со сборкой, или null, если файл не удалось создать</returns>
    string CreateGlobalModuleAssembly(Guid globalModuleHeaderUid);

    /// <summary>
    /// Получить путь к последней опубликованной версии глобального модуля
    /// </summary>
    /// <param name="globalModuleHeaderUid">Идентификатор заголовка глобального модуля</param>
    /// <returns>Путь к последней опубликованной версии глобального модуля</returns>
    string GetGlobalModuleAssemblyPath(Guid globalModuleHeaderUid);
  }
}
