using System;
using System.Collections;
using Bridge;
using EleWise.ELMA.Core;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Collections;

public static class ReactiveCollectionExtensions
{
	public static void Update<T>(this IReactiveCollection collection, T oldInstance, T newInstance)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (collection.IndexOf(oldInstance) == -1)
		{
			throw new ArgumentException(SR.T("Не найден экземпляр в коллекции"));
		}
		if (newInstance is ReactiveProxy)
		{
			ConvertHelper.Reconcile(oldInstance, newInstance);
		}
	}

	internal static IReactiveCollection CreateSpecificCollection(string typeUid, ConvertContext convertContext)
	{
		return Script.Write<IReactiveCollection>("new (Reactive.EleWise.ELMA.Collections.ReactiveCollection$1(EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType(\"{0}\"))).ctor({1})", new object[2] { typeUid, convertContext });
	}

	internal static System.Collections.ICollection CreateSpecificISet(string typeUid, ConvertContext convertContext)
	{
		return Script.Write<System.Collections.ICollection>("new (Reactive.EleWise.ELMA.Collections.ReactiveSet$1(EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType(\"{0}\"))).ctor(undefined, {1})", new object[2] { typeUid, convertContext });
	}
}
