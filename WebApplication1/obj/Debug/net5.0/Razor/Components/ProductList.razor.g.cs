#pragma checksum "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7aea3e1aaba76c0b9229308aa4be53dfbc1df024"
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
#line 1 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
using WebApplication1.Services;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
#nullable restore
#line 7 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
     foreach (var product in ProductService.GetProducts())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.AddAttribute(4, "style", "height:500px;");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-img");
            __builder.AddAttribute(7, "style", "background-image:url(\'" + (
#nullable restore
#line 10 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                                                                product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.OpenElement(11, "h5");
            __builder.AddAttribute(12, "class", "card-title");
            __builder.AddContent(13, 
#nullable restore
#line 13 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                     product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-footer");
            __builder.OpenElement(17, "small");
            __builder.AddAttribute(18, "class", "text-muted");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                                      (e => SelectProduct(product?.Id ?? string.Empty))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "data-toggle", "modal");
            __builder.AddAttribute(22, "data-target", "#productModal");
            __builder.AddAttribute(23, "class", "btn btn-primary");
            __builder.AddMarkupContent(24, "\r\n                        More Info\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
 if (selectedProduct != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "modal fade");
            __builder.AddAttribute(27, "id", "productModal");
            __builder.AddAttribute(28, "tabindex", "-1");
            __builder.AddAttribute(29, "role", "dialog");
            __builder.AddAttribute(30, "aria-labelledby", "productTitle");
            __builder.AddAttribute(31, "aria-hidden", "true");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(34, "role", "document");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "modal-content");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal-header");
            __builder.OpenElement(39, "h5");
            __builder.AddAttribute(40, "class", "modal-title");
            __builder.AddAttribute(41, "id", "productTitle");
            __builder.AddContent(42, 
#nullable restore
#line 34 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                                                               selectedProduct.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.AddMarkupContent(44, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "modal-body");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "card");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "card-img");
            __builder.AddAttribute(52, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 41 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                                                                             selectedProduct.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "card-body");
            __builder.OpenElement(56, "p");
            __builder.AddAttribute(57, "class", "card-text");
            __builder.AddContent(58, 
#nullable restore
#line 44 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                                                  selectedProduct.Desc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "modal-footer");
#nullable restore
#line 49 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                     if (voteCount == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(62, "<span>Be the first to vote!</span>");
#nullable restore
#line 52 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "span");
            __builder.AddContent(64, 
#nullable restore
#line 55 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                               voteCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(65, " ");
            __builder.AddContent(66, 
#nullable restore
#line 55 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                                          voteLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                     for (int i = 1; i < 6; i++)
                    {
                        var currentStar = i;
                        if (i <= currentRating)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(67, "span");
            __builder.AddAttribute(68, "class", "fa fa-star checked");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                                                                       (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(70, "span");
            __builder.AddAttribute(71, "class", "fa fa-star");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                                                               (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 67 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 74 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(73, "<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\Muhammad Ariffanka\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
 
    Product? selectedProduct;
    string? selectedProductId;

    void SelectProduct(string productId)
    {
        selectedProductId = productId;
        selectedProduct = ProductService.GetProducts().First(x => x.Id == productId);
        GetCurrentRating();
    }

    int currentRating = 0;
    int voteCount = 0;
    string? voteLabel;

    void GetCurrentRating()
    {
        if (selectedProduct?.Ratings == null)
        {
            currentRating = 0;
            voteCount = 0;
        }
        else
        {
            voteCount = selectedProduct.Ratings.Count();
            voteLabel = voteCount > 1 ? "Votes" : "Vote";
            currentRating = selectedProduct.Ratings.Sum() / voteCount;
        }

        System.Console.WriteLine($"Current rating for {selectedProduct?.Id}: {currentRating}");
    }

    void SubmitRating(int rating)
    {
        System.Console.WriteLine($"Rating received for {selectedProduct?.Id}: {rating}");
        if (selectedProductId == null)
            return;
        ProductService.AddRating(selectedProductId, rating);
        SelectProduct(selectedProductId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
