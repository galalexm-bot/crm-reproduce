using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Xml.Serialization;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Models;
using Iesi.Collections;

namespace EleWise.ELMA.Web.Mvc.Portlets;

[Serializable]
public class PortletPersonalization : IPortletPersonalization, IStoreValuesObject
{
	public static readonly PortletPersonalization Empty = new PortletPersonalization();

	[NonSerialized]
	private PersonalizationContext _personalizationContext;

	private bool enableAsyncLoading = true;

	private Guid _portletUid = Guid.Empty;

	private string _zone = "Left";

	private int _order;

	private bool _closed;

	private bool _collapsed;

	private object _value;

	public Guid InstanceId { get; set; }

	[Category("Внешний вид")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(PortletPersonalization_SR), "P_Name")]
	[Personalization(PersonalizationScope.Shared)]
	public virtual string Name { get; set; }

	[Category("Внешний вид")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(PortletPersonalization_SR), "P_PortletFrame")]
	[Personalization(PersonalizationScope.Shared)]
	public virtual PortletFrame Frame { get; set; }

	[Category("Внешний вид")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(PortletPersonalization_SR), "P_HeaderColor")]
	[Personalization(PersonalizationScope.Shared)]
	public virtual string HeaderColor { get; set; }

	[Category("Внешний вид")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(PortletPersonalization_SR), "P_TextHeaderColor")]
	[Personalization(PersonalizationScope.Shared)]
	public virtual string TextHeaderColor { get; set; }

	[Category("Внешний вид")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(PortletPersonalization_SR), "P_Width")]
	[Personalization(PersonalizationScope.Shared)]
	public double? Width { get; set; }

	[Category("Внешний вид")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(PortletPersonalization_SR), "P_Height")]
	[Personalization(PersonalizationScope.Shared)]
	public double? Height { get; set; }

	[Category("Внешний вид")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(PortletPersonalization_SR), "P_Minimized")]
	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public bool Minimized { get; set; }

	[Category("Дополнительно")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(PortletPersonalization_SR), "P_DenyMinimize")]
	[Personalization(PersonalizationScope.Shared)]
	[BoolSettings(DisplayType = BoolDisplayType.Checkbox)]
	public bool DenyMinimize { get; set; }

	[Category("Дополнительно")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(PortletPersonalization_SR), "P_NameUrl")]
	[Personalization(PersonalizationScope.Shared)]
	public virtual string NameUrl { get; set; }

	[Category("Дополнительно")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(PortletPersonalization_SR), "P_ImageUrl")]
	[Personalization(PersonalizationScope.Shared)]
	public virtual string ImageUrl { get; set; }

	[Category("Дополнительно")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(PortletPersonalization_SR), "P_Groups")]
	[Personalization(PersonalizationScope.Shared)]
	[HiddenInput(DisplayValue = false)]
	public string Groups { get; set; }

	[Category("Параметры AJAX")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(PortletPersonalization_SR), "P_EnableAsyncLoading")]
	[Personalization(PersonalizationScope.Shared)]
	[BoolSettings(DisplayType = BoolDisplayType.Checkbox)]
	public bool EnableAsyncLoading
	{
		get
		{
			return enableAsyncLoading;
		}
		set
		{
			enableAsyncLoading = value;
		}
	}

	[Category("Параметры AJAX")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(PortletPersonalization_SR), "P_ShowAsyncUpdateButton")]
	[Personalization(PersonalizationScope.Shared)]
	[BoolSettings(DisplayType = BoolDisplayType.Checkbox)]
	public bool ShowAsyncUpdateButton { get; set; }

	[Category("Параметры AJAX")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(PortletPersonalization_SR), "P_AsyncUpdateInterval")]
	[Personalization(PersonalizationScope.Shared)]
	[HiddenInput(DisplayValue = false)]
	public int? AsyncUpdateInterval { get; set; }

	public virtual Guid PortletUid
	{
		get
		{
			return _portletUid;
		}
		set
		{
			_portletUid = value;
		}
	}

	[Personalization(PersonalizationScope.User)]
	public virtual string Zone
	{
		get
		{
			return _zone;
		}
		set
		{
			_zone = value;
		}
	}

	[Personalization(PersonalizationScope.User)]
	public virtual int Order
	{
		get
		{
			return _order;
		}
		set
		{
			_order = value;
		}
	}

	[Personalization(PersonalizationScope.Shared)]
	public virtual bool Closed
	{
		get
		{
			return _closed;
		}
		set
		{
			_closed = value;
		}
	}

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool Collapsed
	{
		get
		{
			return _collapsed;
		}
		set
		{
			_collapsed = value;
		}
	}

	public virtual object Value
	{
		get
		{
			return _value;
		}
		set
		{
			_value = value;
		}
	}

	public virtual bool Shared { get; set; }

	public virtual string Path { get; set; }

	protected IMetadataRuntimeService MetadataRuntimeService => Locator.GetServiceNotNull<IMetadataRuntimeService>();

	public void SetPersonalizationContext(PersonalizationContext context)
	{
		_personalizationContext = context;
	}

	public PersonalizationContext GetPersonalizationContext()
	{
		return _personalizationContext;
	}

	public virtual bool PropertyIsShow(string name)
	{
		return true;
	}

	protected virtual ClassMetadata GetMetadata()
	{
		return MetadataLoader.LoadMetadata(GetType()) as ClassMetadata;
	}

	protected virtual IDictionary<string, string> GetStorageValue(PropertyInfo property)
	{
		string value = null;
		bool flag = false;
		object value2 = property.GetValue(this, null);
		if (value2 == null)
		{
			return new Dictionary<string, string>();
		}
		ClassMetadata metadata = GetMetadata();
		if (metadata != null)
		{
			PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == property.Name);
			if (propertyMetadata != null)
			{
				if (MetadataRuntimeService.GetTypeDescriptor(propertyMetadata.TypeUid, propertyMetadata.SubTypeUid) is ISerializableTypeDescriptor serializableTypeDescriptor)
				{
					WebData webData = new WebData(serializableTypeDescriptor.Serialize(this, metadata, propertyMetadata, (serializableTypeDescriptor is EntityDescriptor) ? new EntitySerializationSettings
					{
						Mode = EntitySerializationMode.Compact
					} : null));
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					WebDataItem[] items = webData.Items;
					foreach (WebDataItem webDataItem in items)
					{
						string value3 = ClassSerializationHelper.SerializeObjectByJsonNet(webDataItem);
						dictionary.Add(webDataItem.Name, value3);
					}
					return dictionary;
				}
			}
			else if (metadata is EntityMetadata)
			{
				TablePartMetadata tablePartMetadata = ((EntityMetadata)metadata).TableParts.FirstOrDefault((TablePartMetadata tp) => tp.TablePartPropertyName == property.Name);
				IEnumerable enumerable = value2 as IEnumerable;
				if (tablePartMetadata != null && enumerable != null)
				{
					SerializableList<WebData> serializableList = new SerializableList<WebData>();
					foreach (object item in enumerable)
					{
						serializableList.Add(WebData.CreateFromObject(item));
					}
					value = ClassSerializationHelper.SerializeObjectByJsonNet(serializableList);
					flag = true;
				}
			}
		}
		if (!flag)
		{
			value = ClassSerializationHelper.SerializeObjectByJsonNet(value2);
		}
		return new Dictionary<string, string> { { property.Name, value } };
	}

	protected virtual void SetStorageValue(PropertyInfo property, IDictionary<string, string> values)
	{
		if (!values.ContainsKey(property.Name))
		{
			return;
		}
		string text = values[property.Name];
		if (text == null)
		{
			return;
		}
		try
		{
			ClassMetadata metadata = GetMetadata();
			if (metadata != null)
			{
				PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == property.Name);
				if (propertyMetadata != null)
				{
					if (MetadataRuntimeService.GetTypeDescriptor(propertyMetadata.TypeUid, propertyMetadata.SubTypeUid) is ISerializableTypeDescriptor serializableTypeDescriptor)
					{
						WebDataItem webDataItem = ClassSerializationHelper.DeserializeObjectByJsonNet<WebDataItem>(text);
						WebData webData = new WebData();
						webData.Items = new WebDataItem[1] { webDataItem };
						IDictionary<string, object> dictionary = webData.ToDictionary();
						if (serializableTypeDescriptor is EntityDescriptor)
						{
							((EntityDescriptor)serializableTypeDescriptor).PrepareDeserializedData(dictionary);
						}
						serializableTypeDescriptor.Deserialize(this, metadata, propertyMetadata, dictionary);
						return;
					}
				}
				else if (metadata is EntityMetadata)
				{
					TablePartMetadata tablePartMetadata = ((EntityMetadata)metadata).TableParts.FirstOrDefault((TablePartMetadata tp) => tp.TablePartPropertyName == property.Name);
					if (tablePartMetadata != null)
					{
						SerializableList<WebData> serializableList = ClassSerializationHelper.DeserializeObjectByJsonNet<SerializableList<WebData>>(text);
						Type typeByUid = MetadataRuntimeService.GetTypeByUid(tablePartMetadata.Uid);
						EntityJsonSerializer entityJsonSerializer = new EntityJsonSerializer();
						object value = property.GetValue(this, null);
						ISet val = (ISet)((value is ISet) ? value : null);
						if (val == null)
						{
							return;
						}
						val.Clear();
						{
							foreach (WebData item in serializableList)
							{
								IDictionary<string, object> dictionary2 = item.ToDictionary();
								if (dictionary2 != null)
								{
									IEntity entity = (IEntity)entityJsonSerializer.ConvertFromSerializable(dictionary2, typeByUid);
									entity?.SetPropertyValue(tablePartMetadata.ParentPropertyUid, this);
									val.Add((object)entity);
								}
							}
							return;
						}
					}
				}
			}
			object value2 = ClassSerializationHelper.DeserializeObjectByJsonNet(property.PropertyType, text);
			property.SetValue(this, value2, null);
		}
		catch (Exception exception)
		{
			Logger.Log.Error($"Cannot deserialize setting {property.Name} in type {property.DeclaringType}", exception);
		}
	}

	protected virtual bool SkipProperty(PropertyInfo property)
	{
		if (property.CanRead)
		{
			return !property.CanWrite;
		}
		return true;
	}

	private static bool SkipPropertyByAttribute(PropertyInfo property)
	{
		return AttributeHelper<XmlIgnoreAttribute>.GetAttribute(property, inherited: true) != null;
	}

	IDictionary<string, string> IStoreValuesObject.GetStorageValues()
	{
		return (from property in GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
			where !SkipPropertyByAttribute(property)
			where !SkipProperty(property)
			where property.GetIndexParameters().Length == 0
			select property).SelectMany(GetStorageValue).ToDictionary((KeyValuePair<string, string> k) => k.Key, (KeyValuePair<string, string> v) => v.Value);
	}

	void IStoreValuesObject.SetStorageValues(IDictionary<string, string> values)
	{
		if (values != null)
		{
			(from property in GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
				where values.Keys.Contains(property.Name)
				where !SkipPropertyByAttribute(property)
				where !SkipProperty(property)
				where property.GetIndexParameters().Length == 0
				select property).ForEach(delegate(PropertyInfo property)
			{
				SetStorageValue(property, values);
			});
		}
	}
}
