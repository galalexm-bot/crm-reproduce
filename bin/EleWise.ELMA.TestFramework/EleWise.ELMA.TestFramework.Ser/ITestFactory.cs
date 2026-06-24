using System;

namespace EleWise.ELMA.TestFramework.Services;

internal interface ITestFactory
{
	T CreateTest<T>();

	object CreateTest(System.Type t);
}
