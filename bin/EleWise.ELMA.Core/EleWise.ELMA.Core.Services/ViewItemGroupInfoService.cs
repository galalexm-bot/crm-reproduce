using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Services;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Views;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Core.Services;

[Service]
internal sealed class ViewItemGroupInfoService : IViewItemGroupInfoService
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public Guid groupUid;

		internal bool _003CLoadViewItemInfoList_003Eb__0(VisibleGroupInfo g)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return g.get_Uid() == groupUid;
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_1
	{
		public string displayName;

		internal bool _003CLoadViewItemInfoList_003Eb__1(VisibleViewItemInfo i)
		{
			return i.get_DisplayName() == displayName;
		}
	}

	[StructLayout(3)]
	private struct _003CLoadViewItemInfoList_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViewItemGroupInfoService _003C_003E4__this;

		public NamedMetadata[] metadataArray;

		private NamedMetadata[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ViewItemGroupInfoService viewItemGroupInfoService = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					viewItemGroupInfoService.visibleGroupInfos.Clear();
					_003C_003E7__wrap1 = metadataArray;
					_003C_003E7__wrap2 = 0;
					goto IL_0193;
				}
				TaskAwaiter<System.Collections.Generic.ICollection<VisibleGroupInfo>> val = (TaskAwaiter<System.Collections.Generic.ICollection<VisibleGroupInfo>>)_003C_003Eu__1;
				_003C_003Eu__1 = null;
				num = (_003C_003E1__state = -1);
				goto IL_009b;
				IL_009b:
				System.Collections.Generic.IEnumerator<VisibleGroupInfo> enumerator = ((System.Collections.Generic.IEnumerable<VisibleGroupInfo>)val.GetResult()).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						VisibleGroupInfo current = enumerator.get_Current();
						_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass3_0();
						CS_0024_003C_003E8__locals1.groupUid = current.get_Uid();
						VisibleGroupInfo val2 = Enumerable.FirstOrDefault<VisibleGroupInfo>((System.Collections.Generic.IEnumerable<VisibleGroupInfo>)viewItemGroupInfoService.visibleGroupInfos, (Func<VisibleGroupInfo, bool>)((VisibleGroupInfo g) => g.get_Uid() == CS_0024_003C_003E8__locals1.groupUid));
						if (val2 != null)
						{
							System.Collections.Generic.IEnumerator<VisibleViewItemInfo> enumerator2 = ((System.Collections.Generic.IEnumerable<VisibleViewItemInfo>)current.get_Items()).GetEnumerator();
							try
							{
								while (((System.Collections.IEnumerator)enumerator2).MoveNext())
								{
									VisibleViewItemInfo current2 = enumerator2.get_Current();
									_003C_003Ec__DisplayClass3_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_1();
									CS_0024_003C_003E8__locals0.displayName = current2.get_DisplayName();
									System.Collections.Generic.ICollection<VisibleViewItemInfo> items = val2.get_Items();
									if (Enumerable.FirstOrDefault<VisibleViewItemInfo>((System.Collections.Generic.IEnumerable<VisibleViewItemInfo>)items, (Func<VisibleViewItemInfo, bool>)((VisibleViewItemInfo i) => i.get_DisplayName() == CS_0024_003C_003E8__locals0.displayName)) == null)
									{
										items.Add(current2);
									}
								}
							}
							finally
							{
								if (num < 0)
								{
									((System.IDisposable)enumerator2)?.Dispose();
								}
							}
						}
						else
						{
							viewItemGroupInfoService.visibleGroupInfos.Add(current);
						}
					}
				}
				finally
				{
					if (num < 0)
					{
						((System.IDisposable)enumerator)?.Dispose();
					}
				}
				_003C_003E7__wrap2++;
				goto IL_0193;
				IL_0193:
				if (_003C_003E7__wrap2 < _003C_003E7__wrap1.Length)
				{
					NamedMetadata metadataDto = _003C_003E7__wrap1[_003C_003E7__wrap2];
					val = viewItemGroupInfoService.formViewItemService.FindVisibleGroupsAndViewItems(metadataDto).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.ICollection<VisibleGroupInfo>>, _003CLoadViewItemInfoList_003Ed__3>(ref val, ref this);
						return;
					}
					goto IL_009b;
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

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public string typeName;

		internal bool _003CGetInfoDisplayName_003Eb__1(VisibleViewItemInfo i)
		{
			return i.get_Name() == typeName;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<VisibleGroupInfo, System.Collections.Generic.IEnumerable<VisibleViewItemInfo>> _003C_003E9__5_0;

		internal System.Collections.Generic.IEnumerable<VisibleViewItemInfo> _003CGetInfoDisplayName_003Eb__5_0(VisibleGroupInfo g)
		{
			return (System.Collections.Generic.IEnumerable<VisibleViewItemInfo>)g.get_Items();
		}
	}

	private readonly IFormViewItemService formViewItemService;

	private System.Collections.Generic.ICollection<VisibleGroupInfo> visibleGroupInfos = new ReactiveCollection<VisibleGroupInfo>();

	public ViewItemGroupInfoService(IFormViewItemService formViewItemService)
	{
		this.formViewItemService = formViewItemService;
	}

	public System.Threading.Tasks.Task LoadViewItemInfoList(NamedMetadata[] metadataArray)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadViewItemInfoList_003Ed__3 _003CLoadViewItemInfoList_003Ed__ = default(_003CLoadViewItemInfoList_003Ed__3);
		_003CLoadViewItemInfoList_003Ed__._003C_003E4__this = this;
		_003CLoadViewItemInfoList_003Ed__.metadataArray = metadataArray;
		_003CLoadViewItemInfoList_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CLoadViewItemInfoList_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CLoadViewItemInfoList_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CLoadViewItemInfoList_003Ed__3>(ref _003CLoadViewItemInfoList_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CLoadViewItemInfoList_003Ed__._003C_003Et__builder)).get_Task();
	}

	public System.Collections.Generic.ICollection<VisibleGroupInfo> GetGroups()
	{
		return visibleGroupInfos;
	}

	public string GetInfoDisplayName(string typeName)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.typeName = typeName;
		VisibleViewItemInfo obj = Enumerable.SelectMany<VisibleGroupInfo, VisibleViewItemInfo>((System.Collections.Generic.IEnumerable<VisibleGroupInfo>)visibleGroupInfos, (Func<VisibleGroupInfo, System.Collections.Generic.IEnumerable<VisibleViewItemInfo>>)((VisibleGroupInfo g) => (System.Collections.Generic.IEnumerable<VisibleViewItemInfo>)g.get_Items())).FirstOrDefault((Func<VisibleViewItemInfo, bool>)((VisibleViewItemInfo i) => i.get_Name() == CS_0024_003C_003E8__locals0.typeName));
		return ((obj != null) ? obj.get_DisplayName() : null) ?? CS_0024_003C_003E8__locals0.typeName;
	}
}
