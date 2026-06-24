// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IEntityTitle
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Определение наименования сущности</summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IEntityTitle
  {
    /// <summary>Проверка соответствия типа</summary>
    /// <param name="entity">Сущность</param>
    /// <returns></returns>
    bool CheckType(IEntity entity);

    /// <summary>Наименование</summary>
    /// <param name="entity">Сущность</param>
    /// <returns></returns>
    string Title(IEntity entity);
  }
}
