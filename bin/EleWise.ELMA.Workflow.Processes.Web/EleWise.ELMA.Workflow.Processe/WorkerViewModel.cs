using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class WorkerViewModel
{
	public enum Types
	{
		Unknown,
		OrganizationItem,
		UserGroup,
		User,
		ContextProperty
	}

	public Types Type { get; set; }

	public string TypeName { get; set; }

	public string Name { get; set; }

	public WorkerViewModel(Worker worker, IWorkflowProcess process)
	{
		if (worker.WorkerType == OrganizationItemDTO.MetadataUid)
		{
			Type = Types.OrganizationItem;
			TypeName = SR.T("Элемент оргструктуры");
			OrganizationItemManager serviceNotNull = Locator.GetServiceNotNull<OrganizationItemManager>();
			Name = serviceNotNull.Load(worker.WorkerId).Name;
		}
		else if (worker.WorkerType == UserGroupDTO.MetadataUid)
		{
			Type = Types.UserGroup;
			TypeName = SR.T("Группа пользователей");
			UserGroupManager serviceNotNull2 = Locator.GetServiceNotNull<UserGroupManager>();
			Name = serviceNotNull2.Load(worker.WorkerId).Name;
		}
		else if (worker.WorkerType == UserDTO.UID)
		{
			Type = Types.User;
			TypeName = SR.T("Пользователь");
			UserManager serviceNotNull3 = Locator.GetServiceNotNull<UserManager>();
			Name = serviceNotNull3.Load(worker.WorkerId).FullName;
		}
		else if (worker.WorkerType == Worker.Types.Property)
		{
			Type = Types.ContextProperty;
			TypeName = SR.T("Контекстная переменная");
			PropertyMetadata propertyMetadata = ((EntityMetadata)MetadataLoader.LoadMetadata(Locator.GetServiceNotNull<WorkflowInstanceContextService>().GetInstanceContextType(process))).Properties.FirstOrDefault((PropertyMetadata m) => m.Uid == worker.WorkerUid);
			Name = propertyMetadata.Name;
		}
		else
		{
			Type = Types.Unknown;
		}
	}
}
