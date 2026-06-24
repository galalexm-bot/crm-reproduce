using System.Collections.Generic;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Models;

public interface IExecutionResult<out T> where T : class
{
	T Result { get; }

	IEnumerable<string> Errors { get; }
}
