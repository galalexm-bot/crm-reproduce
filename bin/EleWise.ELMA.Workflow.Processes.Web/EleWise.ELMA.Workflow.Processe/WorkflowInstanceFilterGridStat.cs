using System;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Workflow.Processes.Web.Extensions;

public class WorkflowInstanceFilterGridStateProvider : FilterGridStateProvider
{
	public new static Guid UID = new Guid("{A8600F08-E194-4BAC-A284-329E3D02A026}");

	public override Guid Uid => UID;

	public override bool OnRefresh(GridState state, string data)
	{
		return WorkflowInstanceGridStateProvider.RefreshState(state, data);
	}
}
