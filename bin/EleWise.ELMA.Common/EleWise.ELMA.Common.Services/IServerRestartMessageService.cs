using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Common.Services;

[DeveloperApi(DeveloperApiType.Service)]
public interface IServerRestartMessageService
{
	IEnumerable<InformationChannelInfo> GetInformationChannelInfo();

	IEnumerable<InformationChannelInfo> GetInformationChannelInfo(IEnumerable<long> channels);

	long? SendMessage(IEnumerable<long> channels, long sender, string subject, string message, ScheduledRestart entry);
}
