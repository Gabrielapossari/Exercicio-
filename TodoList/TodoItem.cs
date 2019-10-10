namespace TodoList
{
    public class TodoItem
    {
        public string Titulo;
        public string Nota;

        public TodoItem(string Titulo, string Nota){  /// inicializando a classe  // Construdor igual ao nome da classe  // 
                                                    /// Construtor não tem retorno instancia uma classe e retorna um objeto 
            this.Titulo = Titulo;
            this.Nota = Nota;
        }
    }
}