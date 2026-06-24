using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogActivityModel : EntityModel<IWorkLogActivity>
{
	public string ObjectTypeUids { get; set; }

	public WorkLogActivityModel()
	{
	}

	public WorkLogActivityModel(IWorkLogActivity workLogActivity)
	{
		base.Entity = workLogActivity;
		ObjectTypeUids = string.Join(",", ((IEnumerable<IWorkLogActivityObjectType>)workLogActivity.ObjectsUIDs).Select((IWorkLogActivityObjectType o) => o.ObjectUID.TypeUid.ToString().Trim("{}".ToCharArray())));
	}
}
