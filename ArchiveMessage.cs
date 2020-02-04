using System;
using System.Collections.Generic;

namespace OneTooX.RestPush.Model
{
    public enum JobStatus
    {
        Waiting = 0,
        Delivered = 1,
        Deleted = 3,
        Error = 99,
        Nodelivery = 11
    }
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
        NoDelivery = 11
    }
    public enum ChannelResolution
    {
        Accepted = 0,
        NoReceiver = 1,
        InvalidReceiverFormat = 2,
        ReceiverNotRegistered = 3
    }

    public enum MailPriority
    {
        A = 1,
        B = 2
    }

    public enum ReceiverType
    {
        None = 0,
        Person = 1,
        Company = 2,
        Email = 3
    }

    public class ArchiveMessage
    {
        public int JobId { get; set; }
        public int ParentJobId { get; set; }
        public DateTime CreateTime { get; set; }
        public string CustomerId { get; set; }
        public string Division { get; set; }
        public string UserId { get; set; }
        public Document MainDocument { get; set; }
        public List<Document> Addendums { get; set; }
        public string FixedAddendumName { get; set; }
        public string ArchiveCaseId { get; set; }
        public string ArchiveCategory { get; set; }
        public string ArchiveDescription { get; set; }
        public JobStatus Status { get; set; }
        public Channel Channel { get; set; }
        public ChannelResolution ChannelResolution { get; set; }
        public string ClientAddress { get; set; }
        public string ClientInfo { get; set; }
        public string ClientVersion { get; set; }
        public bool IsColorPrint { get; set; }
        public string Receiver { get; set; }
        public ReceiverType ReceiverType { get; set; }
        public AttentionInfo AttentionInfo { get; set; }
        public string CustomerText { get; set; }
        public string DigitalDestinationCountry { get; set; }
        public string DigitalPostReceipt { get; set; }
        public string DocumentType { get; set; }
        public string DigitalPostResponse { get; set; }
        public string DigitalPostResponseSubject { get; set; }
        public string MaterialId { get; set; }
        public string Title { get; set; }
        public bool IsArchived { get; set; }
        public bool IsDuplex { get; set; }
        public MailPriority MailPriority { get; set; }
        public int TotalNumberOfPages { get; set; }
        public int TotalNumberOfSheets { get; set; }
        public int TotalSize { get; set; }
        public string OutputSystem { get; set; }
        public string PostalDestinationCountry { get; set; }
        public string SendingSystem { get; set; }
    }
}