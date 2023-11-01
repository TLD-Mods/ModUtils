### [ModUtils](ModUtils.md 'ModUtils').[Scene](ModUtils.Scene.md 'ModUtils.Scene')

## Scene.IsPrimaryScene(string) Method

Check if the scene is the primary scene of the SceneSet  
(not _SANDBOX,_DLC01)

```csharp
public static bool IsPrimaryScene(string? sceneName=null);
```
#### Parameters

<a name='ModUtils.Scene.IsPrimaryScene(string).sceneName'></a>

`sceneName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

If left null Scene.Name() will be used

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')