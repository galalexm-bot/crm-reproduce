using System.Collections.Generic;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public class CreateEventHtmlElementModel
{
	public string Subject { get; set; }

	public string Place { get; set; }

	public List<IUser> Participants { get; set; }

	public List<IUser> Informers { get; set; }

	public CreateEventHtmlElementModel()
	{
		Participants = new List<IUser>();
		Informers = new List<IUser>();
	}
}
