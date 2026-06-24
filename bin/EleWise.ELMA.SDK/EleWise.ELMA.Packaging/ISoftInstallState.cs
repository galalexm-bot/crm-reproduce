using System;

namespace EleWise.ELMA.Packaging;

[Obsolete("Интерфейс утратил актуальность - не используйте его", true)]
public interface ISoftInstallState
{
	ManifestStoreComponentInfo ComponentInfo { get; }

	string Log { get; }

	bool HasBeenProcessed { get; }

	int Index { get; }

	bool HasErrors { get; }
}
