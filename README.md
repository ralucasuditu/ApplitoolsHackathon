# ApplitoolsHackathon

This is a solution written in C#.
In order to open it you need Visual Studion > 2017. Just open ApplitoolsHackathon.sln.
The solution is using page-object design pattern.
'Pages' folder containes
- the definition of the elements in the Login/Main Page: Pages --> Login.cs and Pages --> MainPage.cs
- defines the driver declaration: Utils --> Driver.cs
- setup/teardown functions: Utils --> Start.cs

The tests are grouped in 2 folders
- tests that are using the 'clasical' way for running tests with selenium web driver (tested applition = V1): ClasicalTests
- tests that are using 'applitools': ApplitoolsTests

In order to run the ClasicalTests tests, <add key="BrowserType" value="chrome" /> value should be set in the app.config
In order to run the Applitools tests, <add key="BrowserType" value="eyes" /> value sould be set in the app.config.y

Enjoy!
