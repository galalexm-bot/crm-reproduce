using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.DynamicForms;
using EleWise.ELMA.Web.Mvc.Models.Forms;
using EleWise.ELMA.Web.Mvc.Views.ViewItem;

namespace EleWise.ELMA.Web.Mvc.Controllers;

public class DynamicFormsController : BaseController
{
	internal class EmptyValueProvider : IValueProvider
	{
		public bool ContainsPrefix(string prefix)
		{
			return false;
		}

		public ValueProviderResult GetValue(string key)
		{
			return null;
		}
	}

	private class DynamicFormChangeViewResult : PartialViewResult, ITypedActionResult
	{
		private DynamicFormChangeViewResultBase _baseResult;

		public ActionResultType ResultType => ActionResultType.Json;

		public DynamicFormChangeViewResult(DynamicFormChangeViewResultBase baseResult)
		{
			if (baseResult == null)
			{
				throw new ArgumentNullException("baseResult");
			}
			_baseResult = baseResult;
		}

		public override void ExecuteResult(ControllerContext context)
		{
			((ActionResult)_baseResult).ExecuteResult(context);
			if (_baseResult.Result == null)
			{
				throw new InvalidOperationException("Result is null");
			}
			string value = ((object)_baseResult.Result.ToJson()).ToString();
			context.get_HttpContext().Response.Output.Write(value);
		}
	}

	internal class DynamicFormChangeViewResultBase : JsonCatchViewResult
	{
		public DynamicFormChangeResult Result { get; set; }

		public DynamicFormPropertyChangedData Settings { get; set; }

		public List<KeyValuePair<string, MvcHtmlString>> NotifyMvcMessages { get; set; }

		public override void ExecuteResult(ControllerContext context)
		{
			IValueProvider valueProvider = context.get_Controller().get_ValueProvider();
			context.get_Controller().set_ValueProvider((IValueProvider)(object)new EmptyValueProvider());
			try
			{
				if (NotifyMvcMessages != null)
				{
					foreach (KeyValuePair<string, MvcHtmlString> notifyMvcMessage in NotifyMvcMessages)
					{
						string text = RenderRazorViewToString(context, "Templates/" + notifyMvcMessage.Key, notifyMvcMessage.Value);
						if (!string.IsNullOrEmpty(text))
						{
							Result.NotifyMessages += text;
						}
					}
				}
				base.ExecuteResult(context);
				base.JsonResult = new Dictionary<string, object> { { "dynamicFormResult", Result } };
			}
			finally
			{
				context.get_Controller().set_ValueProvider(valueProvider);
			}
		}

		protected override void OnViewContextCreated(ViewContext viewContext)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			base.OnViewContextCreated(viewContext);
			viewContext.set_ClientValidationEnabled(true);
			FormContext val = new FormContext();
			val.set_FormId(Settings.FormId ?? "GlobalForm");
			viewContext.set_FormContext(val);
		}

		protected override void OnViewRendered(ViewContext viewContext)
		{
			base.OnViewRendered(viewContext);
			Dictionary<string, FieldValidationMetadata> dictionary = new Dictionary<string, FieldValidationMetadata>();
			foreach (KeyValuePair<string, FieldValidationMetadata> fieldValidator in viewContext.get_FormContext().get_FieldValidators())
			{
				if (IsBinaryFileField(fieldValidator.Value, viewContext) && fieldValidator.Value != null)
				{
					fieldValidator.Value.set_FieldName(fieldValidator.Value.get_FieldName() + "_validate");
					if (!string.IsNullOrEmpty(fieldValidator.Value.get_ValidationMessageId()))
					{
						int num = fieldValidator.Value.get_ValidationMessageId().IndexOf("_validationMessage");
						if (num > -1)
						{
							fieldValidator.Value.set_ValidationMessageId(fieldValidator.Value.get_ValidationMessageId().Insert(num, "_validate"));
						}
					}
				}
				if (IsBooleanField(fieldValidator.Value, viewContext))
				{
					dictionary.Add(fieldValidator.Key, fieldValidator.Value);
				}
			}
			Result.ValidationMetadata.Add("Fields", dictionary.Values.ToArray());
			Result.ValidationMetadata.Add("FormId", viewContext.get_FormContext().get_FormId());
		}

		private bool IsBooleanField(FieldValidationMetadata validationMetadata, ViewContext viewContext)
		{
			return ModelMetadata.FromStringExpression(validationMetadata.get_FieldName(), viewContext.get_ViewData()).get_ModelType() != typeof(bool);
		}

		private bool IsBinaryFileField(FieldValidationMetadata validationMetadata, ViewContext viewContext)
		{
			string htmlFieldPrefix = viewContext.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix();
			string text = validationMetadata.get_FieldName();
			if (!string.IsNullOrEmpty(htmlFieldPrefix) && text.IndexOf(htmlFieldPrefix) >= 0)
			{
				text = text.Substring(text.IndexOf(htmlFieldPrefix) + htmlFieldPrefix.Length + 1);
			}
			return ModelMetadata.FromStringExpression(text, viewContext.get_ViewData()).get_ModelType() == typeof(BinaryFile);
		}

