using System.IO;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEncryptedFileDownloadProvider
{
	bool CanDecrypt(BinaryFile file);

	string GetPassword(BinaryFile file);

	Stream GetDecryptedContent(BinaryFile binaryFile);
}
