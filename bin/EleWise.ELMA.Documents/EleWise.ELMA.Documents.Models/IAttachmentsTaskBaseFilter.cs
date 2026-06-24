using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Documents.Models;

[FilterFor(typeof(IAttachmentsTaskBase))]
public interface IAttachmentsTaskBaseFilter : ITaskBaseFilter, IEntityFilter
{
}
