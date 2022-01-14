# VehicleTracking

The solution will track vehicles position using GPS navigation. A device emboarded in a vehicle, will communicate with this API to register the vehicle 
and update its position.
The solutions use the following framework:
? .Net 6.0

## NuGet Packages Used

Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer
MediatR
AutoMapper

## Performance

The performace of the application is ensured by the implementation of 3 things mainly.

	- CQRS Pattern
	- Mediator Pattern
	- Async/Await in Data manipulation

## Database / scalability

There is 2 Table; one is trackingCurrent and another one is trackingHistory. TrackingCurrent will only hold current days data.
Each day; an automated process will run that will take the previous days data and create only one row for each vehicle 
and save all locations in a json formatted string field in that row. 

## Extensibility

As code first approach is taken; If the customer wants to store more properties; they can easily include them in the DataModels 
and run the migrations to push those changes to DB level. As automapper is used; the returned data will be mapped accordingly.

## Security 
A JWT based authentication (yet to be implemented) will ensure that the user is authenticated and has required permission to create
or update an entry.

## Instruction to run the projects

After ensuring all the necessary packages has been installed; The application is ready to go.
The implemented enpoints are - 

	user/GetAllUsers
	user/GetUserById/{id}
	user/CreateUser [Post Endpoint]

	vehicle/GetAllUsers
	vehicle/GetVehicleById/{id}
	vehicle/CreateVehicle [Post Endpoint]

	trackingCurrent/GetAllTrackingCurrents
	trackingCurrent/GetTrackingCurrentById/{id}
	trackingCurrent/CreateTrackingCurrent [Post Endpoint]
