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
2. `dotnet pack` to build the package [[Ref](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-the-dotnet-cli)]
3. check out `\bin\Debug`, a `.nupkg` file should be generated.
## Publish your package
