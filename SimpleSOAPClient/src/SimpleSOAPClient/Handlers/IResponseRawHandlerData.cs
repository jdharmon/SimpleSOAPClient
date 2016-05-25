﻿namespace SimpleSOAPClient.Handlers
{
    using System.Net.Http;

    /// <summary>
    /// Represents the raw response handler data.
    /// </summary>
    public interface IResponseRawHandlerData : IHandlerData
    {
        /// <summary>
        /// The current HTTP response message
        /// </summary>
        HttpResponseMessage Response { get; }

        /// <summary>
        /// The current string content that will be deserialized as a SOAP Envelope
        /// </summary>
        string Content { get; }
    }
}