using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogReportItem : WorkLogObject
{
	public bool IsEmpty
	{
		get
		{
			if (Id.HasValue)
			{
				if (base.ObjectUid == Guid.Empty && base.ObjectId == 0L && (!FactWorkTime.HasValue || FactWorkTime.Value.TotalMinutes == 0L) && Activity == null)
				{
					return string.IsNullOrEmpty(Description);
				}
				return false;
			}
			return true;
		}
	}

	public long? Id { get; set; }

	public Guid? Uid { get; set; }

	public IWorkLogActivity Activity { get; set; }

	public WorkTime? FactWorkTime { get; set; }

	[StringSettings(MultiLine = true, FieldName = "Text", MaxValueString = "2000")]
	public string Description { get; set; }

	public bool IsDelete { get; set; }

	public string WorkLogIdList { get; set; }

	public bool HasWorkLogItem { get; set; }

	public bool Select { get; set; }

	public IEntity Object { get; set; }

	public WorkTime PlanWorkTime
	{
		get
		{
			if (!IsEmpty && Object != null)
			{
				WorkTime? workTime = WorkLogHelper.PlanWorkLog(Object);
				if (workTime.HasValue)
				{
					return workTime.Value;
				}
			}
			return new WorkTime(0);
		}
	}

	public List<string> OvertimeDescriptions { get; set; }

	public WorkLogReportItem()
	{
		FactWorkTime = new WorkTime(0);
		OvertimeDescriptions = new List<string>();
	}
}
