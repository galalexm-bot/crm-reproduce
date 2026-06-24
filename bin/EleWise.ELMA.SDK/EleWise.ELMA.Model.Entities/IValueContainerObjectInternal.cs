using System.Collections.Generic;
using System.ComponentModel;

namespace EleWise.ELMA.Model.Entities;

[EditorBrowsable(EditorBrowsableState.Never)]
public interface IValueContainerObjectInternal
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	IEnumerable<object> GetData();
}
