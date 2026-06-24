using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Notifications.Impl.TemplateGenerator;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Functions;

namespace EleWise.ELMA.CRM.Notifications;

[Component]
public class CRMTemplateGeneratorFunctions : ITemplateGeneratorFunctionsContainer
{
	public static FormatedValue GetRelationshipMembers(FunctionEvaluationContext context)
	{
		if (context.Parameters.Count < 1 || context.Parameters[0] == null)
		{
			return null;
		}
		if (!(context.Parameters[0].Value is IRelationship relationship) || !((IEnumerable<IRelationshipUser>)relationship.RelationshipUsers).Any())
		{
			return null;
		}
		RelationshipUserStatus? status = null;
		if (context.Parameters[1].Value != null)
		{
			int num = Convert.ToInt32(context.Parameters[1].Value);
			if (Enum.IsDefined(typeof(RelationshipUserStatus), num))
			{
				status = (RelationshipUserStatus?)Enum.ToObject(typeof(RelationshipUserStatus), num);
			}
		}
		return new FormatedValue((from eu in (IEnumerable<IRelationshipUser>)relationship.RelationshipUsers
			where !status.HasValue || eu.Status == status.Value
			select eu.User).ToList());
	}

	public static FormatedValue PropertyRowIfCategory(FunctionEvaluationContext context)
	{
		string text = "";
		string text2 = "";
		if (context.Parameters.Count > 1)
		{
			string text3 = ((context.Parameters[0] != null) ? context.Parameters[0].ToString() : "");
			string text4 = ((context.Parameters[1] != null) ? context.Parameters[1].ToString() : "");
			if (!text3.Equals(text4))
			{
				List<long> oldCategory = (from x in text3.Split(',')
					where !string.IsNullOrWhiteSpace(x)
					select long.Parse(x)).ToList();
				List<long> newCategory = (from x in text4.Split(',')
					where !string.IsNullOrWhiteSpace(x)
					select long.Parse(x)).ToList();
				oldCategory.AddRange(newCategory);
				ICollection<ICategory> source = CategoryManager.Instance.FindByIdArray(oldCategory.ToArray());
				text2 = string.Join(",", from c in source
					where newCategory.Any((long d) => d == c.Id)
					select c into u
					select u.ToString());
				text = string.Join(",", from c in source
					where oldCategory.Any((long d) => d == c.Id)
					select c into u
					select u.ToString());
			}
			string text5 = text2;
			if (text != text2 && !string.IsNullOrEmpty(text))
			{
				text5 += SR.T("  (было: {0})", text);
			}
			StringBuilder stringBuilder = new StringBuilder();
			TemplateRenderMode renderMode = context.GenerationContext.GetRenderMode();
			string text6 = SR.T("Категории");
			if (renderMode == TemplateRenderMode.HTML)
			{
				stringBuilder.AppendLine("<tr>");
				stringBuilder.Append("  <td class=\"notificationLeft\">");
				stringBuilder.Append(context.GenerationContext.FormatProvider.FormatValue(new FormatedValue(text6)));
				stringBuilder.AppendLine("</td>");
				stringBuilder.Append("  <td>");
				stringBuilder.Append(text5);
				stringBuilder.AppendLine("</td>");
				stringBuilder.Append("</tr>");
				return new FormatedValue(MvcHtmlString.Create(stringBuilder.ToString()));
			}
			if (!string.IsNullOrEmpty(text6))
			{
				stringBuilder.Append(text6);
				stringBuilder.Append("{#NotificationTab#}");
				int length = text6.Length;
				int textCaptionMaxLength = context.GenerationContext.GetTextCaptionMaxLength();
				if (length > textCaptionMaxLength)
				{
					context.GenerationContext.SetTextCaptionMaxLength(length);
				}
			}
			stringBuilder.Append(text2);
			return new FormatedValue(stringBuilder.ToString());
		}
		return null;
	}
}
