using System.Web;

namespace Orchard;

public interface IWorkContextAccessor
{
	WorkContext GetContext(HttpContextBase httpContext);

	IWorkContextScope CreateWorkContextScope(HttpContextBase httpContext);

	WorkContext GetContext();

	IWorkContextScope CreateWorkContextScope();
}
