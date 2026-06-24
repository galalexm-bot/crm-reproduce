using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Types;

public class ProcessMetricsContainerTypeDescriptor : EntityMetadataTypeDescriptor<ProcessMetricsContainer>
{
	public new const string UID_S = "{72ED98CA-F260-4671-9BCD-FF1D80235F47}";

	public new static readonly Guid UID;

	private static readonly Guid ParametersEntityUid;

	internal static ProcessMetricsContainerTypeDescriptor z8Nc2esfIQMyYWAC7br;

	public override Guid Uid => UID;

	protected override Guid EntityUid => ParametersEntityUid;

	public override Guid ParentUid => new Guid((string)ECyU0BsjBdM7qoKsCq7(-961162596 ^ -961164532));

	public override string Name => (string)Kdi2QhsR6sC6x5R7hWJ(ECyU0BsjBdM7qoKsCq7(0x213F6477 ^ 0x213F7D97));

	public override bool Visible
	{
		get
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (MetadataAccessInfo.EnvironmentType != MetadataEnvironmentType.VisualStudio)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return true;
				default:
					return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
				case 2:
					if (!x5WLU7s6W8jb3JkFNQW(this))
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		throw new NotImplementedException();
	}

	public ProcessMetricsContainerTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		N0On6Rsq9ulkGE7hobO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ProcessMetricsContainerTypeDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				N0On6Rsq9ulkGE7hobO();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				UID = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-684210684 ^ -684204304));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				ParametersEntityUid = new Guid((string)ECyU0BsjBdM7qoKsCq7(0x12F686A ^ 0x12F725C));
				num2 = 3;
				break;
			}
		}
	}

	internal static object ECyU0BsjBdM7qoKsCq7(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool eyVcrPs9D6YF2ETblcS()
	{
		return z8Nc2esfIQMyYWAC7br == null;
	}

	internal static ProcessMetricsContainerTypeDescriptor zPdBFPsWXOfVkMkq1q4()
	{
		return z8Nc2esfIQMyYWAC7br;
	}

	internal static object Kdi2QhsR6sC6x5R7hWJ(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool x5WLU7s6W8jb3JkFNQW(object P_0)
	{
		return ((EntitySubTypeDescriptor<EntityMetadata>)P_0).Visible;
	}

	internal static void N0On6Rsq9ulkGE7hobO()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
