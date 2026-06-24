using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public abstract class WorkflowBaseManager<T> : CompositeEntityManager<T, long> where T : class, ICompositeEntity<long>
{
	private static object oPckEIPg9mopICjcdmF;

	[NotNull]
	public IContextBoundVariableService ContextService
	{
		[CompilerGenerated]
		get
		{
			return _003CContextService_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CContextService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public override T Create()
	{
		return Locator.GetService<T>() ?? Activator.CreateInstance<T>();
	}

	public override T LoadOrCreate(long id)
	{
		return LoadOrNull(id);
	}

	public override T LoadOrCreate(Guid uid)
	{
		T value = null;
		string name = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1756698829 ^ 0x68B54E4F) + typeof(T).AssemblyQualifiedName + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA736F74) + uid;
		if (ContextService != null && ContextService.TryGetValue<T>(name, out value))
		{
			return value;
		}
		if (value == null)
		{
			value = Create();
			PropertyInfo reflectionProperty = value.GetType().GetReflectionProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057715397));
			if (reflectionProperty != null)
			{
				reflectionProperty.SetValue(value, uid, null);
			}
			if (ContextService != null)
			{
				ContextService.Set(name, value);
			}
		}
		return value;
	}

	protected WorkflowBaseManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool KaS471PBr5myIQ7SeTE()
	{
		return oPckEIPg9mopICjcdmF == null;
	}

	internal static object KX8kEIPcOPFW1PWj6hO()
	{
		return oPckEIPg9mopICjcdmF;
	}
}
