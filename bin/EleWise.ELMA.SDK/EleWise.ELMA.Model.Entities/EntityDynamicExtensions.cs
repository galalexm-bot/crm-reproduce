using System;
using System.ComponentModel;

namespace EleWise.ELMA.Model.Entities;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class EntityDynamicExtensions
{
	internal static EntityDynamicExtensions jl46dvh8EyVBDTTyFX3y;

	public static Guid GetTypeUid(IEntity entity)
	{
		return ((IEntityDynamic)entity).TypeUid;
	}

	public static void SetTypeUid(IEntity entity, Guid uid)
	{
	}

	internal static bool JsAQx6h8fnFUMpPKD2QB()
	{
		return jl46dvh8EyVBDTTyFX3y == null;
	}

	internal static EntityDynamicExtensions RZsGDdh8Q9dtaQmPwjiW()
	{
		return jl46dvh8EyVBDTTyFX3y;
	}
}
