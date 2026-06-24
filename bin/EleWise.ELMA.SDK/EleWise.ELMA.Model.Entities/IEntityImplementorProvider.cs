using System;

namespace EleWise.ELMA.Model.Entities;

internal interface IEntityImplementorProvider
{
	Type EntityImplementorType { get; }
}
