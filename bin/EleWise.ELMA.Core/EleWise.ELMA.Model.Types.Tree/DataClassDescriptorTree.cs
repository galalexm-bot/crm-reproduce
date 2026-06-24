using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Helpers;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Managers;

namespace EleWise.ELMA.Model.Types.Tree;

[Component(Order = 650)]
internal class DataClassDescriptorTree : TypeDescriptorTree
{
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public Guid moduleUid;

		internal bool _003CGetSubTypes_003Eb__1(MetadataHeader m)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			if (!(m.get_ModuleUid() == moduleUid))
			{
				return !m.get_Internal();
			}
			return true;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<MetadataHeader, bool> _003C_003E9__4_0;

		public static Func<MetadataHeader, bool> _003C_003E9__4_2;

		public static Func<MetadataHeader, string> _003C_003E9__4_3;

		internal bool _003CGetSubTypes_003Eb__4_0(MetadataHeader a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return a.get_MetadataType() == MetadataConstants.DataClassMetadataTypeUid;
		}

		internal bool _003CGetSubTypes_003Eb__4_2(MetadataHeader m)
		{
			return !m.get_Internal();
		}

		internal string _003CGetSubTypes_003Eb__4_3(MetadataHeader m)
		{
			return m.get_DisplayName();
		}
	}

	[StructLayout(3)]
	private struct _003CGetSubTypes_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ITypeDescriptor>> _003C_003Et__builder;

		public DataClassDescriptorTree _003C_003E4__this;

		public ITypeDescriptorTreeFilterModel filterModel;

		public ITypeDescriptor typeDescriptor;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			DataClassDescriptorTree dataClassDescriptorTree = _003C_003E4__this;
			System.Collections.Generic.IEnumerable<ITypeDescriptor> result;
			try
			{
				TaskAwaiter<System.Collections.Generic.IEnumerable<ITypeDescriptor>> val2;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
					EnumerableInstance<MetadataHeader> val = Enumerable.Where<MetadataHeader>(dataClassDescriptorTree.metadataService.GetMetadataHeaders(filterModel.WithDrafts), (Func<MetadataHeader, bool>)((MetadataHeader a) => a.get_MetadataType() == MetadataConstants.DataClassMetadataTypeUid));
					IMetadata metadata = filterModel.Metadata;
					IMetadata rootMetadata = filterModel.RootMetadata;
					CS_0024_003C_003E8__locals0.moduleUid = Guid.Empty;
					if (rootMetadata != null)
					{
						CS_0024_003C_003E8__locals0.moduleUid = rootMetadata.get_ModuleUid();
					}
					else if (metadata != null)
					{
						CS_0024_003C_003E8__locals0.moduleUid = metadata.get_ModuleUid();
					}
					val2 = CompositeTypeDescriptorHelper.GetDescriptorsByGroups(metadataList: (System.Collections.Generic.IEnumerable<MetadataHeader>)((!(CS_0024_003C_003E8__locals0.moduleUid != Guid.Empty)) ? val.Where((Func<MetadataHeader, bool>)((MetadataHeader m) => !m.get_Internal())) : val.Where((Func<MetadataHeader, bool>)((MetadataHeader m) => m.get_ModuleUid() == CS_0024_003C_003E8__locals0.moduleUid || !m.get_Internal()))).OrderBy<string>((Func<MetadataHeader, string>)((MetadataHeader m) => m.get_DisplayName())), baseTypeDescriptor: typeDescriptor, metadataItemGroupManager: dataClassDescriptorTree.metadataItemGroupManager, metadataService: dataClassDescriptorTree.metadataService).GetAwaiter();
					if (!val2.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val2;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.IEnumerable<ITypeDescriptor>>, _003CGetSubTypes_003Ed__4>(ref val2, ref this);
						return;
					}
				}
				else
				{
					val2 = (TaskAwaiter<System.Collections.Generic.IEnumerable<ITypeDescriptor>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				result = val2.GetResult();
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

	private readonly IMetadataServiceContext metadataService;

	private readonly MetadataItemGroupManager metadataItemGroupManager;

	public DataClassDescriptorTree(IMetadataServiceContext metadataService, MetadataItemGroupManager metadataItemGroupManager)
	{
		this.metadataService = metadataService;
		this.metadataItemGroupManager = metadataItemGroupManager;
	}

	public override bool CanBuildTree(ITypeDescriptor typeDescriptor)
	{
		return typeDescriptor is DataClassDescriptor;
	}

	public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ITypeDescriptor>> GetSubTypes(ITypeDescriptor typeDescriptor, ITypeDescriptorTreeFilterModel filterModel)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CGetSubTypes_003Ed__4 _003CGetSubTypes_003Ed__ = default(_003CGetSubTypes_003Ed__4);
		_003CGetSubTypes_003Ed__._003C_003E4__this = this;
		_003CGetSubTypes_003Ed__.typeDescriptor = typeDescriptor;
		_003CGetSubTypes_003Ed__.filterModel = filterModel;
		_003CGetSubTypes_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ITypeDescriptor>>.Create();
		_003CGetSubTypes_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ITypeDescriptor>> _003C_003Et__builder = _003CGetSubTypes_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetSubTypes_003Ed__4>(ref _003CGetSubTypes_003Ed__);
		return _003CGetSubTypes_003Ed__._003C_003Et__builder.get_Task();
	}
}
