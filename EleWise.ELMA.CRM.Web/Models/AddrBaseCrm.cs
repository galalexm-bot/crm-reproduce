// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.AddrBaseCrm
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Models
{
  [Obsolete]
  public class AddrBaseCrm
  {
    public long Id { get; set; }

    public Guid? Uid { get; set; }

    public Guid? ParentGuid { get; set; }

    public int TypeOfSub { get; set; }

    public string CountryCode { get; set; }

    public string ObjectName { get; set; }

    public string ShortName { get; set; }

    public string Zip { get; set; }

    public string FiasCode { get; set; }

    public DateTime UpdateDate { get; set; }

    public bool Actual { get; set; }

    public long Value { get; set; }

    public string Text { get; set; }

    public static AddrBaseCrm[] GetItems(UrlHelper helper, IEnumerable<IAddrBase> addrs) => addrs.Where<IAddrBase>((Func<IAddrBase, bool>) (u => u != null)).Select<IAddrBase, AddrBaseCrm>((Func<IAddrBase, AddrBaseCrm>) (u => AddrBaseCrm.GetItem(helper, u))).Where<AddrBaseCrm>((Func<AddrBaseCrm, bool>) (i => !string.IsNullOrEmpty(i.ObjectName))).ToArray<AddrBaseCrm>();

    public static AddrBaseCrm GetItem(UrlHelper helper, IAddrBase addr)
    {
      if (addr == null)
        return (AddrBaseCrm) null;
      string str = addr.ObjectName + " " + addr.ShortName;
      return new AddrBaseCrm()
      {
        Id = addr.Id,
        ObjectName = addr.ObjectName,
        Zip = addr.ZIP,
        Value = addr.Id,
        Text = str,
        Uid = new Guid?(addr.Uid),
        CountryCode = addr.CountryCode
      };
    }
  }
}
