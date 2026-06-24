using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Scripts.Services;

[Service]
internal class EqlPropertiesService : IEqlPropertiesService
{
	private readonly IMetadataRuntimeService metadataRuntimeService;

	private static EqlPropertiesService CkI37AUu2xf1R04879R;

	public EqlPropertiesService(IMetadataRuntimeService metadataRuntimeService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		eDChmjUSfRtyE1G54Q3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.metadataRuntimeService = metadataRuntimeService;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
			{
				num = 1;
			}
		}
	}

	public void SetEqlComputedProperties(object source, Type sourceType, IEnumerable<PropertyMetadata> properties, List<SerializedModel> additionalModels)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0.sourceType = sourceType;
		CS_0024_003C_003E8__locals0.source = source;
		SetEqlComputedProperties(properties, GetPropertyValue, SetPropertyValue, additionalModels);
		object GetPropertyValue(PropertyMetadata property)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				case 1:
				{
					PropertyInfo reflectionProperty = CS_0024_003C_003E8__locals0.sourceType.GetReflectionProperty((string)_003C_003Ec__DisplayClass3_0.oCJ6wxfUh2fHU5HJQe5v(property));
					if ((object)reflectionProperty != null)
					{
						return _003C_003Ec__DisplayClass3_0.uPVFOLfUGuEGg3VuDPN7(reflectionProperty, CS_0024_003C_003E8__locals0.source, null);
					}
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num4 = 0;
					}
					break;
				}
				default:
					return null;
				}
			}
		}
		void SetPropertyValue(PropertyMetadata property, object value)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
				{
					object obj = _003C_003Ec__DisplayClass3_0.H6LfgffUEs8EIk353D9D(CS_0024_003C_003E8__locals0.sourceType, _003C_003Ec__DisplayClass3_0.oCJ6wxfUh2fHU5HJQe5v(property));
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						((PropertyInfo)obj).SetValue(CS_0024_003C_003E8__locals0.source, value, (object[])null);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 2;
						}
					}
					break;
				}
				case 2:
					return;
				case 0:
					return;
				}
			}
		}
	}

	public void SetEqlComputedProperties(DataClass source, DataClassMetadata viewModelMetadata, List<SerializedModel> additionalModels)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0.source = source;
		CS_0024_003C_003E8__locals0.viewModelMetadata = viewModelMetadata;
		SetEqlComputedProperties(CS_0024_003C_003E8__locals0.viewModelMetadata.Properties, GetPropertyValue, SetPropertyValue, additionalModels);
		object GetPropertyValue(PropertyMetadata property)
		{
			return _003C_003Ec__DisplayClass4_0.MeCrHHfU8yBZ1NuNROX1(CS_0024_003C_003E8__locals0.source, _003C_003Ec__DisplayClass4_0.o1EvKhfUvoqCQAlHucgw(CS_0024_003C_003E8__locals0.viewModelMetadata), _003C_003Ec__DisplayClass4_0.o1EvKhfUvoqCQAlHucgw(property));
		}
		void SetPropertyValue(PropertyMetadata property, object value)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003C_003Ec__DisplayClass4_0.qF7LpwfUZ9DNUGJrFBHC(CS_0024_003C_003E8__locals0.source, CS_0024_003C_003E8__locals0.viewModelMetadata.Uid, property.Uid, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	private void SetEqlComputedProperties(IEnumerable<PropertyMetadata> properties, Func<PropertyMetadata, object> getPropertyValue, Action<PropertyMetadata, object> setPropertyValue, List<SerializedModel> additionalModels)
	{
		SerializedModel serializedModel = additionalModels.Find((SerializedModel model) => _003C_003Ec.ixtKQcfUnKv6FPIe8Pq9(_003C_003Ec.ADpykxfUTgMjkJCMbXkF(model), _003C_003Ec.pOlviIfUk7SFYi5K44VK(-2138160520 ^ -2138362896)));
		if (serializedModel == null)
		{
			return;
		}
		SerializedModel[] array = new JsonSerializer().Deserialize<SerializedModel[]>(serializedModel.Model);
		if (array.Length == 0)
		{
			return;
		}
		foreach (PropertyMetadata property in properties)
		{
			if (!(property.Settings is EntitySettings entitySettings) || !entitySettings.IsComputedEqlValue)
			{
				continue;
			}
			_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
			CS_0024_003C_003E8__locals0.propertyUid = property.Uid.ToString();
			SerializedModel serializedModel2 = array.FirstOrDefault((SerializedModel m) => _003C_003Ec__DisplayClass5_0.BW2bemfUihTmKVPACHZl(m.Name, CS_0024_003C_003E8__locals0.propertyUid));
			if (serializedModel2 == null)
			{
				continue;
			}
			Type typeByUid = metadataRuntimeService.GetTypeByUid(property.SubTypeUid);
			bool num = entitySettings.RelationType == RelationType.OneToOne;
			int limit = (num ? 1 : 0);
			IEnumerable<IEntity> enumerable = EntityQueryHelper.QueryAllEntitiesWithFilter(typeByUid, serializedModel2.Model, null, limit, 0);
			if (num)
			{
				setPropertyValue(property, enumerable.FirstOrDefault());
				continue;
			}
			UntypedISetProxy untypedISetProxy = getPropertyValue(property).AsUntypedISet();
			if (untypedISetProxy == null)
			{
				continue;
			}
			untypedISetProxy.Clear();
			foreach (IEntity item in enumerable)
			{
				untypedISetProxy.Add(item);
			}
		}
	}

	internal static void eDChmjUSfRtyE1G54Q3()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool tE35UaUI2fORiuWclIk()
	{
		return CkI37AUu2xf1R04879R == null;
	}

	internal static EqlPropertiesService VOnZVPUVtRhqrj9FCv7()
	{
		return CkI37AUu2xf1R04879R;
	}
}
