using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Engine.Storage.Abstractions;

namespace EleWise.ELMA.DTO;

[ServiceContract]
public interface ISystemProxyMetadataReferencesStorage : ISystemMetadataReferencesStorage
{
	string GetMetadataUid(string typeName);
}
