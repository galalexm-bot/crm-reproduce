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

public class InstanceNamingSchemeTypeDescriptor : WorkflowProcessXmlSerializableTypeDescriptor<InstanceNamingScheme, InstanceNamingSchemeNHType, InstanceNamingSchemeTypeSettings>
{
	public const string UID_S = "{13EBBF3A-42EA-46FA-A9E1-FE127E8698BE}";

	public static readonly Guid UID;

	private static InstanceNamingSchemeTypeDescriptor B8UAOZsUhWMIe2ux7ky;

	public override Guid Uid => UID;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => (string)BjakCEs7L1NjMiOdiYi(mOTIpRsGtBp3O22AwS2(-1108877388 ^ -1108884236));

	public override bool Visible
	{
		get
		{
			//Discarded unreachable code: IL_0063, IL_0072
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
				case 1:
					return false;
				case 2:
					if (!tMPTBmsFghha48LOJmP(this))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 3:
					break;
				}
				if (MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.VisualStudio)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
				{
					num2 = 0;
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
		return (ISyntaxNode)aaI3d0soctaWJRIWlFQ(KW5AIJs21TlRWjKZwbN(typeof(InstanceNamingScheme)), Array.Empty<ISyntaxNode>());
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		return new PropertyValueContainer<InstanceNamingScheme>(new InstanceNamingScheme());
	}

	public InstanceNamingSchemeTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static InstanceNamingSchemeTypeDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				reryU5siOwy6NbVUUvh();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				UID = new Guid((string)mOTIpRsGtBp3O22AwS2(-768800937 ^ -768795433));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object mOTIpRsGtBp3O22AwS2(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object BjakCEs7L1NjMiOdiYi(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool rKQRNisV3s07xKtuZLR()
	{
		return B8UAOZsUhWMIe2ux7ky == null;
	}

	internal static InstanceNamingSchemeTypeDescriptor Iqc69esA9EbP4nGFxHH()
	{
		return B8UAOZsUhWMIe2ux7ky;
	}

	internal static object KW5AIJs21TlRWjKZwbN(Type P_0)
	{
		return P_0.CreateTypeSyntax();
	}

	internal static object aaI3d0soctaWJRIWlFQ(object P_0, object P_1)
	{
		return ((ISyntaxNode)P_0).ObjectCreationExpression((ISyntaxNode[])P_1);
	}

	internal static bool tMPTBmsFghha48LOJmP(object P_0)
	{
		return ((TypeDescriptor)P_0).Visible;
	}

	internal static void reryU5siOwy6NbVUUvh()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
