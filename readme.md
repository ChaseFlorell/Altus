##My answers to the Altus Challenges##

**Code Challenges**

 - All technical answers are written in C# and are contained in the [[src](https://github.com/ChaseFlorell/AltusTest/tree/master/src)] directory.  
    - The quickest way to see it all work is to git clone this project and run the `build.ps1` from your powershell console.
       - From there you will see all 25 tests pass, and both console apps will be located in the `build-artifacts/output` directory.
          - AltusTest.ConsoleApp.exe
          - AltusTest.ConsoleDraw.exe
 - All answers are proven using Tests based around the criteria examples, and the tests are run on a CI server, and the build status is reported here: [![Build status](https://ci.appveyor.com/api/projects/status/82el0dug2ysnosjl/branch/master)](https://ci.appveyor.com/project/ChaseFlorell/altustest/branch/master)  
    - Challenge 1 is proven in tests under [Unit/BinaryTests](https://github.com/ChaseFlorell/AltusTest/blob/master/src/AltusTest.Tests/Unit/BinaryTests.cs), but doesn't have an accompanying console app.
       - This will thow custom exceptions if the user tries to enter a number higher than 100 or lower than 1.
       - This will thow a FormatException if the user tries to verify an invalid string as binary.
       - This also has a Binary Validator method that is designed to validate that the original method output the appropriate binary.  
    - Challenge 2 is proven in tests under [Unit/StringChangerTests](https://github.com/ChaseFlorell/AltusTest/blob/master/src/AltusTest.Tests/Unit/StringChangerTests.cs), and is also accompanied with the [ConsoleApp](https://github.com/ChaseFlorell/AltusTest/blob/master/src/AltusTest.ConsoleApp/Program.cs)
       - Notice this challenge is leveraging **Dependency Injection** and the **Chain of Responsibility** pattern.
    - Challenge 3 was a little vague to me, but is proven to the best of my understanding in tests under [Unit/DrawingTests](https://github.com/ChaseFlorell/AltusTest/blob/master/src/AltusTest.Tests/Unit/DrawingTests.cs), and is also accompanied with the [ConsoleDraw](https://github.com/ChaseFlorell/AltusTest/blob/master/src/AltusTest.ConsoleDraw/Program.cs) app.
       - I decided to take on the bonus challenge and allow it to take both a pre-set shape AND a shape that the user can define in the console. 
          - It throws custom exceptions if the user asks to draw an invalid shape
          - It is accompanied with an Extension Method to change any user input string to `Title Case` to ensure the parser can parse their input without them worrying about case sensitivity.

-----

**SQL Challenges**

Please follow [this link](https://github.com/ChaseFlorell/AltusTest/tree/master/sql) to see the answers to the sql challenges.

-----

**Non-Technical Questions**

 - In your opinion, what are the most important elements of making quality software? 
 
> I think the most important elements of quality software begin with a great team who has a clear understanding of spec and scope. From there a solid and agreed upon architecture that all team members will follow. Your work-flow should include distributed source control, and continuous integration. Code should be well tested, and the CI server should run those tests on every build for every branch. Failing builds will never be merged into Master. Your development team should be diversified between both great developers and great UI/UX experts. You can have a great product, but without a great user experience, your product will not appease your end users.

 - In your opinion, what are the most important traits in a good development team?
  
> As stated above, the team should consist of both programmers/developers and user interface/user experience experts. The team should spend time each day (stand-up) discussing goals and daily sprint targets. Bonding is equally important, go out for beers after work once in a while and get to know each other on a more personal level. All team members should be willing to have their code reviewed, and throw entire chunks away if necessary. Lastly, occasional pair programming is a great way to both bond with your fellow developers, and produce quality software (two pairs of eyes can be better than one.).
  
 - From a high level, describe your understanding of what a software development process is and its cornerstones.

> A software development process is the agreed upon process in which a development team will approach their product. Much like unit testing, it's the breaking down of work into units of work in order to better manage the completion of a product. There are several different approaches to the process of developing software, and the process I'm most familiar with in the Agile methodology. Agile leverages TDD (Test Driven Development) and CI (Continuous Integration) to allow a team to make rapid releases and changes to their product. The front end setup of a project can be laborious (setting up the CI server, SCRUM boards, tests, etc) but the payoff can been seen quickly as a product begins moving down the pipeline.
 
 - What is the role of testing in a development team? 

> Testing should be a foundation on which a product is built. This allows bugs to be caught early and often. There should be both code tests and hallway usability tests. Code tests should be written first in order to build up the API, and then the methods are implemented on top of it. Tests should equally be written after the fact when corner-cases are discovered and need to be fixed. Hallway usability tests are simply passing the product over to a co-worker to get their opinion on how a product is functioning as a whole.

 - In your opinion, what are code reviews, unit testing, and continuous integration? What role do they play in software development positively or negatively, when, and how are they used. Express your ideas as you see fit. 

> Code reviews are peer reviews whereby ones code is reviewed by another to ensure consistency and quality. When staring at a problem or project for too long, one can be immersed and not see some issues at a higher level. This is equally valid when it comes to pair programming. 

> Unit testing is one part of the full array of testing that should be done on software product. Unit testing is the testing of each unit of code in isolation... it helps ensure that one single piece of code functions as expected and will do so when integrated into the larger product. Some of the other tests that are equally as valid are Integration Tests, Functional Tests, and Acceptance Tests.

> Continuous integration is my favorite. Having an automated system in place to take a software product, run it through a battery of tests, and then package it for deployment without the need for developer interaction is just gold. Every commit of every branch being tested and built, archiving every release along the way. Then to have another automated system available to deploy your product to production with little to no effort (think [Octopus Deploy](https://octopusdeploy.com/)), keeps your public software current on a more frequent bases. Instead of semi annual releases, you can move to monthly, weekly, or even daily releases without worry.
