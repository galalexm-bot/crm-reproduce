// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.ISchedulerTaskOwner
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using System;

namespace EleWise.ELMA.Scheduling
{
  /// <summary>Владелец задачи планировщика</summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-794.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  [ExtensionPoint(ComponentType.All)]
  public interface ISchedulerTaskOwner
  {
    /// <summary>Уникальный идентификатор владельца</summary>
    Guid Uid { get; }

    /// <summary>Имя владельца</summary>
    string Name { get; }
  }
}
