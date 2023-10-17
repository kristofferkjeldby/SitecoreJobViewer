# SitecoreJobViewer

![Example](https://raw.githubusercontent.com/kristofferkjeldby/SitecoreJobViewer/main/readme.png)

## Introduction

SitecoreJobViewer is a standalone Windows Forms application that allow you to monitor pending, running and finished Sitecore Jobs. The Sitecore JobViewer uses the Sitecore Authoring and Management Graph API (available from version 10.3) to query jobs, and displays the result in a number of graphs.

## Getting Started

To get started, first you need to download or clone the solution and open it in Visual Studio. 

### Configuring Sitecore

Next, make sure that the The Authoring and Management API is enabled on the Sitecore instance you want to connect to. In a CM/CD this will most likely be the CM server. The endpoint is enabled using this setting:

```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <sitecore>
    <settings>
      <setting name="GraphQL.Enabled" value="true"/>
  </sitecore>
</configuration>
```
### Configuring Sitecore Identity Server

As the SitecoreJobViewer will need to obtain access tokens from the Sitecore Identity Server, it will need a client configuration. This can be setup by creating a file called `Sitecore.IdentityServer.JobViewer.xml` in within the Sitecore Identity Server's `Config` folder with the following settings:

```
<?xml version="1.0" encoding="utf-8" ?>
<Settings>
  <Sitecore>
    <IdentityServer>
      <Clients>
        <JobViewerClient>
          <ClientId>SitecoreJobViewerClientId</ClientId>
          <ClientName>SitecoreJobViewerClient</ClientName>
          <AccessTokenType>0</AccessTokenType>
          <AllowOfflineAccess>true</AllowOfflineAccess>
          <AlwaysIncludeUserClaimsInIdToken>false</AlwaysIncludeUserClaimsInIdToken>
          <AccessTokenLifetimeInSeconds>3600</AccessTokenLifetimeInSeconds>
          <IdentityTokenLifetimeInSeconds>3600</IdentityTokenLifetimeInSeconds>
          <AllowAccessTokensViaBrowser>true</AllowAccessTokensViaBrowser>
          <RequireConsent>false</RequireConsent>
          <RequireClientSecret>true</RequireClientSecret>
          <AllowedGrantTypes>
            <AllowedGrantType1>password</AllowedGrantType1>
          </AllowedGrantTypes>
          <AllowedCorsOrigins>
          </AllowedCorsOrigins>
          <AllowedScopes>
            <AllowedScope1>openid</AllowedScope1>
            <AllowedScope2>sitecore.profile</AllowedScope2>
            <AllowedScope3>sitecore.profile.api</AllowedScope3>
          </AllowedScopes>
          <ClientSecrets>
            <ClientSecret1>my-secret-password</ClientSecret1>
          </ClientSecrets>
          <UpdateAccessTokenClaimsOnRefresh>true</UpdateAccessTokenClaimsOnRefresh>
        </JobViewerClient>
      </Clients>
    </IdentityServer>
  </Sitecore>
</Settings>
```

### Configuring SitecoreJobViewer

In Visual Studio, make sure that the following settings are correct:

<appSettings>
  <add key="Server" value="your-server" />
  <add key="IdentityServer" value="your-identity-server" />
  <add key="ClientId" value="SitecoreJobViewerClientId" />
  <add key="ClientSecret" value="my-secret-password" />
  <add key="MaxJobs" value="18" />
</appSettings>

The `Server` should be the URL of your Sitecore CM server, and the IdentityServer should be the URL of your Sitecore Identity Server. The ClientId and ClientSecret should match the one configured in the Sitecore Identity Server configuration

With these settings in place, you should be able to build and run SitecoreJobViewer, logging in using a Sitecore admin username and password.

## Read more

For an introduction to the job viewer, please read this blog: https://www.kjeldby.dk/2023/08/custom-sitecore-job-viewer/
