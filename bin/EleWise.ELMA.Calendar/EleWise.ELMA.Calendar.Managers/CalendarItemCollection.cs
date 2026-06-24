using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Calendar.Managers;

public class CalendarItemCollection : ICollection<ICalendarItem>, IEnumerable<ICalendarItem>, IEnumerable
{
	public IList<ICalendarItem> Items { get; set; }

	public int Count { get; private set; }

	public bool IsReadOnly { get; private set; }

	public CalendarItemCollection()
	{
		Items = new List<ICalendarItem>();
	}

	public IEnumerable<ICalendarItem> OfType<T>()
	{
		return Items.Where((ICalendarItem q) => q.SourceTypeUid == InterfaceActivator.UID(typeof(T)));
	}

	public IEnumerable<T> OfTypeConvert<T>()
	{
		IEnumerable<ICalendarItem> items = Items.Where((ICalendarItem q) => q.SourceTypeUid == InterfaceActivator.UID(typeof(T)));
		return CalendarEventManager.Instance.ConvertToEntityList<T>(items);
	}

	public IEnumerator<ICalendarItem> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public void Add(ICalendarItem item)
	{
		Items.Add(item);
	}

	public void Clear()
	{
		Items.Clear();
	}

	public bool Contains(ICalendarItem item)
	{
		return Items.Contains(item);
	}

	public void CopyTo(ICalendarItem[] array, int arrayIndex)
	{
		Items.CopyTo(array, arrayIndex);
	}

	public bool Remove(ICalendarItem item)
	{
		return Items.Remove(item);
	}
}
