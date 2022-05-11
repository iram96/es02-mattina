namespace SecondoGiorno
{
    public class esercizi_es02
    {
        public static int StampaSomma(int Numero1, int Numero2)
        {
            int iSomma = Numero1 + Numero2;
            return iSomma;
        }
        public static void RaddoppiaNumero(ref int iNumeroDaRaddoppiare)
        {
            iNumeroDaRaddoppiare = iNumeroDaRaddoppiare * 2;
            //return con void non ho bisogno del return, al massimo return vuoto
        }

        public static void ModificaStringa(ref string sStringaDaModificare)
        {
            sStringaDaModificare = sStringaDaModificare + "abc";

        }
    }
}