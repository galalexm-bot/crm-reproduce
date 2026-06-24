using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using EleWise.ELMA.Common.Helpers;
using EleWise.ELMA.Content.Components;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;
using Newtonsoft.Json;

namespace EleWise.ELMA.Content.Models;

[Serializable]
public class ColorSchemeSettingsModel
{
	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет общего фона')")]
	[LessVariableName("general-background-color")]
	public string GeneralBackground { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет фона левого меню')")]
	[LessVariableName("left-menu-background-color")]
	public string LeftMenuBackground { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет элемента левого меню')")]
	[LessVariableName("left-menu-element-color")]
	public string LeftMenuElement { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет элемента левого меню при наведении')")]
	[LessVariableName("left-menu-element-color--hover")]
	public string LeftMenuElementHover { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет фона тулбара')")]
	[LessVariableName("toolbar-background-color")]
	public string TopMenuBackground { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвета фона компонентов')")]
	[LessVariableName("block-background-color")]
	public string BlockBackground { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет тени')")]
	[LessVariableName("shadow-color")]
	public string ShadowColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет разделителя')")]
	[LessVariableName("separator-color")]
	public string SeparatorColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Базовый цвет текста')")]
	[LessVariableName("general-font-color")]
	public string GeneralFontColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Инверсия базового цвета текста')")]
	[LessVariableName("general-font-color--negative")]
	public string GeneralNegativeFontColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет текста наименования свойств')")]
	[LessVariableName("general-font-color--captionCell")]
	public string CaptionCellFontColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет текста описания свойств')")]
	[LessVariableName("general-font-color--description")]
	public string DescriptionFontColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет заполнителя')")]
	[LessVariableName("general-font-color--placeholder")]
	public string PlaceholderFontColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет текста успешного выполнения')")]
	[LessVariableName("general-font-color--validation-success")]
	public string ValidationSuccessFontColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет текста сообщения об ошибке')")]
	[LessVariableName("general-font-color--validation-error")]
	public string ValidationErrorFontColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет текста предупреждения')")]
	[LessVariableName("general-font-color--validation-warning")]
	public string ValidationWarningFontColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет выделенного текста')")]
	[LessVariableName("general-font-color--validation-primary")]
	public string ValidationPrimaryFontColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет серой панели')")]
	[LessVariableName("panel-header-color-gray")]
	public string SeparatorGrayBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет серой панели при наведении')")]
	[LessVariableName("panel-header-color-gray--hover")]
	public string SeparatorGrayHoverBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет синей панели')")]
	[LessVariableName("panel-header-color-blue")]
	public string SeparatorBlueBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет синей панели при наведении')")]
	[LessVariableName("panel-header-color-blue--hover")]
	public string SeparatorBlueHoverBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет желтой панели')")]
	[LessVariableName("panel-header-color-yellow")]
	public string SeparatorYellowBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет желтой панели при наведении')")]
	[LessVariableName("panel-header-color-yellow--hover")]
	public string SeparatorYellowHoverBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет красной панели')")]
	[LessVariableName("panel-header-color-red")]
	public string SeparatorRedBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет красной панели при наведении')")]
	[LessVariableName("panel-header-color-red--hover")]
	public string SeparatorRedHoverBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет зеленой панели')")]
	[LessVariableName("panel-header-color-green")]
	public string SeparatorGreenBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет зеленой панели при наведении')")]
	[LessVariableName("panel-header-color-green--hover")]
	public string SeparatorGreenHoverBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет белой панели')")]
	[LessVariableName("panel-header-color-white")]
	public string SeparatorWhiteBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет белой панели при наведении')")]
	[LessVariableName("panel-header-color-white--hover")]
	public string SeparatorWhiteHoverBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет серой кнопки')")]
	[LessVariableName("btn--gray")]
	public string ButtonGray { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет серой кнопки при наведении')")]
	[LessVariableName("btn-hover--gray")]
	public string ButtonHoverGray { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет серой кнопки без заливки')")]
	[LessVariableName("btn-outline--gray")]
	public string ButtonOutlineGray { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет серой кнопки без заливки при наведении')")]
	[LessVariableName("btn-outline-hover--gray")]
	public string ButtonOutlineHoverGray { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет синей кнопки')")]
	[LessVariableName("btn--blue")]
	public string ButtonBlue { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет синей кнопки при наведении')")]
	[LessVariableName("btn-hover--blue")]
	public string ButtonHoverBlue { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет синей кнопки без заливки')")]
	[LessVariableName("btn-outline--blue")]
	public string ButtonOutlineBlue { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет синей кнопки без заливки при наведении')")]
	[LessVariableName("btn-outline-hover--blue")]
	public string ButtonOutlineHoverBlue { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет красной кнопки')")]
	[LessVariableName("btn--red")]
	public string ButtonRed { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет красной кнопки при наведении')")]
	[LessVariableName("btn-hover--red")]
	public string ButtonHoverRed { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет красной кнопки без заливки')")]
	[LessVariableName("btn-outline--red")]
	public string ButtonOutlineRed { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет красной кнопки без заливки при наведении')")]
	[LessVariableName("btn-outline-hover--red")]
	public string ButtonOutlineHoverRed { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет зеленой кнопки')")]
	[LessVariableName("btn--green")]
	public string ButtonGreen { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет зеленой кнопки при наведении')")]
	[LessVariableName("btn-hover--green")]
	public string ButtonHoverGreen { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет зеленой кнопки без заливки')")]
	[LessVariableName("btn-outline--green")]
	public string ButtonOutlineGreen { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет зеленой кнопки без заливки при наведении')")]
	[LessVariableName("btn-outline-hover--green")]
	public string ButtonOutlineHoverGreen { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет желтой кнопки')")]
	[LessVariableName("btn--yellow")]
	public string ButtonYellow { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет желтой кнопки при наведении')")]
	[LessVariableName("btn-hover--yellow")]
	public string ButtonHoverYellow { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет желтой кнопки без заливки')")]
	[LessVariableName("btn-outline--yellow")]
	public string ButtonOutlineYellow { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет желтой кнопки без заливки при наведении')")]
	[LessVariableName("btn-outline-hover--yellow")]
	public string ButtonOutlineHoverYellow { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет простой кнопки')")]
	[LessVariableName("btn--simple")]
	public string ButtonSimple { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет простой кнопки при наведении')")]
	[LessVariableName("btn-hover--simple")]
	public string ButtonHoverSimple { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет простой кнопки без заливки')")]
	[LessVariableName("btn-outline--simple")]
	public string ButtonOutlineSimple { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет простой кнопки без заливки при наведении')")]
	[LessVariableName("btn-outline-hover--simple")]
	public string ButtonOutlineHoverSimple { get; set; }

	[DefaultValue(ButtonStyle.Blue)]
	[JsonProperty(/*Could not decode attribute arguments.*/)]
	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Главное действие')")]
	public ButtonStyle MainActionButton { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет кнопки главного действия')")]
	[LessVariableName("btn--main")]
	public string ButtonMain => MainActionButton switch
	{
		ButtonStyle.Green => ButtonGreen, 
		ButtonStyle.Yellow => ButtonYellow, 
		ButtonStyle.Red => ButtonRed, 
		ButtonStyle.MetroGray => ButtonGray, 
		ButtonStyle.Simple => ButtonSimple, 
		_ => ButtonBlue, 
	};

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет кнопки главного действия при наведении')")]
	[LessVariableName("btn-hover--main")]
	public string ButtonHoverMain => MainActionButton switch
	{
		ButtonStyle.Green => ButtonHoverGreen, 
		ButtonStyle.Yellow => ButtonHoverYellow, 
		ButtonStyle.Red => ButtonHoverRed, 
		ButtonStyle.MetroGray => ButtonHoverGray, 
		ButtonStyle.Simple => ButtonHoverSimple, 
		_ => ButtonHoverBlue, 
	};

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет кнопки главного действия без заливки')")]
	[LessVariableName("btn-outline--main")]
	public string ButtonOutlineMain => MainActionButton switch
	{
		ButtonStyle.Green => ButtonOutlineGreen, 
		ButtonStyle.Yellow => ButtonOutlineYellow, 
		ButtonStyle.Red => ButtonOutlineRed, 
		ButtonStyle.MetroGray => ButtonOutlineGray, 
		ButtonStyle.Simple => ButtonOutlineSimple, 
		_ => ButtonOutlineBlue, 
	};

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет кнопки главного действия без заливки при наведении')")]
	[LessVariableName("btn-outline-hover--main")]
	public string ButtonOutlineHoverMain => MainActionButton switch
	{
		ButtonStyle.Green => ButtonOutlineHoverGreen, 
		ButtonStyle.Yellow => ButtonOutlineHoverYellow, 
		ButtonStyle.Red => ButtonOutlineHoverRed, 
		ButtonStyle.MetroGray => ButtonOutlineHoverGray, 
		ButtonStyle.Simple => ButtonOutlineHoverSimple, 
		_ => ButtonOutlineHoverBlue, 
	};

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет рамки кнопки главного действия')")]
	[LessVariableName("btn-border--main")]
	public string ButtonBorderMain
	{
		get
		{
			if (MainActionButton == ButtonStyle.Simple)
			{
				return ButtonOutlineMain;
			}
			return ButtonMain;
		}
	}

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет рамки кнопки главного действия при наведении')")]
	[LessVariableName("btn-border-hover--main")]
	public string ButtonBorderHoverMain
	{
		get
		{
			if (MainActionButton == ButtonStyle.Simple)
			{
				return ButtonOutlineMain;
			}
			return ButtonHoverMain;
		}
	}

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет текста кнопки главного действия')")]
	[LessVariableName("btn-text--main")]
	public string ButtonTextMain => GetTextColor(MainActionButton);

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет ссылки кнопки главного действия')")]
	[LessVariableName("btn-link--main")]
	public string ButtonLinkMain => MainActionButton switch
	{
		ButtonStyle.Green => ButtonOutlineGreen, 
		ButtonStyle.Yellow => ButtonOutlineYellow, 
		ButtonStyle.Red => ButtonOutlineRed, 
		ButtonStyle.MetroGray => ButtonOutlineGray, 
		ButtonStyle.Simple => GeneralFontColor, 
		_ => ButtonOutlineBlue, 
	};

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет текста вкладки')")]
	[LessVariableName("tab-font-color")]
	public string TabFontColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет текста счетчика')")]
	[LessVariableName("tab-counter-font-color")]
	public string CounterTextColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет фона счетчика')")]
	[LessVariableName("tab-counter-background-color")]
	public string CounterBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет активной вкладки')")]
	[LessVariableName("tab-background-color--active")]
	public string ActiveTabBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет текста активной вкладки')")]
	[LessVariableName("tab-font-color--active")]
	public string ActiveTabFontColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет текста счетчика активной вкладки')")]
	[LessVariableName("tab-counter-font-color--active")]
	public string ActiveCounterTextColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет фона счетчика активной вкладки')")]
	[LessVariableName("tab-counter-background-color--active")]
	public string ActiveCounterBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет границы')")]
	[LessVariableName("control-border-color")]
	public string ControlBorderColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет границы при наведении')")]
	[LessVariableName("control-border-color--hover")]
	public string ControlHoverBorderColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет границы в фокусе')")]
	[LessVariableName("control-border-color--focus")]
	public string ControlFocusBorderColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет фона контрола при наведении')")]
	[LessVariableName("control-background-color--hover")]
	public string ControlHoverBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет фона отключенного контрола')")]
	[LessVariableName("control-background-color--disabled")]
	public string ControlDisabledBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет фона активного элемента')")]
	[LessVariableName("control-background-color--active")]
	public string ControlActiveBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет фона ошибки')")]
	[LessVariableName("alert-background-color--error")]
	public string AlertErrorBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет границ ошибки')")]
	[LessVariableName("alert-border-color--error")]
	public string AlertErrorBorderColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет иконки ошибки')")]
	[LessVariableName("alert-icon-color--error")]
	public string AlertErrorIconColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет фона предупреждения')")]
	[LessVariableName("alert-background-color--warning")]
	public string AlertWarningBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет границ предупреждения')")]
	[LessVariableName("alert-border-color--warning")]
	public string AlertWarningBorderColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет иконки предупреждения')")]
	[LessVariableName("alert-icon-color--warning")]
	public string AlertWarningIconColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет фона положительного результата')")]
	[LessVariableName("alert-background-color--success")]
	public string AlertSuccessBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет границ положительного результата')")]
	[LessVariableName("alert-border-color--success")]
	public string AlertSuccessBorderColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет иконки положительного результата')")]
	[LessVariableName("alert-icon-color--success")]
	public string AlertSuccessIconColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет фона информации')")]
	[LessVariableName("alert-background-color--information")]
	public string AlertInformationBackgroundColor { get; set; }

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет границ информации')")]
	[LessVariableName("alert-border-color--information")]
	public string AlertInformationBorderColor { get; set; }

	[JsonIgnore]
	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет тени c прозрачностью 10')")]
	[LessVariableName("shadow-color-10")]
	public string ShadowColor10 => GetColorWithAlpha(ShadowColor, 10);

	[JsonIgnore]
	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Цвет тени c прозрачностью 20')")]
	[LessVariableName("shadow-color-20")]
	public string ShadowColor20 => GetColorWithAlpha(ShadowColor, 20);

	public ColorSchemeSettingsModel()
	{
		MainActionButton = ButtonStyle.Blue;
	}

	public static string ToJson(ColorSchemeSettingsModel colorSchemeSettings)
	{
		return JsonConvert.SerializeObject((object)colorSchemeSettings);
	}

	public static ColorSchemeSettingsModel FromJson(string colorSchemeSettingsData)
	{
		return JsonConvert.DeserializeObject<ColorSchemeSettingsModel>(colorSchemeSettingsData);
	}

	public static ColorSchemeSettingsModel FromColorScheme(IColorScheme colorScheme)
	{
		return FromJson(colorScheme.SettingsData);
	}

	private string GetColorWithAlpha(string color, int alpha)
	{
		Color baseColor = color.ToSystemColor();
		Color color2 = Color.FromArgb(alpha, baseColor);
		return $"rgba({color2.R}, {color2.G}, {color2.B}, {((double)(int)color2.A / 100.0).ToString(CultureInfo.InvariantCulture)})";
	}

	private string GetTextColor(ButtonStyle buttonStyle)
	{
		if ((uint)(buttonStyle - 1) <= 1u || (uint)(buttonStyle - 4) <= 1u)
		{
			return GeneralNegativeFontColor;
		}
		return GeneralFontColor;
	}
}
