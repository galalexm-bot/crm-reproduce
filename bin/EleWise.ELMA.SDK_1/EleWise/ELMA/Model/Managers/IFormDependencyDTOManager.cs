// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.IFormDependencyDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Managers
{
  public interface IFormDependencyDTOManager : IConfigurationService
  {
    /// <summary>Загрузить зависимости форм по уиду зависимого объекта</summary>
    /// <param name="uid"></param>
    /// <returns></returns>
    IEnumerable<IFormDependencyData> LoadByDependObjectUid(Guid uid);

    /// <summary>
    /// Загрузить зависимости форм по уиду используемого объекта
    /// </summary>
    /// <param name="uid"></param>
    /// <returns></returns>
    IEnumerable<IFormDependencyData> LoadByUsesObjectUid(Guid uid);

    /// <summary>
    /// Загрузить зависимости форм по списку уидов базовых классов
    /// </summary>
    /// <param name="baseUids"></param>
    /// <returns></returns>
    IEnumerable<IFormDependencyData> LoadByBaseUids(IEnumerable<Guid> baseUids);

    /// <summary>
    /// Получить отображаемую информацию для форм интерфейсов (страницы, портлеты)
    /// </summary>
    /// <param name="objectUid"></param>
    /// <param name="formUid"></param>
    /// <returns></returns>
    string GetInterfaceFormDisplayInfo(Guid objectUid, Guid formUid);
  }
}
