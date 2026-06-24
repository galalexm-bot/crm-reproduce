using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Packaging.Exceptions;

[Serializable]
public class PackagesConflictException : Exception
{
	private List<PackagesConflictInfo> _conflicts = new List<PackagesConflictInfo>();

	public List<PackagesConflictInfo> Conflicts
	{
		get
		{
			return _conflicts;
		}
		set
		{
			_conflicts = value;
		}
	}

	public override string Message => base.Message + ((Conflicts.Count > 0) ? (Environment.NewLine + string.Join(Environment.NewLine, Conflicts.Select((PackagesConflictInfo c) => "   " + c.ToString()))) : "");

	public PackagesConflictException()
	{
		Conflicts = new List<PackagesConflictInfo>();
	}

	public PackagesConflictException(string message)
		: base(message)
	{
	}

	public PackagesConflictException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected PackagesConflictException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		List<PackagesConflictInfo> list = (List<PackagesConflictInfo>)info.GetValue("Conflicts", typeof(List<PackagesConflictInfo>));
		if (list != null)
		{
			_conflicts = list;
		}
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("Conflicts", Conflicts);
	}
}
