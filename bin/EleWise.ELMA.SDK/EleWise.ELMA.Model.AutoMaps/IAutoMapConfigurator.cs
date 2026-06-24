using AutoMapper;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.AutoMaps;

[ExtensionPoint(ComponentType.All)]
public interface IAutoMapConfigurator
{
	void Configure(IMapperConfigurationExpression configuration);
}
