namespace CaluculatorCollab.BLL.Implementations;

public class Calculator : ICalculator
{

    public async Task<int> AddAsync(int a, int b)
    {
        return a + b;

    }

    public async Task<int> DivideAsync(int number, int divisor)
    {
        throw new NotImplementedException();
    }

    public async Task<int> ExponentialAsync(int number, int power)
    {
        throw new NotImplementedException();
    }

    public async Task<int> ModuloAsync(int number, int mod)
    {
        throw new NotImplementedException();
    }

    public async Task<int> MultiplyAsync(int a, int b)
    {
        return a * b;

    }

    public async Task<int> SubtractAsync(int a, int b)
    {
        throw new NotImplementedException();
    }
}
