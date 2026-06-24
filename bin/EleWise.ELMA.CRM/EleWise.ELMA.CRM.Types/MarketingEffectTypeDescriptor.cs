using System;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.CRM.Types;

public class MarketingEffectTypeDescriptor : EntitySubTypeDescriptor<IMarketingEffect>
{
	private static readonly Guid EffectEntityUid = new Guid("2c2ae8eb-9f42-4d3e-b990-157357c1a535");

	public override Type SettingsType => typeof(MarketingEffectSettings);

	protected override Guid EntityUid => EffectEntityUid;
}
