﻿CST Portal Dev Blog
briancarter|2007/10/13 17:48:05
##PAGE##
<div class="boxwide">
Welcome to the CST Portal Development Blog

In this blog, we keep track of all the changes we made for the portal blog.

{TOC}
<p>&nbsp;<p/><p>&nbsp;<p/>
</div>

<div class="boxwide">
==Searching==
<br/>
Added Search to sidebar:
<br/>
<img src="images/dev/quicksearch.jpg" alt="quicksearch" />
<p>&nbsp;</p>
For reference, I modified the SEARCHBOX case statement in <b>\Core\Formatter.cs</b> and changed 

Code: 
<esc>... document.location = 'Search.aspx?Query=' ...</esc>

to 
Code: 
<esc>... document.location = 'Search.aspx?</esc>FullText=1&Query=' ... 
<p>&nbsp;<p/><p>&nbsp;<p/>
</div>

==Keep Alive==

'''Updated file: StartupTools.cs'''
<br />
public static void Startup() { <br/> 
 ...<br />
  <b>KeepAliveInit();<b><br/> 
} <br /><br/> 

Add Init Proc:<br/>
<img src="images/dev/keepaliveinit.jpg" alt="keepaliveinit()" />

<br /><br/>
Add Keep Alive Proc:<br/> 
[imageleft||images/dev/keepalive.jpg]
<br/>


