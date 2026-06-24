using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public class Channel
{
	[DataMember]
	public Guid Uid { get; set; }

	[DataMember]
	public long Id { get; set; }

	[DataMember]
	public string Name { get; set; }

	public static Channel CreateChannel(IInformationChannel model)
	{
		if (model == null)
		{
			return null;
		}
		return new Channel
		{
			Id = model.Id,
			Name = model.Name,
			Uid = model.Uid
		};
	}
}
