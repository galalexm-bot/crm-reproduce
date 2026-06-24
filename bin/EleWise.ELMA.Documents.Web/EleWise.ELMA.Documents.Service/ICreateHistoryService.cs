using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Services;

public interface ICreateHistoryService
{
	List<ClassMetadata> Get();

	void Add(ClassMetadata metadata);

	void SetStatus(DocumentVersionStatus status);

	DocumentVersionStatus GetStatus();
}
