using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.DTO;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.Models;

[Serializable]
public class WorkflowMessageTypeParameterDTO : EntityDTO<long>
{
	public static readonly Guid OperandType;

	internal static WorkflowMessageTypeParameterDTO tQDuDn9krHqMpeAxxbZ;

	public Guid Uid
	{
		[CompilerGenerated]
		get
		{
			return _003CUid_003Ek__BackingField;
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
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b != 0)
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
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c3ae8e111f574ce9b09d9ed725c1ab53 != 0)
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

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return _003CDescription_003Ek__BackingField;
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
					_003CDescription_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9747bbf97f854087a2d2f13ea94f4085 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsControlValue
	{
		[CompilerGenerated]
		get
		{
			return _003CIsControlValue_003Ek__BackingField;
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
					_003CIsControlValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_19817a6c27b8478eb2c8f07b7fca8477 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowMessageTypeParameterDTO()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WYOLBh9m1397qpHCu7M();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public WorkflowMessageTypeParameterDTO(WorkflowMessageTypeParameterDTO obj)
	{
		//Discarded unreachable code: IL_002a
		WYOLBh9m1397qpHCu7M();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 == 0)
		{
			num = 1;
		}
		WorkflowMessageTypeParameterDTO workflowMessageTypeParameterDTO = default(WorkflowMessageTypeParameterDTO);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
			{
				workflowMessageTypeParameterDTO = obj;
				int num2 = 5;
				num = num2;
				break;
			}
			case 4:
				IsControlValue = nh0g7t9y3L7NSOt5gpA(workflowMessageTypeParameterDTO);
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2180cded74a649d583efc1ab91959551 == 0)
				{
					num = 0;
				}
				break;
			case 5:
				Name = (string)wpWjNf9GCkVfRbFol55(workflowMessageTypeParameterDTO);
				num = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1b80284ddf044221848555b8c08e8f67 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				wgI5yD9phZtHpqBwyLh(obj != null, Bomc7h9AqrXj6LoCY16(0x3C126B81 ^ 0x3C120447));
				num = 2;
				break;
			case 0:
				return;
			case 3:
				Description = (string)HYc74e9nNyLqd3Csys3(workflowMessageTypeParameterDTO);
				num = 4;
				break;
			}
		}
	}

	public override void CopyChanges(EntityDTO<long> saved)
	{
		Contract.CheckArgument(saved is WorkflowMessageTypeParameterDTO, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x32F3F75 ^ 0x32F4F63));
		base.CopyChanges(saved);
		WorkflowMessageTypeParameterDTO workflowMessageTypeParameterDTO = (WorkflowMessageTypeParameterDTO)saved;
		Name = workflowMessageTypeParameterDTO.Name;
		Description = workflowMessageTypeParameterDTO.Description;
	}

	static WorkflowMessageTypeParameterDTO()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				OperandType = new Guid((string)Bomc7h9AqrXj6LoCY16(0x82E000E ^ 0x82E7064));
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_51bbd8978ad84af991914149de98c8c6 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0c2830bb8fb347508ec492b48872fee7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool k3Li159biGatwMi1NVO()
	{
		return tQDuDn9krHqMpeAxxbZ == null;
	}

	internal static WorkflowMessageTypeParameterDTO R7Rl6M9UsWXl6PTqToS()
	{
		return tQDuDn9krHqMpeAxxbZ;
	}

	internal static void WYOLBh9m1397qpHCu7M()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static object Bomc7h9AqrXj6LoCY16(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void wgI5yD9phZtHpqBwyLh(bool P_0, object P_1)
	{
		Contract.CheckArgument(P_0, (string)P_1);
	}

	internal static object wpWjNf9GCkVfRbFol55(object P_0)
	{
		return ((WorkflowMessageTypeParameterDTO)P_0).Name;
	}

	internal static object HYc74e9nNyLqd3Csys3(object P_0)
	{
		return ((WorkflowMessageTypeParameterDTO)P_0).Description;
	}

	internal static bool nh0g7t9y3L7NSOt5gpA(object P_0)
	{
		return ((WorkflowMessageTypeParameterDTO)P_0).IsControlValue;
	}
}
