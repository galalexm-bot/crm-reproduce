using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;

namespace EleWise.ELMA.Content;

public class ThemeSettings : GlobalSettingsBase
{
	[DisplayName("SR.M('Текущая цветовая схема')")]
	[IgnoreDataMember]
	public IColorScheme CurrentColorScheme
	{
		get
		{
			return ColorSchemeManager.Instance.LoadOrNull(CurrentColorSchemeId);
		}
		set
		{
			CurrentColorSchemeId = value?.Id ?? 0;
		}
	}

	public long CurrentColorSchemeId { get; set; }

	[DisplayName("SR.M('Цвет общего фона')")]
	[Obsolete("Не используется", true)]
	public string GeneralBackground { get; set; }

	[DisplayName("SR.M('Цвет фона левого меню')")]
	[Obsolete("Не используется", true)]
	public string LeftMenuBackground { get; set; }

	[DisplayName("SR.M('Цвет фона тулбара')")]
	[Obsolete("Не используется", true)]
	public string TopMenuBackground { get; set; }

	[DisplayName("SR.M('Цвета фона компонентов')")]
	[Obsolete("Не используется", true)]
	public string BlockBackground { get; set; }

	[DisplayName("SR.M('Цвет тени')")]
	[Obsolete("Не используется", true)]
	public string ShadowColor { get; set; }

	[DisplayName("SR.M('Базовый цвет текста')")]
	[Obsolete("Не используется", true)]
	public string GeneralFontColor { get; set; }

	[DisplayName("SR.M('Инверсия базового цвета текста')")]
	[Obsolete("Не используется", true)]
	public string GeneralNegativeFontColor { get; set; }

	[DisplayName("SR.M('Цвет текста наименования свойств')")]
	[Obsolete("Не используется", true)]
	public string CaptionCellFontColor { get; set; }

	[DisplayName("SR.M('Цвет текста описания свойств')")]
	[Obsolete("Не используется", true)]
	public string DescriptionFontColor { get; set; }

	[DisplayName("SR.M('Цвет заполнителя')")]
	[Obsolete("Не используется", true)]
	public string PlaceholderFontColor { get; set; }

	[DisplayName("SR.M('Цвет текста успешного выполнения')")]
	[Obsolete("Не используется", true)]
	public string ValidationSuccessFontColor { get; set; }

	[DisplayName("SR.M('Цвет текста сообщения об ошибке')")]
	[Obsolete("Не используется", true)]
	public string ValidationErrorFontColor { get; set; }

	[DisplayName("SR.M('Цвет панели I типа')")]
	[Obsolete("Не используется", true)]
	public string SeparatorGrayBackgroundColor { get; set; }

	[DisplayName("SR.M('Цвет панели I типа при наведении')")]
	[Obsolete("Не используется", true)]
	public string SeparatorGrayHoverBackgroundColor { get; set; }

	[DisplayName("SR.M('Цвет панели II типа')")]
	[Obsolete("Не используется", true)]
	public string SeparatorBlueBackgroundColor { get; set; }

	[DisplayName("SR.M('Цвет панели II типа при наведении')")]
	[Obsolete("Не используется", true)]
	public string SeparatorBlueHoverBackgroundColor { get; set; }

	[DisplayName("SR.M('Цвет панели III типа')")]
	[Obsolete("Не используется", true)]
	public string SeparatorYellowBackgroundColor { get; set; }

	[DisplayName("SR.M('Цвет панели III типа при наведении')")]
	[Obsolete("Не используется", true)]
	public string SeparatorYellowHoverBackgroundColor { get; set; }

	[DisplayName("SR.M('Цвет панели IV типа')")]
	[Obsolete("Не используется", true)]
	public string SeparatorRedBackgroundColor { get; set; }

	[DisplayName("SR.M('Цвет панели IV типа при наведении')")]
	[Obsolete("Не используется", true)]
	public string SeparatorRedHoverBackgroundColor { get; set; }

	[DisplayName("SR.M('Цвет панели V типа')")]
	[Obsolete("Не используется", true)]
	public string SeparatorGreenBackgroundColor { get; set; }

	[DisplayName("SR.M('Цвет панели V типа при наведении')")]
	[Obsolete("Не используется", true)]
	public string SeparatorGreenHoverBackgroundColor { get; set; }

	[DisplayName("SR.M('Цвет кнопки I типа')")]
	[Obsolete("Не используется", true)]
	public string ButtonGray { get; set; }

	[DisplayName("SR.M('Цвет кнопки I типа при наведении')")]
	[Obsolete("Не используется", true)]
	public string ButtonHoverGray { get; set; }

	[DisplayName("SR.M('Цвет кнопки I типа без заливки')")]
	[Obsolete("Не используется", true)]
	public string ButtonOutlineGray { get; set; }

	[DisplayName("SR.M('Цвет кнопки I типа без заливки при наведении')")]
	[Obsolete("Не используется", true)]
	public string ButtonOutlineHoverGray { get; set; }

	[DisplayName("SR.M('Цвет кнопки II типа')")]
	[Obsolete("Не используется", true)]
	public string ButtonBlue { get; set; }

	[DisplayName("SR.M('Цвет кнопки II типа при наведении')")]
	[Obsolete("Не используется", true)]
	public string ButtonHoverBlue { get; set; }

