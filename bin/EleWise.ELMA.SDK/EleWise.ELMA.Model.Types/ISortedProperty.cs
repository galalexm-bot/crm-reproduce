using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Types;

public interface ISortedProperty
{
	bool IsSupportSort();

	IComparer GetComparer(Type sourceType, LambdaExpression propertyFunc, ListSortDirection order);

	IComparer<TSource> GetComparer<TSource, TKey>(Func<TSource, TKey> propertyFunc, ListSortDirection order);
}
