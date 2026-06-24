using System;

namespace EleWise.ELMA.Documents.Components;

public class RegistrationCardTypeFormSettingInfo
{
	public static Guid UID = new Guid("{441B4A8C-AC75-4DFE-94C2-6183EBC9909C}");

	public Guid Uid => UID;

	public string DisplayName => SR.T("Тип регистрационной карточки");
}
