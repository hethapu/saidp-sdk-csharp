﻿using SecureAuth.Sdk.Responses;

namespace SecureAuth.Sdk
{
    public interface IDeviceFingerprintService
    {
        DfpJavascriptLinkResponse GetDfpJavascriptLink();
        DfpResponse ValidateDfp(ValidateDfpRequest request);
        DfpResponse ConfirmDfp(ConfirmDfpRequest request);
    }
}
