using System;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Tasks.Managers;

namespace EleWise.ELMA.Tasks.CodeGeneration;

internal class TaskBaseManagerMaker : EntityManagerMakerBase
{
	protected override Type MakeEntityManager(Type objectType, Type idType)
	{
		return typeof(TaskBaseManager<>).MakeGenericType(objectType);
	}
}
