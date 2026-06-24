using System.Linq;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.ConvertType;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Validation;

namespace EleWise.ELMA.Documents.Web.Models;

public class ConvertDocModel
{
	private string _docStr;

	private IDocument[] _sourceDocuments;

	[RequiredField]
	[Required(true)]
	public TypeInfo TargetType { get; set; }

	public DocTypeMappingInfo[] DocTypeMappingInfos { get; set; }

	public PropertyInfo[] TargetPropertiesInfos { get; set; }

	public string DocsStr
	{
		get
		{
			return _docStr;
		}
		set
		{
			_docStr = value;
		}
	}

	public IDocument[] SourceDocuments
	{
		get
		{
			if (_sourceDocuments == null && !string.IsNullOrEmpty(DocsStr))
			{
				string[] source = DocsStr.Split(',');
				_sourceDocuments = DocumentManager.Instance.FindByIdArray(source.Select(long.Parse).ToArray()).ToArray();
			}
			return _sourceDocuments ?? new IDocument[0];
		}
		set
		{
			_sourceDocuments = value;
		}
	}

	public string ReturnUrl { get; set; }

	public ConvertDocModel()
	{
		TargetType = new TypeInfo();
	}

	public ConvertDocModel(long[] docIds)
	{
		docIds.ForEach(delegate(long m)
		{
			DocsStr = DocsStr + m + ",";
		});
		DocsStr = (string.IsNullOrEmpty(DocsStr) ? DocsStr : DocsStr.TrimEnd(','));
		TargetType = new TypeInfo();
	}
}
