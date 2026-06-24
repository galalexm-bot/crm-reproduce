using System.Web.Mvc;

namespace Orchard.DisplayManagement;

public interface IDisplayHelperFactory : IDependency
{
	dynamic CreateHelper(ViewContext viewContext, IViewDataContainer viewDataContainer);
}
