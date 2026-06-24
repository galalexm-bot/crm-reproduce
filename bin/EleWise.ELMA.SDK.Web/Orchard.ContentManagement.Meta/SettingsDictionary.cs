using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;

namespace Orchard.ContentManagement.MetaData.Models;

public class SettingsDictionary : Dictionary<string, string>
{
	public SettingsDictionary()
	{
	}

	public SettingsDictionary(IDictionary<string, string> dictionary)
		: base(dictionary)
	{
	}

	public T TryGetModel<T>(string key) where T : class
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		DefaultModelBinder val = new DefaultModelBinder();
		ControllerContext val2 = new ControllerContext();
		ModelBindingContext val3 = new ModelBindingContext();
		val3.set_ModelMetadata(ModelMetadataProviders.get_Current().GetMetadataForType((Func<object>)null, typeof(T)));
		val3.set_ModelName(key);
		val3.set_ValueProvider((IValueProvider)(object)new DictionaryValueProvider<string>((IDictionary<string, string>)this, (CultureInfo)null));
		ModelBindingContext val4 = val3;
		return (T)val.BindModel(val2, val4);
	}

	public T TryGetModel<T>() where T : class
	{
		return TryGetModel<T>(typeof(T).Name);
	}

	public T GetModel<T>() where T : class, new()
	{
		return GetModel<T>(typeof(T).Name);
	}

	public T GetModel<T>(string key) where T : class, new()
	{
		return TryGetModel<T>(key) ?? new T();
	}
}
