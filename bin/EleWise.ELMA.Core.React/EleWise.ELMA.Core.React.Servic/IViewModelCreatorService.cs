using System;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.React.Services;

[ServiceContract]
public interface IViewModelCreatorService
{
	T CreateModel<T>();

	object CreateModel(System.Type type);

	IController ControllerCreator(System.Type controllerType, IContext context, IViewModel viewModel = null, IViewItem viewItem = null);

	string InitServerControllerProxy(IController controller, System.Type @namespace, string assemblyName, ModelInfo modelInfo, IViewModel viewModel, params SerializedModelParam[] additionalModels);

	System.Threading.Tasks.Task InitClientController(IController controller, string controllerFullName, string onLoadScriptName, IDataStack dataStack, ModelInfo modelInfo, IViewModel viewModel, string defaultOnLoadScriptName, params AdditionalModel[] additionalModels);

	void ExecuteOnInit(IController controller, IViewModel viewModel);

	System.Threading.Tasks.Task ExecuteServerOnLoad(IController controller, string controllerFullName, string onLoadScriptName, IViewModel currentViewModel);

	System.Threading.Tasks.Task ExecuteEql(IController controller, string defaultOnLoadScriptName, IViewModel viewModel, ModelInfo modelInfo, params AdditionalModel[] additionalModels);

	void ExecuteOnLoad(IController controller, IViewModel viewModel);

	System.Threading.Tasks.Task ExecuteOnLoadAsync(IController controller, IViewModel viewModel);

	System.Type GetServerControllerType(System.Type @namespace);

	string GetServerControllerFullName(System.Type serverControllerInterfaceType, string assemblyName);
}
