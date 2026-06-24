using System;
using EleWise.ELMA.ComponentModel;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.Server)]
public interface IQueryCastExtension
{
	Type LeftOperandType { get; }

	Type RightOperandType { get; }

	SqlString CastLeftOperand(SqlString sqlString);

	IProjection CastRightOperand(string propertyName);
}
