using System.Collections.Generic;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Models;

internal sealed class PacketActionArgs
{
	public IImportSettings ImportSettings { get; }

	public ICollection<IEntity> Entities { get; }

	public ICollection<DeployLogMessage> Messages { get; }

	public string ContentType { get; }

	public IDictionary<string, string> PacketData { get; }

	public IDictionary<string, string> ServiceData { get; }

	public PacketActionArgs(IImportSettings importSettings, ICollection<IEntity> entities, ICollection<DeployLogMessage> messages, string contentType, IDictionary<string, string> packetData, IDictionary<string, string> serviceData)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		ImportSettings = importSettings;
		Entities = entities;
		Messages = messages;
		ContentType = contentType;
		PacketData = packetData;
		ServiceData = serviceData;
	}
}
