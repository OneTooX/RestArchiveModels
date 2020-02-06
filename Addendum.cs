namespace OneTooX.RestPush.Model
{
    /// <summary>
    /// A Document represents the main document of a job or an addendum.
    /// </summary>
    public class Document
    {
        public string ContentType { get; set; }
        public byte[] DocumentData { get; set; }
        public string Title { get; set; }
    }
}