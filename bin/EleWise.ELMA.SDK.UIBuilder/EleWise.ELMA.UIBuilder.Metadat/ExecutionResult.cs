using System.Collections.Generic;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Models;

internal sealed class ExecutionResult<T> : IExecutionResult<T> where T : class
{
	public T Result { get; }

	public IEnumerable<string> Errors { get; }

	public ExecutionResult(T result)
	{
		Result = result;
	}

	public ExecutionResult(T result, IEnumerable<string> errors)
	{
		Result = result;
		Errors = errors;
	}
}
