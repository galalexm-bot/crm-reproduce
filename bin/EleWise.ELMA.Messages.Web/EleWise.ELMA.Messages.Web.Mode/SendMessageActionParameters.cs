namespace EleWise.ELMA.Messages.Web.Models;

public class SendMessageActionParameters
{
	public string Subject { get; set; }

	public long[] Channels { get; set; }

	public long[] Users { get; set; }
}
