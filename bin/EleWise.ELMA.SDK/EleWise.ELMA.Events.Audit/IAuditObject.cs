using System;
using System.Drawing;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Events.Audit;

public interface IAuditObject
{
	Guid Uid { get; }

	IAuditObjectType Type { get; }

	IAuditObject Parent { get; }

	string Name { get; }

	string DisplayName { get; }

	Image Image { get; }

	MetadataImage MetadataImage { get; }

	MetadataImage GetImage(int size);
}
