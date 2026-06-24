// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.ExtensionPoints.IAddEntityToData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Export.ExtensionPoints
{
  /// <summary>
  /// Расширение для добавления дополнительных сущностей к сущностям-записям экспортируемых данных справочника
  /// Создано для возможности использования аттачментов до введения полноценных правил экспорта-импорта
  /// tuev: Расширения помимо аттачмента создавать только при согласовании со мной
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IAddEntityToData
  {
    /// <summary>Метод возвращающий список добавляемых сущностей</summary>
    /// <returns></returns>
    List<IEntity> AddEntities(ClassMetadata metadata, IEntity entity);
  }
}
