using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Documents.Models.Folders;

[FilterFor(typeof(IActionFolder))]
public interface IActionFolderFilter : IDmsObjectFilter, IEntityFilter
{
	string ActionTypeProviderId { get; set; }

	string ActionId { get; set; }
}
