namespace OneTooX.RestPush.Model
{
    /// <summary>
    /// AttentionInfo contains data related to the Digital Post AttentionFormat - see https://digst.dk/media/16810/vejledning-i-anvendelse-af-attentionformatet.pdf.
    /// </summary>
    public class AttentionInfo
    {
        public string PNummer { get; set; }
        public string Email { get; set; }
        public string PersonNavn { get; set; }
        public string EnhedsNavn { get; set; }
        public string PrimaerKlasse { get; set; }
        public string SekundaerKlasse { get; set; }
    }
}