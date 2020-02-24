using System;
using System.Collections.Generic;

namespace OneTooX.RestPush.Model
{
    /// <summary>
    /// The status of the job.
    /// <dl>
    /// <li>
    /// <dt>0</dt>
    /// <dd>Waiting to get delivered to one or more channels.</dd>
    /// </li>
    /// <li>
    /// <dt>1</dt>
    /// <dd>Delivered to all channels.</dd>
    /// </li>
    /// <li>
    /// <dt>3</dt>
    /// <dd>The job has been cancelled and will not be delivered.</dd>
    /// </li>
    /// <li>
    /// <dt>99</dt>
    /// <dd>A fatal error has occurred and the job will not be delivered.</dd>
    /// </li>
    /// <li>
    /// <dt>11</dt>
    /// <dd>Delivery was not possible and this was acceptable for the channel.</dd>
    /// </li>
    /// </dl>
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
    /// <dl>
    /// <li>
    /// <dt>1</dt>
    /// <dd>e-Boks.</dd>
    /// </li>
    /// <li>
    /// <dt>2</dt>
    /// <dd>Remote print.</dd>
    /// </li>
    /// <li>
    /// <dt>3</dt>
    /// <dd>Addendum.</dd>
    /// </li>
    /// <li>
    /// <dt>5</dt>
    /// <dd>Digital Post.</dd>
    /// </li>
    /// <li>
    /// <dt>7</dt>
    /// <dd>Local Print.</dd>
    /// </li>
    /// <li>
    /// <dt>8</dt>
    /// <dd>Archive.</dd>
    /// </li>
    /// <li>
    /// <dt>9</dt>
    /// <dd>Email.</dd>
    /// </li>
    /// <li>
    /// <dt>10</dt>
    /// <dd>e-Boks Ekspres.</dd>
    /// </li>
    /// </dl>
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
    /// <dl>
    /// <li>
    /// <dt>0</dt>
    /// <dd>Accepted.</dd>
    /// </li>
    /// <li>
    /// <dt>1</dt>
    /// <dd>Not delivered due to no receiver.</dd>
    /// </li>
    /// <li>
    /// <dt>2</dt>
    /// <dd>Not delivered due to invalid receiver format.</dd>
    /// </li>
    /// <li>
    /// <dt>3</dt>
    /// <dd>Not delivered due to receiver not being registered in the receiving system.</dd>
    /// </li>
    /// </dl>
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
    /// <dl>
    /// <li>
    /// <dt>1</dt>
    /// <dd>Priority.</dd>
    /// </li>
    /// <li>
    /// <dt>2</dt>
    /// <dd>Economy.</dd>
    /// </li>
    /// </dl>
    /// </summary>
    public enum MailPriority
    {
        A = 1,
        B = 2
    }
    /// <summary>
    /// The type of receiver of the job.
    /// <dl>
    /// <li>
    /// <dt>0</dt>
    /// <dd>No receiver.</dd>
    /// </li>
    /// <li>
    /// <dt>1</dt>
    /// <dd>Person.</dd>
    /// </li>
    /// <li>
    /// <dt>2</dt>
    /// <dd>Company.</dd>
    /// </li>
    /// <li>
    /// <dt>3</dt>
    /// <dd>Email.</dd>
    /// </li>
    /// </dl>
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
        /// The ID of the parent job, if any. Used for mail merges. Zero if there is no parent.
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