using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Managers;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Core.Helpers;

public static class CompositeTypeDescriptorHelper
{
	[StructLayout(3)]
	private struct _003CGetDescriptorsByGroups_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ITypeDescriptor>> _003C_003Et__builder;

		public System.Collections.Generic.IEnumerable<MetadataHeader> metadataList;

		public MetadataItemGroupManager metadataItemGroupManager;

		public IMetadataServiceContext metadataService;

		public ITypeDescriptor baseTypeDescriptor;

		private List<ITypeDescriptor> _003CrootDescriptors_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			System.Collections.Generic.IEnumerable<ITypeDescriptor> result2;
			try
			{
				TaskAwaiter<MetadataTreeHelper.GroupNode> val;
				if (num != 0)
				{
					_003CrootDescriptors_003E5__2 = new List<ITypeDescriptor>();
					val = MetadataTreeHelper.BuildTree(metadataList, metadataItemGroupManager, metadataService).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<MetadataTreeHelper.GroupNode>, _003CGetDescriptorsByGroups_003Ed__0>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<MetadataTreeHelper.GroupNode>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				MetadataTreeHelper.GroupNode result = val.GetResult();
				FillDescriptors(baseTypeDescriptor, (System.Collections.Generic.ICollection<ITypeDescriptor>)_003CrootDescriptors_003E5__2, result);
				result2 = (System.Collections.Generic.IEnumerable<ITypeDescriptor>)_003CrootDescriptors_003E5__2;
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<MetadataTreeHelper.MetadataNode, MetadataHeader> _003C_003E9__1_0;

		internal MetadataHeader _003CFillDescriptors_003Eb__1_0(MetadataTreeHelper.MetadataNode m)
		{
			return m.Metadata;
		}
	}

	public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ITypeDescriptor>> GetDescriptorsByGroups(ITypeDescriptor baseTypeDescriptor, System.Collections.Generic.IEnumerable<MetadataHeader> metadataList, MetadataItemGroupManager metadataItemGroupManager, IMetadataServiceContext metadataService)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		_003CGetDescriptorsByGroups_003Ed__0 _003CGetDescriptorsByGroups_003Ed__ = default(_003CGetDescriptorsByGroups_003Ed__0);
		_003CGetDescriptorsByGroups_003Ed__.baseTypeDescriptor = baseTypeDescriptor;
		_003CGetDescriptorsByGroups_003Ed__.metadataList = metadataList;
		_003CGetDescriptorsByGroups_003Ed__.metadataItemGroupManager = metadataItemGroupManager;
		_003CGetDescriptorsByGroups_003Ed__.metadataService = metadataService;
		_003CGetDescriptorsByGroups_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ITypeDescriptor>>.Create();
		_003CGetDescriptorsByGroups_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ITypeDescriptor>> _003C_003Et__builder = _003CGetDescriptorsByGroups_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetDescriptorsByGroups_003Ed__0>(ref _003CGetDescriptorsByGroups_003Ed__);
		return _003CGetDescriptorsByGroups_003Ed__._003C_003Et__builder.get_Task();
	}

	private static void FillDescriptors(ITypeDescriptor baseTypeDescriptor, System.Collections.Generic.ICollection<ITypeDescriptor> descriptors, MetadataTreeHelper.GroupNode metadataGroup)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		System.Collections.Generic.IEnumerator<MetadataTreeHelper.GroupNode> enumerator = ((System.Collections.Generic.IEnumerable<MetadataTreeHelper.GroupNode>)metadataGroup.GroupNodes).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				MetadataTreeHelper.GroupNode current = enumerator.get_Current();
				SubTypeGroupDescriptor subTypeGroupDescriptor = new SubTypeGroupDescriptor(SR.T(current.Name), baseTypeDescriptor);
				descriptors.Add((ITypeDescriptor)subTypeGroupDescriptor);
				FillDescriptors(baseTypeDescriptor, (System.Collections.Generic.ICollection<ITypeDescriptor>)subTypeGroupDescriptor.SubTypes, current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		System.Collections.Generic.IEnumerator<MetadataHeader> enumerator2 = Enumerable.Select<MetadataTreeHelper.MetadataNode, MetadataHeader>((System.Collections.Generic.IEnumerable<MetadataTreeHelper.MetadataNode>)metadataGroup.MetadataNodes, (Func<MetadataTreeHelper.MetadataNode, MetadataHeader>)((MetadataTreeHelper.MetadataNode m) => m.Metadata)).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator2).MoveNext())
			{
				MetadataHeader current2 = enumerator2.get_Current();
				SubTypeDescriptor subTypeDescriptor = new SubTypeDescriptor(baseTypeDescriptor, current2.get_Uid(), current2.get_DisplayName());
				descriptors.Add((ITypeDescriptor)subTypeDescriptor);
			}
		}
		finally
		{
			((System.IDisposable)enumerator2)?.Dispose();
		}
	}
}
