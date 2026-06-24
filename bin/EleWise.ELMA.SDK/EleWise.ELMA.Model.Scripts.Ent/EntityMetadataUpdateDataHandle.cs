using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts.Entities;

[Component]
internal sealed class EntityMetadataUpdateDataHandler : BaseMetadataUpdateDataHandler
{
	private readonly MetadataItemHeaderManager metadataItemHeaderManager;

	internal static EntityMetadataUpdateDataHandler zUw387beB86lZZZcGXDi;

	public EntityMetadataUpdateDataHandler(MetadataItemHeaderManager metadataItemHeaderManager, ScriptModuleManager scriptModuleManager)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		bm0J1VbebubQkXkfwZd9();
		base._002Ector(scriptModuleManager);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.metadataItemHeaderManager = metadataItemHeaderManager;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
			{
				num = 0;
			}
		}
	}

	public override bool Check(IMetadata metadata)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if ((entityMetadata = metadata as EntityMetadata) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return g0vkQobeGBWpIUONPe9x(CJr0ttbehmJDeIM3KdQb(entityMetadata), EntityMetadata.UID);
			default:
				return false;
			}
		}
	}

	public override IEnumerable<ScriptModule> GetScriptModules(IMetadataUpdateResult updateResult)
	{
		if (updateResult.Metadata is EntityMetadata entityMetadata)
		{
			IMetadataItemHeader metadataItemHeader = metadataItemHeaderManager.LoadOrNull(entityMetadata.Uid);
			if (metadataItemHeader?.Current.ScriptModule != null)
			{
				return new ScriptModule[1] { metadataItemHeader.Current.ScriptModule };
			}
		}
		return Enumerable.Empty<ScriptModule>();
	}

	public override IEnumerable<Guid> GetFormUids(IMetadataUpdateResult updateResult)
	{
		List<Guid> list = new List<Guid>();
		if (!(updateResult.Metadata is EntityMetadata entityMetadata))
		{
			return list;
		}
		if (metadataItemHeaderManager.LoadOrNull(entityMetadata.Uid) == null)
		{
			return list;
		}
		foreach (FormViewItem form in entityMetadata.Forms)
		{
			list.Add(form.Uid);
		}
		foreach (FormViewItemTransformation formTransformation in entityMetadata.FormTransformations)
		{
			list.Add((formTransformation.NewFormUid != Guid.Empty) ? formTransformation.NewFormUid : formTransformation.Uid);
		}
		return list;
	}

	internal static void bm0J1VbebubQkXkfwZd9()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool tPRRRKbeW8rWiEEuuD7a()
	{
		return zUw387beB86lZZZcGXDi == null;
	}

	internal static EntityMetadataUpdateDataHandler v9ngCPbeonOZxdfMiolb()
	{
		return zUw387beB86lZZZcGXDi;
	}

	internal static Guid CJr0ttbehmJDeIM3KdQb(object P_0)
	{
		return ((EntityMetadata)P_0).TypeUid;
	}

	internal static bool g0vkQobeGBWpIUONPe9x(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
