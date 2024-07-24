# ASP.NET MVC Routing and Views Guide

## Overview

This guide explains ASP.NET MVC routing, action methods, views, and Razor programming. It includes code examples and explanations to help you understand how to set up and manage routing and views in your MVC applications.

## Table of Contents

1. [Routing Basics](#routing-basics)
2. [Route Parameters](#route-parameters)
3. [Action Methods](#action-methods)
4. [Views](#views)
5. [View Engines](#view-engines)
6. [Action Method Attributes](#action-method-attributes)
7. [Razor Programming](#razor-programming)
8. [Handling Parameters and Query Strings](#handling-parameters-and-query-strings)

## Routing Basics

Routing maps URL requests to controllers and actions.

### Example Route Configuration

```csharp
routes.MapRoute(
    name: "studentroute",
    url: "Nit/Student",
    defaults: new { controller = "Student", action = "Index" }
);
## Route Configuration

### Route Parameters

Routes can include parameters to capture values from the URL.

#### Example Route with Parameters

```csharp
routes.MapRoute(
    name: "Default",
    url: "{controller}/{action}/{id}",
    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
);
I’m sorry for the trouble. Let’s format it properly to ensure you can copy the code easily:

---

# ASP.NET Routing and Views

## Routes

In ASP.NET, routing is used to define URL patterns and map them to controllers and actions. Here’s a basic example of routing configuration:

```csharp
routes.MapRoute(
    name: "studentroute",
    url: "Nit/Student",
    defaults: new { controller = "Student", action = "Index" }
);
```

**URL Pattern**: `https://localhost:44312/Nit/Student`  
This route will direct requests to the `Student` controller and the `Index` action.

### Route Parameters

You can define routes with parameters:

```csharp
routes.MapRoute(
    name: "Default",
    url: "{controller}/{action}/{id}",
    defaults: new { controller = "Test", action = "Index", id = UrlParameter.Optional }
);
```

In the route above, `id` is a parameter that can be optional. Controllers should handle these parameters:

```csharp
public class ParamsController : Controller
{
    public ActionResult Index1(int id) // id is mandatory
    {
        return Content(id.ToString());
    }

    public ActionResult Index2(int id = 0) // id has a default value
    {
        return Content(id.ToString());
    }

    public ActionResult Index3(int? id) // id is nullable
    {
        return Content(id.ToString());
    }
}
```

## Action Results

Action methods return an `ActionResult`, which can be one of several derived classes:

- `ViewResult`: Returns a view to the client.
- `JsonResult`: Returns JSON-formatted data.
- `RedirectResult`: Redirects to another URL.
- `ContentResult`: Returns plain text content.

**Example**:

```csharp
public ActionResult Forgot()
{
    return View("ForgotPwd");
}

public ActionResult Reset()
{
    return View("ResetPswd");
}
```

If the view name differs from the action method name, specify the view name explicitly. It is recommended to keep view names consistent with their corresponding controller actions.

## View Engines

ASP.NET supports different view engines:

1. **Web Forms View Engine**: Uses `.aspx` files.
2. **Razor View Engine**: Uses `.cshtml` or `.vbhtml` files (preferred for newer projects).

**Razor Syntax**:

```html
@{
    int i = 10;
}
<h1>The value of i is: @i</h1>
```

**Web Forms Syntax**:

```html
<% int i = 10; %>
<h1>The value of i is: <%= i %></h1>
```

## Action Methods

Action methods in ASP.NET MVC are typically public methods in controllers. By default, all public methods are action methods unless decorated with `[NonAction]`.

You can also use the `[ActionName]` attribute to provide a different name for the action:

```csharp
[ActionName("fgt")]
public ActionResult Forgot()
{
    return View("ForgotPwd");
}
```

## Passing Values

Values can be passed to action methods via route parameters or query strings.

**Route Parameters**:

```csharp
public string Greet(string id, string name)
{
    return $"Hello {id} {name}";
}
```

**Query Strings**:

```csharp
public string UrlValues()
{
    string pid = Request.QueryString["Pid"];
    string pname = Request.QueryString["Pname"];
    return $"Hello {pid} {pname}";
}
```

**Route Configuration with Multiple Parameters**:

```csharp
routes.MapRoute(
    name: "Default",
    url: "{controller}/{action}/{id}/{name}/{price}",
    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, name = UrlParameter.Optional, price = UrlParameter.Optional }
);
```

### Summary

- Use routing to map URLs to controllers and actions.
- Define optional and mandatory parameters in routes.
- Return appropriate `ActionResult` types from action methods.
- Use Razor for modern view rendering and prefer consistent naming for views.


