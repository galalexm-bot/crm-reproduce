using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using Iesi.Collections.Generic;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Extensions;

[ExtensionPoint(ComponentType.All)]
public interface IWorkflowContextPropertyObserver
{
	IEnumerable<WorkflowContextPropertyObserverInfo> ObservedInfos { get; }
}
public static class IWorkflowContextPropertyObserverExtensions
{
	internal static IWorkflowContextPropertyObserverExtensions gXwCuHImfU3X37vPsYM;

	public static IEnumerable<Guid> GetAllObservedTypeUids(this IWorkflowContextPropertyObserver observer)
	{
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
		CS_0024_003C_003E8__locals0.observer = observer;
		return (IEnumerable<Guid>)ContextVars.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-135674354 ^ -135752036) + CS_0024_003C_003E8__locals0.observer.GetType().FullName, () => new HashedSet<Guid>((ICollection<Guid>)CS_0024_003C_003E8__locals0.observer.ObservedInfos.Select((WorkflowContextPropertyObserverInfo i) => i.TypeUid).Distinct().ToList()));
	}

	public static IEnumerable<Guid> GetAllBaseObservedSubTypeUids(this IWorkflowContextPropertyObserver observer)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.observer = observer;
		return (IEnumerable<Guid>)ContextVars.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x759227C) + CS_0024_003C_003E8__locals0.observer.GetType().FullName, () => new HashedSet<Guid>((ICollection<Guid>)CS_0024_003C_003E8__locals0.observer.ObservedInfos.SelectMany((WorkflowContextPropertyObserverInfo i) => i.SubTypeUid).Distinct().ToList()));
	}

	public static IEnumerable<Guid> GetAllObservedSubTypeUids(this IWorkflowContextPropertyObserver observer)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals0.observer = observer;
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.observer, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1776305410 ^ -1776358418));
		return (IEnumerable<Guid>)ContextVars.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46FF2F5) + CS_0024_003C_003E8__locals0.observer.GetType().FullName, () => new HashedSet<Guid>((ICollection<Guid>)(from md in CS_0024_003C_003E8__locals0.observer.ObservedInfos.SelectMany((WorkflowContextPropertyObserverInfo i) => i.SubTypeUid).SelectMany((Guid uid) => MetadataLoader.GetChildClasses(uid, loadImplementation: false, includeRoot: true))
			select _003C_003Ec.lPq9BgZaCeuZVAfqsWu0(md)).Distinct().ToList()));
	}

	public static bool CanObserveProperty(this IWorkflowContextPropertyObserver observer, PropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_009b, IL_00aa
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				Contract.ArgumentNotNull(observer, (string)X1AhcCI5SGEtL1YRsK2(-1303601216 ^ -1303523632));
				num2 = 2;
				break;
			case 2:
				if (!observer.GetAllObservedTypeUids().Contains(As5EVFIg8TmA3XWQLES(propMd)))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return observer.GetAllObservedSubTypeUids().Contains(jAVkNLIBfD1w7O7WH4Z(propMd));
			case 1:
				return false;
			}
		}
	}

	internal static object X1AhcCI5SGEtL1YRsK2(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid As5EVFIg8TmA3XWQLES(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static Guid jAVkNLIBfD1w7O7WH4Z(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static bool x2iMaAIt3XqWZkCcPK6()
	{
		return gXwCuHImfU3X37vPsYM == null;
	}

	internal static IWorkflowContextPropertyObserverExtensions Mp8rseIb9rmuabVpBW8()
	{
		return gXwCuHImfU3X37vPsYM;
	}
}
