#3.1.25.112
+ Fixed chat memory issue
+ Chat images for subscribers(gifs disabled for now)
+ Login fixes
+ Fix of play window being always on top when fullscreen
+ Added html support for game documents
+ DB Fixes

#3.1.24.111
+ Fixed now can't edit username if playing online
+ Fixed some event issues

#3.1.24.110
+ Fixed some potential memory leaks

#3.1.24.109
+ Added image and gif support in chat for subscribers
+ Fixed menu bar hiding in game
+ Fixed chat message bar not re showing up if closed
+ Only highlight chat lines if hovering usernames
+ Only allow up and down in chat if no text
+ Add option to change chat history length
+ Added hint in chat text input to show /? command

#3.1.24.108
#3.1.23.108
+ Allow installing multiple o8c files
+ Fixed self hosted game https://github.com/kellyelton/OCTGN/issues/822
+ Fixed pre game lobby always in front and annoying https://github.com/kellyelton/OCTGN/issues/832
+ Fixed not being able to open 2 OCTGN's https://github.com/kellyelton/OCTGN/issues/831
+ Fix for switch statement in proxygen

#3.1.23.107
+ DESTROYED THE EVIL RIBBON CONTROL IN GAME
+ Less user list refreshes for performance

#3.1.23.106
+ User equality speed boost(just a performance thing)
+ elseif in proxy gen fix
+ More performance updates

#3.1.22.106
#3.1.21.106
+ Fixed some chat slow down
+ Trimmed down some logging
+ Adding some logging
+ Fixed game list not showing up
+ Cleaned out some unrequired junk
+ Addes switch case support for proxygen

#3.1.21.105
#3.1.20.105
+ Fixed user chat list
+ Added elseif to proxygen
+ New message box system https://github.com/kellyelton/OCTGN/issues/807

#3.1.20.104
+ Added some sub stuff
+ A fix for the chat log
+ Made version required in the set.xsd

#3.1.19.104
+ Fixed feed games don't update with some version changes https://github.com/kellyelton/OCTGN/issues/809
+ Updated the new login with some visual changes

#3.1.19.103
#3.1.19.102
+ Fixed potential crash/freeze due to breaking my philosophy that while loops are evil

#3.1.18.102
#3.1.17.102
+ More extensive login logging
+ Added more logging
+ Faster propagation???
+ Fixed where you could accidently resize the window when you resize
+ Contact list cleanup
+ Better user icon usage
+ Fixed a sorting bug in the user list
+ Fixed sub price typo

#3.1.17.101
+ Performance boosting

#3.1.17.100
#3.1.16.100
+ Badges for subbed users

#3.1.16.99
#3.1.15.99
+ Made an installer warning for xp

#3.1.15.98
+ Fixed more chat issues
+ Fixed a null crash

#3.1.15.97
+ More performance boosts
+ Killed the indygogo page
+ Increased chat limit to 1k
+ More chat improvements
+ Fixed slow loading of text files in game documents
+ Added install package option to o8buildgui
+ Added o8buildgui

#3.1.15.96
+ Fixed a chat bug

#3.1.14.96
+ Limit chat messages to 100
+ Fixed crash from nag window
+ Fixed bug talking to lobby while offline

#3.1.13.96 - First release of 3.1.x.x
+ Always start as command line(sas)
+ Removed some unnessisary tracing in lobby server
+ Fixed sub list
+ Fixed message box bug

#3.1.12.96
+ Cut sub nag box time in half
+ Fixed switchTo bug https://github.com/kellyelton/OCTGN/issues/797

#3.1.12.95
+ Fixed game time
+ Fixed o8c cancel not allowed to install another o8c

#3.1.12.94
+ Fixed a hack(nothing about that sounds right)

#3.1.12.93
+ This is the real hack for the test version

```
To come...There are 30 ish more changes that can be found in our commit list https://github.com/kellyelton/OCTGN/commits/master for now
```

#3.0.12.58
+ Fixed issue where people boot into the game and crash https://github.com/kellyelton/OCTGN/issues/723

#3.0.10.55
+ Fixed offline gaming https://github.com/kellyelton/OCTGN/issues/679
+ Fixed deck builder crash when no games installed https://github.com/kellyelton/OCTGN/issues/680

#3.0.9.52
+ Added ability to create cards in arbitrary groups https://github.com/kellyelton/OCTGN/issues/674 
+ Fixed bug that was causing OCTGN to crash when someone would join the pre game lobby.

#3.0.8.52[Test Build]
+ Added ability to create cards in arbitrary groups https://github.com/kellyelton/OCTGN/issues/674 
+ Fixed bug that was causing OCTGN to crash when someone would join the pre game lobby.

