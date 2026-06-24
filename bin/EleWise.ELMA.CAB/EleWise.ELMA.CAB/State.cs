#define TRACE
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Runtime.Serialization;
using System.Security.Permissions;
using EleWise.ELMA.CAB.Instrumentation;
using EleWise.ELMA.CAB.Properties;

namespace EleWise.ELMA.CAB;

[Serializable]
public class State : StateElement, ISerializable
{
	private class ClassNameTraceSourceAttribute : TraceSourceAttribute
	{
		public ClassNameTraceSourceAttribute()
			: base(typeof(State).FullName)
		{
		}
	}

	private readonly string id;

	private bool hasChanges;

	private TraceSource traceSource;

	[ClassNameTraceSource]
	public TraceSource TraceSource
	{
		set
		{
			traceSource = value;
		}
	}

	public new object this[string key]
	{
		get
		{
			return base[key];
		}
		set
		{
			base[key] = value;
		}
	}

	[DefaultValue(false)]
	public bool HasChanges => hasChanges;

	public string ID => id;

	public State()
		: this(Guid.NewGuid().ToString())
	{
	}

	public State(string id)
	{
		this.id = id;
	}

	protected State(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		id = (string)info.GetValue("id", typeof(string));
	}

	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		__ContractsRuntime.Requires(info != null, null, "info != null");
		base.GetObjectData(info, context);
		info.AddValue("id", id);
	}

	public void AcceptChanges()
	{
		hasChanges = false;
	}

	protected override void OnStateChanged(StateChangedEventArgs e)
	{
		if (traceSource != null)
		{
			traceSource.TraceInformation(Resources.TraceStateChangedMessage, id, e.Key);
		}
		base.OnStateChanged(e);
		hasChanges = true;
	}
}
