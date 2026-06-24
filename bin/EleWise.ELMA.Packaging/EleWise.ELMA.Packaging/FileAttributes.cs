using System;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging;

public class FileAttributes
{
	public string Path { get; set; }

	[XmlIgnore]
	public DateTime CreationTime { get; set; }

	public long CreationTimeTicks
	{
		get
		{
			return CreationTime.Ticks;
		}
		set
		{
			CreationTime = new DateTime(value);
		}
	}

	[XmlIgnore]
	public DateTime LastWriteTime { get; set; }

	public long LastWriteTimeTicks
	{
		get
		{
			return LastWriteTime.Ticks;
		}
		set
		{
			LastWriteTime = new DateTime(value);
		}
	}
}
