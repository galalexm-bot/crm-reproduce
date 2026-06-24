namespace EleWise.ELMA.Model.Entities;

public interface ISoftDeletable
{
	bool IsDeleted { get; set; }

	bool HardDelete { get; set; }
}
