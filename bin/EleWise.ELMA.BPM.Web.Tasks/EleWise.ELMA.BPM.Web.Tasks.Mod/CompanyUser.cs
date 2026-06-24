using EleWise.ELMA.KPI.Models.Performance;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class CompanyUser
{
	public IUser User { get; set; }

	public KeyIndicator KeyFeature { get; set; }

	public Pair<long, long> NumTasks { get; set; }

	public Pair<long, long> WorkLog { get; set; }

	public PerformanceDiscipline PerformanceDiscipline { get; set; }
}
