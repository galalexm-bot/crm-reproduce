using System;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Models;

public interface IUIModel
{
	Guid TypeUid { get; set; }

	string Name { get; set; }

	string DisplayName { get; set; }

	string Description { get; set; }
}
