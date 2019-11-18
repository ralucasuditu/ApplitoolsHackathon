# ApplitoolsHackathon

This is a solution written in C#.
In order to open it you need Visual Studio > 2017. Just open ApplitoolsHackathon.sln.

The solution is using page-object design pattern.

'Pages' folder contains:
- the definition of the elements in the Login/Main Page: Pages --> Login.cs and Pages --> MainPage.cs
- driver declaration: Utils --> Driver.cs
- setup/teardown functions: Utils --> Start.cs

The tests are grouped in 2 folders:
- tests that are using the 'clasical' way for running tests with selenium web driver (tested applition = V1): ClasicalTests
There are 5 files for each exercise: ClasicalLoginTests_1.cs, ClasicalDataDrivenTests_2.cs, ClasicalTableSortTests_3.cs, ClasicalCanvas_4.cs, ClasicaldynamicTests_5.cs.

- tests that are using 'applitools'  (tested applition = V2): ApplitoolsTests
There are 5 files for each exercise: ApplitoolsLoginTests_1.cs, ApplitoolsDataDrivenTests_2.cs, ApplitoolsTableSortTests_3.cs, ApplitoolsCanvas_4.cs, ApplitoolsDynamicTests_5.cs.

In order to run the ClasicalTests tests, "<add key="BrowserType" value="chrome" />" value should be set in the app.config
In order to run the Applitools tests, "<add key="BrowserType" value="eyes" />" value sould be set in the app.config.y


Enjoy!
