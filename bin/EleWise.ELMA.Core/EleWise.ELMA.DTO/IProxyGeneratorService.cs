using System.Collections.Generic;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.DTO;

[ServiceContract]
public interface IProxyGeneratorService
{
	ReactiveProxy GenerateProxy(string hash);

	ReactiveProxy GenerateProxyOrNull(string hash);

	ReactiveProxy GenerateProxy(ClassMetadata md);

	ReactiveProxy GenerateProxyOrNull(ClassMetadata md);

	System.Collections.Generic.IEnumerable<IPropertyMetadata> DefineProps(ReactiveProxy proxy, ClassMetadata metadata);

	ReactiveProxy CreateProxy(ClassMetadata metadata, object serializedModel);
}
