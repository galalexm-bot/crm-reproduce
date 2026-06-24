using System;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.DTO.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.DTO.Models;

public class ReferenceCustomActivity : ReferenceActivity
{
	internal static ReferenceCustomActivity XnZGVn4mJjeedSCSDsF;

	public ReferenceCustomActivity(CustomActivityDTO dto)
	{
		//Discarded unreachable code: IL_003c, IL_0041
		iTQbNb4Gf6EURarLMTg();
		base._002Ector(InterfaceActivator.UID<ICustomActivity>(loadImplementation: false), Luqusp4nC1PRNpNqSM2(dto), dto.Id);
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3c90beae50bc45bbb9c4179594d556e4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override object Resolve()
	{
		return Locator.GetService<ICustomActivityDTOManager>().LoadOrNull(base.EntityUid);
	}

	internal static void iTQbNb4Gf6EURarLMTg()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static Guid Luqusp4nC1PRNpNqSM2(object P_0)
	{
		return ((CustomActivityDTO)P_0).Uid;
	}

	internal static bool XIpvlP4AagYqxw8Wyhy()
	{
		return XnZGVn4mJjeedSCSDsF == null;
	}

	internal static ReferenceCustomActivity HvBi1h4pcDnSfLIiWUX()
	{
		return XnZGVn4mJjeedSCSDsF;
	}
}
