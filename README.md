# tau-intro-to-selenium-webdriver-with-net-core



SeleniumCoreVSCode

Creating a solution
```
mkdir SeleniumCoreVSCode
cd SeleniumCoreVSCode
dotnet new sln
```

Creating unit test project
```
dotnet new mstest -o SeleniumCore
```

Adding project to the solution
```
dotnet sln add SeleniumCore\SeleniumCore.csproj
```

Adding selenium libraries
```
cd SeleniumCore
dotnet add package Selenium.WebDriver --version 3.141.0
dotnet add package Selenium.WebDriver.ChromeDriver --version 77.0.3865.4000-beta
dotnet add package DotNetSeleniumExtras.WaitHelpers --version 3.11.0
```

Building and running tests
```
dotnet build
dotnet test
```