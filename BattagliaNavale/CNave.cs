using System;
using System.Collections.Generic;

namespace BattagliaNavale
{
    internal class CNave
    {
        private List<(int x, int y)> locazione = new List<(int x, int y)>();

        public List<(int x, int y)> Locazione => locazione;

        public CNave((int x, int y) c1, (int x, int y) c2)
        {
            // Se la nave è orizzontale
            if (c1.y == c2.y)
            {
                int xStart = Math.Min(c1.x, c2.x);
                int xEnd = Math.Max(c1.x, c2.x);

                for (int x = xStart; x <= xEnd; x++)
                    locazione.Add((x, c1.y));
            }
            // Se la nave è verticale
            else if (c1.x == c2.x)
            {
                int yStart = Math.Min(c1.y, c2.y);
                int yEnd = Math.Max(c1.y, c2.y);

                for (int y = yStart; y <= yEnd; y++)
                    locazione.Add((c1.x, y));
            }
            else
            {
                throw new Exception("La nave deve essere orizzontale o verticale!");
            }
        }
    }
}
