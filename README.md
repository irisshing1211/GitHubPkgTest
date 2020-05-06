# GitHubPkgTest
A repo to try out how to pack some package to github package
## Preparation
1. go to your github
2. Setting -> Developer settings -> Personal access tokens -> click **Generate new token**
3. Type the **Note** and tick **write:packages**, **read:packages** and **delete:packages**. The **repo** will select automatically.
4. Then click **Generate token**

Ref:
- [About GitHub Packages](https://help.github.com/en/packages/publishing-and-managing-packages/about-github-packages)
- [Creating a personal access token for the command line](https://help.github.com/en/github/authenticating-to-github/creating-a-personal-access-token-for-the-command-line)

## Pack your package
1. create your class
2. Open your project file (.csproj) and add the following minimal properties inside the existing <PropertyGroup> tag, changing the values as appropriate:
    ``` xml
   <PackageId>AppLogger</PackageId>
   <Version>1.0.0</Version>
   <Authors>your_name</Authors>
   <Company>your_company</Company> 
    ```
3. `dotnet pack --configuration Release` to package the project 
4. check out `\bin\Release`, a `PackageId.version.nupkg` file should be generated.

Ref:
- [Quickstart: Create and publish a package (dotnet CLI)](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-the-dotnet-cli)
## Publish your package
1. create a `nuget.config` in the project
    ``` xml
    <?xml version="1.0" encoding="utf-8"?>
    <configuration>
        <packageSources>
            <clear />
            <add key="github" value="https://nuget.pkg.github.com/name of the user or organization account/index.json" />
        </packageSources>
        <packageSourceCredentials>
            <github>
                <add key="Username" value="name of your user account on GitHub" />
                <add key="ClearTextPassword" value="your personal access token" />
            </github>
        </packageSourceCredentials>
    </configuration>
   ```

2. `dotnet nuget push "bin/Release/PackageId.version.nupkg" --source "github"` to publish your package to github

Ref:
- [Configuring dotnet CLI for use with GitHub Packages](https://help.github.com/en/packages/using-github-packages-with-your-projects-ecosystem/configuring-dotnet-cli-for-use-with-github-packages)

