using System.Collections.Generic;
using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.Web.Services;

public interface IMessageSendHistoryService
{
	List<IInformationChannel> Get();

	void Add(List<IInformationChannel> channels);
}
