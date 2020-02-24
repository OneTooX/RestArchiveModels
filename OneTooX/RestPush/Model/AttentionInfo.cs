namespace OneTooX.RestPush.Model
{
    /// <summary>
    /// AttentionInfo contains data related to the Digital Post AttentionFormat - see https://digst.dk/media/16810/vejledning-i-anvendelse-af-attentionformatet.pdf.
    /// </summary>
    public class AttentionInfo
    {
        /// <summary>
        /// The P-nummer of the receiver.
        /// </summary>
        public string PNummer { get; set; }
        /// <summary>
        /// The e-mail of the receiver.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// The name of the receiver.
        /// </summary>
        public string PersonNavn { get; set; }
        /// <summary>
        /// The OU of the receiver.
        /// </summary>
        public string EnhedsNavn { get; set; }
        /// <summary>
        /// FORM code (public classification).
        /// </summary>
        public string PrimaerKlasse { get; set; }
        /// <summary>
        /// KLE code or similar (public classification).
        /// </summary>
        public string SekundaerKlasse { get; set; }
    }
}