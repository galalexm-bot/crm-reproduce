using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Types.Container;
using EleWise.ELMA.Workflow.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Types;

public class InstanceMetricValuesTypeDescriptor : CLRTypeDescriptor<WorkflowInstanceMetricValues, InstanceMetricValuesTypeSettings>
{
	public const string UID_S = "{67F4ED16-986E-40CB-9D41-A3C060857569}";

	public static readonly Guid UID;

	internal static InstanceMetricValuesTypeDescriptor lhvfeGs3SArFXnRLhma;

	public override Guid Uid => UID;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => (string)XJG5ADsCOl0eVoEe5xX(OLnOd9spsn6euBGrpEP(0x5F800F5B ^ 0x5F8015D9));

	public override bool HasPropertySetter => false;

	public override bool Visible
	{
		get
		{
			//Discarded unreachable code: IL_0031, IL_0040
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
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
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

	protected override void CreatePropertyMapping(INHibernatePropertiesMapper mappingBuilder, ClassMetadata classMetadata, EntityPropertyMetadata entityPropertyMetadata)
	{
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		throw new NotImplementedException();
	}

	public override TypeDbStructures GetDbStructures(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new TypeDbStructures();
	}

	public override bool ApplyDbChanges(IDbModelUpdater updater, EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata, EntityPropertyMetadata oldPropertyMetadata)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CGetPropertyGetterExpressions_003Ed__14))]
	public override IEnumerable<ISyntaxNode> GetPropertyGetterExpressions(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, string fieldName)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetPropertyGetterExpressions_003Ed__14(-2)
		{
			_003C_003E3__fieldName = fieldName
		};
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return new WorkflowInstanceMetricValuesValueContainer();
			case 1:
				seWUqQsM5CvSLSBjgvj(propertyMetadata, OLnOd9spsn6euBGrpEP(-39189604 ^ -39184048));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public InstanceMetricValuesTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		t7EoZ0skjh5u3x5iZYK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static InstanceMetricValuesTypeDescriptor()
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
				t7EoZ0skjh5u3x5iZYK();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				UID = new Guid((string)OLnOd9spsn6euBGrpEP(-1647793954 ^ -1647791570));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object OLnOd9spsn6euBGrpEP(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object XJG5ADsCOl0eVoEe5xX(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool LtwEuqsTURLgQxmuw49()
	{
		return lhvfeGs3SArFXnRLhma == null;
	}

	internal static InstanceMetricValuesTypeDescriptor KKJJuQsQo08PTRfLPpC()
	{
		return lhvfeGs3SArFXnRLhma;
	}

	internal static void seWUqQsM5CvSLSBjgvj(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void t7EoZ0skjh5u3x5iZYK()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
