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

public class WorkflowFormsContainerTypeDescriptor : WorkflowProcessXmlSerializableTypeDescriptor<WorkflowFormsContainer, WorkflowFormsContainerNHType, WorkflowFormsContainerTypeSettings>
{
	public const string UID_S = "{4F8BE3F5-6F53-4D19-BAFE-1A5C19861203}";

	public static readonly Guid UID;

	private static WorkflowFormsContainerTypeDescriptor mWuo1L8GHk1Qv8VJhFK;

	public override Guid Uid => UID;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => (string)D0vWfn8oNBfAtgBw4bv(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70EBAE45));

	public override bool Visible
	{
		get
		{
			//Discarded unreachable code: IL_0053, IL_0062
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
				case 2:
					if (MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.VisualStudio)
					{
						return true;
					}
					num2 = 3;
					break;
				case 1:
					if (!lexd2a8acil0o67M5rM(this))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Binary);
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		return (ISyntaxNode)aac9yY8IwVlV84fpIs9(pmYY8a8iEQIniL03Wxg(Vh4Qyw8FTHO69hor27O(typeof(WorkflowFormsContainer).TypeHandle)), Array.Empty<ISyntaxNode>());
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		return new PropertyValueContainer<WorkflowFormsContainer>(new WorkflowFormsContainer());
	}

	public WorkflowFormsContainerTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vXhhyg8rBrSXy2jxtnj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowFormsContainerTypeDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
				{
					num2 = 0;
				}
				break;
			default:
				UID = new Guid((string)pLeZjl8eJC2yjWjAuQg(-935313063 ^ -935307599));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object D0vWfn8oNBfAtgBw4bv(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool FwTiaO87sJuWKnpBGX9()
	{
		return mWuo1L8GHk1Qv8VJhFK == null;
	}

	internal static WorkflowFormsContainerTypeDescriptor LEju6b82PwZPCn8Tgw8()
	{
		return mWuo1L8GHk1Qv8VJhFK;
	}

	internal static Type Vh4Qyw8FTHO69hor27O(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object pmYY8a8iEQIniL03Wxg(Type P_0)
	{
		return P_0.CreateTypeSyntax();
	}

	internal static object aac9yY8IwVlV84fpIs9(object P_0, object P_1)
	{
		return ((ISyntaxNode)P_0).ObjectCreationExpression((ISyntaxNode[])P_1);
	}

	internal static bool lexd2a8acil0o67M5rM(object P_0)
	{
		return ((TypeDescriptor)P_0).Visible;
	}

	internal static void vXhhyg8rBrSXy2jxtnj()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object pLeZjl8eJC2yjWjAuQg(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
