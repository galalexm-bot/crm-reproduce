using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.Models.DynamicForms;

public class DynamicFormChangeResultViewModel
{
	public DynamicFormChangeResult Result { get; set; }

	public string[] ChangedPropertyNames { get; set; }

	public EntityMetadata Metadata { get; set; }

	public string Prefix { get; set; }

	public IEntity Entity { get; set; }

	public RootViewItem View { get; set; }
}
