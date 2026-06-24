using System;
using System.Collections;
using System.Collections.Generic;
using Bridge;
using Bridge.Html5;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.DTO;

[Convention(/*Could not decode attribute arguments.*/)]
public sealed class ReactiveProxy : DataClass, IContext, ICloneable, IBridgeClass, IComparable
{
	[Name("$metadataService")]
	internal readonly IMetadataServiceContext metadataService;

	[Name("$proxyService")]
	internal readonly IProxyGeneratorService proxyService;

	[Name("$propertyRef")]
	internal object PropertyRef = new object();

	private string _003CUniqueKey_003Ek__BackingField;

	private string _003CTypeName_003Ek__BackingField;

	private string _003CTypeRef_003Ek__BackingField;

	private object _003CJson_003Ek__BackingField;

	private ClassMetadata _003CMetadata_003Ek__BackingField;

	private IDictionary<string, object> _003CActions_003Ek__BackingField = (IDictionary<string, object>)(object)new Dictionary<string, object>();

	private object _003CCanCast_003Ek__BackingField;

	private bool _003CisEntity_003Ek__BackingField;

	private Tuple<PropertyMetadata, ClassMetadata> _003CUniqueProperty_003Ek__BackingField;

	private ProxyType proxyType;

	[Name("$uid")]
	private string UniqueKey
	{
		get
		{
			return _003CUniqueKey_003Ek__BackingField;
		}
		set
		{
			_003CUniqueKey_003Ek__BackingField = value;
		}
	}

	[Name("$typeName")]
	internal string TypeName
	{
		get
		{
			return _003CTypeName_003Ek__BackingField;
		}
		set
		{
			_003CTypeName_003Ek__BackingField = value;
		}
	}

	[Name("$t")]
	public string TypeRef
	{
		get
		{
			return _003CTypeRef_003Ek__BackingField;
		}
		set
		{
			_003CTypeRef_003Ek__BackingField = value;
		}
	}

	[Name("$jsonObj")]
	public object Json
	{
		get
		{
			return _003CJson_003Ek__BackingField;
		}
		set
		{
			_003CJson_003Ek__BackingField = value;
		}
	}

	[Name("$$proxyMetadata")]
	public ClassMetadata Metadata
	{
		get
		{
			return _003CMetadata_003Ek__BackingField;
		}
		set
		{
			_003CMetadata_003Ek__BackingField = value;
		}
	}

	[Name("$$actions")]
	internal IDictionary<string, object> Actions
	{
		get
		{
			return _003CActions_003Ek__BackingField;
		}
		set
		{
			_003CActions_003Ek__BackingField = value;
		}
	}

	[Name("$$canCast")]
	internal object CanCast
	{
		get
		{
			return _003CCanCast_003Ek__BackingField;
		}
		set
		{
			_003CCanCast_003Ek__BackingField = value;
		}
	}

	[Name("$$isEntity")]
	internal bool isEntity
	{
		get
		{
			return _003CisEntity_003Ek__BackingField;
		}
		set
		{
			_003CisEntity_003Ek__BackingField = value;
		}
	}

	[Name("$uniqueProperty")]
	private Tuple<PropertyMetadata, ClassMetadata> UniqueProperty
	{
		get
		{
			return _003CUniqueProperty_003Ek__BackingField;
		}
		set
		{
			_003CUniqueProperty_003Ek__BackingField = value;
		}
	}

	public ReactiveProxy()
	{
	}

	internal ReactiveProxy(IMetadataServiceContext metadataService, IProxyGeneratorService proxyService)
	{
		this.metadataService = metadataService;
		this.proxyService = proxyService;
	}

