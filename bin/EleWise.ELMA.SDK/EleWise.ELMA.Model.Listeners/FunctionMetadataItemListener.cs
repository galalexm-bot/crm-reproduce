using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Runtime.NH.Listeners;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;

namespace EleWise.ELMA.Model.Listeners;

[Component]
internal sealed class FunctionMetadataItemListener : EntityEventsListener
{
	private readonly IModuleReferenceManager moduleReferenceManager;

	internal static FunctionMetadataItemListener lHRU91oFTQAnXGAUxK1D;

	public FunctionMetadataItemListener(IModuleReferenceManager moduleReferenceManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ACr82YoFOotf3yOaGQHL();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.moduleReferenceManager = moduleReferenceManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
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
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				Update((IPostDatabaseOperationEventArgs)(object)@event);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
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
			case 1:
				base.OnPostUpdate(@event);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				Update((IPostDatabaseOperationEventArgs)(object)@event);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private void Update(IPostDatabaseOperationEventArgs @event)
	{
		int num = 3;
		int num2 = num;
		ModuleReference moduleReference2 = default(ModuleReference);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			default:
				UeUxLZoF3DBEjlDYSaWe(moduleReferenceManager, moduleReference2);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				return;
			case 3:
				if (yrqPcOoF29T7lDb0LpDQ(@event) is FunctionMetadataItem functionMetadataItem)
				{
					if (!(d3ghfYoFeevwkWRdsklC(functionMetadataItem) is FunctionMetadata functionMetadata))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 1;
						}
						break;
					}
					ModuleReference moduleReference = new ModuleReference();
					cdk75BoF1FrDVGlIYrE9(moduleReference, Top0l3oFPymdqkWfrcIm(functionMetadata));
					moduleReference.ModuleUid = oalW29oFNwHPKnlWg3mE(functionMetadata);
					moduleReference2 = moduleReference;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 2;
					}
				}
				break;
			case 1:
				return;
			}
		}
	}

	internal static void ACr82YoFOotf3yOaGQHL()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool NIxbGboFkbWO3dO5VmfP()
	{
		return lHRU91oFTQAnXGAUxK1D == null;
	}

	internal static FunctionMetadataItemListener Auqev2oFnWepQ3co9moH()
	{
		return lHRU91oFTQAnXGAUxK1D;
	}

	internal static object yrqPcOoF29T7lDb0LpDQ(object P_0)
	{
		return ((IPostDatabaseOperationEventArgs)P_0).get_Entity();
	}

	internal static object d3ghfYoFeevwkWRdsklC(object P_0)
	{
		return ((FunctionMetadataItem)P_0).Metadata;
	}

	internal static Guid Top0l3oFPymdqkWfrcIm(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void cdk75BoF1FrDVGlIYrE9(object P_0, Guid value)
	{
		((ModuleReference)P_0).MetadataUid = value;
	}

	internal static Guid oalW29oFNwHPKnlWg3mE(object P_0)
	{
		return ((AbstractMetadata)P_0).ModuleUid;
	}

	internal static void UeUxLZoF3DBEjlDYSaWe(object P_0, object P_1)
	{
		((IModuleReferenceManager)P_0).Save((ModuleReference)P_1);
	}
}
