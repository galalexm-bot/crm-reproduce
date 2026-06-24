// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.IEntityPermission
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Security.Services;
using System;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>Интерфейс объекта привилегий доступа к экземпляру</summary>
  public interface IEntityPermission : 
    IEntity<long>,
    IEntity,
    IIdentified,
    ISecuritySetIdHolder,
    IInstanceSettingsPermissionHolder
  {
    /// <summary>Роль</summary>
    Guid? PermissionRole { get; set; }

    /// <summary>Ссылка на объект, к которому применяются права</summary>
    IEntity Instance { get; set; }
  }
}
