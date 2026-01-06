
    class Dice
    {
        /// <summary> 
        /// Generuje nahodný číslo od 2 - pocet stran del parametru
        /// </summary>
        /// <param name="pocetstran">Pocet stran kostky</param>
        /// Pocet stran k generaci (pokud nenastaveno, tak 6)
        /// <returns></returns>
        
        public int hod (int pocetstran = 6) //jak si ríkal s tim nenastavením parametru tak jsem to udelal na zakladnich 6 protože si myslim ze to je pouzitelkny pro cokoli a kdikoly
        {
            if (pocetstran < 2)
            {
                pocetstran = 6;
                ArgumentException ex = new ArgumentException("Počet stran musí být alespoň 2. Nastavuji na výchozí hodnotu 6.");
                throw ex;
            }
            int number = new Random().Next(1, pocetstran + 1);
            Thread.Sleep(100);
            return number;
        }

        public int hodBuff (int pocetstran = 6) //Pc buff hod
        {
            if (pocetstran < 3)
            {
                pocetstran = 6;
                ArgumentException ex = new ArgumentException("Počet stran musí být alespoň 2. Nastavuji na výchozí hodnotu 6.");
                throw ex;
            }
            int number = new Random().Next(3, pocetstran + 1);
            Thread.Sleep(100);
            return number;
        }
    }


