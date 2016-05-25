namespace SimpleSOAPClient.Handlers
{
    using System.Net.Http;

    /// <summary>
    /// Represents the raw request handler data.
    /// </summary>
    public interface IRequestRawHandlerData : IHandlerData
    {
        /// <summary>
        /// The current HTTP request message
        /// </summary>
        HttpRequestMessage Request { get; }

        /// <summary>
        /// The current string content that will be included in the <see cref="Request"/>
        /// </summary>
        string Content { get; }
    }
}