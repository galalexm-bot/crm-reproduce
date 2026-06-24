using System.Globalization;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Services;

public interface ILocalizationService
{
	CultureInfo DefaultCulture { get; }

	void Save(CultureInfo info);

	void Save(CultureInfo info, IUser user);

	CultureInfo Load();

	CultureInfo Load(IUser user);

	void InitCulture();

	void SetDefaultCulture(string name);
}
