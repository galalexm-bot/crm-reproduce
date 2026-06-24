using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;

namespace EleWise.ELMA.Model.Services;

public interface ISearchMetadataService
{
	IEnumerable<DataClassMetadata> GetPublishedDataClasses();

	IEnumerable<DataClassAssemblyInfo> GetPublishedDataClassAssemblies();

	IEnumerable<DataClassMetadata> GetDraftDataClasses();

	IEnumerable<DataClassMetadata> GetNonInternalDraftDataClasses();

	IEnumerable<FunctionMetadata> GetPublishedFunctions();

	IEnumerable<FunctionMetadata> GetDraftFunctions();

	IEnumerable<ComponentMetadata> GetPublishedComponents();

	IEnumerable<ComponentMetadata> GetDraftComponents();
}
