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

public class ProcessMetricValuesTypeDescriptor : CLRTypeDescriptor<WorkflowProcessMetricValues, ProcessMetricValuesTypeSettings>
{
	public const string UID_S = "{CEA4BD40-6BE1-4F9B-B3C5-6954EF367051}";

	public static readonly Guid UID;

	private static ProcessMetricValuesTypeDescriptor j9yPiVsEsmt1HRXkpvR;

	public override Guid Uid => UID;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => SR.T((string)IrPn2mszlw49bka1aEM(0x1C663DA1 ^ 0x1C6621D1));

	public override bool HasPropertySetter => false;

	public override bool Visible
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
				case 1:
					if (!O28AhuJObPX1DTb2wyF(this))
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (MetadataAccessInfo.EnvironmentType != MetadataEnvironmentType.VisualStudio)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				return true;
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
			case 1:
				F6XF7TJKK8gQW9Ujydn(propertyMetadata, IrPn2mszlw49bka1aEM(--296112178 ^ 0x11A64AFE));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new WorkflowProcessMetricValuesValueContainer();
			}
		}
	}

	public ProcessMetricValuesTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zXnuyyJZ6QDlwSs2Ugc();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ProcessMetricValuesTypeDescriptor()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				zXnuyyJZ6QDlwSs2Ugc();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				UID = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862323486));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object IrPn2mszlw49bka1aEM(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool jR3JsUswflGH6mvYJY2()
	{
		return j9yPiVsEsmt1HRXkpvR == null;
	}

	internal static ProcessMetricValuesTypeDescriptor YDWa9Hs4o2gj8DHvx2b()
	{
		return j9yPiVsEsmt1HRXkpvR;
	}

	internal static void F6XF7TJKK8gQW9Ujydn(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool O28AhuJObPX1DTb2wyF(object P_0)
	{
		return ((TypeDescriptor)P_0).Visible;
	}

	internal static void zXnuyyJZ6QDlwSs2Ugc()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
