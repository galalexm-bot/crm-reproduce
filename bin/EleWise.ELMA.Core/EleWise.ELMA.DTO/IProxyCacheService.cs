using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.DTO;

[ServiceContract]
internal interface IProxyCacheService
{
	void Add(string key, ReactiveProxy proxy);

	ReactiveProxy Get(string key);

	void Update(string key);

	ValueTuple<string, ReactiveProxy>[] GetValues();
}
