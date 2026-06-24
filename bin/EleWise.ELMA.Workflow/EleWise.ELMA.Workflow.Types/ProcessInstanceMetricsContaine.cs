using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Types;

public class ProcessInstanceMetricsContainerTypeDescriptor : EntityMetadataTypeDescriptor<ProcessInstanceMetricsContainer>
{
	public new const string UID_S = "{72ED98CA-F260-4671-9BCD-FF1D80235F47}";

	public new static readonly Guid UID;

	private static readonly Guid ParametersEntityUid;

	internal static ProcessInstanceMetricsContainerTypeDescriptor mquJ5MsuICoBNFYAM31;

	public override Guid Uid => UID;

	protected override Guid EntityUid => ParametersEntityUid;

	public override Guid ParentUid => new Guid((string)m6x6MesHjYIiQ8qfv6X(0x4943E3E4 ^ 0x4943FBBC));

	public override string Name => SR.T((string)m6x6MesHjYIiQ8qfv6X(0x651FE29D ^ 0x651FFA35));

	public override bool Visible
	{
		get
		{
			//Discarded unreachable code: IL_0078, IL_0087
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (MetadataAccessInfo.EnvironmentType != MetadataEnvironmentType.VisualStudio)
					{
						num2 = 3;
						break;
					}
					return true;
				case 3:
					return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
				case 1:
					return false;
				case 2:
					if (!base.Visible)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		throw new NotImplementedException();
	}

	public ProcessInstanceMetricsContainerTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ProcessInstanceMetricsContainerTypeDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				ParametersEntityUid = new Guid((string)m6x6MesHjYIiQ8qfv6X(0x75872B6 ^ 0x7586BF2));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			default:
				UID = new Guid((string)m6x6MesHjYIiQ8qfv6X(--296112178 ^ 0x11A648C6));
				num2 = 3;
				break;
			case 1:
				NmsuTysLZU2rCyeQhCD();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object m6x6MesHjYIiQ8qfv6X(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool OUERYCsDtpTS6xVKAxq()
	{
		return mquJ5MsuICoBNFYAM31 == null;
	}

	internal static ProcessInstanceMetricsContainerTypeDescriptor iMkUW5snNsTp7mLH5iF()
	{
		return mquJ5MsuICoBNFYAM31;
	}

	internal static void NmsuTysLZU2rCyeQhCD()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
