# Asset-Injection-Unity

Provides an attribute for automatically inserting assets to serialized fields.

```csharp
[SerializeField, InjectAsset(typeof(EventService))]
EventService service;
```

Its intended use is mainly linking ScriptableObject assets to scripts. It does so by injecting the first asset of given type from the AssetDatabase to the field if the field has not been already set.

This is an Editor script, so it does nothing during runtime.