# SitecoreJobViewer

![Example](https://raw.githubusercontent.com/kristofferkjeldby/SitecoreJobViewer/main/readme.png)

## Introduction

SitecoreJobViewer is a standalone Windows Forms application that allow you to monitor pending, running and finished Sitecore Jobs. The Sitecore JobViewer uses the Sitecore Authoring and Management Graph API (available from version 10.3) to query jobs, and displays the result in a number of graphs.

## Getting Started

To get started, first you need to download or clone the solution and open it in Visual Studio. Make sure that you are able to start the application.

As the solution includes an icon in the Form.resx file, you will might get this error when running the solution for the first time:

`Couldn't process file Form.resx due to its being in the Internet or Restricted zone or having the mark of the web on the file. Remove the mark of the web if you want to process these files.`

To resolve the error, find the Form.resx file in File Explorer and right click it, select *Properties* and the select *Unblock* under *General*.

### Configuring Sitecore

Next, make sure that the The Authoring and Management API is enabled on the Sitecore instance you want to connect to. In a CM/CD this will be the CM server. The endpoint is enabled using this setting:

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

In Visual Studio, make sure that the following settings are correct in the `App.config` file:

```
<appSettings>
  <add key="Server" value="your-server" />
  <add key="IdentityServer" value="your-identity-server" />
  <add key="ClientId" value="SitecoreJobViewerClientId" />
  <add key="ClientSecret" value="my-secret-password" />
  <add key="MaxJobs" value="18" />
</appSettings>
```

The `Server` setting should be the URL of your Sitecore CM server (including `https://`), and the `IdentityServer` setting should be the URL (including `https://`) of your Sitecore Identity Server. The `ClientId` and `ClientSecret` settings should match the one configured in the Sitecore Identity Server configuration.

With these settings in place, you should be able to build and run SitecoreJobViewer, logging in using a Sitecore admin username and password and clicking *Attach*. 

Please note the the username and password are prefilled with "admin" and "b". This can be removed or changed in the file `Form.Designer.cs` line 215 and 230.

## Advanced settings

*Number of jobs*

If you run more than 18 jobs at the same time, you might need to adjust the MaxJobs settings in the `App.config` file. This will adjust the user interface to allow more simultaneous jobs to be displayed.

*Sample frequency and samples to keep*

By default, SitecoreJobViewer will query the Sitecore server once every 2000 ms and keep 100 samples, displaying a period of 200 seconds (a bit over 3 minutes). This can be adjusted using the two settings `SampleFrequency` and `SamplesToKeep` in the Constants.cs file.

*Job states*

Per default, SitecoreJobViewer will only display jobs with the states `RUNNING`, `FINISHED` and `QUEUED`. 

Sitecore has a few more job states that is ignored per default (`UNKNOWN`, `ABORTED`, `ABORTREQUESTED`, `INITIALIZING`). To display these, you need to add the job states to the `Colors` dictionary in the `Constants.cs` file, and select the colors with the user interface should use to display these job states.

## Bypassing the Sitecore Identity Server

If you do not wish to obtain access tokens via SitecoreJobViewer, it is possible to bypass the Sitecore Identity Server login by entering a valid access token in the Access token input field and click *Attach*.

## Read more

For an introduction to the job viewer, please read this blog: https://www.kjeldby.dk/2023/08/custom-sitecore-job-viewer/.

I have also recorded a video covering the same topic: https://www.kjeldby.dk/2023/08/custom-sitecore-job-viewer-video/.
