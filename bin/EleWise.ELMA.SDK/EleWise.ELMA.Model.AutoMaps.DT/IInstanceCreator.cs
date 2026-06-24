using System;
using EleWise.ELMA.DataClasses;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.InstanceCreators;

internal interface IInstanceCreator
{
	bool CanCreateInstance(Type type);

	object CreateInstance(DataClass dataClass, Type type);
}
