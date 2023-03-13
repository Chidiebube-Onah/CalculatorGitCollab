
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaluculatorCollab.BLL.Interfaces
{
   public interface ICalculator
    {
        Task<int> AddAsync(int a, int b);
        Task<int> SubtractAsync( int a, int b);
        Task<int> MultiplyAsync(int a, int b);
        Task<int> DivideAsync(int number, int divisor);
        Task<int> ModuloAsync(int number, int mod);
        Task<int> ExponentialAsync(int number, int power);
    }
}
