using Orchard.Environment.Extensions.Models;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class ModuleFeature
{
	public FeatureDescriptor Descriptor { get; set; }

	public bool IsEnabled { get; set; }

	public bool NeedsUpdate { get; set; }
}
