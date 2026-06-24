using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.Runtime.Managers;

public interface IBinaryFileAsyncLoader
{
	Task<BinaryFile> LoadFileAsync(string id, CancellationToken token);
}
