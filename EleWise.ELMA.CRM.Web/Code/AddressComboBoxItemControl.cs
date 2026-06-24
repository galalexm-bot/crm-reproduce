// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Code.AddressComboBoxItemControl
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Services;
using System;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Code
{
  public abstract class AddressComboBoxItemControl : WebViewPage<string>
  {
    private const string callContextParentName = "AddressItemControlParent";
    private const string callContextTypesName = "AddressItemControlTypes";
    private const string callContextCountryName = "AddressItemControlCountry";
    private const string callContextShowDropDownName = "AddressItemControlShowDropDown";

    internal static object[] Types
    {
      get => ContextVars.GetOrDefault<object[]>("AddressItemControlTypes");
      set => ContextVars.Set<object[]>("AddressItemControlTypes", value);
    }

    internal static ICountry Country
    {
      get => ContextVars.GetOrDefault<ICountry>("AddressItemControlCountry");
      set => ContextVars.Set<ICountry>("AddressItemControlCountry", value);
    }

    internal static bool? ShowDropDownValue
    {
      get => ContextVars.GetOrDefault<bool?>("AddressItemControlShowDropDown");
      set => ContextVars.Set<bool?>("AddressItemControlShowDropDown", value);
    }

    protected internal static Guid? Parent
    {
      get => ContextVars.GetOrDefault<Guid?>("AddressItemControlParent");
      set => ContextVars.Set<Guid?>("AddressItemControlParent", value);
    }

    protected long? CountryCode => AddressComboBoxItemControl.Country == null ? new long?() : new long?(AddressComboBoxItemControl.Country.CountryCode);

    protected bool ShowDropDown => AddressComboBoxItemControl.ShowDropDownValue ?? false;

    protected object CurrentType => Array.Find<object>(AddressComboBoxItemControl.Types, (Predicate<object>) (t => t != null && t.ToString() == this.ViewData.ModelMetadata.PropertyName));

    protected object ParentType
    {
      get
      {
        int index = Array.IndexOf<object>(AddressComboBoxItemControl.Types, this.CurrentType) - 1;
        return index < 0 ? (object) null : AddressComboBoxItemControl.Types[index];
      }
    }

    protected object ChildType
    {
      get
      {
        int index = Array.IndexOf<object>(AddressComboBoxItemControl.Types, this.CurrentType) + 1;
        return index >= AddressComboBoxItemControl.Types.Length ? (object) null : AddressComboBoxItemControl.Types[index];
      }
    }
  }
}
