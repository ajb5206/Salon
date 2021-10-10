## README for Independent Project #9

# Eau Claire's Salon Database

#### Welcome to the Salon database!

#### **By Alex Bertotto**
#### Table of Contents

1. [Technologies Used](#technologies)
2. [Description](#description)
3. [Setup/Installation Requirements](#setup/install)
4. [Known Bugs](#knownbugs)
5. [License](#license)
6. [Contact Information](#contact)

## Technologies Used <a id="technologies"></a>

* ASP.NET Core
* C#
* EntityFrameworkCore
* Microsoft NET 5.0
* MySql
* MySqlWorkbench
* MVC
* Razor View Engine
* Visual Studio Code

## Description <a id="description"></a>

Welcome to the Claire's Database. Create a database of stylists and their respective clients. 

## Setup/Installation Requirements <a id="setup/install"></a>

1. Clone the project to your current directory using the following command: git clone https://github.com/ajb5206/Salon
2. Navigate to the project folder in the command line
3. Run the command _`dotnet restore`_ to install the packages listed in the _`.csproj`_ file 
	 as well as creating the _`obj`_ file
4. Run _`dotnet build`_ to create internal content including the _`bin`_ file
5. Ensure that your MySql server is running by opening Terminal and entering _`mysql -u[YOURID] -p[YOUR-PASSWORD]`_
6. Open MySql Workbench and click on the MySql instance in the MySql Connections section
7. In the Navigator>Administration window of MySql Workbench, select Data Import/Restore
8. In import Options, select Import from Self-Contained File and navigate to the sql file located in the root directory of the project
9. If you wish to change the name, under Default Schema to be Imported To, selec the New button and enter a new name, click okay
10. Click on the Import Progress tab and click Start Import
11. After refreshing all in the Navigator, the database will appear
12. Add an _`appsettings.json`_ file to your root directiory
13. Set your connection string to _`"Server=localhost;Port=3306;database=[YOUR-DATABASE-NAME];uid=[YOUR-USER-ID];pwd=[YOUR-PASSWORD];"`_
14. Run `dotnet run` and navigate to `localhost:5000` to see the tracker in action

## Known Bugs <a id="knownbugs"></a>
* Redirects to the index view when attempting to add a client while no stylists have been added

## License
Copyright <2021> <MIT>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

_If there are any issues or have questions, ideas or concerns, please feel free to contact me or make a contribution to the code._

## Contact Information <a id="contact"></a>
#### Alex Bertotto ajb5206@gmail.com 
#### https://github.com/ajb5206