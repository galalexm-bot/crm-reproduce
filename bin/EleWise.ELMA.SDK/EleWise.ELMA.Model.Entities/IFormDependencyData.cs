using System;
using EleWise.ELMA.Model.Enums;

namespace EleWise.ELMA.Model.Entities;

public interface IFormDependencyData
{
	Guid DependObjectUid { get; }

	Guid DependObjectFormUid { get; }

	Guid UsesObjectUid { get; }

	Guid UsesObjectFormUid { get; }

	FormDependencyDataType Type { get; }

	string GenerateDependInfo();

	string GenerateUsesInfo();
}
