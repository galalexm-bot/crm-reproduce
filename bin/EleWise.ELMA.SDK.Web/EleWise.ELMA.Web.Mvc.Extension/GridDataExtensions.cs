using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;
using Telerik.Web.Mvc.Infrastructure;

namespace EleWise.ELMA.Web.Mvc.Extensions;

public static class GridDataExtensions
{
	private class SetEqualityComparer
	{
		private class InternalEqualityComparer<T> : IEqualityComparer<object>
		{
			public new bool Equals(object x, object y)
			{
				if (x == null && y == null)
				{
					return true;
				}
				if (x == null || y == null)
				{
					return false;
				}
				if (((ICollection<T>)x).Count != ((ICollection<T>)y).Count)
				{
					return false;
				}
				HashSet<T> hashSet = new HashSet<T>((ICollection<T>)x);
				return ((ICollection<T>)y).All(hashSet.Remove);
			}

			public int GetHashCode(object obj)
			{
				if (obj == null)
				{
					return 0;
				}
				EqualityComparer<T> @default = EqualityComparer<T>.Default;
				List<int> list = ((IEnumerable<T>)obj).Select(@default.GetHashCode).ToList();
				list.Sort();
				return list.Aggregate(17, (int a, int h) => a * 23 + h);
			}
		}

		public static IEqualityComparer<object> Create(Type propertyType)
		{
			Type @interface = propertyType.GetInterface(typeof(ISet<>).FullName);
			if (@interface == null)
			{
				return null;
			}
			Type type = @interface.GetGenericArguments()[0];
			return (IEqualityComparer<object>)Activator.CreateInstance(typeof(InternalEqualityComparer<>).MakeGenericType(type));
		}
	}

	public static GridData<TModel> CreateGridData<TModel>([NotNull] this IEntityManager<TModel> manager, GridCommand command) where TModel : IEntity
	{
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		GridData<TModel> gridData = new GridData<TModel>();
		gridData.Command = command;
		gridData.SetCount((GridData<TModel> d, FetchOptions f) => manager.Count());
		gridData.SetDataSource((GridData<TModel> d, FetchOptions f) => (d.Count <= 0) ? new List<TModel>() : manager.Find(f));
		return gridData;
	}

	public static FetchOptions GetFetchOptions(this GridCommand command)
	{
		if (command == null)
		{
			return FetchOptions.All;
		}
		string text = command.get_SortExpressionString();
		ListSortDirection sortDirection = command.get_SortDirection();
		if (string.IsNullOrEmpty(text) && command.get_SortDescriptors() != null && command.get_SortDescriptors().Any())
		{
			text = command.get_SortDescriptors().First().get_Member();
			sortDirection = command.get_SortDescriptors().First().get_SortDirection();
		}
		return new FetchOptions(command.get_PageSize() * (command.get_Page() - 1), command.get_PageSize(), sortDirection, text);
	}

	public static GridData<TModel, TFilter> CreateGridData<TModel, TFilter>([NotNull] this IEntityManager<TModel> manager, GridCommand command, TFilter filter = null) where TModel : IEntity where TFilter : class, IEntityFilter
	{
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		return manager.CreateGridData<TModel, TFilter, TModel>(command, filter);
	}

	public static GridData<TOutput, TFilter> CreateGridData<TModel, TFilter, TOutput>([NotNull] this IEntityManager<TModel> manager, GridCommand command, TFilter filter = null) where TModel : IEntity where TFilter : class, IEntityFilter
	{
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		GridData<TOutput, TFilter> gridData = new GridData<TOutput, TFilter>();
		gridData.DataFilter = filter;
		gridData.Command = command;
		gridData.SetCount((GridData<TOutput, TFilter> d, FetchOptions f) => manager.Count(d.DataFilter));
		gridData.SetDataSource(delegate(GridData<TOutput, TFilter> d, FetchOptions f)
		{
			ICollection<TModel> collection2;
			if (d.Count <= 0)
			{
				ICollection<TModel> collection = new List<TModel>();
				collection2 = collection;
			}
			else
			{
				collection2 = manager.Find(d.DataFilter, f);
			}
			ICollection<TModel> collection3 = collection2;
			return (!(typeof(TModel) != typeof(TOutput))) ? ((IEnumerable)collection3) : ((IEnumerable)collection3.Cast<TOutput>());
		});
		return gridData;
	}

