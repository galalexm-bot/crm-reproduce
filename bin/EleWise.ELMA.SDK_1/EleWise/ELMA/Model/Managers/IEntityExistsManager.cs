// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.IEntityExistsManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>Интерфейс менеджера с проверкой на наличие объектов</summary>
  public interface IEntityExistsManager
  {
    /// <summary>Узнать о наличии объектов</summary>
    /// <returns>Наличие объектов</returns>
    bool Exists();

    /// <summary>Узнать о наличии подходящих объектов по фильтру</summary>
    /// <param name="filter">Фильтр объекта</param>
    /// <returns>Наличие объектов по фильтру</returns>
    bool Exists(IEntityFilter filter);
  }
}
