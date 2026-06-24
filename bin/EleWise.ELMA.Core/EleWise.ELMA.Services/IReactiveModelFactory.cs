using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Services;

[ServiceContract]
public interface IReactiveModelFactory
{
	T CreateModel<T>();

	object CreateModel(System.Type modelType);
}
