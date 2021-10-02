# AspNetCore-Exercise

There are two service in this project named ServiceA and ServiceB.

ServiceA:
- Make a request to ServiceA
- The request has an API header named "X-API-KEY"
- The value of API header is "123"

ServiceB:
- Checks coming request if it has "X-API-KEY" header with value "123"
- if it has returns  MapSettings.
- else returns the  "API key is not valid."  message.

To test the projet first run ServiceB then run ServiceA.