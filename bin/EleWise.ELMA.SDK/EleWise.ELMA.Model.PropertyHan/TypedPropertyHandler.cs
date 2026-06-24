using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.PropertyHandlers;

[Component]
public abstract class TypedPropertyHandler : IPropertyHandler
{
	internal static TypedPropertyHandler WDtMFiWcZ3RKvACmKL9J;

	public abstract Guid Uid { get; }

	public abstract string Name { get; }

	protected abstract Guid? TypeUid { get; }

	protected virtual Guid? SubTypeUid => Guid.Empty;

	protected virtual bool Multiple => false;

	protected virtual bool AllowOtherHandlers => false;

	public virtual bool IsAvailableFor(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, Guid typeUid, Guid subTypeUid, IEnumerable<PropertyHandlerInfo> currentHandlers)
	{
		Contract.ArgumentNotNull(classMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629711930));
		Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A5B395));
		List<PropertyHandlerInfo> list = ((currentHandlers != null) ? currentHandlers.ToList() : new List<PropertyHandlerInfo>());
		if (!Multiple && list.FirstOrDefault((PropertyHandlerInfo h) => GpvcsTWcRfqLRHfXk4Q9(rwpWeyWcSXKVnBjEZ7El(h), L0AIrhWciVfjdp8sEFZK(this))) != null)
		{
			return false;
		}
		if (!AllowOtherHandlers && list.Count > 0)
		{
			return false;
		}
		if (!TypeUid.HasValue)
		{
			return true;
		}
		if (TypeUid.Value != typeUid)
		{
			return false;
		}
		if (!SubTypeUid.HasValue)
		{
			return true;
		}
		if (SubTypeUid.Value != subTypeUid)
		{
			return false;
		}
		return true;
	}

	protected TypedPropertyHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fsJr6dWcV7NJ1yPQPjff();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void fsJr6dWcV7NJ1yPQPjff()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool vNgrrVWcukjZPvMqApIW()
	{
		return WDtMFiWcZ3RKvACmKL9J == null;
	}

	internal static TypedPropertyHandler TbUyQGWcIJWRQc7wPjvi()
	{
		return WDtMFiWcZ3RKvACmKL9J;
	}

	internal static Guid rwpWeyWcSXKVnBjEZ7El(object P_0)
	{
		return ((PropertyHandlerInfo)P_0).HandlerUid;
	}

	internal static Guid L0AIrhWciVfjdp8sEFZK(object P_0)
	{
		return ((TypedPropertyHandler)P_0).Uid;
	}

	internal static bool GpvcsTWcRfqLRHfXk4Q9(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
