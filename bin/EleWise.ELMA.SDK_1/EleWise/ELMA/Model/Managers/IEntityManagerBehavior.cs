// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.IEntityManagerBehavior
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using NHibernate;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>
  /// Точка расширения для изменения поведения EntityManager
  /// </summary>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  public interface IEntityManagerBehavior
  {
    /// <summary>Вызывается после создания объекта Criteria</summary>
    /// <param name="criteria"></param>
    /// <param name="filter">Фильтр объекта</param>
    void OnCreateCriteria(ICriteria criteria, IEntityFilter filter);

    /// <summary>Вызывается в момент загрузки объекта</summary>
    /// <param name="target">Объект</param>
    void OnLoad(object target);
  }
}
