#pragma checksum "D:\Git\ASP.NET-Learning\WebApplication1\WebApplication1\Components\MovieList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "240956e64703683cd18bbd4c2a7ad9a2a2f38669"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Git\ASP.NET-Learning\WebApplication1\WebApplication1\Components\MovieList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Git\ASP.NET-Learning\WebApplication1\WebApplication1\Components\MovieList.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Git\ASP.NET-Learning\WebApplication1\WebApplication1\Components\MovieList.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Git\ASP.NET-Learning\WebApplication1\WebApplication1\Components\MovieList.razor"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    public partial class MovieList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 9 "D:\Git\ASP.NET-Learning\WebApplication1\WebApplication1\Components\MovieList.razor"
     foreach (var movie in MovieService.GetMovies())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "h5");
            __builder.AddContent(11, 
#nullable restore
#line 13 "D:\Git\ASP.NET-Learning\WebApplication1\WebApplication1\Components\MovieList.razor"
                     movie.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "h5");
            __builder.AddContent(14, 
#nullable restore
#line 14 "D:\Git\ASP.NET-Learning\WebApplication1\WebApplication1\Components\MovieList.razor"
                     movie.maker

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "h5");
            __builder.AddContent(17, 
#nullable restore
#line 15 "D:\Git\ASP.NET-Learning\WebApplication1\WebApplication1\Components\MovieList.razor"
                     movie.thetitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "card-footer");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "small");
            __builder.AddAttribute(24, "class", "text-muted");
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "D:\Git\ASP.NET-Learning\WebApplication1\WebApplication1\Components\MovieList.razor"
                                      (e=>SelectMovie(movie.ID))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "data-toggle", "modal");
            __builder.AddAttribute(29, "data-target", "#productModal");
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddMarkupContent(31, "\r\n                        MoreInfo\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 26 "D:\Git\ASP.NET-Learning\WebApplication1\WebApplication1\Components\MovieList.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal fade");
            __builder.AddAttribute(39, "id", "productModal");
            __builder.AddAttribute(40, "role", "dialog");
            __builder.AddAttribute(41, "aria-labelledby", "productTitle");
            __builder.AddAttribute(42, "aria-hidden", "false");
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(46, "role", "document");
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 35 "D:\Git\ASP.NET-Learning\WebApplication1\WebApplication1\Components\MovieList.razor"
         if (selectedMovie != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "            ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "modal-content");
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "modal-header");
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.OpenElement(55, "h5");
            __builder.AddAttribute(56, "class", "modal-title");
            __builder.AddAttribute(57, "id", "productTitle");
            __builder.AddContent(58, 
#nullable restore
#line 39 "D:\Git\ASP.NET-Learning\WebApplication1\WebApplication1\Components\MovieList.razor"
                                                               selectedMovie.thetitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.AddMarkupContent(60, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "modal-body");
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "card");
            __builder.AddMarkupContent(67, "\r\n                        ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "card-body");
            __builder.AddMarkupContent(70, "\r\n                            ");
            __builder.OpenElement(71, "p");
            __builder.AddAttribute(72, "class", "card-text");
            __builder.AddContent(73, 
#nullable restore
#line 47 "D:\Git\ASP.NET-Learning\WebApplication1\WebApplication1\Components\MovieList.razor"
                                                  selectedMovie.maker

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                            ");
            __builder.OpenElement(75, "p");
            __builder.AddAttribute(76, "class", "card-text");
            __builder.AddContent(77, 
#nullable restore
#line 48 "D:\Git\ASP.NET-Learning\WebApplication1\WebApplication1\Components\MovieList.razor"
                                                  selectedMovie.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n");
#nullable restore
#line 53 "D:\Git\ASP.NET-Learning\WebApplication1\WebApplication1\Components\MovieList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(83, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "D:\Git\ASP.NET-Learning\WebApplication1\WebApplication1\Components\MovieList.razor"
       

    Movie selectedMovie;
    string selectedID;

    void SelectMovie(string ID)
    {
        selectedID = ID;
        selectedMovie = MovieService.GetMovies().First(e => e.ID == ID);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileMovie MovieService { get; set; }
    }
}
#pragma warning restore 1591
