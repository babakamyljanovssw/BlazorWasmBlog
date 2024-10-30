<!--
- created: 30-10-2024
- author: Babanazar Kamyljanov
- tags: blog
-->

## How to create markdown based blog in Blazor WASM?

![](./images/blazor-webassembly.png)

Here is step by step guide to convert markdown file to html in Blazor WASM.

1. Add Markdig package to the prorject

`dotnet add package Markdig --version 0.38.0`

2. Convert markdown file to html in your Blazor page using Markdig.

```csharp
@page "/"
@using Markdig
@inject HttpClient Http

<PageTitle>Home</PageTitle>

<div>@((MarkupString)markdownContent)</div>


@code {
    private string markdownContent = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();

        var response = await Http.GetStringAsync("content/hello-world.md");
        markdownContent = Markdown.ToHtml(response, pipeline);
    }
}
```

Thanks for reading!