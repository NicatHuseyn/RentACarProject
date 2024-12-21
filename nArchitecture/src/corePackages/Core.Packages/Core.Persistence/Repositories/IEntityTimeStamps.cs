namespace Core.Persistence.Repositories;

public interface IEntityTimeStamps
{
    DateTime CreateDate { get; set; }
    DateTime? UpdateDate { get; set; }
    DateTime? DeleteDate { get; set; }
}