	[Name("$getUniqueKey")]
	public string GetUniqueKey()
	{
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrWhiteSpace(UniqueKey))
		{
			return UniqueKey;
		}
		PropertyMetadata val = null;
		ClassMetadata metadata = null;
		Tuple<PropertyMetadata, ClassMetadata> val2 = ProxyPropertySearcher.FindUniquePropertyRecursively(metadataService, Metadata);
		if (val2 != null)
		{
			val = val2.get_Item1();
			metadata = val2.get_Item2();
			UniqueProperty = val2;
		}
		if (val != null)
		{
			PropertyInfoExpression propertyExpression = metadataService.GetPropertyExpression((IPropertyMetadata)(object)val, metadata);
			object plainPropertyValue = this.GetPlainPropertyValue(propertyExpression);
			return UniqueKey = plainPropertyValue.ToString();
		}
		if (this.HasProperty("Uid"))
		{
			object plainPropertyValue = this.GetPlainPropertyValue("Uid");
			Guid val3 = default(Guid);
			if (plainPropertyValue != null && Guid.TryParse(plainPropertyValue.ToString(), ref val3))
			{
				return UniqueKey = ((object)(Guid)(ref val3)).ToString();
			}
		}
		if (this.HasProperty("Id"))
		{
			object plainPropertyValue = this.GetPlainPropertyValue("Id");
			long num = default(long);
			if (plainPropertyValue != null && long.TryParse(plainPropertyValue.ToString(), ref num))
			{
				return UniqueKey = ((object)num).ToString();
			}
		}
		Guid val4 = Guid.NewGuid();
		return UniqueKey = ((object)(Guid)(ref val4)).ToString();
	}

	public override string ToString()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if (Json == null)
		{
			Json = new object();
		}
		string fullName = typeof(ReactiveProxy).get_FullName();
		string text = (Json.HasProperty("$toString") ? ((string)Json.GetPlainPropertyValue("$toString", fullName)) : fullName);
		if (text == null)
		{
			text = "";
		}
		if (string.IsNullOrWhiteSpace(text) || text == fullName)
		{
			ValueTuple<ClassMetadata, IPropertyMetadata> titleProperty = GetTitleProperty(Metadata);
			ClassMetadata item = titleProperty.Item1;
			IPropertyMetadata item2 = titleProperty.Item2;
			if (item != null && item2 != null)
			{
				PropertyInfoExpression propertyExpression = metadataService.GetPropertyExpression(item2, item);
				object obj = ((object)this).get_Item(propertyExpression.ObjectExpression);
				text = ((obj == null) ? "" : obj.ToString());
			}
		}
		return text;
	}

	public override bool Equals(object o)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		if (o is ReactiveProxy reactiveProxy && reactiveProxy.isEntity && isEntity)
		{
			Entity entity = ObjectExtensions.As<Entity>(o);
			Entity entity2 = As<Entity>();
			bool flag = false;
			bool flag2 = false;
			if (entity2.HasProperty("Id") && entity.HasProperty("Id") && entity2.Id.get_HasValue() && entity.Id.get_HasValue())
			{
				flag = entity2.Id == entity.Id;
				flag2 = true;
			}
			bool flag3 = false;
			bool flag4 = false;
			if (entity2.HasProperty("Uid") && entity.HasProperty("Uid"))
			{
				flag3 = entity2.Uid == entity.Uid;
				flag4 = true;
			}
			if (flag2 && flag4)
			{
				return flag && flag3;
			}
			if (flag4)
			{
				return flag3;
			}
			if (flag2)
			{
				return flag;
			}
			return false;
		}
		return ((object)this).Equals(o);
	}

	public int CompareTo(object obj)
	{
		if (obj == null)
		{
			return 1;
		}
		return string.Compare(((object)this).ToString(), obj.ToString(), (StringComparison)4);
	}

	internal object CloneJson()
	{
		return JSON.Parse(JSON.Stringify(Json));
	}

	public object Clone()
	{
		ReactiveProxy reactiveProxy = new ReactiveProxy(metadataService, proxyService)
		{
			Metadata = Metadata,
			CanCast = CanCast,
			TypeRef = TypeRef,
			isEntity = isEntity,
			TypeName = TypeName,
			Actions = (IDictionary<string, object>)(object)new Dictionary<string, object>(Actions),
			UniqueKey = null,
			PropertyRef = PropertyRef
		};
		if (UniqueProperty != null)
		{
			reactiveProxy.UniqueProperty = UniqueProperty;
		}
		_ = PropertyRef;
		reactiveProxy.Json = new object();
		reactiveProxy.Json.set_Item("$t", Json.get_Item("$t"));
		object obj = ConvertHelper.Serialize(Json, new SerializationSettings
		{
			WriteReferences = true
		});
		ConvertHelper.Reconcile(reactiveProxy, obj);
		return reactiveProxy;
	}

	internal T GetProxyPropertyValue<T>(string propertyName)
	{
		return (T)GetProxyPropertyValue(propertyName);
	}

	internal object GetProxyPropertyValue(string propertyName)
	{
		Tuple<PropertyMetadata, ClassMetadata> val = ProxyPropertySearcher.FindPropertyRecursively(metadataService, Metadata, propertyName);
		if (val != null)
		{
			PropertyMetadata item = val.get_Item1();
			ClassMetadata item2 = val.get_Item2();
			PropertyInfoExpression propertyExpression = metadataService.GetPropertyExpression((IPropertyMetadata)(object)item, item2);
			return this.GetPlainPropertyValue(propertyExpression);
		}
		return null;
	}

	internal void SetProxyPropertyValue(string propertyName, object value)
	{
		Tuple<PropertyMetadata, ClassMetadata> val = ProxyPropertySearcher.FindPropertyRecursively(metadataService, Metadata, propertyName);
		if (val != null)
		{
			PropertyMetadata item = val.get_Item1();
			ClassMetadata item2 = val.get_Item2();
			PropertyInfoExpression propertyExpression = metadataService.GetPropertyExpression((IPropertyMetadata)(object)item, item2);
			this.SetPlainPropertyValue(propertyExpression, value);
		}
	}

	[Name("$getType")]
	private ProxyType GetTypeFunc()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (proxyType == null)
		{
			Guid uid = ((IMetadata)Metadata).get_Uid();
			proxyType = DTOHelper.ProxyType(((object)(Guid)(ref uid)).ToString());
		}
		return proxyType;
	}

	private ValueTuple<ClassMetadata, IPropertyMetadata> GetTitleProperty(ClassMetadata metadata)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		if (metadata != null && metadataService != null)
		{
			Guid titlePropertyUid = metadata.get_TitlePropertyUid();
			if (titlePropertyUid != Guid.Empty)
			{
				IPropertyMetadata property = metadataService.GetProperty(Metadata, titlePropertyUid);
				if (property != null)
				{
					return new ValueTuple<ClassMetadata, IPropertyMetadata>(metadata, property);
				}
			}
			DataClassMetadata val;
			if ((val = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null)) != null)
			{
				System.Collections.Generic.IEnumerator<DataClassDependency> enumerator = ((System.Collections.Generic.IEnumerable<DataClassDependency>)val.get_IncludeList()).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						DataClassDependency current = enumerator.get_Current();
						IMetadata metadata2 = metadataService.GetMetadata(((Dependency)current).get_HeaderUid());
						DataClassMetadata metadata3;
						if ((metadata3 = (DataClassMetadata)(object)((metadata2 is DataClassMetadata) ? metadata2 : null)) != null)
						{
							ValueTuple<ClassMetadata, IPropertyMetadata> titleProperty = GetTitleProperty((ClassMetadata)(object)metadata3);
							ClassMetadata item = titleProperty.Item1;
							IPropertyMetadata item2 = titleProperty.Item2;
							if (item != null && item2 != null)
							{
								return new ValueTuple<ClassMetadata, IPropertyMetadata>(item, item2);
							}
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator)?.Dispose();
				}
			}
		}
		return new ValueTuple<ClassMetadata, IPropertyMetadata>((ClassMetadata)null, (IPropertyMetadata)null);
	}
}
