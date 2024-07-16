#### [ModUtils](index.md 'index')
### [ModUtils.Classes](ModUtils.Classes.md 'ModUtils.Classes')

## GitHubFile Class

GitHubFile Definition

```csharp
internal class GitHubFile
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; GitHubFile

| Constructors | |
| :--- | :--- |
| [GitHubFile(string, string, string, UpdatePolicy)](ModUtils.Classes.GitHubFile.GitHubFile(string,string,string,ModUtils.Classes.UpdatePolicy).md 'ModUtils.Classes.GitHubFile.GitHubFile(string, string, string, ModUtils.Classes.UpdatePolicy)') | <b>(string) name</b><br/><i>Used solely for debugging output</i><br/><br/><b>(string) remotePath</b><br/><i>Full RAW github path</i><br/><br/><b>(string) localPath</b><br/><i>Local path, relative to \Mods\ folder</i><br/><br/><b>(UpdatePolicy) updatePolicy</b><br/><i>When to update the local file from remote (Default: Changed)</i> |

| Properties | |
| :--- | :--- |
| [LocalPath](ModUtils.Classes.GitHubFile.LocalPath.md 'ModUtils.Classes.GitHubFile.LocalPath') | Local path, relative to \Mods\ folder |
| [Name](ModUtils.Classes.GitHubFile.Name.md 'ModUtils.Classes.GitHubFile.Name') | Used solely for debugging output |
| [RemotePath](ModUtils.Classes.GitHubFile.RemotePath.md 'ModUtils.Classes.GitHubFile.RemotePath') | Full RAW github path |
| [Updated](ModUtils.Classes.GitHubFile.Updated.md 'ModUtils.Classes.GitHubFile.Updated') | Returns true if the file updated |
| [UpdatePolicy](ModUtils.Classes.GitHubFile.UpdatePolicy.md 'ModUtils.Classes.GitHubFile.UpdatePolicy') | When to update the local from remote<br/>Default : Changed |
| [Valid](ModUtils.Classes.GitHubFile.Valid.md 'ModUtils.Classes.GitHubFile.Valid') | Returns true if the supplied information is valid |
