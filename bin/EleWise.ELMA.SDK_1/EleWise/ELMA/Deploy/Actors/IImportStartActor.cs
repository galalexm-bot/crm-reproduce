// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Actors.IImportStartActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Deploy.Import;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Actors
{
  /// <summary>Интерфейс актора управления запуском импорта</summary>
  internal interface IImportStartActor : IActorWithGuidKey, IActor
  {
    /// <summary>Запустить импорт</summary>
    /// <param name="settings">Настройки импорта</param>
    /// <returns>Идентификатор сессии импорта</returns>
    Task<Guid> Import(IImportSettings settings);

    /// <summary>Получить идентификатор текущего импорта</summary>
    /// <returns>Идентификатор импорта, либо пустой <see cref="T:System.Guid" />, если в данный момент не запущен импорт</returns>
    Task<Guid> GetCurrentImportId();

    /// <summary>Запустить продолжаемый импорт</summary>
    /// <param name="settings">Список настроек импорта</param>
    /// <returns>Идентификатор сессии импорта</returns>
    Task<Guid> ContinuedImport(IEnumerable<IConfigImportSettings> settings);

    /// <summary>Продолжить импорт</summary>
    Task ContinueImport();
  }
}
