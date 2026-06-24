using System;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.Services;

public interface IBinaryFileLegacyBehaviorProvider
{
	Uri InitializeContentLocation(BinaryFile binaryFile);

	long? GetLength(BinaryFile binaryFile);

	uint? GetCrc(BinaryFile binaryFile);
}
