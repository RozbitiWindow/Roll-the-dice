namespace kostka
{
    class Kostka
    {
        /// <summary>
        /// Generuje nahodný číslo od 1 - pocet stran
        /// </summary>
        /// <param name="pocetstran"></param>
        /// Pocet stran k generaci
        /// <returns></returns>
        
        public int hod (int pocetstran)
        {
            int number = new Random().Next(1, pocetstran + 1);
            return number;
        }
    }
}

