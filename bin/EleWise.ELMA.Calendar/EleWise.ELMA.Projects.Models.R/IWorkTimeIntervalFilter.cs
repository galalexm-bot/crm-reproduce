using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Projects.Models.Resources;

[FilterFor(typeof(IWorkTimeInterval))]
public interface IWorkTimeIntervalFilter : IEntityFilter
{
}
