using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Models.Inputs;

public class ModernRadioButton : ModernCheckBoxBase
{
	protected override InputType InputType => (InputType)3;

	protected override string DefaultIdPrefix => "rb_";
}
