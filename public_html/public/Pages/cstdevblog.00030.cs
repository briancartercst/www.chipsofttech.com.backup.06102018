﻿CST Portal Dev Blog
admin|2007/10/13 16:44:53
##PAGE##
<h1>Welcome to the CST Portal Development Blog!</h1>

In this blog, we keep track of all the changes we made for the portal blog.

{TOC}


==Searching==
Added Search to sidebar:

<small>'''Quick Search'''</small>{BR}
{SEARCHBOX}{BR}
<small>[Search.aspx?FullText=1|Advanced Search &raquo;]</small>
]]>

For reference, I modified the SEARCHBOX case statement in \Core\Formatter.cs and changed 

Code: 
... document.location = 'Search.aspx?Query=' ... 

to 
Code: 
... document.location = 'Search.aspx?FullText=1&Query=' ... 


==Keep Alive==

'''Updated file: StartupTools.cs'''
public static void Startup() {
  ...
  KeepAliveInit();
}

[imageleft|KeepAliveInit()|images/dev/keepaliveinit.jpg]





