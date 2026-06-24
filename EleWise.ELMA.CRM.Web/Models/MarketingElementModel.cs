// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.MarketingElementModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class MarketingElementModel
  {
    private readonly int countColumn;

    public MarketingElementModel()
    {
    }

    public MarketingElementModel(
      IMarketingGroup group,
      IEnumerable<LeadDynamicCount> listCount,
      int countCol,
      bool showArchive = false)
    {
      this.Entity = (IMarketingBase) group;
      this.AnyChildren = showArchive ? group.MarketingActivities.Any<IMarketingActivity>((Func<IMarketingActivity, bool>) (m => !((IMarketingBase) m).IsDeleted && m.Status == MarketingObjectStatus.Archived)) : group.MarketingActivities.Any<IMarketingActivity>((Func<IMarketingActivity, bool>) (m => !((IMarketingBase) m).IsDeleted && m.Status == MarketingObjectStatus.Active));
      this.countColumn = countCol;
      this.SetCount(listCount.Where<LeadDynamicCount>((Func<LeadDynamicCount, bool>) (m => m.MarketingGroup != null && m.MarketingGroup.Id == group.Id)));
    }

    public MarketingElementModel(
      IEnumerable<LeadDynamicCount> listCount,
      int countCol,
      bool showArchive = false)
    {
      this.Entity = (IMarketingBase) null;
      this.AnyChildren = true;
      this.countColumn = countCol;
      this.SetCount(listCount);
    }

    public MarketingElementModel(
      IMarketingActivity activity,
      IEnumerable<LeadDynamicCount> listCount,
      int countCol,
      bool showArchive = false)
    {
      this.Entity = (IMarketingBase) activity;
      this.AnyChildren = showArchive ? activity.MarketingEffects.Any<IMarketingEffect>((Func<IMarketingEffect, bool>) (m => !((IMarketingBase) m).IsDeleted && m.Status == MarketingObjectStatus.Archived)) : activity.MarketingEffects.Any<IMarketingEffect>((Func<IMarketingEffect, bool>) (m => !((IMarketingBase) m).IsDeleted && m.Status == MarketingObjectStatus.Active));
      this.countColumn = countCol;
      this.SetCount(listCount.Where<LeadDynamicCount>((Func<LeadDynamicCount, bool>) (m => m.MarketingActivity != null && m.MarketingActivity.Id == activity.Id)));
    }

    public MarketingElementModel(
      IMarketingEffect effect,
      IEnumerable<LeadDynamicCount> listCount,
      int countCol,
      bool showArchive = false)
    {
      this.Entity = (IMarketingBase) effect;
      this.countColumn = countCol;
      this.SetCount(listCount.Where<LeadDynamicCount>((Func<LeadDynamicCount, bool>) (m => m.MarketingEffect != null && m.MarketingEffect.Id == effect.Id)));
    }

    private void SetCount(IEnumerable<LeadDynamicCount> resultList)
    {
      this.AllCountMonth = new long[this.countColumn];
      this.ConvertedCountMonth = new long[this.countColumn];
      if (resultList == null || !resultList.Any<LeadDynamicCount>())
        return;
      for (int i = 0; i < this.countColumn; i++)
      {
        this.AllCountMonth[i] = resultList.Sum<LeadDynamicCount>((Func<LeadDynamicCount, long>) (m => m.AllCountMonth[i]));
        this.ConvertedCountMonth[i] = resultList.Sum<LeadDynamicCount>((Func<LeadDynamicCount, long>) (m => m.ConvertedCountMonth[i]));
      }
    }

    public IMarketingBase Entity { get; set; }

    public long[] AllCountMonth { get; set; }

    public long[] ConvertedCountMonth { get; set; }

    public bool AnyChildren { get; set; }

    public bool IsShow { get; set; }

    public bool UserHasCreateItemsPermission { get; set; }
  }
}
