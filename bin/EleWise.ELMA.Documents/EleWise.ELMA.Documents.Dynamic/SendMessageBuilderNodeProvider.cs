using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Model.CodeGeneration.PublicApi;

namespace EleWise.ELMA.Documents.DynamicAPI;

[Component(Order = 20)]
internal class SendMessageBuilderNodeProvider : IPublicApiNodeProvider
{
	public IEnumerable<IPublicApiNode> CreatePublicApiNodes()
	{
		yield return new PublicApiCustomBuilderNode("Messages.Managers.SendMessageBuilderApi", typeof(SendMessageBuilder));
	}
}
