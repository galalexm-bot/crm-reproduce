using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Messaging;

[ExtensionPoint(ComponentType.WebServer)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IMessageChannel
{
	Guid Uid { get; }

	string Name { get; }

	string DisplayName { get; }

	bool Default { get; }

	void Send(IMessage message);
}
