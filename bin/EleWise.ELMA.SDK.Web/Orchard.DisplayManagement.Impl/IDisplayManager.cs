using System.Web;

namespace Orchard.DisplayManagement.Implementation;

public interface IDisplayManager : IDependency
{
	IHtmlString Execute(DisplayContext context);
}
