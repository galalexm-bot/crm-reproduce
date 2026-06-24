using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CRM.Import.Web.Code;

public class Timers
{
	public List<TotalTimeItem> TotalTime { get; set; }

	private Dictionary<Guid, Tuple<TimerType, DateTime>> StartedTimers { get; set; }

	public static string TimerTypeToString(TimerType type)
	{
		return type switch
		{
			TimerType.CreateEntity => SR.T("Создание"), 
			TimerType.FindEntity => SR.T("Поиск"), 
			TimerType.LoadEntity => SR.T("Загрузка"), 
			TimerType.SaveEntity => SR.T("Сохранение"), 
			TimerType.Total => SR.T("Всего"), 
			_ => string.Empty, 
		};
	}

	public Timers()
	{
		TotalTime = new List<TotalTimeItem>();
		StartedTimers = new Dictionary<Guid, Tuple<TimerType, DateTime>>();
	}

	public Guid StartTimer(TimerType timerType)
	{
		Guid guid = Guid.NewGuid();
		StartedTimers.Add(guid, new Tuple<TimerType, DateTime>(timerType, DateTime.Now));
		return guid;
	}

	public void StopTimer(Guid timerGuid)
	{
		KeyValuePair<Guid, Tuple<TimerType, DateTime>> st = StartedTimers.FirstOrDefault((KeyValuePair<Guid, Tuple<TimerType, DateTime>> x) => x.Key.Equals(timerGuid));
		if (!TotalTime.Any((TotalTimeItem x) => x.Type.Equals(st.Value.Item1)))
		{
			TotalTime.Add(new TotalTimeItem(st.Value.Item1, (DateTime.Now - st.Value.Item2).TotalMilliseconds));
		}
		else
		{
			TotalTime.FirstOrDefault((TotalTimeItem x) => x.Type.Equals(st.Value.Item1)).Duration += (DateTime.Now - st.Value.Item2).TotalMilliseconds;
		}
		StartedTimers.Remove(timerGuid);
	}
}
