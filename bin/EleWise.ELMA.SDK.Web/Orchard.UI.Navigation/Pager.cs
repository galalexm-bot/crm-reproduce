using Orchard.Settings;

namespace Orchard.UI.Navigation;

public class Pager
{
	public const int PageDefault = 1;

	public int Page { get; set; }

	public int PageSize { get; set; }

	public Pager(ISite site, PagerParameters pagerParameters)
		: this(site, pagerParameters.Page, pagerParameters.PageSize)
	{
	}

	public Pager(ISite site, int? page, int? pageSize)
	{
		Page = ((!page.HasValue) ? new int?(1) : ((page > 0) ? page : new int?(1))).Value;
		PageSize = pageSize ?? site.PageSize;
		if (site.MaxPageSize > 0 && PageSize > site.MaxPageSize)
		{
			PageSize = site.MaxPageSize;
		}
	}

	public int GetStartIndex(int? page = null)
	{
		return ((page ?? Page) - 1) * PageSize;
	}
}
