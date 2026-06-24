using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Web.Models;

public class SaleModel : DynamicEntityViewModel<ISale>
{
	public bool ContractorReadOnly { get; set; }

	public bool LockEditPermission { get; set; }

	public override FormViewItem View
	{
		get
		{
			if (view != null)
			{
				return view;
			}
			view = base.View;
			view = view.Transformate(CRMSaleFormViewTransformate.GetTransformation(Metadata<EntityMetadata>(), view.ViewType));
			return view;
		}
	}

	public SaleModel(ISale sale)
		: this(sale, ViewType.Create)
	{
	}

	public SaleModel(ISale sale, ViewType viewType)
		: base(sale, viewType)
	{
		ContractorReadOnly = false;
	}

	public SaleModel()
	{
		base.ViewType = ViewType.Create;
		base.Entity.Responsible = AuthenticationService.GetCurrentUser<IUser>();
		CrmSettingsModule serviceNotNull = Locator.GetServiceNotNull<CrmSettingsModule>();
		base.Entity.Currency = serviceNotNull.Settings.DefaultSaleCurrency;
		base.Entity.SaleType = serviceNotNull.Settings.DefaultSaleType;
		ContractorReadOnly = false;
	}
}
