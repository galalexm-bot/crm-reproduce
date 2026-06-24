// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IScriptLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Scripts;
using System;

namespace EleWise.ELMA.Services
{
  /// <summary>Загрузчик скриптов</summary>
  internal interface IScriptLoader
  {
    /// <summary>Загрузить скрипт по идентификатору</summary>
    /// <param name="scriptUid">Идентификатор</param>
    /// <returns>Скрипт</returns>
    ScriptModule GetScript(Guid? scriptUid);
  }
}
