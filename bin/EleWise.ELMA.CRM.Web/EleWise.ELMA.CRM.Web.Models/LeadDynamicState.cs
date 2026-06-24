using System;
using System.Collections.Generic;
using System.Text;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Web.Models;

public class LeadDynamicState
{
	private const string LeadDynamicStateString = "LeadDynamicState";

	private const string LeadDynamicStateUid = "4C406722-6C4F-4E6F-8032-A17C3B3C36B8";

	public List<long> List { get; set; }

	public DateTime CurrentDate { get; set; }

	public MarketingPeriodEnum Mode { get; set; }

	public bool ShowStatistic { get; set; }

	public bool ShowArchive { get; set; }

	public LeadDynamicState()
	{
		List = new List<long>();
		CurrentDate = DateTime.Today;
		Mode = MarketingPeriodEnum.Month;
		ShowArchive = false;
		ShowStatistic = true;
	}

	public static LeadDynamicState LoadState()
	{
		string blobKey = GetBlobKey();
		byte[] array = Locator.GetServiceNotNull<IBLOBStore>().LoadOrNull(blobKey);
		if (array == null)
		{
			return new LeadDynamicState();
		}
		return ClassSerializationHelper.DeserializeObjectByJson<LeadDynamicState>(Encoding.UTF8.GetString(array));
	}

	public static void SaveState(DateTime date, MarketingPeriodEnum mode, bool showArchive, bool showStatistic)
	{
		string blobKey = GetBlobKey();
		IBLOBStore serviceNotNull = Locator.GetServiceNotNull<IBLOBStore>();
		byte[] array = serviceNotNull.LoadOrNull(blobKey);
		LeadDynamicState leadDynamicState = ((array != null) ? ClassSerializationHelper.DeserializeObjectByJson<LeadDynamicState>(Encoding.UTF8.GetString(array)) : new LeadDynamicState());
		leadDynamicState.CurrentDate = date;
		leadDynamicState.Mode = mode;
		leadDynamicState.ShowArchive = showArchive;
		leadDynamicState.ShowStatistic = showStatistic;
		serviceNotNull.Save(blobKey, Encoding.UTF8.GetBytes(ClassSerializationHelper.SerializeObjectByJson(leadDynamicState)));
	}

	public static void SaveIdsState(long id, bool expanding)
	{
		string blobKey = GetBlobKey();
		IBLOBStore serviceNotNull = Locator.GetServiceNotNull<IBLOBStore>();
		byte[] array = serviceNotNull.LoadOrNull(blobKey);
		LeadDynamicState leadDynamicState = ((array != null) ? ClassSerializationHelper.DeserializeObjectByJson<LeadDynamicState>(Encoding.UTF8.GetString(array)) : new LeadDynamicState());
		if (expanding)
		{
			leadDynamicState.List.Add(id);
		}
		else
		{
			leadDynamicState.List.Remove(id);
		}
		serviceNotNull.Save(blobKey, Encoding.UTF8.GetBytes(ClassSerializationHelper.SerializeObjectByJson(leadDynamicState)));
	}

	private static string GetBlobKey()
	{
		return string.Format("{0}_{1}_{2}", "4C406722-6C4F-4E6F-8032-A17C3B3C36B8", Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser().UserName, "LeadDynamicState");
	}
}
