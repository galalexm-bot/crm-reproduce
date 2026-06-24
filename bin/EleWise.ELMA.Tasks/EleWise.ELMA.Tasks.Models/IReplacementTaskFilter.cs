using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Tasks.Models;

[FilterFor(typeof(IReplacementTask))]
public interface IReplacementTaskFilter : ITaskBaseFilter, IEntityFilter
{
	IReplacement Replacement { get; set; }

	IUser BlockedUser { get; set; }
}
