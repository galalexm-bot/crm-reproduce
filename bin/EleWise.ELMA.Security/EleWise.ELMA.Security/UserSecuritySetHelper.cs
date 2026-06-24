using System;

namespace EleWise.ELMA.Security;

public static class UserSecuritySetHelper
{
	private static UserSecuritySetHelper kNiX1nNEG68WUGVyDxG;

	public static long UserMask => 72057594037927936L;

	public static long GroupMask => 144115188075855872L;

	public static long OrganizationItemMask => 216172782113783808L;

	public static bool IsGroup(long? id)
	{
		if (id.HasValue)
		{
			return (id & 0x200000000000000L) != 0;
		}
		return false;
	}

	public static bool IsUser(long? id)
	{
		if (id.HasValue)
		{
			return (id & 0x100000000000000L) != 0;
		}
		return false;
	}

	public static bool IsDepartament(long? id)
	{
		if (id.HasValue)
		{
			return (id & 0x300000000000000L) != 0;
		}
		return false;
	}

	public static bool IsPost(long? id)
	{
		if (id.HasValue)
		{
			return (id & 0x300000000000000L) != 0;
		}
		return false;
	}

	public static long GetGroupMask(long id)
	{
		return id | 0x200000000000000L;
	}

	public static long GetOrganizationItemMask(long id)
	{
		return id | 0x300000000000000L;
	}

	[Obsolete("Следует использовать GetOrganizationItemMask вместо GetPostMask", false)]
	public static long GetPostMask(long id)
	{
		return id | 0x300000000000000L;
	}

	public static long GetUserMask(long id)
	{
		return id | 0x100000000000000L;
	}

	internal static bool PvILlUNDd7wJb2dj5am()
	{
		return kNiX1nNEG68WUGVyDxG == null;
	}

	internal static UserSecuritySetHelper g5ZFNCNMhdPNBnTtclh()
	{
		return kNiX1nNEG68WUGVyDxG;
	}
}
