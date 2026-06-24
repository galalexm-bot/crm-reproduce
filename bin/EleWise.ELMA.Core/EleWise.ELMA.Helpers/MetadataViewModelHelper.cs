using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Helpers;

public static class MetadataViewModelHelper
{
	[Serializable]
	private sealed class _003C_003Ec__0<T>
	{
		public static readonly _003C_003Ec__0<T> _003C_003E9 = new _003C_003Ec__0<T>();

		public static Func<T> _003C_003E9__0_0;

		public static Func<T> _003C_003E9__0_1;

		internal T _003CGetPropertyContext_003Eb__0_0()
		{
			return default(T);
		}

		internal T _003CGetPropertyContext_003Eb__0_1()
		{
			return default(T);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec__1<T>
	{
		public static readonly _003C_003Ec__1<T> _003C_003E9 = new _003C_003Ec__1<T>();

		public static Func<T> _003C_003E9__1_0;

		internal T _003CGetFuncValue_003Eb__1_0()
		{
			return default(T);
		}
	}

	private sealed class _003C_003Ec__DisplayClass2_0<T>
	{
		public ModelMetadata parentModelMetadata;
	}

	private sealed class _003C_003Ec__DisplayClass2_1<T>
	{
		public PropertyInfoExpression expression;

		public _003C_003Ec__DisplayClass2_0<T> CS_0024_003C_003E8__locals1;

		internal T _003CCaseZeroPropertyParents_003Eb__1()
		{
			return (T)GetModelFunc(CS_0024_003C_003E8__locals1.parentModelMetadata.Model, expression);
		}
	}

	private sealed class _003C_003Ec__DisplayClass2_2<T>
	{
		public PropertyInfoExpression parentPropertyExpression;

		public PropertyInfoExpression propertyExpression;

		public _003C_003Ec__DisplayClass2_0<T> CS_0024_003C_003E8__locals2;

		internal T _003CCaseZeroPropertyParents_003Eb__2()
		{
			return (T)GetModelFunc(GetModelFunc(CS_0024_003C_003E8__locals2.parentModelMetadata.Model, parentPropertyExpression), propertyExpression);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec__2<T>
	{
		public static readonly _003C_003Ec__2<T> _003C_003E9 = new _003C_003Ec__2<T>();

		public static Func<T> _003C_003E9__2_0;

		internal T _003CCaseZeroPropertyParents_003Eb__2_0()
		{
			return default(T);
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_0<T>
	{
		public Guid parentPropertyUid;

		public ModelMetadata parentModelMetadata;

		internal bool _003CCaseOnePropertyParents_003Eb__0(PropertyMetadata property)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)property).get_Uid() == parentPropertyUid;
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_1<T>
	{
		public PropertyInfoExpression parentPropertyExpression;

		public PropertyInfoExpression propertyExpression;

		public _003C_003Ec__DisplayClass3_0<T> CS_0024_003C_003E8__locals1;

		internal T _003CCaseOnePropertyParents_003Eb__3()
		{
			return (T)GetModelFunc(GetModelFunc(CS_0024_003C_003E8__locals1.parentModelMetadata.Model, parentPropertyExpression), propertyExpression);
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_2<T>
	{
		public PropertyInfoExpression parentPropertyExpression;

		public PropertyInfoExpression propertyExpression;

		public _003C_003Ec__DisplayClass3_0<T> CS_0024_003C_003E8__locals2;

		internal T _003CCaseOnePropertyParents_003Eb__4()
		{
			return (T)GetModelFunc(GetModelFunc(CS_0024_003C_003E8__locals2.parentModelMetadata.Model, parentPropertyExpression), propertyExpression);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec__3<T>
	{
		public static readonly _003C_003Ec__3<T> _003C_003E9 = new _003C_003Ec__3<T>();

		public static Func<T> _003C_003E9__3_2;

		public static Func<T> _003C_003E9__3_1;

		internal T _003CCaseOnePropertyParents_003Eb__3_2()
		{
			return default(T);
		}

		internal T _003CCaseOnePropertyParents_003Eb__3_1()
		{
			return default(T);
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_0<T>
	{
		public Func<object>[] funcs;

		public PropertyInfoExpression propertyExpression;

		internal T _003CCaseDefaultPropertyParents_003Eb__0()
		{
			object target = null;
			for (int i = 0; i < funcs.Length; i++)
			{
				target = funcs[i].Invoke();
			}
			return ObjectExtensions.As<T>(GetModelFunc(target, propertyExpression));
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_1<T>
	{
		public Guid parentUid;

		public Func<PropertyMetadata, bool> _003C_003E9__5;

		internal bool _003CCaseDefaultPropertyParents_003Eb__1(PropertyMetadata property)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)property).get_Uid() == parentUid;
		}

		internal bool _003CCaseDefaultPropertyParents_003Eb__5(PropertyMetadata property)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)property).get_Uid() == parentUid;
		}

		internal bool _003CCaseDefaultPropertyParents_003Eb__3(DataClassDependency include)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((Dependency)include).get_HeaderUid() == parentUid;
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_2<T>
	{
		public Func<object> tempTargetModelFunc;

		public PropertyInfoExpression parentPropertyExpression;

		internal object _003CCaseDefaultPropertyParents_003Eb__7()
		{
			return GetModelFunc(tempTargetModelFunc.Invoke(), parentPropertyExpression);
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_3<T>
	{
		public Func<object> tempTargetModelFunc;

		public PropertyInfoExpression includePropertyExpression;

		internal object _003CCaseDefaultPropertyParents_003Eb__9()
		{
			return GetModelFunc(tempTargetModelFunc.Invoke(), includePropertyExpression);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec__4<T>
	{
		public static readonly _003C_003Ec__4<T> _003C_003E9 = new _003C_003Ec__4<T>();

		public static Func<T> _003C_003E9__4_6;

		public static Func<T> _003C_003E9__4_2;

		public static Func<T> _003C_003E9__4_8;

		public static Func<T> _003C_003E9__4_4;

		internal T _003CCaseDefaultPropertyParents_003Eb__4_6()
		{
			return default(T);
		}

		internal T _003CCaseDefaultPropertyParents_003Eb__4_2()
		{
			return default(T);
		}

		internal T _003CCaseDefaultPropertyParents_003Eb__4_8()
		{
			return default(T);
		}

		internal T _003CCaseDefaultPropertyParents_003Eb__4_4()
		{
			return default(T);
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public Guid parentPropertyUid;

		internal bool _003CCaseOnePropertyParents_003Eb__0(PropertyMetadata property)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)property).get_Uid() == parentPropertyUid;
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public Guid parentUid;

		public Func<PropertyMetadata, bool> _003C_003E9__2;

		internal bool _003CCaseDefaultPropertyParents_003Eb__0(PropertyMetadata property)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)property).get_Uid() == parentUid;
		}

		internal bool _003CCaseDefaultPropertyParents_003Eb__2(PropertyMetadata property)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)property).get_Uid() == parentUid;
		}

		internal bool _003CCaseDefaultPropertyParents_003Eb__1(DataClassDependency include)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((Dependency)include).get_HeaderUid() == parentUid;
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_1
	{
		public Func<object> tempTargetModelFunc;

		public PropertyInfoExpression parentPropertyExpression;

		internal object _003CCaseDefaultPropertyParents_003Eb__3()
		{
			return GetModelFunc(tempTargetModelFunc.Invoke(), parentPropertyExpression);
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_2
	{
		public Func<object> tempTargetModelFunc;

		public PropertyInfoExpression includePropertyExpression;

		internal object _003CCaseDefaultPropertyParents_003Eb__4()
		{
			return GetModelFunc(tempTargetModelFunc.Invoke(), includePropertyExpression);
		}
	}

	public static Func<T> GetPropertyContext<T>(this IMetadataViewModel viewModel, IMetadataServiceContext metadataServiceContext, Guid propertyUid, Guid[] propertyParents)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (viewModel.IsDesignModeDeep)
		{
			return () => default(T);
		}
		if (viewModel.UIViewModel == null)
		{
			return () => default(T);
		}
		return GetFuncValue<T>(metadataServiceContext, viewModel.ModelMetadata, propertyUid, propertyParents);
	}

	private static Func<T> GetFuncValue<T>(IMetadataServiceContext metadataServiceContext, ModelMetadata parentModelMetadata, Guid propertyUid, Guid[] propertyParents)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (parentModelMetadata.Metadata == null)
		{
			return () => default(T);
		}
		return (Func<T>)(propertyParents.Length switch
		{
			0 => CaseZeroPropertyParents<T>(metadataServiceContext, parentModelMetadata, propertyUid), 
			1 => CaseOnePropertyParents<T>(metadataServiceContext, parentModelMetadata, propertyUid, propertyParents), 
			_ => CaseDefaultPropertyParents<T>(metadataServiceContext, parentModelMetadata, propertyUid, propertyParents), 
		});
	}

	private static Func<T> CaseZeroPropertyParents<T>(IMetadataServiceContext metadataServiceContext, ModelMetadata parentModelMetadata, Guid propertyUid)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass2_0<T> _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0<T>();
		_003C_003Ec__DisplayClass2_.parentModelMetadata = parentModelMetadata;
		ClassMetadata metadata = _003C_003Ec__DisplayClass2_.parentModelMetadata.Metadata;
		IPropertyMetadata property = MetadataHelper.GetProperty(metadataServiceContext, (System.Collections.Generic.IEnumerable<IPropertyMetadata>)((IMetadata)(object)metadata).GetProperties(), propertyUid, (Guid[])(object)new Guid[0]);
		if (property != null)
		{
			return new _003C_003Ec__DisplayClass2_1<T>
			{
				CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass2_,
				expression = metadataServiceContext.GetPropertyExpression(property, metadata)
			}._003CCaseZeroPropertyParents_003Eb__1;
		}
		DataClassMetadata val;
		if ((val = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null)) != null && ((INamedMetadata)val).get_Name() == "ViewModelContext")
		{
			ValueTuple<DataClassMetadata, PropertyMetadata, ClassMetadata> infoInCaseViewModelContext = MetadataHelper.GetInfoInCaseViewModelContext(metadataServiceContext, val, propertyUid);
			DataClassMetadata item = infoInCaseViewModelContext.Item1;
			PropertyMetadata item2 = infoInCaseViewModelContext.Item2;
			ClassMetadata item3 = infoInCaseViewModelContext.Item3;
			if (item != null && item2 != null && item3 != null)
			{
				_003C_003Ec__DisplayClass2_2<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_2<T>();
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass2_;
				System.Collections.Generic.IEnumerable<PropertyMetadata> properties = ((IMetadata)(object)metadata).GetProperties();
				CS_0024_003C_003E8__locals0.parentPropertyExpression = metadataServiceContext.GetPropertyExpression((IPropertyMetadata)(object)item2, (ClassMetadata)(object)item);
				ValueTuple<IPropertyMetadata, ClassMetadata> propertyWithOwner = MetadataHelper.GetPropertyWithOwner(metadataServiceContext, (System.Collections.Generic.IEnumerable<IPropertyMetadata>)properties, propertyUid, (Guid[])(object)new Guid[0]);
				IPropertyMetadata item4 = propertyWithOwner.Item1;
				ClassMetadata item5 = propertyWithOwner.Item2;
				CS_0024_003C_003E8__locals0.propertyExpression = metadataServiceContext.GetPropertyExpression(item4, item5);
				return () => (T)GetModelFunc(GetModelFunc(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.parentModelMetadata.Model, CS_0024_003C_003E8__locals0.parentPropertyExpression), CS_0024_003C_003E8__locals0.propertyExpression);
			}
		}
		EntityMetadata val2;
		if ((val2 = (EntityMetadata)(object)((metadata is EntityMetadata) ? metadata : null)) != null && val2.get_ViewModelMetadata() == null)
		{
			DataClassMetadata viewModelMetadata = metadataServiceContext.GetViewModelMetadata(val2);
			if (viewModelMetadata != null)
			{
				ModelMetadata parentModelMetadata2 = new ModelMetadata(_003C_003Ec__DisplayClass2_.parentModelMetadata, (ClassMetadata)(object)viewModelMetadata, _003C_003Ec__DisplayClass2_.parentModelMetadata.GetModelFunc);
				return CaseZeroPropertyParents<T>(metadataServiceContext, parentModelMetadata2, propertyUid);
			}
		}
		return () => default(T);
	}

	private static Func<T> CaseOnePropertyParents<T>(IMetadataServiceContext metadataService, ModelMetadata parentModelMetadata, Guid propertyUid, Guid[] propertyParents)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass3_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0<T>();
		CS_0024_003C_003E8__locals0.parentModelMetadata = parentModelMetadata;
		ClassMetadata metadata = CS_0024_003C_003E8__locals0.parentModelMetadata.Metadata;
		CS_0024_003C_003E8__locals0.parentPropertyUid = propertyParents[0];
		PropertyMetadata[] array = Enumerable.ToArray<PropertyMetadata>(((IMetadata)(object)metadata).GetProperties());
		PropertyMetadata val = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)array, (Func<PropertyMetadata, bool>)((PropertyMetadata property) => ((IMetadata)property).get_Uid() == CS_0024_003C_003E8__locals0.parentPropertyUid));
		if (val != null)
		{
			_003C_003Ec__DisplayClass3_1<T> CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass3_1<T>();
			CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
			if (!(metadataService.GetMetadata(((IPropertyMetadata)val).get_SubTypeUid()) is ClassMetadata))
			{
				return () => default(T);
			}
			CS_0024_003C_003E8__locals1.parentPropertyExpression = metadataService.GetPropertyExpression((IPropertyMetadata)(object)val, metadata);
			ValueTuple<IPropertyMetadata, ClassMetadata> propertyWithOwner = MetadataHelper.GetPropertyWithOwner(metadataService, (System.Collections.Generic.IEnumerable<IPropertyMetadata>)(object)array, propertyUid, propertyParents);
			IPropertyMetadata item = propertyWithOwner.Item1;
			ClassMetadata item2 = propertyWithOwner.Item2;
			CS_0024_003C_003E8__locals1.propertyExpression = metadataService.GetPropertyExpression(item, item2);
			return () => (T)GetModelFunc(GetModelFunc(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.parentModelMetadata.Model, CS_0024_003C_003E8__locals1.parentPropertyExpression), CS_0024_003C_003E8__locals1.propertyExpression);
		}
		DataClassMetadata val2;
		if ((val2 = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null)) != null && ((INamedMetadata)val2).get_Name() == "ViewModelContext")
		{
			ValueTuple<DataClassMetadata, PropertyMetadata, ClassMetadata> infoInCaseViewModelContext = MetadataHelper.GetInfoInCaseViewModelContext(metadataService, val2, CS_0024_003C_003E8__locals0.parentPropertyUid);
			DataClassMetadata item3 = infoInCaseViewModelContext.Item1;
			PropertyMetadata item4 = infoInCaseViewModelContext.Item2;
			ClassMetadata item5 = infoInCaseViewModelContext.Item3;
			if (item3 != null && item4 != null && item5 != null)
			{
				_003C_003Ec__DisplayClass3_2<T> obj = new _003C_003Ec__DisplayClass3_2<T>
				{
					CS_0024_003C_003E8__locals2 = CS_0024_003C_003E8__locals0,
					parentPropertyExpression = metadataService.GetPropertyExpression((IPropertyMetadata)(object)item4, (ClassMetadata)(object)item3)
				};
				ValueTuple<IPropertyMetadata, ClassMetadata> propertyWithOwner2 = MetadataHelper.GetPropertyWithOwner(metadataService, (System.Collections.Generic.IEnumerable<IPropertyMetadata>)(object)array, propertyUid, propertyParents);
				IPropertyMetadata item6 = propertyWithOwner2.Item1;
				ClassMetadata item7 = propertyWithOwner2.Item2;
				obj.propertyExpression = metadataService.GetPropertyExpression(item6, item7);
				return () => (T)GetModelFunc(GetModelFunc(obj.CS_0024_003C_003E8__locals2.parentModelMetadata.Model, obj.parentPropertyExpression), obj.propertyExpression);
			}
		}
		EntityMetadata val3;
		if ((val3 = (EntityMetadata)(object)((metadata is EntityMetadata) ? metadata : null)) != null && val3.get_ViewModelMetadata() == null)
		{
			DataClassMetadata viewModelMetadata = metadataService.GetViewModelMetadata(val3);
			if (viewModelMetadata != null)
			{
				ModelMetadata parentModelMetadata2 = new ModelMetadata(CS_0024_003C_003E8__locals0.parentModelMetadata, (ClassMetadata)(object)viewModelMetadata, CS_0024_003C_003E8__locals0.parentModelMetadata.GetModelFunc);
				return CaseOnePropertyParents<T>(metadataService, parentModelMetadata2, propertyUid, propertyParents);
			}
		}
		return () => default(T);
	}

