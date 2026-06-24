using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Core.Services;

[Service]
internal sealed class UserDefinedListService : IUserDefinedListService
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public GroupingProperty grouping;

		internal bool _003CGetMetadata_003Eb__0(PropertyMetadata p)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)p).get_Uid() == ((UserDefinedListPropertyBase)grouping).get_OriginalPropertyUid();
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_1
	{
		public AggregationProperty aggregation;

		internal bool _003CGetMetadata_003Eb__1(PropertyMetadata p)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)p).get_Uid() == ((UserDefinedListPropertyBase)aggregation).get_OriginalPropertyUid();
		}

		internal bool _003CGetMetadata_003Eb__2(IncludedProperty ip)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return ((UserDefinedListPropertyBase)ip).get_OriginalPropertyUid() == ((UserDefinedListPropertyBase)aggregation).get_OriginalPropertyUid();
		}
	}

	private const string IncludedPrefix = "Included";

	private const string GroupPrefix = "Group";

	private const string AggregationPrefix = "Aggregation";

	private readonly IMetadataServiceContext metadataServiceContext;

	public UserDefinedListService(IMetadataServiceContext metadataServiceContext)
	{
		this.metadataServiceContext = metadataServiceContext;
	}

	public ClassMetadata GetMetadata(ComponentMetadata componentMetadata, UserDefinedListInfo userDefinedListInfo)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		ClassMetadata val = InterfaceCreator.Create<ClassMetadata>();
		if (userDefinedListInfo == null)
		{
			return val;
		}
		IMetadata metadata = metadataServiceContext.GetMetadata(userDefinedListInfo.get_SubTypeUid());
		ClassMetadata val2 = (ClassMetadata)(object)((metadata is ClassMetadata) ? metadata : null);
		if (val2 == null)
		{
			return val;
		}
		List<PropertyMetadata> val3 = new List<PropertyMetadata>();
		DataClassMetadata dataClassMetadata;
		if ((dataClassMetadata = (DataClassMetadata)(object)((val2 is DataClassMetadata) ? val2 : null)) != null)
		{
			val3.AddRange(dataClassMetadata.GetPropertiesWithInclude(metadataServiceContext));
		}
		else
		{
			val3.AddRange((System.Collections.Generic.IEnumerable<PropertyMetadata>)val2.get_Properties());
		}
		System.Collections.Generic.IEnumerator<GroupingProperty> enumerator = ((System.Collections.Generic.IEnumerable<GroupingProperty>)userDefinedListInfo.get_GroupingProperties()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass5_0();
				CS_0024_003C_003E8__locals1.grouping = enumerator.get_Current();
				PropertyMetadata val4 = val3.Find((Predicate<PropertyMetadata>)((PropertyMetadata p) => ((IMetadata)p).get_Uid() == ((UserDefinedListPropertyBase)CS_0024_003C_003E8__locals1.grouping).get_OriginalPropertyUid()));
				if (val4 == null)
				{
					continue;
				}
				PropertyMetadata val5 = InterfaceCreator.Create<PropertyMetadata>();
				((IMetadata)val5).set_Uid(((UserDefinedListPropertyBase)CS_0024_003C_003E8__locals1.grouping).get_Uid());
				System.Collections.Generic.ICollection<int> datePartTypes = ((DatePartProperty)CS_0024_003C_003E8__locals1.grouping).get_DatePartTypes();
				if (datePartTypes.get_Count() < 3)
				{
					string text = "";
					string text2 = "";
					System.Collections.Generic.IEnumerator<int> enumerator2 = ((System.Collections.Generic.IEnumerable<int>)datePartTypes).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator2).MoveNext())
						{
							int current = enumerator2.get_Current();
							text = $"{text}.{(DatePartType)current}";
							text2 = text2 + "." + GetDatePartTypeName((DatePartType)current);
						}
					}
					finally
					{
						((System.IDisposable)enumerator2)?.Dispose();
					}
					((IPropertyMetadata)val5).set_TypeUid(StringDescriptor.UID);
					((IPropertyMetadata)val5).set_Settings((TypeSettings)(object)InterfaceCreator.Create<StringSettings>());
					((INamedMetadata)val5).set_Name(GetName("Group" + text, ((INamedMetadata)val4).get_Name()));
					((INamedMetadata)val5).set_DisplayName("Группировка свойства: " + ((INamedMetadata)val4).get_DisplayName() + text2);
				}
				else
				{
					((IPropertyMetadata)val5).set_TypeUid(((IPropertyMetadata)val4).get_TypeUid());
					((IPropertyMetadata)val5).set_SubTypeUid(((IPropertyMetadata)val4).get_SubTypeUid());
					((IPropertyMetadata)val5).set_Settings(((IPropertyMetadata)val4).get_Settings());
					((INamedMetadata)val5).set_Name(GetName("Group", ((INamedMetadata)val4).get_Name()));
					((INamedMetadata)val5).set_DisplayName("Группировка свойства: " + ((INamedMetadata)val4).get_DisplayName());
				}
				val.get_Properties().Add(val5);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		System.Collections.Generic.IEnumerator<AggregationProperty> enumerator3 = ((System.Collections.Generic.IEnumerable<AggregationProperty>)userDefinedListInfo.get_AggregationProperties()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator3).MoveNext())
			{
				_003C_003Ec__DisplayClass5_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_1();
				CS_0024_003C_003E8__locals0.aggregation = enumerator3.get_Current();
				IncludedProperty val6 = null;
				IPropertyMetadata val7 = (IPropertyMetadata)(object)val3.Find((Predicate<PropertyMetadata>)((PropertyMetadata p) => ((IMetadata)p).get_Uid() == ((UserDefinedListPropertyBase)CS_0024_003C_003E8__locals0.aggregation).get_OriginalPropertyUid()));
				if (val7 == null)
				{
					val6 = Enumerable.FirstOrDefault<IncludedProperty>((System.Collections.Generic.IEnumerable<IncludedProperty>)userDefinedListInfo.get_IncludedProperties(), (Func<IncludedProperty, bool>)((IncludedProperty ip) => ((UserDefinedListPropertyBase)ip).get_OriginalPropertyUid() == ((UserDefinedListPropertyBase)CS_0024_003C_003E8__locals0.aggregation).get_OriginalPropertyUid()));
					if (val6 == null)
					{
						continue;
					}
					val7 = MetadataHelper.GetProperty(metadataServiceContext, val2, ((UserDefinedListPropertyBase)val6).get_OriginalPropertyUid(), Enumerable.ToArray<Guid>((System.Collections.Generic.IEnumerable<Guid>)val6.get_PropertyParents()));
					if (val7 == null)
					{
						continue;
					}
				}
				string text3 = ((val6 != null) ? GetIncludedPropertyDisplayNameChain(val6, val3) : "");
				PropertyMetadata val8 = InterfaceCreator.Create<PropertyMetadata>();
				((IMetadata)val8).set_Uid(((UserDefinedListPropertyBase)CS_0024_003C_003E8__locals0.aggregation).get_Uid());
				((INamedMetadata)val8).set_Name(GetAggregationName("Aggregation" + GetIncludedPropertyNameChain(val6, val3), ((INamedMetadata)val7).get_Name(), (AggregationType)CS_0024_003C_003E8__locals0.aggregation.get_AggregationType()));
				((INamedMetadata)val8).set_DisplayName(string.Concat(new string[5]
				{
					"Агрегация '",
					GetAggregationTypeName((AggregationType)CS_0024_003C_003E8__locals0.aggregation.get_AggregationType()),
					"' свойства: ",
					text3,
					((INamedMetadata)val7).get_DisplayName()
				}));
				if (CS_0024_003C_003E8__locals0.aggregation.get_AggregationType() == 4)
				{
					((IPropertyMetadata)val8).set_TypeUid(Int32Descriptor.UID);
					((IPropertyMetadata)val8).set_Settings((TypeSettings)(object)InterfaceCreator.Create<Int32Settings>());
				}
				else
				{
					((IPropertyMetadata)val8).set_TypeUid(val7.get_TypeUid());
					((IPropertyMetadata)val8).set_SubTypeUid(val7.get_SubTypeUid());
					((IPropertyMetadata)val8).set_Settings(val7.get_Settings());
				}
				val.get_Properties().Add(val8);
			}
		}
		finally
		{
			((System.IDisposable)enumerator3)?.Dispose();
		}
		System.Collections.Generic.IEnumerator<IncludedProperty> enumerator4 = ((System.Collections.Generic.IEnumerable<IncludedProperty>)userDefinedListInfo.get_IncludedProperties()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator4).MoveNext())
			{
				IncludedProperty current2 = enumerator4.get_Current();
				IPropertyMetadata property = MetadataHelper.GetProperty(metadataServiceContext, (System.Collections.Generic.IEnumerable<IPropertyMetadata>)val3, ((UserDefinedListPropertyBase)current2).get_OriginalPropertyUid(), Enumerable.ToArray<Guid>((System.Collections.Generic.IEnumerable<Guid>)current2.get_PropertyParents()));
				Enumerable.ToArray<Guid>((System.Collections.Generic.IEnumerable<Guid>)current2.get_PropertyParents());
				string includedPropertyNameChain = GetIncludedPropertyNameChain(current2, val3);
				string includedPropertyDisplayNameChain = GetIncludedPropertyDisplayNameChain(current2, val3);
				if (property == null)
				{
					continue;
				}
				PropertyMetadata val9 = InterfaceCreator.Create<PropertyMetadata>();
				((IMetadata)val9).set_Uid(((IMetadata)property).get_Uid());
				System.Collections.Generic.ICollection<int> datePartTypes2 = ((DatePartProperty)current2).get_DatePartTypes();
				if (datePartTypes2.get_Count() < 3)
				{
					string text4 = "";
					string text5 = "";
					System.Collections.Generic.IEnumerator<int> enumerator2 = ((System.Collections.Generic.IEnumerable<int>)datePartTypes2).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator2).MoveNext())
						{
							int current3 = enumerator2.get_Current();
							text4 = $"{text4}.{(DatePartType)current3}";
							text5 = text5 + "." + GetDatePartTypeName((DatePartType)current3);
						}
					}
					finally
					{
						((System.IDisposable)enumerator2)?.Dispose();
					}
					((IPropertyMetadata)val9).set_TypeUid(StringDescriptor.UID);
					((IPropertyMetadata)val9).set_Settings((TypeSettings)(object)InterfaceCreator.Create<StringSettings>());
					((INamedMetadata)val9).set_Name(GetName("IncludedGroup" + includedPropertyNameChain + text4, ((INamedMetadata)property).get_Name()));
					((INamedMetadata)val9).set_DisplayName("Свойство: " + includedPropertyDisplayNameChain + ((INamedMetadata)property).get_DisplayName() + text5);
				}
				else
				{
					((IPropertyMetadata)val9).set_TypeUid(property.get_TypeUid());
					((IPropertyMetadata)val9).set_SubTypeUid(property.get_SubTypeUid());
					((IPropertyMetadata)val9).set_Settings(property.get_Settings());
					((INamedMetadata)val9).set_Name(GetName("IncludedGroup" + includedPropertyNameChain, ((INamedMetadata)property).get_Name()));
					((INamedMetadata)val9).set_DisplayName("Свойство: " + includedPropertyDisplayNameChain + ((INamedMetadata)property).get_DisplayName());
				}
				val.get_Properties().Add(val9);
			}
		}
		finally
		{
			((System.IDisposable)enumerator4)?.Dispose();
		}
		((IMetadata)(object)val).InitNew();
		return val;
	}

	private string GetIncludedPropertyDisplayNameChain(IncludedProperty includedProperty, List<PropertyMetadata> props)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		if (includedProperty == null)
		{
			return text;
		}
		if (MetadataHelper.GetProperty(metadataServiceContext, (System.Collections.Generic.IEnumerable<IPropertyMetadata>)props, ((UserDefinedListPropertyBase)includedProperty).get_OriginalPropertyUid(), Enumerable.ToArray<Guid>((System.Collections.Generic.IEnumerable<Guid>)includedProperty.get_PropertyParents())) == null)
		{
			return text;
		}
		Guid[] array = Enumerable.ToArray<Guid>((System.Collections.Generic.IEnumerable<Guid>)includedProperty.get_PropertyParents());
		for (object obj = ((System.Array)array).Pop(); obj != null; obj = ((System.Array)array).Pop())
		{
			text = ((INamedMetadata)MetadataHelper.GetProperty(metadataServiceContext, (System.Collections.Generic.IEnumerable<IPropertyMetadata>)props, (Guid)obj, array)).get_DisplayName() + " - " + text;
		}
		return text;
	}

	private string GetName(string prefix, string propertyName)
	{
		return prefix + "." + propertyName;
	}

	private string GetAggregationName(string prefix, string propertyName, AggregationType aggregationType)
	{
		string name = GetName(prefix, propertyName);
		return $"{name}{aggregationType}";
	}

	private string GetIncludedPropertyNameChain(IncludedProperty includedProperty, List<PropertyMetadata> props)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		if (includedProperty == null)
		{
			return text;
		}
		if (MetadataHelper.GetProperty(metadataServiceContext, (System.Collections.Generic.IEnumerable<IPropertyMetadata>)props, ((UserDefinedListPropertyBase)includedProperty).get_OriginalPropertyUid(), Enumerable.ToArray<Guid>((System.Collections.Generic.IEnumerable<Guid>)includedProperty.get_PropertyParents())) == null)
		{
			return text;
		}
		Guid[] array = Enumerable.ToArray<Guid>((System.Collections.Generic.IEnumerable<Guid>)includedProperty.get_PropertyParents());
		for (object obj = ((System.Array)array).Pop(); obj != null; obj = ((System.Array)array).Pop())
		{
			text = ((INamedMetadata)MetadataHelper.GetProperty(metadataServiceContext, (System.Collections.Generic.IEnumerable<IPropertyMetadata>)props, (Guid)obj, array)).get_Name() + text;
		}
		return text;
	}

	private string GetAggregationTypeName(AggregationType aggregation)
	{
		return aggregation switch
		{
			AggregationType.Avg => SR.T("Среднее"), 
			AggregationType.Max => SR.T("Максимум"), 
			AggregationType.Min => SR.T("Минимум"), 
			AggregationType.Sum => SR.T("Сумма"), 
			AggregationType.Count => SR.T("Счетчик"), 
			_ => "", 
		};
	}

	private string GetDatePartTypeName(DatePartType datePartType)
	{
		return datePartType switch
		{
			DatePartType.Day => SR.T("День"), 
			DatePartType.Month => SR.T("Месяц"), 
			DatePartType.Year => SR.T("Год"), 
			_ => "", 
		};
	}
}
