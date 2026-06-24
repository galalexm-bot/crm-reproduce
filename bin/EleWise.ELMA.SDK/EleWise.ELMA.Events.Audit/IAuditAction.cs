using System;
using System.Drawing;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Events.Audit;

public interface IAuditAction
{
	Guid Uid { get; }

	string Name { get; }

	string DisplayName { get; }

	string Description { get; }

	Image Image { get; }

	MetadataImage MetadataImage { get; }
}
