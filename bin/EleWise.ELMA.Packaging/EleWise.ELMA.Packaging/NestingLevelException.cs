using System;
using EleWise.ELMA.Packaging.ElmaStoreManifest;

namespace EleWise.ELMA.Packaging;

[Serializable]
public class NestingLevelException : Exception
{
	public NestingLevelException()
		: base(SR.T("Глубина вложенности комплексного BPM App превышает допустимую {0}", 100))
	{
	}

	public NestingLevelException(ElmaStoreComponentManifest manifest)
		: base(SR.T("Глубина вложенности комплексного BPM App {0} превышает допустимую {1}", (manifest == null) ? "" : manifest.Id, 100))
	{
	}
}
