using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Extensions;
using EleWise.ELMA.Messages.Web.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Messages.Web.Controllers;

[Permission("39F0AC82-A80F-4403-A041-CFFD8E183FD3")]
public class InformationChannelController : BPMController<IInformationChannel, long>
{
	public IPermissionManagmentService PermissionManagmentService { get; set; }

	[HttpGet]
	public ActionResult Create()
	{
		ChannelViewInfo channelViewInfo = new ChannelViewInfo
		{
			Entity = InterfaceActivator.Create<IInformationChannel>(),
			IsOpen = true
		};
		return (ActionResult)(object)((Controller)this).View((object)channelViewInfo);
	}

	[HttpPost]
	public ActionResult Create(ChannelViewInfo info)
	{
		if (((Controller)this).get_ModelState().get_IsValid())
		{
			info.Entity.ChannelType = ((!info.IsOpen) ? InformationChannelType.Close : InformationChannelType.Open);
			info.Entity.Save();
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("List");
	}

	public ActionResult List(Guid? groupId)
	{
		InformationChannelList informationChannelList = new InformationChannelList();
		if (!groupId.HasValue)
		{
			groupId = Guid.Empty;
		}
		if (groupId.HasValue)
		{
			IInformationChannelGroup informationChannelGroup = ComponentManager.Current.GetExtensionPoints<IInformationChannelGroup>().FirstOrDefault((IInformationChannelGroup g) => g.Uid == groupId.Value);
			informationChannelList.GroupId = groupId.Value;
			informationChannelList.GroupName = informationChannelGroup.FullName;
		}
		return (ActionResult)(object)((Controller)this).View((object)informationChannelList);
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command, Guid? groupId)
	{
		IInformationChannelFilter informationChannelFilter = InterfaceActivator.Create<IInformationChannelFilter>();
		if (groupId.HasValue)
		{
			informationChannelFilter.GroupUid = groupId.Value;
		}
		GridData<IInformationChannel, IInformationChannelFilter> gridData = CreateGridData(command, informationChannelFilter);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[HttpGet]
	public ActionResult Info(long id)
	{
		IInformationChannel entity = base.Manager.Load(id);
		return (ActionResult)(object)((Controller)this).View((object)new ChannelViewInfo
		{
			Entity = entity
		});
	}

	[HttpGet]
	public ActionResult Edit(long id)
	{
		IInformationChannel entity = base.Manager.Load(id);
		ChannelViewInfo channelViewInfo = new ChannelViewInfo
		{
			Entity = entity
		};
		channelViewInfo.IsOpen = channelViewInfo.Entity.ChannelType == InformationChannelType.Open;
		return (ActionResult)(object)((Controller)this).View((object)channelViewInfo);
	}

	[HttpPost]
	public ActionResult Edit(ChannelViewInfo info)
	{
		if (((Controller)this).get_ModelState().get_IsValid())
		{
			info.Entity.ChannelType = ((!info.IsOpen) ? InformationChannelType.Close : InformationChannelType.Open);
			info.Entity.Save();
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Info", (object)new
		{
			id = info.Entity.Id
		});
	}

	[Permission("258BBEBC-006B-46FB-80AC-B36456A191E9")]
	public ActionResult PermissionInfoPanel(long id, Guid permission)
	{
		IInformationChannel informationChannel = base.Manager.Load(id);
		ChannelPermissionInfo channelPermissionInfo = new ChannelPermissionInfo
		{
			PermissionId = permission,
			ChannelPermissions = (from p in (IEnumerable<IInformationChannelPermission>)informationChannel.Permissions
				where p.PermissionId == permission
				select new ChannelPermissionInfoItem
				{
					Permission = p
				}).ToList()
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)channelPermissionInfo);
	}

	[HttpGet]
	[ContentItem(Name = "SR.M('Инф. каналы')", Image24 = "#channel.svg")]
	public ActionResult Groups()
	{
		List<IInformationChannelGroup> list = ComponentManager.Current.GetExtensionPoints<IInformationChannelGroup>().ToList();
		if (list.Count == 1)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("List", "InformationChannel", (object)new
			{
				area = "EleWise.ELMA.Messages.Web",
				groupId = list.First().Uid
			});
		}
		return (ActionResult)(object)((Controller)this).View((object)list);
	}
}
