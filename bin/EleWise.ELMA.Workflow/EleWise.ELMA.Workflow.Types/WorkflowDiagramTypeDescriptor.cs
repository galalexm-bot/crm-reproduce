using System;
using System.Data;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Types;

public class WorkflowDiagramTypeDescriptor : WorkflowProcessXmlSerializableTypeDescriptor<WorkflowDiagram, WorkflowDiagramNHType, WorkflowDiagramTypeSettings>
{
	public const string UID_S = "{89FF4169-0ABF-4D42-BA7B-C85367CD6096}";

	public static readonly Guid UID;

	private static WorkflowDiagramTypeDescriptor sgcjIQJCR3IGVFiyhxZ;

	public override Guid Uid => UID;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => SR.T((string)eyLWkkJUJq3J0vspYXf(-949717965 ^ -949720521));

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
				default:
					if (MetadataAccessInfo.EnvironmentType != MetadataEnvironmentType.VisualStudio)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return true;
				case 3:
					if (!DnDSaSJVN9NIcD2Lla9(this))
					{
						num2 = 2;
						break;
					}
					goto default;
				case 1:
					return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
				case 2:
					return false;
				}
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Binary);
	}

	public WorkflowDiagramTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WSZPcnJATHXACrTIFCd();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowDiagramTypeDescriptor()
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
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid((string)eyLWkkJUJq3J0vspYXf(0x7381F16B ^ 0x7381EF47));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object eyLWkkJUJq3J0vspYXf(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool Ib4gu6JMfpDOlme9WiW()
	{
		return sgcjIQJCR3IGVFiyhxZ == null;
	}

	internal static WorkflowDiagramTypeDescriptor hiPg4FJkPyrQo0FL3bL()
	{
		return sgcjIQJCR3IGVFiyhxZ;
	}

	internal static bool DnDSaSJVN9NIcD2Lla9(object P_0)
	{
		return ((TypeDescriptor)P_0).Visible;
	}

	internal static void WSZPcnJATHXACrTIFCd()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
