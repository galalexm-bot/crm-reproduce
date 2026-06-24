using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Forms;
using Iesi.Collections;
using Newtonsoft.Json;

namespace EleWise.ELMA.Web.Mvc;

public class ElmaModelBinder : DefaultModelBinder
{
	private class CustomBindPropertyDescriptor : PropertyDescriptor
	{
		public Action BindAction { get; set; }

		public override Type ComponentType
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public override bool IsReadOnly => false;

		public override Type PropertyType
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public CustomBindPropertyDescriptor()
			: base("#CustomBindPropertyDescriptor#", new Attribute[0])
		{
		}

		public override bool CanResetValue(object component)
		{
			throw new NotImplementedException();
		}

		public override object GetValue(object component)
		{
			throw new NotImplementedException();
		}

		public override void ResetValue(object component)
		{
		}

		public override void SetValue(object component, object value)
		{
		}

		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}
	}

	private class SkipValueProvider : IValueProvider
	{
		private readonly IValueProvider valueProvider;

		private readonly string skipValue;

		public SkipValueProvider(IValueProvider valueProvider, string skipValue)
		{
			this.valueProvider = valueProvider;
			this.skipValue = skipValue;
		}

		public bool ContainsPrefix(string prefix)
		{
			return valueProvider.ContainsPrefix(prefix);
		}

		public ValueProviderResult GetValue(string key)
		{
			if (!(key == skipValue))
			{
				return valueProvider.GetValue(key);
			}
			return null;
		}
	}

	private const string ResetTablePartNewItemIdsKey = "ElmaModelBinder.ResetTablePartNewItemIds";

	private static readonly string BoundEntityListCacheKey = typeof(ElmaModelBinder).FullName + ":BoundEntityList";

	public static ISecurityService _securityService { get; set; }

	public static IMetadataRuntimeService _metadataRuntimeService { get; set; }

	public static ISecurityService securityService => _securityService ?? (_securityService = Locator.GetServiceNotNull<ISecurityService>());

	public IMetadataRuntimeService MetadataRuntimeService => _metadataRuntimeService ?? (_metadataRuntimeService = Locator.GetServiceNotNull<IMetadataRuntimeService>());

	public static bool ResetTablePartNewItemIds
	{
		get
		{
			return ContextVars.GetOrAdd("ElmaModelBinder.ResetTablePartNewItemIds", () => true);
		}
		set
		{
			ContextVars.Set("ElmaModelBinder.ResetTablePartNewItemIds", value);
		}
	}

	public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		if (bindingContext == null)
		{
			throw new ArgumentNullException("bindingContext");
		}
		if (bindingContext.get_ModelType() != typeof(string))
		{
			ValueProviderResult value = bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName());
			if (value != null && !string.IsNullOrWhiteSpace(value.get_AttemptedValue()))
			{
				string text = value.get_AttemptedValue().Trim();
				if (text.StartsWith("{") && text.EndsWith("}"))
				{
					IValueProvider val = DeserializeJsonResult(value, (JsonToken)1, bindingContext.get_ModelName(), ".");
					if (val != null)
					{
						bindingContext.set_ValueProvider(val);
						return ((DefaultModelBinder)this).BindModel(controllerContext, bindingContext);
					}
				}
			}
		}
		if (typeof(IEntity).IsAssignableFrom(bindingContext.get_ModelType()) || typeof(IAutoImplement).IsAssignableFrom(bindingContext.get_ModelType()))
		{
			object obj = ((bindingContext.get_Model() != null && bindingContext.get_ModelMetadata() != null && bindingContext.get_ModelMetadata().get_PropertyName() == null) ? bindingContext.get_Model() : ((DefaultModelBinder)this).CreateModel(controllerContext, ModelBindingContext(bindingContext), bindingContext.get_ModelType()));
			if (obj == null)
			{
				return null;
			}
			if (!(MetadataLoader.LoadMetadata(obj.GetType()) is ITablePartMetadata))
			{
				BindEntityJsonState(obj, controllerContext, bindingContext);
			}
			ModelBindingContext val2 = CreateEntityBindingContext(controllerContext, bindingContext, obj);
			return ((DefaultModelBinder)this).BindModel(controllerContext, val2);
		}
		if (typeof(IEntityFilter).IsAssignableFrom(bindingContext.get_ModelType()))
		{
			object filter = ((bindingContext.get_Model() != null && bindingContext.get_ModelMetadata() != null && bindingContext.get_ModelMetadata().get_PropertyName() == null) ? bindingContext.get_Model() : ((DefaultModelBinder)this).CreateModel(controllerContext, ModelBindingContext(bindingContext), bindingContext.get_ModelType()));
			if (filter == null)
			{
				return null;
			}
			bindingContext.set_ModelMetadata(ModelMetadataProviders.get_Current().GetMetadataForType((Func<object>)(() => filter), bindingContext.get_ModelType()));
			return ((DefaultModelBinder)this).BindModel(controllerContext, bindingContext);
		}
		object obj2 = null;
		if (ExtractGenericInterface(bindingContext.get_ModelType(), typeof(ICollection<>)) != null)
		{
			obj2 = bindingContext.get_Model();
			ValueProviderResult value2 = bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName());
			if (value2 != null)
			{
				IValueProvider obj3;
				if (!value2.get_AttemptedValue().IsNullOrEmpty())
				{
					obj3 = DeserializeJsonResult(value2, (JsonToken)2, bindingContext.get_ModelName(), string.Empty);
				}
				else
				{
					IValueProvider val3 = (IValueProvider)(object)new SkipValueProvider(bindingContext.get_ValueProvider(), bindingContext.get_ModelName());
					obj3 = val3;
				}
				IValueProvider val4 = obj3;
				if (val4 != null)
				{
					ModelBindingContext val5 = new ModelBindingContext();
					val5.set_ModelMetadata(bindingContext.get_ModelMetadata());
					val5.set_ModelName(bindingContext.get_ModelName());
					val5.set_ModelState(bindingContext.get_ModelState());
					val5.set_PropertyFilter(bindingContext.get_PropertyFilter());
					val5.set_ValueProvider(val4);
					bindingContext = val5;
				}
			}
		}
		object obj4 = BindObjectJsonState(controllerContext, bindingContext);
		object obj5 = ((obj4 != null) ? ((DefaultModelBinder)this).BindModel(controllerContext, CreateEntityBindingContext(controllerContext, bindingContext, obj4)) : ((DefaultModelBinder)this).BindModel(controllerContext, bindingContext));
		if (obj2 != null && obj5 == null)
		{
			MethodInfo method = obj2.GetType().GetMethod("Clear", BindingFlags.Instance | BindingFlags.Public, null, new Type[0], null);
			if (method != null)
			{
				method.Invoke(obj2, null);
			}
			return obj2;
		}
		return obj5;
	}

	private IValueProvider DeserializeJsonResult(ValueProviderResult providerResult, JsonToken startToken, string prefix, string delimiter)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		IValueProvider result = null;
		try
		{
			Dictionary<string, object> dictionary = null;
			JsonTextReader val = new JsonTextReader((TextReader)new StringReader(providerResult.ConvertTo<string>()));
			try
			{
				if (((JsonReader)val).Read() && ((JsonReader)val).get_TokenType() == startToken)
				{
					while (((JsonReader)val).Read())
					{
						JsonToken tokenType = ((JsonReader)val).get_TokenType();
						if (tokenType - 6 <= 5 || tokenType - 16 <= 1)
						{
							dictionary = dictionary ?? new Dictionary<string, object>();
							dictionary[prefix + delimiter + ClassSerializationHelper.GetUnescapedJsonNetPath(((JsonReader)val).get_Path())] = ((JsonReader)val).get_Value();
						}
					}
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			if (dictionary != null)
			{
				result = (IValueProvider)(object)new DictionaryValueProvider<object>((IDictionary<string, object>)dictionary, providerResult.get_Culture());
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	private static Type ExtractGenericInterface(Type queryType, Type interfaceType)
	{
		Func<Type, bool> func = (Type t) => t.IsGenericType && t.GetGenericTypeDefinition() == interfaceType;
		if (!func(queryType))
		{
			return queryType.GetInterfaces().FirstOrDefault(func);
		}
		return queryType;
	}

	internal ModelBindingContext CreateEntityBindingContext(ControllerContext controllerContext, ModelBindingContext bindingContext, object entity)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		ModelBindingContext val = new ModelBindingContext();
		val.set_FallbackToEmptyPrefix(bindingContext.get_FallbackToEmptyPrefix());
		val.set_ModelMetadata(ModelMetadataProviders.get_Current().GetMetadataForType((Func<object>)(() => entity), bindingContext.get_ModelType()));
		val.set_ModelName(bindingContext.get_ModelName());
		val.set_ModelState(bindingContext.get_ModelState());
		val.set_PropertyFilter(bindingContext.get_PropertyFilter());
		val.set_ValueProvider((IValueProvider)(object)new SkipValueProvider(bindingContext.get_ValueProvider(), bindingContext.get_ModelName()));
		return val;
	}

	private static bool ShouldPerformRequestValidation(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		if (controllerContext != null && controllerContext.get_Controller() != null && bindingContext != null && bindingContext.get_ModelMetadata() != null)
		{
			if (controllerContext.get_Controller().get_ValidateRequest())
			{
				return bindingContext.get_ModelMetadata().get_RequestValidationEnabled();
			}
			return false;
		}
		return true;
	}

	protected override bool OnModelUpdating(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		if (bindingContext.get_Model() == null)
		{
			return false;
		}
		return ((DefaultModelBinder)this).OnModelUpdating(controllerContext, bindingContext);
	}

	protected override void OnModelUpdated(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		if (bindingContext.get_Model() == null || !(bindingContext.get_Model().GetType().GetInterface(typeof(ICompositeEntity).FullName) != null))
		{
			((DefaultModelBinder)this).OnModelUpdated(controllerContext, bindingContext);
		}
	}

	protected override void BindProperty(ControllerContext controllerContext, ModelBindingContext bindingContext, PropertyDescriptor propertyDescriptor)
	{
		if (propertyDescriptor is CustomBindPropertyDescriptor customBindPropertyDescriptor)
		{
			if (customBindPropertyDescriptor.BindAction != null)
			{
				customBindPropertyDescriptor.BindAction();
			}
			return;
		}
		if (bindingContext.get_Model() is IEntity entity && MetadataLoader.LoadMetadata(entity.GetType()) is IEntityMetadata entityMetadata)
		{
			ITablePartMetadata tablePartMetadata = entityMetadata.GetPropertiesAndTableParts().OfType<ITablePartMetadata>().FirstOrDefault((ITablePartMetadata p) => p.TablePartPropertyName == propertyDescriptor.Name);
			if (tablePartMetadata != null)
			{
				BindEntityTablePart(controllerContext, bindingContext, propertyDescriptor, entityMetadata, tablePartMetadata);
				return;
			}
		}
		((DefaultModelBinder)this).BindProperty(controllerContext, bindingContext, propertyDescriptor);
	}

	public static void SetTablePartParent(IEntity tablePartItem, object parent)
	{
		if (tablePartItem == null)
		{
			throw new ArgumentNullException("tablePartItem");
		}
		Type type = tablePartItem.CastAsRealType().GetType();
		PropertyInfo reflectionProperty = type.GetReflectionProperty("Parent");
		if (reflectionProperty == null)
		{
			throw new InvalidOperationException(SR.T("Не найдено свойство с именем '{0}' в типе '{1}'", "Parent", type.AssemblyQualifiedName));
		}
		object value = ConvertParentForTablePart(reflectionProperty.PropertyType, parent);
		reflectionProperty.SetValue(tablePartItem, value, null);
	}

	protected virtual void BindEntityTablePart(ControllerContext controllerContext, ModelBindingContext bindingContext, PropertyDescriptor propertyDescriptor, IEntityMetadata metadata, ITablePartMetadata tablePart)
	{
		string text = DefaultModelBinder.CreateSubPropertyName(bindingContext.get_ModelName(), propertyDescriptor.Name);
		IEnumerable enumerable = (IEnumerable)propertyDescriptor.GetValue(bindingContext.get_Model());
		if (enumerable == null)
		{
			return;
		}
		ISet val = (ISet)((enumerable is ISet) ? enumerable : null);
		if (val == null)
		{
			return;
		}
		if (!bindingContext.get_ValueProvider().ContainsPrefix(text))
		{
			foreach (IEntity item in (IEnumerable)val)
			{
				SetTablePartParent(item, bindingContext.get_Model());
			}
			return;
		}
		ValueProviderResult value = bindingContext.get_ValueProvider().GetValue(text);
		string[] array = ((value != null) ? (value.get_RawValue() as string[]) : null);
		string text2 = ((array != null && array.Length != 0) ? array[0] : null);
		if (text2 == null)
		{
			return;
		}
		TablePartChangesModel tablePartChangesModel = new JsonSerializer().Deserialize<TablePartChangesModel>(text2);
		if (tablePartChangesModel == null)
		{
			return;
		}
		List<object> list = (from e in ((IEnumerable)val).OfType<IEntity>()
			select e.GetId()).ToList();
		Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(tablePart.Uid);
		Type entityIdType = ModelHelper.GetEntityIdType(typeByUid);
		tablePartChangesModel.Apply(val, typeByUid, needRemoveOldItems: true, (IEntity e) => !GetBoundEntityList().Contains(e));
		foreach (IEntity item2 in (IEnumerable)val)
		{
			object id = item2.GetId();
			if (!list.Contains(id) && ResetTablePartNewItemIds && typeByUid.IsNewId(entityIdType, id) && MetadataLoader.LoadMetadata(typeByUid) is ITablePartExtension tablePartExtension && !(tablePartExtension.TablePartOwner is ITablePartMetadata))
			{
				item2.SetId(typeByUid.DefaultIdentifierValue(entityIdType));
			}
			SetTablePartParent(item2, bindingContext.get_Model());
		}
	}

	protected override object CreateModel(ControllerContext controllerContext, ModelBindingContext bindingContext, Type modelType)
	{
		return CreateModel(controllerContext, bindingContext, modelType, base.CreateModel);
	}

	internal static object CreateModel(ControllerContext controllerContext, ModelBindingContext bindingContext, Type modelType, Func<ControllerContext, ModelBindingContext, Type, object> baseCreateModelFunc)
	{
		if (modelType != null)
		{
			if (modelType.GetInterface(typeof(IEntity).FullName) != null || modelType == typeof(IEntity))
			{
				ValueProviderResult value = bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName());
				if (((value != null) ? value.get_RawValue() : null) is ParameterContainer parameterContainer)
				{
					return parameterContainer.Entity;
				}
				if (!string.IsNullOrEmpty(bindingContext.get_ModelName()) && !bindingContext.get_ValueProvider().ContainsPrefix(bindingContext.get_ModelName()))
				{
					return null;
				}
				string prefix = ((!string.IsNullOrEmpty(bindingContext.get_ModelName())) ? (bindingContext.get_ModelName() + ".") : "");
				string key = prefix + "TypeUid";
				string value2 = bindingContext.GetValue<string>(key);
				Type type = modelType;
				if (!string.IsNullOrEmpty(value2))
				{
					Guid uid = new Guid(value2);
					type = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(uid);
				}
				string key2 = prefix + "Id";
				string value3 = bindingContext.GetValue<string>(key2);
				IEntity entity = null;
				object id = null;
				if (value3 != null)
				{
					if (!(value3 != string.Empty))
					{
						return null;
					}
					Type entityIdType = ModelHelper.GetEntityIdType(type);
					TypeConverter converter = TypeDescriptor.GetConverter(entityIdType);
					id = converter.ConvertFromInvariantString(value3);
					if (!type.IsDefaultId(entityIdType, id))
					{
						string key3 = prefix.TrimEnd('.') + "_BinderProviderUid";
						string value4 = bindingContext.GetValue<string>(key3);
						if (!string.IsNullOrEmpty(value4))
						{
							Guid providerUid = new Guid(value4);
							IEntityModelBinderProvider entityModelBinderProvider = ComponentManager.Current.GetExtensionPoints<IEntityModelBinderProvider>().FirstOrDefault((IEntityModelBinderProvider p) => p.ProviderUid == providerUid);
							if (entityModelBinderProvider != null)
							{
								return entityModelBinderProvider.LoadEntity(type, id);
							}
						}
						IEntityManager manager = ModelHelper.GetEntityManager(type);
						securityService.RunWithElevatedPrivilegiesAndWithDeleted(delegate
						{
							entity = (IEntity)manager.Load(id).CastAsRealType();
						});
					}
				}
				else if (prefix == "")
				{
					if (InterfaceActivator.TypeOf(type).GetReflectionProperties().All((PropertyInfo p) => !bindingContext.get_ValueProvider().ContainsPrefix(p.Name)))
					{
						return null;
					}
				}
				else if (bindingContext.get_Model() is IEntity entity2 && string.IsNullOrWhiteSpace(value2) && prefix.Trim('.').IndexOf('.') > 0 && InterfaceActivator.TypeOf(type).GetReflectionProperties().Any((PropertyInfo p) => bindingContext.get_ValueProvider().ContainsPrefix(prefix + p.Name)))
				{
					entity = entity2;
				}
				if (entity == null)
				{
					entity = (IEntity)InterfaceActivator.Create(type);
					if (id != null)
					{
						entity.SetId(id);
					}
				}
				return entity;
			}
			if (!modelType.IsPrimitive && (modelType.IsClass || modelType.IsInterface) && (string.IsNullOrEmpty(bindingContext.get_ModelName()) || bindingContext.get_ValueProvider().ContainsPrefix(bindingContext.get_ModelName())))
			{
				string text = ((!string.IsNullOrEmpty(bindingContext.get_ModelName())) ? (bindingContext.get_ModelName() + ".") : "") + "__TypeName";
				object obj = ((bindingContext.get_ValueProvider() != null && bindingContext.get_ValueProvider().GetValue(text) != null) ? bindingContext.get_ValueProvider().GetValue(text).get_RawValue() : null);
				object obj2 = obj as string;
				if (obj2 == null)
				{
					IEnumerable<string> enumerable = obj as string[];
					obj2 = (enumerable ?? Enumerable.Empty<string>()).FirstOrDefault();
				}
				string text2 = (string)obj2;
				if (!string.IsNullOrEmpty(text2))
				{
					Type type2 = FindType(text2);
					if (type2 != null)
					{
						return InterfaceActivator.Create(type2);
					}
				}
			}
			Type type3 = modelType;
			if (modelType.IsGenericType)
			{
				Type genericTypeDefinition = modelType.GetGenericTypeDefinition();
				if (genericTypeDefinition == typeof(IDictionary<, >))
				{
					type3 = typeof(Dictionary<, >).MakeGenericType(modelType.GetGenericArguments());
				}
				else if (genericTypeDefinition == typeof(IEnumerable<>) || genericTypeDefinition == typeof(ICollection<>) || genericTypeDefinition == typeof(IList<>))
				{
					type3 = typeof(List<>).MakeGenericType(modelType.GetGenericArguments());
				}
			}
			if (type3.IsInterface)
			{
				return InterfaceActivator.Create(type3);
			}
			if (AttributeHelper<ServiceAttribute>.GetAttribute(type3, inherited: true) != null && Locator.Initialized)
			{
				object service = Locator.GetService(type3);
				if (service != null)
				{
					return service;
				}
			}
		}
		return baseCreateModelFunc?.Invoke(controllerContext, bindingContext, modelType);
	}

	private static ModelBindingContext ModelBindingContext(ModelBindingContext bindingContext)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		if (bindingContext.get_FallbackToEmptyPrefix() && !string.IsNullOrEmpty(bindingContext.get_ModelName()) && !bindingContext.get_ValueProvider().ContainsPrefix(bindingContext.get_ModelName()))
		{
			ModelBindingContext val = new ModelBindingContext();
			val.set_ModelMetadata(bindingContext.get_ModelMetadata());
			val.set_ModelState(bindingContext.get_ModelState());
			val.set_PropertyFilter(bindingContext.get_PropertyFilter());
			val.set_ValueProvider(bindingContext.get_ValueProvider());
			return val;
		}
		return bindingContext;
	}

	private void BindEntityJsonState(object entity, ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		if (!(entity is IEntity))
		{
			return;
		}
		string text = bindingContext.get_ModelName() + ((!string.IsNullOrEmpty(bindingContext.get_ModelName())) ? "." : "") + "__jsonState";
		if (!bindingContext.get_ValueProvider().ContainsPrefix(text))
		{
			return;
		}
		ValueProviderResult value = bindingContext.get_ValueProvider().GetValue(text);
		string[] array = ((value != null) ? (value.get_RawValue() as string[]) : null);
		string text2 = ((array != null && array.Length != 0) ? array[0] : null);
		if (string.IsNullOrEmpty(text2))
		{
			return;
		}
		ExpandoObject deserializedObject = new JsonSerializer().Deserialize<ExpandoObject>(text2);
		if (MetadataLoader.LoadMetadata(entity.CastAsRealType().GetType()) is IEntityMetadata entityMetadata && deserializedObject != null)
		{
			IDictionary<string, object> dictionary = deserializedObject;
			foreach (ITablePartMetadata item in entityMetadata.GetPropertiesAndTableParts().OfType<ITablePartMetadata>())
			{
				string text3 = bindingContext.get_ModelName() + ((!string.IsNullOrEmpty(bindingContext.get_ModelName())) ? "." : "") + item.TablePartPropertyName;
				if (bindingContext.get_ValueProvider().ContainsPrefix(text3) && dictionary.ContainsKey(item.TablePartPropertyName))
				{
					dictionary.Remove(item.TablePartPropertyName);
				}
			}
			foreach (string item2 in dictionary.Keys.ToList())
			{
				if (!bindingContext.get_PropertyFilter()(item2))
				{
					dictionary.Remove(item2);
				}
			}
		}
		EntityJsonSerializer serializer = new EntityJsonSerializer();
		securityService.RunWithElevatedPrivilegiesAndWithDeleted(delegate
		{
			serializer.ConvertFromSerializable(entity, deserializedObject);
		});
	}

	private object BindObjectJsonState(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		string text = bindingContext.get_ModelName() + ((!string.IsNullOrEmpty(bindingContext.get_ModelName())) ? "." : "") + "__jsonState";
		if (!bindingContext.get_ValueProvider().ContainsPrefix(text))
		{
			return null;
		}
		ValueProviderResult value = bindingContext.get_ValueProvider().GetValue(text);
		string[] array = ((value != null) ? (value.get_RawValue() as string[]) : null);
		string text2 = ((array != null && array.Length != 0) ? array[0] : null);
		if (string.IsNullOrEmpty(text2))
		{
			return null;
		}
		ExpandoObject deserializedObject = new JsonSerializer().Deserialize<ExpandoObject>(text2);
		object obj = null;
		try
		{
			obj = Activator.CreateInstance(bindingContext.get_ModelType());
		}
		catch
		{
			return obj;
		}
		EntityJsonSerializer serializer = new EntityJsonSerializer();
		securityService.RunWithElevatedPrivilegiesAndWithDeleted(delegate
		{
			serializer.ConvertFromSerializable(obj, deserializedObject);
		});
		return obj;
	}

	protected static Type FindType(string typeName)
	{
		Type type = ReflectionType.GetType(typeName);
		if (type != null)
		{
			return type;
		}
		foreach (Assembly item in ComponentManager.GetAssemblies().Reverse())
		{
			Type type2 = item.GetType(typeName);
			if (type2 != null)
			{
				return type2;
			}
		}
		return null;
	}

	protected override PropertyDescriptorCollection GetModelProperties(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		if (bindingContext.get_Model() == null)
		{
			return new PropertyDescriptorCollection(new PropertyDescriptor[0]);
		}
		PropertyDescriptorCollection propertyDescriptorCollection = null;
		if (bindingContext.get_Model() != null && bindingContext.get_Model().GetType() != bindingContext.get_ModelType())
		{
			ICustomTypeDescriptor typeDescriptor = new AssociatedMetadataTypeTypeDescriptionProvider(bindingContext.get_Model().GetType()).GetTypeDescriptor(bindingContext.get_Model().GetType());
			if (typeDescriptor != null)
			{
				propertyDescriptorCollection = typeDescriptor.GetProperties();
			}
		}
		if (propertyDescriptorCollection == null)
		{
			propertyDescriptorCollection = ((DefaultModelBinder)this).GetModelProperties(controllerContext, bindingContext);
		}
		if (bindingContext.get_Model() is IEntity)
		{
			ITablePartMetadata tpMd = MetadataLoader.LoadMetadata(bindingContext.get_Model().GetType()) as ITablePartMetadata;
			if (tpMd != null)
			{
				PropertyMetadata propertyMetadata = tpMd.Properties.Find((PropertyMetadata p) => p.Uid == tpMd.ParentPropertyUid);
				PropertyDescriptor propertyDescriptor = propertyDescriptorCollection.Find(propertyMetadata.Name, ignoreCase: false);
				if (propertyDescriptor != null)
				{
					Type parentType = ((propertyMetadata != null) ? MetadataRuntimeService.GetTypeByUidOrNull(propertyMetadata.SubTypeUid) : null);
					List<PropertyDescriptor> list = new List<PropertyDescriptor>();
					list.AddRange(propertyDescriptorCollection.OfType<PropertyDescriptor>());
					list.Remove(propertyDescriptor);
					list.Insert(0, new CustomBindPropertyDescriptor
					{
						BindAction = delegate
						{
							//IL_0000: Unknown result type (might be due to invalid IL or missing references)
							//IL_0005: Unknown result type (might be due to invalid IL or missing references)
							//IL_003a: Unknown result type (might be due to invalid IL or missing references)
							//IL_008c: Unknown result type (might be due to invalid IL or missing references)
							//IL_008d: Unknown result type (might be due to invalid IL or missing references)
							//IL_0097: Expected O, but got Unknown
							//IL_0097: Unknown result type (might be due to invalid IL or missing references)
							//IL_00b3: Expected O, but got Unknown
							ModelBindingContext val = new ModelBindingContext();
							val.set_ModelMetadata(ModelMetadataProviders.get_Current().GetMetadataForType((Func<object>)(() => null), parentType));
							val.set_ModelName(((!string.IsNullOrEmpty(bindingContext.get_ModelName())) ? (bindingContext.get_ModelName() + ".") : "") + "ParentB5857BD3_6DBE_48F0_9489_FD6C08F1528E");
							val.set_ModelState(new ModelStateDictionary());
							val.set_ValueProvider(bindingContext.get_ValueProvider());
							ModelBindingContext val2 = val;
							if (((DefaultModelBinder)this).get_Binders().get_DefaultBinder().BindModel(controllerContext, val2) is IEntity parent)
							{
								SetTablePartParent(bindingContext.get_Model() as IEntity, parent);
							}
						}
					});
					CustomBindPropertyDescriptor item = new CustomBindPropertyDescriptor
					{
						BindAction = delegate
						{
							BindEntityJsonState(bindingContext.get_Model(), controllerContext, bindingContext);
						}
					};
					list.Insert(1, item);
					propertyDescriptorCollection = new PropertyDescriptorCollection(list.ToArray());
				}
			}
		}
		return propertyDescriptorCollection;
	}

	protected override ICustomTypeDescriptor GetTypeDescriptor(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		return ((DefaultModelBinder)this).GetTypeDescriptor(controllerContext, bindingContext);
	}

	protected override void SetProperty(ControllerContext controllerContext, ModelBindingContext bindingContext, PropertyDescriptor propertyDescriptor, object value)
	{
		if (bindingContext.get_Model() != null)
		{
			if (bindingContext.get_Model() is IEntity source && MetadataLoader.LoadMetadata(source.CastAsRealType().GetType()) is ITablePartMetadata && propertyDescriptor.Name == "Parent")
			{
				value = ConvertParentForTablePart(propertyDescriptor.PropertyType, value);
			}
			((DefaultModelBinder)this).SetProperty(controllerContext, bindingContext, propertyDescriptor, value);
		}
	}

	protected static string GetPrefix(ModelBindingContext bindingContext)
	{
		string result = ((!string.IsNullOrEmpty(bindingContext.get_ModelName())) ? (bindingContext.get_ModelName() + ".") : "");
		if (!string.IsNullOrEmpty(bindingContext.get_ModelName()) && !bindingContext.get_ValueProvider().ContainsPrefix(bindingContext.get_ModelName()))
		{
			result = "";
		}
		return result;
	}

	private static void RegisterBoundEntity(IEntity entity)
	{
		List<IEntity> boundEntityList = GetBoundEntityList();
		if (!boundEntityList.Contains(entity))
		{
			boundEntityList.Add(entity);
		}
	}

	private static List<IEntity> GetBoundEntityList()
	{
		return Locator.GetService<IContextBoundVariableService>()?.GetOrAdd(BoundEntityListCacheKey, () => new List<IEntity>());
	}

	private static object ConvertParentForTablePart(Type propertyType, object value)
	{
		if (propertyType == null)
		{
			return value;
		}
		object obj = value;
		while (obj != null && !propertyType.IsAssignableFrom(obj.GetType()))
		{
			PropertyInfo reflectionProperty = obj.GetType().GetReflectionProperty("ParentContext");
			obj = ((!(reflectionProperty != null)) ? null : reflectionProperty.GetValue(obj, null));
		}
		return obj;
	}
}
