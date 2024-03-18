## Sz.Blazor

Sz.Blazor provides a few ultra-simple utilities and components for Blazor.

### Components

- **Reveal** is a drop-in replacement for an `@if` block in a .razor file's markup section

  #### Usage
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
  [] Why does text in inline and table cell disappear immediately? Need to make inline transitions disappear better

## Quickstart

Run.bat executed in the root of the solution should automatically start with the right parameters.

GitHub Action SzBlazor1 should be set up to automatically publish to https://szblazor1.azurewebsites.net/ on Azure.
If visiting this demo site, it will take a few minutes to spin up, as it is hosted on a free tier.

## Open questions
[] Why do I need to specify a default render mode on the Routes in app.razor at all?  Shouldn't it work by default?
[] Why does OperatingSystem.IsBrowser seem to always return false?  Are we never in WebAssembly mode even when InteractiveAuto?
