#### [ModUtils](index.md 'index')
### [ModUtils.Classes](ModUtils.Classes.md 'ModUtils.Classes').[GitHubFile](ModUtils.Classes.GitHubFile.md 'ModUtils.Classes.GitHubFile')

## GitHubFile(string, string, string, UpdatePolicy) Constructor

<b>(string) name</b><br/><i>Used solely for debugging output</i><br/><br/><b>(string) remotePath</b><br/><i>Full RAW github path</i><br/><br/><b>(string) localPath</b><br/><i>Local path, relative to \Mods\ folder</i><br/><br/><b>(UpdatePolicy) updatePolicy</b><br/><i>When to update the local file from remote (Default: Changed)</i>

```csharp
internal GitHubFile(string name, string remotePath, string localPath, ModUtils.Classes.UpdatePolicy updatePolicy=ModUtils.Classes.UpdatePolicy.Changed);
```
#### Parameters

<a name='ModUtils.Classes.GitHubFile.GitHubFile(string,string,string,ModUtils.Classes.UpdatePolicy).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='ModUtils.Classes.GitHubFile.GitHubFile(string,string,string,ModUtils.Classes.UpdatePolicy).remotePath'></a>

`remotePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='ModUtils.Classes.GitHubFile.GitHubFile(string,string,string,ModUtils.Classes.UpdatePolicy).localPath'></a>

`localPath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='ModUtils.Classes.GitHubFile.GitHubFile(string,string,string,ModUtils.Classes.UpdatePolicy).updatePolicy'></a>

`updatePolicy` [ModUtils.Classes.UpdatePolicy](https://docs.microsoft.com/en-us/dotnet/api/ModUtils.Classes.UpdatePolicy 'ModUtils.Classes.UpdatePolicy')