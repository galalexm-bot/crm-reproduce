using System;
using EleWise.ELMA.Documents.Models.ConvertType;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Services;

public interface IConvertTypeService
{
	void Convert(IEntity entity, TypeMappingInfo mapping, Action<ConvertTypeProgressInfo> callback);
}
