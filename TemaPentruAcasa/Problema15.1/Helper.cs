using System;


namespace Problema15._1
{
    public static class Helper
    {
        private static Random random = new Random();
        public static string GenerareCodUnic(string prefix)
        {
            int numberRandomN = random.Next(100, 999);
            int numberRandomY = random.Next(1000, 9999);
            return prefix + numberRandomN + numberRandomY;      
        }
    }
}
