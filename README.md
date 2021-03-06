# ASP .NET Core Dependenct Injection
A sample app that explores resolving objects based on the current request context.

## Choosing which object to resolve at runtime

In the sample there are 2 controllers and 3 different pages. Each page will resolve a different implementation of the [IMarketingPromo](./MultipleRegistrations/MarketingPromos/IMarketingPromo.cs) to display 3 different marketing promotion messages.

* Home/Index - _"Buy one now and get one free!"_
* Home/Privacy - _"No promotions available"_
* About/Index - _"Use code HELLOWORLD for 50% off today"_

In this example the [RouteBasedPromoFactory.cs](./MultipleRegistrations/MarketingPromos/RouteBasedPromoFactory.cs) will use the `ActionContextAccessor` to determine which message to display but the factory could also use other logic to pick the right promotion display.

When the IMarketingPromo implementations have more details they can be sorted. The easiest way to do this is to build a new class derived from `System.Attribute` with the properties needed to sort or filter the registered objects.