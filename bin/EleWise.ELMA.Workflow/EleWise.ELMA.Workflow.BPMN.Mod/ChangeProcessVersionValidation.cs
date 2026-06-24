using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.Validation;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Models;

public class ChangeProcessVersionValidationResult
{
	internal static ChangeProcessVersionValidationResult s1wpZcOGnPbq9yfQWZ0K;

	public IList<ProcessValidationMessage> Messages { get; set; }

	public IList<SwimlaneChangeInfo> ChangedSwimlanes { get; set; }

	public IEnumerable<PropertyMetadata> AddedProperties { get; set; }

	public IEnumerable<PropertyMetadata> RemovedProperties { get; set; }

	public bool HasCriticalIssues => Messages.Any((ProcessValidationMessage m) => _003C_003Ec.LZLvOhvlUwNurY3SwgS8(m) == ProcessValidationMessageType.Error);

	public ChangeProcessVersionValidationResult()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jHwLd6OGfp95ZnSyY9ug();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 4:
				ChangedSwimlanes = new List<SwimlaneChangeInfo>();
				num = 3;
				break;
			case 2:
				RemovedProperties = Enumerable.Empty<PropertyMetadata>();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
				{
					num = 0;
				}
				break;
			case 3:
				AddedProperties = Enumerable.Empty<PropertyMetadata>();
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
				{
					num = 2;
				}
				break;
			case 0:
				return;
			case 1:
				Messages = new List<ProcessValidationMessage>();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
				{
					num = 4;
				}
				break;
			}
		}
	}

	internal static void jHwLd6OGfp95ZnSyY9ug()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool Sg6DcQOGHSt2EH20esMM()
	{
		return s1wpZcOGnPbq9yfQWZ0K == null;
	}

	internal static ChangeProcessVersionValidationResult E4KemuOGL0SmtFB8DEBj()
	{
		return s1wpZcOGnPbq9yfQWZ0K;
	}
}
