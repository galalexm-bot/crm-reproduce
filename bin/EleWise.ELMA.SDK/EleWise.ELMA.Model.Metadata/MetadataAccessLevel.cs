using System;

namespace EleWise.ELMA.Model.Metadata;

[Obsolete("Уровень доступа к метаданным больше не используется")]
public enum MetadataAccessLevel
{
	All = 0,
	EleWise = 1000
}
