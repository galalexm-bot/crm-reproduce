using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Plugins;

public class DocumentChangePermissionsInfo
{
	public enum RoleType
	{
		ContextVarUser,
		ContextVarGroup,
		ContextVarStructure,
		Group,
		Structure,
		Author
	}

	public enum ActionType
	{
		Add,
		Remove
	}

	public enum PermissionType
	{
		Load,
		Download,
		Edit,
		Issue,
		Full
	}

	private static DocumentChangePermissionsInfo wwN4S6ZsrGmwK1T0NIp0;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public Guid Documents
	{
		[CompilerGenerated]
		get
		{
			return _003CDocuments_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CDocuments_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public ActionType Action
	{
		[CompilerGenerated]
		get
		{
			return _003CAction_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CAction_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public PermissionType Permissions
	{
		[CompilerGenerated]
		get
		{
			return _003CPermissions_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CPermissions_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<DocumentChangePermissionsInfoRole> Roles { get; set; }

	public bool ApplyToRelated
	{
		[CompilerGenerated]
		get
		{
			return _003CApplyToRelated_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CApplyToRelated_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public DocumentChangePermissionsInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		i1B2loZsx70LY4AgPgu4();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool TSgd6cZseCuqCLc1V8hv()
	{
		return wwN4S6ZsrGmwK1T0NIp0 == null;
	}

	internal static DocumentChangePermissionsInfo zAhY2NZsN1jQ9RV9FHcD()
	{
		return wwN4S6ZsrGmwK1T0NIp0;
	}

	internal static void i1B2loZsx70LY4AgPgu4()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
