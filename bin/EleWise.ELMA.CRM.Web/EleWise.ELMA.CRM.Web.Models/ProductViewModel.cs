using System;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Models;

public class ProductViewModel : EntityModel<IProduct>
{
	private FormViewItem view;

	public IProduct CurrentFolderObject { get; set; }

	public FilterModel Filter { get; set; }

	public string GridId { get; set; }

	public Guid? FormUid { get; set; }

	public ViewType ViewType { get; set; }

	public FormViewItem View
	{
		get
		{
			if (view != null)
			{
				return view;
			}
			EntityMetadata entityMetadata = Metadata<EntityMetadata>();
			if (FormUid.HasValue && FormUid.Value != Guid.Empty)
			{
				view = entityMetadata.GetForms().FirstOrDefault(delegate(FormViewItem q)
				{
					Guid uid = q.Uid;
					Guid? formUid = FormUid;
					return uid == formUid;
				});
			}
			else
			{
				view = entityMetadata.DefaultForms.GetForm(ViewType);
			}
			if (view == null)
			{
				return null;
			}
			if (view.ViewType == ViewType.Display)
			{
				view = (FormViewItem)view.CloneAsReadOnly();
			}
			return view;
		}
	}

	public ProductViewModel(IProduct product, ViewType viewType)
	{
		base.Entity = product ?? InterfaceActivator.Create<IProduct>();
		ViewType = viewType;
	}

	public ProductViewModel(IProduct product)
		: this(product, ViewType.Create)
	{
	}

	public ProductViewModel()
		: this(null)
	{
	}
}
