using EleWise.ELMA.UI.Descriptors;

namespace EleWise.ELMA.UI.Models;

public interface IPageViewModel : IFormViewModel
{
	PageContentDescriptor PageContentDescriptor { get; }
}
