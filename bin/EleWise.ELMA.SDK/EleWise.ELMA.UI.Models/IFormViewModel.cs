using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Results;

namespace EleWise.ELMA.UI.Models;

public interface IFormViewModel
{
	string Header { get; }

	IEntity Context { get; set; }

	FormViewItem View { get; set; }

	IFormPartDescriptor Descriptor { get; }

	FormResult Result { get; }
}
