using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Workflow.Models;

[FilterFor(typeof(ICustomActivity))]
public interface ICustomActivityFilter : IEntityFilter
{
}
