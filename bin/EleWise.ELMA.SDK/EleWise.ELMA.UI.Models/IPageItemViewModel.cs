using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.UI.Models;

public interface IPageItemViewModel
{
	IEntity Context { get; }

	RootViewItem View { get; }
}
