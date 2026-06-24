using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using EleWise.ELMA.CAB.Properties;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.Commands;

public class EventCommandAdapter<TInvoker> : CommandAdapter
{
	private readonly ListDictionary<TInvoker, string> invokers = new ListDictionary<TInvoker, string>();

	public ReadOnlyDictionary<TInvoker, List<string>> Invokers => new ReadOnlyDictionary<TInvoker, List<string>>(invokers);

	public override int InvokerCount => invokers.Count;

	private MethodInfo InvokerEventHandle => GetType().GetMethod("InvokerEventHandler", BindingFlags.Instance | BindingFlags.Public);

	public EventCommandAdapter()
	{
	}

	public EventCommandAdapter(TInvoker invoker, string eventName)
	{
		WireUpInvoker(invoker, eventName);
	}

	public void InvokerEventHandler(object sender, EventArgs e)
	{
		FireCommand();
	}

	public override void AddInvoker(object invoker, string eventName)
	{
		Guard.ArgumentNotNull(invoker, "invoker");
		ThrowIfWrongType(invoker);
		WireUpInvoker((TInvoker)invoker, eventName);
	}

	public override void RemoveInvoker(object invoker, string eventName)
	{
		UnwireInvoker(invoker, eventName);
		RemoveInvokerIfZeroEvents(invoker);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			foreach (KeyValuePair<TInvoker, List<string>> item in (IEnumerable<KeyValuePair<TInvoker, List<string>>>)invokers)
			{
				List<string> value = item.Value;
				for (int num = value.Count - 1; num >= 0; num--)
				{
					UnwireInvoker(item.Key, value[num]);
				}
			}
			invokers.Clear();
		}
		base.Dispose(disposing);
	}

	public override bool ContainsInvoker(object invoker)
	{
		if (!typeof(TInvoker).IsAssignableFrom(invoker.GetType()))
		{
			return false;
		}
		return invokers.ContainsKey((TInvoker)invoker);
	}

	private void WireUpInvoker(TInvoker invoker, string eventName)
	{
		Guard.ArgumentNotNull(invoker, "invoker");
		Guard.ArgumentNotNull(eventName, "evenName");
		ThrowIfWrongType(invoker);
		if (!invokers.ContainsKey(invoker))
		{
			HookInvokerEvent(invoker, eventName);
			invokers.Add(invoker, eventName);
		}
		else if (!invokers[invoker].Contains(eventName))
		{
			invokers[invoker].Add(eventName);
			HookInvokerEvent(invoker, eventName);
		}
	}

	private void UnwireInvoker(object invoker, string eventName)
	{
		Guard.ArgumentNotNull(invoker, "invoker");
		Guard.ArgumentNotNullOrEmptyString(eventName, "eventName");
		ThrowIfWrongType(invoker);
		TInvoker key = (TInvoker)invoker;
		if (invokers.ContainsKey(key))
		{
			UnhookInvokerEvent(invoker, eventName);
			invokers[key].Remove(eventName);
		}
	}

	private void RemoveInvokerIfZeroEvents(object invoker)
	{
		Guard.ArgumentNotNull(invoker, "invoker");
		ThrowIfWrongType(invoker);
		TInvoker key = (TInvoker)invoker;
		if (invokers.ContainsKey(key) && invokers[key].Count == 0)
		{
			invokers.Remove(key);
		}
	}

	private void HookInvokerEvent(object invoker, string eventName)
	{
		EventInfo eventInfo = GetEventInfo(invoker, eventName);
		Delegate handler = Delegate.CreateDelegate(eventInfo.EventHandlerType, this, InvokerEventHandle);
		eventInfo.AddEventHandler(invoker, handler);
	}

	private void UnhookInvokerEvent(object invoker, string eventName)
	{
		EventInfo eventInfo = GetEventInfo(invoker, eventName);
		Delegate handler = Delegate.CreateDelegate(eventInfo.EventHandlerType, this, InvokerEventHandle);
		eventInfo.RemoveEventHandler(invoker, handler);
	}

	private EventInfo GetEventInfo(object invoker, string eventName)
	{
		Type type = invoker.GetType();
		EventInfo @event = type.GetEvent(eventName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		if (@event == null)
		{
			throw new CommandException(string.Format(CultureInfo.CurrentCulture, Resources.EventNotPresentOnInvoker, new object[2] { eventName, type.FullName }));
		}
		if (@event.GetAddMethod().IsStatic || @event.GetRemoveMethod().IsStatic)
		{
			throw new CommandException(string.Format(CultureInfo.CurrentCulture, Resources.StaticCommandPublisherNotSupported, new object[1] { @event.Name }));
		}
		return @event;
	}

	private void ThrowIfWrongType(object invoker)
	{
		if (!typeof(TInvoker).IsAssignableFrom(invoker.GetType()))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.EventCommandAdapterInvokerNotType, new object[1] { typeof(TInvoker) }));
		}
	}
}
