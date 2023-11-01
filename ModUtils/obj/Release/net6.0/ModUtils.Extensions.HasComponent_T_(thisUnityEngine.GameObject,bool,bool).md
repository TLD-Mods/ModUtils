### [ModUtils](ModUtils.md 'ModUtils').[Extensions](ModUtils.Extensions.md 'ModUtils.Extensions')

## Extensions.HasComponent<T>(this GameObject, bool, bool) Method

Checks if the GameObject has a component of type <T>

```csharp
internal static bool HasComponent<T>(this UnityEngine.GameObject go, bool checkChildren=false, bool checkParent=false)
    where T : UnityEngine.Component;
```
#### Type parameters

<a name='ModUtils.Extensions.HasComponent_T_(thisUnityEngine.GameObject,bool,bool).T'></a>

`T`
#### Parameters

<a name='ModUtils.Extensions.HasComponent_T_(thisUnityEngine.GameObject,bool,bool).go'></a>

`go` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')

<a name='ModUtils.Extensions.HasComponent_T_(thisUnityEngine.GameObject,bool,bool).checkChildren'></a>

`checkChildren` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

(optional [bool])

<a name='ModUtils.Extensions.HasComponent_T_(thisUnityEngine.GameObject,bool,bool).checkParent'></a>

`checkParent` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

(optional [bool])

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
bool true|false