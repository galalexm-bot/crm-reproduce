namespace EleWise.TemplateGenerator.Adl.Tree;

public class PlainText : TreeItem
{
	public string Text { get; set; }

	public override string ToString()
	{
		return Text;
	}

	public override TreeItem CreateCopy(TreeItem parent)
	{
		PlainText obj = (PlainText)base.CreateCopy(parent);
		obj.Text = Text;
		return obj;
	}
}
