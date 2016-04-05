
namespace Contracts
{
    public interface IStringMutatorV2
    {
        string ComponentDescription { get; }
        string MutateString(string s);
    }

}
