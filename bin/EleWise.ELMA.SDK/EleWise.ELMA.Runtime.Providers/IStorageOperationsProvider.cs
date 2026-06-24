using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.Runtime.Providers;

public interface IStorageOperationsProvider
{
	Uri GetSourceContentLocation(SystemFile systemFile);

	long? GetContentSize(SystemFile systemFile);

	Uri SaveContent(Uri srcLocation, SystemFile systemFile, bool deleteSourceAfterSave = false);

	void FetchContent(SystemFile systemFile);

	Task FetchContentAsync(SystemFile systemFile, CancellationToken token);

	BinaryFileContentInfo EncryptContent(SystemFile systemFile, string password);

	BinaryFileContentInfo DecryptContent(SystemFile systemFile, string password);

	Stream OpenTempContentWriteStream(Action<Uri> contentInfoHandler, PutContentOptions options);

	Stream OpenPersistentContentReadStream(SystemFile systemFile, GetContentOptions options);

	Stream OpenTempContentReadStream(Uri contentLocation, GetContentOptions options);

	string GetContentHash(SystemFile systemFile, HashAlogrithmEnum hashAlgorithm);

	Task<string> GetContentHashAsync(SystemFile systemFile, HashAlogrithmEnum hashAlgorithm, CancellationToken token);
}
