using EleWise.ELMA.UI.Descriptors;

namespace EleWise.ELMA.UI.Models;

public interface IPortletContentViewModel : IFormViewModel
{
	IPortletPersonalization Settings { get; }

	PortletContentDescriptor PortletContentDescriptor { get; }
}
