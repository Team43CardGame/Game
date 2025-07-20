# Usefulness and Transition Report:
## Is the product complete? Which parts are done and which aren't done?
- Not complete. MVP3 is the last part for the current course.
- Done/Mostly Done (MVP3 goals):
- Mechanics of winning the game.
- Spell list.
- Trick of spells.
- Game installation (checked and working on Windows).
- Displaying the amount of cards during the game (player IDs are the amount of cards of other players).
- Ability to input IP address with numbers and letters (16 numeric system).
- Not Done/Needs Work (related to MVP3 and potential additions):
- Full implementation of three-card spells.
- Visibility of connected players in the game (currently only in console). Customer suggests adding "amount of players" to MVP3.
- Fixing the issue where a game can be created with only one player, and the game breaks in that scenario.
- "Auto-pass" functionality needs to be implemented and the instruction in the README file about "pass" should be removed.
- Ability to choose name for players (customer highly recommends moving this to MVP3 if not too difficult).
- Future MVPs (4 & 5) and associated features:
- MVP4: Tutorial (customer not sure if it's good for MVP4, maybe MVP5), custom avatars, sound design (customer not sure if MVP3 or MVP4, but animations are better for MVP3).
- MVP5: Android port (originally thought to be done faster, but now agreed for MVP5), matchmaking, skins for cards/table, list of available lobbies (customer questions its usefulness without online mode and IP input).
## Is the customer using the product? How often? In what way? If not, why not?
- Yes, the customer (Timofey) is using the product. He checked the installation and confirmed it's working. He plans to use it to test mechanics for his board game idea, to experiment with the code as a base, and for future playtests as an easier alternative to a physical card deck. The frequency isn't specified but implies ongoing use for testing.
## Has the customer deployed the product on their side?
- The product is a local game, not a website or service that requires typical deployment. The customer has downloaded and installed the game files on his local Windows machine and confirmed it's working.
## What measures need to be taken to fully transition the product?
- From the discussion, the "transition" seems to be less about a formal handover and more about the project being usable and meeting the customer's immediate needs for testing. The key measures are:
- Completing the core mechanics for MVP3 (three-card spells, win mechanics, spell list).
- Implementing the suggested user experience improvements for MVP3 (visibility of connected players, ability to choose name if feasible).
- Fixing the game's behavior when only one player is present.
- Addressing the "auto-pass" instruction in the README.
- The customer confirmed he has the files and they work, and he plans to use them.
## What are the customer's plans for the product after its delivery? Are they going to continue working on it? Would they like to continue collaborating with the team and on what conditions?
- Customer's plans: The customer plans to use the product as a base to test mechanics for his board game idea, for experiments, and for future playtests. He sees it as a much easier way to test than using a physical deck of cards.
- Continue working on it? The customer states he is "sure that I will use this project later."
- Continue collaborating with the team? The customer is open to continuing collaboration if the team wants to "polish this game, add some new mechanics and so on." He acknowledges that it might involve more game design work than programming at that stage.
- How to increase the chance that it'll be useful after the final delivery?
- By ensuring the core mechanics are fully implemented and stable (e.g., full three-card spells).
- Improving user experience features like visible connected players and player names in MVP3, as these directly enhance its utility for testing.
- Fixing critical bugs like the single-player game state.
- Providing a stable and easily runnable build, which seems to be the case based on the customer's feedback ("it's working, it's fine").
- The customer's existing plan to use it as a testing ground already indicates its usefulness.
Customer feedback on your README (go through it together at the meeting):
## Is everything clear? What can be improved?
- Clarity: Generally clear. The customer mentions the "game installo" typo, which needs fixing.
- Improvements:
- Fix the typo "game installo" to "game installation."
- Remove the "pass" instruction if auto-pass is implemented.
- The customer questioned if "documentation link" and "information about development" should be in the README, but accepted it since it was a task assignment.
- The customer also questioned if "roadmap" should be in the README, but accepted it for the same reason.
- The customer suggested adding a button for game rules within the game itself, rather than a link in the README, as the game is "very easy."
## Are they able to launch/deploy using your instructions?
- Yes, the customer confirmed: "Let me extract files, and I will check just that it's working. Unity Player DLL, how to launch game. You have this file. Okay, it's working. It's fine."
## What two other sections the customer would like to be included in the ReadMe?
- The customer did not explicitly ask for two new sections to be included. When asked by Egor, he stated, "I don't think that... As I said, README file could be very different. You already have README file, I think. Right now. You have instructions, you have everything. Installation? I'm not sure. Do you really need to add something? Fix something? Yes. Add something? Not sure. Probably not."
- However, during the discussion about "game rules," Egor asked if a link for game rules should be added. The customer suggested adding a button within the game itself for rules, not in the README.

# Meeting Transcript
- Egor: Hello.
    
- Customer - Timofey: Wait a second, please. I'll check the connection. What's wrong with my internet? Second, please.. Okay. I'm not sure but it's works
    
- Egor: The meeting is recording. It's okay?
    
- Customer - Timofey: Yes, it's okay. Okay, again, three seconds, please. I will open your GitHub readme file. It will be easier to discuss. I think you will edit the recorded file. So, what's your task? I don't really get it because we can read every point here, but I'm not sure if it's convenient or not because some of the project goals, stakeholders, and so on isn't really needed for the discussion, as I see.
    
- Egor: You need just to read the file, show that you read it somehow, and make corrections, maybe some details.
    
- Customer - Timofey: Okay. Okay. I'm not sure how is more convenient way to say it. I see only one thing that you should, I'm not sure, edit or just you can add one, I'm not sure, three-card spell implementation in the MVP3. You can mark it. As I remember, on the meeting, you already showed me that you have done it, three-card spells.
    
- Egor: Not fully.
    
- Nikita: No, not all three-card spells
    
- Customer - Timofey: What is it? Probably it's my language issues, but "game installo", what is it?
    
- Egor: Maybe it's typo
    
- Customer - Timofey: Probably, yes. Because after that, you have game installation. Okay. I think you should fix it. Okay.
    
- Egor: Let me check. Maybe you want that we add something in readme file.
    
- Customer - Timofey: Readme file, it's very, very specific document. It can be very small, it can be very big. I'm not sure what should you add to it. Because for now, but okay. Let me check. It's downloaded, current game multiplayer. Let me extract files, and I will check just that it's working. Unity Player DLL, how to launch game. You have this file.
    
- Customer - Timofey: Okay, it's working. It's fine. And that, and the file, of course. Run it anyway. Okay, it's working. It's fine, it's working.
    
- Customer - Timofey: Did you change anything from our last meeting in the code?
    
- Egor: Yes, we did. Yes.
    
- Customer - Timofey: What have you done?
    
- Egor: Oleg is typing in chat.
    
- Customer - Timofey: Oleg is typing, okay.
    
- Customer - Timofey: Okay, it's fine, it's fine. I will read it later. The amount of cards show up during the game. Player IDs are the amount of cards of other players.
    
- Egor: Yes
    
- Customer - Timofey: Okay, great. I can check it right now... It's very, very fine. Okay, I'm not sure. Documentation link, you already have it. Your information about development also, I'm not sure. Should it be part of the readme file? Probably not.
    
- Egor: It is the task assignment that it should be in the file.
    
- Customer - Timofey: If it's your task... If you ask to add it to the readme file, okay. Just because... Usually in the games you just don't have such thing in the readme file. But if your TA says that you should add it, okay. Roadmap also. Again, roadmap is usually not part of the readme file. But if you should add it, you should add it. I can't change anything.
    
- Egor: What about MVP 4 and 5? Oh, yes. We need to discuss what... Sorry, I'm... You can continue.
    
- Customer - Timofey: Okay, okay. I finished. Continue, please.
    
- Egor: We need to discuss about our plans in future. Are we going to continue with this project and this stuff? And for this we create MVP 4 and 5. And you can check it. Just in case if you won't continue and someone also won't.
    
- Customer - Timofey: Okay.
    
- Egor: Because it's also part of assignment.
    
- Customer - Timofey: Yes, I understand. Look, that... For the MVP 3... Of course, mechanic of the win the game, spell list... Trick of spells. It's the part that should be done. You can't play without it. Of course. Ability to choose name. I think, yes. For the MVP 4. Tutorial, I'm not sure...
    
- Egor: You have some problems with connection.
    
- Customer - Timofey: But it's... You should add. Only... I'm not sure. Is it good for MVP 4? Probably best for MVP 5. Tutorial. Custom avatars... With ability to choose name. I think it can be... I can't hear you. I just hear... Please write in the chat. Thank you. Okay. Okay. Problems with connections. I understand. Sound design for MVP 3. Again, I'm not sure... I'm not sure it's good for MVP 3 or for the MVP 4. Because animations is better for the MVP 3. Because you should see what's going on the table. What actions was... Was done. But sound design for the MVP 3, I think, will be enough. Done all the mechanics to normally play the game. And animations. Better experience. For the... List of available lobbies. Again, I'm not sure... Do you really need it... Without online game mode. Because... How often you will have different lobbies in the... Different lobbies on the local network. And without ability to... Without ability to get the IP. Because you have host... And host can share his IP. But... What I think you should add. I think we already discussed it. Type some numbers with dots. Is not very good user experience. Is better to somehow convert it to the... Letters.
    
- Egor: Oh, will convert it in 16 numeric system. It will be numbers and Letters.
    
- Customer - Timofey: Okay. Okay. Okay. You should add it
    
- Customer - Timofey: We have it already. It's very good. And I think you should add it to the MVP3.
    
- Egor: Okay, we already have it.
    
- Customer - Timofey: MVP3, I think. It's... You already saw and see in the console that some players connected to you. But in the game I can't see it. So I think you should add it to the MVP3 that you can see that player connected to you. Amount of players, at least. Because ability to choose name you can add it to the MVP4 but at least amount of the players that connected. I think you should print now. No, now.
    
- Egor: Okay.
    
- Customer - Timofey: At the MVP3. Game installation. Okay, okay. I have Windows, so I checked it. It's working. How to play? I already read it. Read it. No, it's fine. I don't have any questions to it probably. Oh, okay. Again, the thing that you should correct that auto-pass. I think we already discussed it.
    
- Egor: Yes.
    
- Customer - Timofey: But here in the instructions you also have pass. I think if you fix it, you should delete it here just because you will not need to pass.
    
- Egor: Yes.
    
- Customer - Timofey: Quality-proof automations. Should I check it? Just because I'm not sure again.
    
- Egor: I'm also not sure. If you want, you can.
    
- Customer - Timofey: Okay, I can. Quality characteristics. I think it's for your TA, for your assignment, not really. What?
    
- Egor: Yes, It was part of your assignment.
    
- Customer - Timofey: Oh, okay. Again, if it's part of your assignment, I think I don't have any questions. Unit tests. Integration tests again. Oh, and.. I'm not sure I understand that now you have Android ports on the MVP5. For the online game. it's not very good, but I think if we are realistic, it's fine for the MVP5, but I was thinking it will be done faster. But now in the current situation, I agree that Android port is fine for the MVP5, but for the project at all, meh. As I understand, MVP... If I understand correctly, MVP5 is the part that you say that we will do it in the future after final demonstration.
    
- Egor: Yes, if work on the project will continue.:
    
- Customer - Timofey: Okay, yes. MVP5. And MVP4?
    
- Egor: Too. MVP3 is the last one for this course
    
- Customer - Timofey: Okay, MVP3 is the last one, okay. So, what you should add? You said this thing? So... Is it really hard to... Do ability to choose name? Because if... If it's not very hard thing, I think you should add it to the MVP3, just because it will be much, much better than see just amount of the players. It will be much better for user experience. Without avatars, just ability to to choose name. If you can add it, add it. I think you can edit readme files to look on your progress.
    
- Egor: Yeah.
    
- Customer - Timofey: If you add it. The ability to name.
    
- Egor: We will try.
    
- Customer - Timofey: So, I hope you can move it to MVP3.
    
- Customer - Timofey: But, Matchmaking, skins for cards, table. And list of available. Available, we already discussed. So, fix the table. Fix the roadmap. External systems. I'm understand that you don't have anything now. It's fine. Because we discussed local host game.
    
- Egor: In the future, of course, we will have some servers for online game.
    
- Customer - Timofey: Of course, in the future, if we will have online mode, we will have some servers and this stuff.
    
- Customer - Timofey: Yes, I understand. My question is: Have you find something that you can use in the future? Okay, when we will do it, we will use this service or something like that. Do you have some?
    
- Egor: We didn't think about it before.
    
- Customer - Timofey: You didn't. Okay, okay. It's fine, it's fine. You've done local host game. It's fine that you didn't start it. Just because if you already seen something, you could add it just for the online. We will use or something like that. Because your game doesn't use anything. You're right about it. Again, target audience, is it part of your assignment?
    
- Egor: Yeap.
    
- Customer - Timofey: Okay. That's because I'm not sure. For the target audience, in practice, it's question for whom, for who you... I forgot the word. Distributed. What is your target audience? But if you... Or any communities that use local network. Okay. I just read. University. So, I think it's fine. One thing is that, you have great multiplayer goals. Create a multiplayer, at least local game, game for three - six players. Right now, I can proceed when I host. And I'm only one player. I can create game with only one player. But you should fix it, that without players, you can't create game. And also, as I see, the game is also broken when I create the game, when I'm only one player. I'm still the player, but I cannot do anything. Something strange. So, you also should fix it. Do you have any questions or anything that I should say about your project, about your README file?

- Egor: You need provide maybe two, some sessions in README file that you want to see. I want to see... What you can add in README file, if you want.
    
- Customer - Timofey: I don't think that... As I said, README file could be very different. You already have README file, I think. Right now. You have instructions, you have everything. Installation? I'm not sure. Do you really need to add something? Fix something? Yes. Add something? Not sure. Probably not.
    
- Egor: Do we have game rules in README file, something for it? Really no. Do we have, as I checked, no link for game rules in README file? I for some reason forget about it. Do we need to add it in README?
    
- Customer - Timofey: It's something with my connection. Can you write it in the chat? Sorry. I heard that you asked me, do we need to add something? Game rules? Game rules... I'm not sure that it should be part of the... Oh, let me check. You have spell list. You will have a spell list in game. I think it will be better just to add small window, not in the README file.
    
- Egor: I can just add a link for game rules
    
- Customer - Timofey: Because you already have instructions how to play. You already have instructions how to play. Game rules, I think you don't know. You don't need to add it. Just because we have very easy game. Let's imagine that you have very, very, very big game. Do you really need to write in the README file all the rules? I think no.
    
- Egor: Of course.
    
- Customer - Timofey: I think no.
    
- Egor: Okay.
    
- Customer - Timofey: In the window, when you can press play, you can also add button rules. It will be much better.
    
- Egor: We will add it. Okay.
    
- Customer - Timofey: As I know, it's very easy.
    
- Egor: We need to know about your plans for this project in future.
    
- Customer - Timofey: My plans for the project? Okay. I already seen your code. Exactly. My plans, I want to test some mechanics on it because you done some three-card spells, but without four-card spells, I think at least I will try to imagine some new... I will experiment with it. It was initially my idea of board game. But when you have ability to check it this way, I think it's much, much easier. I think I will test some mechanics with your code. Just take it as a base. At least we'll do some experiments.
    
- Nikita: No. What about your global plans on the product? Do you going to continue work on it?
    
- Customer - Timofey: I'm not sure will I... Online part. because as I said local was enough for me just because I needed such game just for testing some mechanics and so on. The most important part for me was at least local host part and that spells normally created drop and drop mechanics and so on. It was the most important part that you have done. Now with it you can improvise with it. So I'm sure that I will use this project later, but probably I will test it for the real board game. Because as I said initially it was idea of the real board game.
    
- Egor: Understood.
    
- Customer - Timofey: For the future playtests it will be much easier. You will not grab a deck of cards but just please install it. Is it enough?
    
- Customer - Timofey: The last question I think it's not it wasn't said. Would you like to continue collaboration with your team? What conditions?
    
- Customer - Timofey: Again I'm not sure what I think. What kind of collaborations? Because your team now exists for this course. If you will continue do some games of course but I'm not sure what kind of collaborations.
    
- Egor: Continue work at this game with us.
    
- Customer - Timofey: Continue work on this game? Yes. If you really want to continue work on this game I think I can.
    
- Egor: Now we need to ask the team if team wants.
    
- Customer - Timofey: Yes I understand of course but if you if you really want to polish this game add some new mechanics and so on I think it's much more work for game designer than for programmers, probably
    
- Customer - Timofey: But in general, yes Any questions?
    
- Egor: We need to say, is product deployed on your side, but it's not our case, because we have an local game
    
- Customer - Timofey: Yes, it's not a site or something
    
- Egor: I have no questions, as i believe. so we can end
    
- Customer - Timofey: Okay, good bye, have a nice day
    
- Egor: Good bye, you too
    
- Nikita: Good bye
    
- Muhammad (in chat): Good bye
    
- Ekaterina: Good bye
    
- Yaroslav: Good bye
    
- Oleg (in chat): Good bye

  
# Audio [Link](interview.mp3)