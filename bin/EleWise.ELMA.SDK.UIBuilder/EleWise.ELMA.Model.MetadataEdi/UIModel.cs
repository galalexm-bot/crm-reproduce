using System;
using EleWise.ELMA.UIBuilder.MetadataEdit.Models;

namespace EleWise.ELMA.Model.MetadataEdit;

public class UIModel : IUIModel
{
	public Guid TypeUid { get; set; }

	public string Name { get; set; }

	public string DisplayName { get; set; }

	public string Description { get; set; }
}
