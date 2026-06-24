using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.CodeGeneration.PublicApi;

namespace EleWise.ELMA.Content.DynamicAPI;

[Component(Order = 16)]
internal class PublicApiContentNodeEntityProvider : IPublicApiNodeProvider
{
	public IEnumerable<IPublicApiNode> CreatePublicApiNodes()
	{
		yield return new PublicApiPropertyClassNode("PublicAPI.Portal", "ContentPortalApi", "Content")
		{
			Description = SR.T("Контент"),
			Remarks = SR.T("Раздел содержащий методы для работы с контентом")
		};
	}
}
