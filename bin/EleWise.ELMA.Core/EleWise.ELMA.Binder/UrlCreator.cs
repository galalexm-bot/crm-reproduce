using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Binder;

[Service]
internal sealed class UrlCreator
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ViewModelPropertyMetadata, bool> _003C_003E9__2_0;

		internal bool _003CCreateUrlParametersByModel_003Eb__2_0(ViewModelPropertyMetadata a)
		{
			return a.get_Input();
		}
	}

	private readonly IMetadataServiceContext metadataService;

	public UrlCreator(IMetadataServiceContext metadataService)
	{
		this.metadataService = metadataService;
	}

	public string CreateUrlParametersByModel(object model, ClassMetadata metadata)
	{
		if (model == null || metadata == null)
		{
			return "";
		}
		EnumerableInstance<ViewModelPropertyMetadata> properties = Enumerable.OfType<ViewModelPropertyMetadata>((System.Collections.IEnumerable)metadata.get_Properties()).Where((Func<ViewModelPropertyMetadata, bool>)((ViewModelPropertyMetadata a) => a.get_Input()));
		string url = "";
		ProcessProperties(ref url, (System.Collections.Generic.IEnumerable<PropertyMetadata>)properties, model);
		if (!url.IsNullOrWhiteSpace())
		{
			url = url.Insert(0, "?").Remove(url.get_Length());
		}
		return url;
	}

	private void ProcessProperties(ref string url, System.Collections.Generic.IEnumerable<PropertyMetadata> properties, object model, string prefix = null)
	{
		System.Collections.Generic.IEnumerator<PropertyMetadata> enumerator = properties.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				PropertyMetadata current = enumerator.get_Current();
				string name = ((INamedMetadata)current).get_Name();
				object plainPropertyValue = model.GetPlainPropertyValue(name);
				if (plainPropertyValue == null)
				{
					continue;
				}
				TypeSettings settings = ((IPropertyMetadata)current).get_Settings();
				if (settings != null)
				{
					DataClassSettings val;
					if ((val = (DataClassSettings)(object)((settings is DataClassSettings) ? settings : null)) != null)
					{
						DataClassSettings val2 = val;
						ProcessObject(ref url, current, plainPropertyValue, (RelationType)val2.get_RelationType(), prefix);
						continue;
					}
					EntitySettings val3;
					if ((val3 = (EntitySettings)(object)((settings is EntitySettings) ? settings : null)) != null)
					{
						EntitySettings val4 = val3;
						ProcessObject(ref url, current, plainPropertyValue, (RelationType)val4.get_RelationType(), prefix);
						continue;
					}
				}
				string stringPropertyValue = ConvertHelper.GetStringPropertyValue(name, model);
				if (!stringPropertyValue.IsNullOrWhiteSpace())
				{
					url = string.Concat(new string[6] { url, prefix, name, "=", stringPropertyValue, "&" });
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private void ProcessObject(ref string url, PropertyMetadata property, object value, RelationType relationType, string rootPrefix)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		IMetadata metadata = metadataService.GetMetadata(((IPropertyMetadata)property).get_SubTypeUid());
		ClassMetadata val;
		if ((val = (ClassMetadata)(object)((metadata is ClassMetadata) ? metadata : null)) == null)
		{
			return;
		}
		string text = rootPrefix + ((INamedMetadata)property).get_Name();
		if (relationType != 0)
		{
			if (!(value is System.Collections.IEnumerable enumerable))
			{
				return;
			}
			int num = 0;
			{
				System.Collections.IEnumerator enumerator = enumerable.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object current = enumerator.get_Current();
						ProcessProperties(ref url, (System.Collections.Generic.IEnumerable<PropertyMetadata>)val.get_Properties(), current, $"{text}[{num}].");
						num++;
					}
					return;
				}
				finally
				{
					System.IDisposable disposable = enumerator as System.IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
		ProcessProperties(ref url, (System.Collections.Generic.IEnumerable<PropertyMetadata>)val.get_Properties(), value, text + ".");
	}
}
