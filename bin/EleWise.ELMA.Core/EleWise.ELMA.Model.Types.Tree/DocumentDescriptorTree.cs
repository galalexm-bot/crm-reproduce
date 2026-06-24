using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Services.Internal;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Helpers;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Managers;

namespace EleWise.ELMA.Model.Types.Tree;

[Component(Order = 399)]
internal sealed class DocumentDescriptorTree : EntityDescriptorTree
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public System.Collections.Generic.ICollection<Guid> activeUids;

		internal bool _003CGetSubTypes_003Eb__0(MetadataHeader m)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return activeUids.Contains(m.get_Uid());
		}
	}

	[StructLayout(3)]
	private struct _003CGetSubTypes_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ITypeDescriptor>> _003C_003Et__builder;

		public DocumentDescriptorTree _003C_003E4__this;

		public ITypeDescriptorTreeFilterModel filterModel;

		private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

		public ITypeDescriptor typeDescriptor;

		private MetadataHeader[] _003CmetadataList_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			DocumentDescriptorTree documentDescriptorTree = _003C_003E4__this;
			System.Collections.Generic.IEnumerable<ITypeDescriptor> result2;
			try
			{
				TaskAwaiter<System.Collections.Generic.IEnumerable<ITypeDescriptor>> val;
				TaskAwaiter<System.Collections.Generic.ICollection<Guid>> val2;
				if (num != 0)
				{
					if (num == 1)
					{
						val = (TaskAwaiter<System.Collections.Generic.IEnumerable<ITypeDescriptor>>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_016e;
					}
					_003CmetadataList_003E5__2 = Enumerable.ToArray<MetadataHeader>(documentDescriptorTree.GetSubTypes(filterModel));
					ITypeDescriptorTreeFilterModel typeDescriptorTreeFilterModel = filterModel;
					if (typeDescriptorTreeFilterModel == null || typeDescriptorTreeFilterModel.WithDeleted || _003CmetadataList_003E5__2.Length == 0)
					{
						goto IL_0103;
					}
					_003C_003E8__1 = new _003C_003Ec__DisplayClass3_0();
					val2 = documentDescriptorTree.documentMetadataHeadService.GetActiveDocumentTypeUids(MetadataConstants.EntityMetadataTypeUid).GetAwaiter();
					if (!val2.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val2;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.ICollection<Guid>>, _003CGetSubTypes_003Ed__3>(ref val2, ref this);
						return;
					}
				}
				else
				{
					val2 = (TaskAwaiter<System.Collections.Generic.ICollection<Guid>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				System.Collections.Generic.ICollection<Guid> result = val2.GetResult();
				_003C_003E8__1.activeUids = result;
				_003CmetadataList_003E5__2 = Enumerable.Where<MetadataHeader>((System.Collections.Generic.IEnumerable<MetadataHeader>)_003CmetadataList_003E5__2, (Func<MetadataHeader, bool>)((MetadataHeader m) => _003C_003E8__1.activeUids.Contains(m.get_Uid()))).ToArray();
				_003C_003E8__1 = null;
				goto IL_0103;
				IL_0103:
				val = CompositeTypeDescriptorHelper.GetDescriptorsByGroups(typeDescriptor, _003CmetadataList_003E5__2, documentDescriptorTree.metadataItemGroupManager, documentDescriptorTree.metadataService).GetAwaiter();
				if (!val.get_IsCompleted())
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = val;
					_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.IEnumerable<ITypeDescriptor>>, _003CGetSubTypes_003Ed__3>(ref val, ref this);
					return;
				}
				goto IL_016e;
				IL_016e:
				result2 = val.GetResult();
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

	private readonly IDocumentMetadataHeadService documentMetadataHeadService;

	public DocumentDescriptorTree(IMetadataServiceContext metadataService, MetadataItemGroupManager metadataItemGroupManager, IDocumentMetadataHeadService documentMetadataHeadService)
		: base(metadataService, metadataItemGroupManager)
	{
		this.documentMetadataHeadService = documentMetadataHeadService;
	}

	public override bool CanBuildTree(ITypeDescriptor typeDescriptor)
	{
		return typeDescriptor is DocumentTypeDescriptor;
	}

	public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ITypeDescriptor>> GetSubTypes(ITypeDescriptor typeDescriptor, ITypeDescriptorTreeFilterModel filterModel)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CGetSubTypes_003Ed__3 _003CGetSubTypes_003Ed__ = default(_003CGetSubTypes_003Ed__3);
		_003CGetSubTypes_003Ed__._003C_003E4__this = this;
		_003CGetSubTypes_003Ed__.typeDescriptor = typeDescriptor;
		_003CGetSubTypes_003Ed__.filterModel = filterModel;
		_003CGetSubTypes_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ITypeDescriptor>>.Create();
		_003CGetSubTypes_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ITypeDescriptor>> _003C_003Et__builder = _003CGetSubTypes_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetSubTypes_003Ed__3>(ref _003CGetSubTypes_003Ed__);
		return _003CGetSubTypes_003Ed__._003C_003Et__builder.get_Task();
	}

	internal override System.Collections.Generic.IEnumerable<MetadataHeader> GetSubTypes(ITypeDescriptorTreeFilterModel filterModel)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return EntityDescriptorTree.GetSubTypes(metadataService, filterModel, MetadataConstants.DocumentMetadataTypeUid);
	}
}
