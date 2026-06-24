// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Services.IModuleAssemblyLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Model.Metadata.Services
{
  /// <summary>Загрузчик сборок модуля</summary>
  internal interface IModuleAssemblyLoader
  {
    /// <summary>Загрузить клиентскую сборку модуля</summary>
    /// <param name="moduleUid">Идентификатор модуля</param>
    /// <param name="versionUid">Идентификатор версии</param>
    /// <returns>Данные клиентской сборки</returns>
    ClientBuildResult GetClientAssembly(Guid moduleUid, Guid versionUid);

    /// <summary>Загрузить серверную сборку модуля</summary>
    /// <param name="moduleUid">Идентификатор модуля</param>
    /// <param name="versionUid">Идентификатор версии</param>
    /// <returns>Данные серверной сборки</returns>
    ServerBuildResult GetServerAssembly(Guid moduleUid, Guid versionUid);
  }
}
