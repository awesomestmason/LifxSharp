# LifxSharp
A C# implementation of a Lifx HTTP API Client. It is still under development, but has most of the crucial HTTP methods implemented.
# Usage
First need to obtain a Lifx Http Api Key (see https://api.developer.lifx.com/docs/authentication). This key is tied to your account, so make sure to register all your bulbs under this account. 
You can then simply call the constructor for the `LifxHttpClient` class.
```csharp
LifxHttpClient client = new LifxHttpClient(/* LIFX API KEY */);
```
Once the client is created, you can use the full Lifx API to send requests.
See the full list of HTTP methods at https://api.developer.lifx.com/docs
## Examples
### Print out all connected bulbs.
```csharp
var result = await client.ListLightsAsync();
foreach (var bulb in result.Bulbs)
{
    Console.WriteLine(bulb.Uuid);
}
```
### Set all connected lights to green, over the course of 15 seconds.
```csharp
var selector = new SelectorBuilder(Selector.All()).Build();
var color = new LifxColor()
{
    Brightness = 1,
    Hue = 100,
    Kelvin = 4500,
    Saturation = 1
};
var request = new SetStateRequest() { Color = color.AsLifxColorString(), Duration = 15 };
await client.SetState(selector, request);
```
### Building selectors
Lifx uses selectors to determine which bulbs to effect. Here are some examples:

Select all lights
```csharp
var selector = new SelectorBuilder(Selector.All()).Build();
```
Select all lights in zone 1 with label "customLabel" or that are in the kitchen. 
```csharp
var selector = new SelectorBuilder(Selector.Label("customLabel"))
    .Or(Selector.Location("kitchen"))
    .Zone(1)
    .Build();
```

Select all lights in zones 1-5 with label "customLabel" or that are in the kitchen. 
```csharp
var selector = new SelectorBuilder(Selector.Label("customLabel"))
    .Or(Selector.Location("kitchen"))
    .ZoneRange(1, 5)
    .Build();
```
Select all lights with labels "customLabel1", "customLabel2" or "customLabel3".
```csharp
var selector = new SelectorBuilder(Selector.Label("customLabel1"))
    .Or(Selector.Label("customLabel2"))
    .Or(Selector.Label("customLabel3"))
    .Build();
```
