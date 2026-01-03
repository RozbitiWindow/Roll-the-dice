namespace kostka
{
    class Kostka
    {
        /// <summary>
        /// Nekde vymrda číslo od(from) do(to) a nasere ho jako number
        /// </summary>
        /// <param name="from"></param>
        /// začátek
        /// <param name="to"></param>
        /// konec + 1
        /// <param name="number"></param>
        /// vysledek RNG
        /// <returns></returns>
        public int hod (int from, int to)
        {
            int number = new Random().Next(from, to + 1);
            return number;
        }
    }
}


//pice to objektovy programovani je ez a MEGA dobry lol