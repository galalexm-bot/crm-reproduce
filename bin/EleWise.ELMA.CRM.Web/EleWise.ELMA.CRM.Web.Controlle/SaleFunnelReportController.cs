using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Security;
using NHibernate;

namespace EleWise.ELMA.CRM.Web.Controllers;

[RouteArea("EleWise.ELMA.CRM.Web")]
[Permission("6D7D9545-BCA8-4D1A-8856-996684F76130")]
[Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
public class SaleFunnelReportController : BPMController
{
	public FilterMenuProvider FilterMenuProvider { get; set; }

	protected bool EnableEqlQuery => true;

	[ContentItem(Name = "SR.M('Воронки продаж')", Image24 = "#report.svg")]
	[FilterMenuItem(Id = "crm-sale-funnels", TypeUidStr = "{869E49A0-BB96-495F-8EA4-0EFC5F06ED35}", HideFilterAll = true)]
	public ActionResult Index(long? FilterId = null)
	{
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		if (!FilterId.HasValue)
		{
			IFilter defaultFilter = FilterDefaultManager.Instance.LoadDefaultFilter(InterfaceActivator.UID<ISaleFunnel>()).CastAsRealType();
			if (defaultFilter == null)
			{
				IFilterFolder filterFolder = FilterMenuProvider.Folders(SaleFunnelManager.SaleFunnelReportUid, null).FirstOrDefault((IFilterFolder f) => f is IFilter);
				if (filterFolder == null)
				{
					return (ActionResult)(object)((Controller)this).View();
				}
				return (ActionResult)(object)((Controller)this).RedirectToAction("Index", (object)new
				{
					FilterId = filterFolder.Id
				});
			}
			IFilterMenuProviderExtension filterMenuProviderExtension = ComponentManager.Current.GetExtensionPoints<IFilterMenuProviderExtension>().FirstOrDefault((IFilterMenuProviderExtension p) => p.SupportedFilter(defaultFilter));
			string href = null;
			if (filterMenuProviderExtension != null)
			{
				string text = (string)HttpContextAccessor.CurrentContext.Request.RequestContext.RouteData.Values["area"];
				filterMenuProviderExtension.GetTreeNodeParameters(defaultFilter, new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext), isDefault: false, isSystemDefault: false, out var _, out var _, out href, out var _, new ActionRoute((string)HttpContextAccessor.CurrentContext.Request.RequestContext.RouteData.Values["action"], (string)HttpContextAccessor.CurrentContext.Request.RequestContext.RouteData.Values["controller"], string.IsNullOrEmpty(text) ? null : new
				{
					area = text
				}), "FilterId");
			}
			return (ActionResult)(object)((Controller)this).Redirect(href);
		}
		FilterModel filterModel = CreateFilter(FilterId);
		return (ActionResult)(object)((Controller)this).View((object)new SaleFunnelReportFilterModel
		{
			Entity = ((ISaleFilter)filterModel.Filter).SaleFunnel,
			DataFilter = filterModel
		});
	}

	public ActionResult SaleFunnels([Bind(Prefix = "DataFilter")] FilterModel filter)
	{
		ISaleFilter saleFilter = (ISaleFilter)filter.Filter;
		return (ActionResult)(object)((Controller)this).PartialView("SaleFunnel", (object)new SaleFunnelReportModel
		{
			SaleFunnel = saleFilter.SaleFunnel,
			SaleFunnelReportInfo = SaleManager.Instance.SaleFunnelReport(saleFilter)
		});
	}

	protected virtual FilterModel CreateFilter(long? FilterId = null)
	{
		FilterModel filterModel = new FilterModel((FilterId > 0) ? AbstractNHEntityManager<IFilter, long>.Instance.Load(FilterId.Value) : InterfaceActivator.Create<IFilter>(), SaleFunnelManager.SaleFunnelReportUid, null, InterfaceActivator.UID<ISale>(), "Filter", null, null, EnableEqlQuery);
		if (EnableEqlQuery)
		{
			IEntityManager entityManager = ModelHelper.GetEntityManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(MetadataLoader.GetEntityMetadataByFilter(filterModel.Filter.GetType()).Uid));
			IEntityFilter filter = filterModel.Filter;
			try
			{
				entityManager.CheckFilter(filter);
				return filterModel;
			}
			catch (NullReferenceException)
			{
				base.Notifier.Error(SR.T("Неправильно составлен запрос"));
				return filterModel;
			}
			catch (ADOException)
			{
				base.Notifier.Error(SR.T("Неправильно составлен запрос"));
				return filterModel;
			}
			catch (Exception exception)
			{
				FormNotifierExtensions.Error(base.Notifier, exception);
				return filterModel;
			}
		}
		return filterModel;
	}
}
