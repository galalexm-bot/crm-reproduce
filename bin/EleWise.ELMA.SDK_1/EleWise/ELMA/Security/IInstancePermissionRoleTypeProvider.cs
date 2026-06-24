// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.IInstancePermissionRoleTypeProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Security
{
  /// <summary>
  /// Привилегии для объекта типа, роли для привилегий, на основе экземпляра сущности
  /// </summary>
  public interface IInstancePermissionRoleTypeProvider : IPermissionRoleTypeProvider
  {
    /// <summary>
    /// Получить соответствие тип, привилегия, роль. Сформированные на  основе указанной сущности
    /// Этот метод задает какие привилегии можно задавать на объекты типа, и какие роли возможны для привилегий
    /// </summary>
    /// <param name="instance">Экземпляр сущности</param>
    /// <returns>Возвращает список соответствий привилегий и типов, определяемых по экземпляру сущности</returns>
    IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes(object instance);
  }
}
