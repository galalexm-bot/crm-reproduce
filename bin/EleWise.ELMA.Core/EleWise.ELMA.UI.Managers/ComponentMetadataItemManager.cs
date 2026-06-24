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
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Models;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Ioc.Abstract;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Managers;
using EleWise.ELMA.Model.Validation;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.UI.Managers;

[Component]
public sealed class ComponentMetadataItemManager : UpdateMetadataHandler<ComponentMetadata>
{
	[StructLayout(3)]
	private struct _003CLoadOrNullAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ComponentMetadataItem> _003C_003Et__builder;

		public ComponentMetadataItemManager _003C_003E4__this;

		public Guid uid;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ComponentMetadataItemManager componentMetadataItemManager = _003C_003E4__this;
			ComponentMetadataItem result;
			try
			{
				TaskAwaiter<ComponentMetadataItem> val;
				if (num == 0)
				{
					val = (TaskAwaiter<ComponentMetadataItem>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00a9;
				}
				ComponentMetadataItem val2 = default(ComponentMetadataItem);
				if (((IDictionary<Guid, ComponentMetadataItem>)componentMetadataItemManager.items).TryGetValue(uid, ref val2))
				{
					result = val2;
				}
				else
				{
					ComponentMetadataItem val3 = default(ComponentMetadataItem);
					if (!((IDictionary<Guid, ComponentMetadataItem>)componentMetadataItemManager.drafts).TryGetValue(uid, ref val3))
					{
						val = componentMetadataItemManager.componentMetadataItemService.Load(uid).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ComponentMetadataItem>, _003CLoadOrNullAsync_003Ed__16>(ref val, ref this);
							return;
						}
						goto IL_00a9;
					}
					result = val3;
				}
				goto end_IL_000e;
				IL_00a9:
				ComponentMetadataItem result2 = val.GetResult();
				componentMetadataItemManager.LocalSaveFormMetadataItem(result2);
				result = result2;
				end_IL_000e:;
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

	[StructLayout(3)]
	private struct _003CLoadDraftByHeaderUid_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ComponentMetadataItem> _003C_003Et__builder;

		public ComponentMetadataItemManager _003C_003E4__this;

		public Guid headerUid;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ComponentMetadataItemManager componentMetadataItemManager = _003C_003E4__this;
			ComponentMetadataItem result2;
			try
			{
				TaskAwaiter<ComponentMetadataItem> val;
				if (num != 0)
				{
					val = componentMetadataItemManager.componentMetadataItemService.LoadDraftByHeaderUid(headerUid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ComponentMetadataItem>, _003CLoadDraftByHeaderUid_003Ed__17>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<ComponentMetadataItem>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				ComponentMetadataItem result = val.GetResult();
				componentMetadataItemManager.LocalSaveFormMetadataItem(result);
				result2 = result;
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

	[StructLayout(3)]
	private struct _003CCreateComponent_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ComponentMetadataItemHeader> _003C_003Et__builder;

		public ComponentMetadataItemManager _003C_003E4__this;

		public CreateModel createModel;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ComponentMetadataItemManager componentMetadataItemManager = _003C_003E4__this;
			ComponentMetadataItemHeader result2;
			try
			{
				TaskAwaiter<ComponentMetadataItemHeader> val;
				if (num != 0)
				{
					val = componentMetadataItemManager.componentMetadataItemHeaderService.CreateComponent(createModel).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ComponentMetadataItemHeader>, _003CCreateComponent_003Ed__18>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<ComponentMetadataItemHeader>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				ComponentMetadataItemHeader result = val.GetResult();
				((IDictionary<Guid, ComponentMetadataItemHeader>)componentMetadataItemManager.headers).set_Item(result.get_Uid(), result);
				result2 = result;
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

	[StructLayout(3)]
	private struct _003CCreatePage_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ComponentMetadataItemHeader> _003C_003Et__builder;

		public ComponentMetadataItemManager _003C_003E4__this;

		public CreateModel createModel;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ComponentMetadataItemManager componentMetadataItemManager = _003C_003E4__this;
			ComponentMetadataItemHeader result2;
			try
			{
				TaskAwaiter<ComponentMetadataItemHeader> val;
				if (num != 0)
				{
					val = componentMetadataItemManager.componentMetadataItemHeaderService.CreatePage(createModel).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ComponentMetadataItemHeader>, _003CCreatePage_003Ed__19>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<ComponentMetadataItemHeader>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				ComponentMetadataItemHeader result = val.GetResult();
				((IDictionary<Guid, ComponentMetadataItemHeader>)componentMetadataItemManager.headers).set_Item(result.get_Uid(), result);
				result2 = result;
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

	[StructLayout(3)]
	private struct _003CCreatePortlet_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ComponentMetadataItemHeader> _003C_003Et__builder;

		public ComponentMetadataItemManager _003C_003E4__this;

		public CreateModel createModel;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ComponentMetadataItemManager componentMetadataItemManager = _003C_003E4__this;
			ComponentMetadataItemHeader result2;
			try
			{
				TaskAwaiter<ComponentMetadataItemHeader> val;
				if (num != 0)
				{
					val = componentMetadataItemManager.componentMetadataItemHeaderService.CreatePortlet(createModel).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ComponentMetadataItemHeader>, _003CCreatePortlet_003Ed__20>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<ComponentMetadataItemHeader>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				ComponentMetadataItemHeader result = val.GetResult();
				((IDictionary<Guid, ComponentMetadataItemHeader>)componentMetadataItemManager.headers).set_Item(result.get_Uid(), result);
				result2 = result;
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

	[StructLayout(3)]
	private struct _003CEditHeader_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ComponentMetadataItemHeader> _003C_003Et__builder;

		public ComponentMetadataItemManager _003C_003E4__this;

		public CreateModel editModel;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ComponentMetadataItemManager componentMetadataItemManager = _003C_003E4__this;
			ComponentMetadataItemHeader result2;
			try
			{
				TaskAwaiter<ComponentMetadataItemHeader> val;
				if (num != 0)
				{
					val = componentMetadataItemManager.componentMetadataItemHeaderService.EditHeader(editModel).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ComponentMetadataItemHeader>, _003CEditHeader_003Ed__21>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<ComponentMetadataItemHeader>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				ComponentMetadataItemHeader result = val.GetResult();
				((IDictionary<Guid, ComponentMetadataItemHeader>)componentMetadataItemManager.headers).set_Item(result.get_Uid(), result);
				result2 = result;
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

	[StructLayout(3)]
	private struct _003CLoadHeaderAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ComponentMetadataItemHeader> _003C_003Et__builder;

		public ComponentMetadataItemManager _003C_003E4__this;

		public Guid uid;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ComponentMetadataItemManager componentMetadataItemManager = _003C_003E4__this;
			ComponentMetadataItemHeader result2;
			try
			{
				TaskAwaiter<ComponentMetadataItemHeader> val;
				if (num != 0)
				{
					val = componentMetadataItemManager.componentMetadataItemHeaderService.Load(uid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ComponentMetadataItemHeader>, _003CLoadHeaderAsync_003Ed__23>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<ComponentMetadataItemHeader>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				ComponentMetadataItemHeader result = val.GetResult();
				if (result != null)
				{
					((IDictionary<Guid, ComponentMetadataItemHeader>)componentMetadataItemManager.headers).set_Item(result.get_Uid(), result);
				}
				result2 = result;
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

		public static Func<KeyValuePair<Guid, ComponentMetadataItemHeader>, ComponentMetadataItemHeader> _003C_003E9__24_0;

		public static Func<ValidationError, bool> _003C_003E9__28_0;

		public static Func<ValidationError, Guid> _003C_003E9__28_1;

		public static Func<ComponentMetadata, bool> _003C_003E9__29_4;

		public static Func<ModuleMetadataItem, System.Collections.Generic.IEnumerable<ComponentMetadata>> _003C_003E9__29_1;

		public static Func<ComponentMetadata, ComponentMetadataItemHeader> _003C_003E9__29_2;

		public static Func<ComponentMetadataItemHeader, bool> _003C_003E9__29_3;

		public static Func<ComponentMetadata, bool> _003C_003E9__29_7;

		internal ComponentMetadataItemHeader _003CGetAllHeaders_003Eb__24_0(KeyValuePair<Guid, ComponentMetadataItemHeader> el)
		{
			return el.get_Value();
		}

		internal bool _003CPublish_003Eb__28_0(ValidationError error)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return error.get_ElementTypeUid() != ValidationElementType.Property;
		}

		internal Guid _003CPublish_003Eb__28_1(ValidationError error)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return error.get_ElementUid();
		}

		internal System.Collections.Generic.IEnumerable<ComponentMetadata> _003CGetVisibleModuleHeaders_003Eb__29_1(ModuleMetadataItem a)
		{
			return (System.Collections.Generic.IEnumerable<ComponentMetadata>)Enumerable.Where<ComponentMetadata>((System.Collections.Generic.IEnumerable<ComponentMetadata>)a.get_Metadata().get_Components(), (Func<ComponentMetadata, bool>)((ComponentMetadata b) => !((IMetadata)b).get_Internal()));
		}

		internal bool _003CGetVisibleModuleHeaders_003Eb__29_4(ComponentMetadata b)
		{
			return !((IMetadata)b).get_Internal();
		}

		internal ComponentMetadataItemHeader _003CGetVisibleModuleHeaders_003Eb__29_2(ComponentMetadata c)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			ComponentMetadataItemHeader obj = InterfaceCreator.Create<ComponentMetadataItemHeader>();
			obj.set_Uid(((IMetadata)c).get_Uid());
			obj.set_Name(((INamedMetadata)c).get_Name());
			obj.set_DisplayName(((INamedMetadata)c).get_DisplayName());
			obj.set_ModuleUid(((IMetadata)c).get_ModuleUid());
			obj.set_MetadataTypeUid((c is PageComponentMetadata) ? MetadataConstants.PageComponentMetadataTypeUid : ((c is PortletComponentMetadata) ? MetadataConstants.PortletComponentMetadataTypeUid : MetadataConstants.ComponentMetadataTypeUid));
			return obj;
		}

		internal bool _003CGetVisibleModuleHeaders_003Eb__29_3(ComponentMetadataItemHeader el)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			if (el.get_Published_Uid().get_HasValue() && el.get_Published_Uid().get_Value() != Guid.Empty)
			{
				if (!(el.get_ModuleUid() == Guid.Empty))
				{
					return !el.get_Internal();
				}
				return true;
			}
			return false;
		}

		internal bool _003CGetVisibleModuleHeaders_003Eb__29_7(ComponentMetadata d)
		{
			return !((IMetadata)d).get_Internal();
		}
	}

	[StructLayout(3)]
	private struct _003CGetAllHeaders_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>> _003C_003Et__builder;

		public ComponentMetadataItemManager _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ComponentMetadataItemManager componentMetadataItemManager = _003C_003E4__this;
			System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader> result;
			try
			{
				TaskAwaiter<System.Collections.Generic.ICollection<ComponentMetadataItemHeader>> val;
				if (num == 0)
				{
					val = (TaskAwaiter<System.Collections.Generic.ICollection<ComponentMetadataItemHeader>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00ab;
				}
				if (((System.Collections.Generic.ICollection<KeyValuePair<Guid, ComponentMetadataItemHeader>>)componentMetadataItemManager.headers).get_Count() <= 0)
				{
					val = componentMetadataItemManager.componentMetadataItemHeaderService.LoadAll().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.ICollection<ComponentMetadataItemHeader>>, _003CGetAllHeaders_003Ed__24>(ref val, ref this);
						return;
					}
					goto IL_00ab;
				}
				result = (System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>)Enumerable.Select<KeyValuePair<Guid, ComponentMetadataItemHeader>, ComponentMetadataItemHeader>((System.Collections.Generic.IEnumerable<KeyValuePair<Guid, ComponentMetadataItemHeader>>)componentMetadataItemManager.headers, (Func<KeyValuePair<Guid, ComponentMetadataItemHeader>, ComponentMetadataItemHeader>)((KeyValuePair<Guid, ComponentMetadataItemHeader> el) => el.get_Value()));
				goto end_IL_000e;
				IL_00ab:
				ComponentMetadataItemHeader[] array = Enumerable.ToArray<ComponentMetadataItemHeader>((System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>)val.GetResult());
				ComponentMetadataItemHeader[] array2 = array;
				foreach (ComponentMetadataItemHeader val2 in array2)
				{
					((IDictionary<Guid, ComponentMetadataItemHeader>)componentMetadataItemManager.headers).set_Item(val2.get_Uid(), val2);
				}
				result = array;
				end_IL_000e:;
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

	[StructLayout(3)]
	private struct _003CDelete_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ComponentMetadataItemHeader header;

		public ComponentMetadataItemManager _003C_003E4__this;

		private Guid _003CheaderUid_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected O, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ComponentMetadataItemManager componentMetadataItemManager = _003C_003E4__this;
			try
			{
				TaskAwaiter val;
				if (num != 0)
				{
					_003CheaderUid_003E5__2 = header.get_Uid();
					val = componentMetadataItemManager.componentMetadataItemHeaderService.Delete(_003CheaderUid_003E5__2).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CDelete_003Ed__25>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				val.GetResult();
				((IDictionary<Guid, ComponentMetadataItemHeader>)componentMetadataItemManager.headers).Remove(_003CheaderUid_003E5__2);
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

	[StructLayout(3)]
	private struct _003CCopy_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ComponentMetadataItemHeader> _003C_003Et__builder;

		public ComponentMetadataItemManager _003C_003E4__this;

		public Guid headerUid;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ComponentMetadataItemManager componentMetadataItemManager = _003C_003E4__this;
			ComponentMetadataItemHeader result2;
			try
			{
				TaskAwaiter<ComponentMetadataItemHeader> val;
				if (num != 0)
				{
					val = componentMetadataItemManager.componentMetadataItemHeaderService.Copy(headerUid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ComponentMetadataItemHeader>, _003CCopy_003Ed__27>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<ComponentMetadataItemHeader>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				ComponentMetadataItemHeader result = val.GetResult();
				((IDictionary<Guid, ComponentMetadataItemHeader>)componentMetadataItemManager.headers).set_Item(result.get_Uid(), result);
				result2 = result;
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

	[StructLayout(3)]
	private struct _003CPublish_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ComponentMetadataItem> _003C_003Et__builder;

		public bool forEmulation;

		public ComponentMetadataItemManager _003C_003E4__this;

		public Guid uid;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ComponentMetadataItemManager componentMetadataItemManager = _003C_003E4__this;
			ComponentMetadataItem item;
			try
			{
				TaskAwaiter<ComponentMetadataPublishResult> val;
				ComponentMetadataPublishResult result;
				if (num != 0)
				{
					if (num != 1)
					{
						if (forEmulation)
						{
							val = componentMetadataItemManager.componentMetadataItemHeaderService.Emulation(uid).GetAwaiter();
							if (!val.get_IsCompleted())
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = val;
								_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ComponentMetadataPublishResult>, _003CPublish_003Ed__28>(ref val, ref this);
								return;
							}
							goto IL_0082;
						}
						val = componentMetadataItemManager.componentMetadataItemHeaderService.Publish(uid).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ComponentMetadataPublishResult>, _003CPublish_003Ed__28>(ref val, ref this);
							return;
						}
					}
					else
					{
						val = (TaskAwaiter<ComponentMetadataPublishResult>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
					}
					result = val.GetResult();
					goto IL_00f8;
				}
				val = (TaskAwaiter<ComponentMetadataPublishResult>)_003C_003Eu__1;
				_003C_003Eu__1 = null;
				num = (_003C_003E1__state = -1);
				goto IL_0082;
				IL_0082:
				result = val.GetResult();
				goto IL_00f8;
				IL_00f8:
				ComponentMetadataPublishResult val2 = result;
				if (val2.get_Errors().get_Count() != 0)
				{
					componentMetadataItemManager.notValidElementStorage.Clear(uid);
					componentMetadataItemManager.notValidElementStorage.AddRange(uid, (System.Collections.Generic.IEnumerable<Guid>)Enumerable.Where<ValidationError>((System.Collections.Generic.IEnumerable<ValidationError>)val2.get_Errors(), (Func<ValidationError, bool>)((ValidationError error) => error.get_ElementTypeUid() != ValidationElementType.Property)).Select<Guid>((Func<ValidationError, Guid>)((ValidationError error) => error.get_ElementUid())));
					throw new System.Exception(ValidationErrorHelper.GetMessage(val2.get_Errors()));
				}
				ComponentMetadataItemHeader val3 = ((IDictionary<Guid, ComponentMetadataItemHeader>)componentMetadataItemManager.headers).get_Item(uid);
				if (forEmulation)
				{
					val3.set_Emulation_Uid((Guid?)val2.get_Item().get_Uid());
				}
				else
				{
					val3.set_Published_Uid((Guid?)val2.get_Item().get_Uid());
					val3.set_IsDirtyItem(false);
				}
				ComponentMetadata metadata = val2.get_Item().get_Metadata();
				val3.set_DisplayName(((INamedMetadata)metadata).get_DisplayName());
				val3.set_Name(((INamedMetadata)metadata).get_Name());
				item = val2.get_Item();
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(item);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public Guid moduleUid;

		internal bool _003CGetVisibleModuleHeaders_003Eb__5(ComponentMetadataItemHeader el)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return el.get_ModuleUid() == moduleUid;
		}

		internal bool _003CGetVisibleModuleHeaders_003Eb__0(ComponentMetadataItemHeader el)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return el.get_ModuleUid() == moduleUid;
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_1
	{
		public LinkToModule link;

		internal bool _003CGetVisibleModuleHeaders_003Eb__6(ComponentMetadataItemHeader h)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			if (h.get_ModuleUid() == link.get_ModuleUid())
			{
				return !h.get_Internal();
			}
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_2
	{
		public EnumerableInstance<ComponentMetadata> publicComponents;

		internal bool _003CGetVisibleModuleHeaders_003Eb__8(ComponentMetadataItemHeader h)
		{
			_003C_003Ec__DisplayClass29_3 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass29_3();
			CS_0024_003C_003E8__locals0.h = h;
			return publicComponents.Any((Func<ComponentMetadata, bool>)((ComponentMetadata c) => ((IMetadata)c).get_Uid() == CS_0024_003C_003E8__locals0.h.get_Uid()));
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_3
	{
		public ComponentMetadataItemHeader h;

		internal bool _003CGetVisibleModuleHeaders_003Eb__9(ComponentMetadata c)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)c).get_Uid() == h.get_Uid();
		}
	}

	[StructLayout(3)]
	private struct _003CGetVisibleModuleHeaders_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>> _003C_003Et__builder;

		public Guid moduleUid;

		public ComponentMetadataItemManager _003C_003E4__this;

		private _003C_003Ec__DisplayClass29_0 _003C_003E8__1;

		private ComponentMetadataItemHeader[] _003CallHeaders_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ComponentMetadataItemManager componentMetadataItemManager = _003C_003E4__this;
			System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader> result;
			try
			{
				TaskAwaiter<System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>> val3;
				TaskAwaiter<System.Collections.Generic.IEnumerable<ModuleMetadataItem>> val2;
				TaskAwaiter<ModuleMetadataItem> val;
				EnumerableInstance<ComponentMetadataItemHeader> val4;
				System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader> result2;
				switch (num)
				{
				default:
					_003C_003E8__1 = new _003C_003Ec__DisplayClass29_0();
					_003C_003E8__1.moduleUid = moduleUid;
					val3 = componentMetadataItemManager.GetAllHeaders().GetAwaiter();
					if (!val3.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val3;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>>, _003CGetVisibleModuleHeaders_003Ed__29>(ref val3, ref this);
						return;
					}
					goto IL_0093;
				case 0:
					val3 = (TaskAwaiter<System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0093;
				case 1:
					val2 = (TaskAwaiter<System.Collections.Generic.IEnumerable<ModuleMetadataItem>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_011f;
				case 2:
					{
						val = (TaskAwaiter<ModuleMetadataItem>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_011f:
					val4 = Enumerable.SelectMany<ModuleMetadataItem, ComponentMetadata>(val2.GetResult(), (Func<ModuleMetadataItem, System.Collections.Generic.IEnumerable<ComponentMetadata>>)((ModuleMetadataItem a) => (System.Collections.Generic.IEnumerable<ComponentMetadata>)Enumerable.Where<ComponentMetadata>((System.Collections.Generic.IEnumerable<ComponentMetadata>)a.get_Metadata().get_Components(), (Func<ComponentMetadata, bool>)((ComponentMetadata b) => !((IMetadata)b).get_Internal())))).Select<ComponentMetadataItemHeader>((Func<ComponentMetadata, ComponentMetadataItemHeader>)delegate(ComponentMetadata c)
					{
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						//IL_002b: Unknown result type (might be due to invalid IL or missing references)
						//IL_0046: Unknown result type (might be due to invalid IL or missing references)
						//IL_004d: Unknown result type (might be due to invalid IL or missing references)
						//IL_0054: Unknown result type (might be due to invalid IL or missing references)
						ComponentMetadataItemHeader obj = InterfaceCreator.Create<ComponentMetadataItemHeader>();
						obj.set_Uid(((IMetadata)c).get_Uid());
						obj.set_Name(((INamedMetadata)c).get_Name());
						obj.set_DisplayName(((INamedMetadata)c).get_DisplayName());
						obj.set_ModuleUid(((IMetadata)c).get_ModuleUid());
						obj.set_MetadataTypeUid((c is PageComponentMetadata) ? MetadataConstants.PageComponentMetadataTypeUid : ((c is PortletComponentMetadata) ? MetadataConstants.PortletComponentMetadataTypeUid : MetadataConstants.ComponentMetadataTypeUid));
						return obj;
					});
					result = (System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>)Enumerable.Where<ComponentMetadataItemHeader>((System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>)_003CallHeaders_003E5__2, (Func<ComponentMetadataItemHeader, bool>)((ComponentMetadataItemHeader el) => el.get_Published_Uid().get_HasValue() && el.get_Published_Uid().get_Value() != Guid.Empty && (el.get_ModuleUid() == Guid.Empty || !el.get_Internal()))).Concat((System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>)val4);
					goto end_IL_000e;
					IL_0093:
					result2 = val3.GetResult();
					_003CallHeaders_003E5__2 = Enumerable.ToArray<ComponentMetadataItemHeader>(result2);
					if (_003C_003E8__1.moduleUid == Guid.Empty)
					{
						val2 = componentMetadataItemManager.moduleMetadataItemManager.GetAll().GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val2;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.IEnumerable<ModuleMetadataItem>>, _003CGetVisibleModuleHeaders_003Ed__29>(ref val2, ref this);
							return;
						}
						goto IL_011f;
					}
					val = componentMetadataItemManager.moduleMetadataItemManager.LoadOrNullByHeaderAsync(_003C_003E8__1.moduleUid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ModuleMetadataItem>, _003CGetVisibleModuleHeaders_003Ed__29>(ref val, ref this);
						return;
					}
					break;
				}
				ModuleMetadataItem result3 = val.GetResult();
				ModuleInfoMetadata val5;
				if ((val5 = ((result3 != null) ? result3.get_Metadata() : null)) != null)
				{
					List<ComponentMetadataItemHeader> val6 = new List<ComponentMetadataItemHeader>();
					val6.AddRange((System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>)Enumerable.Where<ComponentMetadataItemHeader>((System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>)_003CallHeaders_003E5__2, (Func<ComponentMetadataItemHeader, bool>)((ComponentMetadataItemHeader el) => el.get_ModuleUid() == _003C_003E8__1.moduleUid)));
					System.Collections.Generic.IEnumerator<LinkToModule> enumerator = ((System.Collections.Generic.IEnumerable<LinkToModule>)val5.get_DependencyModules()).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							_003C_003Ec__DisplayClass29_3 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass29_1();
							CS_0024_003C_003E8__locals0.link = enumerator.get_Current();
							if (componentMetadataItemManager.applicationData.InterfaceBuilderMode == InterfaceBuilderMode.Elma)
							{
								_003C_003Ec__DisplayClass29_2 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass29_2();
								ModuleMetadataItem val7 = componentMetadataItemManager.moduleMetadataItemManager.LoadPublish(CS_0024_003C_003E8__locals0.link.get_ModuleUid());
								if (val7 == null)
								{
									continue;
								}
								CS_0024_003C_003E8__locals1.publicComponents = Enumerable.Where<ComponentMetadata>((System.Collections.Generic.IEnumerable<ComponentMetadata>)val7.get_Metadata().get_Components(), (Func<ComponentMetadata, bool>)((ComponentMetadata d) => !((IMetadata)d).get_Internal()));
								val6.AddRange((System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>)Enumerable.Where<ComponentMetadataItemHeader>((System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>)_003CallHeaders_003E5__2, (Func<ComponentMetadataItemHeader, bool>)delegate(ComponentMetadataItemHeader h)
								{
									CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass29_3();
									CS_0024_003C_003E8__locals0.h = h;
									return CS_0024_003C_003E8__locals1.publicComponents.Any((Func<ComponentMetadata, bool>)((ComponentMetadata c) => ((IMetadata)c).get_Uid() == CS_0024_003C_003E8__locals0.h.get_Uid()));
								}));
							}
							else
							{
								val6.AddRange((System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>)Enumerable.Where<ComponentMetadataItemHeader>((System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>)_003CallHeaders_003E5__2, (Func<ComponentMetadataItemHeader, bool>)((ComponentMetadataItemHeader h) => h.get_ModuleUid() == CS_0024_003C_003E8__locals0.link.get_ModuleUid() && !h.get_Internal())));
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
					result = (System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>)val6;
				}
				else
				{
					result = (System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>)Enumerable.Where<ComponentMetadataItemHeader>((System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>)_003CallHeaders_003E5__2, (Func<ComponentMetadataItemHeader, bool>)((ComponentMetadataItemHeader el) => el.get_ModuleUid() == _003C_003E8__1.moduleUid));
				}
				end_IL_000e:;
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

	[StructLayout(3)]
	private struct _003CSaveAndUpdate_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ComponentMetadataItem> _003C_003Et__builder;

		public ComponentMetadataItemManager _003C_003E4__this;

		public ComponentMetadataItem metadata;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ComponentMetadataItemManager componentMetadataItemManager = _003C_003E4__this;
			ComponentMetadataItem result2;
			try
			{
				TaskAwaiter<ComponentSaveResult> val;
				if (num != 0)
				{
					val = componentMetadataItemManager.componentMetadataItemService.SaveAndUpdate(metadata).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ComponentSaveResult>, _003CSaveAndUpdate_003Ed__35>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<ComponentSaveResult>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				ComponentSaveResult result = val.GetResult();
				if (((BaseResult)result).get_Warnings().get_Count() > 0)
				{
					System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)((BaseResult)result).get_Warnings()).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							string current = enumerator.get_Current();
							componentMetadataItemManager.notificationService.Warning(SR.T("Внимание"), current);
							componentMetadataItemManager.logger.Warn(current);
						}
					}
					finally
					{
						if (num < 0)
						{
							((System.IDisposable)enumerator)?.Dispose();
						}
					}
				}
				ComponentMetadataItem component = result.get_Component();
				ComponentMetadataItemHeader val2 = ((IDictionary<Guid, ComponentMetadataItemHeader>)componentMetadataItemManager.headers).get_Item(component.get_Header_Uid());
				if (val2 != null)
				{
					ComponentMetadata val3 = component.get_Metadata();
					val2.set_DisplayName(((INamedMetadata)val3).get_DisplayName());
					val2.set_Name(((INamedMetadata)val3).get_Name());
					val2.set_IsDirtyItem(true);
				}
				componentMetadataItemManager.LocalSaveFormMetadataItem(component);
				result2 = component;
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

	[StructLayout(3)]
	private struct _003CSaveAndUpdate_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IUpdateModel> _003C_003Et__builder;

		public IUpdateModel updateModel;

		public ComponentMetadataItemManager _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ComponentMetadataItemManager componentMetadataItemManager = _003C_003E4__this;
			IUpdateModel result;
			try
			{
				TaskAwaiter<ComponentMetadataItem> val;
				if (num == 0)
				{
					val = (TaskAwaiter<ComponentMetadataItem>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00f8;
				}
				IMetadata obj = updateModel?.Metadata;
				ComponentMetadata val2;
				if ((val2 = (ComponentMetadata)(object)((obj is ComponentMetadata) ? obj : null)) == null)
				{
					result = null;
				}
				else
				{
					ComponentMetadataItem val3 = componentMetadataItemManager.LoadItemByMetadataUid(((IMetadata)val2).get_Uid());
					if (val3 != null)
					{
						val3.set_Metadata(val2);
						val3.set_ScriptModule(updateModel.ServerScriptModule);
						val3.set_ClientScriptModule(updateModel.ClientScriptModule);
						val3.set_ViewScriptModule(updateModel.ViewScriptModule);
						val3.set_TestScriptModule(updateModel.TestScriptModule);
						val = componentMetadataItemManager.SaveAndUpdate(val3).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ComponentMetadataItem>, _003CSaveAndUpdate_003Ed__38>(ref val, ref this);
							return;
						}
						goto IL_00f8;
					}
					result = null;
				}
				goto end_IL_000e;
				IL_00f8:
				ComponentMetadataItem result2 = val.GetResult();
				result = new UpdateModel((IMetadata)(object)result2.get_Metadata())
				{
					ServerScriptModule = result2.get_ScriptModule(),
					ClientScriptModule = result2.get_ClientScriptModule(),
					ViewScriptModule = result2.get_ViewScriptModule(),
					TestScriptModule = result2.get_TestScriptModule()
				};
				end_IL_000e:;
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

	[StructLayout(3)]
	private struct _003CSaveAndPublish_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IUpdateModel> _003C_003Et__builder;

		public IUpdateModel updateModel;

		public ComponentMetadataItemManager _003C_003E4__this;

		private ComponentMetadataItem _003Citem_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ComponentMetadataItemManager componentMetadataItemManager = _003C_003E4__this;
			IUpdateModel result;
			try
			{
				TaskAwaiter<ComponentMetadataItem> val;
				if (num == 0)
				{
					val = (TaskAwaiter<ComponentMetadataItem>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_011f;
				}
				if (num == 1)
				{
					val = (TaskAwaiter<ComponentMetadataItem>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0197;
				}
				IMetadata obj = updateModel?.Metadata;
				ComponentMetadata val2;
				if ((val2 = (ComponentMetadata)(object)((obj is ComponentMetadata) ? obj : null)) == null)
				{
					result = null;
				}
				else
				{
					_003Citem_003E5__2 = componentMetadataItemManager.LoadItemByMetadataUid(((IMetadata)val2).get_Uid());
					if (_003Citem_003E5__2 != null)
					{
						_003Citem_003E5__2.set_Metadata(val2);
						_003Citem_003E5__2.set_ScriptModule(updateModel.ServerScriptModule);
						_003Citem_003E5__2.set_ClientScriptModule(updateModel.ClientScriptModule);
						_003Citem_003E5__2.set_ViewScriptModule(updateModel.ViewScriptModule);
						_003Citem_003E5__2.set_TestScriptModule(updateModel.TestScriptModule);
						val = componentMetadataItemManager.SaveAndUpdate(_003Citem_003E5__2).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ComponentMetadataItem>, _003CSaveAndPublish_003Ed__39>(ref val, ref this);
							return;
						}
						goto IL_011f;
					}
					result = null;
				}
				goto end_IL_000e;
				IL_011f:
				val.GetResult();
				val = componentMetadataItemManager.Publish(_003Citem_003E5__2.get_Header_Uid(), updateModel.ViewMode == InterfaceBuilderViewMode.Emulation).GetAwaiter();
				if (!val.get_IsCompleted())
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = val;
					_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ComponentMetadataItem>, _003CSaveAndPublish_003Ed__39>(ref val, ref this);
					return;
				}
				goto IL_0197;
				IL_0197:
				ComponentMetadataItem result2 = val.GetResult();
				result = new UpdateModel((IMetadata)(object)result2.get_Metadata())
				{
					ServerScriptModule = result2.get_ScriptModule(),
					ClientScriptModule = result2.get_ClientScriptModule(),
					ViewScriptModule = result2.get_ViewScriptModule(),
					TestScriptModule = result2.get_TestScriptModule()
				};
				end_IL_000e:;
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

	private readonly IComponentMetadataService componentMetadataItemService;

	private readonly IComponentMetadataItemHeaderService componentMetadataItemHeaderService;

	private readonly IApplicationData applicationData;

	private readonly ICustomComponentCacheService customComponentCacheService;

	private readonly INotValidElementStorage notValidElementStorage;

	private readonly ModuleMetadataItemManager moduleMetadataItemManager;

	private readonly DataClassMetadataItemManager dataClassMetadataItemManager;

	private readonly INotificationService notificationService;

	private readonly ILogger logger;

	private readonly IReactiveDictionary<Guid, Guid> components;

	private readonly IReactiveDictionary<Guid, ComponentMetadataItem> items;

	private readonly IReactiveDictionary<Guid, ComponentMetadataItem> drafts;

	private readonly IReactiveDictionary<Guid, ComponentMetadataItemHeader> headers;

	public ComponentMetadataItemManager(IComponentMetadataService componentMetadataItemService, IComponentMetadataItemHeaderService componentMetadataItemHeaderService, ModuleMetadataItemManager moduleMetadataItemManager, DataClassMetadataItemManager dataClassMetadataItemManager, INotificationService notificationService, ILogger logger, IApplicationData applicationData, ILifetimeScope lifetimeScope, ICustomComponentCacheService customComponentCacheService)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		this.componentMetadataItemService = componentMetadataItemService;
		this.componentMetadataItemHeaderService = componentMetadataItemHeaderService;
		this.moduleMetadataItemManager = moduleMetadataItemManager;
		this.dataClassMetadataItemManager = dataClassMetadataItemManager;
		this.notificationService = notificationService;
		this.logger = logger;
		this.applicationData = applicationData;
		this.customComponentCacheService = customComponentCacheService;
		notValidElementStorage = ((IScopeContext)((ISharingLifetimeScope)lifetimeScope).get_RootLifetimeScope()).Resolve<INotValidElementStorage>();
		components = new ReactiveDictionary<Guid, Guid>();
		items = new ReactiveDictionary<Guid, ComponentMetadataItem>();
		drafts = new ReactiveDictionary<Guid, ComponentMetadataItem>();
		headers = new ReactiveDictionary<Guid, ComponentMetadataItemHeader>();
	}

	public ComponentMetadataItem Load(Guid uid)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return LoadOrNull(uid) ?? throw new ObjectNotFoundException(SR.T("Метаданные компонента не найдены"));
	}

	public ComponentMetadataItem LoadOrNull(Guid uid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		ComponentMetadataItem result = default(ComponentMetadataItem);
		if (((IDictionary<Guid, ComponentMetadataItem>)items).TryGetValue(uid, ref result))
		{
			return result;
		}
		ComponentMetadataItem result2 = default(ComponentMetadataItem);
		if (!((IDictionary<Guid, ComponentMetadataItem>)drafts).TryGetValue(uid, ref result2))
		{
			return null;
		}
		return result2;
	}

	public System.Threading.Tasks.Task<ComponentMetadataItem> LoadOrNullAsync(Guid uid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadOrNullAsync_003Ed__16 _003CLoadOrNullAsync_003Ed__ = default(_003CLoadOrNullAsync_003Ed__16);
		_003CLoadOrNullAsync_003Ed__._003C_003E4__this = this;
		_003CLoadOrNullAsync_003Ed__.uid = uid;
		_003CLoadOrNullAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ComponentMetadataItem>.Create();
		_003CLoadOrNullAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ComponentMetadataItem> _003C_003Et__builder = _003CLoadOrNullAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CLoadOrNullAsync_003Ed__16>(ref _003CLoadOrNullAsync_003Ed__);
		return _003CLoadOrNullAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<ComponentMetadataItem> LoadDraftByHeaderUid(Guid headerUid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadDraftByHeaderUid_003Ed__17 _003CLoadDraftByHeaderUid_003Ed__ = default(_003CLoadDraftByHeaderUid_003Ed__17);
		_003CLoadDraftByHeaderUid_003Ed__._003C_003E4__this = this;
		_003CLoadDraftByHeaderUid_003Ed__.headerUid = headerUid;
		_003CLoadDraftByHeaderUid_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ComponentMetadataItem>.Create();
		_003CLoadDraftByHeaderUid_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ComponentMetadataItem> _003C_003Et__builder = _003CLoadDraftByHeaderUid_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CLoadDraftByHeaderUid_003Ed__17>(ref _003CLoadDraftByHeaderUid_003Ed__);
		return _003CLoadDraftByHeaderUid_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<ComponentMetadataItemHeader> CreateComponent(CreateModel createModel)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CCreateComponent_003Ed__18 _003CCreateComponent_003Ed__ = default(_003CCreateComponent_003Ed__18);
		_003CCreateComponent_003Ed__._003C_003E4__this = this;
		_003CCreateComponent_003Ed__.createModel = createModel;
		_003CCreateComponent_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ComponentMetadataItemHeader>.Create();
		_003CCreateComponent_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ComponentMetadataItemHeader> _003C_003Et__builder = _003CCreateComponent_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CCreateComponent_003Ed__18>(ref _003CCreateComponent_003Ed__);
		return _003CCreateComponent_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<ComponentMetadataItemHeader> CreatePage(CreateModel createModel)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CCreatePage_003Ed__19 _003CCreatePage_003Ed__ = default(_003CCreatePage_003Ed__19);
		_003CCreatePage_003Ed__._003C_003E4__this = this;
		_003CCreatePage_003Ed__.createModel = createModel;
		_003CCreatePage_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ComponentMetadataItemHeader>.Create();
		_003CCreatePage_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ComponentMetadataItemHeader> _003C_003Et__builder = _003CCreatePage_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CCreatePage_003Ed__19>(ref _003CCreatePage_003Ed__);
		return _003CCreatePage_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<ComponentMetadataItemHeader> CreatePortlet(CreateModel createModel)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CCreatePortlet_003Ed__20 _003CCreatePortlet_003Ed__ = default(_003CCreatePortlet_003Ed__20);
		_003CCreatePortlet_003Ed__._003C_003E4__this = this;
		_003CCreatePortlet_003Ed__.createModel = createModel;
		_003CCreatePortlet_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ComponentMetadataItemHeader>.Create();
		_003CCreatePortlet_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ComponentMetadataItemHeader> _003C_003Et__builder = _003CCreatePortlet_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CCreatePortlet_003Ed__20>(ref _003CCreatePortlet_003Ed__);
		return _003CCreatePortlet_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<ComponentMetadataItemHeader> EditHeader(CreateModel editModel)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CEditHeader_003Ed__21 _003CEditHeader_003Ed__ = default(_003CEditHeader_003Ed__21);
		_003CEditHeader_003Ed__._003C_003E4__this = this;
		_003CEditHeader_003Ed__.editModel = editModel;
		_003CEditHeader_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ComponentMetadataItemHeader>.Create();
		_003CEditHeader_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ComponentMetadataItemHeader> _003C_003Et__builder = _003CEditHeader_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CEditHeader_003Ed__21>(ref _003CEditHeader_003Ed__);
		return _003CEditHeader_003Ed__._003C_003Et__builder.get_Task();
	}

	public ComponentMetadataItemHeader LoadHeader(Guid uid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		ComponentMetadataItemHeader result = default(ComponentMetadataItemHeader);
		if (((IDictionary<Guid, ComponentMetadataItemHeader>)headers).TryGetValue(uid, ref result))
		{
			return result;
		}
		throw new ObjectNotFoundException(SR.T("Заголовок компонента не найден"));
	}

	public System.Threading.Tasks.Task<ComponentMetadataItemHeader> LoadHeaderAsync(Guid uid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadHeaderAsync_003Ed__23 _003CLoadHeaderAsync_003Ed__ = default(_003CLoadHeaderAsync_003Ed__23);
		_003CLoadHeaderAsync_003Ed__._003C_003E4__this = this;
		_003CLoadHeaderAsync_003Ed__.uid = uid;
		_003CLoadHeaderAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ComponentMetadataItemHeader>.Create();
		_003CLoadHeaderAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ComponentMetadataItemHeader> _003C_003Et__builder = _003CLoadHeaderAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CLoadHeaderAsync_003Ed__23>(ref _003CLoadHeaderAsync_003Ed__);
		return _003CLoadHeaderAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>> GetAllHeaders()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CGetAllHeaders_003Ed__24 _003CGetAllHeaders_003Ed__ = default(_003CGetAllHeaders_003Ed__24);
		_003CGetAllHeaders_003Ed__._003C_003E4__this = this;
		_003CGetAllHeaders_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>>.Create();
		_003CGetAllHeaders_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>> _003C_003Et__builder = _003CGetAllHeaders_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetAllHeaders_003Ed__24>(ref _003CGetAllHeaders_003Ed__);
		return _003CGetAllHeaders_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task Delete(ComponentMetadataItemHeader header)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CDelete_003Ed__25 _003CDelete_003Ed__ = default(_003CDelete_003Ed__25);
		_003CDelete_003Ed__._003C_003E4__this = this;
		_003CDelete_003Ed__.header = header;
		_003CDelete_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CDelete_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CDelete_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CDelete_003Ed__25>(ref _003CDelete_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CDelete_003Ed__._003C_003Et__builder)).get_Task();
	}

	public void RemoveFromCache(InterfaceBuilderViewMode viewMode, Guid headerUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ComponentMetadataItemHeader val = default(ComponentMetadataItemHeader);
		if (!((IDictionary<Guid, ComponentMetadataItemHeader>)headers).TryGetValue(headerUid, ref val))
		{
			return;
		}
		switch (viewMode)
		{
		case InterfaceBuilderViewMode.Design:
			((IDictionary<Guid, ComponentMetadataItem>)drafts).Remove(val.get_Draft_Uid());
			break;
		case InterfaceBuilderViewMode.Runtime:
			if (val.get_Published_Uid().get_HasValue())
			{
				((IDictionary<Guid, ComponentMetadataItem>)items).Remove(val.get_Published_Uid().get_Value());
			}
			break;
		case InterfaceBuilderViewMode.Emulation:
			if (val.get_Emulation_Uid().get_HasValue())
			{
				((IDictionary<Guid, ComponentMetadataItem>)items).Remove(val.get_Emulation_Uid().get_Value());
			}
			break;
		}
	}

	public System.Threading.Tasks.Task<ComponentMetadataItemHeader> Copy(Guid headerUid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CCopy_003Ed__27 _003CCopy_003Ed__ = default(_003CCopy_003Ed__27);
		_003CCopy_003Ed__._003C_003E4__this = this;
		_003CCopy_003Ed__.headerUid = headerUid;
		_003CCopy_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ComponentMetadataItemHeader>.Create();
		_003CCopy_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ComponentMetadataItemHeader> _003C_003Et__builder = _003CCopy_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CCopy_003Ed__27>(ref _003CCopy_003Ed__);
		return _003CCopy_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<ComponentMetadataItem> Publish(Guid uid, bool forEmulation = false)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CPublish_003Ed__28 _003CPublish_003Ed__ = default(_003CPublish_003Ed__28);
		_003CPublish_003Ed__._003C_003E4__this = this;
		_003CPublish_003Ed__.uid = uid;
		_003CPublish_003Ed__.forEmulation = forEmulation;
		_003CPublish_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ComponentMetadataItem>.Create();
		_003CPublish_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ComponentMetadataItem> _003C_003Et__builder = _003CPublish_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CPublish_003Ed__28>(ref _003CPublish_003Ed__);
		return _003CPublish_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>> GetVisibleModuleHeaders(Guid moduleUid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CGetVisibleModuleHeaders_003Ed__29 _003CGetVisibleModuleHeaders_003Ed__ = default(_003CGetVisibleModuleHeaders_003Ed__29);
		_003CGetVisibleModuleHeaders_003Ed__._003C_003E4__this = this;
		_003CGetVisibleModuleHeaders_003Ed__.moduleUid = moduleUid;
		_003CGetVisibleModuleHeaders_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>>.Create();
		_003CGetVisibleModuleHeaders_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ComponentMetadataItemHeader>> _003C_003Et__builder = _003CGetVisibleModuleHeaders_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetVisibleModuleHeaders_003Ed__29>(ref _003CGetVisibleModuleHeaders_003Ed__);
		return _003CGetVisibleModuleHeaders_003Ed__._003C_003Et__builder.get_Task();
	}

	public Guid GetItemUidByMetadataUid(Guid uid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		Guid result = default(Guid);
		if (((IDictionary<Guid, Guid>)components).TryGetValue(uid, ref result))
		{
			return result;
		}
		return Guid.Empty;
	}

	public ComponentMetadataItem LoadItemByMetadataUid(Guid uid)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		Guid itemUidByMetadataUid = GetItemUidByMetadataUid(uid);
		if (itemUidByMetadataUid == Guid.Empty)
		{
			return null;
		}
		ComponentMetadataItem result = default(ComponentMetadataItem);
		if (((IDictionary<Guid, ComponentMetadataItem>)drafts).TryGetValue(itemUidByMetadataUid, ref result))
		{
			return result;
		}
		if (((IDictionary<Guid, ComponentMetadataItem>)items).TryGetValue(itemUidByMetadataUid, ref result))
		{
			return result;
		}
		return null;
	}

	public ComponentMetadataItemHeader LoadHeaderByMetadataUid(Guid uid)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		ComponentMetadataItem val = LoadItemByMetadataUid(uid);
		if (val != null)
		{
			return ((IDictionary<Guid, ComponentMetadataItemHeader>)headers).get_Item(val.get_Header_Uid());
		}
		return null;
	}

	internal void RegisterItem(ComponentMetadataItem item)
	{
		LocalSaveFormMetadataItem(item);
	}

	internal bool CheckItem(Guid itemUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return ((IDictionary<Guid, ComponentMetadataItem>)items).ContainsKey(itemUid);
	}

	private System.Threading.Tasks.Task<ComponentMetadataItem> SaveAndUpdate(ComponentMetadataItem metadata)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CSaveAndUpdate_003Ed__35 _003CSaveAndUpdate_003Ed__ = default(_003CSaveAndUpdate_003Ed__35);
		_003CSaveAndUpdate_003Ed__._003C_003E4__this = this;
		_003CSaveAndUpdate_003Ed__.metadata = metadata;
		_003CSaveAndUpdate_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ComponentMetadataItem>.Create();
		_003CSaveAndUpdate_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ComponentMetadataItem> _003C_003Et__builder = _003CSaveAndUpdate_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CSaveAndUpdate_003Ed__35>(ref _003CSaveAndUpdate_003Ed__);
		return _003CSaveAndUpdate_003Ed__._003C_003Et__builder.get_Task();
	}

	private void LocalSaveFormMetadataItems(System.Collections.Generic.IEnumerable<ComponentMetadataItem> result)
	{
		System.Collections.Generic.IEnumerator<ComponentMetadataItem> enumerator = result.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ComponentMetadataItem current = enumerator.get_Current();
				LocalSaveFormMetadataItem(current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private void LocalSaveFormMetadataItem(ComponentMetadataItem item)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (item == null)
		{
			return;
		}
		if (item.get_IsPublished())
		{
			((IDictionary<Guid, ComponentMetadataItem>)items).set_Item(item.get_Uid(), item);
			ComponentMetadata metadata = item.get_Metadata();
			if (metadata.get_ImplementationForms().get_Count() > 0)
			{
				System.Collections.Generic.IEnumerator<ImplementationForm> enumerator = ((System.Collections.Generic.IEnumerable<ImplementationForm>)metadata.get_ImplementationForms()).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						ImplementationForm current = enumerator.get_Current();
						dataClassMetadataItemManager.RegisterForm(current, metadata);
					}
				}
				finally
				{
					((System.IDisposable)enumerator)?.Dispose();
				}
			}
			customComponentCacheService.RegisterComponent(metadata, item.get_Header_Uid());
		}
		else
		{
			((IDictionary<Guid, ComponentMetadataItem>)drafts).set_Item(item.get_Uid(), item);
		}
		((IDictionary<Guid, Guid>)components).set_Item(((IMetadata)item.get_Metadata()).get_Uid(), item.get_Uid());
	}

	public override System.Threading.Tasks.Task<IUpdateModel> SaveAndUpdate(IUpdateModel updateModel)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CSaveAndUpdate_003Ed__38 _003CSaveAndUpdate_003Ed__ = default(_003CSaveAndUpdate_003Ed__38);
		_003CSaveAndUpdate_003Ed__._003C_003E4__this = this;
		_003CSaveAndUpdate_003Ed__.updateModel = updateModel;
		_003CSaveAndUpdate_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<IUpdateModel>.Create();
		_003CSaveAndUpdate_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IUpdateModel> _003C_003Et__builder = _003CSaveAndUpdate_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CSaveAndUpdate_003Ed__38>(ref _003CSaveAndUpdate_003Ed__);
		return _003CSaveAndUpdate_003Ed__._003C_003Et__builder.get_Task();
	}

	public override System.Threading.Tasks.Task<IUpdateModel> SaveAndPublish(IUpdateModel updateModel)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CSaveAndPublish_003Ed__39 _003CSaveAndPublish_003Ed__ = default(_003CSaveAndPublish_003Ed__39);
		_003CSaveAndPublish_003Ed__._003C_003E4__this = this;
		_003CSaveAndPublish_003Ed__.updateModel = updateModel;
		_003CSaveAndPublish_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<IUpdateModel>.Create();
		_003CSaveAndPublish_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IUpdateModel> _003C_003Et__builder = _003CSaveAndPublish_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CSaveAndPublish_003Ed__39>(ref _003CSaveAndPublish_003Ed__);
		return _003CSaveAndPublish_003Ed__._003C_003Et__builder.get_Task();
	}
}
