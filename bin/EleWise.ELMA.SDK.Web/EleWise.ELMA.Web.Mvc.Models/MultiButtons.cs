using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Models;

public class MultiButtons
{
	public string Id { get; set; }

	public List<MultiButtonsItem> Items { get; set; }

	public int ButtonMaxSymbols { get; set; }

	public int ButtonMaxWidth { get; set; }

	public string Onclick { get; set; }

	public string OnDeleteClick { get; set; }

	public bool Deletable { get; set; }

	public MultiButtons(string id)
	{
		Items = new List<MultiButtonsItem>();
		Id = (string.IsNullOrEmpty(id) ? string.Format("mbp{0}", Guid.NewGuid().ToString().Replace("-", "")) : id);
		Init();
	}

	private void Init()
	{
		ButtonMaxSymbols = 25;
		ButtonMaxWidth = 250;
	}
}
