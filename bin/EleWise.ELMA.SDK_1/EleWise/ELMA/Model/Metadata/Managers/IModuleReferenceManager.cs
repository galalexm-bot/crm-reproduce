// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.IModuleReferenceManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Scripts;
using System;

namespace EleWise.ELMA.Model.Metadata.Managers
{
  /// <summary>Менеджер ссылки метаданных на модуль</summary>
  internal interface IModuleReferenceManager
  {
    /// <summary>Сохранить</summary>
    /// <param name="moduleReference">Ссылка на модуль</param>
    /// <exception cref="T:System.Exception">Возникает, если уникальный идентификатор метаданных пустой</exception>
    void Save(ModuleReference moduleReference);

    /// <summary>Загрузить ссылку метаданных на модуль</summary>
    /// <param name="metadataUid">Уникальный идентификатор метаданных</param>
    /// <returns>Ссылка метаданных на модуль или <c>null</c></returns>
    ModuleReference LoadOrNull(Guid metadataUid);
  }
}
