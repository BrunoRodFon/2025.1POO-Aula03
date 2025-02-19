namespace aula_03;
class Televisao
{
    //O metodo construtor possui o mesmo
    //nome da classe. Ele não possui retorno (nem mesmo o void)
    //Este método é executado sempre que uma instancia da classe
    //é criada
    //Por padrão, o C# cria um método contrutor publico vazio,
    //mas podemos criar métods construtores com outras
    //visibilidades e recebendo parametros, se necesário
    
    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
    }



    //Get: permite que seja executada a 
    //leitura do valor atual da propriedade

    //Set: permite que seja atribuido um 
    //valor para a propriedade

    //classe, propriedades e métodos possuem modificadores de acessos    //public: visiveis a todo o projeto
    //internal: visiveis somente no namespace
    //protected: visiveis somente na classe e nas classes que herdam
    //private: visiveis somente na classe que foram criados

    public float Tamanho { get; private set; }
    public int Resolucao { get; set; }
    public int Volume { get; set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }

}