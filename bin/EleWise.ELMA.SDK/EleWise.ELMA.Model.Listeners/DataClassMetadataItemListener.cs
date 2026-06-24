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
internal sealed class DataClassMetadataItemListener : EntityEventsListener
{
	private readonly IModuleReferenceManager moduleReferenceManager;

	internal static DataClassMetadataItemListener ebo5HToFuxDrbSYxnkJW;

	public DataClassMetadataItemListener(IModuleReferenceManager moduleReferenceManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
		{
			num = 0;
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return base.OnPreInsert(@event);
			case 1:
				Update((IPreDatabaseOperationEventArgs)(object)@event);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return base.OnPreUpdate(@event);
			case 1:
				Update((IPreDatabaseOperationEventArgs)(object)@event);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void Update(IPreDatabaseOperationEventArgs @event)
	{
		//Discarded unreachable code: IL_00d9
		int num = 4;
		int num2 = num;
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		ModuleReference moduleReference2 = default(ModuleReference);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (!(Nqq2BBoFSk0la7GVkGyH(@event) is DataClassMetadataItem dataClassMetadataItem))
				{
					num2 = 3;
					break;
				}
				if ((dataClassMetadata = dataClassMetadataItem.Metadata as DataClassMetadata) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 2:
				YmBD1xoFXStKnX9beqen(moduleReferenceManager, moduleReference2);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			case 5:
				return;
			default:
			{
				ModuleReference moduleReference = new ModuleReference();
				EXmE3ZoFRtOJU9mVITUD(moduleReference, OHJR9NoFijQcl1UGPCVL(dataClassMetadata));
				t7u9kioFKbAd4X2n6thH(moduleReference, vCXL6joFqSu0qxoLbZaD(dataClassMetadata));
				moduleReference2 = moduleReference;
				num2 = 2;
				break;
			}
			case 1:
				return;
			}
		}
	}

	internal static bool CTY4qNoFI9ObTH5ZU7WA()
	{
		return ebo5HToFuxDrbSYxnkJW == null;
	}

	internal static DataClassMetadataItemListener Ou3wPnoFVH8jJp4hebwx()
	{
		return ebo5HToFuxDrbSYxnkJW;
	}

	internal static object Nqq2BBoFSk0la7GVkGyH(object P_0)
	{
		return ((IPreDatabaseOperationEventArgs)P_0).get_Entity();
	}

	internal static Guid OHJR9NoFijQcl1UGPCVL(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void EXmE3ZoFRtOJU9mVITUD(object P_0, Guid value)
	{
		((ModuleReference)P_0).MetadataUid = value;
	}

	internal static Guid vCXL6joFqSu0qxoLbZaD(object P_0)
	{
		return ((AbstractMetadata)P_0).ModuleUid;
	}

	internal static void t7u9kioFKbAd4X2n6thH(object P_0, Guid value)
	{
		((ModuleReference)P_0).ModuleUid = value;
	}

	internal static void YmBD1xoFXStKnX9beqen(object P_0, object P_1)
	{
		((IModuleReferenceManager)P_0).Save((ModuleReference)P_1);
	}
}
