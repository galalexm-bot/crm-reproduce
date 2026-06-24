using System;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Models;

public interface IUIGroupedModel : IUIModel
{
	Guid GroupUid { get; set; }
}
