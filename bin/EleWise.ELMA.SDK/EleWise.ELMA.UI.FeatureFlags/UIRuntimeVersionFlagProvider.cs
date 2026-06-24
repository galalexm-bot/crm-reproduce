using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FeatureFlags.Components;
using EleWise.ELMA.Model;
using EleWise.ELMA.UI.FeatureFlags.Components;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.FeatureFlags;

[Component(Order = 100)]
internal sealed class UIRuntimeVersionFlagProvider : BaseFeatureFlagProvider
{
	private readonly IEnumerable<IUIRuntimeVersionChecker> runtimeVersionCheckers;

	private bool? result;

	public UIRuntimeVersionFlagProvider(IEnumerable<IUIRuntimeVersionChecker> runtimeVersionCheckers)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.runtimeVersionCheckers = runtimeVersionCheckers;
	}

	[IteratorStateMachine(typeof(_003CGetFlags_003Ed__3))]
	public override IEnumerable<(string featureFlagName, bool enabled)> GetFlags(IEnumerable<string> featureFlagNames)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetFlags_003Ed__3(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__featureFlagNames = featureFlagNames
		};
	}

	private bool? Check()
	{
		if (runtimeVersionCheckers.FirstOrDefault((IUIRuntimeVersionChecker a) => _003C_003Ec.u4C94qQEfBPL5GkL5QVy(a) == RuntimeVersion.Version2) == null)
		{
			return null;
		}
		return true;
	}
}
