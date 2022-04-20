# LifxSharp
A C# implementation of a Lifx HTTP API Client. It is still under development, but has most of the crucial HTTP methods implemented.
# Usage
First need to obtain a Lifx Http Api Key (see https://api.developer.lifx.com/docs/authentication). This key is tied to your account, so make sure to register all your bulbs under this account. 
You can then simply call the constructor for the `LifxHttpClient` class.
```
LifxHttpClient client = new LifxHttpClient(/* LIFX API KEY */);
```
Once the client is created, you can use the full Lifx API to send requests.
See the full list of HTTP methods at https://api.developer.lifx.com/docs
## Examples
### Print out all connected bulbs.
```
var result = await client.ListLightsAsync();
foreach (var bulb in result.Bulbs)
{
    Console.WriteLine(bulb.Uuid);
}
```
### Set all connected lights to green, over the course of 15 seconds.
```
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
