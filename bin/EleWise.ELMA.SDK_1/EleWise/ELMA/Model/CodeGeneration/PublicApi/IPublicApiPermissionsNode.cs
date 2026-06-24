// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.IPublicApiPermissionsNode
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  /// <summary>Общий интерфейс для PublicApiPermissionsNode</summary>
  internal interface IPublicApiPermissionsNode
  {
    /// <summary>Тип провайдера привелегий</summary>
    Type Type { get; }
  }
}
