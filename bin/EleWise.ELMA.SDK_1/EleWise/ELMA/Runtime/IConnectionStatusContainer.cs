// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.IConnectionStatusContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Db;

namespace EleWise.ELMA.Runtime
{
  /// <summary>Интерфейс контейнера для текущего статуса сервера</summary>
  internal interface IConnectionStatusContainer
  {
    /// <summary>Статус сервера</summary>
    DbConnectionStatus Status { get; }
  }
}
