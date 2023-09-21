namespace Lista2
{
    internal class DadoVirtual
    {
        private int numFaces;
        private Random random;

        public DadoVirtual(int numFaces)
        {
            this.numFaces = numFaces;
            random = new Random();
        }

        public int Rolar()
        {
            return random.Next(1, numFaces + 1);
        }
    }
}
