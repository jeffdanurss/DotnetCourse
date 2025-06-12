
using System.Security.Cryptography.X509Certificates;

namespace Wpm.Management.Domain;

public record Weight
{
    public decimal Value { get; init; }
    public Weight(decimal value)
    {
        if (value < 0)
        {
            throw new ArgumentException("Peso no valido");

        }
        Value = value;
    }
    public static implicit operator Weight(decimal value)
    {
        return new Weight(value);
    }
}