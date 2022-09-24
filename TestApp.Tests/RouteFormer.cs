using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Tests
{
    public static class RouteFormer
    {
        public static string FormRoute(List<Path> citiesPairs)
        {
            var output = new List<string>();

            for (int i = citiesPairs.Count - 1; i >= 0; i--)
            {
                if (!output.Contains(citiesPairs[i].From))
                    output.Add(citiesPairs[i].From);

                if (!output.Contains(citiesPairs[i].To))
                    output.Add(citiesPairs[i].To);
            }

            return String.Join(" ", output.ToArray());
        }
    }
}
