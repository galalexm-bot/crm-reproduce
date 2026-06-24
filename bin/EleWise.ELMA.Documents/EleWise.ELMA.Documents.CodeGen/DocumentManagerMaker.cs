using System;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Documents.CodeGeneration;

public class DocumentManagerMaker : EntityManagerMakerBase
{
	protected override Type MakeEntityImplManager(Type objectType, Type intfType, Type idType)
	{
		return typeof(DocumentImplManager<, , >).MakeGenericType(objectType, intfType, idType);
	}

	protected override Type MakeEntityManager(Type objectType, Type idType)
	{
		return typeof(DocumentManager<, >).MakeGenericType(objectType, idType);
	}
}
