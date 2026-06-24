using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogItemViewModel : EntityModel<IWorkLogItem>
{
	public bool IsSelect { get; set; }

	public IEntity Object
	{
		get
		{
			if (base.Entity != null && Extension() != null)
			{
				return WorkLogExtensionHelper.LoadObject(base.Entity.ObjectId, base.Entity.ObjectUID);
			}
			return null;
		}
	}

	public WorkTime PlanWorkTime
	{
		get
		{
			if (base.Entity != null)
			{
				IWorkLogExtension workLogExtension = Extension();
				if (workLogExtension != null)
				{
					WorkTime? workTime = workLogExtension.PlanWorkLog(base.Entity);
					if (workTime.HasValue)
					{
						return workTime.Value;
					}
				}
			}
			return new WorkTime(0);
		}
	}

	public WorkTime FactWorkTime
	{
		get
		{
			if (base.Entity != null && base.Entity.FactWorkTime.HasValue)
			{
				return base.Entity.FactWorkTime.Value;
			}
			return new WorkTime(0);
		}
	}

	public WorkTime ApprovalWorkTime { get; set; }

	public bool HasWorkLogItem { get; set; }

	public WorkLogItemViewModel()
	{
	}

	public WorkLogItemViewModel(IWorkLogItem workLogItem)
	{
		base.Entity = workLogItem;
	}

	public IWorkLogExtension Extension()
	{
		if (base.Entity != null)
		{
			return WorkLogExtensionHelper.FindExtensionByObjectUid(base.Entity.ObjectUID);
		}
		return null;
	}

	public bool Overtime()
	{
		return WorkLogHelper.WorkLogItemOvertime(base.Entity);
	}
}