	public static GridData<T> CreateGridData<T>(this IEnumerable<T> source, params string[] groupMemebers) where T : class
	{
		GridData<T> gridData = new GridData<T>
		{
			DataSource = source,
			IsAjax = false,
			IsPageable = false
		};
		gridData.SetCount((GridData<T> d, FetchOptions f) => source.Count());
		if (groupMemebers != null && groupMemebers.Any())
		{
			foreach (string text in groupMemebers)
			{
				if (typeof(T).GetReflectionProperty(text) == null)
				{
					throw new ArgumentException(SR.T("неправильно имя свойства {0}", text), "groupMemebers");
				}
				gridData.GroupDescriptors = new List<GridGroupDescriptor>
				{
					new GridGroupDescriptor
					{
						Member = text,
						SortDirection = ListSortDirection.Ascending
					}
				};
			}
			gridData.DataSource = ApplyGrouping((IEnumerable<string>)groupMemebers, source);
		}
		return gridData;
	}

	public static IEnumerable ApplyAll<T>(this GridCommand command, IEnumerable<T> items)
	{
		if (items == null || command == null)
		{
			return items;
		}
		items = command.ApplySorting(items);
		items = command.ApplyPaging(items);
		if (command.get_GroupDescriptors().Any())
		{
			return command.ApplyGrouping(items);
		}
		return items.ToList();
	}

	public static IEnumerable<T> ApplySorting<T>(this GridCommand command, IEnumerable<T> items)
	{
		if (command.get_SortDescriptors().Any())
		{
			foreach (SortDescriptor sortDescriptor in command.get_SortDescriptors())
			{
				items = AddSortExpression(items, sortDescriptor.get_SortDirection(), sortDescriptor.get_Member());
			}
		}
		if (command.get_GroupDescriptors().Any())
		{
			foreach (GroupDescriptor item in command.get_GroupDescriptors().Reverse())
			{
				items = AddSortExpression(items, ((SortDescriptor)item).get_SortDirection(), ((SortDescriptor)item).get_Member());
			}
			return items;
		}
		return items;
	}

	public static IEnumerable<T> ApplyPaging<T>(this GridCommand command, IEnumerable<T> items)
	{
		int pageSize = command.get_PageSize();
		int page = command.get_Page();
		if (pageSize > 0 && page > 0)
		{
			items = items.Skip((page - 1) * pageSize);
		}
		return items.Take(pageSize);
	}

	public static IEnumerable ApplyGrouping<T>(this GridCommand command, IEnumerable<T> items)
	{
		if (command.get_GroupDescriptors() == null || !command.get_GroupDescriptors().Any())
		{
			return items;
		}
		return ApplyGrouping(from d in command.get_GroupDescriptors()
			select ((SortDescriptor)d).get_Member(), items);
	}

	public static IEnumerable ApplyGrouping<T>(IEnumerable<string> groupMemebers, IEnumerable<T> items)
	{
		if (groupMemebers == null || !groupMemebers.Any())
		{
			return items;
		}
		Func<IEnumerable<T>, IEnumerable<AggregateFunctionsGroup>> func = null;
		foreach (string item in groupMemebers.Reverse())
		{
			string[] source = item.Split('.');
			Type type = typeof(T);
			PropertyInfo[] array = source.Select(delegate(string name)
			{
				PropertyInfo reflectionProperty = type.GetReflectionProperty(name);
				type = ((reflectionProperty != null) ? reflectionProperty.PropertyType : null);
				return reflectionProperty;
			}).ToArray();
			if (array.Any((PropertyInfo p) => p == null || !p.CanRead))
			{
				continue;
			}
			_ = type;
			string memberCopy = item;
			PropertyInfo[] propsCopy = array;
			IEqualityComparer<object> comparer = SetEqualityComparer.Create(array[array.Length - 1].PropertyType);
			func = ((func != null) ? BuildGroup((T i) => propsCopy.Aggregate(i, (object a, PropertyInfo info) => (a != null) ? info.GetValue(a, null) : null), comparer, func, memberCopy) : ((Func<IEnumerable<T>, IEnumerable<AggregateFunctionsGroup>>)((IEnumerable<T> localItems) => BuildInnerGroup(localItems, (T i) => propsCopy.Aggregate(i, (object a, PropertyInfo info) => (a != null) ? info.GetValue(a, null) : null), comparer, memberCopy))));
		}
		if (func == null)
		{
			return items;
		}
		return func(items).ToList();
	}

