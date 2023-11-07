![Icon](https://raw.github.com/silentpartnersoftware/Keycloak.Net/01f1654e44065409726b417e26b2dfc913e03c7f/docs/icon.png)
# Keycloak.Net.Core
[![license](https://img.shields.io/github/license/AnderssonPeter/Keycloak.Net.svg?maxAge=2592000)](https://github.com/AnderssonPeter/Keycloak.Net/blob/master/LICENSE) [![NuGet](https://img.shields.io/nuget/v/Keycloak.Net.Core?maxAge=2592000)](https://www.nuget.org/packages/Keycloak.Net.Core/) [![downloads](https://img.shields.io/nuget/dt/Keycloak.Net.Core)](https://www.nuget.org/packages/Keycloak.Net.Core/)

 A Fork of https://github.com/lvermeulen/Keycloak.Net with some additional patches
 * allow usage of CancellationTokens
 * changed ClientConfig to Dictionary<string, string>
 * removed signing
 * .net 6 support only
 * updated for keycloak version 17+
 * added support for changing default `AdminClientId` which has default `admin-cli` value

 To use different AdminClientId, use newly introduced KeyCloakOptions:
  ```cs
 new KeycloakClient(
    "http://keycloak.url",
    "adminUserName",
    "adminPassword",
    new KeycloakOptions(adminClientId:"admin"
    )
);
 ```

 ## Older version support for using /auth path
 When creating a new KeycloakClient, use newly introduced KeycloakOptions:
 ```cs
 new KeycloakClient(
    "http://keycloak.url",
    "adminUserName",
    "adminPassword",
    new KeycloakOptions(prefix:"auth"
    )
);
 ```

C# client for [Keycloak](https://www.keycloak.org/) 6.x

See documentation at [https://www.keycloak.org/docs-api/6.0/rest-api/](https://www.keycloak.org/docs-api/6.0/rest-api/)

## Features
* [X] Attack Detection
* [X] Authentication Management
* [X] Client Attribute Certificate
* [X] Client Initial Access
* [X] Client Registration Policy
* [X] Client Role Mappings
* [X] Client Scopes
* [X] Clients
* [X] Component
* [X] Groups
* [X] Identity Providers
* [X] Key
* [X] Protocol Mappers
* [X] Realms Admin
* [X] Role Mapper
* [X] Roles
* [X] Roles (by ID)
* [X] Scope Mappings
* [X] User Storage Provider
* [X] Users
* [X] Root

