namespace WebApp.Model
{
    public class ServiceResult<T> where T : class
    {
        // public string result { get; set; }

        public T[] data { get; set; }

    }
}
