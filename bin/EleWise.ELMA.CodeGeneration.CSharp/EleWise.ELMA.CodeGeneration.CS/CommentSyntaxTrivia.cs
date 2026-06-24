namespace EleWise.ELMA.CodeGeneration.CSharp.Trivias;

public class CommentSyntaxTrivia : SyntaxTrivia
{
	private readonly string _text;

	public CommentSyntaxTrivia(string text)
	{
		_text = text;
	}

	internal override void Generate()
	{
		GenerationContext.Current.WriteLine(_text);
	}
}
