// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.IPermissionRoleTypeProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using System.Collections.Generic;

namespace EleWise.ELMA.Security
{
  /// <summary>Привилегии для объекта типа, роли для привилегий</summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-813.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  public interface IPermissionRoleTypeProvider
  {
    /// <summary>
    /// Получить соответствие тип, привилегия, роль.
    /// По этот метод задает какие привилегии можно задавать на объекты типа, и какие роли возможны для привилегий
    /// </summary>
    /// <returns></returns>
    IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes();

    /// <summary>Получить роли, относящиеся к привилегиям</summary>
    /// <returns></returns>
    IEnumerable<PermissionRoleType> GetRoleTypes();
  }
}
