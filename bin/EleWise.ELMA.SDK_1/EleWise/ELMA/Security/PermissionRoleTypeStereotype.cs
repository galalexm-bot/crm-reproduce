// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.PermissionRoleTypeStereotype
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security
{
  /// <summary>Информация о соответвтсии типа, привилигиях и ролях.</summary>
  public class PermissionRoleTypeStereotype
  {
    private readonly Type type;
    private readonly Permission permission;
    private readonly IEnumerable<PermissionRoleType> roleTypes;

    public PermissionRoleTypeStereotype(
      Type type,
      Permission permission,
      IEnumerable<PermissionRoleType> roleTypes)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.type = type;
      this.permission = permission;
      this.roleTypes = roleTypes;
    }

    /// <summary>Тип сущности</summary>
    public Type Type => this.type;

    /// <summary>Привилегия</summary>
    public Permission Permission => this.permission;

    /// <summary>Роли</summary>
    public IEnumerable<PermissionRoleType> RoleTypes => this.roleTypes;
  }
}
