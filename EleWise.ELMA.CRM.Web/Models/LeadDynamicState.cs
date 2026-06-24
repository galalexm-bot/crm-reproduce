// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.LeadDynamicState
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
  public class LeadDynamicState
  {
    private const string LeadDynamicStateString = "LeadDynamicState";
    private const string LeadDynamicStateUid = "4C406722-6C4F-4E6F-8032-A17C3B3C36B8";

    public LeadDynamicState()
    {
      this.List = new System.Collections.Generic.List<long>();
      this.CurrentDate = DateTime.Today;
      this.Mode = MarketingPeriodEnum.Month;
      this.ShowArchive = false;
      this.ShowStatistic = true;
    }

    public System.Collections.Generic.List<long> List { get; set; }

    public DateTime CurrentDate { get; set; }

    public MarketingPeriodEnum Mode { get; set; }

    public bool ShowStatistic { get; set; }

    public bool ShowArchive { get; set; }

    public static LeadDynamicState LoadState()
    {
      string blobKey = LeadDynamicState.GetBlobKey();
      byte[] bytes = Locator.GetServiceNotNull<IBLOBStore>().LoadOrNull(blobKey);
      return bytes == null ? new LeadDynamicState() : ClassSerializationHelper.DeserializeObjectByJson<LeadDynamicState>(Encoding.UTF8.GetString(bytes));
    }

    public static void SaveState(
      DateTime date,
      MarketingPeriodEnum mode,
      bool showArchive,
      bool showStatistic)
    {
      string blobKey = LeadDynamicState.GetBlobKey();
      IBLOBStore serviceNotNull = Locator.GetServiceNotNull<IBLOBStore>();
      byte[] bytes = serviceNotNull.LoadOrNull(blobKey);
      LeadDynamicState leadDynamicState = bytes != null ? ClassSerializationHelper.DeserializeObjectByJson<LeadDynamicState>(Encoding.UTF8.GetString(bytes)) : new LeadDynamicState();
      leadDynamicState.CurrentDate = date;
      leadDynamicState.Mode = mode;
      leadDynamicState.ShowArchive = showArchive;
      leadDynamicState.ShowStatistic = showStatistic;
      serviceNotNull.Save(blobKey, Encoding.UTF8.GetBytes(ClassSerializationHelper.SerializeObjectByJson((object) leadDynamicState)));
    }

    public static void SaveIdsState(long id, bool expanding)
    {
      string blobKey = LeadDynamicState.GetBlobKey();
      IBLOBStore serviceNotNull = Locator.GetServiceNotNull<IBLOBStore>();
      byte[] bytes = serviceNotNull.LoadOrNull(blobKey);
      LeadDynamicState leadDynamicState = bytes != null ? ClassSerializationHelper.DeserializeObjectByJson<LeadDynamicState>(Encoding.UTF8.GetString(bytes)) : new LeadDynamicState();
      if (expanding)
        leadDynamicState.List.Add(id);
      else
        leadDynamicState.List.Remove(id);
      serviceNotNull.Save(blobKey, Encoding.UTF8.GetBytes(ClassSerializationHelper.SerializeObjectByJson((object) leadDynamicState)));
    }

    private static string GetBlobKey() => string.Format("{0}_{1}_{2}", (object) "4C406722-6C4F-4E6F-8032-A17C3B3C36B8", (object) Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser().UserName, (object) nameof (LeadDynamicState));
  }
}
