// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Extensions.HtmlExtensions
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Code;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace EleWise.ELMA.CRM.Web.Extensions
{
  public static class HtmlExtensions
  {
    public static MvcHtmlString AddressContent<TModel, TType>(
      this HtmlHelper<TModel> html,
      Func<object, object> content,
      params TType[] types)
      where TModel : IAddress
      where TType : struct
    {
      if (!typeof (TType).IsEnum)
        throw new ArgumentException("TType must be an enumerated type");
      Guid? parent = AddressComboBoxItemControl.Parent;
      object[] types1 = AddressComboBoxItemControl.Types;
      ICountry country = AddressComboBoxItemControl.Country;
      AddressComboBoxItemControl.Parent = new Guid?();
      AddressComboBoxItemControl.Types = Enumerable.Cast<object>(types).ToArray<object>();
      AddressComboBoxItemControl.Country = html.ViewData.Model.Country;
      try
      {
        return MvcHtmlString.Create(html.Partial("Address/ContentBegin").ToString() + content((object) null));
      }
      finally
      {
        AddressComboBoxItemControl.Parent = parent;
        AddressComboBoxItemControl.Types = types1;
        AddressComboBoxItemControl.Country = country;
      }
    }

    private static MvcHtmlString AddressItemComboBox(
      Func<Action<WebViewAttributes>, MvcHtmlString> render,
      bool showDropDown)
    {
      bool? showDropDownValue = AddressComboBoxItemControl.ShowDropDownValue;
      AddressComboBoxItemControl.ShowDropDownValue = new bool?(showDropDown);
      try
      {
        return render((Action<WebViewAttributes>) (a => a.TemplateName = "Address/ComboBox"));
      }
      finally
      {
        AddressComboBoxItemControl.ShowDropDownValue = showDropDownValue;
      }
    }

    private static MvcHtmlString AddressItemTextBox(
      Func<Action<WebViewAttributes>, MvcHtmlString> render,
      int? maxlength = null)
    {
      return render((Action<WebViewAttributes>) (a =>
      {
        a.TemplateName = "Address/TextBox";
        a.AdditionalViewData = new RouteValueDictionary((object) new
        {
          maxlength = maxlength
        });
      }));
    }

    private static MvcHtmlString AddressItemWithAptType(
      HtmlHelper html,
      string expression,
      MvcHtmlString value)
    {
      HtmlHelper htmlHelper = html;
      PropertyRowModel model = new PropertyRowModel();
      WebViewAttributes webViewAttributes = new WebViewAttributes();
      webViewAttributes.LabelStyle = "white-space:unset;";
      model.ViewAttributes = webViewAttributes;
      model.ModelName = html.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(expression);
      model.Caption = ModelExtensions.Editor(html, "AptType", (Action<WebViewAttributes>) (a => a.TemplateName = "Address/AptType"));
      model.Value = value;
      return htmlHelper.Partial("Templates/PropertyRow", (object) model);
    }

    public static MvcHtmlString AddressItemComboBox<TModel, TValue>(
      this HtmlHelper<TModel> html,
      Expression<Func<TModel, TValue>> expression,
      bool showDropDown = false)
      where TModel : IAddress
    {
      return HtmlExtensions.AddressItemComboBox((Func<Action<WebViewAttributes>, MvcHtmlString>) (action => html.EditableProperty<TModel, TValue>(expression, action)), showDropDown);
    }

    public static MvcHtmlString AddressItemComboBox(
      this HtmlHelper html,
      string expression,
      bool showDropDown = false)
    {
      return HtmlExtensions.AddressItemComboBox((Func<Action<WebViewAttributes>, MvcHtmlString>) (action => html.EditableProperty(expression, action)), showDropDown);
    }

    public static MvcHtmlString AddressItemTextBox<TModel, TValue>(
      this HtmlHelper<TModel> html,
      Expression<Func<TModel, TValue>> expression)
    {
      return HtmlExtensions.AddressItemTextBox((Func<Action<WebViewAttributes>, MvcHtmlString>) (action => html.EditableProperty<TModel, TValue>(expression, action)));
    }

    public static MvcHtmlString AddressItemTextBox<TModel, TValue>(
      this HtmlHelper<TModel> html,
      Expression<Func<TModel, TValue>> expression,
      int maxlength)
    {
      return HtmlExtensions.AddressItemTextBox((Func<Action<WebViewAttributes>, MvcHtmlString>) (action => html.EditableProperty<TModel, TValue>(expression, action)), new int?(maxlength));
    }

    public static MvcHtmlString AddressItemTextBox(
      this HtmlHelper html,
      string expression,
      int maxlength)
    {
      return HtmlExtensions.AddressItemTextBox((Func<Action<WebViewAttributes>, MvcHtmlString>) (action => html.EditableProperty(expression, action)), new int?(maxlength));
    }

    public static MvcHtmlString AddressItemTextBox(this HtmlHelper html, string expression) => HtmlExtensions.AddressItemTextBox((Func<Action<WebViewAttributes>, MvcHtmlString>) (action => html.EditableProperty(expression, action)));

    public static MvcHtmlString AddressItemComboBoxWithAptType<TModel, TValue>(
      this HtmlHelper<TModel> html,
      Expression<Func<TModel, TValue>> expression,
      bool showDropDown = false)
    {
      return HtmlExtensions.AddressItemWithAptType((HtmlHelper) html, ExpressionHelper.GetExpressionText((LambdaExpression) expression), HtmlExtensions.AddressItemComboBox((Func<Action<WebViewAttributes>, MvcHtmlString>) (action => html.Editor<TModel, TValue>(expression, action)), showDropDown));
    }

    public static MvcHtmlString AddressItemComboBoxWithAptType(
      this HtmlHelper html,
      string expression,
      bool showDropDown = false)
    {
      return HtmlExtensions.AddressItemWithAptType(html, expression, HtmlExtensions.AddressItemComboBox((Func<Action<WebViewAttributes>, MvcHtmlString>) (action => ModelExtensions.Editor(html, expression, action)), showDropDown));
    }

    public static MvcHtmlString AddressItemTextBoxWithAptType<TModel, TValue>(
      this HtmlHelper<TModel> html,
      Expression<Func<TModel, TValue>> expression)
    {
      return HtmlExtensions.AddressItemWithAptType((HtmlHelper) html, ExpressionHelper.GetExpressionText((LambdaExpression) expression), HtmlExtensions.AddressItemTextBox((Func<Action<WebViewAttributes>, MvcHtmlString>) (action => html.Editor<TModel, TValue>(expression, action))));
    }

    public static MvcHtmlString AddressItemTextBoxWithAptType<TModel, TValue>(
      this HtmlHelper<TModel> html,
      Expression<Func<TModel, TValue>> expression,
      int maxlength)
    {
      return HtmlExtensions.AddressItemWithAptType((HtmlHelper) html, ExpressionHelper.GetExpressionText((LambdaExpression) expression), HtmlExtensions.AddressItemTextBox((Func<Action<WebViewAttributes>, MvcHtmlString>) (action => html.Editor<TModel, TValue>(expression, action)), new int?(maxlength)));
    }

    public static MvcHtmlString AddressItemTextBoxWithAptType(
      this HtmlHelper html,
      string expression)
    {
      return HtmlExtensions.AddressItemWithAptType(html, expression, HtmlExtensions.AddressItemTextBox((Func<Action<WebViewAttributes>, MvcHtmlString>) (action => ModelExtensions.Editor(html, expression, action))));
    }

    public static MvcHtmlString AddressItemTextBoxWithAptType(
      this HtmlHelper html,
      string expression,
      int maxlength)
    {
      return HtmlExtensions.AddressItemWithAptType(html, expression, HtmlExtensions.AddressItemTextBox((Func<Action<WebViewAttributes>, MvcHtmlString>) (action => ModelExtensions.Editor(html, expression, action)), new int?(maxlength)));
    }
  }
}
