namespace EleWise.ELMA.CRM.Db.MsSql;

internal class ForeignKeyInfo
{
	public string FK_Name { get; set; }

	public string RefTable { get; set; }

	public string RefColumn { get; set; }

	public string DestColumn { get; set; }
}