#3.0.8.51
+ Fixed multiple lobby chat tabs appearing over time
+ Defaulted HardwareRendering to 'ON'
+ Fixed config files not saving
+ Octgn remembers last game type hosted https://github.com/kellyelton/OCTGN/issues/641

#3.0.7.51[Test Build]
+ Fixed multiple lobby chat tabs appearing over time
+ Defaulted HardwareRendering to 'ON'
+ Fixed config files not saving
+ Octgn remembers last game type hosted https://github.com/kellyelton/OCTGN/issues/641

#3.0.7.50
+ Fixed crash from Game list resize.
+ Some file locking on config file so it doesn't keep breaking.
+ Drag issue in deck fixed

#3.0.6.48
+ Increased login page size
+ Added turnNumber() to python API https://github.com/kellyelton/OCTGN/commit/fbaf0ecd246b72d3a96150ebe457d47c92ab6f71

#3.0.5.47
+ Added missing login links for registration and password recovery etc.
+ Fixed Custom Games resizing issue
+ Removes title bar on fullscreen game
+ Added card.setController(player) api
+ Added card.peek() api
+ Added setActivePlayer() api

#3.0.3.43
+ More performance tuning
+ Added some performance options to the options menu
+ Performance options start on the lowest settings
+ Fixed offline play bug
+ Fixed Pre Game Lobby popping up behind main window.
+ Fixed Ctrl+S Shortcut in game

#3.0.2.42
+ Performance tuning

#3.0.2.41
+ Added options dialog
+ Added light chat option

#3.0.2.40
+ Fixed game hosting and joining.

#3.0.2.39
+ Added isTableBackgroundFlipped() and setTableBackgroundFlipped(flipped) to python api https://github.com/kellyelton/OCTGN/issues/540
+ Can now save a limited deck during play https://github.com/kellyelton/OCTGN/issues/559
+ Fixed deck editor crash https://github.com/kellyelton/OCTGN/issues/577

#3.0.2.38
+ **New Layout**
+ Fix issue with OCTGN window being offscreen
+ Converted most colors(I think)
+ Converted Table window to new style
+ Autorefresh news list
+ Changed contact list(for better or worse)
+ /commands for most user based things
+ Improved offline playability with this new layout
+ Better offline nickname picker
+ Fixed window dragging error(right click)
+ Fixed some race conditions
+ Improved deck editor drag drop

#3.0.1.32
+ Deck editor, most things are draggable(use shift key for some stuff)
+ Shuffling improvement
+ Offline hosting works with no internet connection again.

#3.0.1.31
+ Fixed game menus(missing shortcut keys and scrolling)
+ Shrunk down menu spacing

#3.0.1.30
+ Performance gain in lobby.

#3.0.1.29
+ Dummy change to fix updater.

