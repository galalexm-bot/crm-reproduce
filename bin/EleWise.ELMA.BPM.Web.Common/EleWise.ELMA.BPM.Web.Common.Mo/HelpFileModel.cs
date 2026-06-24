using System.Collections.Generic;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.BPM.Web.Common.Models.Deploy;

public sealed class HelpFileModel
{
	public BinaryFile HelpFile { get; set; }

	public IList<string> AdditionalFiles { get; set; } = new List<string>();

}
