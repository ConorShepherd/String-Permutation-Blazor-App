namespace StringPermutation.Data
{
    public interface IStringPermutationService
    {
        public string Description { get; }
        public bool HasValidPermutation(string s);
    }
}