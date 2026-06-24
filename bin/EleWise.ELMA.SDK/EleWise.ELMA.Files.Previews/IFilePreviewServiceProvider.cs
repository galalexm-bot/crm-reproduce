using System;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Files.Previews;

[DeveloperApi(DeveloperApiType.Service)]
public interface IFilePreviewServiceProvider
{
	Guid ProviderUid { get; }

	void AddFileToQueue(string fileId, long priority);

	void DeleteFileFromQueue(string fileId);

	PreviewWorkStatus GetFilePreviewWorkStatus(string fileId);

	IFilePreviewCreator GetFilePreviewCreator(BinaryFile file);

	bool GeneratePreview(string fileId, string fileEncryptPassword, string password = null);

	bool CheckPassword(string fileId, string password);

	bool CheckPassword(string fileId, string fileEncryptPassword, string password);
}
