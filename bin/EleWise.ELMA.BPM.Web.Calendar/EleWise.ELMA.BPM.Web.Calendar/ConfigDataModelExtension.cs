using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Projects.Models.Resources;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.BPM.Web.Calendar.Extensions;

public class ConfigDataModelExtension
{
	public static string BaseTimeIntervalCollectionSerialize(IEnumerable<IBaseTimeInterval> baseTimeIntervalCollection)
	{
		EntityJsonSerializer serializer = new EntityJsonSerializer();
		EntitySerializationSettings settings = new EntitySerializationSettings
		{
			Mode = EntitySerializationMode.Compact
		};
		return new JsonSerializer().Serialize(baseTimeIntervalCollection.Select((IBaseTimeInterval m) => serializer.ConvertToSerializable(m, settings)).ToArray());
	}

	public static IEnumerable<IBaseTimeInterval> BaseTimeIntervalCollectionDeserialize(string jsonBaseTimeIntervalCollection, bool loadEntityIfExists = true)
	{
		if (string.IsNullOrEmpty(jsonBaseTimeIntervalCollection))
		{
			return new List<IBaseTimeInterval>();
		}
		ExpandoObject[] source = new JsonSerializer().Deserialize<ExpandoObject[]>(jsonBaseTimeIntervalCollection);
		EntityJsonSerializer serializer = new EntityJsonSerializer();
		return source.Select((ExpandoObject s) => (IBaseTimeInterval)serializer.ConvertFromSerializable(s, InterfaceActivator.TypeOf<IBaseTimeInterval>(), loadEntityIfExists)).ToList();
	}

	public static string WorkingTimeIntervalCollectionSerialize(IEnumerable<IWorkTimeInterval> workingTimeIntervalCollection)
	{
		EntityJsonSerializer serializer = new EntityJsonSerializer();
		EntitySerializationSettings settings = new EntitySerializationSettings
		{
			Mode = EntitySerializationMode.Compact
		};
		return new JsonSerializer().Serialize(workingTimeIntervalCollection.Select((IWorkTimeInterval m) => serializer.ConvertToSerializable(m, settings)).ToArray());
	}

	public static IEnumerable<IWorkTimeInterval> WorkingTimeIntervalCollectionDeserialize(string jsonWorkingTimeIntervalCollection, bool loadEntityIfExists = true)
	{
		if (string.IsNullOrEmpty(jsonWorkingTimeIntervalCollection))
		{
			return new List<IWorkTimeInterval>();
		}
		ExpandoObject[] source = new JsonSerializer().Deserialize<ExpandoObject[]>(jsonWorkingTimeIntervalCollection);
		EntityJsonSerializer serializer = new EntityJsonSerializer();
		return source.Select((ExpandoObject s) => (IWorkTimeInterval)serializer.ConvertFromSerializable(s, InterfaceActivator.TypeOf<IWorkTimeInterval>(), loadEntityIfExists)).ToList();
	}

	public static string HolidayIntervalCollectionSerialize(IEnumerable<IHolidayInterval> jsonHolidayTimeIntervalCollection)
	{
		EntityJsonSerializer serializer = new EntityJsonSerializer();
		EntitySerializationSettings settings = new EntitySerializationSettings
		{
			Mode = EntitySerializationMode.Compact
		};
		return new JsonSerializer().Serialize(jsonHolidayTimeIntervalCollection.Select((IHolidayInterval m) => serializer.ConvertToSerializable(m, settings)).ToArray());
	}

	public static IEnumerable<IHolidayInterval> HolidayIntervalCollectionDeserialize(string jsonHolidayTimeIntervalCollection, bool loadEntityIfExists = true)
	{
		if (string.IsNullOrEmpty(jsonHolidayTimeIntervalCollection))
		{
			return new List<IHolidayInterval>();
		}
		ExpandoObject[] source = new JsonSerializer().Deserialize<ExpandoObject[]>(jsonHolidayTimeIntervalCollection);
		EntityJsonSerializer serializer = new EntityJsonSerializer();
		return source.Select((ExpandoObject s) => (IHolidayInterval)serializer.ConvertFromSerializable(s, InterfaceActivator.TypeOf<IHolidayInterval>(), loadEntityIfExists)).ToList();
	}

	public static bool IsBaseWorkingDay(IEnumerable<IBaseTimeInterval> baseTimeIntervalCollection, IEnumerable<IWorkTimeInterval> workingTimeIntervalCollection)
	{
		IOrderedEnumerable<TimeInterval> second = from bi in baseTimeIntervalCollection
			select new TimeInterval(bi.Start.ToClientDateTime(TZ.Server).TimeOfDay, (bi.Finish.ToClientDateTime(TZ.Server).TimeOfDay == TimeSpan.Zero) ? TimeSpan.FromDays(1.0) : bi.Finish.ToClientDateTime(TZ.Server).TimeOfDay) into bi
			orderby bi.Start
			select bi;
		return (from bi in workingTimeIntervalCollection
			select new TimeInterval(bi.Start.ToClientDateTime(TZ.Server).TimeOfDay, (bi.Finish.ToClientDateTime(TZ.Server).TimeOfDay == TimeSpan.Zero) ? TimeSpan.FromDays(1.0) : bi.Finish.ToClientDateTime(TZ.Server).TimeOfDay) into wi
			orderby wi.Start
			select wi).SequenceEqual(second);
	}

	public static IEnumerable<IWorkTimeInterval> NormalizeIntervalCollectionForUpdate(IEnumerable<IWorkTimeInterval> workingTimeIntervalCollection, int requiredTimeIntervalQuantity)
	{
		List<IWorkTimeInterval> list = workingTimeIntervalCollection.ToList();
		if (list.Count >= requiredTimeIntervalQuantity)
		{
			while (list.Count > requiredTimeIntervalQuantity)
			{
				IWorkTimeInterval workTimeInterval = list.FirstOrDefault((IWorkTimeInterval bi) => bi.Id <= 0);
				if (workTimeInterval != null)
				{
					list.Remove(workTimeInterval);
				}
				else
				{
					list = list.Take(list.Count - 1).ToList();
				}
			}
		}
		else
		{
			while (list.Count < requiredTimeIntervalQuantity)
			{
				list.Add(InterfaceActivator.Create<IWorkTimeInterval>());
			}
		}
		return list;
	}

	public static bool IsSimpleModeAllowed(IEnumerable<IWorkTimeInterval> workingTimeIntervals)
	{
		return IsSimpleModeAllowed(from bi in workingTimeIntervals
			select new TimeInterval(bi.Start.ToClientDateTime(TZ.Server).TimeOfDay, (bi.Finish.ToClientDateTime(TZ.Server).TimeOfDay == TimeSpan.Zero) ? TimeSpan.FromDays(1.0) : bi.Finish.ToClientDateTime(TZ.Server).TimeOfDay) into wi
			orderby wi.Start
			select wi);
	}

	public static bool IsSimpleModeAllowed(IEnumerable<TimeInterval> timeIntervals)
	{
		if (timeIntervals.Count() > 2)
		{
			return false;
		}
		if (timeIntervals.Count() == 2 && timeIntervals.First().End >= timeIntervals.Last().Start)
		{
			return false;
		}
		return true;
	}
}
