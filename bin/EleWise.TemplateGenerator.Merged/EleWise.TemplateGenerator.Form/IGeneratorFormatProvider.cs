using System.Drawing;

namespace EleWise.TemplateGenerator.Formats;

public interface IGeneratorFormatProvider
{
	string FormatValue(FormatedValue value);

	Image GetImage(FormatedValue value);
}
