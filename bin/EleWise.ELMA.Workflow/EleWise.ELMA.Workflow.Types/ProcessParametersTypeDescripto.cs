using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Types;

public class ProcessParametersTypeDescriptor : EntityMetadataTypeDescriptor<ProcessContext>
{
	public new const string UID_S = "{72ED98CA-F260-4671-9BCD-FF1D80235F47}";

	public new static readonly Guid UID;

	private static ProcessParametersTypeDescriptor gYDd6SJvIJTZneVfenu;

	public override Guid Uid => UID;

	protected override Guid EntityUid => ProcessContext.ProcessContextUid;

	public override Guid ParentUid => new Guid((string)MM7iCiJs2OuPAss08Ev(-1712492721 ^ -1712491589));

	public override string Name => (string)uvkc82JJs5MEa6dyZ9V(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A69D889));

	public override bool Visible
	{
		get
		{
			//Discarded unreachable code: IL_0078, IL_0087
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (MetadataAccessInfo.EnvironmentType != MetadataEnvironmentType.VisualStudio)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return true;
				default:
					return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
				case 2:
					return false;
				case 3:
					if (!Tw9US2JlgGaqo5sNwZ4(this))
					{
						num2 = 2;
						break;
					}
					goto case 1;
				}
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		throw new NotImplementedException();
	}

	public ProcessParametersTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kNScxqJ0Lin96eIkhSQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ProcessParametersTypeDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)MM7iCiJs2OuPAss08Ev(0x3C1FFB55 ^ 0x3C1FE3A1));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				kNScxqJ0Lin96eIkhSQ();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object MM7iCiJs2OuPAss08Ev(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool Rt8KqZJYPC0O1JSktve()
	{
		return gYDd6SJvIJTZneVfenu == null;
	}

	internal static ProcessParametersTypeDescriptor Gg5cesJ8GUrI4rUCKo5()
	{
		return gYDd6SJvIJTZneVfenu;
	}

	internal static object uvkc82JJs5MEa6dyZ9V(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool Tw9US2JlgGaqo5sNwZ4(object P_0)
	{
		return ((EntitySubTypeDescriptor<EntityMetadata>)P_0).Visible;
	}

	internal static void kNScxqJ0Lin96eIkhSQ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
