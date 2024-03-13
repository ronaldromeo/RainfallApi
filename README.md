# RainfallApi
Description of the project:
- This is a test project to get the rainfall data. This is written in C# and is using .net core 6. The rainfall data are provided by the Department of Environment FOod & Rural Affairs which can be accessed thru this url: https://environment.data.gov.uk/flood-monitoring/doc/rainfall#api-summary. 

Dependencies:
- Visual Studio 2022 Community edition for the IDE
- An internet conections since this consumes a 3rd party API.
- NUGet Packages:
   1. Newtonsoft.Json (13.0.3)
   2. Swashbuckle.AspNetCore (6.5.0)
   3. Swashbuckle.AspNetCore.Annotations (6.5.0)
   4. Swashbuckle.AspNetCore.Swagger (6.5.0)
   5. Swashbuckle.AspNetCore.SwaggerGen (6.5.0)
   6.  Swashbuckle.AspNetCore.SwaggerUI (6.5.0)

How to run the project:
  1. Download the Rainfall.zip. Extract it on your local machine.
  2. Open the RainfallApi solution (RainfallApi.sln) in Visual Studio.
  3. Rebuild it. Make sure that there are no exceptions. If there are problems during building you may need to downloaded the following NUGet packages from the list above.
  4. After a successful build run it. You should be seeing the swagger page.
  5. In the swagger expand the node Rainfall GET. Click Try it out.
  6. Click Try it out then enter a valid stationId: 3680, the count parameter is optional. If you don't enter anything in the count, it will default to 10.
  7. You should be getting a response Ok (200) and the list of the data.
     
- Instructions to test:
  1. From visual studio (ide) click on Test then Test Explorer.

  ![Uploading image.png…]()
  2. You should be seeing that in the test explorer.
  3. Click on the yellow > button to run the test.
  
  
