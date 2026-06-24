using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.Tasks.Models;

[FilterFor(typeof(IWorkLog))]
public interface IWorkLogFilter : IEntityFilter
{
	ITaskBase TaskBase { get; set; }

	DateTimeRange CreationDate { get; set; }

	IWorkLogItem WorkLogItem { get; set; }
}
