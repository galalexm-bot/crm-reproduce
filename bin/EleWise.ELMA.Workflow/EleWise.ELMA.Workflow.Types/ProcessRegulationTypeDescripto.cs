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

public class ProcessRegulationTypeDescriptor : WorkflowProcessXmlSerializableTypeDescriptor<ProcessRegulation, ProcessRegulationNHType, ProcessRegulationTypeSettings>
{
	public const string UID_S = "{1DD4A250-4989-4f61-AB06-21D118F932E4}";

	public static readonly Guid UID;

	internal static ProcessRegulationTypeDescriptor EOFXYV8jj8CG6x9FfyD;

	public override Guid Uid => UID;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => SR.T((string)AZ4PA78qM9yOk0DfqpK(-45832783 ^ -45829489));

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
				case 3:
					if (!oJJZ4O8QBprIcGTwNS5(this))
					{
						num2 = 2;
						continue;
					}
					break;
				case 1:
					return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
				case 2:
					return false;
				}
				if (MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.VisualStudio)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
				{
					num2 = 1;
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
		return (ISyntaxNode)INTXHV8TTT9TEqrgmsd(XjpKWC83AskmDMVK1iC(typeof(ProcessRegulation)), Array.Empty<ISyntaxNode>());
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		return new PropertyValueContainer<ProcessRegulation>(new ProcessRegulation());
	}

	public ProcessRegulationTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QLiQi08psCkPqDZaCC2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ProcessRegulationTypeDescriptor()
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
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				UID = new Guid((string)AZ4PA78qM9yOk0DfqpK(-790221436 ^ -790218014));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object AZ4PA78qM9yOk0DfqpK(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool MKhwLt8RGm7JlVx8jTi()
	{
		return EOFXYV8jj8CG6x9FfyD == null;
	}

	internal static ProcessRegulationTypeDescriptor gt6GLN86kBYtFi4EnQA()
	{
		return EOFXYV8jj8CG6x9FfyD;
	}

	internal static object XjpKWC83AskmDMVK1iC(Type P_0)
	{
		return P_0.CreateTypeSyntax();
	}

	internal static object INTXHV8TTT9TEqrgmsd(object P_0, object P_1)
	{
		return ((ISyntaxNode)P_0).ObjectCreationExpression((ISyntaxNode[])P_1);
	}

	internal static bool oJJZ4O8QBprIcGTwNS5(object P_0)
	{
		return ((TypeDescriptor)P_0).Visible;
	}

	internal static void QLiQi08psCkPqDZaCC2()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
