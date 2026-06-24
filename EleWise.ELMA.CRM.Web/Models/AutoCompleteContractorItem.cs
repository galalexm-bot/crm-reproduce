// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.AutoCompleteContractorItem
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.Models.Boxes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class AutoCompleteContractorItem : AutocompleteItem
  {
    public static AutoCompleteContractorItem[] GetItems(IEnumerable<IContractor> contractors) => contractors.Where<IContractor>((Func<IContractor, bool>) (u => u != null)).Select<IContractor, AutoCompleteContractorItem>((Func<IContractor, AutoCompleteContractorItem>) (u =>
    {
      return new AutoCompleteContractorItem()
      {
        Value = u.Id.ToString(),
        Text = u.Name,
        ViewText = u.Name
      };
    })).Where<AutoCompleteContractorItem>((Func<AutoCompleteContractorItem, bool>) (i => !string.IsNullOrEmpty(i.Text))).ToArray<AutoCompleteContractorItem>();

    public static AutoCompleteContractorItem GetItem(IContractor contractor)
    {
      if (contractor == null)
        return (AutoCompleteContractorItem) null;
      AutoCompleteContractorItem completeContractorItem = new AutoCompleteContractorItem();
      completeContractorItem.Value = contractor.Id.ToString();
      completeContractorItem.Text = contractor.Name;
      completeContractorItem.ViewText = contractor.Name;
      return completeContractorItem;
    }
  }
}
