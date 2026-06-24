using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

[Serializable]
public abstract class RecipientInfoForNotification : IXsiType
{
	internal static RecipientInfoForNotification A7PTBlZtkiyDsgY6fjTV;

	public object RecipientValue
	{
		[CompilerGenerated]
		get
		{
			return _003CRecipientValue_003Ek__BackingField;
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
					_003CRecipientValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public abstract IEnumerable<object> GetRecipients(IWorkflowInstance instance);

	protected RecipientInfoForNotification()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool f9wON9ZtUvblMOxj1mRj()
	{
		return A7PTBlZtkiyDsgY6fjTV == null;
	}

	internal static RecipientInfoForNotification IEOxrmZtVj5ZGGpfjVW6()
	{
		return A7PTBlZtkiyDsgY6fjTV;
	}
}
