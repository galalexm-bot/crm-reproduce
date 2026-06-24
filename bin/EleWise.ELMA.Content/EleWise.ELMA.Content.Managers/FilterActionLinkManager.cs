using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Content.Managers;

public class FilterActionLinkManager : EntityManager<IFilterActionLink, long>
{
	public IContextBoundVariableService CacheService { get; set; }

	public new static FilterActionLinkManager Instance => Locator.GetServiceNotNull<FilterActionLinkManager>();

	[Transaction]
	[PublicApiMember]
	public override void Delete(IFilterActionLink obj)
	{
		FilterDefaultManager.Instance.DeleteDefaults(obj);
		FilterManager.Instance.DeletePermissions(obj);
		base.Delete(obj);
	}
}
