using System.Collections.Generic;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

public class ValidateTreeItem
{
	public string RootFile { get; set; }

	public string File { get; set; }

	public ElmaStoreComponentManifest Manifest { get; set; }

	public List<ValidateMessage> Messages { get; set; }

	public List<ValidateTreeItem> Items { get; set; }

	public ValidateTreeItem()
	{
		Messages = new List<ValidateMessage>();
		Items = new List<ValidateTreeItem>();
	}

	public ValidateTreeItem(string rootFile, string file)
	{
		RootFile = rootFile;
		File = file;
		Messages = new List<ValidateMessage>();
		Items = new List<ValidateTreeItem>();
	}
}
