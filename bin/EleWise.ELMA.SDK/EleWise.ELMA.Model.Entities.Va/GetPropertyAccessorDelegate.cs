using System.ComponentModel;
using EleWise.ELMA.Model.Accessors;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;

[EditorBrowsable(EditorBrowsableState.Never)]
public delegate IAccessor GetPropertyAccessorDelegate(string name);
