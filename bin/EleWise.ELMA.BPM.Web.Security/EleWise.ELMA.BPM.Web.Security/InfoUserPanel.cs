using System;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class InfoUserPanel
{
	public IUser User { get; set; }

	public bool FixedWidth { get; set; }

	public Func<dynamic, object> Content { get; set; }
}
