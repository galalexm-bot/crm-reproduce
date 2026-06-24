using System;
using System.Reflection;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

public static class ActivityExecutionContextHelper
{
	public interface IItemSetter : IDisposable
	{
	}

	private class ItemSetter<T> : IItemSetter, IDisposable where T : class
	{
		private string _key;

		private T _old;

		private static object vfsklgZGXw0QKfZ4UITl;

		public ItemSetter(T queueItem, string key)
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			_key = key;
			ContextVars.TryGetValue<T>(_key, out _old);
			ContextVars.Set(_key, queueItem);
		}

		public void Dispose()
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
					ContextVars.Set(_key, _old);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static bool eMQm3FZGdxopV2d16u63()
		{
			return vfsklgZGXw0QKfZ4UITl == null;
		}

		internal static object sLA0uCZGuga74SbrwdoP()
		{
			return vfsklgZGXw0QKfZ4UITl;
		}
	}

	private class QueueItemSetter : ItemSetter<IWorkflowQueueItem>
	{
		internal static object dSGtDeZGDEHZZyvP7jBq;

		public QueueItemSetter(IWorkflowQueueItem queueItem)
		{
			//Discarded unreachable code: IL_0030, IL_0035
			SGw9KWZGLgTXhqyQnZBa();
			base._002Ector(queueItem, QueueItemKey);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void SGw9KWZGLgTXhqyQnZBa()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static bool hoK4nDZGniJPYLCInRWI()
		{
			return dSGtDeZGDEHZZyvP7jBq == null;
		}

		internal static QueueItemSetter BRnDp4ZGHAS4MZsvNOiA()
		{
			return (QueueItemSetter)dSGtDeZGDEHZZyvP7jBq;
		}
	}

	private class WorkflowInstanceSetter : ItemSetter<IWorkflowInstance>
	{
		internal static object ajoW7tZGfK9Gd53I4eAj;

		public WorkflowInstanceSetter(IWorkflowInstance instance)
		{
			//Discarded unreachable code: IL_0030, IL_0035
			sKDVX3ZGj1O2TDHc70yt();
			base._002Ector(instance, WorkflowInstanceKey);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void sKDVX3ZGj1O2TDHc70yt()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static bool zdHjXGZG9cq4hBoI4rdc()
		{
			return ajoW7tZGfK9Gd53I4eAj == null;
		}

		internal static WorkflowInstanceSetter ikq8wEZGWF2oaJUPOHIP()
		{
			return (WorkflowInstanceSetter)ajoW7tZGfK9Gd53I4eAj;
		}
	}

	private class WorkflowBookmarkSetter : ItemSetter<IWorkflowBookmark>
	{
		internal static object VQW4lLZGR7CNvVuTLiiR;

		public WorkflowBookmarkSetter(IWorkflowBookmark bookmark)
		{
			//Discarded unreachable code: IL_0030, IL_0035
			ETQqkoZG3VtcwAZAoANH();
			base._002Ector(bookmark, WorkflowBookmarkKey);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void ETQqkoZG3VtcwAZAoANH()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static bool mlQWgpZG6nh5LBO8ThBc()
		{
			return VQW4lLZGR7CNvVuTLiiR == null;
		}

		internal static WorkflowBookmarkSetter z3oxn7ZGqlcW6wAyZ0uj()
		{
			return (WorkflowBookmarkSetter)VQW4lLZGR7CNvVuTLiiR;
		}
	}

	private class ElementSetter : ItemSetter<Element>
	{
		internal static object NQEuiHZGTfhVhvNTr5JN;

		public ElementSetter(Element element)
		{
			//Discarded unreachable code: IL_0030, IL_0035
			tgdDB1ZGCD1oMwBjqLlU();
			base._002Ector(element, ElementKey);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void tgdDB1ZGCD1oMwBjqLlU()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static bool aqeJwmZGQ2inqZ3SNdp7()
		{
			return NQEuiHZGTfhVhvNTr5JN == null;
		}

		internal static ElementSetter SB402qZGp42jB2kQbQ52()
		{
			return (ElementSetter)NQEuiHZGTfhVhvNTr5JN;
		}
	}

	private static readonly string QueueItemKey;

	private static readonly string WorkflowInstanceKey;

	private static readonly string WorkflowBookmarkKey;

	private static readonly string ElementKey;

	private static ActivityExecutionContextHelper YRdkssCUNKurssd3Xk1;

	public static IActivityExecutionContext Get()
	{
		IActivityExecutionContext activityExecutionContext = InterfaceActivator.Create<IActivityExecutionContext>();
		ContextVars.TryGetValue<IWorkflowQueueItem>(QueueItemKey, out var value);
		sWUehmCGpKjEQYHH2jv(activityExecutionContext, value);
		ContextVars.TryGetValue<IWorkflowInstance>(WorkflowInstanceKey, out var value2);
		vK0CSUC7NDT812m7nVm(activityExecutionContext, value2);
		ContextVars.TryGetValue<IWorkflowBookmark>(WorkflowBookmarkKey, out var value3);
		j7JTu6C209T8qqC0d4U(activityExecutionContext, value3);
		ContextVars.TryGetValue<Element>(ElementKey, out var value4);
		YAgokeCoe7dPiyF4Ynt(activityExecutionContext, value4);
		return activityExecutionContext;
	}

	public static IItemSetter SetQueueItem(IWorkflowQueueItem queueItem)
	{
		return new QueueItemSetter(queueItem);
	}

	public static IItemSetter SetWorkflowInstance(IWorkflowInstance instance)
	{
		return new WorkflowInstanceSetter(instance);
	}

	public static IItemSetter SetBookmark(IWorkflowBookmark bookmark)
	{
		return new WorkflowBookmarkSetter(bookmark);
	}

	public static IItemSetter SetElement(Element element)
	{
		return new ElementSetter(element);
	}

	static ActivityExecutionContextHelper()
	{
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				WorkflowInstanceKey = dWVHDBCFbvYRTLRWFFm(typeof(ActivityExecutionContextHelper).TypeHandle).Name + (string)HRSYUgCIacBgu632fOl(-1965291699 ^ -1965232107);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				QueueItemKey = (string)iMLHgkCabSllgKIeIJo(JZMVNkCibiycYWWg34S(dWVHDBCFbvYRTLRWFFm(typeof(ActivityExecutionContextHelper).TypeHandle)), HRSYUgCIacBgu632fOl(-1361036319 ^ -1360999213));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				WorkflowBookmarkKey = (string)iMLHgkCabSllgKIeIJo(JZMVNkCibiycYWWg34S(typeof(ActivityExecutionContextHelper)), HRSYUgCIacBgu632fOl(-2002063381 ^ -2002118553));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				ElementKey = (string)JZMVNkCibiycYWWg34S(dWVHDBCFbvYRTLRWFFm(typeof(ActivityExecutionContextHelper).TypeHandle)) + (string)HRSYUgCIacBgu632fOl(-1647793954 ^ -1647812834);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void sWUehmCGpKjEQYHH2jv(object P_0, object P_1)
	{
		((IActivityExecutionContext)P_0).QueueItem = (IWorkflowQueueItem)P_1;
	}

	internal static void vK0CSUC7NDT812m7nVm(object P_0, object P_1)
	{
		((IActivityExecutionContext)P_0).Instance = (IWorkflowInstance)P_1;
	}

	internal static void j7JTu6C209T8qqC0d4U(object P_0, object P_1)
	{
		((IActivityExecutionContext)P_0).Bookmark = (IWorkflowBookmark)P_1;
	}

	internal static void YAgokeCoe7dPiyF4Ynt(object P_0, object P_1)
	{
		((IActivityExecutionContext)P_0).Element = (Element)P_1;
	}

	internal static bool j887kxCVbDUHMlHbTkj()
	{
		return YRdkssCUNKurssd3Xk1 == null;
	}

	internal static ActivityExecutionContextHelper xr0jUwCAUCGeqw9lO6u()
	{
		return YRdkssCUNKurssd3Xk1;
	}

	internal static Type dWVHDBCFbvYRTLRWFFm(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object JZMVNkCibiycYWWg34S(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object HRSYUgCIacBgu632fOl(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object iMLHgkCabSllgKIeIJo(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}
}
