using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Encrypters;

[ExtensionPoint(ComponentType.All)]
public interface ITypeEncrypter
{
	bool CheckType(object obj, IMetadata propertyMetadata);

	string Encrypt(object obj, string password, string salt, IMetadata propertyMetadata);

	object Decrypt(string encrypted, string password, string salt, IMetadata propertyMetadata);

	object EncryptStub(object obj, IMetadata propertyMetadata);
}
