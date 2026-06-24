using System.Collections.Generic;

namespace Orchard.Indexing;

public interface IIndexProvider : ISingletonDependency, IDependency
{
	void CreateIndex(string name);

	bool Exists(string name);

	IEnumerable<string> List();

	void DeleteIndex(string name);

	bool IsEmpty(string indexName);

	int NumDocs(string indexName);

	IDocumentIndex New(int documentId);

	void Store(string indexName, IDocumentIndex indexDocument);

	void Store(string indexName, IEnumerable<IDocumentIndex> indexDocuments);

	void Delete(string indexName, int documentId);

	void Delete(string indexName, IEnumerable<int> documentIds);

	ISearchBuilder CreateSearchBuilder(string indexName);

	IEnumerable<string> GetFields(string indexName);
}
