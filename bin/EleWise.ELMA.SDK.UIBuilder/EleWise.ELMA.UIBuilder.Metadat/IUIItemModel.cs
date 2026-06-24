using System;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Models;

public interface IUIItemModel : IUIModuleModel, IUIModel, IUIHeadedModel, IUIGroupedModel
{
	Guid Uid { get; set; }
}
