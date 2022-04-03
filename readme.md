#Getting Started
1. BankGuarantee.Core
Library for the bian implementation of BankGuarantee for CBA. This **MUST not** depend on HTTP Context object and must not assume the response will be a HTTP Response
Actions - Entry point into the library - e.g. called from the Controller for the WebAPIHttpTrigger
Services - API references/clients to connect to downstream systems
Data - TODO: connection to the local mongodb data store

2. BankGuarantee.Tranport Projects
Thin wrappers to expose the BankGuarantee.Core to the transport layers - HTTP, Lambda, gRPC, etc. This helps achieves portability between cloud providers

3. .teamcity
Contains the Kotlin code for TeamCity build definition as code

#TODO
Code cleanup to align to c# naming standard & adding of attributes to preserve BIAN object casing

#References
BIAN Landscape 10.0, Bank Guarantee [Open API Spec](https://github.com/bian-official/public/blob/main/release10.0.0/semantic-apis/oas3/yamls/BankGuarantee.yaml)