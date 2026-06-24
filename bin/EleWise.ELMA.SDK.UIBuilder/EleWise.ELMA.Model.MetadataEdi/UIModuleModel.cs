using System.Collections.Generic;
using EleWise.ELMA.UIBuilder.MetadataEdit.Models;

namespace EleWise.ELMA.Model.MetadataEdit;

public sealed class UIModuleModel : UIModel, IUIEditionsModel, IUIModel
{
	public IEnumerable<string> Editions { get; set; }
}
