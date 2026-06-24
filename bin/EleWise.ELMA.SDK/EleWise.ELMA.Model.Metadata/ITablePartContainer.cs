using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata;

public interface ITablePartContainer
{
	ICollection<ITablePartMetadata> TableParts { get; set; }
}
