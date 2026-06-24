using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.TestFramework.Services;

[ServiceContract]
internal interface ITestComponentCreatorService
{
	T CreateModel<T>(string componentUid) where T : IViewModel;

	object CreateModel(System.Type type, string componentUid);

	T CreateBaseReactComponent<T>(System.Type inputsType, System.Type contextType, System.Type controllerType) where T : IViewModel;

	object CreateBaseReactComponent(System.Type type, System.Type inputsType, System.Type contextType, System.Type controllerType);

	T CreateBaseViewItemComponent<T>(System.Type viewItemType, System.Type contextType, System.Type controllerType) where T : IViewModel;

	object CreateBaseViewItemComponent(System.Type type, System.Type viewItemType, System.Type contextType, System.Type controllerType);
}
