using System;
using EleWise.ELMA.Model.MetadataEdit;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Models;

public sealed class UIItemModel : UIModel, IUIItemModel, IUIModuleModel, IUIModel, IUIHeadedModel, IUIGroupedModel
{
	public Guid Uid { get; set; }

	public Guid ModuleUid { get; set; }

	public Guid GroupUid { get; set; }

	public Guid HeaderUid { get; set; }
}
