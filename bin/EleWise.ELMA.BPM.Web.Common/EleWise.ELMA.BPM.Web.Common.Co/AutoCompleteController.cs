using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using NHibernate;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

public class AutoCompleteController : BPMController
{
	public IAutoComplete AutoComplete { get; set; }

	public JsonResult GetData(Guid objectUid, bool needOperators)
	{
		EntityMetadata entityMetadata = (from p in ComponentManager.Current.GetExtensionPoints<IEntityMetadataSearcher>()
			select p.FindEntityMetadata(objectUid)).FirstOrDefault((EntityMetadata m) => m != null);
		IEnumerable<EQLField> fields = AutoComplete.GetFields(entityMetadata);
		IEnumerable<EleWise.ELMA.BPM.Web.Common.ExtensionPoints.EQLFunction> functions = AutoComplete.GetFunctions(entityMetadata);
		if (needOperators)
		{
			IEnumerable<EQLOperator> operators = AutoComplete.GetOperators();
			IEnumerable<EQLEntity> allEntities = AutoComplete.GetAllEntities();
			var anon = new
			{
				fields = fields.OrderBy((EQLField x) => x.displayName),
				operators = operators,
				functions = functions,
				entity = allEntities
			};
			return ((Controller)this).Json((object)anon, (JsonRequestBehavior)0);
		}
		var anon2 = new
		{
			fields = fields.OrderBy((EQLField x) => x.displayName),
			functions = functions
		};
		return ((Controller)this).Json((object)anon2, (JsonRequestBehavior)0);
	}

	public JsonResult GetEntities(Guid Uid, string entityValue)
	{
		List<EQLSuggestion> list = AutoComplete.GetEntities(Uid, entityValue).ToList();
		if (list == null || list.Count == 0)
		{
			return ((Controller)this).Json((object)new
			{
				results = new List<EQLSuggestion>()
			}, (JsonRequestBehavior)0);
		}
		EQLSuggestion item = list.FirstOrDefault();
		List<EQLSuggestion> list2 = new List<EQLSuggestion> { item };
		if (list.Count > 1)
		{
			list.RemoveAt(0);
			list2.AddRange(list.OrderBy((EQLSuggestion x) => x.displayName));
		}
		var anon = new
		{
			results = list2
		};
		return ((Controller)this).Json((object)anon, (JsonRequestBehavior)0);
	}

	public ActionResult DateTimeFunction(string fieldId)
	{
		((ControllerBase)this).get_ViewData().set_Item("QueryFieldId", (object)fieldId);
		return (ActionResult)(object)((Controller)this).PartialView("DateTimePopupWindow");
	}

	public ActionResult WorkTimeFunction(string fieldId)
	{
		((ControllerBase)this).get_ViewData().set_Item("QueryFieldId", (object)fieldId);
		return (ActionResult)(object)((Controller)this).PartialView("WorkTimePopupWindow");
	}

	public JsonResult GetParseError([Bind(Prefix = "DataFilter")] FilterModel model)
	{
		ClassMetadata classMetadata = ((model.FilterTypeUid != Guid.Empty) ? (MetadataLoader.LoadMetadata(model.FilterTypeUid) as ClassMetadata) : MetadataLoader.GetEntityMetadataByFilter(model.Filter.GetType()));
		if (classMetadata == null)
		{
			var anon = new
			{
				error = "success"
			};
			return ((Controller)this).Json((object)anon);
		}
		IEntityManager manager = ModelHelper.GetEntityManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(classMetadata.Uid));
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		IEntityFilter entityFilter = model.Filter;
		return ComponentManager.Current.GetExtensionPoints<IAutoCompleteExtension>().Select((Func<IAutoCompleteExtension, JsonResult>)delegate(IAutoCompleteExtension p)
		{
			//IL_0070: Expected O, but got Unknown
			try
			{
				if (!p.CheckFilter(manager, entityFilter))
				{
					return null;
				}
				var anon2 = new
				{
					error = "success"
				};
				return ((Controller)this).Json((object)anon2);
			}
			catch (NullReferenceException exception)
			{
				base.Logger.Error("Query error", exception);
				var anon3 = new
				{
					error = SR.T("Неправильно составлен запрос")
				};
				return ((Controller)this).Json((object)anon3);
			}
			catch (ADOException val)
			{
				ADOException exception2 = val;
				base.Logger.Error("Query error", (Exception)(object)exception2);
				var anon4 = new
				{
					error = SR.T("Неправильно составлен запрос")
				};
				return ((Controller)this).Json((object)anon4);
			}
			catch (Exception ex)
			{
				base.Logger.Error("Query error", ex);
				var anon5 = new
				{
					error = ex.Message
				};
				return ((Controller)this).Json((object)anon5);
			}
		}).FirstOrDefault((JsonResult r) => r != null);
	}
}
