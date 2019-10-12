# Yackeen Solutions Blog
 

Simple Blogging System Using Asp.Net MVC and SQL Server as a DB Storage


### Up and Running

* Download or clone this repository to your local machine. 
* Open the solution in your favourit text editor and change the connectionstring to your local server
* Build the solution and that's it, you are ready to go.

* To avoid compiler directory error run this in the nuget package manager console
	```Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r```

* The Nuget Package Manager will restore all the neccessary packages and EF will execute all migrations
  to bring the database to the latest state.
* I've seeded some initial data to make it easy to start using the application.

* You can register a new user and experience the application as a visitor or you can login with admin account
	```email:admin@app.com  pass:P@ssw0rd```
