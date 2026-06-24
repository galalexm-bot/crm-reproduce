using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Engine.Metadata.Services.Abstractions;
using EleWise.ELMA.Types.Storage;

namespace EleWise.ELMA.DTO;

[Service]
internal sealed class MetadataReferenceStorage : IMetadataReferenceStorage, ISystemMetadataTypeReferenceStorage
{
	private readonly TypedMap<string, string> metadataRef = new TypedMap<string, string>();

	public string GetTypeReference(string metadataUid)
	{
		return metadataRef.Get(metadataUid);
	}

	public string GetMetadataUid(string typeReference)
	{
		return metadataRef.Get(typeReference);
	}

	public void SetReference(string uid, string typeRef)
	{
		if (!string.IsNullOrWhiteSpace(typeRef) && !metadataRef.Has(typeRef) && !(uid == "00000000-0000-0000-0000-000000000000"))
		{
			metadataRef.Set(uid, typeRef);
			metadataRef.Set(typeRef, uid);
		}
	}
}
