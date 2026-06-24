using System.Collections.Generic;
using System.Web.Mvc;

namespace Orchard.Mvc.ModelBinders;

public class ModelBinderPublisher : IModelBinderPublisher, IDependency
{
	private readonly ModelBinderDictionary _binders;

	public ModelBinderPublisher(ModelBinderDictionary binders)
	{
		_binders = binders;
	}

	public void Publish(IEnumerable<ModelBinderDescriptor> binders)
	{
		foreach (ModelBinderDescriptor binder in binders)
		{
			_binders.set_Item(binder.Type, binder.ModelBinder);
		}
	}
}
