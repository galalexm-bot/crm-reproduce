using System;
using EleWise.ELMA.Core;

namespace EleWise.ELMA.Exceptions;

public sealed class MetadataNotFoundException : System.Exception
{
	private static string MetadataByUidNotFoundException => SR.T("Метаданные по уникальному идентификатору \"{0}\" не найдены");

	public MetadataNotFoundException(Guid uid)
		: base(string.Format(MetadataByUidNotFoundException, (object)uid))
	{
	}//IL_0006: Unknown result type (might be due to invalid IL or missing references)

}
