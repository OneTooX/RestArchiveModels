namespace OneTooX.RestPush.Model
{
    /// <summary>
    /// A Document represents the main document of a job or an addendum.
    /// </summary>
    public class Document
    {
        /// <summary>
        /// The content type of the document. Currently only application/pdf is supported. 
        /// </summary>
        public string ContentType { get; set; }
        /// <summary>
        /// The contents of the document.
        /// </summary>
        public byte[] DocumentData { get; set; }
        /// <summary>
        /// The title of the document.
        /// </summary>
        public string Title { get; set; }
    }
}