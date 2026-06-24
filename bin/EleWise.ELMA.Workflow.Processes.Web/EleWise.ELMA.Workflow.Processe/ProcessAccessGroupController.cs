using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Security;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Controllers;

[Permission("0B0F7BD9-70C9-4AE6-8077-182ABF3DD8A6")]
public class ProcessAccessGroupController : BPMController<IProcessAccessGroup, long>
{
	public ProcessHeaderManager ProcessHeaderManager { get; set; }

	public UserGroupManager UserGroupManager { get; set; }

	[HttpGet]
	public ActionResult Edit(long processHeaderId)
	{
		IProcessHeader processHeader = ProcessHeaderManager.LoadOrNull(processHeaderId);
		Contract.NotNull(processHeader, "processHeader");
		if (processHeader.AccessGroup == null)
		{
			IProcessAccessGroup processAccessGroup = base.Manager.Create();
			processAccessGroup.Name = processHeader.Name;
			IUserGroup userGroup = UserGroupManager.LoadOrNull(SecurityConstants.AllUsersGroupUid);
			processAccessGroup.Groups.Add(userGroup);
			processHeader.AccessGroup = processAccessGroup;
			processHeader.Save();
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "UserGroup", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security",
			id = processHeader.AccessGroup.Id
		});
	}
}
