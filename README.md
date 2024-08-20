# Net-Auth


Recently it dawned upon my that I could use a bit more practice on Authentication types. This here will be a repo where I will be posting my examples and potentially diagrams of Auth protocols like OAuth2, SAML, etc.

### Identity Server

1. PersistedGrantDbContext: 
-  is responsible for storing data related to persisted grants, which include tokens, authorization codes, user consent, and other operational data related to the OAuth2 and OpenID Connect flows.

2. ConfigurationDbContext: 
-  is responsible for storing the configuration data of IdentityServer. This includes details about clients, resources, identity resources, and API resources that are configured within IdentityServer.

