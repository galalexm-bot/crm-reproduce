using System;
using System.Collections.Generic;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Model.ViewModel;

public interface IFormViewModel : IMetadataViewModel, IViewModel
{
	IViewItem ViewItem { get; }

	Action CloseCurrentDrawer { get; }

	IDictionary<Guid, IController> Controllers { get; }
}