	public static IEnumerable ApplyTableGrouping(IEnumerable<string> groupMemebers, IEnumerable<DataRowView> items)
	{
		if (groupMemebers == null || !groupMemebers.Any())
		{
			return items;
		}
		Func<IEnumerable<DataRowView>, IEnumerable<AggregateFunctionsGroup>> func = null;
		foreach (string item in groupMemebers.Reverse())
		{
			List<string> list = new List<string> { item };
			string memberCopy = item;
			List<string> propsCopy = list;
			func = ((func != null) ? BuildGroup((DataRowView i) => propsCopy.Aggregate(i, (object row, string column) => ((DataRowView)row)[column]), null, func, memberCopy) : ((Func<IEnumerable<DataRowView>, IEnumerable<AggregateFunctionsGroup>>)((IEnumerable<DataRowView> localItems) => BuildInnerGroup(localItems, (DataRowView i) => propsCopy.Aggregate(i, (object row, string column) => ((DataRowView)row)[column]), null, memberCopy))));
		}
		if (func == null)
		{
			return items;
		}
		return func(items).ToList();
	}

	private static IEnumerable<T> AddSortExpression<T>(IEnumerable<T> items, ListSortDirection sortDirection, string memberName)
	{
		string[] source = memberName.Split('.');
		Type type = typeof(T);
		PropertyInfo[] props = source.Select(delegate(string name)
		{
			PropertyInfo reflectionProperty = type.GetReflectionProperty(name);
			type = ((reflectionProperty != null) ? reflectionProperty.PropertyType : null);
			return reflectionProperty;
		}).ToArray();
		if (props.Any((PropertyInfo p) => p == null || !p.CanRead))
		{
			return items;
		}
		bool isComparable = typeof(IComparable).IsAssignableFrom(type) || (type.GetGenericArguments().Length == 1 && type.GetGenericTypeDefinition() == typeof(Nullable<>) && typeof(IComparable).IsAssignableFrom(type.GetGenericArguments()[0]));
		if (sortDirection != 0)
		{
			return items.OrderByDescending((T i) => GetValue(props, i, isComparable));
		}
		return items.OrderBy((T i) => GetValue(props, i, isComparable));
	}

	private static object GetValue(IEnumerable<PropertyInfo> properties, object item, bool isComparable)
	{
		object obj = properties.Aggregate(item, (object a, PropertyInfo info) => (a != null) ? info.GetValue(a, null) : null);
		if (!isComparable)
		{
			return obj?.ToString();
		}
		return obj;
	}

	private static Func<IEnumerable<T>, IEnumerable<AggregateFunctionsGroup>> BuildGroup<T, TValue>(Func<T, TValue> groupSelector, IEqualityComparer<TValue> comparer, Func<IEnumerable<T>, IEnumerable<AggregateFunctionsGroup>> selectorBuilder, string memberName)
	{
		return (IEnumerable<T> g) => g.GroupBy(groupSelector, comparer).Select((Func<IGrouping<TValue, T>, AggregateFunctionsGroup>)delegate(IGrouping<TValue, T> c)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected O, but got Unknown
			AggregateFunctionsGroup val = new AggregateFunctionsGroup();
			((Group)val).set_Key((object)c.Key);
			((Group)val).set_KeyMember(memberName);
			((Group)val).set_HasSubgroups(true);
			((Group)val).set_Items((IEnumerable)selectorBuilder(c).ToList());
			return val;
		});
	}

	private static IEnumerable<AggregateFunctionsGroup> BuildInnerGroup<T, TValue>(IEnumerable<T> group, Func<T, TValue> groupSelector, IEqualityComparer<TValue> comparer, string memberName)
	{
		return group.GroupBy(groupSelector, comparer).Select((Func<IGrouping<TValue, T>, AggregateFunctionsGroup>)delegate(IGrouping<TValue, T> i)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			AggregateFunctionsGroup val = new AggregateFunctionsGroup();
			((Group)val).set_Key((object)i.Key);
			((Group)val).set_KeyMember(memberName);
			((Group)val).set_Items((IEnumerable)i.ToList());
			return val;
		});
	}
}
