using Orchard.ContentManagement;

namespace Orchard.Tasks.Indexing;

public interface IIndexingTaskManager : IDependency
{
	void CreateUpdateIndexTask(ContentItem contentItem);

	void CreateDeleteIndexTask(ContentItem contentItem);
}