	[DisplayName("SR.M('Цвет кнопки II типа без заливки')")]
	[Obsolete("Не используется", true)]
	public string ButtonOutlineBlue { get; set; }

	[DisplayName("SR.M('Цвет кнопки II типа без заливки при наведении')")]
	[Obsolete("Не используется", true)]
	public string ButtonOutlineHoverBlue { get; set; }

	[DisplayName("SR.M('Цвет кнопки III типа')")]
	[Obsolete("Не используется", true)]
	public string ButtonRed { get; set; }

	[DisplayName("SR.M('Цвет кнопки III типа при наведении')")]
	[Obsolete("Не используется", true)]
	public string ButtonHoverRed { get; set; }

	[DisplayName("SR.M('Цвет кнопки III типа без заливки')")]
	[Obsolete("Не используется", true)]
	public string ButtonOutlineRed { get; set; }

	[DisplayName("SR.M('Цвет кнопки III типа без заливки при наведении')")]
	[Obsolete("Не используется", true)]
	public string ButtonOutlineHoverRed { get; set; }

	[DisplayName("SR.M('Цвет кнопки IV типа')")]
	[Obsolete("Не используется", true)]
	public string ButtonGreen { get; set; }

	[DisplayName("SR.M('Цвет кнопки IV типа при наведении')")]
	[Obsolete("Не используется", true)]
	public string ButtonHoverGreen { get; set; }

	[DisplayName("SR.M('Цвет кнопки IV типа без заливки')")]
	[Obsolete("Не используется", true)]
	public string ButtonOutlineGreen { get; set; }

	[DisplayName("SR.M('Цвет кнопки IV типа без заливки при наведении')")]
	[Obsolete("Не используется", true)]
	public string ButtonOutlineHoverGreen { get; set; }

	[DisplayName("SR.M('Цвет кнопки V типа')")]
	[Obsolete("Не используется", true)]
	public string ButtonYellow { get; set; }

	[DisplayName("SR.M('Цвет кнопки V типа при наведении')")]
	[Obsolete("Не используется", true)]
	public string ButtonHoverYellow { get; set; }

	[DisplayName("SR.M('Цвет кнопки V типа без заливки')")]
	[Obsolete("Не используется", true)]
	public string ButtonOutlineYellow { get; set; }

	[DisplayName("SR.M('Цвет кнопки V типа без заливки при наведении')")]
	[Obsolete("Не используется", true)]
	public string ButtonOutlineHoverYellow { get; set; }

	[DisplayName("SR.M('Цвет кнопки VI типа')")]
	[Obsolete("Не используется", true)]
	public string ButtonSimple { get; set; }

	[DisplayName("SR.M('Цвет кнопки VI типа при наведении')")]
	[Obsolete("Не используется", true)]
	public string ButtonHoverSimple { get; set; }

	[DisplayName("SR.M('Цвет кнопки VI типа без заливки')")]
	[Obsolete("Не используется", true)]
	public string ButtonOutlineSimple { get; set; }

	[DisplayName("SR.M('Цвет кнопки VI типа без заливки при наведении')")]
	[Obsolete("Не используется", true)]
	public string ButtonOutlineHoverSimple { get; set; }

	[DisplayName("SR.M('Цвет текста вкладки')")]
	[Obsolete("Не используется", true)]
	public string TabFontColor { get; set; }

	[DisplayName("SR.M('Цвет текста счетчика')")]
	[Obsolete("Не используется", true)]
	public string CounterTextColor { get; set; }

	[DisplayName("SR.M('Цвет фона счетчика')")]
	[Obsolete("Не используется", true)]
	public string CounterBackgroundColor { get; set; }

	[DisplayName("SR.M('Цвет активной вкладки')")]
	[Obsolete("Не используется", true)]
	public string ActiveTabBackgroundColor { get; set; }

	[DisplayName("SR.M('Цвет текста активной вкладки')")]
	[Obsolete("Не используется", true)]
	public string ActiveTabFontColor { get; set; }

	[DisplayName("SR.M('Цвет текста счетчика активной вкладки')")]
	[Obsolete("Не используется", true)]
	public string ActiveCounterTextColor { get; set; }

	[DisplayName("SR.M('Цвет фона счетчика активной вкладки')")]
	[Obsolete("Не используется", true)]
	public string ActiveCounterBackgroundColor { get; set; }

	[DisplayName("SR.M('Цвет границы')")]
	[Obsolete("Не используется", true)]
	public string ControlBorderColor { get; set; }

	[DisplayName("SR.M('Цвет границы при наведении')")]
	[Obsolete("Не используется", true)]
	public string ControlHoverBorderColor { get; set; }

	[DisplayName("SR.M('Цвет границы в фокусе')")]
	[Obsolete("Не используется", true)]
	public string ControlFocusBorderColor { get; set; }

	[DisplayName("SR.M('Цвет фона контрола при наведении')")]
	[Obsolete("Не используется", true)]
	public string ControlHoverBackgroundColor { get; set; }

	[DisplayName("SR.M('Цвет фона отключенного контрола')")]
	[Obsolete("Не используется", true)]
	public string ControlDisabledBackgroundColor { get; set; }
}
