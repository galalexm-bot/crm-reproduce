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
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using NHibernate;
using System;
using System.Linq;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    [RouteArea("EleWise.ELMA.CRM.Web")]
    [Permission("6D7D9545-BCA8-4D1A-8856-996684F76130")]
    [Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
    public class SaleFunnelReportController : BPMController
    {
        public FilterMenuProvider FilterMenuProvider { get; set; }

        [ContentItem(Name = "SR.M('Воронки продаж')", Image24 = "#report.svg")]
        [FilterMenuItem(Id = "crm-sale-funnels", TypeUidStr = "{869E49A0-BB96-495F-8EA4-0EFC5F06ED35}", HideFilterAll = true)]
        public ActionResult Index(long? FilterId = null)
        {
            if (!FilterId.HasValue)
            {
                Common.Models.Filters.IFilter defaultFilter = FilterDefaultManager.Instance.LoadDefaultFilter(InterfaceActivator.UID<ISaleFunnel>()).CastAsRealType();
                if (defaultFilter == null)
                {
                    IFilterFolder filterFolder = FilterMenuProvider.Folders(SaleFunnelManager.SaleFunnelReportUid, null).FirstOrDefault((IFilterFolder f) => f is Common.Models.Filters.IFilter);
                    if (filterFolder == null)
                    {
                        return View();
                    }
                    return RedirectToAction("Index", new
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
                return Redirect(href);
            }
            FilterModel filterModel = CreateFilter(FilterId);
            return View(new SaleFunnelReportFilterModel
            {
                Entity = ((ISaleFilter)filterModel.Filter).SaleFunnel,
                DataFilter = filterModel
            });
        }

        public ActionResult SaleFunnels([Bind(Prefix = "DataFilter")] FilterModel filter)
        {
            ISaleFilter filter1 = (ISaleFilter)filter.Filter;
            return PartialView("SaleFunnel", (object)new SaleFunnelReportModel()
            {
                SaleFunnel = filter1.SaleFunnel,
                SaleFunnelReportInfo = SaleManager.Instance.SaleFunnelReport((IEntityFilter)filter1)
            });
        }

        protected virtual FilterModel CreateFilter(long? FilterId = null)
        {
            long? nullable = FilterId;
            long num = 0;
            FilterModel filter1 = new FilterModel(nullable.GetValueOrDefault() > num & nullable.HasValue ? (IFilterBase)AbstractNHEntityManager<EleWise.ELMA.Common.Models.Filters.IFilter, long>.Instance.Load(FilterId.Value) : (IFilterBase)InterfaceActivator.Create<EleWise.ELMA.Common.Models.Filters.IFilter>(), SaleFunnelManager.SaleFunnelReportUid, new Guid?(), new Guid?(InterfaceActivator.UID<ISale>()), "Filter", (IEntityFilter)null, new Guid?(), this.EnableEqlQuery, (GridState)null, (string)null, (string)null, (Type)null);
            if (this.EnableEqlQuery)
            {
                IEntityManager entityManager = ModelHelper.GetEntityManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(MetadataLoader.GetEntityMetadataByFilter(filter1.Filter.GetType()).Uid));
                IEntityFilter filter2 = filter1.Filter;
                try
                {
                    entityManager.CheckFilter(filter2);
                }
                catch (NullReferenceException ex)
                {
                    // ISSUE: explicit non-virtual call
                    Notifier.Error(EleWise.ELMA.SR.T("Неправильно составлен запрос"));
                }
                catch (ADOException ex)
                {
                    // ISSUE: explicit non-virtual call
                    Notifier.Error(EleWise.ELMA.SR.T("Неправильно составлен запрос"));
                }
                catch (Exception ex)
                {
                    // ISSUE: explicit non-virtual call
                    Notifier.Error(ex);
                }
            }
            return filter1;
        }

        protected bool EnableEqlQuery => true;
    }
}
