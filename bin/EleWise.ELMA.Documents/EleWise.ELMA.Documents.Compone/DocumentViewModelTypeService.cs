using EleWise.ELMA.Components;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.Documents.Components;

internal sealed class DocumentViewModelTypeService : ViewModelTypeService
{
	public const string MetadataTypeCode = "Document";

	public override bool Check(string metadataTypeCode)
	{
		return metadataTypeCode == "Document";
	}

	public override ViewModelTypeName GetViewModelType(string metadataName, string metadataNamespace, bool useOriginalModel)
	{
		if (useOriginalModel)
		{
			return new ViewModelTypeName("DocumentInfo", "EleWise.ELMA.Documents.Web.Models");
		}
		return base.GetViewModelType(metadataName, metadataNamespace, useOriginalModel);
	}
}
