using AutoMapper;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.AutoMaps;

namespace EleWise.ELMA.Messages.Components;

[Component]
internal class MessageMapConfigurator : IAutoMapConfigurator
{
	public void Configure(IMapperConfigurationExpression configuration)
	{
		((IProfileExpression)configuration).CreateMap<IMessage, IMessage>();
	}
}
