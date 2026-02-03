namespace Bateu.Domain.Enums;

    public enum StatusReconciliacao
    {
        Pendente = 0,
        EmAndamento = 1,
        Concluida = 2,
        Falhada = 3,
        ParciamenteConcluida = 4
    }
    
    public enum TipoTransacao
    {
        Credito = 0,
        Debito = 1
    }

    public enum FonteTransacao
    {
        Banco = 0,
        Sistema = 1
    }

    public enum MatchStatus
    {
        Exato = 0,
        Aproximado = 1,
        Manual = 2,
        NaoConciliado = 3
    }