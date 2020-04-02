namespace Aula3.App_Code
{
    public class Unica
    {
        private static Unica instancia = null;

        public string Nome { get; set; }

        private Unica()
        {
        }

        public static Unica Instancia
        {
            get
            {
                if (instancia == null)
                {
                    lock (typeof(Unica))
                    {
                        instancia = new Unica();
                    }
                }

                return instancia;
            }
        }


    }
}