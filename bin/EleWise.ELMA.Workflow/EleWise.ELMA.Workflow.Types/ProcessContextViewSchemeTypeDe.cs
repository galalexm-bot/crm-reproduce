using System;
using System.Data;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Types;

public class ProcessContextViewSchemeTypeDescriptor : WorkflowProcessXmlSerializableTypeDescriptor<ProcessContextViewScheme, ProcessContextViewSchemeNHType, ProcessContextViewSchemeTypeSettings>
{
	public const string UID_S = "{39B9D454-69DF-4621-89A6-518BB85C1D27}";

	public static readonly Guid UID;

	internal static ProcessContextViewSchemeTypeDescriptor DRfAUvsIfBMZyxefn35;

	public override Guid Uid => UID;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => (string)req7HXsNcpIltIbjeqa(Hfjx2Pse8SF2PO2d6TD(-2125897096 ^ -2125891160));

	public override bool Visible
	{
		get
		{
			//Discarded unreachable code: IL_003e, IL_004d
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
				default:
					return false;
				case 1:
					if (!ih0gXksxjkCoLdM7bxc(this))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					break;
				}
				if (MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.VisualStudio)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
				{
					num2 = 3;
				}
			}
			return true;
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Binary);
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		return (ISyntaxNode)WurbJus1XKnSuJyghIb(GsqXLWsS8OMuBhkgrU9(typeof(ProcessContextViewScheme).TypeHandle).CreateTypeSyntax(), Array.Empty<ISyntaxNode>());
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		return new PropertyValueContainer<ProcessContextViewScheme>(new ProcessContextViewScheme());
	}

	public ProcessContextViewSchemeTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		UAuXhcshcZYZmukvflM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ProcessContextViewSchemeTypeDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)Hfjx2Pse8SF2PO2d6TD(-980570076 ^ -980571132));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			case 1:
				UAuXhcshcZYZmukvflM();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object Hfjx2Pse8SF2PO2d6TD(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object req7HXsNcpIltIbjeqa(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool ng4FEZsaXcPHMGaFql8()
	{
		return DRfAUvsIfBMZyxefn35 == null;
	}

	internal static ProcessContextViewSchemeTypeDescriptor qJwXMhsr1ruYIOme2r1()
	{
		return DRfAUvsIfBMZyxefn35;
	}

	internal static bool ih0gXksxjkCoLdM7bxc(object P_0)
	{
		return ((TypeDescriptor)P_0).Visible;
	}

	internal static Type GsqXLWsS8OMuBhkgrU9(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object WurbJus1XKnSuJyghIb(object P_0, object P_1)
	{
		return ((ISyntaxNode)P_0).ObjectCreationExpression((ISyntaxNode[])P_1);
	}

	internal static void UAuXhcshcZYZmukvflM()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
