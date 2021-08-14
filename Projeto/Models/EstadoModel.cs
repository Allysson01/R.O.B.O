namespace R.O.B.O.Models
{
    public class EstadoModel
    {
        public dynamic EstadoAtual { get; private set; }
        public string Comando { get; private set; }

        internal void AddEstadoAtual(dynamic estadoAtual)
        {
            EstadoAtual = estadoAtual;
        }

        internal void AddComando(string comando)
        {
            Comando = comando;
        }
    }
}
