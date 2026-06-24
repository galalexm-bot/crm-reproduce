using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model;

public sealed class CheckMetadataResult
{
	private readonly bool _003CIsValid_003Ek__BackingField;

	private readonly string[] _003CErrors_003Ek__BackingField;

	public bool IsValid => _003CIsValid_003Ek__BackingField;

	public string[] Errors => _003CErrors_003Ek__BackingField;

	public CheckMetadataResult(bool success, params string[] errors)
	{
		_003CIsValid_003Ek__BackingField = success;
		_003CErrors_003Ek__BackingField = errors;
	}

	public CheckMetadataResult(bool success, System.Collections.Generic.IEnumerable<string> errors)
		: this(success, Enumerable.ToArray<string>(errors))
	{
	}
}
