using System.IO;
using System.Threading.Tasks;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.Runtime.Managers;

public interface IBinaryFileStreams
{
	Stream GetContent(BinaryFile binaryFile, GetContentOptions options = null);

	void PutContent(BinaryFile binaryFile, Stream content, PutContentOptions options = null);

	Task PutContentAsync(BinaryFile binaryFile, Stream content, PutContentOptions options = null);
}
