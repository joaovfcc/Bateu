namespace Bateu.Domain.Common;

public abstract class BaseEntity
{
    
    public Guid Id { get; protected set; }
    public DateTime? Criado { get; protected set; }
    public DateTime? Atualizado { get; protected set; }
    
    protected BaseEntity()
    {
        Id = Guid.NewGuid();
        Criado = DateTime.UtcNow;
    }
    
    protected void MarcarComoAtualizado()
    {
        Atualizado = DateTime.UtcNow;
    }
}