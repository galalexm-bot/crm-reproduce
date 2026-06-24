using System;

namespace Orchard.Indexing;

public interface IDocumentIndex
{
	bool IsDirty { get; }

	IDocumentIndex SetContentItemId(int contentItemId);

	IDocumentIndex Add(string name, string value);

	IDocumentIndex Add(string name, DateTime value);

	IDocumentIndex Add(string name, int value);

	IDocumentIndex Add(string name, bool value);

	IDocumentIndex Add(string name, double value);

	IDocumentIndex Store();

	IDocumentIndex Analyze();

	IDocumentIndex RemoveTags();
}
