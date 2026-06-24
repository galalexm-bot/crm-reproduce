using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using EleWise.ELMA.BPM.Mvc.Application.Orchard;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime;

namespace EleWise.ELMA.BPM.Web;

public class Activation : Page
{
	private class ModuleInfoForText
	{
		public string Name { get; set; }

		public string LicenseCount { get; set; }
	}

	private Color redColor = Color.FromArgb(230, 45, 50);

	private Color greenColor = Color.FromArgb(62, 168, 83);

	protected HtmlHead Head1;

	protected HtmlGenericControl activateBody;

	protected Literal lblEdition;

	protected Literal lblRegNumber;

	protected Label lblActivationInfo;

	protected HyperLink hlActivatedModules;

	protected Label lbActivatingComponents;

	protected bool CanAddActivationKey
	{
		get
		{
			if (ComponentManager.Initialized && ComponentManager.Current.LicenseManager != null)
			{
				return ComponentManager.Current.LicenseManager.CanAddActivationKey();
			}
			return false;
		}
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (OrchardApplication.ActivationPage != "Activation.aspx")
		{
			base.Response.Redirect("~/" + OrchardApplication.ActivationPage, endResponse: false);
			Context.ApplicationInstance.CompleteRequest();
			return;
		}
		if (!ComponentManager.Initialized)
		{
			base.Response.Redirect("~/StartInfo.aspx", endResponse: false);
			Context.ApplicationInstance.CompleteRequest();
			return;
		}
		hlActivatedModules.Visible = false;
		ILicensedUnit mainLicensedUnit = ComponentManager.Current.ModuleManager.MainLicensedUnit;
		lblRegNumber.Text = ComponentManager.Current.LicenseManager.GetRegistrationKey(mainLicensedUnit);
		ILicenseInfo licenseInfo = null;
		if (ComponentManager.Current.ModuleManager.MainApplication != null)
		{
			foreach (ILicensedUnit item in ComponentManager.Current.ModuleManager.MainApplication.SystemModules.OfType<ILicensedUnit>())
			{
				ILicenseInfo licenseInfo2 = item.GetLicenseInfo();
				if (licenseInfo2 != null && licenseInfo2.Status != 0)
				{
					licenseInfo = licenseInfo2;
					break;
				}
			}
		}
		ILicenseInfo licenseInfo3 = licenseInfo ?? mainLicensedUnit.GetLicenseInfo();
		ITrialLicenseInfo trialLicenseInfo = licenseInfo3 as ITrialLicenseInfo;
		if (licenseInfo3 != null && licenseInfo3.Status != LicenseStatus.NotActivated)
		{
			switch (licenseInfo3.Status)
			{
			case LicenseStatus.Activated:
				if (StartInformation.Root.Status == StartStatus.NotActivated && !string.IsNullOrEmpty(ELMAEnviromentStarter.StartupExceptionText))
				{
					lblActivationInfo.ForeColor = redColor;
					if (ELMAEnviromentStarter.StartupException is LicenseActivationRequiredException ex && ex.ModuleNames != null)
					{
						lblActivationInfo.Text = SR.T("Для запуска данной конфигурации требуется активировать компоненты");
						hlActivatedModules.Visible = true;
						lbActivatingComponents.Text = GenerateModulesActivationText(mainLicensedUnit, ex.ModuleNames.Select((string mn) => new ModuleInfoForText
						{
							Name = mn
						}).ToArray(), needToken: true);
					}
					else
					{
						lblActivationInfo.Text = ELMAEnviromentStarter.StartupExceptionText;
					}
				}
				else
				{
					IWorkplaceLicenseInfo workplaceLicenseInfo = licenseInfo3 as IWorkplaceLicenseInfo;
					string text = ((trialLicenseInfo == null || !trialLicenseInfo.TrialExpiration.HasValue) ? SR.T("Количество лицензий: {0}", (workplaceLicenseInfo != null && workplaceLicenseInfo.WorkplaceCount.HasValue) ? workplaceLicenseInfo.WorkplaceCount.Value : 0u) : ((licenseInfo3.LicenseType != 2) ? SR.T("Количество лицензий: {0}. Срок действия лицензии: {1}.", (workplaceLicenseInfo != null && workplaceLicenseInfo.WorkplaceCount.HasValue) ? workplaceLicenseInfo.WorkplaceCount.Value : 0u, trialLicenseInfo.TrialExpiration.Value.ToShortDateString()) : SR.T("Количество лицензий: {0}. Система находится в аренде до {1}.", (workplaceLicenseInfo != null && workplaceLicenseInfo.WorkplaceCount.HasValue) ? workplaceLicenseInfo.WorkplaceCount.Value : 0u, trialLicenseInfo.TrialExpiration.Value.ToShortDateString())));
					lblActivationInfo.Text = text;
					lblActivationInfo.ForeColor = greenColor;
				}
				break;
			case LicenseStatus.DateExpired:
			{
				string text = ((licenseInfo3.LicenseType == 2) ? SR.T("Истек срок аренды. Для продолжения работы введите новый ключ активации.") : SR.T("Истек срок действия лицензии. Для продолжения работы введите новый ключ активации."));
				lblActivationInfo.Text = text;
				lblActivationInfo.ForeColor = redColor;
				if (!ComponentManager.Initialized)
				{
					break;
				}
				hlActivatedModules.Visible = true;
				IEnumerable<IStoreComponentInfo> storeComponentsInfo = ComponentManager.Current.PackageService.GetStoreComponentsInfo(forRuntime: true);
				IEnumerable<ElmaStoreComponentManifest> installedManifests = ComponentManager.Current.ModuleManager.GetInstalledComponentManifests();
				lbActivatingComponents.Text = GenerateModulesActivationText(mainLicensedUnit, storeComponentsInfo.Where((IStoreComponentInfo c) => installedManifests.Any((ElmaStoreComponentManifest m) => m.Id.Equals(c.Id))).Select(delegate(IStoreComponentInfo ci)
				{
					ModuleInfoForText moduleInfoForText = new ModuleInfoForText
					{
						Name = ((!string.IsNullOrEmpty(ci.Title)) ? SR.T(ci.Title) : ci.Id)
					};
					ILicenseInfo licenseInfo4 = ((ci.LicensedUnit != null) ? ci.LicensedUnit.GetLicenseInfo() : null);
					if (licenseInfo4 is IWorkplaceLicenseInfo workplaceLicenseInfo2)
					{
						moduleInfoForText.LicenseCount = (workplaceLicenseInfo2.WorkplaceCount.HasValue ? workplaceLicenseInfo2.WorkplaceCount.Value.ToString() : SR.T("Не ограничено"));
					}
					return moduleInfoForText;
				}).ToArray(), needToken: false);
				break;
			}
			}
		}
		else
		{
			lblActivationInfo.Text = SR.T("Система не активирована");
			lblActivationInfo.ForeColor = redColor;
		}
		lblEdition.Text = VersionInfo.GetEdition();
	}

