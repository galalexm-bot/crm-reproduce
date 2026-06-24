using EleWise.ELMA.Packaging;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class PackagesGridData : GridData<PackageDescription>
{
	public bool HasUpdates { get; set; }

	public PackagesActionInfo ActionInfo { get; set; }

	public PackageFilter DataFilter { get; set; }
}
