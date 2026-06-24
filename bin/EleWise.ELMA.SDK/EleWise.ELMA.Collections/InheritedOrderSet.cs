using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using Iesi.Collections;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Collections;

[Obsolete("Use InheritedSet<TSource, TTarget> instead", true)]
public class InheritedOrderSet<TSource, TTarget, TKey> : InheritedSet<TSource, TTarget>, ISet<TTarget>, ISet<TTarget>, ICollection<TTarget>, IEnumerable<TTarget>, IEnumerable, IInheritedSet, ISet, ICollection where TSource : class where TTarget : class
{
	private readonly IComparer<TSource> comparer;

	private static object nrwqlw0gBBABULEre58;

	public InheritedOrderSet(ISet<TSource> source, Guid typeUidProperty, Guid subTypeUidProperty, Func<TSource, TKey> propertyExpression, ListSortDirection order)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(source);
		ITypeDescriptor typeDescriptor = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeDescriptor(typeUidProperty, subTypeUidProperty);
		if (!(typeDescriptor is ISortedProperty sortedProperty))
		{
			throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488840517), typeDescriptor.GetType().FullName));
		}
		comparer = sortedProperty.GetComparer(propertyExpression, order);
		if (comparer == null)
		{
			throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633538631), typeDescriptor.GetType().FullName));
		}
	}

	public override IEnumerator<TTarget> GetEnumerator()
	{
		return new EnumeratorT(new SortedSet<TSource>((IEnumerable<TSource>)source, comparer).GetEnumerator());
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new SortedSet<TSource>((IEnumerable<TSource>)source, comparer).GetEnumerator();
	}

	internal static bool seQ7jh056PjwhZLhe8o()
	{
		return nrwqlw0gBBABULEre58 == null;
	}

	internal static object ey2Adr0j2h33llIgM4u()
	{
		return nrwqlw0gBBABULEre58;
	}
}
