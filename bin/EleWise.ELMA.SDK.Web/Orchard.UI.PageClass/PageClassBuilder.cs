using System.Text;

namespace Orchard.UI.PageClass;

public class PageClassBuilder : IPageClassBuilder, IDependency
{
	private readonly StringBuilder _classNameBuilder;

	public PageClassBuilder()
	{
		_classNameBuilder = new StringBuilder();
	}

	public void AddClassNames(params object[] classNames)
	{
		if (classNames == null)
		{
			return;
		}
		foreach (object obj in classNames)
		{
			if (obj != null)
			{
				if (_classNameBuilder.Length > 0)
				{
					_classNameBuilder.AppendFormat(" {0}", obj);
				}
				else
				{
					_classNameBuilder.Append(obj);
				}
			}
		}
	}

	public override string ToString()
	{
		return _classNameBuilder.ToString().ToLower().Replace('.', '-');
	}
}
