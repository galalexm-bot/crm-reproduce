using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Tasks.API.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.API.Models;

[Serializable]
[DataContract(Name = "WorkflowTaskPackage")]
public class WorkflowTaskPackage : TaskBasePackage
{
	internal static WorkflowTaskPackage kxfUEyZHYmv6pmmYQVUu;

	[DataMember]
	public WorkflowTaskWCF Data
	{
		[CompilerGenerated]
		get
		{
			return _003CData_003Ek__BackingField;
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
					_003CData_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowTaskPackage(Guid typeUid)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		jTdPhqZHJbUqJmCQFHXb();
		base._002Ector(typeUid);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override long GetId()
	{
		return TdbvcbZHl0PYt4QZG6Z5(Data);
	}

	internal static void jTdPhqZHJbUqJmCQFHXb()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool WpYmUqZH8kMs9FUp8cPu()
	{
		return kxfUEyZHYmv6pmmYQVUu == null;
	}

	internal static WorkflowTaskPackage XucXoOZHshMWRCrTUqTD()
	{
		return kxfUEyZHYmv6pmmYQVUu;
	}

	internal static long TdbvcbZHl0PYt4QZG6Z5(object P_0)
	{
		return ((TaskBaseWCF)P_0).Id;
	}
}
