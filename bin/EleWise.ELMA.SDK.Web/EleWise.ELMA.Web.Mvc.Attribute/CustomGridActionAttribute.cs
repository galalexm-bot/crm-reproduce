using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;
using Telerik.Web.Mvc.Extensions;
using Telerik.Web.Mvc.Infrastructure;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Web.Mvc.Attributes;

[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
public class CustomGridActionAttribute : ActionFilterAttribute
{
	private class GridJsonCatchViewResult : JsonCatchViewResult
	{
		public GridJsonCatchViewResult(ViewResultBase actionResult)
			: base(actionResult, (ControllerContext context) => ((IDictionary<string, object>)context.get_HttpContext().Items["GridResultDictionary"]) ?? new Dictionary<string, object>())
		{
		}

		public override void ExecuteResult(ControllerContext context)
		{
			base.ExecuteResult(context);
			if (base.JsonResult == null)
			{
				throw new InvalidOperationException("JsonResult is null");
			}
			string value = ((object)base.JsonResult.ToJson()).ToString();
			context.get_HttpContext().Response.Output.Write(value);
		}
	}

	public string ActionParameterName { get; set; }

	public string GridName { get; set; }

	public bool EnableCustomBinding { get; set; }

	public CustomGridActionAttribute()
	{
		ActionParameterName = "command";
		((FilterAttribute)this).set_Order(2);
	}

	private string Prefix(string key)
	{
		if (!string.IsNullOrEmpty(GridName))
		{
			return GridName + "-" + key;
		}
		return key;
	}

	public override void OnActionExecuting(ActionExecutingContext filterContext)
	{
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		if (!filterContext.get_ActionParameters().ContainsKey(ActionParameterName))
		{
			return;
		}
		string text = GridControllerExtensions.ValueOf<string>(((ControllerContext)filterContext).get_Controller(), "gridStateId");
		string text2 = ((ControllerContext)filterContext).get_HttpContext().Request.Params.Get("gridId");
		string text3 = GridControllerExtensions.ValueOf<string>(((ControllerContext)filterContext).get_Controller(), "provider");
		if (GridControllerExtensions.ValueOf<bool>(((ControllerContext)filterContext).get_Controller(), "isStateSaving"))
		{
			return;
		}
		if (string.IsNullOrEmpty(text2))
		{
			filterContext.get_ActionParameters()[ActionParameterName] = null;
			return;
		}
		GridCommand val = null;
		string text4 = GridControllerExtensions.ValueOf<string>(((ControllerContext)filterContext).get_Controller(), Prefix(GridUrlParameters.get_GridPrefix()));
		if (text4 != null && !text2.Equals(text4))
		{
			GridState gridState = GridPersonalizationAdministration.LoadState(text4, (!string.IsNullOrEmpty(text3)) ? new Guid(text3) : Guid.Empty);
			if (gridState != null)
			{
				GridCommand val2 = new GridCommand();
				val2.set_Page(gridState.CurrentPage);
				val2.set_PageSize(gridState.PageSize);
				val = val2;
				if (gridState.GroupDescriptors != null)
				{
					foreach (GridGroupDescriptor groupDescriptor in gridState.GroupDescriptors)
					{
						IList<GroupDescriptor> groupDescriptors = val.get_GroupDescriptors();
						GroupDescriptor val3 = new GroupDescriptor();
						((SortDescriptor)val3).set_Member(groupDescriptor.Member);
						((SortDescriptor)val3).set_SortDirection(groupDescriptor.SortDirection);
						groupDescriptors.Add(val3);
					}
				}
				IList<SortDescriptor> sortDescriptors = val.get_SortDescriptors();
				SortDescriptor val4 = new SortDescriptor();
				val4.set_Member(val.get_SortExpressionString());
				val4.set_SortDirection(val.get_SortDirection());
				sortDescriptors.Add(val4);
				GridPersonalizationAdministration.SaveState(text4, gridState, (!string.IsNullOrEmpty(text3)) ? new Guid(text3) : Guid.Empty, true);
			}
		}
		else
		{
			if (!string.IsNullOrWhiteSpace(text))
			{
				text2 = text;
			}
			GridCommand val5 = new GridCommand();
			val5.set_Page(GridControllerExtensions.ValueOf<int>(((ControllerContext)filterContext).get_Controller(), Prefix(GridUrlParameters.get_CurrentPage())));
			val5.set_PageSize(GridControllerExtensions.ValueOf<int>(((ControllerContext)filterContext).get_Controller(), Prefix(GridUrlParameters.get_PageSize())));
			val = val5;
			string text5 = GridControllerExtensions.ValueOf<string>(((ControllerContext)filterContext).get_Controller(), Prefix(GridUrlParameters.get_OrderBy()));
			CollectionExtensions.AddRange<SortDescriptor>((ICollection<SortDescriptor>)val.get_SortDescriptors(), (IEnumerable<SortDescriptor>)GridDescriptorSerializer.Deserialize<SortDescriptor>(text5));
			string text6 = GridControllerExtensions.ValueOf<string>(((ControllerContext)filterContext).get_Controller(), Prefix(GridUrlParameters.get_Filter()));
			CollectionExtensions.AddRange<IFilterDescriptor>((ICollection<IFilterDescriptor>)val.get_FilterDescriptors(), (IEnumerable<IFilterDescriptor>)FilterDescriptorFactory.Create(text6));
			string text7 = GridControllerExtensions.ValueOf<string>(((ControllerContext)filterContext).get_Controller(), Prefix(GridUrlParameters.get_GroupBy()));
			CollectionExtensions.AddRange<GroupDescriptor>((ICollection<GroupDescriptor>)val.get_GroupDescriptors(), (IEnumerable<GroupDescriptor>)GridDescriptorSerializer.Deserialize<GroupDescriptor>(text7));
			GridState gridState2 = GridPersonalizationAdministration.LoadState(text2, (!string.IsNullOrEmpty(text3)) ? new Guid(text3) : Guid.Empty);
			if (val.get_Page() == 0)
			{
				val.set_PageSize(gridState2?.PageSize ?? 15);
				if (gridState2 != null && !string.IsNullOrEmpty(gridState2.SortExpression) && !Guid.TryParse(gridState2.SortExpression, out var _))
				{
					IList<SortDescriptor> sortDescriptors2 = val.get_SortDescriptors();
					SortDescriptor val6 = new SortDescriptor();
					val6.set_Member(gridState2.SortExpression);
					val6.set_SortDirection(gridState2.SortDirection);
					sortDescriptors2.Add(val6);
				}
				if (gridState2 != null && gridState2.GroupDescriptors != null)
				{
					foreach (GridGroupDescriptor groupDescriptor2 in gridState2.GroupDescriptors)
					{
						IList<GroupDescriptor> groupDescriptors2 = val.get_GroupDescriptors();
						GroupDescriptor val7 = new GroupDescriptor();
						((SortDescriptor)val7).set_Member(groupDescriptor2.Member);
						((SortDescriptor)val7).set_SortDirection(groupDescriptor2.SortDirection);
						groupDescriptors2.Add(val7);
					}
				}
			}
			else if (gridState2 != null)
			{
				gridState2.PageSize = val.get_PageSize();
				gridState2.SortExpression = val.get_SortExpressionString();
				gridState2.SortDirection = val.get_SortDirection();
				gridState2.GroupDescriptors = ((val.get_GroupDescriptors() != null && val.get_GroupDescriptors().Any()) ? (from gd in val.get_GroupDescriptors()
					select new GridGroupDescriptor
					{
						Member = ((SortDescriptor)gd).get_Member(),
						SortDirection = ((SortDescriptor)gd).get_SortDirection()
					}).ToList() : null);
				GridPersonalizationAdministration.SaveState(text2, gridState2, (!string.IsNullOrEmpty(text3)) ? new Guid(text3) : Guid.Empty, true);
			}
		}
		filterContext.get_ActionParameters()[ActionParameterName] = val;
	}

	public override void OnActionExecuted(ActionExecutedContext filterContext)
	{
		if (((ControllerContext)filterContext).get_ParentActionViewContext() == null && AjaxRequestExtensions.IsAjaxRequest(((ControllerContext)filterContext).get_HttpContext().Request))
		{
			((ControllerContext)filterContext).get_HttpContext().EditingFormEnabled(false);
		}
		ActionResult result = filterContext.get_Result();
		ViewResultBase val = (ViewResultBase)(object)((result is ViewResultBase) ? result : null);
		if (AjaxRequestExtensions.IsAjaxRequest(((ControllerContext)filterContext).get_HttpContext().Request) && ((ControllerContext)filterContext).get_HttpContext().Request.HttpMethod == "POST" && !string.IsNullOrWhiteSpace(((ControllerContext)filterContext).get_HttpContext().Request.Params.Get("gridId")) && !((ControllerContext)filterContext).get_HttpContext().EditingFormEnabled())
		{
			if (val != null && !(val is CompositeActionResult))
			{
				GridJsonCatchViewResult result2 = new GridJsonCatchViewResult(val);
				filterContext.set_Result((ActionResult)(object)result2);
			}
		}
		else
		{
			((ActionFilterAttribute)this).OnActionExecuted(filterContext);
		}
	}
}