	private static Func<T> CaseDefaultPropertyParents<T>(IMetadataServiceContext metadataService, ModelMetadata parentModelMetadata, Guid propertyUid, Guid[] propertyParents)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass4_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0<T>();
		CS_0024_003C_003E8__locals0.funcs = new Func<object>[0];
		ClassMetadata val = parentModelMetadata.Metadata;
		Func<object> val2 = parentModelMetadata.GetModelFunc;
		ModelMetadata parent = parentModelMetadata;
		ArrayExtensions.Push<Func<object>>(CS_0024_003C_003E8__locals0.funcs, new Func<object>[1] { val2 });
		for (int i = 0; i < propertyParents.Length; i++)
		{
			_003C_003Ec__DisplayClass4_1<T> CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass4_1<T>();
			CS_0024_003C_003E8__locals2.parentUid = propertyParents[i];
			PropertyMetadata val3 = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)val.get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata property) => ((IMetadata)property).get_Uid() == CS_0024_003C_003E8__locals2.parentUid));
			EntityMetadata val4;
			if (val3 == null && (val4 = (EntityMetadata)(object)((val is EntityMetadata) ? val : null)) != null && val4.get_Type() == 2)
			{
				IMetadata metadata = metadataService.GetMetadata(((ClassMetadata)val4).get_BaseClassUid());
				ClassMetadata val5 = (ClassMetadata)(object)((metadata is ClassMetadata) ? metadata : null);
				if (val5 != null)
				{
					val = val5;
					do
					{
						val3 = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)val.get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata property) => ((IMetadata)property).get_Uid() == CS_0024_003C_003E8__locals2.parentUid));
						if (val3 != null || val.get_BaseClassUid() == Guid.Empty)
						{
							break;
						}
						IMetadata metadata2 = metadataService.GetMetadata(val.get_BaseClassUid());
						val = (ClassMetadata)(object)((metadata2 is ClassMetadata) ? metadata2 : null);
					}
					while (val != null);
				}
			}
			if (val3 != null)
			{
				_003C_003Ec__DisplayClass4_2<T> CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass4_2<T>();
				IMetadata metadata3 = metadataService.GetMetadata(((IPropertyMetadata)val3).get_SubTypeUid());
				ClassMetadata val6 = (ClassMetadata)(object)((metadata3 is ClassMetadata) ? metadata3 : null);
				if (val6 == null)
				{
					return () => default(T);
				}
				CS_0024_003C_003E8__locals1.parentPropertyExpression = metadataService.GetPropertyExpression((IPropertyMetadata)(object)val3, val);
				CS_0024_003C_003E8__locals1.tempTargetModelFunc = val2;
				val2 = () => GetModelFunc(CS_0024_003C_003E8__locals1.tempTargetModelFunc.Invoke(), CS_0024_003C_003E8__locals1.parentPropertyExpression);
				val = val6;
				parent = new ModelMetadata(parent, val, val2);
				ArrayExtensions.Push<Func<object>>(CS_0024_003C_003E8__locals0.funcs, new Func<object>[1] { val2 });
				continue;
			}
			EntityMetadata val7;
			if ((val7 = (EntityMetadata)(object)((val is EntityMetadata) ? val : null)) != null && val7.get_ViewModelMetadata() == null)
			{
				DataClassMetadata viewModelMetadata = metadataService.GetViewModelMetadata(val7);
				if (viewModelMetadata != null)
				{
					ModelMetadata parentModelMetadata2 = new ModelMetadata(parentModelMetadata, (ClassMetadata)(object)viewModelMetadata, parentModelMetadata.GetModelFunc);
					return CaseDefaultPropertyParents<T>(metadataService, parentModelMetadata2, propertyUid, propertyParents);
				}
			}
			DataClassMetadata val8 = (DataClassMetadata)(object)((val is DataClassMetadata) ? val : null);
			if (val8 == null || val8.get_IncludeList().get_Count() == 0)
			{
				return () => default(T);
			}
			DataClassDependency val9 = Enumerable.FirstOrDefault<DataClassDependency>((System.Collections.Generic.IEnumerable<DataClassDependency>)val8.get_IncludeList(), (Func<DataClassDependency, bool>)((DataClassDependency include) => ((Dependency)include).get_HeaderUid() == CS_0024_003C_003E8__locals2.parentUid));
			if (val9 == null)
			{
				if (i == 0 && ((INamedMetadata)val8).get_Name() == "ViewModelContext")
				{
					ValueTuple<DataClassMetadata, PropertyMetadata, ClassMetadata> infoInCaseViewModelContext = MetadataHelper.GetInfoInCaseViewModelContext(metadataService, val8, CS_0024_003C_003E8__locals2.parentUid);
					DataClassMetadata item = infoInCaseViewModelContext.Item1;
					PropertyMetadata item2 = infoInCaseViewModelContext.Item2;
					ClassMetadata item3 = infoInCaseViewModelContext.Item3;
					if (item != null && item2 != null && item3 != null)
					{
						val2 = new _003C_003Ec__DisplayClass4_3<T>
						{
							includePropertyExpression = metadataService.GetPropertyExpression((IPropertyMetadata)(object)item2, (ClassMetadata)(object)item),
							tempTargetModelFunc = val2
						}._003CCaseDefaultPropertyParents_003Eb__9;
						val = item3;
						parent = new ModelMetadata(parent, val, val2);
						ArrayExtensions.Push<Func<object>>(CS_0024_003C_003E8__locals0.funcs, new Func<object>[1] { val2 });
						continue;
					}
				}
				return () => default(T);
			}
			IMetadata metadata4 = metadataService.GetMetadata(((Dependency)val9).get_HeaderUid());
			ClassMetadata val10 = (ClassMetadata)(object)((metadata4 is ClassMetadata) ? metadata4 : null);
			if (val10 == null)
			{
				return () => default(T);
			}
			val = val10;
			parent = new ModelMetadata(parent, val, val2);
			ArrayExtensions.Push<Func<object>>(CS_0024_003C_003E8__locals0.funcs, new Func<object>[1] { val2 });
		}
		ValueTuple<IPropertyMetadata, ClassMetadata> propertyWithOwner = MetadataHelper.GetPropertyWithOwner(metadataService, (System.Collections.Generic.IEnumerable<IPropertyMetadata>)parentModelMetadata.Metadata.get_Properties(), propertyUid, propertyParents);
		IPropertyMetadata item4 = propertyWithOwner.Item1;
		ClassMetadata item5 = propertyWithOwner.Item2;
		CS_0024_003C_003E8__locals0.propertyExpression = metadataService.GetPropertyExpression(item4, item5);
		return delegate
		{
			object target = null;
			for (int j = 0; j < CS_0024_003C_003E8__locals0.funcs.Length; j++)
			{
				target = CS_0024_003C_003E8__locals0.funcs[j].Invoke();
			}
			return ObjectExtensions.As<T>(GetModelFunc(target, CS_0024_003C_003E8__locals0.propertyExpression));
		};
	}

	private static object GetModelFunc(object target, PropertyInfoExpression parentPropertyExpression)
	{
		return target?.GetPlainPropertyValue(parentPropertyExpression);
	}

	public static ValueTuple<object, PropertyInfoExpression> GetPropertyContext(this IMetadataViewModel viewModel, IMetadataServiceContext metadataServiceContext, Guid propertyUid, Guid[] propertyParents)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (viewModel.IsDesignModeDeep)
		{
			return new ValueTuple<object, PropertyInfoExpression>((object)null, (PropertyInfoExpression)null);
		}
		if (viewModel.UIViewModel == null)
		{
			return new ValueTuple<object, PropertyInfoExpression>((object)null, (PropertyInfoExpression)null);
		}
		ModelMetadata modelMetadata = viewModel.ModelMetadata;
		if (modelMetadata.Metadata == null)
		{
			return new ValueTuple<object, PropertyInfoExpression>((object)null, (PropertyInfoExpression)null);
		}
		return (ValueTuple<object, PropertyInfoExpression>)(propertyParents.Length switch
		{
			0 => CaseZeroPropertyParents(metadataServiceContext, modelMetadata, propertyUid), 
			1 => CaseOnePropertyParents(metadataServiceContext, modelMetadata, propertyUid, propertyParents), 
			_ => CaseDefaultPropertyParents(metadataServiceContext, modelMetadata, propertyUid, propertyParents), 
		});
	}

	private static ValueTuple<object, PropertyInfoExpression> CaseZeroPropertyParents(IMetadataServiceContext metadataServiceContext, ModelMetadata parentModelMetadata, Guid propertyUid)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		ClassMetadata metadata = parentModelMetadata.Metadata;
		IPropertyMetadata property = MetadataHelper.GetProperty(metadataServiceContext, (System.Collections.Generic.IEnumerable<IPropertyMetadata>)((IMetadata)(object)metadata).GetProperties(), propertyUid, (Guid[])(object)new Guid[0]);
		if (property != null)
		{
			PropertyInfoExpression propertyExpression = metadataServiceContext.GetPropertyExpression(property, metadata);
			return new ValueTuple<object, PropertyInfoExpression>(parentModelMetadata.Model, propertyExpression);
		}
		DataClassMetadata val;
		if ((val = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null)) != null && ((INamedMetadata)val).get_Name() == "ViewModelContext")
		{
			ValueTuple<DataClassMetadata, PropertyMetadata, ClassMetadata> infoInCaseViewModelContext = MetadataHelper.GetInfoInCaseViewModelContext(metadataServiceContext, val, propertyUid);
			DataClassMetadata item = infoInCaseViewModelContext.Item1;
			PropertyMetadata item2 = infoInCaseViewModelContext.Item2;
			ClassMetadata item3 = infoInCaseViewModelContext.Item3;
			if (item != null && item2 != null && item3 != null)
			{
				System.Collections.Generic.IEnumerable<PropertyMetadata> properties = ((IMetadata)(object)metadata).GetProperties();
				PropertyInfoExpression propertyExpression2 = metadataServiceContext.GetPropertyExpression((IPropertyMetadata)(object)item2, (ClassMetadata)(object)item);
				ValueTuple<IPropertyMetadata, ClassMetadata> propertyWithOwner = MetadataHelper.GetPropertyWithOwner(metadataServiceContext, (System.Collections.Generic.IEnumerable<IPropertyMetadata>)properties, propertyUid, (Guid[])(object)new Guid[0]);
				IPropertyMetadata item4 = propertyWithOwner.Item1;
				ClassMetadata item5 = propertyWithOwner.Item2;
				PropertyInfoExpression propertyExpression3 = metadataServiceContext.GetPropertyExpression(item4, item5);
				return new ValueTuple<object, PropertyInfoExpression>(GetModelFunc(parentModelMetadata.Model, propertyExpression2), propertyExpression3);
			}
		}
		EntityMetadata val2;
		if ((val2 = (EntityMetadata)(object)((metadata is EntityMetadata) ? metadata : null)) != null && val2.get_ViewModelMetadata() == null)
		{
			DataClassMetadata viewModelMetadata = metadataServiceContext.GetViewModelMetadata(val2);
			if (viewModelMetadata != null)
			{
				ModelMetadata parentModelMetadata2 = new ModelMetadata(parentModelMetadata, (ClassMetadata)(object)viewModelMetadata, parentModelMetadata.GetModelFunc);
				return CaseZeroPropertyParents(metadataServiceContext, parentModelMetadata2, propertyUid);
			}
		}
		return new ValueTuple<object, PropertyInfoExpression>((object)null, (PropertyInfoExpression)null);
	}

	private static ValueTuple<object, PropertyInfoExpression> CaseOnePropertyParents(IMetadataServiceContext metadataService, ModelMetadata parentModelMetadata, Guid propertyUid, Guid[] propertyParents)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		ClassMetadata metadata = parentModelMetadata.Metadata;
		CS_0024_003C_003E8__locals0.parentPropertyUid = propertyParents[0];
		System.Collections.Generic.IEnumerable<PropertyMetadata> properties = ((IMetadata)(object)metadata).GetProperties();
		PropertyMetadata val = Enumerable.FirstOrDefault<PropertyMetadata>(properties, (Func<PropertyMetadata, bool>)((PropertyMetadata property) => ((IMetadata)property).get_Uid() == CS_0024_003C_003E8__locals0.parentPropertyUid));
		if (val != null)
		{
			if (!(metadataService.GetMetadata(((IPropertyMetadata)val).get_SubTypeUid()) is ClassMetadata))
			{
				return new ValueTuple<object, PropertyInfoExpression>((object)null, (PropertyInfoExpression)null);
			}
			PropertyInfoExpression propertyExpression = metadataService.GetPropertyExpression((IPropertyMetadata)(object)val, metadata);
			ValueTuple<IPropertyMetadata, ClassMetadata> propertyWithOwner = MetadataHelper.GetPropertyWithOwner(metadataService, (System.Collections.Generic.IEnumerable<IPropertyMetadata>)properties, propertyUid, propertyParents);
			IPropertyMetadata item = propertyWithOwner.Item1;
			ClassMetadata item2 = propertyWithOwner.Item2;
			PropertyInfoExpression propertyExpression2 = metadataService.GetPropertyExpression(item, item2);
			return new ValueTuple<object, PropertyInfoExpression>(GetModelFunc(parentModelMetadata.Model, propertyExpression), propertyExpression2);
		}
		DataClassMetadata val2;
		if ((val2 = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null)) != null && ((INamedMetadata)val2).get_Name() == "ViewModelContext")
		{
			ValueTuple<DataClassMetadata, PropertyMetadata, ClassMetadata> infoInCaseViewModelContext = MetadataHelper.GetInfoInCaseViewModelContext(metadataService, val2, CS_0024_003C_003E8__locals0.parentPropertyUid);
			DataClassMetadata item3 = infoInCaseViewModelContext.Item1;
			PropertyMetadata item4 = infoInCaseViewModelContext.Item2;
			ClassMetadata item5 = infoInCaseViewModelContext.Item3;
			if (item3 != null && item4 != null && item5 != null)
			{
				PropertyInfoExpression propertyExpression3 = metadataService.GetPropertyExpression((IPropertyMetadata)(object)item4, (ClassMetadata)(object)item3);
				ValueTuple<IPropertyMetadata, ClassMetadata> propertyWithOwner2 = MetadataHelper.GetPropertyWithOwner(metadataService, (System.Collections.Generic.IEnumerable<IPropertyMetadata>)properties, propertyUid, propertyParents);
				IPropertyMetadata item6 = propertyWithOwner2.Item1;
				ClassMetadata item7 = propertyWithOwner2.Item2;
				PropertyInfoExpression propertyExpression4 = metadataService.GetPropertyExpression(item6, item7);
				return new ValueTuple<object, PropertyInfoExpression>(GetModelFunc(parentModelMetadata.Model, propertyExpression3), propertyExpression4);
			}
		}
		EntityMetadata val3;
		if ((val3 = (EntityMetadata)(object)((metadata is EntityMetadata) ? metadata : null)) != null && val3.get_ViewModelMetadata() == null)
		{
			DataClassMetadata viewModelMetadata = metadataService.GetViewModelMetadata(val3);
			if (viewModelMetadata != null)
			{
				ModelMetadata parentModelMetadata2 = new ModelMetadata(parentModelMetadata, (ClassMetadata)(object)viewModelMetadata, parentModelMetadata.GetModelFunc);
				return CaseOnePropertyParents(metadataService, parentModelMetadata2, propertyUid, propertyParents);
			}
		}
		return new ValueTuple<object, PropertyInfoExpression>((object)null, (PropertyInfoExpression)null);
	}

	private static ValueTuple<object, PropertyInfoExpression> CaseDefaultPropertyParents(IMetadataServiceContext metadataService, ModelMetadata parentModelMetadata, Guid propertyUid, Guid[] propertyParents)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		Func<object>[] array = new Func<object>[0];
		ClassMetadata val = parentModelMetadata.Metadata;
		Func<object> val2 = parentModelMetadata.GetModelFunc;
		ModelMetadata parent = parentModelMetadata;
		ArrayExtensions.Push<Func<object>>(array, new Func<object>[1] { val2 });
		for (int i = 0; i < propertyParents.Length; i++)
		{
			_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass9_0();
			CS_0024_003C_003E8__locals1.parentUid = propertyParents[i];
			PropertyMetadata val3 = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)val.get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata property) => ((IMetadata)property).get_Uid() == CS_0024_003C_003E8__locals1.parentUid));
			EntityMetadata val4;
			if (val3 == null && (val4 = (EntityMetadata)(object)((val is EntityMetadata) ? val : null)) != null && val4.get_Type() == 2)
			{
				IMetadata metadata = metadataService.GetMetadata(((ClassMetadata)val4).get_BaseClassUid());
				ClassMetadata val5 = (ClassMetadata)(object)((metadata is ClassMetadata) ? metadata : null);
				if (val5 != null)
				{
					val = val5;
					do
					{
						val3 = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)val.get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata property) => ((IMetadata)property).get_Uid() == CS_0024_003C_003E8__locals1.parentUid));
						if (val3 != null || val.get_BaseClassUid() == Guid.Empty)
						{
							break;
						}
						IMetadata metadata2 = metadataService.GetMetadata(val.get_BaseClassUid());
						val = (ClassMetadata)(object)((metadata2 is ClassMetadata) ? metadata2 : null);
					}
					while (val != null);
				}
			}
			if (val3 != null)
			{
				_003C_003Ec__DisplayClass9_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_1();
				IMetadata metadata3 = metadataService.GetMetadata(((IPropertyMetadata)val3).get_SubTypeUid());
				ClassMetadata val6 = (ClassMetadata)(object)((metadata3 is ClassMetadata) ? metadata3 : null);
				if (val6 == null)
				{
					return new ValueTuple<object, PropertyInfoExpression>((object)null, (PropertyInfoExpression)null);
				}
				CS_0024_003C_003E8__locals0.parentPropertyExpression = metadataService.GetPropertyExpression((IPropertyMetadata)(object)val3, val);
				CS_0024_003C_003E8__locals0.tempTargetModelFunc = val2;
				val2 = () => GetModelFunc(CS_0024_003C_003E8__locals0.tempTargetModelFunc.Invoke(), CS_0024_003C_003E8__locals0.parentPropertyExpression);
				val = val6;
				parent = new ModelMetadata(parent, val, val2);
				ArrayExtensions.Push<Func<object>>(array, new Func<object>[1] { val2 });
				continue;
			}
			EntityMetadata val7;
			if ((val7 = (EntityMetadata)(object)((val is EntityMetadata) ? val : null)) != null && val7.get_ViewModelMetadata() == null)
			{
				DataClassMetadata viewModelMetadata = metadataService.GetViewModelMetadata(val7);
				if (viewModelMetadata != null)
				{
					ModelMetadata parentModelMetadata2 = new ModelMetadata(parentModelMetadata, (ClassMetadata)(object)viewModelMetadata, parentModelMetadata.GetModelFunc);
					return CaseDefaultPropertyParents(metadataService, parentModelMetadata2, propertyUid, propertyParents);
				}
			}
			DataClassMetadata val8 = (DataClassMetadata)(object)((val is DataClassMetadata) ? val : null);
			if (val8 == null || val8.get_IncludeList().get_Count() == 0)
			{
				return new ValueTuple<object, PropertyInfoExpression>((object)null, (PropertyInfoExpression)null);
			}
			DataClassDependency val9 = Enumerable.FirstOrDefault<DataClassDependency>((System.Collections.Generic.IEnumerable<DataClassDependency>)val8.get_IncludeList(), (Func<DataClassDependency, bool>)((DataClassDependency include) => ((Dependency)include).get_HeaderUid() == CS_0024_003C_003E8__locals1.parentUid));
			if (val9 == null)
			{
				if (i == 0 && ((INamedMetadata)val8).get_Name() == "ViewModelContext")
				{
					ValueTuple<DataClassMetadata, PropertyMetadata, ClassMetadata> infoInCaseViewModelContext = MetadataHelper.GetInfoInCaseViewModelContext(metadataService, val8, CS_0024_003C_003E8__locals1.parentUid);
					DataClassMetadata item = infoInCaseViewModelContext.Item1;
					PropertyMetadata item2 = infoInCaseViewModelContext.Item2;
					ClassMetadata item3 = infoInCaseViewModelContext.Item3;
					if (item != null && item2 != null && item3 != null)
					{
						val2 = new _003C_003Ec__DisplayClass9_2
						{
							includePropertyExpression = metadataService.GetPropertyExpression((IPropertyMetadata)(object)item2, (ClassMetadata)(object)item),
							tempTargetModelFunc = val2
						}._003CCaseDefaultPropertyParents_003Eb__4;
						val = item3;
						parent = new ModelMetadata(parent, val, val2);
						ArrayExtensions.Push<Func<object>>(array, new Func<object>[1] { val2 });
						continue;
					}
				}
				return new ValueTuple<object, PropertyInfoExpression>((object)null, (PropertyInfoExpression)null);
			}
			IMetadata metadata4 = metadataService.GetMetadata(((Dependency)val9).get_HeaderUid());
			ClassMetadata val10 = (ClassMetadata)(object)((metadata4 is ClassMetadata) ? metadata4 : null);
			if (val10 == null)
			{
				return new ValueTuple<object, PropertyInfoExpression>((object)null, (PropertyInfoExpression)null);
			}
			val = val10;
			parent = new ModelMetadata(parent, val, val2);
			ArrayExtensions.Push<Func<object>>(array, new Func<object>[1] { val2 });
		}
		ValueTuple<IPropertyMetadata, ClassMetadata> propertyWithOwner = MetadataHelper.GetPropertyWithOwner(metadataService, (System.Collections.Generic.IEnumerable<IPropertyMetadata>)parentModelMetadata.Metadata.get_Properties(), propertyUid, propertyParents);
		IPropertyMetadata item4 = propertyWithOwner.Item1;
		ClassMetadata item5 = propertyWithOwner.Item2;
		PropertyInfoExpression propertyExpression = metadataService.GetPropertyExpression(item4, item5);
		object obj = null;
		for (int j = 0; j < array.Length; j++)
		{
			obj = array[j].Invoke();
		}
		return new ValueTuple<object, PropertyInfoExpression>(obj, propertyExpression);
	}
}
