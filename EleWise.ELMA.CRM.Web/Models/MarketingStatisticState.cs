// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.MarketingStatisticState
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using System;
using System.Text;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class MarketingStatisticState
  {
    private const string MarketingStatisticStateString = "MarketingStatisticState";
    private const string MarketingStatisticStateUid = "ED6F1768-5122-474F-A965-F1252B8C183C";

    public MarketingStatisticState()
    {
      this.CurrentDate = DateTime.Today;
      this.Mode = MarketingPeriodEnum.Month;
    }

    public DateTime CurrentDate { get; set; }

    public MarketingPeriodEnum Mode { get; set; }

    public static MarketingStatisticState LoadState()
    {
      byte[] bytes = Locator.GetServiceNotNull<IBLOBStore>().LoadOrNull(MarketingStatisticState.GetBlobKey());
      return bytes == null ? new MarketingStatisticState() : ClassSerializationHelper.DeserializeObjectByJson<MarketingStatisticState>(Encoding.UTF8.GetString(bytes));
    }

    public static void SaveState(DateTime date, MarketingPeriodEnum mode)
    {
      string blobKey = MarketingStatisticState.GetBlobKey();
      IBLOBStore serviceNotNull = Locator.GetServiceNotNull<IBLOBStore>();
      byte[] bytes = serviceNotNull.LoadOrNull(blobKey);
      MarketingStatisticState marketingStatisticState = bytes != null ? ClassSerializationHelper.DeserializeObjectByJson<MarketingStatisticState>(Encoding.UTF8.GetString(bytes)) : new MarketingStatisticState();
      marketingStatisticState.CurrentDate = date;
      marketingStatisticState.Mode = mode;
      serviceNotNull.Save(blobKey, Encoding.UTF8.GetBytes(ClassSerializationHelper.SerializeObjectByJson((object) marketingStatisticState)));
    }

    private static string GetBlobKey() => string.Format("{0}_{1}_{2}", (object) "ED6F1768-5122-474F-A965-F1252B8C183C", (object) Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser().UserName, (object) nameof (MarketingStatisticState));
  }
}
