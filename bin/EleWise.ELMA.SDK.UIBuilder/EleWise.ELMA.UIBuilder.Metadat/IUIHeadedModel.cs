using System;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Models;

public interface IUIHeadedModel : IUIModel
{
	Guid HeaderUid { get; set; }
}
