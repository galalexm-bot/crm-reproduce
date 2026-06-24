using Bridge;
using EleWise.ELMA.DTO;

namespace EleWise.ELMA.Serialization;

[ObjectLiteral]
public sealed class ConvertContext
{
	private IProxyGeneratorService _003CProxyGeneratorService_003Ek__BackingField;

	private IExtendEntityService _003CExtendEntityService_003Ek__BackingField;

	[Name("$proxyGenerator")]
	internal IProxyGeneratorService ProxyGeneratorService
	{
		get
		{
			return _003CProxyGeneratorService_003Ek__BackingField;
		}
		set
		{
			_003CProxyGeneratorService_003Ek__BackingField = value;
		}
	}

	[Name("$extendEntityService")]
	internal IExtendEntityService ExtendEntityService
	{
		get
		{
			return _003CExtendEntityService_003Ek__BackingField;
		}
		set
		{
			_003CExtendEntityService_003Ek__BackingField = value;
		}
	}
}
