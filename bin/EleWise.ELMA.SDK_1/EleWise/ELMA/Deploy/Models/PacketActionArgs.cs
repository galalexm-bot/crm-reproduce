// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Models.PacketActionArgs
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Models
{
  /// <summary>Аргументы действия для пакета импорта сущностей</summary>
  internal sealed class PacketActionArgs
  {
    /// <summary>Ctor</summary>
    /// <param name="importSettings">Настройки импорта</param>
    /// <param name="entities">Сущности пакета</param>
    /// <param name="messages">Сообщения</param>
    /// <param name="contentType">Тип пакета</param>
    /// <param name="packetData">Служебные данные пакета</param>
    /// <param name="serviceData">Служебные данные</param>
    public PacketActionArgs(
      IImportSettings importSettings,
      ICollection<IEntity> entities,
      ICollection<DeployLogMessage> messages,
      string contentType,
      IDictionary<string, string> packetData,
      IDictionary<string, string> serviceData)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.ImportSettings = importSettings;
      this.Entities = entities;
      this.Messages = messages;
      this.ContentType = contentType;
      this.PacketData = packetData;
      this.ServiceData = serviceData;
    }

    /// <summary>Настройки импорта</summary>
    public IImportSettings ImportSettings { get; }

    /// <summary>Сущности</summary>
    public ICollection<IEntity> Entities { get; }

    /// <summary>Сообщения</summary>
    public ICollection<DeployLogMessage> Messages { get; }

    /// <summary>Тип пакета</summary>
    public string ContentType { get; }

    /// <summary>Служебные данные пакета</summary>
    public IDictionary<string, string> PacketData { get; }

    /// <summary>Служебные данные</summary>
    public IDictionary<string, string> ServiceData { get; }
  }
}
