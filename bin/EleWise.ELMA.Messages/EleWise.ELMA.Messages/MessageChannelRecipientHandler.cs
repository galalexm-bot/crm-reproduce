using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Notifications;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages;

[Component]
internal class MessageChannelRecipientHandler : INotificationRecipientTypeHandler
{
	public string Name => "MessageChannelRecipient";

	public IEnumerable<object> GetRecipients(object value)
	{
		if (value == null)
		{
			return new object[0];
		}
		IChannelMessage channelMessage = value as IChannelMessage;
		List<object> list = new List<object>();
		List<IUser> list2 = new List<IUser>();
		bool flag = true;
		if (channelMessage != null)
		{
			if (channelMessage.Recipients != null)
			{
				list.AddRange((IEnumerable<object>)channelMessage.Recipients);
			}
			foreach (IInformationChannel item in (IEnumerable<IInformationChannel>)channelMessage.Channels)
			{
				if (!item.IsSubscriptionManagementDenied)
				{
					if (item.Subscribers != null)
					{
						list.AddRange(((IEnumerable<IInformationChannelSubscriber>)item.Subscribers).Select((IInformationChannelSubscriber s) => s.User));
					}
					flag = false;
				}
				else if (list2.Count == 0)
				{
					list2 = UsersPermissionsMessage(channelMessage);
				}
			}
			if (flag && list2.Count == 0)
			{
				list2 = UsersPermissionsMessage(channelMessage);
			}
			list.AddRange(list2);
		}
		return list;
	}

	private static List<IUser> UsersPermissionsMessage(IChannelMessage message)
	{
		List<IUser> list = new List<IUser>();
		if (message != null)
		{
			((IEnumerable<IInformationChannel>)message.Channels).ForEach(delegate(IInformationChannel ch)
			{
				IEnumerable<IUser> collection = from p in (IEnumerable<IInformationChannelPermission>)ch.Permissions
					where p.Assigned is IUser
					select p.User;
				list.AddRange(collection);
				IEnumerable<IUserGroup> enumerable = from p in (IEnumerable<IInformationChannelPermission>)ch.Permissions
					where p.Assigned is IUserGroup
					select p.Group;
				List<IUserGroup> chekedGroups = new List<IUserGroup>();
				List<IUser> users = new List<IUser>();
				foreach (IUserGroup item in enumerable)
				{
					GroupsPermissionsMessage(message, ref users, item, ref chekedGroups);
				}
				if (users != null)
				{
					list.AddRange(users.Where((IUser u) => !list.Contains(u)));
				}
				foreach (IOrganizationItem item2 in from p in (IEnumerable<IInformationChannelPermission>)ch.Permissions
					where p.Assigned is IOrganizationItem
					select p.OrganizationItem into p
					where p != null
					select p)
				{
					list.AddRange((IEnumerable<IUser>)item2.Users);
				}
				foreach (IOrganizationItem item3 in from p in (IEnumerable<IInformationChannelPermission>)ch.Permissions
					where p.Assigned is IOrganizationItem
					select p.OrganizationItemPosition into p
					where p != null
					select p)
				{
					if (item3.User != null)
					{
						list.Add(item3.User);
					}
				}
			});
		}
		return list;
	}

	private static void GroupsPermissionsMessage(IBaseMessage message, ref List<IUser> users, IUserGroup group, ref List<IUserGroup> chekedGroups)
	{
		if (group == null || chekedGroups.Contains(group))
		{
			return;
		}
		chekedGroups.Add(group);
		if (chekedGroups == null)
		{
			chekedGroups = new List<IUserGroup>();
		}
		if (users == null)
		{
			users = new List<IUser>();
		}
		foreach (IUser item in (IEnumerable<IUser>)group.Users)
		{
			if (!users.Contains(item))
			{
				users.Add(item);
			}
		}
		foreach (IOrganizationItem item2 in ((IEnumerable<IOrganizationItem>)group.OrganizationItems).Where((IOrganizationItem oi) => oi.ItemType == OrganizationItemType.Position))
		{
			if (item2.User != null && !users.Contains(item2.User))
			{
				users.Add(item2.User);
			}
		}
		foreach (IOrganizationItem item3 in ((IEnumerable<IOrganizationItem>)group.OrganizationItems).Where((IOrganizationItem oi) => oi.ItemType == OrganizationItemType.EmployeeGroup))
		{
			foreach (IUser item4 in (IEnumerable<IUser>)item3.Users)
			{
				if (!users.Contains(item4))
				{
					users.Add(item4);
				}
			}
		}
		foreach (IUserGroup item5 in (IEnumerable<IUserGroup>)group.Groups)
		{
			GroupsPermissionsMessage(message, ref users, item5, ref chekedGroups);
		}
	}
}
