using System.Collections.Generic;

namespace EleWise.TemplateGenerator;

public class BlockInfo
{
	public int Count { get; set; }

	public int Index { get; set; }

	public FormatedValue CurrentValue { get; set; }

	public List<object> List { get; set; }
}
