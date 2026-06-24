using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Binder;

[Service]
internal sealed class DefaultModelBinder : IModelBinder
{
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public string propertyName;

		internal bool _003CBindModel_003Eb__0(PropertyMetadata a)
		{
			return ((INamedMetadata)a).get_Name() == propertyName;
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public string propertyName;

		internal bool _003CProcessDto_003Eb__0(PropertyMetadata a)
		{
			return ((INamedMetadata)a).get_Name() == propertyName;
		}
	}

	private readonly IProxyGeneratorService proxyGeneratorService;

	private readonly IMetadataServiceContext metadataService;

	private readonly IDescriptorService descriptorService;

	public DefaultModelBinder(IProxyGeneratorService proxyGeneratorService, IMetadataServiceContext metadataService, IDescriptorService descriptorService)
	{
		this.proxyGeneratorService = proxyGeneratorService;
		this.metadataService = metadataService;
		this.descriptorService = descriptorService;
	}

	public void BindModel(ModelBindingContext bindingContext, RequestContext requestContext)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		Contract.ArgumentNotNull(bindingContext, "bindingContext");
		Contract.ArgumentNotNull(requestContext, "requestContext");
		ClassMetadata metadata = bindingContext.ModelMetadata.Metadata;
		object model = bindingContext.ModelMetadata.Model;
		System.Collections.Generic.ICollection<PropertyMetadata> properties = metadata.get_Properties();
		Enumerator<string, string> enumerator = requestContext.RouteData.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<string, string> current = enumerator.get_Current();
				_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
				string[] array = current.get_Key().Split(new char[1] { '.' });
				string text = array[0];
				ValueTuple<string, int?> val = TryParseArrayKey(text);
				CS_0024_003C_003E8__locals0.propertyName = val.Item1;
				PropertyMetadata obj = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)properties, (Func<PropertyMetadata, bool>)((PropertyMetadata a) => ((INamedMetadata)a).get_Name() == CS_0024_003C_003E8__locals0.propertyName));
				ViewModelPropertyMetadata val2 = (ViewModelPropertyMetadata)(object)((obj is ViewModelPropertyMetadata) ? obj : null);
				if (val2 != null && val2.get_Input())
				{
					string[] keys = Enumerable.Except<string>((System.Collections.Generic.IEnumerable<string>)array, (System.Collections.Generic.IEnumerable<string>)new string[1] { text }).ToArray();
					Resolve((PropertyMetadata)(object)val2, model, current.get_Value(), keys, val.Item2);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public void BindModel(ModelBindingContext bindingContext, object externalInputs)
	{
		Contract.ArgumentNotNull(bindingContext, "bindingContext");
		Contract.ArgumentNotNull(externalInputs, "externalInputs");
		ClassMetadata metadata = bindingContext.ModelMetadata.Metadata;
		object model = bindingContext.ModelMetadata.Model;
		System.Collections.Generic.IEnumerator<PropertyMetadata> enumerator = ((System.Collections.Generic.IEnumerable<PropertyMetadata>)metadata.get_Properties()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				PropertyMetadata current = enumerator.get_Current();
				ViewModelPropertyMetadata val = (ViewModelPropertyMetadata)(object)((current is ViewModelPropertyMetadata) ? current : null);
				if (val != null && val.get_Input())
				{
					object plainPropertyValue = externalInputs.GetPlainPropertyValue(((INamedMetadata)val).get_Name());
					if (plainPropertyValue != null)
					{
						Resolve((PropertyMetadata)(object)val, model, plainPropertyValue.ToString());
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private void Resolve(PropertyMetadata property, object model, string value, string[] keys = null, int? arrayIndex = null)
	{
		string name = ((INamedMetadata)property).get_Name();
		object plainPropertyValue = model.GetPlainPropertyValue(name);
		TypeSettings settings = ((IPropertyMetadata)property).get_Settings();
		if (settings != null)
		{
			DataClassSettings val;
			if ((val = (DataClassSettings)(object)((settings is DataClassSettings) ? settings : null)) != null)
			{
				DataClassSettings val2 = val;
				ProcessDto(property, plainPropertyValue, (RelationType)val2.get_RelationType(), model, value, keys, arrayIndex);
				return;
			}
			EntitySettings val3;
			if ((val3 = (EntitySettings)(object)((settings is EntitySettings) ? settings : null)) != null)
			{
				EntitySettings val4 = val3;
				ProcessDto(property, plainPropertyValue, (RelationType)val4.get_RelationType(), model, value, keys, arrayIndex);
				return;
			}
		}
		ConvertHelper.ReconcileProperty(name, model, value);
	}

	private void ProcessDto(PropertyMetadata property, object currentValue, RelationType relationType, object model, string value, string[] keys = null, int? arrayIndex = null)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		IMetadata metadata = metadataService.GetMetadata(((IPropertyMetadata)property).get_SubTypeUid());
		ClassMetadata val;
		if ((val = (ClassMetadata)(object)((metadata is ClassMetadata) ? metadata : null)) == null)
		{
			return;
		}
		string name = ((INamedMetadata)property).get_Name();
		if (currentValue == null)
		{
			if (relationType != 0)
			{
				ReactiveCollection<ReactiveProxy> reactiveCollection = new ReactiveCollection<ReactiveProxy>();
				ViewModelPropertyMetadata val2;
				if ((val2 = (ViewModelPropertyMetadata)(object)((property is ViewModelPropertyMetadata) ? property : null)) != null && val2.get_Input())
				{
					model.get_Item("$jsonObj").set_Item(name, ((object)reactiveCollection).get_Item("json"));
				}
				else
				{
					model.SetPlainPropertyValue(name, reactiveCollection);
				}
			}
			else
			{
				ReactiveProxy value2 = proxyGeneratorService.GenerateProxy(val);
				ViewModelPropertyMetadata val3;
				if ((val3 = (ViewModelPropertyMetadata)(object)((property is ViewModelPropertyMetadata) ? property : null)) != null && val3.get_Input())
				{
					ConvertHelper.ReconcileProperty(name, model, value2);
				}
				else
				{
					model.SetPlainPropertyValue(name, value2);
				}
			}
		}
		if (keys == null || keys.Length == 0)
		{
			return;
		}
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
		string key = keys[0];
		string[] keys2 = ((System.Array)keys).Slice(1) as string[];
		currentValue = model.GetPlainPropertyValue(name);
		if (arrayIndex.get_HasValue())
		{
			int value3 = arrayIndex.get_Value();
			ReactiveCollection<ReactiveProxy> reactiveCollection2 = ObjectExtensions.As<ReactiveCollection<ReactiveProxy>>(currentValue);
			if (value3 < reactiveCollection2.Count)
			{
				currentValue = reactiveCollection2[value3];
			}
			else
			{
				currentValue = proxyGeneratorService.GenerateProxy(val);
				reactiveCollection2.Insert(value3, currentValue);
			}
		}
		ValueTuple<string, int?> val4 = TryParseArrayKey(key);
		CS_0024_003C_003E8__locals0.propertyName = val4.Item1;
		int? item = val4.Item2;
		EntityMetadata metadata2;
		PropertyMetadata val5 = (((metadata2 = (EntityMetadata)(object)((val is EntityMetadata) ? val : null)) == null || !(CS_0024_003C_003E8__locals0.propertyName == "Id")) ? Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)val.get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata a) => ((INamedMetadata)a).get_Name() == CS_0024_003C_003E8__locals0.propertyName)) : metadata2.GetIdProperty(descriptorService).Item1);
		if (val5 != null)
		{
			Resolve(val5, currentValue, value, keys2, item);
		}
	}

	private static ValueTuple<string, int?> TryParseArrayKey(string key)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		int num = key.IndexOf('[');
		if (num == -1)
		{
			return new ValueTuple<string, int?>(key, (int?)null);
		}
		string text = key.Substring(0, num);
		int num2 = key.IndexOf(']');
		int num3 = default(int);
		int.TryParse(key.Substring(num + 1, key.get_Length() - num2), ref num3);
		return new ValueTuple<string, int?>(text, (int?)num3);
	}
}