	private string GenerateModulesActivationText(ILicensedUnit mainLicenseUnit, IEnumerable<ModuleInfoForText> infos, bool needToken)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(SR.T("Редакция системы"));
		stringBuilder.Append(": ");
		stringBuilder.AppendLine(VersionInfo.GetEdition());
		stringBuilder.Append(SR.T("Регистрационный ключ"));
		stringBuilder.Append(": ");
		stringBuilder.AppendLine(ComponentManager.Current.LicenseManager.GetRegistrationKey(mainLicenseUnit));
		List<string> tokenItems = new List<string>();
		if (needToken)
		{
			stringBuilder.Append(SR.T("Токен сервера"));
			stringBuilder.AppendLine(": ");
			string text = ComponentManager.Current.LicenseManager.GetActivationToken();
			while (text != null && text.Length > 0)
			{
				tokenItems.Add((text.Length > 40) ? text.Substring(0, 40) : text);
				text = ((text.Length > 40) ? text.Substring(40) : "");
			}
			foreach (string item in tokenItems)
			{
				stringBuilder.AppendLine(item);
			}
		}
		stringBuilder.AppendLine("==========");
		StringBuilder sb = new StringBuilder();
		IEnumerable<IStoreComponentInfo> storeComponentsInfo = ComponentManager.Current.PackageService.GetStoreComponentsInfo(forRuntime: true);
		IEnumerable<ElmaStoreComponentManifest> installedComponentManifests = ComponentManager.Current.ModuleManager.GetInstalledComponentManifests();
		Action<string> Append = delegate(string s)
		{
			sb.Append(HttpUtility.HtmlEncode(s));
		};
		sb.AppendLine("<table class=\"activationComponentsTable\">");
		sb.AppendLine("<tr>");
		sb.Append("<td class=\"nameColumn\">");
		Append(SR.T("Название компонента"));
		sb.AppendLine("</td>");
		sb.Append("<td class=\"licenseColumn\">");
		Append(SR.T("Лицензия"));
		sb.AppendLine("</td>");
		sb.AppendLine("</tr>");
		foreach (ModuleInfoForText info in infos)
		{
			sb.AppendLine("<tr>");
			sb.Append("<td class=\"nameColumn\">");
			Append(info.Name);
			stringBuilder.Append(info.Name);
			sb.AppendLine("</td>");
			sb.Append("<td class=\"licenseColumn\">");
			if (info.LicenseCount != null)
			{
				stringBuilder.Append(" (");
				stringBuilder.Append(SR.T("лицензий"));
				stringBuilder.Append(": ");
				stringBuilder.Append(info.LicenseCount);
				Append(info.LicenseCount);
				stringBuilder.Append(")");
			}
			sb.AppendLine("</td>");
			sb.AppendLine("</tr>");
			stringBuilder.AppendLine();
		}
		Action<string, Action> action = delegate(string title, Action appendContentFunc)
		{
			sb.AppendLine("<tr>");
			sb.Append("<td colspan=\"2\" class=\"nameColumn\">");
			Append(title);
			sb.AppendLine("</td>");
			sb.AppendLine("</tr>");
			sb.AppendLine("<tr>");
			sb.Append("<td colspan=\"2\">");
			appendContentFunc();
			sb.AppendLine("</td>");
			sb.AppendLine("</tr>");
		};
		action(SR.T("Редакция системы"), delegate
		{
			Append(VersionInfo.GetEdition());
		});
		action(SR.T("Регистрационный ключ"), delegate
		{
			Append(ComponentManager.Current.LicenseManager.GetRegistrationKey(mainLicenseUnit));
		});
		if (needToken)
		{
			action(SR.T("Токен сервера"), delegate
			{
				foreach (string item2 in tokenItems)
				{
					Append(item2);
					sb.Append("<br/>");
				}
			});
		}
		sb.AppendLine("</table>");
		sb.Append(string.Format("<input type=\"hidden\" id=\"{0}\" value=\"{1}\" />", "activationComponentsText", HttpUtility.HtmlAttributeEncode(stringBuilder.ToString())));
		return sb.ToString();
	}
}
