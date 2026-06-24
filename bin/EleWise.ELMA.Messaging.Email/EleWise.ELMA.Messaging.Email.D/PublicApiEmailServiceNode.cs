using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.CodeGeneration.PublicApi;

namespace EleWise.ELMA.Messaging.Email.DynamicApi;

[Component(Order = 20)]
internal class PublicApiEmailServiceNode : IPublicApiNodeProvider
{
	public IEnumerable<IPublicApiNode> CreatePublicApiNodes()
	{
		return PublicApiNodeServicesProvider.Services(typeof(EmailSender));
	}
}
