using System;

namespace EleWise.ELMA.Model.Managers;

public interface IManagerMaker
{
	Type MakeManager(Type objectType);
}
