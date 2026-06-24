using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Extensions;

public class WorkflowInstanceGridStateProvider : GridStateProvider
{
	public static readonly Guid UID = new Guid("{FC09280E-4F7E-40EB-B909-D1774CFB4F47}");

	public override Guid Uid => UID;

	public override bool OnRefresh(GridState state, string data)
	{
		return RefreshState(state, data);
	}

	public static bool RefreshState(GridState state, string data)
	{
		if (string.IsNullOrEmpty(data))
		{
			return false;
		}
		IProcessHeader processHeader = ProcessHeaderManager.Instance.Load(long.Parse(data));
		EntityMetadata metadata = WorkflowInstanceContextService.Instance.GetInstanceContextMetadata(processHeader.Published);
		List<Guid> availablePropertyUids = Locator.GetServiceNotNull<WorkflowProcessManager>().GetVisiblePropertyUids(processHeader.Published);
		if (availablePropertyUids == null)
		{
			return false;
		}
		List<string> availableNames = (from uid in availablePropertyUids
			select metadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == uid) into p
			where p != null
			select p.Name).ToList();
		Guid result;
		IEnumerable<ColumnState> source = state.ColumnStates.Where((ColumnState c) => (state.CustomColumns == null || state.CustomColumns.All((CustomColumnDescriptor cc) => cc.UniqueName != c.UniqueName)) && ((!Guid.TryParse(c.UniqueName, out result)) ? (!availableNames.Contains(c.UniqueName)) : (!availablePropertyUids.Contains(result))));
		if (source.Any())
		{
			state.ColumnStates.RemoveAll(source.ToList());
			return true;
		}
		return false;
	}
}
