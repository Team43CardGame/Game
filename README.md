🃏 Card Game – Multiplayer Spell Casting Game
A local multiplayer card game. Players use combinations of colored cards to cast spells that can attack, defend, or trigger special effects. The project was built with a strong focus on usability, performance, and incorporating real-time customer feedback.

🚧 Development
Kanban Board
We used a GitHub Project board to track the progress of our development during Sprint 5.

🔗 Kanban board link

Columns and Entry Criteria:
No Status: Default state for new issues or items.
To Do: Approved issues that are ready to begin.
In Progress: Tasks a team member is actively working on.
Ready to Deploy: Feature or fix is complete and ready for deployment/testing.
Done: Task is tested and verified as working.
Git Workflow
We followed a simple GitHub workflow suitable for small student teams.

No pull requests were used.
We used issues to track features, bugs, and tasks.
Most changes were pushed directly to the main branch.
Commit messages followed basic clarity and intent (e.g., fix: card color bug, feat: spell casting logic).
Future improvements could include:

Consistent branch naming (e.g., feature/, bugfix/)
Conventional commit style
Pull request reviews
Secrets Management
There are no secrets, API keys, or sensitive information used in this project.

✅ Quality Assurance
Quality Attribute Scenarios
📄 View scenarios here: docs/quality-assurance/quality-attribute-scenarios.md

We focused on the following three sub-characteristics from ISO 25010:

✅ Usability
Why it matters: If the gameplay is confusing or frustrating, players won’t enjoy the experience.
How we improved: We incorporated suggestions directly from the customer to improve flow and layout.
How we tested: Manual tests and customer feedback loops.
✅ Reliability
Why it matters: Game behavior must be predictable and consistent.
How we improved: Fixed gameplay issues based on user requirements and corrected logical errors.
How we tested: Used scenario-based testing with the customer’s use cases.
✅ Performance
Why it matters: Lag or bugs reduce playability and user engagement.
How we improved: Addressed performance bottlenecks and bugs during development.
How we tested: Team and customer playtests to check responsiveness and card action timing.
Automated Tests
🧪 This section will be updated once our teammate finalizes the testing setup.

User Acceptance Tests
📄 View all acceptance tests here: docs/quality-assurance/user-acceptance-tests.md

MVP v2 User Testing
✅ Passed tests for improved menu navigation, casting logic, and card drawing
🛠 Requested improvements for:
Spells using three-card combinations
Visual effects when spells are cast
🚀 Build and Deployment
Continuous Integration
We did not use a CI/CD pipeline. All development, testing, and builds were handled manually by team members.

🏛 Architecture
Static View
📄 See: docs/architecture/static-view/

The architecture consists of modular components:

Game controller (handles card logic, state changes)
UI component (menu, card display)
Player and Game session handler
We focused on:

Low coupling: Individual modules can be modified without breaking others
High cohesion: Each module performs a specific, focused function
This improves maintainability and allows for future extension.

Dynamic View
📄 See: docs/architecture/dynamic-view/

Scenario: Player joins and casts a spell
User selects “Join Game” from the main menu
Game session connects via local network
Player is dealt 8 random cards of 3 colors
Player places 2 cards on the table
If combination matches a spell, it's cast
The game engine applies effects to the target(s)
⏱ Execution time: Instantaneous (less than 1 second)

Deployment View
📄 See: docs/architecture/deployment-view/

The game is run locally for now.
Deployed manually for customer testing.
Local LAN multiplayer supported (no cloud/server hosting yet).
🧪 Usage Instructions
💡 MVP v2 is available for manual playtesting.

To run the game:

Clone the repository:
git clone https://github.com/Team43CardGame/CardGame.git

## How to launch game:
- **1.** Use Windows OS.
- **2** If you didn't download directory with game( name: "MVP2"), and read this file if browser, you need to download this directory.
- **2.** Look at directory "MVP2", study files, check if number of directoryes inside is 4, number of .exe files is 2, number of .dll file is 1, and one file with instruction(such you read now). If numbers is equals, then directory was downloaded correctly, and you can continue.
- **3.** Find "CardGameMultiplayer.exe"
- **4.** Double-click the left mouse button on the file. After this the game will start itself.
