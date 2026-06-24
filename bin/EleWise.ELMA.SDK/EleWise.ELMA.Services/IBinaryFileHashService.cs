using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.Services;

public interface IBinaryFileHashService
{
	string GetHash(BinaryFile binaryFile, HashAlogrithmEnum algorithm);

	Task<string> GetHashAsync(BinaryFile binaryFile, HashAlogrithmEnum algorithm, CancellationToken token);
}
