// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.EntityDynamicExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.ComponentModel;

namespace EleWise.ELMA.Model.Entities
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class EntityDynamicExtensions
  {
    internal static EntityDynamicExtensions jl46dvh8EyVBDTTyFX3y;

    public static Guid GetTypeUid(IEntity entity) => ((IEntityDynamic) entity).TypeUid;

    public static void SetTypeUid(IEntity entity, Guid uid)
    {
    }

    internal static bool JsAQx6h8fnFUMpPKD2QB() => EntityDynamicExtensions.jl46dvh8EyVBDTTyFX3y == null;

    internal static EntityDynamicExtensions RZsGDdh8Q9dtaQmPwjiW() => EntityDynamicExtensions.jl46dvh8EyVBDTTyFX3y;
  }
}
