using System;
using System.Text;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Web.Models;

public class MarketingStatisticState
{
	private const string MarketingStatisticStateString = "MarketingStatisticState";

	private const string MarketingStatisticStateUid = "ED6F1768-5122-474F-A965-F1252B8C183C";

	public DateTime CurrentDate { get; set; }

	public MarketingPeriodEnum Mode { get; set; }

	public MarketingStatisticState()
	{
		CurrentDate = DateTime.Today;
		Mode = MarketingPeriodEnum.Month;
	}

	public static MarketingStatisticState LoadState()
	{
		byte[] array = Locator.GetServiceNotNull<IBLOBStore>().LoadOrNull(GetBlobKey());
		if (array == null)
		{
			return new MarketingStatisticState();
		}
		return ClassSerializationHelper.DeserializeObjectByJson<MarketingStatisticState>(Encoding.UTF8.GetString(array));
	}

	public static void SaveState(DateTime date, MarketingPeriodEnum mode)
	{
		string blobKey = GetBlobKey();
		IBLOBStore serviceNotNull = Locator.GetServiceNotNull<IBLOBStore>();
		byte[] array = serviceNotNull.LoadOrNull(blobKey);
		MarketingStatisticState marketingStatisticState = ((array != null) ? ClassSerializationHelper.DeserializeObjectByJson<MarketingStatisticState>(Encoding.UTF8.GetString(array)) : new MarketingStatisticState());
		marketingStatisticState.CurrentDate = date;
		marketingStatisticState.Mode = mode;
		serviceNotNull.Save(blobKey, Encoding.UTF8.GetBytes(ClassSerializationHelper.SerializeObjectByJson(marketingStatisticState)));
	}

	private static string GetBlobKey()
	{
		return string.Format("{0}_{1}_{2}", "ED6F1768-5122-474F-A965-F1252B8C183C", Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser().UserName, "MarketingStatisticState");
	}
}
