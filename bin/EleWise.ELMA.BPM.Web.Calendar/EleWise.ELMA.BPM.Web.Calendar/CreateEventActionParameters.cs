namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public class CreateEventActionParameters
{
	public string Subject { get; set; }

	public string Place { get; set; }

	public long[] Participants { get; set; }

	public long[] Informers { get; set; }
}