#3.0.1.28
+ Friendslist is now sorted by online and offline and then alphabetically
+ Reworked how fonts are loaded from game definitions. Developers see [here](https://github.com/kellyelton/OCTGN/pull/621)
+ UI Changes
+ Made reconnecting not be a popup window anymore
+ Changed updating back to installer
+ New chat
+ Fixed offline games
+ fixed deck loading bug
+ In game chat window is now resizable
+ Fixed chat command crash
+ Created basic plugin system for the deck editor(octgn.library on nuget)
+ python: can now draw arrows

#3.0.1.27
+ Localized and changed chat server endpoints
+ Added v1 of Deck Builder Plugin System
+ Offline games now can see their external IP

#3.0.1.26
+ Fixed 10 crash scenarios
+ Fixed a problem with the updater
+ Fixed webRead no response before timeout error.
+ Fixed https://github.com/kellyelton/OCTGN/issues/508 (Lobby chat missing on first start)

#3.0.1.25
+ Fixed webRead bug.

#3.0.1.24
+ Fixed issue with passwords with special characters not working

#3.0.1.23
+ Added password reset button
+ New login mechanism
+ New registration mechanism
+ Added error submitting
+ Fixed potential deadlock
+ Middle mouse button to pan
+ Added currentGameName() to get current hosted game name
+ { and } in askInteger don't crash anymore
+ Fixed temp cards moving crashing octgn
+ Whispering other players now more distinguishable
+ Sealed deck editor UI update
+ Games can now only grab cards from there own games

#3.0.1.22
+ Removed twitter feed and replaced with an xml file on the website.
+ Fixed a hosting bug.
+ Removed XML protocol from OCTGN
+ Quick fix for settings not saving.
+ Increased the login timeout for people with a bad connection
+ Can launch and connect to StandAloneServer using just the command line.

#3.0.1.21
+ Disabled sandboxing of python scripts.
 
#3.0.1.20
+ Fixed multiple instance of OCTGN message box always showing up.
+ Removed OCTGN Shortcut updater, as it caused crashes issues on weird machines.
 
#3.0.1.19
+ If multiple instances of OCTGN are running, prompts user if they want to kill them
+ If you log in, and another instance of OCTGN is logged in anywhere, it gets booted properly and doesn't create a never ending binding loop
+ Updates OCTGN links on the Desktop, Start Menu, Quick Launch, Pinned Task Bar, and Pinned Start Menu to point to the current install location on startup.
+ Unbroke offline games
 
#3.0.1.18
+ Changed the updater
+ Fixed some url's
+ Added auto build+release stuff for CruiseControl.net
 
#3.0.1.14
+ Fixed autoupdate bug.
+ 
#3.0.1.13
+ Fixed bug that caused load to hang

#3.0.1.12
+ Removed the split screen
+ Added help in file menu
+ Added automatic updating

#3.0.1.11
+ Make gamelist autorefresh
+ Arrange user list in lobby by name
+ Adding friends and chatting works again
+ User status fixed
+ Lobby is now opt-in

#3.0.1.10
+ Fixed another game install bug
+ Added game isolation(games are unaware of each other)
+ Added game uninstallation(select a game to get to the set listing and click remove game)

#3.0.1.9
+ Fixed install game bug

#3.0.1.7:
+ Minor boot changes
+ Lobby Sounds
+ Setup enhancements 

#3.0.1.6:
+ Changed .net framework requirements from full to client profile.
+ New server
+ Proper SQL query escaping for Deck Builder

#3.0.1.5:
+ Fixed font permission issue with UAC
+ New database rebuild table
+ Supports help.txt documents
+ Fixed deck editor display empty fields on a deleted game

#3.0.1.4:

+ Fixed hosted games not showing up
+ Fixed bug when switching filter
+ Optional custom font support

#3.0.1.3:

+ Problem with two OCTGN's open at once, booting eachother off fixed
+ Trim debug window so it doesn't overflow
+ Fixed up SimpleConfig
+ Chat topic can now be set by chat owners, and exists in Lobby chat
+ Remembers if you checked Two-Sided Table
+ Default game name, and remembers last game name
+ Announcements from server is now possible
+ Save password feature fixed
+ Game run time fixed
+ Games not refreshing fixed

#3.0.1.2:

+ Added option in File menu to disable installing sets/defs on startup
+ Fixed problems with installer(SQLite and others)
+ Fixed issue with pregame lobby not changing size

#3.0.1.1:

+ Catches errors when installing/checking defs/sets on startup
+ Fixed crash when OCTGN can't access news feed
+ Fixed memory leak in deck editor
+ Fixed deck editor crashes 
+ Fixed midgame crashes due to SimpleDataTableCache
+ Fixed ram usage issues


#3.0.1.0:

+ Chatting service seperated from game hosting service
+ Offline play added
+ More info about hosted games
+ Python error checking/catching in multiple places
+ Removed lots of dead code
+ New database using Sqlite
+ Added Game Rules window to play
+ Moved user settings to a settings file
+ No longer uses Google to authenticate
+ Huge amount of code cleaning/refactoring
+ GlobalVariables for game devs.
+ Headlines on login page
+ Offline messages
+ Fixed several UI bugs
+ Added About window and links on login page
+ Lobby reconnects on disconnect
+ Sub directory for sets
+ Can set custom data directory for octgn
+ Can now filter game list by game name
+ Clicking the preview image in DeckEditor flips cards
+ Hovering previews of cards with alternate images (hold alt key)
+ Fixed too many bugs to count.  Take a look at https://github.com/kellyelton/OCTGN/issues?sort=updated&direction=desc&state=closed

#3.0.0.3:

+ Moved user settings to the registry
+ Added "/developer" command while in game for python console
+ Added python console button in game
+ Changed some window titles
+ When exiting deck editor, it now asks you if you want to save your changes, if changes were made
+ When making a new deck, prompts you to save current deck if not saved
+ Added server messages, and timed server restart functions
+ Added status messages when logging in
+ Added server status to login page

**Fixed**:

+ Lobby Chat no user issue/can't host game
+ Issue where Octgn will sometimes run in background when closed
+ Lots of instabilities and random crash problems.
+ Username not carried through to game
+ Better checking of finished games
+ Problems selecting sets in the set list
+ Multiple windows issues
+ Fixed Log Off/Quit issues with windows
+ Removed AboutWindow in game

**Python**:

+ Added me.isActivePlayer
+ Added openUrl(url)
