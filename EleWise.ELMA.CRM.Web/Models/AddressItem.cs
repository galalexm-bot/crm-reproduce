// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.AddressItem
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class AddressItem : DropDownItem
  {
    public Guid? Uid { get; set; }

    public string Zip { get; set; }

    public static AddressItem[] GetItems(IEnumerable<IAddrBase> addrs) => addrs.Where<IAddrBase>((Func<IAddrBase, bool>) (u => u != null && !string.IsNullOrEmpty(u.ObjectName))).OrderBy<IAddrBase, string>((Func<IAddrBase, string>) (u => u.ObjectName)).Select<IAddrBase, AddressItem>(new Func<IAddrBase, AddressItem>(AddressItem.GetItem)).ToArray<AddressItem>();

    public static AddressItem GetItem(IAddrBase addr)
    {
      if (addr == null)
        return (AddressItem) null;
      AddressItem addressItem = new AddressItem();
      addressItem.Zip = addr.ZIP;
      addressItem.Value = addr.Id.ToString();
      addressItem.Text = addr.ObjectName + " " + addr.ShortName;
      addressItem.Uid = new Guid?(addr.Uid);
      return addressItem;
    }
  }
}
