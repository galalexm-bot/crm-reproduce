using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Events;

public class GroupPermissionEventArgs : AuditEventArgs
{
	private GroupPermission permission;

	private GroupPermissionOperation operation;

	private Permission parentPermission;

	internal static GroupPermissionEventArgs ol4wHVrV6ogvZm5EWKm;

	public GroupPermission Permission => permission;

	public GroupPermissionOperation Operation => operation;

	public Permission ParentPermission => parentPermission;

	public GroupPermissionEventArgs(GroupPermission permission, GroupPermissionOperation operation, Permission parentPermission)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		WRK7P6rTd0SOjEooxbs();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				this.permission = permission;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
				{
					num = 0;
				}
				break;
			default:
				this.operation = operation;
				num = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
				{
					num = 3;
				}
				break;
			case 3:
				this.parentPermission = parentPermission;
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	internal static void WRK7P6rTd0SOjEooxbs()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool AIhBHPrQhFmwfYeIgko()
	{
		return ol4wHVrV6ogvZm5EWKm == null;
	}

	internal static GroupPermissionEventArgs LXQfUtrdmv95LsdGQXs()
	{
		return ol4wHVrV6ogvZm5EWKm;
	}
}
