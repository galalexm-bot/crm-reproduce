using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Tasks.Models;

[FilterFor(typeof(IQuestion))]
public interface IQuestionFilter : ITaskBaseFilter, IEntityFilter
{
}
