using System.Collections.Generic;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html.Grids;

public class GridUtilityBuilder
{
	private string _id;

	private GridCommands _command;

	private string _callback;

	private string _form;

	private string _url;

	private string _ids;

	private string _commandName;

	private string _data;

	private string _dataContainer;

	public GridUtilityBuilder(string id)
	{
		_id = id;
	}

	public GridUtilityBuilder(string id, GridCommands command)
	{
		_id = id;
		_command = command;
	}

	public GridUtilityBuilder Command(GridCommands command)
	{
		_command = command;
		return this;
	}

	public GridUtilityBuilder Callback(string callback)
	{
		_callback = callback;
		return this;
	}

	public GridUtilityBuilder Form(string id)
	{
		_form = id;
		return this;
	}

	public GridUtilityBuilder Url(string url)
	{
		_url = url;
		return this;
	}

	public GridUtilityBuilder Ids(string ids)
	{
		_ids = ids;
		return this;
	}

	public GridUtilityBuilder CommandName(string name)
	{
		_commandName = name;
		return this;
	}

	public GridUtilityBuilder Data(string data)
	{
		_data = data;
		return this;
	}

	public GridUtilityBuilder DataContainer(string selector)
	{
		_dataContainer = selector;
		return this;
	}

	public MvcHtmlString Script()
	{
		string arg = "";
		List<string> list = new List<string>();
		switch (_command)
		{
		case GridCommands.Refresh:
			arg = "refreshGrid";
			list.Add($"'{_id}'");
			if (!string.IsNullOrEmpty(_callback))
			{
				list.Add(_callback);
			}
			break;
		case GridCommands.ApplyFilter:
			arg = "applyFilterGrid";
			list.Add($"'{_id}'");
			if (!string.IsNullOrEmpty(_form))
			{
				list.Add($"'{_form}'");
			}
			if (!string.IsNullOrEmpty(_callback))
			{
				list.Add(_callback);
			}
			break;
		case GridCommands.Custom:
			arg = "doCommandGridRows";
			list.Add($"'{_id}'");
			list.Add($"'{_commandName}'");
			if (!string.IsNullOrEmpty(_ids))
			{
				list.Add(_ids);
			}
			else
			{
				list.Add("null");
			}
			if (!string.IsNullOrEmpty(_url))
			{
				list.Add($"'{_url}'");
			}
			else
			{
				list.Add("null");
			}
			if (!string.IsNullOrEmpty(_data))
			{
				list.Add($"{_data}");
			}
			else
			{
				list.Add("null");
			}
			if (!string.IsNullOrEmpty(_dataContainer))
			{
				list.Add($"'{_dataContainer}'");
			}
			else
			{
				list.Add("null");
			}
			break;
		}
		return MvcHtmlString.Create(string.Format("{0}({1});", arg, string.Join(",", list)));
	}
}
