using EleWise.ELMA.UIBuilder.MetadataEdit.DTO;
using EleWise.ELMA.UIBuilder.MetadataEdit.Models;

namespace EleWise.ELMA.Model.MetadataEdit.Services;

public interface IMetadataItemGroupUIService
{
	IExecutionResult<MetadataItemGroupUIDTO> Create(IUIItemModel iuiModel);

	void Delete(IUIItemModel iuiModel);

	IExecutionResult<MetadataItemGroupUIDTO> Edit(IUIItemModel iuiModel);

	IExecutionResult<MetadataItemGroupUIDTO[]> LoadGroups();
}