		private string RenderRazorViewToString(ControllerContext context, string viewName, object model)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			ViewDataDictionary val = new ViewDataDictionary(model);
			using StringWriter stringWriter = new StringWriter();
			ViewEngineResult val2 = ViewEngines.get_Engines().FindPartialView(context, viewName);
			ViewContext val3 = new ViewContext(context, val2.get_View(), val, ((ViewResultBase)this).get_TempData(), (TextWriter)stringWriter);
			val2.get_View().Render(val3, (TextWriter)stringWriter);
			val2.get_ViewEngine().ReleaseView(context, val2.get_View());
			return stringWriter.GetStringBuilder().ToString();
		}
	}

	private readonly IMetadataRuntimeService metadataRuntimeService;

	private readonly IEnumerable<IOpenFormProvider> openFormProviders;

	private readonly IEnumerable<IDynamicFormsProvider> dynamicFormsProviders;

	private readonly IEnumerable<IObjectViewItemProvider> objectViewItemProviders;

	public DynamicFormsController(IMetadataRuntimeService metadataRuntimeService, IEnumerable<IOpenFormProvider> openFormProviders, IEnumerable<IDynamicFormsProvider> dynamicFormsProviders, IEnumerable<IObjectViewItemProvider> objectViewItemProviders)
	{
		this.openFormProviders = openFormProviders;
		this.dynamicFormsProviders = dynamicFormsProviders;
		this.metadataRuntimeService = metadataRuntimeService;
		this.objectViewItemProviders = objectViewItemProviders;
	}

	[Obsolete]
	private static string HtmlPrefix(DynamicFormPropertyChangedData settings)
	{
		return settings.HtmlPrefix;
	}

	[Obsolete("Используйте метод ProcessPropertyValueChanged")]
	public ActionResult ProcessProeprtyValueChanged([Bind(Prefix = "__DynamicFormSettings")] DynamicFormPropertyChangedData settings)
	{
		return ProcessPropertyValueChanged(settings);
	}

	[Obsolete("Используйте метод ProcessPropertyValueChanged")]
	public static ActionResult ProcessProeprtyValueChanged(Controller controller, DynamicFormPropertyChangedData settings, IEntity entity, string scriptName, RootViewItem view = null, object originalState = null)
	{
		return ProcessPropertyValueChanged(controller, settings, entity, scriptName, view, originalState);
	}

	[TransactionAction(CommitOnResultExecuted = true)]
	public ActionResult ProcessConnectorClick([Bind(Prefix = "__DynamicFormSettings")] DynamicFormPropertyChangedData settings)
	{
		if (!(BindData(settings, isConnectorClick: true) is DynamicFormChangeViewResult result))
		{
			return ThrowJsonException(SR.T("Не удалось получить результат выполнения сценария"));
		}
		return (ActionResult)(object)result;
	}

	[TransactionAction(CommitOnResultExecuted = true)]
	public ActionResult ProcessPropertyValueChanged([Bind(Prefix = "__DynamicFormSettings")] DynamicFormPropertyChangedData settings)
	{
		return BindData(settings);
	}

	public static ActionResult ProcessPropertyValueChanged(Controller controller, DynamicFormPropertyChangedData settings, IEntity entity, string scriptName, RootViewItem view = null, object originalState = null, IDictionary<string, object> realrootEntityState = null, bool isConnectorClick = false)
	{
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Expected O, but got Unknown
		if (controller == null)
		{
			throw new ArgumentNullException("controller");
		}
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		if (scriptName == null)
		{
			throw new ArgumentNullException("scriptName");
		}
		Locator.GetServiceNotNull<IUnitOfWorkManager>().RevertEntityChangesOnCommit("", entity.GetRootEntity());
		if (view == null)
		{
			IObjectViewItemProvider objectViewItemProvider = ((settings.ViewProviderUid != Guid.Empty) ? ComponentManager.Current.GetExtensionPoints<IObjectViewItemProvider>().FirstOrDefault((IObjectViewItemProvider p) => p.ProviderUid == settings.ViewProviderUid) : null);
			view = ((objectViewItemProvider != null) ? ((RootViewItem)objectViewItemProvider.GetViewItem(settings.ViewItemId)) : null);
		}
		DynamicFormResult dynamicFormResult = DynamicFormHelper.ExecuteScript(entity, settings, view, scriptName, originalState, realrootEntityState);
		if (dynamicFormResult == null)
		{
			return null;
		}
		view = dynamicFormResult.ChangedView;
		DynamicFormChangeResult dynamicFormChangeResult = new DynamicFormChangeResult
		{
			ModelJsonState = dynamicFormResult.ModelJsonState,
			ViewTransformation = ((dynamicFormResult.ViewTransformation != null) ? dynamicFormResult.ViewTransformation.SerializeToJson() : null)
		};
		if (isConnectorClick && dynamicFormResult.ResultData.Data.ContainsKey("IResult"))
		{
			bool? flag = dynamicFormResult.ResultData.Data["IResult"] as bool?;
			dynamicFormChangeResult.Error = !flag.HasValue || !flag.Value;
		}
		if (settings.IgnoreChangedPropertyInResult && dynamicFormResult.ChangedPropertyNames.Contains(settings.ChangedPropertyName))
		{
			dynamicFormResult.ChangedPropertyNames.Remove(settings.ChangedPropertyName);
		}
		if (dynamicFormResult.ResultData.Data.Count > 0)
		{
			foreach (IDynamicFormWebProvider extensionPoint in ComponentManager.Current.GetExtensionPoints<IDynamicFormWebProvider>())
			{
				Dictionary<string, object> extendedData = extensionPoint.GetExtendedData(controller, dynamicFormResult.ResultData);
				if (extendedData == null)
				{
					continue;
				}
				foreach (KeyValuePair<string, object> item2 in extendedData)
				{
					dynamicFormChangeResult.ExtendedData[item2.Key] = item2.Value;
				}
			}
		}
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(EntityHelper.GetType(entity));
		string text = HtmlPrefix(settings);
		string changedPropertyName = settings.ChangedPropertyName;
		if (text.IsNullOrWhiteSpace() && changedPropertyName.StartsWith("Prop_") && changedPropertyName.IndexOf('.') != -1)
		{
			text = (text.IsNullOrWhiteSpace() ? changedPropertyName.Substring(0, changedPropertyName.IndexOf('.')) : null);
		}
		string text2 = ((!string.IsNullOrEmpty(text)) ? (text + ".") : "");
		foreach (IPropertyMetadata propMetadata in entityMetadata.GetPropertiesAndTableParts())
		{
			IEnumerable<IPropertyMetadata> enumerable = null;
			if (propMetadata.Settings is EntitySettings && MetadataLoader.LoadMetadata(propMetadata.SubTypeUid) is IEntityMetadata entityMetadata2)
			{
				enumerable = entityMetadata2.GetPropertiesAndTableParts();
			}
			PropertyViewItem[] array = ((view != null) ? (from i in view.GetAllItems().OfType<PropertyViewItem>()
				where i.PropertyUid == propMetadata.PropertyUid
				select i).ToArray() : new PropertyViewItem[0]);
			foreach (PropertyViewItem propertyViewItem2 in array)
			{
				string text3 = text2 + propMetadata.Name;
				dynamicFormChangeResult.PropertiesVisibility[ModelExtensions.PropertyContainerBaseId(TagBuilder.CreateSanitizedId(text3), new WebViewAttributes
				{
					ViewItemUid = propertyViewItem2.Uid,
					NeedPostfix = propertyViewItem2.NeedPostfix()
				})] = (propertyViewItem2.IsVisible() ? 1 : 0);
				if (enumerable == null)
				{
					continue;
				}
				foreach (ViewItem item3 in propertyViewItem2.Items)
				{
					PropertyViewItem propertyViewItem = item3 as PropertyViewItem;
					if (propertyViewItem != null)
					{
						IPropertyMetadata propertyMetadata = enumerable.FirstOrDefault((IPropertyMetadata a) => a.PropertyUid == propertyViewItem.PropertyUid);
						if (propertyMetadata != null)
						{
							string text4 = $"{text3}.{propertyMetadata.Name}";
							dynamicFormChangeResult.PropertiesVisibility[ModelExtensions.PropertyContainerBaseId(TagBuilder.CreateSanitizedId(text4), new WebViewAttributes
							{
								ViewItemUid = propertyViewItem.Uid,
								NeedPostfix = propertyViewItem.NeedPostfix()
							})] = (propertyViewItem2.IsVisible() ? 1 : 0);
						}
					}
				}
			}
		}
		IEnumerable<RowViewItem> enumerable3;
		if (view == null)
		{
			IEnumerable<RowViewItem> enumerable2 = new RowViewItem[0];
			enumerable3 = enumerable2;
		}
		else
		{
			enumerable3 = view.GetAllItems().OfType<RowViewItem>();
		}
		foreach (RowViewItem item4 in enumerable3)
		{
			dynamicFormChangeResult.PropertiesVisibility[ModelExtensions.RowBaseId(item4.Uid.ToString())] = (item4.GetAllItems().Any((ViewItem a) => (!(a is CellViewItem) && !(a is PropertyViewItem)) || (a is PropertyViewItem && ((PropertyViewItem)a).IsVisible())) ? 1 : 0);
		}
		foreach (Guid uid in dynamicFormResult.ChangedValidationPropertyUids)
		{
			PropertyViewItem[] array = ((view != null) ? (from i in view.GetAllItems().OfType<PropertyViewItem>()
				where i.PropertyUid == uid
				select i).ToArray() : new PropertyViewItem[0]);
			foreach (PropertyViewItem propertyViewItem3 in array)
			{
				IPropertyMetadata propertyMetadata2 = entityMetadata.GetPropertiesAndTableParts().FirstOrDefault((IPropertyMetadata p) => p.PropertyUid == uid);
				if (propertyMetadata2 != null)
				{
					string item = ModelExtensions.PropertyContainerBaseId(TagBuilder.CreateSanitizedId(text2 + propertyMetadata2.Name), new WebViewAttributes
					{
						ViewItemUid = propertyViewItem3.Uid,
						NeedPostfix = propertyViewItem3.NeedPostfix()
					});
					dynamicFormChangeResult.PropertiesValidation.Add(item);
				}
			}
		}
		dynamicFormChangeResult.ClosePopup = DynamicFormHelper.ClosePopup;
		((ControllerBase)controller).get_ViewData().set_Item("DynamicFormChangeResultViewModel", (object)new DynamicFormChangeResultViewModel
		{
			Result = dynamicFormChangeResult,
			ChangedPropertyNames = dynamicFormResult.ChangedPropertyNames.ToArray(),
			Prefix = text,
			Metadata = entityMetadata,
			Entity = entity,
			View = view
		});
		((ControllerBase)controller).get_ViewData().set_Item("DynamicFormPropertyChangedData", (object)settings);
		DynamicFormChangeViewResultBase obj = new DynamicFormChangeViewResultBase
		{
			Result = dynamicFormChangeResult,
			Settings = settings
		};
		((ViewResultBase)obj).set_ViewName("Templates/DynamicFormChangeResult");
		ViewDataDictionary<IEntity> obj2 = new ViewDataDictionary<IEntity>(((ControllerBase)controller).get_ViewData());
		obj2.set_Model(entity);
		((ViewResultBase)obj).set_ViewData((ViewDataDictionary)(object)obj2);
		((ViewResultBase)obj).set_TempData(new TempDataDictionary());
		obj.NotifyMvcMessages = DynamicFormHelper.GetContextNotifyMvcMessages();
		DynamicFormChangeViewResultBase dynamicFormChangeViewResultBase = obj;
		if (((ViewResultBase)dynamicFormChangeViewResultBase).get_ViewData().get_ModelState() != null)
		{
			((ViewResultBase)dynamicFormChangeViewResultBase).get_ViewData().get_ModelState().Clear();
		}
		return (ActionResult)(object)dynamicFormChangeViewResultBase;
	}

	public ActionResult OpenForm(string newPopupId, Guid buttonUid, string actionSettings, string callback, [Bind(Prefix = "__DynamicFormSettings")] DynamicFormPropertyChangedData settings)
	{
		IDynamicFormsProvider provider;
		Type modelType;
		string bindPrefix;
		string prefix;
		ModelBindingContext bindingContext = GetBindingContext(settings, "", out provider, out modelType, out bindPrefix, out prefix);
		if (bindingContext == null)
		{
			throw new ElmaInvalidOperationException(SR.T("Не удалось получить контекст биндинга при открытии формы"));
		}
		ElmaModelBinder.ResetTablePartNewItemIds = false;
		object obj = ((Controller)this).get_Binders().get_DefaultBinder().BindModel(((ControllerBase)this).get_ControllerContext(), bindingContext);
		if (obj == null)
		{
			throw new ElmaInvalidOperationException(SR.T("Не удалось восстановить объект при открытии формы"));
		}
		IEntity entity = obj as IEntity;
		if (entity != null)
		{
			Locator.GetServiceNotNull<IUnitOfWorkManager>().RevertEntityChangesOnCommit("", entity.GetRootEntity());
		}
		IObjectViewItemProvider obj2 = ((settings.ViewProviderUid != Guid.Empty) ? objectViewItemProviders.FirstOrDefault((IObjectViewItemProvider p) => p.ProviderUid == settings.ViewProviderUid) : null) ?? throw new ElmaInvalidOperationException(SR.T("Не найден провайдер для получения информации о представлении"));
		if (Guid.TryParse(settings.FormId, out var _))
		{
			DynamicFormPropertyChangedData dynamicFormPropertyChangedData = settings;
			dynamicFormPropertyChangedData.ViewItemId = dynamicFormPropertyChangedData.ViewItemId + ";" + settings.FormId;
		}
		FormView formView = (FormView)obj2.GetViewItem(settings.ViewItemId);
		FormViewItem formViewItem = formView as FormViewItem;
		if (settings.ViewItemUid.HasValue)
		{
			formView = formView.FindItem<FormViewItem>(settings.ViewItemUid.Value);
		}
		if (buttonUid != Guid.Empty)
		{
			string text = "";
			ButtonViewItem buttonViewItem = formView.GetAllItems().FirstOrDefault((ViewItem q) => q.Uid == buttonUid) as ButtonViewItem;
			if (buttonViewItem == null && formViewItem != null)
			{
				foreach (Group item in formViewItem.Toolbar.Items.OfType<Group>())
				{
					if (item.Items.FirstOrDefault((ToolbarItem q) => q.Uid == buttonUid) is Button button)
					{
						text = button.ActionId;
						break;
					}
				}
				if (string.IsNullOrEmpty(text))
				{
					throw new ElmaInvalidOperationException(SR.T("Не найдена кнопка с идентификатором \"{0}\"", buttonUid));
				}
			}
			else
			{
				text = buttonViewItem.ActionId;
			}
			string[] array = text.Split(new string[1] { "-BEFE1D44-62F6-457E-B628-F6CDC62FC2C9-" }, StringSplitOptions.None);
			actionSettings = array.ElementAt(array.Length - 2);
		}
		FormBindingModel formBindingModel = ClassSerializationHelper.DeserializeObjectByXml<FormBindingModel>(actionSettings);
		if (formBindingModel.RenderMode == RenderFormMode.Inherit && formViewItem != null)
		{
			formBindingModel.ReadOnly = formViewItem.IsReadOnly();
		}
		else if (formBindingModel.RenderMode == RenderFormMode.ReadOnly)
		{
			formBindingModel.ReadOnly = true;
		}
		if (formBindingModel.ViewType == ViewType.Display)
		{
			formBindingModel.ReadOnly = true;
		}
		Guid typeUid = formBindingModel.TypeUid;
		if (typeUid == Guid.Empty)
		{
			if (entity != null)
			{
				typeUid = InterfaceActivator.UID(EntityHelper.GetType(entity));
			}
		}
		else
		{
			IEntity entity2 = null;
			if (typeUid == PageMetadata.TypeUid && formBindingModel.HeaderUid != Guid.Empty)
			{
				entity2 = AbstractNHEntityManager<IFormMetadataItemHeader, long>.Instance.Load(formBindingModel.HeaderUid);
			}
			else if (formBindingModel.FormPropertyMap != null)
			{
				PropertyMapItem propertyMapItem = formBindingModel.FormPropertyMap.Items[0];
				if (entity != null)
				{
					entity2 = ((IEntity)entity.GetPropertyValue(propertyMapItem.RightPropertyUid)).CastAsRealType();
				}
				else if (formBindingModel.SelectedPropertyUid.HasValue && provider is ComponentDynamicFormProvider componentDynamicFormProvider)
				{
					entity2 = ((IEntity)componentDynamicFormProvider.GetProperty(settings, obj, formBindingModel.SelectedPropertyUid.Value, formBindingModel.PropertyParents)).CastAsRealType();
				}
				if (entity2 == null)
				{
					throw new ElmaInvalidOperationException(SR.T("Свойство с идентификатором \"{0}\" должно быть заполнено", propertyMapItem.RightPropertyUid));
				}
				typeUid = InterfaceActivator.UID(EntityHelper.GetType(entity2), loadImplementation: false);
			}
			if (formBindingModel.ReadOnly && entity2 != null)
			{
				if (base.SecurityService.CanCheckPermission(CommonPermissions.View, entity2) && !base.SecurityService.HasPermission(CommonPermissions.View, entity2))
				{
					throw new SecurityException(SR.T("Недостаточно прав для просмотра объекта"));
				}
			}
			else if (entity2 == null)
			{
				Type typeByUid = metadataRuntimeService.GetTypeByUid(typeUid);
				if (base.SecurityService.CanCheckPermission(CommonPermissions.Create, typeByUid) && !base.SecurityService.HasPermission(CommonPermissions.Create, typeByUid))
				{
					throw new SecurityException(SR.T("Недостаточно прав для создания объекта"));
				}
			}
			else if (base.SecurityService.CanCheckPermission(CommonPermissions.Edit, entity2) && !base.SecurityService.HasPermission(CommonPermissions.Edit, entity2))
			{
				throw new SecurityException(SR.T("Недостаточно прав для редактирования объекта"));
			}
		}
		IOpenFormProvider obj3 = openFormProviders.FirstOrDefault((IOpenFormProvider q) => q.CheckType(typeUid)) ?? throw new ElmaInvalidOperationException(SR.T("Не найден провайдер для открытия формы"));
		entity = entity.CastAsRealType();
		EntityFormInfo formInfo = obj3.GetFormInfo(typeUid, entity, formBindingModel, settings.ViewItemId);
		if (formInfo == null)
		{
			throw new ElmaInvalidOperationException(SR.T("Не удалось получить модель открытия формы"));
		}
		formInfo.PopupId = newPopupId;
		formInfo.TypeUid = typeUid;
		formInfo.ReadOnly = formBindingModel.ReadOnly;
		formInfo.FormId = "Form" + formInfo.CreatorPrefix;
		formInfo.ParentFormId = settings.DynamicFormId;
		formInfo.Route.Add("parentFormId", settings.DynamicFormId);
		formInfo.Route.Add("formId", formInfo.FormId);
		if (formBindingModel.TypeUid == Guid.Empty)
		{
			formInfo.Route["uid"] = typeUid;
			if (!string.IsNullOrEmpty(formInfo.ParameterName))
			{
				formInfo.Route[formInfo.ParameterName] = new ParameterContainer(entity);
			}
		}
		if (!string.IsNullOrEmpty(callback))
		{
			formInfo.OnSubmitScript = (HtmlHelper helper, string s) => callback;
		}
		if (formBindingModel.TypeUid == Guid.Empty)
		{
			formInfo.IsLocal = true;
			if (string.IsNullOrEmpty(settings.ModelJsonState))
			{
				object obj4 = new EntityJsonSerializer().ConvertToSerializable(entity, new EntitySerializationSettings
				{
					Mode = EntitySerializationMode.ChangesOnly
				});
				settings.ModelJsonState = new JsonSerializer().Serialize(obj4);
			}
		}
		ViewItemControl<ViewItem, object, object>.HideMode = ViewItemHideMode.Modal;
		return (ActionResult)(object)((Controller)this).PartialView("Templates/EntityForm", (object)formInfo);
	}

	public ActionResult ApplyPopupFormData([Bind(Prefix = "__DynamicFormSettings")] DynamicFormPropertyChangedData settings)
	{
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		string text = HtmlPrefix(settings);
		DynamicFormPropertyChangedData parentSettings = new DynamicFormPropertyChangedData();
		((Controller)this).TryUpdateModel<DynamicFormPropertyChangedData>(parentSettings, string.Join(".", text, "ParentB5857BD3_6DBE_48F0_9489_FD6C08F1528E", "__DynamicFormSettings"));
		if (parentSettings.DynamicFormsProviderUid == Guid.Empty)
		{
			return ThrowJsonException(SR.T("Не задан провайдер динамических форм"));
		}
		IDynamicFormsProvider dynamicFormsProvider = dynamicFormsProviders.FirstOrDefault((IDynamicFormsProvider p) => p.Uid == parentSettings.DynamicFormsProviderUid);
		if (dynamicFormsProvider == null)
		{
			return ThrowJsonException(SR.T("Не найден провайдер динамических форм"));
		}
		Type type = dynamicFormsProvider.GetEntityType(parentSettings) ?? typeof(IEntity);
		((Controller)this).get_Binders().GetBinder(type);
		string text2 = text;
		string text3 = ((Controller)this).get_HttpContext().Request["CreatorPrefix"];
		if (!string.IsNullOrEmpty(text3) && !string.IsNullOrEmpty(text2) && text2.StartsWith(text3, StringComparison.CurrentCultureIgnoreCase))
		{
			text2 = text2.Substring(text3.Length + 1);
		}
		ModelBindingContext val = new ModelBindingContext();
		val.set_ModelMetadata(ModelMetadataProviders.get_Current().GetMetadataForType((Func<object>)(() => null), type));
		val.set_ModelName(text2 + ".ParentB5857BD3_6DBE_48F0_9489_FD6C08F1528E");
		val.set_ModelState(new ModelStateDictionary());
		val.set_ValueProvider(((ControllerBase)this).get_ValueProvider());
		ModelBindingContext val2 = val;
		ElmaModelBinder.ResetTablePartNewItemIds = false;
		if (!(((Controller)this).get_Binders().get_DefaultBinder().BindModel(((ControllerBase)this).get_ControllerContext(), val2) is IEntity entity))
		{
			return ThrowJsonException(SR.T("Не удалось восстановить родительскую сущность"));
		}
		text = HtmlPrefix(parentSettings);
		if (!(MetadataLoader.LoadMetadata(EntityHelper.GetType(entity)) is EntityMetadata metadata))
		{
			return ThrowJsonException(SR.T("Не удалось получить метаданные сущность"));
		}
		IEntity rootEntity = entity.GetRootEntity();
		DynamicFormHelper.ProcessNewTablePartItems(rootEntity, null);
		if (rootEntity != entity)
		{
			DynamicFormHelper.ProcessNewTablePartItems(entity, metadata);
		}
		IDictionary<string, object> state = EntityCompareHelper.GetState(entity);
		((Controller)this).TryUpdateModel<IEntity>(entity, text2);
		IEntity rootEntity2 = entity.GetRootEntity();
		DynamicFormHelper.ProcessNewTablePartItems(rootEntity2, null);
		if (rootEntity2 != entity)
		{
			DynamicFormHelper.ProcessNewTablePartItems(entity, metadata);
		}
		DynamicFormResult dynamicFormResult = new DynamicFormResult();
		dynamicFormResult.ModelJsonState = DynamicFormHelper.ModelJsonState(entity, null, needProcessNewTablePartItems: false);
		dynamicFormResult.ChangedPropertyNames.AddRange(EntityCompareHelper.Compare(entity, state));
		DynamicFormChangeResult result = new DynamicFormChangeResult
		{
			ModelJsonState = ((dynamicFormResult.ChangedPropertyNames.Count > 0) ? dynamicFormResult.ModelJsonState : null),
			ViewTransformation = ((dynamicFormResult.ViewTransformation != null) ? dynamicFormResult.ViewTransformation.SerializeToJson() : null)
		};
		IObjectViewItemProvider objectViewItemProvider = ((parentSettings.ViewProviderUid != Guid.Empty) ? objectViewItemProviders.FirstOrDefault((IObjectViewItemProvider p) => p.ProviderUid == parentSettings.ViewProviderUid) : null);
		RootViewItem rootViewItem = ((objectViewItemProvider != null) ? (objectViewItemProvider.GetViewItem(parentSettings.ViewItemId) as RootViewItem) : null);
		if (rootViewItem != null)
		{
			rootViewItem = rootViewItem.Transformate(parentSettings.ViewTransformation) as RootViewItem;
			if (parentSettings.ViewTransformationAdditional != null)
			{
				parentSettings.ViewTransformationAdditional.Apply(rootViewItem);
			}
		}
		((ControllerBase)this).get_ViewData().set_Item("DynamicFormChangeResultViewModel", (object)new DynamicFormChangeResultViewModel
		{
			Result = result,
			ChangedPropertyNames = dynamicFormResult.ChangedPropertyNames.ToArray(),
			Prefix = text,
			Metadata = metadata,
			Entity = entity,
			View = rootViewItem
		});
		((ControllerBase)this).get_ViewData().set_Item("DynamicFormPropertyChangedData", (object)parentSettings);
		DynamicFormChangeViewResultBase obj = new DynamicFormChangeViewResultBase
		{
			Result = result,
			Settings = parentSettings
		};
		((ViewResultBase)obj).set_ViewName("Templates/DynamicFormChangeResult");
		ViewDataDictionary<IEntity> obj2 = new ViewDataDictionary<IEntity>(((ControllerBase)this).get_ViewData());
		obj2.set_Model(entity);
		((ViewResultBase)obj).set_ViewData((ViewDataDictionary)(object)obj2);
		((ViewResultBase)obj).set_TempData(new TempDataDictionary());
		obj.NotifyMvcMessages = DynamicFormHelper.GetContextNotifyMvcMessages();
		DynamicFormChangeViewResultBase dynamicFormChangeViewResultBase = obj;
		if (((ViewResultBase)dynamicFormChangeViewResultBase).get_ViewData().get_ModelState() != null)
		{
			((ViewResultBase)dynamicFormChangeViewResultBase).get_ViewData().get_ModelState().Clear();
		}
		return (ActionResult)(object)new DynamicFormChangeViewResult(dynamicFormChangeViewResultBase);
	}

	private ModelBindingContext GetBindingContext(DynamicFormPropertyChangedData settings, string bindPrefixPart, out IDynamicFormsProvider provider, out Type modelType, out string bindPrefix, out string prefix)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		bindPrefix = (prefix = string.Empty);
		provider = null;
		modelType = null;
		if (settings == null || settings.DynamicFormsProviderUid == Guid.Empty)
		{
			return null;
		}
		provider = dynamicFormsProviders.FirstOrDefault((IDynamicFormsProvider p) => p.Uid == settings.DynamicFormsProviderUid);
		if (provider == null)
		{
			return null;
		}
		modelType = provider.GetEntityType(settings) ?? typeof(IEntity);
		((Controller)this).get_Binders().GetBinder(modelType);
		prefix = HtmlPrefix(settings);
		bindPrefix = prefix;
		string text = ((Controller)this).get_HttpContext().Request["CreatorPrefix"];
		if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(bindPrefix) && bindPrefix.StartsWith(text, StringComparison.CurrentCultureIgnoreCase))
		{
			bindPrefix = bindPrefix.Substring(text.Length + 1);
		}
		ModelBindingContext val = new ModelBindingContext();
		val.set_ModelMetadata(ModelMetadataProviders.get_Current().GetMetadataForType((Func<object>)(() => null), modelType));
		val.set_ModelName(bindPrefix + bindPrefixPart);
		val.set_ModelState(new ModelStateDictionary());
		val.set_ValueProvider(((ControllerBase)this).get_ValueProvider());
		return val;
	}

	private ActionResult BindData(DynamicFormPropertyChangedData settings, bool isConnectorClick = false)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		IDynamicFormsProvider provider;
		Type modelType;
		string bindPrefix;
		string prefix;
		ModelBindingContext bindingContext = GetBindingContext(settings, "", out provider, out modelType, out bindPrefix, out prefix);
		if (bindingContext == null)
		{
			return ThrowJsonException(SR.T("Не удалось получить контекст биндинга"));
		}
		IEntity entity = ElmaModelBinder.CreateModel(((ControllerBase)this).get_ControllerContext(), bindingContext, modelType, null) as IEntity;
		IMetadata metadata = ((entity != null) ? MetadataLoader.LoadMetadata(EntityHelper.GetType(entity)) : null);
		ITablePartMetadata tpMetadata = metadata as ITablePartMetadata;
		IDictionary<string, object> state = EntityCompareHelper.GetState(entity.GetRootEntity());
		object obj = null;
		if (tpMetadata != null)
		{
			PropertyMetadata propertyMetadata = tpMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == tpMetadata.ParentPropertyUid);
			Type type = ((propertyMetadata != null) ? metadataRuntimeService.GetTypeByUidOrNull(propertyMetadata.SubTypeUid) : null);
			if (type != null)
			{
				ModelBindingContext val = new ModelBindingContext();
				val.set_ModelMetadata(ModelMetadataProviders.get_Current().GetMetadataForType((Func<object>)(() => null), type));
				val.set_ModelName(((!string.IsNullOrEmpty(bindPrefix)) ? (bindPrefix + ".") : "") + "ParentB5857BD3_6DBE_48F0_9489_FD6C08F1528E");
				val.set_ModelState(new ModelStateDictionary());
				val.set_ValueProvider(((ControllerBase)this).get_ValueProvider());
				ModelBindingContext val2 = val;
				IEntity entity2 = (IEntity)((Controller)this).get_Binders().get_DefaultBinder().BindModel(((ControllerBase)this).get_ControllerContext(), val2);
				if (entity2 != null)
				{
					IEntity entity3 = ((entity2.GetPropertyValue(tpMetadata.TablePartPropertyUid) is IEnumerable source) ? source.OfType<IEntity>().FirstOrDefault((IEntity e) => e.GetId().Equals(entity.GetId())) : null);
					if (entity3 != null)
					{
						obj = EntityHelper.GetEntityManager(EntityHelper.GetType(entity3)).GetCurrentState(entity3);
						state = EntityCompareHelper.GetState(entity2);
					}
				}
			}
		}
		entity = (IEntity)((Controller)this).get_Binders().get_DefaultBinder().BindModel(((ControllerBase)this).get_ControllerContext(), bindingContext);
		if (entity == null)
		{
			return ThrowJsonException(SR.T("Не удалось получить восстановить сущность"));
		}
		IObjectViewItemProvider objectViewItemProvider = ((settings.ViewProviderUid != Guid.Empty) ? objectViewItemProviders.FirstOrDefault((IObjectViewItemProvider p) => p.ProviderUid == settings.ViewProviderUid) : null);
		RootViewItem rootViewItem = ((objectViewItemProvider != null) ? ((RootViewItem)objectViewItemProvider.GetViewItem(settings.ViewItemId)) : null);
		if (rootViewItem != null && settings.ViewItemUid.HasValue)
		{
			rootViewItem = rootViewItem.FindItem<RootViewItem>(settings.ViewItemUid.Value);
		}
		string text = settings.ChangedPropertyName;
		if (text != null && !string.IsNullOrEmpty(prefix) && text.StartsWith(prefix))
		{
			text = text.Substring(prefix.Length + 1);
		}
		string text2 = string.Empty;
		string text3 = settings.ScriptName;
		if (!string.IsNullOrWhiteSpace(text3) && text3.Contains(";"))
		{
			string[] array = text3.Split(';');
			text3 = array[0];
			text2 = array[1];
		}
		else if (string.IsNullOrEmpty(text3))
		{
			text3 = provider.GetPropertyValueChangeScriptName(entity, rootViewItem, settings, text);
		}
		if (string.IsNullOrEmpty(text3) && string.IsNullOrWhiteSpace(text2))
		{
			return ThrowJsonException(SR.T("Не удалось получить имя сценария для выполнения"));
		}
		DynamicFormChangeViewResultBase dynamicFormChangeViewResultBase = null;
		if (!string.IsNullOrWhiteSpace(text3))
		{
			if (entity.IsNew() && obj == null)
			{
				IEntityManager entityManager = EntityHelper.GetEntityManager(entity.GetType());
				obj = entityManager.GetCurrentState(entityManager.Create());
			}
			dynamicFormChangeViewResultBase = (DynamicFormChangeViewResultBase)(object)ProcessPropertyValueChanged((Controller)(object)this, settings, entity, text3, rootViewItem, obj, null, isConnectorClick);
		}
		PropertyViewItem propertyViewItem = rootViewItem as PropertyViewItem;
		if (tpMetadata != null && propertyViewItem != null && propertyViewItem.Items.Any((ViewItem a) => (a is PropertyViewItem propertyViewItem2 && propertyViewItem2.EditableInTable) ? true : false) && propertyViewItem.Attributes != null && settings.FormEditMode == DynamicFormEditMode.Column)
		{
			IEntity rootEntity = entity.GetRootEntity();
			RootViewItem view = propertyViewItem.Root as RootViewItem;
			DynamicFormPropertyChangedData dynamicFormPropertyChangedData = new DynamicFormPropertyChangedData();
			((Controller)this).TryUpdateModel<DynamicFormPropertyChangedData>(dynamicFormPropertyChangedData, string.Join(".", "ParentB5857BD3_6DBE_48F0_9489_FD6C08F1528E", "__DynamicFormSettings"));
			dynamicFormPropertyChangedData.ChangedPropertyName = tpMetadata.TablePartPropertyName;
			return (ActionResult)(object)new DynamicFormChangeViewResult((DynamicFormChangeViewResultBase)(object)ProcessPropertyValueChanged((Controller)(object)this, dynamicFormPropertyChangedData, rootEntity, text2, view, null, state));
		}
		if (dynamicFormChangeViewResultBase == null)
		{
			return ThrowJsonException(SR.T("Не удалось получить результат выполнения сценария"));
		}
		return (ActionResult)(object)new DynamicFormChangeViewResult(dynamicFormChangeViewResultBase);
	}

	private ActionResult ThrowJsonException(string message)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		base.Logger.Error(message);
		JsonResult val = new JsonResult();
		val.set_Data((object)new
		{
			Error = true,
			Message = message
		});
		return (ActionResult)val;
	}
}
