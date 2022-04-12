namespace ApplicationLayer.Responses
{
    public class ActionResultResponse<T> : IBaseResponse<T> where T : class
    {
        public T Result { get; private set; }
        public IList<ResponseErrors> Errors { get; private set; }
        public ActionResultResponse(T result) : this()
        {
            Result = result;
        }
        public ActionResultResponse(ResponseErrors error) : this()
        {
            Errors = new List<ResponseErrors>() { error };
        }
        //public ActionResultResponse(IEnumerable<ResponseErrors> errors) : this()
        //{
        //    Errors = new List<ResponseErrors>(errors);
        //}
        public ActionResultResponse()
        {
            Errors = new List<ResponseErrors>();
        }
    }
}
