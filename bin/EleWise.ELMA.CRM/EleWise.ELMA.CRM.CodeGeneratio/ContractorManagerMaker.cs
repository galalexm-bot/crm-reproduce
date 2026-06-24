using System;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.CRM.CodeGeneration;

public class ContractorManagerMaker : EntityManagerMakerBase
{
	protected override Type MakeEntityManager(Type objectType, Type idType)
	{
		return typeof(ContractorManager<>).MakeGenericType(objectType);
	}
}
