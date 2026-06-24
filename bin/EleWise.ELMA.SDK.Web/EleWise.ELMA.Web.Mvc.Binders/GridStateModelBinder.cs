using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Newtonsoft.Json;

namespace EleWise.ELMA.Web.Mvc.Binders;

public sealed class GridStateModelBinder : IModelBinder
{
	private static readonly string NameOfColumnStates = LinqUtils.NameOf((Expression<Func<GridState, object>>)((GridState s) => s.ColumnStates));

	private static readonly string NameOfSelectedColumns = LinqUtils.NameOf((Expression<Func<GridState, object>>)((GridState s) => s.SelectedColumns));

	private static readonly string NameOfAvailableColumns = LinqUtils.NameOf((Expression<Func<GridState, object>>)((GridState s) => s.AvailableColumns));

	public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		try
		{
			Predicate<string> propertyFilter = bindingContext.get_PropertyFilter();
			bindingContext.set_PropertyFilter((Predicate<string>)((string s) => s != NameOfAvailableColumns && s != NameOfSelectedColumns && s != NameOfColumnStates));
			GridState gridState = ModelBinders.get_Binders().get_DefaultBinder().BindModel(controllerContext, bindingContext) as GridState;
			bindingContext.set_PropertyFilter(propertyFilter);
			if (gridState != null)
			{
				string prefix = GetPrefix(bindingContext);
				ValueProviderResult value = bindingContext.get_ValueProvider().GetValue(prefix + NameOfColumnStates);
				if (value != null && !string.IsNullOrEmpty(value.get_AttemptedValue()))
				{
					GridStateSet gridStateSet2 = (gridState.ColumnStates = (GridStateSet)JsonConvert.DeserializeObject(value.get_AttemptedValue(), typeof(GridStateSet)));
				}
				ValueProviderResult value2 = bindingContext.get_ValueProvider().GetValue(prefix + NameOfSelectedColumns);
				if (value2 != null && !string.IsNullOrEmpty(value2.get_AttemptedValue()))
				{
					List<SelectListItem> list2 = (gridState.SelectedColumns = (List<SelectListItem>)JsonConvert.DeserializeObject(value2.get_AttemptedValue(), typeof(List<SelectListItem>)));
				}
				ValueProviderResult value3 = bindingContext.get_ValueProvider().GetValue(prefix + NameOfAvailableColumns);
				if (value3 != null && !string.IsNullOrEmpty(value3.get_AttemptedValue()))
				{
					List<SelectListItem> list4 = (gridState.AvailableColumns = (List<SelectListItem>)JsonConvert.DeserializeObject(value3.get_AttemptedValue(), typeof(List<SelectListItem>)));
				}
			}
			return gridState;
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Недостаточно данных формы для восстановления состояния GridState. URL: {0}", controllerContext.get_HttpContext().Request.RawUrl), exception);
			return null;
		}
	}

	private string GetPrefix(ModelBindingContext bindingContext)
	{
		string result = ((!string.IsNullOrEmpty(bindingContext.get_ModelName())) ? (bindingContext.get_ModelName() + ".") : "");
		if (!string.IsNullOrEmpty(bindingContext.get_ModelName()) && !bindingContext.get_ValueProvider().ContainsPrefix(bindingContext.get_ModelName()))
		{
			result = "";
		}
		return result;
	}
}
