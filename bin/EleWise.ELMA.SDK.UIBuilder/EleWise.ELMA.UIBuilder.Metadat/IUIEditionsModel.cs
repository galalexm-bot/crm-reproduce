using System.Collections.Generic;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Models;

public interface IUIEditionsModel : IUIModel
{
	IEnumerable<string> Editions { get; set; }
}
