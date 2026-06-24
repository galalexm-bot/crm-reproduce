using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class ReAssignWorkLogItemModel : CommentWithAttachments
{
	public string WorkLogItems { get; set; }

	public IUser Harmonizator { get; set; }

	public ReAssignWorkLogItemModel()
	{
		base.PostAction = "ReAssign";
		base.PostController = "WorkLogItem";
		base.PostArea = "EleWise.ELMA.BPM.Web.Tasks";
	}

	public void SetWorkLogItemIds(List<long> ids)
	{
		WorkLogItems = string.Join(",", ids);
	}

	public List<long> GetWorkLogItemIds()
	{
		return (from m in WorkLogItems.Split(",".ToCharArray())
			select Convert.ToInt64(m)).ToList();
	}
}
