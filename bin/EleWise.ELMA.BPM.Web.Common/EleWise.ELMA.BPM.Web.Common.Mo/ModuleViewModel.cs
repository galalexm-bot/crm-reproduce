using System.Collections.Generic;
using Orchard.Environment.Extensions.Models;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class ModuleViewModel
{
	public bool Enabled { get; set; }

	public bool System { get; set; }

	public ExtensionDescriptor Module { get; set; }

	public IEnumerable<string> Dependecies { get; set; }
}
