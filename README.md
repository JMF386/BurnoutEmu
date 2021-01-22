
A Server Emulator for Burnout (and possibly other) games, Based on The Sims Bustin Out (PS2)'s Online Weekend mode emulator, written in C# targeting .NET Core.


### Net Plugin
This plugin is a little crashy but it runs on even the latest version of PCSX2. Makes it very easy to change the DNS to our one!

![image](https://user-images.githubusercontent.com/6294155/43041312-84b754ee-8d54-11e8-9aba-940bdf656b2b.png)

https://forums.pcsx2.net/Thread-Experimental-Winsock-based-DEV9-plugin-Now-with-HDD-Support

### Keyboard
Think typing with an onscreen keyboard is a literal nightmare? Play the game with a controller and type with a keyboard instead, since you're emulating on a PC anyways.

**Plugin:**
https://forums.pcsx2.net/Thread-Another-USBQemu-plugin-this-time-in-VB-net-Keyboard-only


## Server Usage
Clone the repo into a folder and configure it using config.json. The only important thing to set here is your _external ip_, which is used by the redirection server the game first connects to.

Run the server using:
`dotnet run`
That's it for getting the server itself working. To get the game to connect to it, you need to trick the DNS into redirecting some EA and Sony URLs to your server.

A good way to do this is to host a DNS server. On Linux, the easiest way to do this is to install `dnsmasq`, then add the following to your hosts file:
```
199.195.251.151 gate1.us.dnas.playstation.org
<your public ip> tso-e.com
<your public ip> ps2sims04.ea.com
```
The top is a DNAS replacement server hosted by someone else.

Make sure ports `11100`, `10901` and `53` (dns) are open on your firewall.

## Future Stuff
There are a few unknowns in the server software right now, and some things are still a little messy. Specifically, the current mode, "challenge", boots into the player's current. It looks like there is another mode called "play", which might instead let the player use one of their freeplay houses. 

## Acknowledgements 

- Blayer98 from the FreeSO Community for noticing that Need for Speed Underground used the same connection packet as Bustin' Out sent.
- The creator of the NFSU Server, which was the basis of this server (although it was a bit incredibly unsafe for a server). (https://github.com/HarpyWar/nfsuserver/)
- Whoever recorded those packets for a (literally) underground PC/PS2 racing game in 2003, arguably before anyone even cared about this kind of preservation
- PCSX2 developers and the PS2 online community for making DNAS less of an insurmountable obstacle.
- FreeSO Team for not losing it when I decided to work on this for a whole day instead of important stuff. :laughing:
