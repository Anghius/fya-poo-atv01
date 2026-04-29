public class CofreDigital
{
    // Encapsulamento
    private string _dono;
    private string _senha;
    private bool _estaAberto;
    private int _tentativasErradas;

    // Campo somente leitura
    private readonly int _limiteTentativas = 3;

    // Propriedades públicas
    public string Dono
    {
        get { return _dono; }
    }

    // Apenas leitura externa
    public bool EstaAberto
    {
        get { return _estaAberto; }
    }

    // Campo calculado 
    public bool EstaBloqueado
    {
        get { return _tentativasErradas >= _limiteTentativas; }
    }

    public int TentativasRestantes
    {
        get { return _limiteTentativas - _tentativasErradas; }
    }

    // Construtor
    public CofreDigital(string dono, string senhaInicial)
    {
        if (string.IsNullOrWhiteSpace(dono))
            throw new ArgumentException("O dono não pode ser vazio.");

        if (string.IsNullOrWhiteSpace(senhaInicial))
            throw new ArgumentException("A senha não pode ser vazia.");

        _dono = dono;
        _senha = senhaInicial;
        _estaAberto = false;
        _tentativasErradas = 0;
    }

    // Método abrir
    public string Abrir(string senhaInformada)
    {
        if (EstaBloqueado)
            return "Cofre Bloqueado! Reinicie para tentar novamente.";

        if (senhaInformada == _senha)
        {
            _estaAberto = true;
            _tentativasErradas = 0;
            return "Cofre aberto com sucesso!";
        }
        else
        {
            _tentativasErradas++;
            return $"Senha incorreta! Tentativas restantes: {TentativasRestantes}";
        }
    }

    // Método fechar
    public void Fechar()
    {
        _estaAberto = false;
    }

    // Método alterar senha
    public string AlterarSenha(string senhaAntiga, string novaSenha)
    {
        if (!_estaAberto)
            return "O cofre precisa estar aberto para alterar a senha.";

        if (senhaAntiga != _senha)
            return "Senha antiga incorreta.";

        if (string.IsNullOrWhiteSpace(novaSenha))
            return "Nova senha inválida.";

        _senha = novaSenha;
        return "Senha alterada com sucesso!";
    }

    // Método opcional de reset (desbloqueio)
    public void ResetarCofre()
    {
        _tentativasErradas = 0;
        _estaAberto = false;
    }

    // Sobrescrita do ToString()
    public override string ToString()
    {
        return $"Dono: {_dono} | Aberto: {_estaAberto} | Tentativas Erradas: {_tentativasErradas}";
    }
}