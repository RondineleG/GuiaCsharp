namespace Keywords
{
    public class Keywords
    {
        public Keywords() { }

        public int PropriedadePublica { get; set; }

        private int PropriedadePrivada
        {
            private get;
            private set;

        }

        struct CriandoStruct
        {
            public decimal preco;
            public string nome;
            public string descricao;
        }
    }
}
