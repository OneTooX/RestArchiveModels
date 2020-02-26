using System;
using System.Collections.Generic;

namespace OneTooX.RestPush.Model
{
    /// <summary>
    /// The status of the job.
    /// <table>
    /// <tr>
    /// <td>0</td>
    /// <td>Waiting to get delivered to one or more channels.</td>
    /// </tr>
    /// <tr>
    /// <td>1</td>
    /// <td>Delivered to all channels.</td>
    /// </tr>
    /// <tr>
    /// <td>3</td>
    /// <td>The job has been cancelled and will not be delivered.</td>
    /// </tr>
    /// <tr>
    /// <td>99</td>
    /// <td>A fatal error has occurred and the job will not be delivered.</td>
    /// </tr>
    /// <tr>
    /// <td>11</td>
    /// <td>Delivery was not possible and this was acceptable for the channel.</td>
    /// </tr>
    /// </table>
    ///</summary>
    public enum JobStatus
    {
        Waiting = 0,
        Delivered = 1,
        Deleted = 3,
        Error = 99,
        Nodelivery = 11
    }
    /// <summary>
    /// The main channel of the job.
    /// <table>
    /// <tr>
    /// <td>1</td>
    /// <td>e-Boks.</td>
    /// </tr>
    /// <tr>
    /// <td>2</td>
    /// <td>Remote print.</td>
    /// </tr>
    /// <tr>
    /// <td>3</td>
    /// <td>Addendum.</td>
    /// </tr>
    /// <tr>
    /// <td>5</td>
    /// <td>Digital Post.</td>
    /// </tr>
    /// <tr>
    /// <td>7</td>
    /// <td>Local Print.</td>
    /// </tr>
    /// <tr>
    /// <td>8</td>
    /// <td>Archive.</td>
    /// </tr>
    /// <tr>
    /// <td>9</td>
    /// <td>Email.</td>
    /// </tr>
    /// <tr>
    /// <td>10</td>
    /// <td>e-Boks Ekspres.</td>
    /// </tr>
    /// </table>
    ///</summary>
    public enum Channel
    {
        Eboks = 1,
        RemotePrint = 2,
        Addendum = 3,
        DigitalPost = 5,
        LocalPrint = 7,
        Archive = 8,
        Email = 9,
        EboksExpress = 10,
    }
    /// <summary>
    /// The delivery resolution of the channel. The value is Accepted if delivery is mandatory.
    /// <table>
    /// <tr>
    /// <td>0</td>
    /// <td>Accepted.</td>
    /// </tr>
    /// <tr>
    /// <td>1</td>
    /// <td>Not delivered due to no receiver.</td>
    /// </tr>
    /// <tr>
    /// <td>2</td>
    /// <td>Not delivered due to invalid receiver format.</td>
    /// </tr>
    /// <tr>
    /// <td>3</td>
    /// <td>Not delivered due to receiver not being registered in the receiving system.</td>
    /// </tr>
    /// </table>
    /// </summary>
    public enum ChannelResolution
    {
        Accepted = 0,
        NoReceiver = 1,
        InvalidReceiverFormat = 2,
        ReceiverNotRegistered = 3
    }
    /// <summary>
    /// The mail priority of the job.
    /// <table>
    /// <tr>
    /// <td>1</td>
    /// <td>Priority.</td>
    /// </tr>
    /// <tr>
    /// <td>2</td>
    /// <td>Economy.</td>
    /// </tr>
    /// </table>
    /// </summary>
    public enum MailPriority
    {
        A = 1,
        B = 2
    }
    /// <summary>
    /// The type of receiver of the job.
    /// <table>
    /// <tr>
    /// <td>0</td>
    /// <td>No receiver.</td>
    /// </tr>
    /// <tr>
    /// <td>1</td>
    /// <td>Person.</td>
    /// </tr>
    /// <tr>
    /// <td>2</td>
    /// <td>Company.</td>
    /// </tr>
    /// <tr>
    /// <td>3</td>
    /// <td>Email.</td>
    /// </tr>
    /// </table>
    /// </summary>
    public enum ReceiverType
    {
        None = 0,
        Person = 1,
        Company = 2,
        Email = 3
    }
    /// <summary>
    /// The message containing the job metadata, document and addendums.
    /// </summary>
    public class ArchiveMessage
    {
        /// <summary>
        /// The ID of the delivery job.
        /// </summary>
        public int JobId { get; set; }
        /// <summary>
        /// The ID of the parent job, if any. Used for mail merges. The value is 0 if there is no parent.
        /// </summary>
        public int ParentJobId { get; set; }
        /// <summary>
        /// The time of creation of the job.
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// The ID of the customer that the user belongs to.
        /// </summary>
        public string CustomerId { get; set; }
        /// <summary>
        /// The name of the division that the user belongs to.
        /// </summary>
        public string Division { get; set; }
        /// <summary>
        /// The ID of the user that sent the job.
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// The main document.
        /// </summary>
        public Document MainDocument { get; set; }
        /// <summary>
        /// The list of addendums, if any.
        /// </summary>
        public List<Document> Addendums { get; set; }
        /// <summary>
        /// The name of the fixed addendum, if any.
        /// </summary>
        public string FixedAddendumName { get; set; }
        /// <summary>
        /// The case ID used for archiving, if any.
        /// </summary>
        public string ArchiveCaseId { get; set; }
        /// <summary>
        /// The category for archiving.
        /// </summary>
        public string ArchiveCategory { get; set; }
        /// <summary>
        /// The description for archiving, if any.
        /// </summary>
        public string ArchiveDescription { get; set; }
        /// <summary>
        /// The status of the job.
        /// </summary>
        public JobStatus Status { get; set; }
        /// <summary>
        /// The main channel of the job.
        /// </summary>
        public Channel Channel { get; set; }
        /// <summary>
        /// The resolution of the main channel of the job.
        /// </summary>
        public ChannelResolution ChannelResolution { get; set; }
        /// <summary>
        /// The IP address of the client delivering the job.
        /// </summary>
        public string ClientAddress { get; set; }
        /// <summary>
        /// Information on the client delivering the job. For non-webservice delivery this is the user agent of the client browser.
        /// </summary>
        public string ClientInfo { get; set; }
        /// <summary>
        /// The version of the client. For non-webservice delivery this is the version of the OneTooX server.
        /// </summary>
        public string ClientVersion { get; set; }
        /// <summary>
        /// Determines if color was used for remote printing.
        /// </summary>
        public bool IsColorPrint { get; set; }
        /// <summary>
        /// The ID of the receiver, e.g. a civil registration no. or a CBR no.
        /// </summary>
        public string Receiver { get; set; }
        /// <summary>
        /// The type of the receiver.
        /// </summary>
        public ReceiverType ReceiverType { get; set; }
        /// <summary>
        /// The AttentionInfo, if any.
        /// </summary>
        public AttentionInfo AttentionInfo { get; set; }
        /// <summary>
        /// The customer-specified text, if any.
        /// </summary>
        public string CustomerText { get; set; }
        /// <summary>
        /// ISO code of the destination country for digital delivery. Currently only DK is supported.
        /// </summary>
        public string DigitalDestinationCountry { get; set; }
        /// <summary>
        /// The receipt from Digital Post, if this is the main channel.
        /// </summary>
        public string DigitalPostReceipt { get; set; }
        /// <summary>
        /// The document type used for creating the job.
        /// </summary>
        public string DocumentType { get; set; }
        /// <summary>
        /// The Digital Post response address that the receiver can reply to if supplied.
        /// </summary>
        public string DigitalPostResponse { get; set; }
        /// <summary>
        /// The subject belonging to the Digital Post response address.
        /// </summary>
        public string DigitalPostResponseSubject { get; set; }
        /// <summary>
        /// The Digital Post material ID, if Digital Post is the main channel.
        /// </summary>
        public string MaterialId { get; set; }
        /// <summary>
        /// The title of the job.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Determines if the job is archived.
        /// </summary>
        public bool IsArchived { get; set; }
        /// <summary>
        /// Determines if the document is printed in duplex, if sent to remote print or local print.
        /// </summary>
        public bool IsDuplex { get; set; }
        /// <summary>
        /// The mail priority, if sent to remote print.
        /// </summary>
        public MailPriority MailPriority { get; set; }
        /// <summary>
        /// The total number of pages in the main document and addendums.
        /// </summary>
        public int TotalNumberOfPages { get; set; }
        /// <summary>
        /// The total number of sheets in the main document and addendums.
        /// </summary>
        public int TotalNumberOfSheets { get; set; }
        /// <summary>
        /// The total size in bytes of the main document and addendums.
        /// </summary>
        public int TotalSize { get; set; }
        /// <summary>
        /// The output system that was used to deliver the delivery.
        /// </summary>
        public string OutputSystem { get; set; }
        /// <summary>
        /// ISO code of the destination country for postal delivery.
        /// </summary>
        public string PostalDestinationCountry { get; set; }
        /// <summary>
        /// The name of the system that sent the document
        /// </summary>
        public string SendingSystem { get; set; }
    }
}