using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Runtime.NH.Listeners;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;

namespace EleWise.ELMA.Model.Listeners;

[Component]
internal sealed class ModuleMetadataItemListener : EntityEventsListener
{
	private readonly IModuleReferenceManager moduleReferenceManager;

	internal static ModuleMetadataItemListener VUbSqmoFp4UCyjyyVBU5;

	public ModuleMetadataItemListener(IModuleReferenceManager moduleReferenceManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
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
			this.moduleReferenceManager = moduleReferenceManager;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
			{
				num = 1;
			}
		}
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				base.OnPostInsert(@event);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				Update((IPostDatabaseOperationEventArgs)(object)@event);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Update((IPostDatabaseOperationEventArgs)(object)@event);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				base.OnPostUpdate(@event);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void Update(IPostDatabaseOperationEventArgs @event)
	{
		int num = 2;
		int num2 = num;
		ModuleInfoMetadata moduleInfoMetadata = default(ModuleInfoMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				ProcessMetadata(moduleInfoMetadata.Functions);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (!(CDv4GAoFthEDiJEg4ycD(@event) is ModuleMetadataItem moduleMetadataItem))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 1;
					}
				}
				else if ((moduleInfoMetadata = YaCbd2oFwyyQrxbJdj6I(moduleMetadataItem) as ModuleInfoMetadata) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					ProcessMetadata(moduleInfoMetadata.Components);
					num2 = 5;
				}
				break;
			case 4:
				return;
			case 5:
				ProcessMetadata(moduleInfoMetadata.DataClasses);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				return;
			case 0:
				return;
			}
		}
		void ProcessMetadata(IEnumerable<IMetadata> metadataList)
		{
			foreach (IMetadata metadata in metadataList)
			{
				ModuleReference moduleReference = new ModuleReference
				{
					MetadataUid = metadata.Uid,
					ModuleUid = metadata.ModuleUid
				};
				moduleReferenceManager.Save(moduleReference);
			}
		}
	}

	internal static bool MHQUBhoFaI9bMeCEkeWW()
	{
		return VUbSqmoFp4UCyjyyVBU5 == null;
	}

	internal static ModuleMetadataItemListener nL3wUEoFDZDoEVKIkXnh()
	{
		return VUbSqmoFp4UCyjyyVBU5;
	}

	internal static object CDv4GAoFthEDiJEg4ycD(object P_0)
	{
		return ((IPostDatabaseOperationEventArgs)P_0).get_Entity();
	}

	internal static object YaCbd2oFwyyQrxbJdj6I(object P_0)
	{
		return ((ModuleMetadataItem)P_0).Metadata;
	}
}
