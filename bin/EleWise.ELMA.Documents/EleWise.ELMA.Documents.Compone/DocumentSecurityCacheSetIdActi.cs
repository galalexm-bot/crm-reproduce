using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class DocumentSecurityCacheSetIdAction : ISecurityCacheSetIdAction
{
	public void Execute()
	{
		Locator.GetServiceNotNull<ISystemFoldersService>().ClearAll();
	}
}
