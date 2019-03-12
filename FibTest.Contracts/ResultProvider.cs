namespace CodeTest.Contracts
{
    public abstract class ResultProvider<TInput,TResult>
    {
        public abstract string Name { get; }

        protected abstract TResult DoGetResult(TInput input);

        public TResult GetResult(TInput input)
        {
            return DoGetResult(input);
        }
    }
}
