using System.Collections.Generic;
using System.Linq;
using System.Web;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Security.Components;
using Newtonsoft.Json;

namespace EleWise.ELMA.Documents.Web.Models;

public class AutoCompleteDocumentVersionItem : AutoCompleteEntityItem
{
	public override string ObjectValuePrefix => BaseEntityUserTypeSelector.GetFullPrefix("Version");

	[JsonIgnore]
	public override string SelectedItemTemplateJs => HttpUtility.HtmlEncode(string.Format(MultiSelectPatternText, "{item.FileLink}", "{item.File}", string.Format(BasePatternText, "{item.Version}", "{item.StatusCssClass}", "{item.Status}", "{item.ChangeAuthor}", "{item.ChangeDate}")));

	public string File { get; set; }

	public string StatusCssClass { get; set; }

	public string Status { get; set; }

	public string ChangeAuthor { get; set; }

	public string ChangeDate { get; set; }

	public string FileLink { get; set; }

	public string Version { get; set; }

	[JsonIgnore]
	public string MultiSelectText { get; set; }

	private string BasePatternText { get; set; }

	private string MultiSelectPatternText { get; set; }

	public static AutoCompleteDocumentVersionItem[] GetItems(IEnumerable<IDocumentVersion> versions)
	{
		return (from v in versions
			where v != null
			select GetItem(v) into i
			orderby i.Version descending
			select i).ToArray();
	}

	public static AutoCompleteDocumentVersionItem GetItem(IDocumentVersion version)
	{
		if (version == null)
		{
			return null;
		}
		string text = ((version.GetId() != null) ? version.GetId().ToString() : "");
		string text2 = string.Empty;
		if (version.Document != null && WebDocumentManager.Instance.IsWebDocument(version.Document))
		{
			text2 = version.Document.Name;
		}
		else if (version.File != null)
		{
			text2 = version.File.ToString();
		}
		string text3 = (version.Version.HasValue ? version.Version.ToString() : "");
		string versionCssClass = DocumentVersionGrid.GetVersionCssClass(version);
		string displayName = version.Status.GetDisplayName();
		string text4 = ((version.ChangeAuthor != null) ? version.ChangeAuthor.ToString() : "");
		string text5 = (version.ChangeDate.HasValue ? version.ChangeDate.ToString() : "");
		string text6 = $"/Documents/DocumentVersion/Download/{text}";
		string text7 = SR.T("\r\n                    <div><span style='color: gray'>Номер:</span> {0}</div>    \r\n                    <div><span style='color: gray;'>Статус:</span> <span class='{1}'> {2} </span> </div>\r\n                    <div><span style='color: gray;'>Изменения внес:</span> {3} </div>\r\n                    <div><span style='color: gray;'>Дата изменения:</span> {4} </div>");
		string text8 = string.Format(text7, text3, versionCssClass, displayName, text4, text5);
		string dropDownText = $"<div> <div><a>{text2}</a></div> {text8} </div>";
		string text9 = "<div style='float: left;'>\r\n                        <table>\r\n                            <tr><td style='padding-left: 0'>\r\n                                <div class='brickPanel border-panel'>\r\n                                    <div><a href='{0}' style='white-space: nowrap;'><span class='attach' style='width: 16px; height: 16px; float: left'></span><span>{1}</span></div>\r\n                                    {2}\r\n                                </div>\r\n                            </td></tr>\r\n                        </table>\r\n                    </div>";
		string multiSelectText = string.Format(text9, text6, text2, text8);
		return new AutoCompleteDocumentVersionItem
		{
			Value = text,
			Text = text2,
			DropDownText = dropDownText,
			MultiSelectText = multiSelectText,
			FileLink = text6,
			File = text2,
			Version = text3,
			StatusCssClass = versionCssClass,
			Status = displayName,
			ChangeAuthor = text4,
			ChangeDate = text5,
			BasePatternText = text7,
			MultiSelectPatternText = text9
		};
	}
}
