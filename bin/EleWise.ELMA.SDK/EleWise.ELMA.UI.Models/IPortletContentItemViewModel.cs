using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.UI.Models;

public interface IPortletContentItemViewModel
{
	IEntity Context { get; }

	IPortletPersonalization Settings { get; }

	RootViewItem View { get; }
}
