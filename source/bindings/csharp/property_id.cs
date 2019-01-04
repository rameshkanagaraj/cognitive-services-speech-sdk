//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE.md file in the project root for full license information.
//

namespace Microsoft.CognitiveServices.Speech
{
    /// <summary>
    /// Defines speech property ids.
    /// Changed in version 1.1.0.
    /// </summary>
    public enum PropertyId
    {
        /// <summary>
        /// The Cognitive Services Speech Service subscription key. If you are using an intent recognizer, you need
        /// to specify the LUIS endpoint key for your particular LUIS app. Under normal circumstances, you shouldn't
        /// have to use this property directly.
        /// Instead, use <see cref="SpeechConfig.FromSubscription"/>.
        /// </summary>
        SpeechServiceConnection_Key = Internal.PropertyId.SpeechServiceConnection_Key,

        /// <summary>
        /// The Cognitive Services Speech Service endpoint (url). Under normal circumstances, you shouldn't
        /// have to use this property directly.
        /// Instead, use <see cref="SpeechConfig.FromEndpoint"/>.
        /// NOTE: This endpoint is not the same as the endpoint used to obtain an access token.
        /// </summary>
        SpeechServiceConnection_Endpoint = Internal.PropertyId.SpeechServiceConnection_Endpoint,

        /// <summary>
        /// The Cognitive Services Speech Service region. Under normal circumstances, you shouldn't have to
        /// use this property directly.
        /// Instead, use <see cref="SpeechConfig.FromSubscription"/>, <see cref="SpeechConfig.FromEndpoint"/>,
        /// <see cref="SpeechConfig.FromAuthorizationToken"/>.
        /// </summary>
        SpeechServiceConnection_Region = Internal.PropertyId.SpeechServiceConnection_Region,

        /// <summary>
        /// The Cognitive Services Speech Service authorization token (aka access token). Under normal circumstances,
        /// you shouldn't have to use this property directly.
        /// Instead, use <see cref="SpeechConfig.FromAuthorizationToken"/>,
        /// <see cref="SpeechRecognizer.AuthorizationToken"/>, <see cref="Intent.IntentRecognizer.AuthorizationToken"/>, <see cref="Translation.TranslationRecognizer.AuthorizationToken"/>.
        /// </summary>
        SpeechServiceAuthorization_Token = Internal.PropertyId.SpeechServiceAuthorization_Token,

        /// <summary>
        /// The Cognitive Services Speech Service authorization type. Currently unused.
        /// </summary>
        SpeechServiceAuthorization_Type = Internal.PropertyId.SpeechServiceAuthorization_Type,

        /// <summary>
        /// The Cognitive Services Custom Speech Service endpoint id. Under normal circumstances, you shouldn't
        /// have to use this property directly.
        /// Instead use <see cref="SpeechConfig.FromEndpoint"/>.
        /// NOTE: The endpoint id is available in the Custom Speech Portal, listed under Endpoint Details.
        /// </summary>
        SpeechServiceConnection_EndpointId = Internal.PropertyId.SpeechServiceConnection_EndpointId,

        /// <summary>
        /// The host name of the proxy server used to connect to the Cognitive Services Speech Service. Under normal circumstances,
        /// you shouldn't have to use this property directly.
        /// Instead use <see cref="SpeechConfig.SetProxy"/>.
        /// NOTE: This property id was added in version 1.1.0.
        /// </summary>
        SpeechServiceConnection_ProxyHostName = Internal.PropertyId.SpeechServiceConnection_ProxyHostName,

        /// <summary>
        /// The port of the proxy server used to connect to the Cognitive Services Speech Service. Under normal circumstances,
        /// you shouldn't have to use this property directly.
        /// Instead use <see cref="SpeechConfig.SetProxy"/>.
        /// NOTE: This property id was added in version 1.1.0.
        /// </summary>
        SpeechServiceConnection_ProxyPort  = Internal.PropertyId.SpeechServiceConnection_ProxyPort,

        /// <summary>
        /// The user name of the proxy server used to connect to the Cognitive Services Speech Service. Under normal circumstances,
        /// you shouldn't have to use this property directly.
        /// Instead use <see cref="SpeechConfig.SetProxy"/>.
        /// NOTE: This property id was added in version 1.1.0.
        /// </summary>
        SpeechServiceConnection_ProxyUserName  = Internal.PropertyId.SpeechServiceConnection_ProxyUserName,

        /// <summary>
        /// The password of the proxy server used to connect to the Cognitive Services Speech Service. Under normal circumstances,
        /// you shouldn't have to use this property directly.
        /// Instead use <see cref="SpeechConfig.SetProxy"/>.
        /// NOTE: This property id was added in version 1.1.0.
        /// </summary>
        SpeechServiceConnection_ProxyPassword = Internal.PropertyId.SpeechServiceConnection_ProxyPassword,

