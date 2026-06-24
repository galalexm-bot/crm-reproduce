using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Models.Selectors;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class UserPopupSelectorModel : EntityPopupSelectorModel
{
	private List<IEntityUserTypeSelector> _selectors;

	public string Id { get; set; }

	public RouteValueDictionary RouteValues { get; set; }

	public string SearchString { get; set; }

	public IOrganizationItem OrganizationItem { get; set; }

	public string FilterProviderUid { get; set; }

	public string FilterProviderData { get; set; }

	public bool CheckReplacement { get; set; }

	public bool ComplexExecutor { get; set; }

	public string SelectedExecutorType { get; set; }

	public bool ShowBlock { get; set; }

	public int PageSize { get; set; }

	public string OrgItemOnlyCheckBoxId { get; set; }

	public ICollection<SelectButtonSetting> SelectButtonSettings { get; set; }

	public ICollection<IPersonalGroup> PersonalGroups { get; set; }

	public IEnumerable<UserPopupSelectListItem> GroupUsers { get; set; }

	public IEnumerable<UserPopupSelectListItem> UserSelectListItemsAvailable { get; set; }

	public List<IEntityUserTypeSelector> Selectors => _selectors ?? (_selectors = ComponentManager.Current.GetExtensionPoints<IEntityUserTypeSelector>().ToList());
}
