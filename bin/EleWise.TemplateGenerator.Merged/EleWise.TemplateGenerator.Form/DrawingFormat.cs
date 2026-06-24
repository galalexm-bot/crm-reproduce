using System;

namespace EleWise.TemplateGenerator.Formats;

public class DrawingFormat : BaseFormat
{
	public double Scale { get; set; }

	public string WrapType { get; set; }

	public DrawingFormat()
	{
		Scale = 100.0;
	}

	public void Parse(string s)
	{
		if (string.IsNullOrEmpty(s))
		{
			return;
		}
		string[] array = s.Split(";,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split(":".ToCharArray());
			if (array2.Length != 2)
			{
				continue;
			}
			string text = array2[0].ToLower();
			double result;
			if (!(text == "scale"))
			{
				if (text == "wraptype")
				{
					WrapType = array2[1];
				}
			}
			else if (double.TryParse(array2[1], out result))
			{
				Scale = result;
			}
		}
	}
}
