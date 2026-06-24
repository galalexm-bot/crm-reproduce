using System.Collections.Generic;

namespace EleWise.ELMA.BridgeCompiler;

internal sealed class EmitResult
{
	public bool Success { get; private set; }

	public IEnumerable<string> Errors { get; private set; }

	private EmitResult()
	{
		Errors = new List<string>();
	}

	internal static EmitResult SuccessResult()
	{
		return new EmitResult
		{
			Success = true
		};
	}

	internal static EmitResult ErrorResult(IEnumerable<string> errors)
	{
		return new EmitResult
		{
			Success = false,
			Errors = errors
		};
	}
}
