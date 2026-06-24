using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Common.BulkDataImport.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.CodeGeneration.PublicApi;

namespace EleWise.ELMA.Common.DynamicAPI;

[Component(Order = 4)]
internal class PublicApiCommonRootNodeEntityProvider : IPublicApiNodeProvider
{
	public IEnumerable<IPublicApiNode> CreatePublicApiNodes()
	{
		yield return new PublicApiCommonRootNode();
		foreach (IPublicApiNode item in PublicApiNodeServicesProvider.Services(TypeOf<IBulkDataImportService>.Raw))
		{
			yield return item;
		}
	}
}
