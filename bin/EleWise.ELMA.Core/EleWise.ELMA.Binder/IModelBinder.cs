using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Binder;

[ServiceContract]
public interface IModelBinder
{
	void BindModel(ModelBindingContext bindingContext, RequestContext requestContext);

	void BindModel(ModelBindingContext bindingContext, object externalInputs);
}
