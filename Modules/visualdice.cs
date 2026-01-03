namespace logo //MUSIM psta jako druhy
{
    class WriteDice //je to vyjebany ale je to tak
    {
        public int logo (int cislo)
        {
            switch (cislo)
            {
                case 1:
                    Console.WriteLine("┌─────┐\n│     │\n│  •  │\n│     │\n└─────┘");
                    break;
                case 2:
                    Console.WriteLine("┌─────┐\n│ •   │\n│     │\n│   • │\n└─────┘");
                    break;
                case 3:
                    Console.WriteLine("┌─────┐\n│ •   │\n│  •  │\n│   • │\n└─────┘");
                    break;
                case 4:
                    Console.WriteLine("┌─────┐\n│ • • │\n│     │\n│ • • │\n└─────┘");
                    break;
                case 5:
                    Console.WriteLine("┌─────┐\n│ • • │\n│  •  │\n│ • • │\n└─────┘");
                    break;
                case 6:
                    Console.WriteLine("┌─────┐\n│ • • │\n│ • • │\n│ • • │\n└─────┘");
                    break;
                default:
                    Console.WriteLine("Currently we dont have dice for this number, please imagin it");
                    break;
            }
            return cislo;
        }
    }
}
    
