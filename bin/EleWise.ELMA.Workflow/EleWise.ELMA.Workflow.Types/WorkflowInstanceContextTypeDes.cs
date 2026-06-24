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

public class WorkflowInstanceContextTypeDescriptor : CLRTypeDescriptor<WorkflowInstanceContext, WorkflowInstanceContextTypeSettings>
{
	public const string UID_S = "{B8596385-A65E-4007-891D-836F78022FBD}";

	public static readonly Guid UID;

	internal static WorkflowInstanceContextTypeDescriptor LlkLWFJGfA64VGOlMXL;

	public override Guid Uid => UID;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => (string)AO7SJaJFviUNkiv7SlH(R1E3TvJoHdW18uWIxjg(-1303601216 ^ -1303608900));

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
				case 1:
					if (base.Visible)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
						{
							num2 = 0;
						}
						break;
					}
					return false;
				case 2:
					return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
				default:
					if (MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.VisualStudio)
					{
						return true;
					}
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
					{
						num2 = 1;
					}
					break;
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

	[IteratorStateMachine(typeof(_003CGetPropertyGetterExpressions_003Ed__12))]
	public override IEnumerable<ISyntaxNode> GetPropertyGetterExpressions(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, string fieldName)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetPropertyGetterExpressions_003Ed__12(-2)
		{
			_003C_003E3__fieldName = fieldName
		};
	}

	[IteratorStateMachine(typeof(_003CGetPropertySetterExpressions_003Ed__13))]
	public override IEnumerable<ISyntaxNode> GetPropertySetterExpressions(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, string fieldName)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetPropertySetterExpressions_003Ed__13(-2)
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
				return new WorkflowInstanceContextValueContainer();
			case 1:
				qN4FSDJiOCbBUXvJ16a(propertyMetadata, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6CC04061 ^ 0x6CC05AAD));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public WorkflowInstanceContextTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowInstanceContextTypeDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				gK294LJI3Ib9j92dCwW();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				UID = new Guid((string)R1E3TvJoHdW18uWIxjg(0x63D6C913 ^ 0x63D6D7AB));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static object R1E3TvJoHdW18uWIxjg(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object AO7SJaJFviUNkiv7SlH(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool cBXhcqJ7IIhKxB3q6cK()
	{
		return LlkLWFJGfA64VGOlMXL == null;
	}

	internal static WorkflowInstanceContextTypeDescriptor h62ZcmJ2b5Ijm6fZuiA()
	{
		return LlkLWFJGfA64VGOlMXL;
	}

	internal static void qN4FSDJiOCbBUXvJ16a(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void gK294LJI3Ib9j92dCwW()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
