using Bridge;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.DTO;

namespace EleWise.ELMA.Serialization;

[ObjectLiteral]
public sealed class EnumConvertContext
{
	private EnumMetadata _003CMetadata_003Ek__BackingField;

	private IProxyGeneratorService _003CProxyGeneratorService_003Ek__BackingField;

	[Name("$metadata")]
	internal EnumMetadata Metadata
	{
		get
		{
			return _003CMetadata_003Ek__BackingField;
		}
		set
		{
			_003CMetadata_003Ek__BackingField = value;
		}
	}

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
}
