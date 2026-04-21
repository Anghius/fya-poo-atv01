public class LampadaInteligente
{
    // Encapsulamento (atributos privados)
    private string _marca;
    private readonly string _tecnologia; // somente leitura
    private bool _ligada;
    private int _brilho;

    // Propriedades públicas
    public string Marca
    {
        get { return _marca; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _marca = value;
        }
    }

    public string Tecnologia
    {
        get { return _tecnologia; } // somente leitura
    }

    public bool Ligada
    {
        get { return _ligada; }
    }

    public int Brilho
    {
        get { return _brilho; }
    }

    // Campo calculado (exemplo extra)
    public string EstadoDescricao
    {
        get { return _ligada ? "Ligada" : "Desligada"; }
    }

    // Construtor obrigatório
    public LampadaInteligente(string marca, string tecnologia)
    {
        if (string.IsNullOrWhiteSpace(marca))
            throw new ArgumentException("Marca inválida.");

        if (string.IsNullOrWhiteSpace(tecnologia))
            throw new ArgumentException("Tecnologia inválida.");

        _marca = marca;
        _tecnologia = tecnologia;
        _ligada = false;   // inicia desligada
        _brilho = 100;     // brilho padrão
    }

    // Método alternar (liga/desliga)
    public void Alternar()
    {
        _ligada = !_ligada;
    }

    // Método para ajustar brilho
    public void AjustarBrilho(int novoBrilho)
    {
        if (!_ligada)
            throw new InvalidOperationException("Não é possível ajustar o brilho com a lâmpada desligada.");

        if (novoBrilho < 0 || novoBrilho > 100)
            throw new ArgumentException("O brilho deve estar entre 0 e 100.");

        _brilho = novoBrilho;
    }

    // Sobrescrita do ToString()
    public override string ToString()
    {
        return $"Marca: {_marca}, Tecnologia: {_tecnologia}, Estado: {EstadoDescricao}, Brilho: {_brilho}%";
    }
}
