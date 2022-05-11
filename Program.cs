namespace SecondoGiorno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int iSomma = esercizi_es02.StampaSomma(10, 20);

            Console.WriteLine("La somma è {0}", iSomma);

            int iNumeroDaRaddoppiare = 9;
            esercizi_es02.RaddoppiaNumero(ref iNumeroDaRaddoppiare);
            Console.WriteLine("il numero vale {0}", iNumeroDaRaddoppiare);

            string sNome = "ciao";
            //con ref passo una variabile, senza passo il valore della variabile
            esercizi_es02.ModificaStringa(ref sNome);
            Console.WriteLine("La parola è {0}", sNome);
            */


            // vettori = array, devo specificare la lunghezza dell'array
            // specifico che è un vettore con le []
            int[] ArrayDiNumeri;
            ArrayDiNumeri = new int[4];


            Console.WriteLine("Scegli un numero");
            string sNumeroUtente;
            sNumeroUtente = Console.ReadLine();
            int iNumeriInseriti = 0;
            while ((sNumeroUtente.Length > 0) && (iNumeriInseriti < 4))
            {
                ArrayDiNumeri[iNumeriInseriti] = int.Parse(sNumeroUtente);
                iNumeriInseriti++;
                sNumeroUtente = Console.ReadLine();
            }

            /*for (int i = 0; i < ArrayDiNumeri.Length; i++)
            {
                Console.WriteLine("Scegli un numero");
                int iNumeroUtente = 0;
                try
                {
                    iNumeroUtente = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("hai sbagliato!!!");
                }
                ArrayDiNumeri[i] = iNumeroUtente;
            }*/



            /*ArrayDiNumeri[0] = 1;
            ArrayDiNumeri[1] = 2;
            ArrayDiNumeri[2] = 3;
            ArrayDiNumeri[3] = 4;*/

            float fMedia;
            fMedia = esercizi_es02.GeneraMedia(ArrayDiNumeri);

            Console.WriteLine("La media è {0}", fMedia);

            string[] ArrayDiStringhe;
            ArrayDiStringhe = new string[10];

            ArrayDiStringhe[3] = "ciccio";
            Console.WriteLine("La lettera è {0}", ArrayDiStringhe[3][4]);


        }
    }
}