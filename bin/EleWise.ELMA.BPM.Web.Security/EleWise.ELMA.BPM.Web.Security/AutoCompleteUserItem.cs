using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security.Extensions;
using EleWise.ELMA.BPM.Web.Security.Helper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.Boxes;
using Newtonsoft.Json;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class AutoCompleteUserItem : AutoCompleteEntityItem
{
	public const string LastItemValue = "3EA1A6F3-B106-4726-A1CD-77C41F43A614";

	public override string ObjectValuePrefix => BaseEntityUserTypeSelector.GetFullPrefix("User");

	[JsonIgnore]
	public override string SelectedItemTemplateJs => HttpUtility.HtmlEncode("<div class=\"userphoto-item-display {item.ListItemClass}\"><div class=\"user-photo-container userphoto-item-image\">" + HtmlExtensions.Image("{item.IconUrl}", new
	{
		align = "absmiddle"
	}) + "</div><div class=\"userphoto-item-content\"><a tabindex=\"-1\" href=\"#\" onclick=\"showUserInfo({item.ObjectId}); \" style=\"white-space: nowrap;\">{item.ShortName}</a><div class=\"comment3\">{item.Positions}</div><div class=\"absences\" tooltiptext=\"{item.AbsenceText}\">{item.AbsenceText}</div></div></div>");

	public string FullName { get; set; }

	public string ShortName { get; set; }

	public string Positions { get; set; }

	public string Replacements { get; set; }

	public string Absences { get; set; }

	public string AbsenceText { get; set; }

	public TimeZoneModel TimeZone { get; set; }

	public string TimeZoneDisplay { get; set; }

	public static string GetReplacementsAbsences4Text(IUser user)
	{
		return ReplacementUserHelper.GetReplacementsAbsencesText(user);
	}

	private static string GetReplacements(IUser user)
	{
		IList<IReplacement> replacementsReadOnly = ReplacementManager.Instance.GetReplacementsReadOnly(user);
		UserManager manager = UserManager.Instance;
		return JsonConvert.SerializeObject((object)replacementsReadOnly.Select(delegate(IReplacement r)
		{
			IUser user2 = manager.Load(r.TargetUser.Id);
			return new
			{
				StartDate = r.StartDate,
				EndDate = r.EndDate,
				TargetUser = new AutocompleteItem
				{
					Value = user2.Id.ToString(),
					Text = user2.GetFullNamePosition().HtmlEncode(),
					ViewText = user2.GetShortNamePosition().HtmlEncode()
				}
			};
		}).ToArray());
	}

	private static string GetAbsences(IUser user)
	{
		IList<IAbsence> absences = AbsenceManager.Instance.GetAbsences(user);
		if (absences.Count == 0)
		{
			return string.Empty;
		}
		return JsonConvert.SerializeObject((object)absences.Select((IAbsence r) => new { r.StartDate, r.EndDate, r.Description }).ToArray());
	}

	public static AutoCompleteUserItem[] GetItems(UrlHelper helper, IEnumerable<IUser> users, bool checkReplacement = false)
	{
		return GetItems(helper, users, checkReplacement, valueWithType: false);
	}

	public static AutoCompleteUserItem[] GetItems(UrlHelper helper, IEnumerable<IUser> users, bool checkReplacement, bool valueWithType)
	{
		return (from u in users
			where u != null
			select GetItem(helper, u, checkReplacement, valueWithType) into i
			where !string.IsNullOrEmpty(i.Text)
			select i).ToArray();
	}

	public static AutoCompleteUserItem GetItem(UrlHelper helper, IUser user, bool checkReplacement = false)
	{
		return GetItem(helper, user, checkReplacement, valueWithType: false);
	}

	public static AutoCompleteUserItem GetItem(UrlHelper helper, IUser user, bool checkReplacement, bool valueWithType)
	{
		return GetItem(helper, user, checkReplacement, valueWithType, null);
	}

	public static AutoCompleteUserItem GetItem(UrlHelper helper, IUser user, bool checkReplacement, bool valueWithType, EntitySelectGroupStyles styles)
	{
		if (user == null)
		{
			return null;
		}
		string text = user.GetFullName().HtmlEncode();
		string text2 = user.GetPositions().HtmlEncode();
		string text3 = user.GetShortName().HtmlEncode();
		string userIcon = helper.UserPhotoUrl(user, 32);
		string text4 = (checkReplacement ? GetReplacementsAbsences4Text(user) : "");
		string text5 = "";
		if (styles != null)
		{
			if (styles.FontColor.HasValue)
			{
				text5 += $"color:{ColorTranslator.ToHtml(styles.FontColor.Value)};";
			}
			if (styles.BackgroundColor.HasValue)
			{
				text5 += $"background:{ColorTranslator.ToHtml(styles.BackgroundColor.Value)};";
			}
			if (styles.FontStyle.HasValue)
			{
				switch (styles.FontStyle.Value)
				{
				case FontStyle.Italic:
					text5 += "font-style:italic;";
					break;
				case FontStyle.Bold:
					text5 += "font-weight:bold;";
					break;
				case FontStyle.Underline:
					text5 += "text-decoration:underline;";
					break;
				case FontStyle.Strikeout:
					text5 += "text-decoration:line-through;";
					break;
				}
			}
		}
		string formatPositions = (string.IsNullOrEmpty(text2) ? null : ("<div class=\"comment3\">" + text2 + "</div>"));
		string formatReplacement = (checkReplacement ? ("<div class=\"absences\" tooltiptext=\"" + text4.Replace("\"", "\\\"").HtmlEncode() + "\">" + text4.HtmlEncode() + "</div>") : null);
		string formatStyle = (string.IsNullOrEmpty(text5) ? null : (" style=\"" + text5 + "\""));
		Func<string, string, string> func = (string @class, string name) => string.Format("<div class=\"{0}{2}\"{3}><div class=\"user-photo-container userphoto-item-image\">{4}</div><div class=\"userphoto-item-content\">{1}{5}{6}</div></div>", @class, name, (user.Status == UserStatus.Blocked) ? " blocked-user" : null, formatStyle, HtmlExtensions.Image(userIcon, new
		{
			align = "absmiddle"
		}), formatPositions, formatReplacement);
		TimeZoneModel userTimeZone = Locator.GetServiceNotNull<ITimeZoneService>().GetUserTimeZone(user);
		return new AutoCompleteUserItem
		{
			Value = (valueWithType ? BaseEntityUserTypeSelector.GetFullPrefix("User") : null) + user.Id,
			Text = user.GetFullNamePosition().HtmlEncode(),
			DropDownText = func("userphoto-item", text),
			ViewText = func("userphoto-item-display", text3),
			FullName = text,
			ShortName = text3,
			Positions = text2,
			Replacements = (checkReplacement ? GetReplacements(user) : ""),
			Absences = (checkReplacement ? GetAbsences(user) : ""),
			AbsenceText = text4,
			IconUrl = userIcon,
			EntityUrl = helper.Entity(user),
			ListItemClass = ((user.Status == UserStatus.Blocked) ? "blocked" : ""),
			TimeZone = userTimeZone,
			TimeZoneDisplay = userTimeZone.ToString()
		};
	}

	public static AutoCompleteUserItem GetLastItem(string popupId, string url, string text)
	{
		url += string.Format("&ObjectPrefix={0}&SearchString={1}", "User", text);
		return new AutoCompleteUserItem
		{
			Value = "3EA1A6F3-B106-4726-A1CD-77C41F43A614",
			Text = "...",
			DropDownText = string.Format("<div class=\"userphoto-item-button\"><div class=\"userphoto-item-image\"></div><div class=\"userphoto-item-content-button\"><div class=\"comment\" onclick=\"openEntitySelectPopup('{0}','{1}')\">{2}</div></div></div>", popupId, url, SR.T("Показать все...")),
			ViewText = "...",
			VirtualItem = true
		};
	}
}
