// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Managers.ITypeDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using System;

namespace EleWise.ELMA.Deploy.Managers
{
  /// <summary>Менеджер для работы с типами в дизайнере</summary>
  public interface ITypeDTOManager : IConfigurationService
  {
    /// <summary>Проверить уникальное наименование в интерфейсах</summary>
    /// <param name="typeUid">Guid типа</param>
    /// <param name="propertyName">Наименование свойства</param>
    /// <param name="propertyUid">Uid свойства</param>
    /// <returns>True, если в интерфейсе нет такого свойства или он имеет такой же Uid, иначе false</returns>
    bool CheckUniqueName(Guid typeUid, string propertyName, Guid propertyUid);
  }
}
