# Epic Battle of Epic Mages - Online Card Game
---

![[Logo.png]]

- Game for 3-6 players, where you can create spells from 3 colors cards and cast them
- [Actual version of game]((https://github.com/Team43CardGame/Game/tree/main/MVP2))
- [Link to Demo Video](https://disk.yandex.ru/d/6V6_0WVCYTa-lw)
# Projects Goals
---
- Create a multiplayer (At least local game) game for 3-6 players, that will be interesting and enjoyable to play
- Make the game pleasing to the eye through visual design
# Project Context Diagram
---


# Roadmap
---
- [X] MVP 0
	 - [X] Main scene of the game
	 - [X] Mechanic of turns
	 - [X] Hot Seat game mode (Timely solution)
	 - [X] Simulation of spell casting
- [X] MVP 1
	- [X] Local game mode for 2 players
	- [X] Simple main menu
- [X] MVP 2
	- [X] Local game mode for 3 - 6 players
	- [ ] 2 cards spells implementation
- [ ] MVP 3 
	- [ ] Mechanic of winning the game
	- [ ] Main menu
	- [ ] Spell list in game
	- [ ] 3 cards spells implementation
	- [ ] Sound design
	- [ ] Animations
 	- [ ] Drag and Drop mechanic
# Game Installation
--- 
1. To download the archive of game click: [Dowload the Game](https://downgit.github.io/#/home?url=https:%2F%2Fgithub.com%2FTeam43CardGame%2FGame%2Ftree%2Fmain%2FMVP2)
2. Unzip by any method, for example on windows, **RMB** to archive **MVP2.zip**, in list chose **Extract all** and chose place for it (don't matter)
3. Open the directory **MVP** and double click **LMB** on **CardGameMultiplayer**, the game will be lauched
4. Also in the directory you can find **HOW_TO_LAUCH_GAME.md** with similar instruction
# Usage insructions - How to play
---
1. Click **START** button
2. 1 player must click **Host Game**, all other players should click **Join Game**
3. If you are **Host**, share your ip with other players, for it go in **cmd** and write `ipconfig`, find field **IPv4-adress** and share this ip with other players
4. If you are **Joined player** write the received IP address in the field **IP** and click **Join**
5. When all players are connected, **Host** can click **Proceed.** to start the game
6. From this point the game is actually started
7. Players turns goes one after another, in your turn you can place the card **LMB** to card in your hand and **A** or **D** to place the card in left of right part if the spell respectively and click **Pass** to pass the turn
8. When you have 2 cards in the spell, you can click **Cast** button to cast the spell with unique effect and then click **Pass** to pass the turn
9. In this way game is playing, now there is no finish game mechanic, so for exit press **Alt + F4** at keybord, this is all for now
# Documentation [Link](docs)
---
## All information about development in [This File]()
- Link to [Kandan board](https://github.com/orgs/Team43CardGame/projects/6)
- Git workflow
- Secrets management
## Quality proof
 - [Quality characteristics and quality attribute scenarios](docs/quality-attributes)
 - [Automated tests](docs/quality-assurance/automated-tests.md)
 - [User acceptance tests](docs/quality-assurance/user-acceptance-tests.md)
## Build and deployment automation
 - [Continuos Integration](docs/automation/continuous-integration.md)
 - [Continuos Deployment](docs/automation/continuous-delivery.md)
## Architecture 
 - [Static view]()
 - [Dynamic view]()
 - [Deployment view]()
 - [Tech Stack](docs/architecture/architecture.md)
## [Changelog](Changelog.md)
## [LICENCE]()
