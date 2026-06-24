using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Web.Mvc.Models.Settings;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Web.Mvc.Services;

[Component(Order = 1000)]
public class DiagnosticsSettingsModuleController : GlobalSettingsModuleControllerBase<DiagnosticsSettings, DiagnosticsSettingsModule>
{
	public static IEnumerable<DropDownItem> ExportReportIntervals
	{
		get
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected O, but got Unknown
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Expected O, but got Unknown
			DropDownItem[] array = new DropDownItem[8];
			DropDownItem val = new DropDownItem();
			val.set_Value("0");
			val.set_Text(SR.T("Раз в день"));
			array[0] = val;
			DropDownItem val2 = new DropDownItem();
			val2.set_Value("360");
			val2.set_Text(SR.T("Каждые 6 часов"));
			array[1] = val2;
			DropDownItem val3 = new DropDownItem();
			val3.set_Value("180");
			val3.set_Text(SR.T("Каждые 3 часа"));
			array[2] = val3;
			DropDownItem val4 = new DropDownItem();
			val4.set_Value("60");
			val4.set_Text(SR.T("Каждый час"));
			array[3] = val4;
			DropDownItem val5 = new DropDownItem();
			val5.set_Value("30");
			val5.set_Text(SR.T("Каждые 30 минут"));
			array[4] = val5;
			DropDownItem val6 = new DropDownItem();
			val6.set_Value("15");
			val6.set_Text(SR.T("Каждые 15 минут"));
			array[5] = val6;
			DropDownItem val7 = new DropDownItem();
			val7.set_Value("5");
			val7.set_Text(SR.T("Каждые 5 минут"));
			array[6] = val7;
			DropDownItem val8 = new DropDownItem();
			val8.set_Value("1");
			val8.set_Text(SR.T("Каждую минуту"));
			array[7] = val8;
			return (IEnumerable<DropDownItem>)(object)array;
		}
	}

	public DiagnosticsSettingsModuleController(DiagnosticsSettingsModule module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderEdit(HtmlHelper html)
	{
		if (base.Module.Settings == null)
		{
			base.Module.Settings = new DiagnosticsSettings();
		}
		base.Module.Settings.InitEventProcessorsInfos();
		return PartialExtensions.Partial(html, "EditorTemplates/DiagnosticsSettings", (object)base.Module.Settings);
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		if (base.Module.Settings == null)
		{
			base.Module.Settings = new DiagnosticsSettings();
		}
		base.Module.Settings.InitEventProcessorsInfos();
		return PartialExtensions.Partial(html, "DisplayTemplates/DiagnosticsSettings", (object)base.Module.Settings);
	}
}
