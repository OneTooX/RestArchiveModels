using System.ComponentModel.DataAnnotations;

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
        [Required]
        public string ContentType { get; set; }
        /// <summary>
        /// The contents of the document.
        /// </summary>
        [Required]
        public byte[] DocumentData { get; set; }
        /// <summary>
        /// The title of the document.
        /// </summary>
        [Required]
        public string Title { get; set; }
    }
}