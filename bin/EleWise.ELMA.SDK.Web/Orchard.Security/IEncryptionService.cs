namespace Orchard.Security;

public interface IEncryptionService : ISingletonDependency, IDependency
{
	byte[] Decode(byte[] encodedData);

	byte[] Encode(byte[] data);
}
