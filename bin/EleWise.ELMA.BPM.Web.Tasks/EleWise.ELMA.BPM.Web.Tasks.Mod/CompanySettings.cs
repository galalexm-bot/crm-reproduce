using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.BPM.Web.Tasks.Models.Settings;

[Serializable]
public class CompanySettings
{
	public KeyIndicator KeyFeature { get; set; }

	public DateTime Period { get; set; }

	public SearchType LastSearchType { get; set; }

	public bool IsNew { get; set; }

	public List<long> PreviousLoadedUsersIds { get; set; }

	public List<long> LoadedUsersIds { get; set; }

	public List<long> CheckedUsersIds { get; set; }

	public List<long> LastUsersIds { get; set; }

	public void AddLastUser(long userId)
	{
		if (IsNew)
		{
			ClearLastUsers();
			IsNew = false;
		}
		if (LastUsersIds == null)
		{
			LastUsersIds = new List<long>();
		}
		if (!LastUsersIds.Contains(userId))
		{
			LastUsersIds.Add(userId);
		}
	}

	public void AddLoadedUser(long userId)
	{
		if (LoadedUsersIds == null)
		{
			LoadedUsersIds = new List<long>();
		}
		if (!LoadedUsersIds.Contains(userId))
		{
			LoadedUsersIds.Add(userId);
		}
	}

	public void AddCheckedUser(long userId)
	{
		if (CheckedUsersIds == null)
		{
			CheckedUsersIds = new List<long>();
		}
		if (!CheckedUsersIds.Contains(userId))
		{
			CheckedUsersIds.Add(userId);
		}
	}

	public void RemoveLastUser(long userId)
	{
		LastUsersIds.Remove(userId);
	}

	public void RemoveLoadedUser(long userId)
	{
		LoadedUsersIds.Remove(userId);
	}

	public void RemoveCheckedUser(long userId)
	{
		CheckedUsersIds.Remove(userId);
	}

	public void ClearLastUsers()
	{
		LastUsersIds = new List<long>();
	}

	public void ClearLoadedUsers()
	{
		LoadedUsersIds = new List<long>();
	}

	public void ClearCheckedUsers(bool clearPrevious = false)
	{
		if (clearPrevious)
		{
			PreviousLoadedUsersIds = new List<long>();
		}
		CheckedUsersIds = new List<long>();
	}

	public CompanySettings()
	{
		KeyFeature = KeyIndicator.Discipline;
		Period = DateTime.Now;
		PreviousLoadedUsersIds = new List<long>();
		LoadedUsersIds = new List<long>();
		CheckedUsersIds = new List<long>();
		LastUsersIds = new List<long>();
		LastSearchType = SearchType.Department;
	}

	public CompanySettings(CompanySettings other)
	{
		KeyFeature = other.KeyFeature;
		Period = other.Period;
		LastSearchType = other.LastSearchType;
		IsNew = other.IsNew;
		PreviousLoadedUsersIds = other.PreviousLoadedUsersIds.ToList();
		LoadedUsersIds = other.LoadedUsersIds.ToList();
		CheckedUsersIds = other.CheckedUsersIds.ToList();
		LastUsersIds = other.LastUsersIds.ToList();
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() != typeof(CompanySettings))
		{
			return false;
		}
		return Equals((CompanySettings)obj);
	}

	public bool Equals(CompanySettings obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (object.Equals(obj.KeyFeature, KeyFeature) && object.Equals(obj.Period, Period) && object.Equals(obj.LastSearchType, LastSearchType) && object.Equals(obj.IsNew, IsNew) && ((obj.PreviousLoadedUsersIds == null && PreviousLoadedUsersIds == null) || (obj.PreviousLoadedUsersIds != null && PreviousLoadedUsersIds != null && obj.PreviousLoadedUsersIds.SequenceEqual(PreviousLoadedUsersIds))) && ((obj.LoadedUsersIds == null && LoadedUsersIds == null) || (obj.LoadedUsersIds != null && LoadedUsersIds != null && obj.LoadedUsersIds.SequenceEqual(LoadedUsersIds))) && ((obj.CheckedUsersIds == null && CheckedUsersIds == null) || (obj.CheckedUsersIds != null && CheckedUsersIds != null && obj.CheckedUsersIds.SequenceEqual(CheckedUsersIds))))
		{
			if (obj.LastUsersIds != null || LastUsersIds != null)
			{
				if (obj.LastUsersIds != null && LastUsersIds != null)
				{
					return obj.LastUsersIds.SequenceEqual(LastUsersIds);
				}
				return false;
			}
			return true;
		}
		return false;
	}
}
