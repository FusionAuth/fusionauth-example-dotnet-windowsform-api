# Example Windows Forms Application Using FusionAuth APIs

## Considerations
- This is a sample Windows Form application utilizing the FusionAuth APIs in C#.
	- This does not run on Visual Studio for Mac.
- This is a sample application written for a blog post that utilizes the FusionAuth APIs.

## Setup
- You will need a working version of a FusionAuth Server to point the application to. 
	- In the root directory of this repo you'll find a Docker compose file (docker-compose.yml) and an environment variables configuration file (.env).  Assuming you have Docker installed on your machine, you can stand up FusionAuth on your machine with:
		```
		docker-compose up -d
		```
		- The credentials for the instance:
			- Url: 	[http://localhost:9011](http://localhost:9011) 
			- Admin Username: admin@example.com
			- Admin Password: password
			  
		> **_Note:_** If you ever want to reset the FusionAuth system, delete the volumes created by docker-compose by executing docker-compose down -v, then re-run docker-compose up -d.

	- See [How to Run FusionAuth](https://fusionauth.io/docs/) in the FusionAuth documentation for alternatives.
- If you are using the docker image associated with this project, you should not have to update anything.  However, if you are using another instance of a FusionAuth you will need to update the `App.config` file to work with your environment.
	- FusionAuthUrl is the location of the FusionAuth instance you are running.
		- This will be [http://localhost:9011](http://localhost:9011) if you are running the docker image above. 
	- FusionAuthAPIKey is the API key for the instance .
		- See [Managing API Keys](https://fusionauth.io/docs/v1/tech/apis/authentication#managing-api-keys) in the FusionAuth documentation if needed.

## Usage
Once the `App.config` settings are configured correctly the application will be able to connect to the FusionAuth server specified.  

This application can do 3 things.

- Create User
	- Enter the user information for the user and click the `Create User` button.
		- The user info has been pre-populated and can be changed
- Delete User
	- Click the `Populate Users` button to fill the combo box with users.
	- Select a user.
	- Click the `Delete User` button.
- Add a user to Group
	- Click the `Populate Users and Groups` button to fill the combo box with users.
		- You will need to create groups in the FusionAuth Admin Interface before they will populate in the application.
	- Select a group you want to add the user to and then select a user.
	- Click the `Add User to Group` button.

Screenshot:

![Windows Form Demo Screenshot](https://github.com/FusionAuth/fusionauth-example-dotnet-windowsform-api/blob/main/img/FusionAuth%20User%20API%20Demo.png "Screenshot")


