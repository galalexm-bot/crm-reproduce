using System.Threading;
using EleWise.ELMA.Api.Services.Internal;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.Services;

[Service]
internal sealed class UpdateSessionService : IUpdateSessionService
{
	private readonly IServerVersionInfoService serverInfoService;

	private readonly IApplicationData applicationData;

	private bool needUpdate = true;

	private readonly Timer timer;

	private int updatePeriod = 60000;

	public UpdateSessionService(IServerVersionInfoService serverInfoService, IApplicationData applicationData)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		this.serverInfoService = serverInfoService;
		this.applicationData = applicationData;
		if (applicationData.InterfaceBuilderMode != InterfaceBuilderMode.DevServer)
		{
			timer = new Timer(new TimerCallback(UpdateSession), (object)null, updatePeriod, updatePeriod);
		}
	}

	public void SetNeedUpdate(bool flag)
	{
		needUpdate = flag;
	}

	private void UpdateSession(object state)
	{
		if (needUpdate)
		{
			serverInfoService.UpdateSession();
		}
		needUpdate = true;
	}
}
