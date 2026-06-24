using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.DTO;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.Models;

[Serializable]
public class WorkflowMessageTypeDTO : EntityDTO<long>
{
	private static WorkflowMessageTypeDTO ISlvRY9vF6nLmVfwUmb;

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
				case 0:
					return;
				case 1:
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_6ee07aa726964a2281f0ce81cd001aec != 0)
					{
						num2 = 0;
					}
					break;
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
				case 0:
					return;
				case 1:
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1bd128a8000b4a92bbfa94dfdfc79104 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool ReliableDelivery
	{
		[CompilerGenerated]
		get
		{
			return _003CReliableDelivery_003Ek__BackingField;
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
					_003CReliableDelivery_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_122c98752b3a49d0ab2b48b3f7a3ed7e == 0)
					{
						num2 = 0;
					}
					break;
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
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<WorkflowMessageTypeParameterDTO> Parameters { get; set; }

	public bool IsDeleted
	{
		[CompilerGenerated]
		get
		{
			return _003CIsDeleted_003Ek__BackingField;
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
					_003CIsDeleted_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowMessageTypeDTO()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0307c0add07f4a1a96da2f3cd63aa8fa == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Parameters = new List<WorkflowMessageTypeParameterDTO>();
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public WorkflowMessageTypeDTO(WorkflowMessageTypeDTO obj)
	{
		//Discarded unreachable code: IL_001a
		KmPfqj99fb4lt1ehkEq();
		base._002Ector();
		int num = 8;
		WorkflowMessageTypeDTO workflowMessageTypeDTO = default(WorkflowMessageTypeDTO);
		while (true)
		{
			switch (num)
			{
			case 3:
				IsDeleted = FZQGf99SVXKpwA1wPl9(workflowMessageTypeDTO);
				num = 7;
				break;
			case 7:
				return;
			default:
				workflowMessageTypeDTO = obj;
				num = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bbeafe91b1c448baa8c5cf2ab0baaadd == 0)
				{
					num = 0;
				}
				break;
			case 6:
				ReliableDelivery = Oau8SK9jv3BF3mT6XpV(workflowMessageTypeDTO);
				num = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1f93f2934a244aa9a51974d0e91035bb != 0)
				{
					num = 2;
				}
				break;
			case 2:
				Parameters = new List<WorkflowMessageTypeParameterDTO>();
				num = 5;
				break;
			case 8:
				n66rvN9cUeBhbC9f9i4(obj != null, BTmUKf9TUZnYhOHMbDf(-1643416224 ^ -1643439578));
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb == 0)
				{
					num = 0;
				}
				break;
			case 1:
			{
				Name = (string)VNuhbW9N3yTEA3lL36d(workflowMessageTypeDTO);
				int num2 = 4;
				num = num2;
				break;
			}
			case 4:
				Description = (string)gUFFkj9dWMq4o3ZRq8l(workflowMessageTypeDTO);
				num = 6;
				break;
			case 5:
				workflowMessageTypeDTO.Parameters.ForEach(delegate(WorkflowMessageTypeParameterDTO item)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							Parameters.Add(new WorkflowMessageTypeParameterDTO(item));
							num4 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0c2830bb8fb347508ec492b48872fee7 == 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num = 3;
				break;
			}
		}
	}

	public override void CopyChanges(EntityDTO<long> saved)
	{
		Contract.CheckArgument(saved is WorkflowMessageTypeDTO, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4CBDA8D5 ^ 0x4CBDC751));
		base.CopyChanges(saved);
		WorkflowMessageTypeDTO workflowMessageTypeDTO = (WorkflowMessageTypeDTO)saved;
		Name = workflowMessageTypeDTO.Name;
		Description = workflowMessageTypeDTO.Description;
		ReliableDelivery = workflowMessageTypeDTO.ReliableDelivery;
		IsDeleted = workflowMessageTypeDTO.IsDeleted;
	}

	public override string ToString()
	{
		return Name;
	}

	internal static bool sPwXBs9P3oEWPaK5WyX()
	{
		return ISlvRY9vF6nLmVfwUmb == null;
	}

	internal static WorkflowMessageTypeDTO nmD1wI94Yxi91MRPWJp()
	{
		return ISlvRY9vF6nLmVfwUmb;
	}

	internal static void KmPfqj99fb4lt1ehkEq()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static object BTmUKf9TUZnYhOHMbDf(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void n66rvN9cUeBhbC9f9i4(bool P_0, object P_1)
	{
		Contract.CheckArgument(P_0, (string)P_1);
	}

	internal static object VNuhbW9N3yTEA3lL36d(object P_0)
	{
		return ((WorkflowMessageTypeDTO)P_0).Name;
	}

	internal static object gUFFkj9dWMq4o3ZRq8l(object P_0)
	{
		return ((WorkflowMessageTypeDTO)P_0).Description;
	}

	internal static bool Oau8SK9jv3BF3mT6XpV(object P_0)
	{
		return ((WorkflowMessageTypeDTO)P_0).ReliableDelivery;
	}

	internal static bool FZQGf99SVXKpwA1wPl9(object P_0)
	{
		return ((WorkflowMessageTypeDTO)P_0).IsDeleted;
	}
}
