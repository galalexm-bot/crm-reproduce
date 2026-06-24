using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Web.Models;

public class LifeCycleStatusChangerModel
{
	public IDocument Document { get; set; }

	public bool IsCustomChangeStatus
	{
		get
		{
			if (Document != null)
			{
				if (!Locator.GetService<ISecurityService>().HasPermission(PermissionProvider.DocumentEditPermission, Document))
				{
					return false;
				}
				IMetadata metadata = MetadataLoader.LoadMetadata(((EntityMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID(Document.GetType()))).ImplementationUid, inherit: true, loadImplementation: false);
				ILifeCycle lifeCycle = LifeCycleManager.Instance.LoadOrNull(metadata.Uid);
				if (lifeCycle != null)
				{
					return lifeCycle.IsCustomChangeStatus;
				}
			}
			return false;
		}
	}
}
