using System;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.DTO.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.DTO.Models;

public class ReferenceActivityFolder : ReferenceActivity
{
	internal static ReferenceActivityFolder iNnPU24y5VfHmFZ2O4l;

	public ReferenceActivityFolder(CustomActivityFolderDTO dto)
	{
		//Discarded unreachable code: IL_003c, IL_0041
		Vt9Ne64RHBUPfNNMMqX();
		base._002Ector(InterfaceActivator.UID<ICustomActivityFolder>(loadImplementation: false), dto.Uid, dto.Id);
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 == 0)
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
		return wrPAyD40bxpxF9KPLQ9(Locator.GetService<ICustomActivityFolderDTOManager>(), base.EntityUid);
	}

	internal static void Vt9Ne64RHBUPfNNMMqX()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool AjUNGB4O84m5ooHCUtd()
	{
		return iNnPU24y5VfHmFZ2O4l == null;
	}

	internal static ReferenceActivityFolder wI7E5w46mRMy3mG4ZOm()
	{
		return iNnPU24y5VfHmFZ2O4l;
	}

	internal static object wrPAyD40bxpxF9KPLQ9(object P_0, Guid uid)
	{
		return ((ICustomActivityFolderDTOManager)P_0).LoadOrNull(uid);
	}
}
