using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.Documents.Extensions;

[InterfaceExtension(typeof(IWorkLogObjectSearchFilter))]
public interface IDocumentWorkLogObjectSearchFilter : IWorkLogObjectSearchFilter, IAutoImplement, IEntityFilter
{
	[DisplayName(typeof(DocumentWorkLogItemSearchFilter_SR), "P_Document")]
	List<IDocument> Documents { get; set; }
}
