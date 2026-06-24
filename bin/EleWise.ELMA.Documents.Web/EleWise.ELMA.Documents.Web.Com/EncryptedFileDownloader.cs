using System.IO;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Exceptions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Files;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
internal class EncryptedFileDownloader : IEncryptedFileDownloadProvider
{
	private readonly ICryptoContextAuthService cryptoContextAuthService;

	private readonly DocumentVersionManager documentVersionManager;

	public EncryptedFileDownloader(ICryptoContextAuthService cryptoContextAuthService, DocumentVersionManager documentVersionManager)
	{
		this.cryptoContextAuthService = cryptoContextAuthService;
		this.documentVersionManager = documentVersionManager;
	}

	public bool CanDecrypt(BinaryFile file)
	{
		return file.Encrypt;
	}

	public Stream GetDecryptedContent(BinaryFile binaryFile)
	{
		string password = GetPassword(binaryFile);
		Stream content = binaryFile.GetContent(GetContentOptions.NonSeekable);
		if (password != null)
		{
			return EncryptionHelper.DecryptStream(content, binaryFile.Salt, password);
		}
		return null;
	}

	public string GetPassword(BinaryFile file)
	{
		InstanceOf<IDocumentVersionFilter> instanceOf = new InstanceOf<IDocumentVersionFilter>();
		instanceOf.New.File = file;
		instanceOf.New.DisableSecurity = true;
		IDocumentVersionFilter @new = instanceOf.New;
		IDocumentVersion documentVersion = documentVersionManager.Find(@new, new FetchOptions(0, 1)).FirstOrDefault();
		if (documentVersion == null)
		{
			return null;
		}
		IEntity entity2;
		if (!documentVersion.Document.Encrypt)
		{
			IEntity entity = documentVersion;
			entity2 = entity;
		}
		else
		{
			IEntity entity = documentVersion.Document;
			entity2 = entity;
		}
		IEntity entity3 = entity2;
		if (!cryptoContextAuthService.IsSignForEntity(entity3))
		{
			if (documentVersion.Document.Encrypt)
			{
				throw new EncryptDocumentException(documentVersion.Document.Id);
			}
			throw new EncryptDocumentVersionException(documentVersion.Id);
		}
		return cryptoContextAuthService.GetPasswordFromContext(entity3);
	}
}
