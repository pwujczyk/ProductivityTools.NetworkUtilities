<!--Category:C#--> 
 <p align="right">
        <a href="https://www.nuget.org/packages/ProductivityTools.NetworkUtilities/"><img   src="Images/Header/Nuget_border_40px.png" /></a>
        <a href="http://productivitytools.tech/NetworkUtilities/"><img src="Images/Header/ProductivityTools_green_40px_2.png" /><a> 
        <a href="https://github.com/pwujczyk/ProducvitityTools.NetworkUtilities"><img src="Images/Header/Github_border_40px.png" /></a>
</p>
<p align="center">
    <a href="http://productivitytools.tech/">
        <img src="Images/Header/LogoTitle_green_500px.png" />
    </a>
</p>


# Network Utilities

The library returns external IP of the computer.
<!--more-->

Currently library has one method, which returns external IP, to do it it calls http://ifconfig.me/ip which shows ip of the caller. 

```c#
var externalIp = ExternalIP.Get();
```
<!--og-image-->
![Console Colors Tester](Images/Diagram.png)
