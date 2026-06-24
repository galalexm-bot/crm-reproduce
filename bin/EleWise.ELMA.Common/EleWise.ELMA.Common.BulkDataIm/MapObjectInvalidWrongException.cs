using System;

namespace EleWise.ELMA.Common.BulkDataImport.Exceptions;

public class MapObjectInvalidWrongException : Exception
{
	public MapObjectInvalidWrongException(string message)
		: base(message)
	{
	}
}
