using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Common.Models;

[Component]
internal abstract class DependencyHackList : IDependencyHackList, IEntityTypeFinder
{
	public abstract Guid[] TypeUids { get; }

	public abstract ValueTuple<Guid, string>[] Properties { get; }

	protected abstract System.Type RealType { get; }

	public System.Type GetRealType(object json)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (json == null)
		{
			return null;
		}
		Guid val = default(Guid);
		if (!Guid.TryParse("", ref val))
		{
			return null;
		}
		if (!ArrayExtensions.Contains<Guid>(TypeUids, val))
		{
			return null;
		}
		return RealType;
	}
}
