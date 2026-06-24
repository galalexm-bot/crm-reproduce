using System;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Managers;

public class EntityPermissionConfigurationManager : DTOManager, IEntityPermissionConfigurationManager, IConfigurationService
{
	internal static EntityPermissionConfigurationManager M0U0tdhGGnY8xyU07V5X;

	public virtual void ActivatePermissionMetadata(EntityMetadata metadata, TablePartMetadata tablePartMetadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				TMBtyFhGQtWYHXJVcLNv(metadata, tablePartMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual void DisablePermissionMetadata(EntityMetadata metadata)
	{
		RGp5k0hGCHWExmOEZigw(metadata);
	}

	public virtual TablePartMetadata GetActivePermissionMetadata(EntityMetadata metadata)
	{
		return (TablePartMetadata)pINDdIhGvMvduoP4doQB(metadata);
	}

	public virtual TablePartMetadata InitNewPermissionMetadata(EntityMetadata metadata, string metadataName, string propertyName)
	{
		int num = 1;
		int num2 = num;
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				tablePartMetadata = (TablePartMetadata)sxQOuEhG8AFQCWdldjlD(metadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return tablePartMetadata;
			default:
				metadata.InitNewPermissionMetadata(tablePartMetadata, metadataName, propertyName);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	[Obsolete("Use EntityMetadataExtensions.IsSystem or MetadataRuntimeService.IsSystem instead", true)]
	public virtual bool IsSystem(IMetadata metadata)
	{
		return mUQJlFhGZCkP9AjhqJtl(metadata);
	}

	public EntityPermissionConfigurationManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cw1HgXhGuRSliwjYZERM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void TMBtyFhGQtWYHXJVcLNv(object P_0, object P_1)
	{
		((EntityMetadata)P_0).ActivatePermissionMetadata((TablePartMetadata)P_1);
	}

	internal static bool R859WphGEH6QO5VyepLx()
	{
		return M0U0tdhGGnY8xyU07V5X == null;
	}

	internal static EntityPermissionConfigurationManager nYjunkhGfi4gmR8eW8kZ()
	{
		return M0U0tdhGGnY8xyU07V5X;
	}

	internal static void RGp5k0hGCHWExmOEZigw(object P_0)
	{
		((EntityMetadata)P_0).DisablePermissionMetadata();
	}

	internal static object pINDdIhGvMvduoP4doQB(object P_0)
	{
		return ((EntityMetadata)P_0).GetActivePermissionMetadata();
	}

	internal static object sxQOuEhG8AFQCWdldjlD(object P_0)
	{
		return ((EntityMetadata)P_0).CreateTablePart();
	}

	internal static bool mUQJlFhGZCkP9AjhqJtl(object P_0)
	{
		return ((IMetadata)P_0).IsSystem();
	}

	internal static void cw1HgXhGuRSliwjYZERM()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
