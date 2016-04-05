
namespace Contracts
{
    public interface IStringMutatorV1
    {
        string ComponentDescription { get; }
        string MutateString(string s);
    }

}