        /// <summary>
        /// The list of comma separated languages (in BCP-47 format) used as target translation languages. Under normal circumstances,
        /// you shouldn't have to use this property directly.
        /// Instead, use <see cref="SpeechTranslationConfig.AddTargetLanguage"/> and the read-only <see cref="SpeechTranslationConfig.TargetLanguages"/> collection.
        /// </summary>
        SpeechServiceConnection_TranslationToLanguages = Internal.PropertyId.SpeechServiceConnection_TranslationToLanguages,

        /// <summary>
        /// The name of the Cognitive Service Text to Speech Service voice. Under normal circumstances, you shouldn't have to use this
        /// property directly. Instead use <see cref="SpeechTranslationConfig.VoiceName"/>.
        /// NOTE: Valid voice names can be found <a href="https://aka.ms/csspeech/voicenames">here</a>.
        /// </summary>
        SpeechServiceConnection_TranslationVoice = Internal.PropertyId.SpeechServiceConnection_TranslationVoice,

        /// <summary>
        /// Translation features. For internal use.
        /// </summary>
        SpeechServiceConnection_TranslationFeatures = Internal.PropertyId.SpeechServiceConnection_TranslationFeatures,

        /// <summary>
        /// The Language Understanding Service Region. Under normal circumstances, you shouldn't have to use this property directly.
        /// Instead use <see cref="Intent.LanguageUnderstandingModel"/>.
        /// </summary>
        SpeechServiceConnection_IntentRegion = Internal.PropertyId.SpeechServiceConnection_IntentRegion,

        /// <summary>
        /// The Cognitive Services Speech Service recognition mode. Can be "INTERACTIVE", "CONVERSATION", "DICTATION".
        /// This property is intended to be read-only. The SDK is using it internally.
        /// </summary>
        SpeechServiceConnection_RecoMode = Internal.PropertyId.SpeechServiceConnection_RecoMode,

        /// <summary>
        /// The spoken language to be recognized (in BCP-47 format). Under normal circumstances, you shouldn't have to use this property directly.
        /// Instead, use <see cref="SpeechConfig.SpeechRecognitionLanguage"/>.
        /// </summary>
        SpeechServiceConnection_RecoLanguage = Internal.PropertyId.SpeechServiceConnection_RecoLanguage,

        /// <summary>
        /// The session id. This id is a universally unique identifier (aka UUID) representing a specific binding of an audio input stream
        /// and the underlying speech recognition instance to which it is bound. Under normal circumstances,
        /// you shouldn't have to use this property directly.
        /// Instead use <see cref="SessionEventArgs.SessionId"/>.
        /// </summary>
        Speech_SessionId = Internal.PropertyId.Speech_SessionId,

        /// <summary>
        /// The requested Cognitive Services Speech Service response output format (simple or detailed). Under normal circumstances, you shouldn't have
        /// to use this property directly.
        /// Instead, use <see cref="SpeechConfig.OutputFormat"/>.
        /// </summary>
        SpeechServiceResponse_RequestDetailedResultTrueFalse = Internal.PropertyId.SpeechServiceResponse_RequestDetailedResultTrueFalse,

        /// <summary>
        /// The requested Cognitive Services Speech Service response output profanity level. Currently unused.
        /// </summary>
        SpeechServiceResponse_RequestProfanityFilterTrueFalse = Internal.PropertyId.SpeechServiceResponse_RequestProfanityFilterTrueFalse,

        /// <summary>
        /// The Cognitive Services Speech Service response output (in JSON format). This property is available on
        /// recognition result objects only.
        /// </summary>
        SpeechServiceResponse_JsonResult = Internal.PropertyId.SpeechServiceResponse_JsonResult,

        /// <summary>
        /// The Cognitive Services Speech Service error details (in JSON format). Under normal circumstances, you shouldn't have to
        /// use this property directly. Instead use <see cref="CancellationDetails.ErrorDetails"/>.
        /// </summary>
        SpeechServiceResponse_JsonErrorDetails = Internal.PropertyId.SpeechServiceResponse_JsonErrorDetails,

        /// <summary>
        /// The cancellation reason. Currently unused.
        /// </summary>
        CancellationDetails_Reason = Internal.PropertyId.CancellationDetails_Reason,

        /// <summary>
        /// The cancellation text. Currently unused.
        /// </summary>
        CancellationDetails_ReasonText = Internal.PropertyId.CancellationDetails_ReasonText,

        /// <summary>
        /// The cancellation detailed text. Currently unused.
        /// </summary>
        CancellationDetails_ReasonDetailedText = Internal.PropertyId.CancellationDetails_ReasonDetailedText,

        /// <summary>
        /// The Language Understanding Service response output (in JSON format). Available via <see cref="RecognitionResult.Properties"/>.
        /// </summary>
        LanguageUnderstandingServiceResponse_JsonResult = Internal.PropertyId.LanguageUnderstandingServiceResponse_JsonResult,
    }
}