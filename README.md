# Sz.Blazor

Sz.Blazor provides a few ultra-simple utilities and components for Blazor.

## Quickstart

### Run it locally with hot reload, without a container
`dotnet watch --project .\Sz.Blazor\`

Note there is no Dockerfile! You can control many aspects of the generated 
container through MSBuild properties just like in a Dockerfile.
See https://learn.microsoft.com/en-us/dotnet/core/docker/publish-as-container?pivots=dotnet-8-0

### Publish the demo site to a local container and run it 
```cmd
dotnet publish --os linux --arch x64 /t:PublishContainer -c Release .\Sz.Blazor\ && docker run -it --init --rm -p 5101:8080 sz-blazor
```


## Components

- **Reveal** is a drop-in replacement for an `@if` block in a .razor file's markup section

  ### Usage
  For any block-display elements that are conditionally shown in an @if block, such as:
  ```razor
  @if (ShowPanel){
	  <div>Any HTML element</div>
	  <EditForm>Any Blazor component instance</EditForm>
  }
  ```
  Simply replace the `@if` with the Reveal component and supply the boolean
  value as the When parameter.
  ```razor
  <Reveal When="ShowPanel">
	  <div>Any HTML element</div>
	  <EditForm>Any Blazor component instance</EditForm>
  </Reveal>
  ```

  ### Wishlist
  
  [] Make inline transitions disappear better
