>#  CustomsTagHelpers

![Image](http://dpaninfor.fr/Captures/tag%20helper.jpg)

> ##Introduction
<p>
    Ce projet de regroupement de Tag Helper à débuté suite à la lecture de l'article
    <a href="http://www.dotnetcurry.com/aspnet-mvc/1266/using-tag-helpers-aspnetmvc-6-core-1">Creating Tag Helpers in ASP.NET MVC 6 / ASP.NET Core 1.0</a>
    <span style="color:darkgrey; font-size:small">([2016-03-24] by <a style="font-style:italic; color:lightcoral" href="http://www.dotnetcurry.com/author/mahesh-sabnis">Mahesh Sabnis</a></span>).
    C'est en effet une des nouvelles fonctionnalités les plus intéressantes de ASP.NET, elle permet de construire une page Html de façon cohérente et claire tout en permettant aux programmeurs de créer des snippets personnalisés pour simplifier la création des pages web.
</p>

> ## A Propos

<p>
    Je découvre MVC 5 et les Tag Helpers, au cours de cette découverte j'ajouterai différents Tag Helpers trouvés
    de façons épars tout au long du parcours de formation, cela aura pour effet de créer une
    collection de Tag Helpers utiles à tous. Je noterai aussi des articles sur les Tag Helpers de façons chronologique.
</p>


> ## Arborescence


- Les différents Tag Helpers se trouvent dans le dossier ./CustomsTagHelpers/TagHelpers.
- L'auteur du projet <a href="https://github.com/dpaquette/TagHelperSamples">TagHelperSamples</a> est <span style="color:darkgrey; font-size:small">([2016-03-24] by <a style="font-style:italic; color:lightcoral" href="https://www.nuget.org/profiles/dpaquette">David Paquette</a></span>).


> ## Références internet sur les Tag Helper

---
###2016
---
-  [Introduction to Tag Helpers](https://docs.asp.net/en/latest/mvc/views/tag-helpers/intro.html)
<span style="color:darkgrey; font-size:small">([2016] - by <a style="font-style:italic; color:lightcoral" href="https://twitter.com/RickAndMSFT">Rick Anderson</a></span>)

- [Authoring Tag Helpers](http://aspnetmvc.readthedocs.io/projects/mvc/en/latest/views/tag-helpers/authoring.html)
<span style="color:darkgrey; font-size:small">([2016] - by <a style="font-style:italic; color:lightcoral" href="https://twitter.com/RickAndMSFT">Rick Anderson</a></span>)

- [Tag Helpers In MVC 6](http://www.c-sharpcorner.com/article/tag-helpers-in-mvc6/)
<span style="color:darkgrey; font-size:small">([2016-05-10] By <a style="font-style:italic; color:lightcoral" href="http://www.c-sharpcorner.com/members/nataraj-arunachalam">Nataraj Gandhi Arunachalam</a></span>)

- [Telling the time with ASP.NET Tag Helpers](https://blogs.msdn.microsoft.com/martinkearn/2016/04/27/telling-the-time-with-asp-net-tag-helpers/)
<span style="color:darkgrey; font-size:small">([2016-04-27] - by <a style="font-style:italic; color:lightcoral" href="https://blogs.msdn.microsoft.com/martinkearn/">Martin Kean</a></span>)

- [ASP.NET Core 1.0 : Goodbye Html Helpers and hello TagHelpers](https://dannyvanderkraan.wordpress.com/2016/04/19/asp-net-core-1-0-goodbye-html-helpers-and-hello-taghelpers/)
<span style="color:darkgrey; font-size:small">([2016-04-19])- by <a style="font-style:italic; color:lightcoral" href="http://stackoverflow.com/users/1065278/danny-van-der-kraan">Danny van der Kraan</a></span>)

- [Authoring ASP.NET Core MVC Tag Helper](http://www.hossambarakat.net/2016/02/15/authoring-asp-net-core-mvc-tag-helper/)
<span style="color:darkgrey; font-size:small">([2016-02-15] by <a style="font-style:italic; color:lightcoral" href="https://au.linkedin.com/in/hossambarakat">Hossam Barakat</a></span>)

- [Enabling Tag Helper Intellisense in Visual Studio]()
<span style="color:darkgrey; font-size:small">([2016-02-06] by <a style="font-style:italic; color:lightcoral" href="http://stackoverflow.com/users/3199781/anthony-chu">Antony Chu</a>]</span>)

- [How to use select tag helper in ASP.NET MVC 6](http://www.talkingdotnet.com/how-to-use-select-tag-helper-mvc6/)
<span style="color:darkgrey; font-size:small">([2016-01-25] by <a style="font-style:italic; color:lightcoral" href="http://www.talkingdotnet.com">Talking Dotnet</a></span>)

---
###2015
---

- [Complex Custom Tag Helpers in MVC 6](http://www.davepaquette.com/archive/2015/12/28/complex-custom-tag-helpers-in-mvc-6.aspx)
<span style="color:darkgrey; font-size:small">([2015-12-28] by <a style="font-style:italic; color:lightcoral" href="http://davepaquette.com/about.html">David Paquette</a></span>)

- [Tag Helpers in ASP.NET MVC 6](https://blog.mariusschulz.com/2015/12/14/tag-helpers-in-asp-net-mvc-6)
<span style="color:darkgrey; font-size:small">([2015-12-14] by <a style="font-style:italic; color:lightcoral" href="https://blog.mariusschulz.com/about">Marius Schulz</a></span>)

- [Creating custom MVC 6 Tag Helpers](http://www.davepaquette.com/archive/2015/06/22/creating-custom-mvc-6-tag-helpers.aspx)
<span style="color:darkgrey; font-size:small">([2015-11-22] by <a style="font-style:italic; color:lightcoral" href="http://davepaquette.com/about.html">David Paquette</a></span>)

- [Markdown in your MVC 6 Razor Pages](http://www.davepaquette.com/archive/2015/11/02/markdown-in-your-mvc-6-razor-pages.aspx)
<span style="color:darkgrey; font-size:small">([2015-11-02] by <a style="font-style:italic; color:lightcoral" href="http://davepaquette.com/about.html">David Paquette</a></span>)

- [Custom MVC 6 Tag Helper Samples](http://www.davepaquette.com/archive/2015/09/20/custom-mvc-6-tag-helper-samples.aspx)
<span style="color:darkgrey; font-size:small">([2015-09-20] by <a style="font-style:italic; color:lightcoral" href="http://davepaquette.com/about.html">David Paquette</a></span>)

- [ASP.NET MVC 6 les nouvelles fonctions des Tag Helpers](http://blog.soat.fr/2015/09/asp-net-mvc-6-les-nouvelles-fonctions-des-tag-helpers/)
<span style="color:darkgrey; font-size:small">([2015-09-11] by <a style="font-style:italic; color:lightcoral" href="http://blog.soat.fr/author/leonard-labat/">Léonard Labat</a></span>)

- [Adding Prefixes to Tag Helpers in MVC 6](http://www.davepaquette.com/archive/2015/09/03/adding-prefixes-to-tag-helpers-in-mvc-6.aspx)
<span style="color:darkgrey; font-size:small">([2015-09-03] by <a style="font-style:italic; color:lightcoral" href="http://davepaquette.com/about.html">David Paquette</a></span>)

- [A complete guide to the MVC 6 Tag Helpers](https://blogs.msdn.microsoft.com/cdndevs/2015/08/06/a-complete-guide-to-the-mvc-6-tag-helpers/)
<span style="color:darkgrey; font-size:small">([2015-08-06] by <a style="font-style:italic; color:lightcoral" href="http://davepaquette.com/about.html">David Paquette</a></span>)

- [ASP.NET MVC 6 introduction aux Tag Helpers](http://blog.soat.fr/2015/07/asp-net-mvc-6-introduction-aux-tags-helpers/)
<span style="color:darkgrey; font-size:small">([2015-07-31] by <a style="font-style:italic; color:lightcoral" href="http://blog.soat.fr/author/leonard-labat/">Léonard Labat</a></span>)

- [MVC 6 Image Tag Helper](http://www.davepaquette.com/archive/2015/07/01/mvc-6-image-tag-helper.aspx)
<span style="color:darkgrey; font-size:small">([2015-07-01] by <a style="font-style:italic; color:lightcoral" href="http://davepaquette.com/about.html">David Paquette</a></span>)

- [Tag Helpers in ASP.NET MVC 6 - An Overview](https://www.exceptionnotfound.net/tag-helpers-in-asp-net-core-1-0-an-overview/)
<span style="color:darkgrey; font-size:small">([2015-05-26] by <a style="font-style:italic; color:lightcoral" href="https://www.exceptionnotfound.net/author/matthew-jones/">Matthew Jones</a></span>)

- [MVC6 Input Tag Helper Deep Dive](http://www.davepaquette.com/archive/2015/05/13/mvc6-input-tag-helper-deep-dive.aspx)
<span style="color:darkgrey; font-size:small">([2015-05-13]by <a style="font-style:italic; color:lightcoral" href="http://davepaquette.com/about.html">David Paquette</a></span>)

- [Cleaner Forms using Tag Helpers in MVC6](http://www.davepaquette.com/archive/2015/05/11/cleaner-forms-using-tag-helpers-in-mvc6.aspx)
<span style="color:darkgrey; font-size:small">([2015-05-11] by <a style="font-style:italic; color:lightcoral" href="http://davepaquette.com/about.html">David Paquette</a></span>)

- [Introducing TagHelpers in ASP.NET MVC 6](http://www.mikesdotnetting.com/article/274/introducing-taghelpers-in-asp-net-mvc-6)
<span style="color:darkgrey; font-size:small">([2015-05-11] by <a style="font-style:italic; color:lightcoral" href="http://www.mikesdotnetting.com/about">Mike Brind</a></span>)


---
###2014
---
- [ASPNET 5 VNext Work In Progress : Exploring Tag Helpers](http://www.hanselman.com/blog/ASPNET5VNextWorkInProgressExploringTagHelpers.aspx)
<span style="color:darkgrey; font-size:small">([2014-11-20] by <a style="font-style:italic; color:lightcoral" href="http://www.hanselman.com/about/">Scott Hanselman</a></span>)

- [ASP.NET Tag Helpers – The Basics](http://www.jeffreyfritz.com/2014/11/asp-net-tag-helpers-the-basics/)
<span style="color:darkgrey; font-size:small">([2014-11-11] by <a style="font-style:italic; color:lightcoral" href="http://www.jeffreyfritz.com/about/">Jeffrey T. Fritz</a></span>)

- [ASP.NET MVC Tag Helpers – Web Controls 2.0?](http://www.jeffreyfritz.com/2014/11/asp-net-mvc-tag-helpers-web-controls-2-0/)
<span style="color:darkgrey; font-size:small">([2014-11-10] by <a style="font-style:italic; color:lightcoral" href="http://www.jeffreyfritz.com/about/">Jeffrey T. Fritz</a></span>)

- [Get Started with ASP.NET MVC TagHelpers](http://www.jeffreyfritz.com/2014/11/get-started-with-asp-net-mvc-taghelpers/)
<span style="color:darkgrey; font-size:small">([2014-11-09] by <a style="font-style:italic; color:lightcoral" href="http://www.jeffreyfritz.com/about/">Jeffrey T. Fritz</a></span>)

----

<span style="color:darkgrey; font-size:small"><a style="font-style:italic; color:cadetblue" href="http://www.dpaninfor.ovh">Assistance et Solutions Informatiques</a></span>

