using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Workflow.Models;

[FilterFor(typeof(ICustomActivityHeader))]
public interface ICustomActivityHeaderFilter : IEntityFilter
{
	[Uid("23a28039-1297-4836-a78f-e9c8ce3bce29")]
	string Name { get; set; }
}
