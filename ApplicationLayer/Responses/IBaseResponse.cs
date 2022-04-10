namespace ApplicationLayer.Responses
{
    public interface IBaseResponse<T> where T : class
    {
        public T Result { get; }
        public IList<ResponseErrors> Errors { get; }
    }
}
