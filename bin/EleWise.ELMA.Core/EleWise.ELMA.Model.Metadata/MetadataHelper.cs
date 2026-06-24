using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Views;
using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Model.Metadata;

public static class MetadataHelper
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public Guid? typeUid;

		internal bool _003CGetEnumerableProperties_003Eb__0(PropertyMetadata p)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			if (typeUid.get_HasValue())
			{
				Guid? val = typeUid;
				Guid subTypeUid = ((IPropertyMetadata)p).get_SubTypeUid();
				if (!val.get_HasValue() || (val.get_HasValue() && val.GetValueOrDefault() != subTypeUid))
				{
					return false;
				}
			}
			if (((IPropertyMetadata)p).get_TypeUid() == EntityDescriptor.UID)
			{
				TypeSettings settings = ((IPropertyMetadata)p).get_Settings();
				EntitySettings val2 = (EntitySettings)(object)((settings is EntitySettings) ? settings : null);
				if (val2 == null)
				{
					return false;
				}
				return val2.get_RelationType() != 0;
			}
			if (((IPropertyMetadata)p).get_TypeUid() == DataClassDescriptor.UID)
			{
				TypeSettings settings2 = ((IPropertyMetadata)p).get_Settings();
				DataClassSettings val3 = (DataClassSettings)(object)((settings2 is DataClassSettings) ? settings2 : null);
				if (val3 == null)
				{
					return false;
				}
				return val3.get_RelationType() != 0;
			}
			return ((IPropertyMetadata)p).get_TypeUid() == ListOfSimpleTypeDescriptor.UID;
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public string computedEqlQueryExpression;

		public Func<ComputedValue, bool> _003C_003E9__2;

		internal bool _003CGetEqlComputedProperties_003Eb__1(PropertyMetadata p)
		{
			ViewModelPropertyMetadata val;
			EntitySettings val2;
			if ((val = (ViewModelPropertyMetadata)(object)((p is ViewModelPropertyMetadata) ? p : null)) != null && (val2 = (EntitySettings)/*isinst with value type is only supported in some contexts*/) != null && val2.get_IsComputedEqlValue())
			{
				ComputedValue val3 = Enumerable.FirstOrDefault<ComputedValue>((System.Collections.Generic.IEnumerable<ComputedValue>)val.get_ComputedValues(), (Func<ComputedValue, bool>)((ComputedValue a) => a.get_Name() == computedEqlQueryExpression));
				if (val3 != null && val3.get_ComputedValueType() != 0)
				{
					return true;
				}
				return !string.IsNullOrWhiteSpace(val2.get_ComputedEqlQuery());
			}
			return false;
		}

		internal bool _003CGetEqlComputedProperties_003Eb__2(ComputedValue a)
		{
			return a.get_Name() == computedEqlQueryExpression;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
	}

	[StructLayout(3)]
	private struct _003CGetPropertiesWithIncludeAsync_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<PropertyMetadata>> _003C_003Et__builder;

		public DataClassMetadata dataClassMetadata;

		public IMetadataServiceContext metadataService;

		private PropertyMetadata[] _003Cproperties_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected O, but got Unknown
			int num = _003C_003E1__state;
			System.Collections.Generic.IEnumerable<PropertyMetadata> result;
			try
			{
				TaskAwaiter val;
				if (num == 0)
				{
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0096;
				}
				_003Cproperties_003E5__2 = (PropertyMetadata[])(object)new PropertyMetadata[0];
				if (dataClassMetadata != null && metadataService != null)
				{
					val = FillPropertiesWithIncludeAsync(_003Cproperties_003E5__2, dataClassMetadata, metadataService).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter, _003CGetPropertiesWithIncludeAsync_003Ed__11>(ref val, ref this);
						return;
					}
					goto IL_0096;
				}
				result = _003Cproperties_003E5__2;
				goto end_IL_0007;
				IL_0096:
				val.GetResult();
				System.Collections.Generic.IEnumerator<PropertyMetadata> enumerator = ((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)dataClassMetadata).get_Properties()).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						PropertyMetadata current = enumerator.get_Current();
						ArrayExtensions.Push<PropertyMetadata>(_003Cproperties_003E5__2, (PropertyMetadata[])(object)new PropertyMetadata[1] { current });
					}
				}
				finally
				{
					if (num < 0)
					{
						((System.IDisposable)enumerator)?.Dispose();
					}
				}
				result = _003Cproperties_003E5__2;
				end_IL_0007:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public ViewModelPropertyMetadata property;

		internal bool _003CCanBeInput_003Eb__0(DataClassMetadata d)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)d).get_Uid() == ((IPropertyMetadata)property).get_SubTypeUid();
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_1
	{
		public Guid parameterTypeSubTypeUid;

		public Guid returnTypeSubTypeUid;

		internal bool _003CCanBeInput_003Eb__1(DataClassMetadata d)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)d).get_Uid() == parameterTypeSubTypeUid;
		}

		internal bool _003CCanBeInput_003Eb__2(DataClassMetadata d)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)d).get_Uid() == returnTypeSubTypeUid;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public ViewModelPropertyMetadata property;

		internal bool _003CCanBeOutput_003Eb__0(DataClassMetadata d)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)d).get_Uid() == ((IPropertyMetadata)property).get_SubTypeUid();
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public Guid currentPropertyUid;

		public Func<PropertyMetadata, bool> _003C_003E9__0;

		internal bool _003CGetInfoInCaseViewModelContextAsync_003Eb__0(PropertyMetadata property)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)property).get_Uid() == currentPropertyUid;
		}
	}

	[StructLayout(3)]
	private struct _003CGetInfoInCaseViewModelContextAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ValueTuple<DataClassMetadata, PropertyMetadata, ClassMetadata>> _003C_003Et__builder;

		public Guid currentPropertyUid;

		public DataClassMetadata dataClassMetadata;

		public IMetadataServiceContext metadataService;

		private _003C_003Ec__DisplayClass17_0 _003C_003E8__1;

		private DataClassMetadata _003CincludeMetadata_003E5__2;

		private PropertyMetadata _003CincludeProperty_003E5__3;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ValueTuple<DataClassMetadata, PropertyMetadata, ClassMetadata> result2;
			try
			{
				DataClassMetadata val;
				TaskAwaiter<IMetadata> val2;
				if (num != 0)
				{
					if (num != 1)
					{
						_003C_003E8__1 = new _003C_003Ec__DisplayClass17_0();
						_003C_003E8__1.currentPropertyUid = currentPropertyUid;
						val = dataClassMetadata;
						if (dataClassMetadata.get_IncludeList().get_Count() != 0)
						{
						}
						goto IL_01dc;
					}
					val2 = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_01a3;
				}
				val2 = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
				_003C_003Eu__1 = null;
				num = (_003C_003E1__state = -1);
				goto IL_00bf;
				IL_00bf:
				IMetadata result = val2.GetResult();
				_003CincludeMetadata_003E5__2 = (DataClassMetadata)(object)((result is DataClassMetadata) ? result : null);
				if (_003CincludeMetadata_003E5__2 != null)
				{
					_003CincludeProperty_003E5__3 = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)_003CincludeMetadata_003E5__2).get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata property) => ((IMetadata)property).get_Uid() == _003C_003E8__1.currentPropertyUid));
					if (_003CincludeProperty_003E5__3 != null)
					{
						val2 = metadataService.GetMetadataAsync(((IPropertyMetadata)_003CincludeProperty_003E5__3).get_SubTypeUid()).GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val2;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CGetInfoInCaseViewModelContextAsync_003Ed__17>(ref val2, ref this);
							return;
						}
						goto IL_01a3;
					}
					val = _003CincludeMetadata_003E5__2;
					_003CincludeMetadata_003E5__2 = null;
					_003CincludeProperty_003E5__3 = null;
					goto IL_01dc;
				}
				result2 = new ValueTuple<DataClassMetadata, PropertyMetadata, ClassMetadata>((DataClassMetadata)null, (PropertyMetadata)null, (ClassMetadata)null);
				goto end_IL_0007;
				IL_01dc:
				if (val.get_IncludeList().get_Count() == 1)
				{
					DataClassDependency val3 = Enumerable.First<DataClassDependency>((System.Collections.Generic.IEnumerable<DataClassDependency>)val.get_IncludeList());
					val2 = metadataService.GetMetadataAsync(((Dependency)val3).get_HeaderUid()).GetAwaiter();
					if (!val2.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val2;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CGetInfoInCaseViewModelContextAsync_003Ed__17>(ref val2, ref this);
						return;
					}
					goto IL_00bf;
				}
				result2 = new ValueTuple<DataClassMetadata, PropertyMetadata, ClassMetadata>((DataClassMetadata)null, (PropertyMetadata)null, (ClassMetadata)null);
				goto end_IL_0007;
				IL_01a3:
				IMetadata result3 = val2.GetResult();
				ClassMetadata val4 = (ClassMetadata)(object)((result3 is ClassMetadata) ? result3 : null);
				result2 = new ValueTuple<DataClassMetadata, PropertyMetadata, ClassMetadata>(_003CincludeMetadata_003E5__2, _003CincludeProperty_003E5__3, val4);
				end_IL_0007:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public Guid currentPropertyUid;

		public Func<PropertyMetadata, bool> _003C_003E9__0;

		internal bool _003CGetInfoInCaseViewModelContext_003Eb__0(PropertyMetadata property)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)property).get_Uid() == currentPropertyUid;
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public Guid parent;

		internal bool _003CGetProperty_003Eb__0(IPropertyMetadata a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)a).get_Uid() == parent;
		}

		internal bool _003CGetProperty_003Eb__1(DataClassDependency i)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((Dependency)i).get_HeaderUid() == parent;
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public Guid parent;

		internal bool _003CGetPropertyWithOwner_003Eb__0(IPropertyMetadata a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)a).get_Uid() == parent;
		}

		internal bool _003CGetPropertyWithOwner_003Eb__1(DataClassDependency inc)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((Dependency)inc).get_HeaderUid() == parent;
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public Guid parent;

		internal bool _003CGetPropertyWithOwnerAsync_003Eb__0(IPropertyMetadata a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)a).get_Uid() == parent;
		}

		internal bool _003CGetPropertyWithOwnerAsync_003Eb__1(DataClassDependency inc)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((Dependency)inc).get_HeaderUid() == parent;
		}
	}

	[StructLayout(3)]
	private struct _003CGetPropertyWithOwnerAsync_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ValueTuple<IPropertyMetadata, ClassMetadata>> _003C_003Et__builder;

		public IMetadataServiceContext metadataService;

		public System.Collections.Generic.IEnumerable<IPropertyMetadata> properties;

		public Guid[] parents;

		private IPropertyMetadata[] _003Cprops_003E5__2;

		private IPropertyMetadata _003Cproperty_003E5__3;

		private int _003Ci_003E5__4;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ValueTuple<IPropertyMetadata, ClassMetadata> result;
			try
			{
				ClassMetadata val2;
				TaskAwaiter<IMetadata> val;
				IMetadata result2;
				IMetadata result3;
				IMetadata result4;
				_003C_003Ec__DisplayClass26_0 CS_0024_003C_003E8__locals0;
				switch (num)
				{
				default:
					if (metadataService == null)
					{
						result = new ValueTuple<IPropertyMetadata, ClassMetadata>((IPropertyMetadata)null, (ClassMetadata)null);
					}
					else
					{
						_003Cprops_003E5__2 = Enumerable.ToArray<IPropertyMetadata>(properties);
						if (_003Cprops_003E5__2.Length != 0)
						{
							_003Cproperty_003E5__3 = null;
							val2 = null;
							_003Ci_003E5__4 = 0;
							goto IL_029e;
						}
						result = new ValueTuple<IPropertyMetadata, ClassMetadata>((IPropertyMetadata)null, (ClassMetadata)null);
					}
					goto end_IL_0007;
				case 0:
					val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_011c;
				case 1:
					val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_01e3;
				case 2:
					{
						val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_027c;
					}
					IL_011c:
					result2 = val.GetResult();
					val2 = (ClassMetadata)(object)((result2 is ClassMetadata) ? result2 : null);
					goto IL_028c;
					IL_028c:
					_003Ci_003E5__4++;
					goto IL_029e;
					IL_01e3:
					result3 = val.GetResult();
					val2 = (ClassMetadata)(object)((result3 is ClassMetadata) ? result3 : null);
					if (!(val2 is DataClassMetadata))
					{
						break;
					}
					goto IL_028c;
					IL_027c:
					result4 = val.GetResult();
					val2 = (ClassMetadata)(object)((result4 is ClassMetadata) ? result4 : null);
					if (val2 == null)
					{
						break;
					}
					goto IL_028c;
					IL_029e:
					if (_003Ci_003E5__4 >= parents.Length)
					{
						break;
					}
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass26_0();
					CS_0024_003C_003E8__locals0.parent = parents[_003Ci_003E5__4];
					if (val2 == null)
					{
						_003Cproperty_003E5__3 = Enumerable.FirstOrDefault<IPropertyMetadata>((System.Collections.Generic.IEnumerable<IPropertyMetadata>)_003Cprops_003E5__2, (Func<IPropertyMetadata, bool>)((IPropertyMetadata a) => ((IMetadata)a).get_Uid() == CS_0024_003C_003E8__locals0.parent));
						if (_003Cproperty_003E5__3 == null)
						{
							break;
						}
						val = metadataService.GetMetadataAsync(_003Cproperty_003E5__3.get_SubTypeUid()).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CGetPropertyWithOwnerAsync_003Ed__26>(ref val, ref this);
							return;
						}
						goto IL_011c;
					}
					_003Cproperty_003E5__3 = metadataService.GetProperty(val2, CS_0024_003C_003E8__locals0.parent);
					if (_003Cproperty_003E5__3 == null)
					{
						DataClassMetadata val3;
						if ((val3 = (DataClassMetadata)(object)((val2 is DataClassMetadata) ? val2 : null)) == null)
						{
							break;
						}
						DataClassDependency val4 = Enumerable.FirstOrDefault<DataClassDependency>((System.Collections.Generic.IEnumerable<DataClassDependency>)val3.get_IncludeList(), (Func<DataClassDependency, bool>)((DataClassDependency inc) => ((Dependency)inc).get_HeaderUid() == CS_0024_003C_003E8__locals0.parent));
						if (val4 == null)
						{
							break;
						}
						val = metadataService.GetMetadataAsync(((Dependency)val4).get_HeaderUid()).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CGetPropertyWithOwnerAsync_003Ed__26>(ref val, ref this);
							return;
						}
						goto IL_01e3;
					}
					if (_003Ci_003E5__4 == parents.Length - 1)
					{
						break;
					}
					val = metadataService.GetMetadataAsync(_003Cproperty_003E5__3.get_SubTypeUid()).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CGetPropertyWithOwnerAsync_003Ed__26>(ref val, ref this);
						return;
					}
					goto IL_027c;
				}
				result = new ValueTuple<IPropertyMetadata, ClassMetadata>(_003Cproperty_003E5__3, val2);
				end_IL_0007:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public Guid parent;

		internal bool _003CGetPropertyAsync_003Eb__0(IPropertyMetadata a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)a).get_Uid() == parent;
		}

		internal bool _003CGetPropertyAsync_003Eb__1(DataClassDependency inc)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((Dependency)inc).get_HeaderUid() == parent;
		}
	}

	[StructLayout(3)]
	private struct _003CGetPropertyAsync_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IPropertyMetadata> _003C_003Et__builder;

		public IMetadataServiceContext metadataService;

		public System.Collections.Generic.IEnumerable<IPropertyMetadata> properties;

		public Guid[] parents;

		private IPropertyMetadata[] _003Cprops_003E5__2;

		private IPropertyMetadata _003Cproperty_003E5__3;

		private int _003Ci_003E5__4;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			IPropertyMetadata result;
			try
			{
				ClassMetadata val2;
				TaskAwaiter<IMetadata> val;
				IMetadata result2;
				IMetadata result3;
				IMetadata result4;
				_003C_003Ec__DisplayClass30_0 CS_0024_003C_003E8__locals0;
				switch (num)
				{
				default:
					if (metadataService == null)
					{
						result = null;
					}
					else
					{
						_003Cprops_003E5__2 = Enumerable.ToArray<IPropertyMetadata>(properties);
						if (_003Cprops_003E5__2.Length != 0)
						{
							_003Cproperty_003E5__3 = null;
							val2 = null;
							_003Ci_003E5__4 = 0;
							goto IL_027a;
						}
						result = null;
					}
					goto end_IL_0007;
				case 0:
					val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0110;
				case 1:
					val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_01d7;
				case 2:
					{
						val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_0258;
					}
					IL_0110:
					result2 = val.GetResult();
					val2 = (ClassMetadata)(object)((result2 is ClassMetadata) ? result2 : null);
					goto IL_0268;
					IL_0258:
					result3 = val.GetResult();
					val2 = (ClassMetadata)(object)((result3 is ClassMetadata) ? result3 : null);
					if (val2 == null)
					{
						break;
					}
					goto IL_0268;
					IL_01d7:
					result4 = val.GetResult();
					val2 = (ClassMetadata)(object)((result4 is ClassMetadata) ? result4 : null);
					if (!(val2 is DataClassMetadata))
					{
						break;
					}
					goto IL_0268;
					IL_0268:
					_003Ci_003E5__4++;
					goto IL_027a;
					IL_027a:
					if (_003Ci_003E5__4 >= parents.Length)
					{
						break;
					}
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass30_0();
					CS_0024_003C_003E8__locals0.parent = parents[_003Ci_003E5__4];
					if (val2 == null)
					{
						_003Cproperty_003E5__3 = Enumerable.FirstOrDefault<IPropertyMetadata>((System.Collections.Generic.IEnumerable<IPropertyMetadata>)_003Cprops_003E5__2, (Func<IPropertyMetadata, bool>)((IPropertyMetadata a) => ((IMetadata)a).get_Uid() == CS_0024_003C_003E8__locals0.parent));
						if (_003Cproperty_003E5__3 == null)
						{
							break;
						}
						val = metadataService.GetMetadataAsync(_003Cproperty_003E5__3.get_SubTypeUid()).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CGetPropertyAsync_003Ed__30>(ref val, ref this);
							return;
						}
						goto IL_0110;
					}
					_003Cproperty_003E5__3 = metadataService.GetProperty(val2, CS_0024_003C_003E8__locals0.parent);
					if (_003Cproperty_003E5__3 == null)
					{
						DataClassMetadata val3;
						if ((val3 = (DataClassMetadata)(object)((val2 is DataClassMetadata) ? val2 : null)) == null)
						{
							break;
						}
						DataClassDependency val4 = Enumerable.FirstOrDefault<DataClassDependency>((System.Collections.Generic.IEnumerable<DataClassDependency>)val3.get_IncludeList(), (Func<DataClassDependency, bool>)((DataClassDependency inc) => ((Dependency)inc).get_HeaderUid() == CS_0024_003C_003E8__locals0.parent));
						if (val4 == null)
						{
							break;
						}
						val = metadataService.GetMetadataAsync(((Dependency)val4).get_HeaderUid()).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CGetPropertyAsync_003Ed__30>(ref val, ref this);
							return;
						}
						goto IL_01d7;
					}
					val = metadataService.GetMetadataAsync(_003Cproperty_003E5__3.get_SubTypeUid()).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CGetPropertyAsync_003Ed__30>(ref val, ref this);
						return;
					}
					goto IL_0258;
				}
				result = _003Cproperty_003E5__3;
				end_IL_0007:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public Guid propertyUid;

		public Func<PropertyMetadata, bool> _003C_003E9__0;

		internal bool _003CFindTablePartOrProperty_003Eb__0(PropertyMetadata a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)a).get_Uid() == propertyUid;
		}
	}

	[StructLayout(3)]
	private struct _003CFillPropertiesWithIncludeAsync_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DataClassMetadata dataClassMetadata;

		public IMetadataServiceContext metadataService;

		public PropertyMetadata[] properties;

		private System.Collections.Generic.IEnumerator<DataClassDependency> _003C_003E7__wrap1;

		private DataClassMetadata _003CincludeMetadata_003E5__3;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Expected O, but got Unknown
			int num = _003C_003E1__state;
			try
			{
				if ((uint)num > 1u)
				{
					_003C_003E7__wrap1 = ((System.Collections.Generic.IEnumerable<DataClassDependency>)dataClassMetadata.get_IncludeList()).GetEnumerator();
				}
				try
				{
					TaskAwaiter val;
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_017d;
						}
						val = (TaskAwaiter)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_0121;
					}
					TaskAwaiter<IMetadata> val2 = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_009b;
					IL_009b:
					IMetadata result = val2.GetResult();
					_003CincludeMetadata_003E5__3 = (DataClassMetadata)(object)((result is DataClassMetadata) ? result : null);
					if (_003CincludeMetadata_003E5__3 != null)
					{
						val = FillPropertiesWithIncludeAsync(properties, _003CincludeMetadata_003E5__3, metadataService).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CFillPropertiesWithIncludeAsync_003Ed__35>(ref val, ref this);
							return;
						}
						goto IL_0121;
					}
					goto IL_017d;
					IL_017d:
					if (((System.Collections.IEnumerator)_003C_003E7__wrap1).MoveNext())
					{
						DataClassDependency current = _003C_003E7__wrap1.get_Current();
						val2 = metadataService.GetMetadataAsync(((Dependency)current).get_HeaderUid()).GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val2;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CFillPropertiesWithIncludeAsync_003Ed__35>(ref val2, ref this);
							return;
						}
						goto IL_009b;
					}
					goto end_IL_0022;
					IL_0121:
					val.GetResult();
					System.Collections.Generic.IEnumerator<PropertyMetadata> enumerator = ((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)_003CincludeMetadata_003E5__3).get_Properties()).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							PropertyMetadata current2 = enumerator.get_Current();
							ArrayExtensions.Push<PropertyMetadata>(properties, (PropertyMetadata[])(object)new PropertyMetadata[1] { current2 });
						}
					}
					finally
					{
						if (num < 0)
						{
							((System.IDisposable)enumerator)?.Dispose();
						}
					}
					_003CincludeMetadata_003E5__3 = null;
					goto IL_017d;
					end_IL_0022:;
				}
				finally
				{
					if (num < 0 && _003C_003E7__wrap1 != null)
					{
						((System.IDisposable)_003C_003E7__wrap1).Dispose();
					}
				}
				_003C_003E7__wrap1 = null;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(stateMachine);
		}
	}

	public static void InitNew(this IMetadata metadataDto)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		metadataDto.set_Uid(Guid.NewGuid());
	}

	public static System.Collections.Generic.IEnumerable<PropertyMetadata> GetProperties(this IMetadata metadata)
	{
		if (metadata == null)
		{
			return (System.Collections.Generic.IEnumerable<PropertyMetadata>)Enumerable.Empty<PropertyMetadata>();
		}
		ClassMetadata classMetadata = metadata.GetClassMetadata();
		if (classMetadata == null)
		{
			return (System.Collections.Generic.IEnumerable<PropertyMetadata>)Enumerable.Empty<PropertyMetadata>();
		}
		return (System.Collections.Generic.IEnumerable<PropertyMetadata>)classMetadata.get_Properties();
	}

	public static System.Collections.Generic.IEnumerable<PropertyMetadata> GetEnumerableProperties(this IMetadata metadata, Guid? typeUid = null)
	{
		ClassMetadata classMetadata = metadata.GetClassMetadata();
		if (classMetadata != null)
		{
			return classMetadata.GetEnumerableProperties(typeUid);
		}
		return (System.Collections.Generic.IEnumerable<PropertyMetadata>)Enumerable.Empty<PropertyMetadata>();
	}

	public static System.Collections.Generic.IEnumerable<PropertyMetadata> GetEnumerableProperties(this ClassMetadata metadata, Guid? typeUid = null)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0.typeUid = typeUid;
		return (System.Collections.Generic.IEnumerable<PropertyMetadata>)Enumerable.Where<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)metadata.get_Properties(), (Func<PropertyMetadata, bool>)delegate(PropertyMetadata p)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			if (CS_0024_003C_003E8__locals0.typeUid.get_HasValue())
			{
				Guid? typeUid2 = CS_0024_003C_003E8__locals0.typeUid;
				Guid subTypeUid = ((IPropertyMetadata)p).get_SubTypeUid();
				if (!typeUid2.get_HasValue() || (typeUid2.get_HasValue() && typeUid2.GetValueOrDefault() != subTypeUid))
				{
					return false;
				}
			}
			if (((IPropertyMetadata)p).get_TypeUid() == EntityDescriptor.UID)
			{
				TypeSettings settings = ((IPropertyMetadata)p).get_Settings();
				EntitySettings val = (EntitySettings)(object)((settings is EntitySettings) ? settings : null);
				if (val == null)
				{
					return false;
				}
				return val.get_RelationType() != 0;
			}
			if (((IPropertyMetadata)p).get_TypeUid() == DataClassDescriptor.UID)
			{
				TypeSettings settings2 = ((IPropertyMetadata)p).get_Settings();
				DataClassSettings val2 = (DataClassSettings)(object)((settings2 is DataClassSettings) ? settings2 : null);
				if (val2 == null)
				{
					return false;
				}
				return val2.get_RelationType() != 0;
			}
			return ((IPropertyMetadata)p).get_TypeUid() == ListOfSimpleTypeDescriptor.UID;
		});
	}

	public static bool IsEnumerableProperty(this IPropertyMetadata propertyMetadata)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (propertyMetadata == null)
		{
			return false;
		}
		if (propertyMetadata.get_TypeUid() == Guid.Empty)
		{
			return false;
		}
		TypeSettings settings = propertyMetadata.get_Settings();
		if (settings == null)
		{
			return false;
		}
		EntitySettings val;
		if ((val = (EntitySettings)(object)((settings is EntitySettings) ? settings : null)) != null)
		{
			return val.get_RelationType() != 0;
		}
		DataClassSettings val2;
		if ((val2 = (DataClassSettings)(object)((settings is DataClassSettings) ? settings : null)) != null)
		{
			return val2.get_RelationType() != 0;
		}
		return propertyMetadata.get_TypeUid() == ListOfSimpleTypeDescriptor.UID;
	}

	public static bool IsObjectProperty(this IPropertyMetadata propertyMetadata)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (propertyMetadata.get_SubTypeUid() == Guid.Empty)
		{
			return false;
		}
		if (propertyMetadata.get_TypeUid() == EnumDescriptor.UID)
		{
			return false;
		}
		return true;
	}

	public static ClassMetadata GetClassMetadata(this IMetadata metadata)
	{
		if (metadata != null)
		{
			ComponentMetadata val;
			if ((val = (ComponentMetadata)(object)((metadata is ComponentMetadata) ? metadata : null)) != null)
			{
				return (ClassMetadata)(object)val.get_Content().get_Context();
			}
			ClassMetadata result;
			if ((result = (ClassMetadata)(object)((metadata is ClassMetadata) ? metadata : null)) != null)
			{
				return result;
			}
		}
		return null;
	}

	public static Guid GetMetadataType(ICodeItemMetadata metadata)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (metadata != null)
		{
			EnumMetadata val;
			if ((val = (EnumMetadata)(object)((metadata is EnumMetadata) ? metadata : null)) != null)
			{
				return MetadataConstants.EnumMetadataTypeUid;
			}
			DataClassMetadata val2;
			if ((val2 = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null)) != null)
			{
				return MetadataConstants.DataClassMetadataTypeUid;
			}
			EntityMetadata val3;
			if ((val3 = (EntityMetadata)(object)((metadata is EntityMetadata) ? metadata : null)) != null)
			{
				return MetadataConstants.EntityMetadataTypeUid;
			}
			PageComponentMetadata val4;
			if ((val4 = (PageComponentMetadata)(object)((metadata is PageComponentMetadata) ? metadata : null)) != null)
			{
				return MetadataConstants.PageComponentMetadataTypeUid;
			}
			PortletComponentMetadata val5;
			if ((val5 = (PortletComponentMetadata)(object)((metadata is PortletComponentMetadata) ? metadata : null)) != null)
			{
				return MetadataConstants.PortletComponentMetadataTypeUid;
			}
			ComponentMetadata val6;
			if ((val6 = (ComponentMetadata)(object)((metadata is ComponentMetadata) ? metadata : null)) != null)
			{
				return MetadataConstants.ComponentMetadataTypeUid;
			}
		}
		return Guid.Empty;
	}

	internal static ValueTuple<PropertyMetadata, ITypeDescriptor> GetIdProperty(this EntityMetadata metadata, IDescriptorService descriptorService)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		Guid idTypeUid = metadata.get_IdTypeUid();
		if (idTypeUid == Guid.Empty)
		{
			return new ValueTuple<PropertyMetadata, ITypeDescriptor>((PropertyMetadata)null, (ITypeDescriptor)null);
		}
		ITypeDescriptor typeDescriptor = descriptorService.GetTypeDescriptor(idTypeUid, Guid.Empty);
		if (typeDescriptor == null)
		{
			return new ValueTuple<PropertyMetadata, ITypeDescriptor>((PropertyMetadata)null, (ITypeDescriptor)null);
		}
		object obj = InterfaceCreator.Create(typeDescriptor.SettingsType);
		TypeSettings val = (TypeSettings)((obj is TypeSettings) ? obj : null);
		if (val == null)
		{
			return new ValueTuple<PropertyMetadata, ITypeDescriptor>((PropertyMetadata)null, (ITypeDescriptor)null);
		}
		PropertyMetadata obj2 = InterfaceCreator.Create<PropertyMetadata>();
		((IPropertyMetadata)obj2).set_Settings(val);
		((INamedMetadata)obj2).set_Name("Id");
		return new ValueTuple<PropertyMetadata, ITypeDescriptor>(obj2, typeDescriptor);
	}

	public static System.Collections.Generic.IEnumerable<PropertyMetadata> GetEqlComputedProperties(this ClassMetadata classMetadata)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
		ParameterExpression val = Expression.Parameter(typeof(PropertyMetadata), "q");
		CS_0024_003C_003E8__locals0.computedEqlQueryExpression = DynamicPropertyHelper<PropertyMetadata>.GetExpression<string>(Expression.Lambda<Func<PropertyMetadata, string>>((Expression)(object)Expression.Property((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(EntitySettings)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		return (System.Collections.Generic.IEnumerable<PropertyMetadata>)Enumerable.Where<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)classMetadata.get_Properties(), (Func<PropertyMetadata, bool>)delegate(PropertyMetadata p)
		{
			ViewModelPropertyMetadata val2;
			EntitySettings val3;
			if ((val2 = (ViewModelPropertyMetadata)(object)((p is ViewModelPropertyMetadata) ? p : null)) != null && (val3 = (EntitySettings)/*isinst with value type is only supported in some contexts*/) != null && val3.get_IsComputedEqlValue())
			{
				ComputedValue val4 = Enumerable.FirstOrDefault<ComputedValue>((System.Collections.Generic.IEnumerable<ComputedValue>)val2.get_ComputedValues(), (Func<ComputedValue, bool>)((ComputedValue a) => a.get_Name() == CS_0024_003C_003E8__locals0.computedEqlQueryExpression));
				if (val4 != null && val4.get_ComputedValueType() != 0)
				{
					return true;
				}
				return !string.IsNullOrWhiteSpace(val3.get_ComputedEqlQuery());
			}
			return false;
		});
	}

	public static System.Collections.Generic.IEnumerable<PropertyMetadata> GetPropertiesWithInclude(this DataClassMetadata dataClassMetadata, IMetadataServiceContext metadataService)
	{
		PropertyMetadata[] array = (PropertyMetadata[])(object)new PropertyMetadata[0];
		if (dataClassMetadata == null || metadataService == null)
		{
			return array;
		}
		FillPropertiesWithInclude(array, dataClassMetadata, metadataService);
		System.Collections.Generic.IEnumerator<PropertyMetadata> enumerator = ((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)dataClassMetadata).get_Properties()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				PropertyMetadata current = enumerator.get_Current();
				ArrayExtensions.Push<PropertyMetadata>(array, (PropertyMetadata[])(object)new PropertyMetadata[1] { current });
			}
			return array;
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<PropertyMetadata>> GetPropertiesWithIncludeAsync(this DataClassMetadata dataClassMetadata, IMetadataServiceContext metadataService)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CGetPropertiesWithIncludeAsync_003Ed__11 _003CGetPropertiesWithIncludeAsync_003Ed__ = default(_003CGetPropertiesWithIncludeAsync_003Ed__11);
		_003CGetPropertiesWithIncludeAsync_003Ed__.dataClassMetadata = dataClassMetadata;
		_003CGetPropertiesWithIncludeAsync_003Ed__.metadataService = metadataService;
		_003CGetPropertiesWithIncludeAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<PropertyMetadata>>.Create();
		_003CGetPropertiesWithIncludeAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<PropertyMetadata>> _003C_003Et__builder = _003CGetPropertiesWithIncludeAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetPropertiesWithIncludeAsync_003Ed__11>(ref _003CGetPropertiesWithIncludeAsync_003Ed__);
		return _003CGetPropertiesWithIncludeAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	public static System.Type GetTypeFromModule(this ICodeItemMetadata metadata, object moduleObject)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		Contract.ArgumentNotNull(moduleObject, "moduleObject");
		string[] array = metadata.get_Namespace().Split(new char[1] { '.' });
		for (int i = 0; i < array.Length; i++)
		{
			moduleObject = moduleObject.get_Item(array[i]);
		}
		return ObjectExtensions.As<System.Type>(moduleObject.get_Item(((INamedMetadata)metadata).get_Name()));
	}

	public static bool IsDataClassTableProperty(this IPropertyMetadata property)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		DataClassSettings val;
		if (property != null && property.get_TypeUid() == DataClassDescriptor.UID && (val = (DataClassSettings)/*isinst with value type is only supported in some contexts*/) != null && val.get_RelationType() == 2)
		{
			return val.get_DisplayType() == 1;
		}
		return false;
	}

	internal static bool CanBeInput(IMetadata rootMetadata, ViewModelPropertyMetadata property)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals0.property = property;
		if (rootMetadata is PortletComponentMetadata)
		{
			return false;
		}
		ComponentMetadata val = (ComponentMetadata)(object)((rootMetadata is ComponentMetadata) ? rootMetadata : null);
		if (val == null)
		{
			return false;
		}
		if (((IPropertyMetadata)CS_0024_003C_003E8__locals0.property).get_TypeUid() == DataClassDescriptor.UID)
		{
			if (rootMetadata is PageComponentMetadata)
			{
				return false;
			}
			if (Enumerable.Any<DataClassMetadata>((System.Collections.Generic.IEnumerable<DataClassMetadata>)val.get_DataClasses(), (Func<DataClassMetadata, bool>)((DataClassMetadata d) => ((IMetadata)d).get_Uid() == ((IPropertyMetadata)CS_0024_003C_003E8__locals0.property).get_SubTypeUid())))
			{
				return false;
			}
		}
		ActionSettings val2;
		if (((IPropertyMetadata)CS_0024_003C_003E8__locals0.property).get_TypeUid() == ActionDescriptor.UID && (val2 = (ActionSettings)/*isinst with value type is only supported in some contexts*/) != null)
		{
			_003C_003Ec__DisplayClass14_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass14_1();
			CS_0024_003C_003E8__locals1.parameterTypeSubTypeUid = val2.get_ParameterType().get_SubTypeUid();
			if (CS_0024_003C_003E8__locals1.parameterTypeSubTypeUid != Guid.Empty && Enumerable.Any<DataClassMetadata>((System.Collections.Generic.IEnumerable<DataClassMetadata>)val.get_DataClasses(), (Func<DataClassMetadata, bool>)((DataClassMetadata d) => ((IMetadata)d).get_Uid() == CS_0024_003C_003E8__locals1.parameterTypeSubTypeUid)))
			{
				return false;
			}
			CS_0024_003C_003E8__locals1.returnTypeSubTypeUid = val2.get_ReturnType().get_SubTypeUid();
			if (CS_0024_003C_003E8__locals1.returnTypeSubTypeUid != Guid.Empty && Enumerable.Any<DataClassMetadata>((System.Collections.Generic.IEnumerable<DataClassMetadata>)val.get_DataClasses(), (Func<DataClassMetadata, bool>)((DataClassMetadata d) => ((IMetadata)d).get_Uid() == CS_0024_003C_003E8__locals1.returnTypeSubTypeUid)))
			{
				return false;
			}
		}
		if (CS_0024_003C_003E8__locals0.property.get_Output())
		{
			return false;
		}
		return true;
	}

	internal static bool CanBeOutput(IMetadata rootMetadata, ViewModelPropertyMetadata property)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
		CS_0024_003C_003E8__locals0.property = property;
		ComponentMetadata val = (ComponentMetadata)(object)((rootMetadata is ComponentMetadata) ? rootMetadata : null);
		if (val == null)
		{
			return false;
		}
		if (rootMetadata is PortletComponentMetadata)
		{
			return false;
		}
		if (rootMetadata is PageComponentMetadata)
		{
			return false;
		}
		if (CS_0024_003C_003E8__locals0.property.get_Input())
		{
			return false;
		}
		if (((IPropertyMetadata)CS_0024_003C_003E8__locals0.property).get_TypeUid() == ActionDescriptor.UID)
		{
			return false;
		}
		if (((IPropertyMetadata)CS_0024_003C_003E8__locals0.property).get_TypeUid() == DataClassDescriptor.UID && Enumerable.Any<DataClassMetadata>((System.Collections.Generic.IEnumerable<DataClassMetadata>)val.get_DataClasses(), (Func<DataClassMetadata, bool>)((DataClassMetadata d) => ((IMetadata)d).get_Uid() == ((IPropertyMetadata)CS_0024_003C_003E8__locals0.property).get_SubTypeUid())))
		{
			return false;
		}
		return true;
	}

	internal static System.Collections.Generic.IEnumerable<IMetadata> GetMetadataToRegister(IMetadata metadata)
	{
		EnumerableInstance<IMetadata> val = Enumerable.Empty<IMetadata>();
		ComponentMetadata val2;
		if ((val2 = (ComponentMetadata)(object)((metadata is ComponentMetadata) ? metadata : null)) != null)
		{
			val = val.Concat((System.Collections.Generic.IEnumerable<IMetadata>)val2.get_DataClasses()).Concat((System.Collections.Generic.IEnumerable<IMetadata>)(object)new ComponentContentMetadata[1] { val2.get_Content() }).Concat((System.Collections.Generic.IEnumerable<IMetadata>)(object)new ComponentContextMetadata[1] { val2.get_Content().get_Context() });
			PortletComponentMetadata val3;
			if ((val3 = (PortletComponentMetadata)(object)((val2 is PortletComponentMetadata) ? val2 : null)) != null)
			{
				val = val.Concat((System.Collections.Generic.IEnumerable<IMetadata>)(object)new PortletPersonalizationMetadata[1] { val3.get_PersonalizationContext() });
			}
		}
		ModuleInfoMetadata val4;
		if ((val4 = (ModuleInfoMetadata)(object)((metadata is ModuleInfoMetadata) ? metadata : null)) != null)
		{
			val = val.Concat((System.Collections.Generic.IEnumerable<IMetadata>)val4.get_DataClasses()).Concat((System.Collections.Generic.IEnumerable<IMetadata>)val4.get_Functions());
			System.Collections.Generic.IEnumerator<ComponentMetadata> enumerator = ((System.Collections.Generic.IEnumerable<ComponentMetadata>)val4.get_Components()).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					ComponentMetadata current = enumerator.get_Current();
					val = val.Concat((System.Collections.Generic.IEnumerable<IMetadata>)(object)new ComponentMetadata[1] { current }).Concat(GetMetadataToRegister((IMetadata)(object)current));
				}
				return (System.Collections.Generic.IEnumerable<IMetadata>)val;
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
		return (System.Collections.Generic.IEnumerable<IMetadata>)val;
	}

	internal static System.Threading.Tasks.Task<ValueTuple<DataClassMetadata, PropertyMetadata, ClassMetadata>> GetInfoInCaseViewModelContextAsync(IMetadataServiceContext metadataService, DataClassMetadata dataClassMetadata, Guid currentPropertyUid)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CGetInfoInCaseViewModelContextAsync_003Ed__17 _003CGetInfoInCaseViewModelContextAsync_003Ed__ = default(_003CGetInfoInCaseViewModelContextAsync_003Ed__17);
		_003CGetInfoInCaseViewModelContextAsync_003Ed__.metadataService = metadataService;
		_003CGetInfoInCaseViewModelContextAsync_003Ed__.dataClassMetadata = dataClassMetadata;
		_003CGetInfoInCaseViewModelContextAsync_003Ed__.currentPropertyUid = currentPropertyUid;
		_003CGetInfoInCaseViewModelContextAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ValueTuple<DataClassMetadata, PropertyMetadata, ClassMetadata>>.Create();
		_003CGetInfoInCaseViewModelContextAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ValueTuple<DataClassMetadata, PropertyMetadata, ClassMetadata>> _003C_003Et__builder = _003CGetInfoInCaseViewModelContextAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetInfoInCaseViewModelContextAsync_003Ed__17>(ref _003CGetInfoInCaseViewModelContextAsync_003Ed__);
		return _003CGetInfoInCaseViewModelContextAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	internal static ValueTuple<DataClassMetadata, PropertyMetadata, ClassMetadata> GetInfoInCaseViewModelContext(IMetadataServiceContext metadataService, DataClassMetadata dataClassMetadata, Guid currentPropertyUid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
		CS_0024_003C_003E8__locals0.currentPropertyUid = currentPropertyUid;
		DataClassMetadata val = dataClassMetadata;
		while (val.get_IncludeList().get_Count() == 1)
		{
			DataClassDependency val2 = Enumerable.First<DataClassDependency>((System.Collections.Generic.IEnumerable<DataClassDependency>)val.get_IncludeList());
			IMetadata metadata = metadataService.GetMetadata(((Dependency)val2).get_HeaderUid());
			DataClassMetadata val3 = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null);
			if (val3 == null)
			{
				return new ValueTuple<DataClassMetadata, PropertyMetadata, ClassMetadata>((DataClassMetadata)null, (PropertyMetadata)null, (ClassMetadata)null);
			}
			PropertyMetadata val4 = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)val3).get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata property) => ((IMetadata)property).get_Uid() == CS_0024_003C_003E8__locals0.currentPropertyUid));
			if (val4 != null)
			{
				IMetadata metadata2 = metadataService.GetMetadata(((IPropertyMetadata)val4).get_SubTypeUid());
				ClassMetadata val5 = (ClassMetadata)(object)((metadata2 is ClassMetadata) ? metadata2 : null);
				return new ValueTuple<DataClassMetadata, PropertyMetadata, ClassMetadata>(val3, val4, val5);
			}
			val = val3;
		}
		return new ValueTuple<DataClassMetadata, PropertyMetadata, ClassMetadata>((DataClassMetadata)null, (PropertyMetadata)null, (ClassMetadata)null);
	}

	internal static IPropertyMetadata GetProperty(IMetadataServiceContext metadataService, ClassMetadata metadata, Guid propertyUid, Guid[] parents)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (propertyUid == Guid.Empty || metadataService == null)
		{
			return null;
		}
		IPropertyMetadata property = metadataService.GetProperty(metadata, propertyUid);
		if (property != null)
		{
			return property;
		}
		IPropertyMetadata[] array = Enumerable.ToArray<IPropertyMetadata>(metadataService.GetProperties(metadata, includeBase: true));
		if (array.Length == 0)
		{
			return null;
		}
		Guid[] parents2 = Enumerable.Concat<Guid>((System.Collections.Generic.IEnumerable<Guid>)parents, (System.Collections.Generic.IEnumerable<Guid>)(object)new Guid[1] { propertyUid }).ToArray();
		return GetProperty(metadataService, array, parents2);
	}

	internal static IPropertyMetadata GetProperty(IMetadataServiceContext metadataService, System.Collections.Generic.IEnumerable<IPropertyMetadata> properties, Guid propertyUid, Guid[] parents)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (propertyUid == Guid.Empty || metadataService == null)
		{
			return null;
		}
		IPropertyMetadata[] array = Enumerable.ToArray<IPropertyMetadata>(properties);
		if (array.Length == 0)
		{
			return null;
		}
		Guid[] parents2 = Enumerable.Concat<Guid>((System.Collections.Generic.IEnumerable<Guid>)parents, (System.Collections.Generic.IEnumerable<Guid>)(object)new Guid[1] { propertyUid }).ToArray();
		return GetProperty(metadataService, array, parents2);
	}

	internal static IPropertyMetadata GetProperty(IMetadataServiceContext metadataService, System.Collections.Generic.IEnumerable<IPropertyMetadata> properties, Guid[] parents)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (metadataService == null)
		{
			return null;
		}
		IPropertyMetadata[] array = Enumerable.ToArray<IPropertyMetadata>(properties);
		if (array.Length == 0)
		{
			return null;
		}
		IPropertyMetadata val = null;
		ClassMetadata val2 = null;
		for (int j = 0; j < parents.Length; j++)
		{
			_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass21_0();
			CS_0024_003C_003E8__locals0.parent = parents[j];
			if (val2 == null)
			{
				val = Enumerable.FirstOrDefault<IPropertyMetadata>((System.Collections.Generic.IEnumerable<IPropertyMetadata>)array, (Func<IPropertyMetadata, bool>)((IPropertyMetadata a) => ((IMetadata)a).get_Uid() == CS_0024_003C_003E8__locals0.parent));
				if (val == null)
				{
					break;
				}
				IMetadata metadata = metadataService.GetMetadata(val.get_SubTypeUid());
				val2 = (ClassMetadata)(object)((metadata is ClassMetadata) ? metadata : null);
				continue;
			}
			val = metadataService.GetProperty(val2, CS_0024_003C_003E8__locals0.parent);
			if (val == null)
			{
				DataClassMetadata val3;
				if ((val3 = (DataClassMetadata)(object)((val2 is DataClassMetadata) ? val2 : null)) == null)
				{
					break;
				}
				DataClassDependency val4 = Enumerable.FirstOrDefault<DataClassDependency>((System.Collections.Generic.IEnumerable<DataClassDependency>)val3.get_IncludeList(), (Func<DataClassDependency, bool>)((DataClassDependency i) => ((Dependency)i).get_HeaderUid() == CS_0024_003C_003E8__locals0.parent));
				if (val4 == null)
				{
					break;
				}
				IMetadata metadata2 = metadataService.GetMetadata(((Dependency)val4).get_HeaderUid());
				val2 = (ClassMetadata)(object)((metadata2 is ClassMetadata) ? metadata2 : null);
				if (!(val2 is DataClassMetadata))
				{
					break;
				}
			}
			else
			{
				TablePartMetadata val5;
				val2 = (ClassMetadata)(((val5 = (TablePartMetadata)(object)((val is TablePartMetadata) ? val : null)) == null) ? ((object)/*isinst with value type is only supported in some contexts*/) : ((object)val5));
				if (val2 == null)
				{
					break;
				}
			}
		}
		return val;
	}

	internal static ValueTuple<IPropertyMetadata, ClassMetadata> GetPropertyWithOwner(IMetadataServiceContext metadataService, ClassMetadata metadata, Guid propertyUid, Guid[] parents)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (propertyUid == Guid.Empty || metadataService == null)
		{
			return new ValueTuple<IPropertyMetadata, ClassMetadata>((IPropertyMetadata)null, (ClassMetadata)null);
		}
		ValueTuple<ClassMetadata, IPropertyMetadata> propertyWithOwner = metadataService.GetPropertyWithOwner(metadata, propertyUid);
		ClassMetadata item = propertyWithOwner.Item1;
		IPropertyMetadata item2 = propertyWithOwner.Item2;
		if (item2 != null)
		{
			return new ValueTuple<IPropertyMetadata, ClassMetadata>(item2, item);
		}
		IPropertyMetadata[] array = Enumerable.ToArray<IPropertyMetadata>(metadataService.GetProperties(metadata, includeBase: true));
		if (array.Length == 0)
		{
			return new ValueTuple<IPropertyMetadata, ClassMetadata>((IPropertyMetadata)null, (ClassMetadata)null);
		}
		Guid[] parents2 = Enumerable.Concat<Guid>((System.Collections.Generic.IEnumerable<Guid>)parents, (System.Collections.Generic.IEnumerable<Guid>)(object)new Guid[1] { propertyUid }).ToArray();
		return GetPropertyWithOwner(metadataService, array, parents2);
	}

	internal static ValueTuple<IPropertyMetadata, ClassMetadata> GetPropertyWithOwner(IMetadataServiceContext metadataService, System.Collections.Generic.IEnumerable<IPropertyMetadata> properties, Guid propertyUid, Guid[] parents)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if (propertyUid == Guid.Empty || metadataService == null)
		{
			return new ValueTuple<IPropertyMetadata, ClassMetadata>((IPropertyMetadata)null, (ClassMetadata)null);
		}
		IPropertyMetadata[] array = Enumerable.ToArray<IPropertyMetadata>(properties);
		if (array.Length == 0)
		{
			return new ValueTuple<IPropertyMetadata, ClassMetadata>((IPropertyMetadata)null, (ClassMetadata)null);
		}
		Guid[] parents2 = Enumerable.Concat<Guid>((System.Collections.Generic.IEnumerable<Guid>)parents, (System.Collections.Generic.IEnumerable<Guid>)(object)new Guid[1] { propertyUid }).ToArray();
		return GetPropertyWithOwner(metadataService, array, parents2);
	}

	internal static ValueTuple<IPropertyMetadata, ClassMetadata> GetPropertyWithOwner(IMetadataServiceContext metadataService, System.Collections.Generic.IEnumerable<IPropertyMetadata> properties, Guid[] parents)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		if (metadataService == null)
		{
			return new ValueTuple<IPropertyMetadata, ClassMetadata>((IPropertyMetadata)null, (ClassMetadata)null);
		}
		IPropertyMetadata[] array = Enumerable.ToArray<IPropertyMetadata>(properties);
		if (array.Length == 0)
		{
			return new ValueTuple<IPropertyMetadata, ClassMetadata>((IPropertyMetadata)null, (ClassMetadata)null);
		}
		IPropertyMetadata val = null;
		ClassMetadata val2 = null;
		for (int i = 0; i < parents.Length; i++)
		{
			_003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass24_0();
			CS_0024_003C_003E8__locals0.parent = parents[i];
			if (val2 == null)
			{
				val = Enumerable.FirstOrDefault<IPropertyMetadata>((System.Collections.Generic.IEnumerable<IPropertyMetadata>)array, (Func<IPropertyMetadata, bool>)((IPropertyMetadata a) => ((IMetadata)a).get_Uid() == CS_0024_003C_003E8__locals0.parent));
				if (val == null)
				{
					break;
				}
				IMetadata metadata = metadataService.GetMetadata(val.get_SubTypeUid());
				val2 = (ClassMetadata)(object)((metadata is ClassMetadata) ? metadata : null);
				continue;
			}
			val = metadataService.GetProperty(val2, CS_0024_003C_003E8__locals0.parent);
			if (val == null)
			{
				DataClassMetadata val3;
				if ((val3 = (DataClassMetadata)(object)((val2 is DataClassMetadata) ? val2 : null)) == null)
				{
					break;
				}
				DataClassDependency val4 = Enumerable.FirstOrDefault<DataClassDependency>((System.Collections.Generic.IEnumerable<DataClassDependency>)val3.get_IncludeList(), (Func<DataClassDependency, bool>)((DataClassDependency inc) => ((Dependency)inc).get_HeaderUid() == CS_0024_003C_003E8__locals0.parent));
				if (val4 == null)
				{
					break;
				}
				IMetadata metadata2 = metadataService.GetMetadata(((Dependency)val4).get_HeaderUid());
				val2 = (ClassMetadata)(object)((metadata2 is ClassMetadata) ? metadata2 : null);
				if (!(val2 is DataClassMetadata))
				{
					break;
				}
			}
			else
			{
				if (i == parents.Length - 1)
				{
					break;
				}
				IMetadata metadata3 = metadataService.GetMetadata(val.get_SubTypeUid());
				val2 = (ClassMetadata)(object)((metadata3 is ClassMetadata) ? metadata3 : null);
				if (val2 == null)
				{
					break;
				}
			}
		}
		return new ValueTuple<IPropertyMetadata, ClassMetadata>(val, val2);
	}

	internal static System.Threading.Tasks.Task<ValueTuple<IPropertyMetadata, ClassMetadata>> GetPropertyWithOwnerAsync(IMetadataServiceContext metadataService, ClassMetadata metadata, Guid propertyUid, Guid[] parents)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (propertyUid == Guid.Empty || metadataService == null)
		{
			return System.Threading.Tasks.Task.FromResult<ValueTuple<IPropertyMetadata, ClassMetadata>>(new ValueTuple<IPropertyMetadata, ClassMetadata>((IPropertyMetadata)null, (ClassMetadata)null));
		}
		ValueTuple<ClassMetadata, IPropertyMetadata> propertyWithOwner = metadataService.GetPropertyWithOwner(metadata, propertyUid);
		ClassMetadata item = propertyWithOwner.Item1;
		IPropertyMetadata item2 = propertyWithOwner.Item2;
		if (item2 != null)
		{
			return System.Threading.Tasks.Task.FromResult<ValueTuple<IPropertyMetadata, ClassMetadata>>(new ValueTuple<IPropertyMetadata, ClassMetadata>(item2, item));
		}
		IPropertyMetadata[] array = Enumerable.ToArray<IPropertyMetadata>(metadataService.GetProperties(metadata, includeBase: true));
		if (array.Length == 0)
		{
			return System.Threading.Tasks.Task.FromResult<ValueTuple<IPropertyMetadata, ClassMetadata>>(new ValueTuple<IPropertyMetadata, ClassMetadata>((IPropertyMetadata)null, (ClassMetadata)null));
		}
		Guid[] parents2 = Enumerable.Concat<Guid>((System.Collections.Generic.IEnumerable<Guid>)parents, (System.Collections.Generic.IEnumerable<Guid>)(object)new Guid[1] { propertyUid }).ToArray();
		return GetPropertyWithOwnerAsync(metadataService, array, parents2);
	}

	internal static System.Threading.Tasks.Task<ValueTuple<IPropertyMetadata, ClassMetadata>> GetPropertyWithOwnerAsync(IMetadataServiceContext metadataService, System.Collections.Generic.IEnumerable<IPropertyMetadata> properties, Guid[] parents)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CGetPropertyWithOwnerAsync_003Ed__26 _003CGetPropertyWithOwnerAsync_003Ed__ = default(_003CGetPropertyWithOwnerAsync_003Ed__26);
		_003CGetPropertyWithOwnerAsync_003Ed__.metadataService = metadataService;
		_003CGetPropertyWithOwnerAsync_003Ed__.properties = properties;
		_003CGetPropertyWithOwnerAsync_003Ed__.parents = parents;
		_003CGetPropertyWithOwnerAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ValueTuple<IPropertyMetadata, ClassMetadata>>.Create();
		_003CGetPropertyWithOwnerAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ValueTuple<IPropertyMetadata, ClassMetadata>> _003C_003Et__builder = _003CGetPropertyWithOwnerAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetPropertyWithOwnerAsync_003Ed__26>(ref _003CGetPropertyWithOwnerAsync_003Ed__);
		return _003CGetPropertyWithOwnerAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	internal static System.Threading.Tasks.Task<IPropertyMetadata> GetPropertyAsync(IMetadataServiceContext metadataService, ClassMetadata metadata, Guid propertyUid, Guid[] parents)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (propertyUid == Guid.Empty || metadataService == null)
		{
			return System.Threading.Tasks.Task.FromResult<IPropertyMetadata>((IPropertyMetadata)null);
		}
		IPropertyMetadata property = metadataService.GetProperty(metadata, propertyUid);
		if (property != null)
		{
			return System.Threading.Tasks.Task.FromResult<IPropertyMetadata>(property);
		}
		IPropertyMetadata[] array = Enumerable.ToArray<IPropertyMetadata>(metadataService.GetProperties(metadata, includeBase: true));
		if (array.Length == 0)
		{
			return System.Threading.Tasks.Task.FromResult<IPropertyMetadata>((IPropertyMetadata)null);
		}
		Guid[] parents2 = Enumerable.Concat<Guid>((System.Collections.Generic.IEnumerable<Guid>)parents, (System.Collections.Generic.IEnumerable<Guid>)(object)new Guid[1] { propertyUid }).ToArray();
		return GetPropertyAsync(metadataService, array, parents2);
	}

	internal static System.Threading.Tasks.Task<IPropertyMetadata> GetPropertyAsync(IMetadataServiceContext metadataService, System.Collections.Generic.IEnumerable<IPropertyMetadata> properties, Guid propertyUid, Guid[] parents)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (propertyUid == Guid.Empty || metadataService == null)
		{
			return System.Threading.Tasks.Task.FromResult<IPropertyMetadata>((IPropertyMetadata)null);
		}
		IPropertyMetadata[] array = Enumerable.ToArray<IPropertyMetadata>(properties);
		if (array.Length == 0)
		{
			return System.Threading.Tasks.Task.FromResult<IPropertyMetadata>((IPropertyMetadata)null);
		}
		Guid[] parents2 = Enumerable.Concat<Guid>((System.Collections.Generic.IEnumerable<Guid>)parents, (System.Collections.Generic.IEnumerable<Guid>)(object)new Guid[1] { propertyUid }).ToArray();
		return GetPropertyAsync(metadataService, array, parents2);
	}

	internal static System.Threading.Tasks.Task<IPropertyMetadata> GetPropertyAsync(IMetadataServiceContext metadataService, System.Collections.Generic.IEnumerable<IPropertyMetadata> properties, string parents)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		string[] array = parents.Split(new char[1] { '_' });
		Guid[] array2 = (Guid[])(object)new Guid[0];
		for (int i = 0; i < array.Length; i++)
		{
			ArrayExtensions.Push<Guid>(array2, (Guid[])(object)new Guid[1]
			{
				new Guid(array[i])
			});
		}
		return GetPropertyAsync(metadataService, properties, array2);
	}

	internal static System.Threading.Tasks.Task<IPropertyMetadata> GetPropertyAsync(IMetadataServiceContext metadataService, System.Collections.Generic.IEnumerable<IPropertyMetadata> properties, Guid[] parents)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CGetPropertyAsync_003Ed__30 _003CGetPropertyAsync_003Ed__ = default(_003CGetPropertyAsync_003Ed__30);
		_003CGetPropertyAsync_003Ed__.metadataService = metadataService;
		_003CGetPropertyAsync_003Ed__.properties = properties;
		_003CGetPropertyAsync_003Ed__.parents = parents;
		_003CGetPropertyAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<IPropertyMetadata>.Create();
		_003CGetPropertyAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IPropertyMetadata> _003C_003Et__builder = _003CGetPropertyAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetPropertyAsync_003Ed__30>(ref _003CGetPropertyAsync_003Ed__);
		return _003CGetPropertyAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	internal static TablePartMetadata FindTablePart(EntityMetadata entityMetadata, Guid propertyUid)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		System.Collections.Generic.IEnumerator<TablePartMetadata> enumerator = ((System.Collections.Generic.IEnumerable<TablePartMetadata>)entityMetadata.get_TableParts()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				TablePartMetadata current = enumerator.get_Current();
				if (current.get_TablePartPropertyUid() == propertyUid)
				{
					return current;
				}
				TablePartMetadata val = FindTablePart((EntityMetadata)(object)current, propertyUid);
				if (val != null)
				{
					return val;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return null;
	}

	internal static ValueTuple<EntityMetadata, IPropertyMetadata> FindTablePartOrProperty(EntityMetadata entityMetadata, Guid propertyUid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass32_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass32_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		System.Collections.Generic.IEnumerator<TablePartMetadata> enumerator = ((System.Collections.Generic.IEnumerable<TablePartMetadata>)entityMetadata.get_TableParts()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				TablePartMetadata current = enumerator.get_Current();
				if (current.get_TablePartPropertyUid() == CS_0024_003C_003E8__locals0.propertyUid)
				{
					return new ValueTuple<EntityMetadata, IPropertyMetadata>(entityMetadata, (IPropertyMetadata)(object)current);
				}
				PropertyMetadata val = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)current).get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata a) => ((IMetadata)a).get_Uid() == CS_0024_003C_003E8__locals0.propertyUid));
				if (val != null)
				{
					return new ValueTuple<EntityMetadata, IPropertyMetadata>((EntityMetadata)(object)current, (IPropertyMetadata)(object)val);
				}
				ValueTuple<EntityMetadata, IPropertyMetadata> val2 = FindTablePartOrProperty((EntityMetadata)(object)current, CS_0024_003C_003E8__locals0.propertyUid);
				EntityMetadata item = val2.Item1;
				IPropertyMetadata item2 = val2.Item2;
				if (item2 != null)
				{
					return new ValueTuple<EntityMetadata, IPropertyMetadata>(item, item2);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return new ValueTuple<EntityMetadata, IPropertyMetadata>((EntityMetadata)null, (IPropertyMetadata)null);
	}

	internal static string GetInputName(string propertyName)
	{
		return "Input___" + propertyName;
	}

	internal static string GetOutputName(string propertyName)
	{
		return "Output___" + propertyName;
	}

	private static System.Threading.Tasks.Task FillPropertiesWithIncludeAsync(PropertyMetadata[] properties, DataClassMetadata dataClassMetadata, IMetadataServiceContext metadataService)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CFillPropertiesWithIncludeAsync_003Ed__35 _003CFillPropertiesWithIncludeAsync_003Ed__ = default(_003CFillPropertiesWithIncludeAsync_003Ed__35);
		_003CFillPropertiesWithIncludeAsync_003Ed__.properties = properties;
		_003CFillPropertiesWithIncludeAsync_003Ed__.dataClassMetadata = dataClassMetadata;
		_003CFillPropertiesWithIncludeAsync_003Ed__.metadataService = metadataService;
		_003CFillPropertiesWithIncludeAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CFillPropertiesWithIncludeAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CFillPropertiesWithIncludeAsync_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CFillPropertiesWithIncludeAsync_003Ed__35>(ref _003CFillPropertiesWithIncludeAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CFillPropertiesWithIncludeAsync_003Ed__._003C_003Et__builder)).get_Task();
	}

	private static void FillPropertiesWithInclude(PropertyMetadata[] properties, DataClassMetadata dataClassMetadata, IMetadataServiceContext metadataService)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		System.Collections.Generic.IEnumerator<DataClassDependency> enumerator = ((System.Collections.Generic.IEnumerable<DataClassDependency>)dataClassMetadata.get_IncludeList()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				DataClassDependency current = enumerator.get_Current();
				IMetadata metadata = metadataService.GetMetadata(((Dependency)current).get_HeaderUid());
				DataClassMetadata val = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null);
				if (val == null)
				{
					continue;
				}
				FillPropertiesWithInclude(properties, val, metadataService);
				System.Collections.Generic.IEnumerator<PropertyMetadata> enumerator2 = ((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)val).get_Properties()).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						PropertyMetadata current2 = enumerator2.get_Current();
						ArrayExtensions.Push<PropertyMetadata>(properties, (PropertyMetadata[])(object)new PropertyMetadata[1] { current2 });
					}
				}
				finally
				{
					((System.IDisposable)enumerator2)?.Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}
}
