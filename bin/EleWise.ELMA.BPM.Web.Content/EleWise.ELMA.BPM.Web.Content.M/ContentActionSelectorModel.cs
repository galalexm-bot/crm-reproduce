using System.Collections.Generic;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class ContentActionSelectorModel
{
	public IEnumerable<ILinkTypeProvider> LinkTypeProviders { get; set; }
}
