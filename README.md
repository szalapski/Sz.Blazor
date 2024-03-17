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
  
  [] Make inline transitions disappear better

## Quickstart

### Running locally
Run.bat executed in the root of the solution should automatically start with the right parameters.