using System;
using System.IO;

namespace EleWise.ELMA.Packaging.Components;

public interface IElmaProjectSystem
{
	void AddReference(string referencePath, Stream stream);

	void AddReference(string referencePath, Stream stream, DateTime? creationTime, DateTime? lastWriteTime);

	bool ReferenceExists(string name);

	void RemoveReference(string name);
}
