using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.CRM.Web.Models;

public class SaleProductsModel : DynamicEntityViewModel<ISaleProduct>
{
	public GridData<ISaleProduct, ISaleProductFilter> GridData { get; set; }

	public bool ReadOnly { get; set; }

	public ISale Sale { get; set; }

	public FilterModel Filter { get; set; }

	public SaleProductsModel(ISaleProduct saleProduct, ViewType viewType)
		: base(saleProduct, viewType)
	{
	}

	public SaleProductsModel(ViewType viewType)
		: this(InterfaceActivator.Create<ISaleProduct>(), viewType)
	{
	}

	public SaleProductsModel()
		: this(ViewType.Create)
	{
	}
}
