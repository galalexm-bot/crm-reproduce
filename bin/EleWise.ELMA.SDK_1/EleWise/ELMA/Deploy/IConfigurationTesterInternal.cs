// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.IConfigurationTesterInternal
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Import;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy
{
  /// <summary>Внутренняя часть объекта для проверки конфигурации</summary>
  internal interface IConfigurationTesterInternal : IConfigurationTester
  {
    /// <summary>
    /// Событие, которые вызывается перед добавление сообщений о прохождении этапа теста в лог
    /// </summary>
    event Action<TestImportMessages> BeforeAddTestMessage;

    /// <summary>Идентификатор приложения</summary>
    string AppId { get; }

    /// <summary>Получить список системных сообщений с этапа теста</summary>
    List<DeploySystemMessage> GetTestSystemMessages();
  }
}
