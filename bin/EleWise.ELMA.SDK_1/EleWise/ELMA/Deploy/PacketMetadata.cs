// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.PacketMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy
{
  /// <summary>Класс пакет метаданных</summary>
  public class PacketMetadata
  {
    public IMetadata MetaData;
    /// <summary>Список вложеных системных метаданных</summary>
    public List<IGroupedMetadata> SubSystemMetadata;
    /// <summary>
    /// Список вложеных сущностей относящихся к метаданным, записываемых до метаданных
    /// </summary>
    public Dictionary<IEntity, Guid?> SubEntitiesBefore;
    /// <summary>
    /// Список вложеных сущностей относящихся к метаданным, записываемых после метаданных
    /// </summary>
    public Dictionary<IEntity, Guid?> SubEntitiesAfter;
    /// <summary>Кастомные правила импорта свойств сущностей пакета</summary>
    public ExportRuleList ExportRules;
    internal static PacketMetadata c6lqeuEpfbZaPQmLJZw1;

    /// <summary>Конструктор для пакета метаданных</summary>
    public PacketMetadata(IMetadata metaData)
    {
      PacketMetadata.O8lsHIEpvQff7poB1NqJ();
      this.SubUserMetadataInfo = (IDictionary<Guid, EleWise.ELMA.Deploy.Models.SubUserMetadataInfo>) new Dictionary<Guid, EleWise.ELMA.Deploy.Models.SubUserMetadataInfo>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.SubSystemMetadata = new List<IGroupedMetadata>();
            num = 4;
            continue;
          case 2:
            this.MetaData = metaData;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            this.SubEntitiesBefore = new Dictionary<IEntity, Guid?>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          default:
            this.SubEntitiesAfter = new Dictionary<IEntity, Guid?>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Список вложеных пользовательских метаданных</summary>
    public IDictionary<Guid, EleWise.ELMA.Deploy.Models.SubUserMetadataInfo> SubUserMetadataInfo { get; }

    internal static void O8lsHIEpvQff7poB1NqJ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool XHBIGrEpQ0NlB0FMkjnY() => PacketMetadata.c6lqeuEpfbZaPQmLJZw1 == null;

    internal static PacketMetadata RILxQsEpCh1CY0Qj7oB5() => PacketMetadata.c6lqeuEpfbZaPQmLJZw1;
  }
}
