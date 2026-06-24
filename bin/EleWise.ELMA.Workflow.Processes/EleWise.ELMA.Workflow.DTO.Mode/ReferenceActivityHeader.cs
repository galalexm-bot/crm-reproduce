using System;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.DTO.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.DTO.Models;

public class ReferenceActivityHeader : ReferenceActivity
{
	internal static ReferenceActivityHeader wxh2iA4BV9TeM6iO98f;

	public ReferenceActivityHeader(CustomActivityHeaderDTO dto)
	{
		//Discarded unreachable code: IL_003c, IL_0041
		bagRHs4exjPKQPYAgxs();
		base._002Ector(InterfaceActivator.UID<ICustomActivityHeader>(loadImplementation: false), lT2PpZ4i0YgtfSi6YJB(dto), dto.Id);
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_98890646a18d4a91b352a4ea5d1be319 == 0)
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
		return Locator.GetService<ICustomActivityHeaderDTOManager>().LoadOrNull(base.EntityUid);
	}

	internal static void bagRHs4exjPKQPYAgxs()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static Guid lT2PpZ4i0YgtfSi6YJB(object P_0)
	{
		return ((CustomActivityHeaderDTO)P_0).Uid;
	}

	internal static bool nC3Pr74WcQgaE5NuCrL()
	{
		return wxh2iA4BV9TeM6iO98f == null;
	}

	internal static ReferenceActivityHeader nx7e2y4H7GHmPnGIp1X()
	{
		return wxh2iA4BV9TeM6iO98f;
	}
}
